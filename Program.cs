using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace SpriteImages
{
    internal static class Program
    {
        private static void Main(string[] arguments)
        {
            var sourceDirectory = string.Empty;
            var targetDirectory = string.Empty;
            var useClass = false;
            if (arguments.Length == 0)
            {
                PrintHelp();
                return;
            }

            var sourcePosition = Array.FindIndex(arguments,
                t => t.Equals("--source", StringComparison.InvariantCultureIgnoreCase));
            if (sourcePosition >= 0)
            {
                sourceDirectory = arguments[sourcePosition + 1];
            }

            var targetPosition = Array.FindIndex(arguments,
                t => t.Equals("--target", StringComparison.InvariantCultureIgnoreCase));
            if (targetPosition >= 0)
            {
                targetDirectory = arguments[targetPosition + 1];
            }

            useClass =
                Array.FindIndex(arguments, t => t.Equals("--useClass", StringComparison.InvariantCultureIgnoreCase)) >=
                0;

            if (string.IsNullOrWhiteSpace(sourceDirectory))
            {
                PrintHelp();
                return;
            }

            if (string.IsNullOrWhiteSpace(targetDirectory))
            {
                targetDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "output");
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }
            }

            var files = new List<FileInfo>();
            var directory = new DirectoryInfo(sourceDirectory);
            files.AddRange(directory.GetFiles("*.png", SearchOption.AllDirectories));
            files.AddRange(directory.GetFiles("*.jpg", SearchOption.AllDirectories));
            files.AddRange(directory.GetFiles("*.gif", SearchOption.AllDirectories));

            CombineImages(files, targetDirectory, useClass);
        }

        private static void CombineImages(List<FileInfo> files, string targetDirectory, bool useClass)
        {
            var finalImage = Path.Combine(targetDirectory, "SpriteImage.png");
            var imageHeights = new List<int>();
            var styles = new List<Style>();
            var nIndex = 0;
            var width = 0;
            foreach (var file in files)
            {
                var img = Image.FromFile(file.FullName);

                imageHeights.Add(img.Height);
                width += img.Width;
                img.Dispose();
            }

            imageHeights.Sort();
            var height = imageHeights[imageHeights.Count - 1];
            var img3 = new Bitmap(width, height);
            var g = Graphics.FromImage(img3);
            g.Clear(Color.Transparent);
            foreach (var file in files)
            {
                var img = Image.FromFile(file.FullName);
                if (nIndex == 0)
                {
                    g.DrawImage(img, new Point(0, 0));
                    nIndex++;
                    width = img.Width;
                    styles.Add(new Style
                    {
                        Height = img.Height,
                        Width = img.Width,
                        Name = file.Name,
                        Left = 0,
                        UseClass = useClass
                    });
                }
                else
                {
                    g.DrawImage(img, new Point(width, 0));
                    width += img.Width;
                    styles.Add(new Style
                    {
                        Height = img.Height,
                        Width = img.Width,
                        Name = file.Name,
                        Left = width - img.Width,
                        UseClass = useClass
                    });
                }
                img.Dispose();
            }
            g.Dispose();
            img3.Save(finalImage, ImageFormat.Png);
            img3.Dispose();

            CreateCSS(targetDirectory, styles);
        }

        private static void CreateCSS(string targetDirectory, List<Style> styles)
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

        private static void PrintHelp()
        {
            Console.WriteLine("SpriteImages 0.1");
            Console.WriteLine("A utility to create Sprite images and CSS");
            Console.WriteLine("Usage : SpriteImages [options]");
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine(
                "--source <PATH> : Source images directory. Images with extension png, jpg, and gif will be used.");
            Console.WriteLine(
                "--target <PATH> : Target directory. Combined images and CSS will be saved in this directory");
            Console.WriteLine("--useClass : Generated CSS will using dot (.) instead of hash (#) ");
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