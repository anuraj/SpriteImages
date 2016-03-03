using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SpriteImages
{
    public partial class MainForm : Form
    {
        private string[] _files;
        private string _targetDirectory;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectImages(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif";
                openFileDialog.Multiselect = true;
                openFileDialog.ShowReadOnly = false;
                openFileDialog.ShowHelp = false;
                openFileDialog.Title = "Select Images for creating Sprite Image";
                openFileDialog.CheckFileExists = true;
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    _files = openFileDialog.FileNames;
                    UXSourceImageText.Text = string.Format("{0} File(s) selected", _files.Length);
                }
            }
        }

        private void SelectTargetDirectory(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select Target directory for Sprite Image and CSS";
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
                {
                    _targetDirectory = folderBrowserDialog.SelectedPath;
                    UXTargetDirText.Text = _targetDirectory;
                }
            }
        }

        private void ExitApp(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void GenerateCSS(object sender, EventArgs e)
        {
            GenerateSprite(_files, _targetDirectory);
        }

        private void AboutApp(object sender, EventArgs e)
        {
            var about = string.Format("SpriteImages v{0}{1}https://github.com/anuraj/SpriteImages",
                Assembly.GetExecutingAssembly().GetName().Version, Environment.NewLine);
            MessageBox.Show(about, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static void CreateCSS(List<Style> styles, string targetDirectory)
        {
            var cssFile = Path.Combine(targetDirectory, "style.css");
            using (var streamWriter = new StreamWriter(cssFile, false))
            {
                foreach (var style in styles)
                {
                    streamWriter.WriteLine(style.ToString());
                }
            }
        }
        private static void GenerateSprite(string[] files, string targetDirectory)
        {
            var images = new List<Bitmap>();
            var styles = new List<Style>();
            Bitmap finalImage = null;

            try
            {
                int width = 0;
                int height = 0;

                foreach (string image in files)
                {
                    var bitmap = new Bitmap(image);
                    bitmap.Tag = image;
                    width += bitmap.Width;
                    height = bitmap.Height > height ? bitmap.Height : height;
                    images.Add(bitmap);
                }

                finalImage = new Bitmap(width, height);
                using (Graphics graphics = Graphics.FromImage(finalImage))
                {
                    graphics.Clear(Color.Transparent);
                    int offset = 0;
                    foreach (var image in images)
                    {
                        graphics.DrawImage(image, new Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;

                        styles.Add(new Style
                        {
                            Height = image.Height,
                            Width = image.Width,
                            Name = image.Tag.ToString(),
                            Left = width - image.Width
                        });
                    }
                }

                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                finalImage.Save(Path.Combine(targetDirectory, "SpriteImage.png"), ImageFormat.Png);
                CreateCSS(styles, targetDirectory);
                MessageBox.Show("Generated sprite image and css successfully", "SpriteImages",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                if (finalImage != null)
                {
                    finalImage.Dispose();
                }

                throw;
            }
            finally
            {
                foreach (var image in images)
                {
                    image.Dispose();
                }
            }
        }
    }

    internal class Style
    {
        public string Name { private get; set; }
        public int Width { private get; set; }
        public int Height { private get; set; }
        public int Left { private get; set; }
        public bool UseClass { private get; set; }

        public override string ToString()
        {
            return string.Format("{4}{0} {{ width: {1}px; height: {2}px; background: url(SpriteImage.png) -{3}px 0;}}",
                Path.GetFileNameWithoutExtension(Name).ToLowerInvariant(), Width, Height, Left, UseClass ? "." : "#");
        }
    }
}
