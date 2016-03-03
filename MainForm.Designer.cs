namespace SpriteImages
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UXMainMenu = new System.Windows.Forms.MenuStrip();
            this.UXFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UXSelectImages = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.UXSelectTargetDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.UXExit = new System.Windows.Forms.ToolStripMenuItem();
            this.UXTools = new System.Windows.Forms.ToolStripMenuItem();
            this.UXGenerateCSS = new System.Windows.Forms.ToolStripMenuItem();
            this.UXHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.UXAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.UXSelectImagesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UXSelectImgs = new System.Windows.Forms.Button();
            this.UXBrowseTarget = new System.Windows.Forms.Button();
            this.UXGenerateSprite = new System.Windows.Forms.Button();
            this.UXSourceImageText = new System.Windows.Forms.TextBox();
            this.UXTargetDirText = new System.Windows.Forms.TextBox();
            this.UXMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UXMainMenu
            // 
            this.UXMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UXFileMenu,
            this.UXTools,
            this.UXHelp});
            this.UXMainMenu.Location = new System.Drawing.Point(0, 0);
            this.UXMainMenu.Name = "UXMainMenu";
            this.UXMainMenu.Size = new System.Drawing.Size(427, 24);
            this.UXMainMenu.TabIndex = 0;
            this.UXMainMenu.Text = "menuStrip1";
            // 
            // UXFileMenu
            // 
            this.UXFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UXSelectImages,
            this.toolStripMenuItem1,
            this.UXSelectTargetDirectory,
            this.toolStripMenuItem2,
            this.UXExit});
            this.UXFileMenu.Name = "UXFileMenu";
            this.UXFileMenu.Size = new System.Drawing.Size(37, 20);
            this.UXFileMenu.Text = "&File";
            // 
            // UXSelectImages
            // 
            this.UXSelectImages.Name = "UXSelectImages";
            this.UXSelectImages.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.UXSelectImages.Size = new System.Drawing.Size(232, 22);
            this.UXSelectImages.Text = "&Select Images";
            this.UXSelectImages.Click += new System.EventHandler(this.SelectImages);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // UXSelectTargetDirectory
            // 
            this.UXSelectTargetDirectory.Name = "UXSelectTargetDirectory";
            this.UXSelectTargetDirectory.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.UXSelectTargetDirectory.Size = new System.Drawing.Size(232, 22);
            this.UXSelectTargetDirectory.Text = "Select &Target Directory";
            this.UXSelectTargetDirectory.Click += new System.EventHandler(this.SelectTargetDirectory);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(229, 6);
            // 
            // UXExit
            // 
            this.UXExit.Name = "UXExit";
            this.UXExit.Size = new System.Drawing.Size(232, 22);
            this.UXExit.Text = "Exit";
            this.UXExit.Click += new System.EventHandler(this.ExitApp);
            // 
            // UXTools
            // 
            this.UXTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UXGenerateCSS});
            this.UXTools.Name = "UXTools";
            this.UXTools.Size = new System.Drawing.Size(47, 20);
            this.UXTools.Text = "&Tools";
            // 
            // UXGenerateCSS
            // 
            this.UXGenerateCSS.Name = "UXGenerateCSS";
            this.UXGenerateCSS.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.UXGenerateCSS.Size = new System.Drawing.Size(173, 22);
            this.UXGenerateCSS.Text = "&Generate Sprite";
            this.UXGenerateCSS.Click += new System.EventHandler(this.GenerateCSS);
            // 
            // UXHelp
            // 
            this.UXHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UXAbout});
            this.UXHelp.Name = "UXHelp";
            this.UXHelp.Size = new System.Drawing.Size(44, 20);
            this.UXHelp.Text = "&Help";
            // 
            // UXAbout
            // 
            this.UXAbout.Name = "UXAbout";
            this.UXAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.UXAbout.Size = new System.Drawing.Size(152, 22);
            this.UXAbout.Text = "&About";
            this.UXAbout.Click += new System.EventHandler(this.AboutApp);
            // 
            // UXSelectImagesLabel
            // 
            this.UXSelectImagesLabel.AutoSize = true;
            this.UXSelectImagesLabel.Location = new System.Drawing.Point(12, 45);
            this.UXSelectImagesLabel.Name = "UXSelectImagesLabel";
            this.UXSelectImagesLabel.Size = new System.Drawing.Size(78, 13);
            this.UXSelectImagesLabel.TabIndex = 1;
            this.UXSelectImagesLabel.Text = "&Source Images";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Target Directory";
            // 
            // UXSelectImgs
            // 
            this.UXSelectImgs.Location = new System.Drawing.Point(313, 40);
            this.UXSelectImgs.Name = "UXSelectImgs";
            this.UXSelectImgs.Size = new System.Drawing.Size(91, 23);
            this.UXSelectImgs.TabIndex = 3;
            this.UXSelectImgs.Text = "&Select";
            this.UXSelectImgs.UseVisualStyleBackColor = true;
            this.UXSelectImgs.Click += new System.EventHandler(this.SelectImages);
            // 
            // UXBrowseTarget
            // 
            this.UXBrowseTarget.Location = new System.Drawing.Point(313, 74);
            this.UXBrowseTarget.Name = "UXBrowseTarget";
            this.UXBrowseTarget.Size = new System.Drawing.Size(91, 23);
            this.UXBrowseTarget.TabIndex = 3;
            this.UXBrowseTarget.Text = "&Browse";
            this.UXBrowseTarget.UseVisualStyleBackColor = true;
            this.UXBrowseTarget.Click += new System.EventHandler(this.SelectTargetDirectory);
            // 
            // UXGenerateSprite
            // 
            this.UXGenerateSprite.Location = new System.Drawing.Point(145, 114);
            this.UXGenerateSprite.Name = "UXGenerateSprite";
            this.UXGenerateSprite.Size = new System.Drawing.Size(143, 23);
            this.UXGenerateSprite.TabIndex = 4;
            this.UXGenerateSprite.Text = "&Generate Sprite";
            this.UXGenerateSprite.UseVisualStyleBackColor = true;
            this.UXGenerateSprite.Click += new System.EventHandler(this.GenerateCSS);
            // 
            // UXSourceImageText
            // 
            this.UXSourceImageText.Location = new System.Drawing.Point(102, 42);
            this.UXSourceImageText.Name = "UXSourceImageText";
            this.UXSourceImageText.ReadOnly = true;
            this.UXSourceImageText.Size = new System.Drawing.Size(205, 20);
            this.UXSourceImageText.TabIndex = 5;
            // 
            // UXTargetDirText
            // 
            this.UXTargetDirText.Location = new System.Drawing.Point(102, 76);
            this.UXTargetDirText.Name = "UXTargetDirText";
            this.UXTargetDirText.ReadOnly = true;
            this.UXTargetDirText.Size = new System.Drawing.Size(205, 20);
            this.UXTargetDirText.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 154);
            this.Controls.Add(this.UXTargetDirText);
            this.Controls.Add(this.UXSourceImageText);
            this.Controls.Add(this.UXGenerateSprite);
            this.Controls.Add(this.UXBrowseTarget);
            this.Controls.Add(this.UXSelectImgs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UXSelectImagesLabel);
            this.Controls.Add(this.UXMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.UXMainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpriteImages";
            this.UXMainMenu.ResumeLayout(false);
            this.UXMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip UXMainMenu;
        private System.Windows.Forms.ToolStripMenuItem UXFileMenu;
        private System.Windows.Forms.ToolStripMenuItem UXSelectImages;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UXSelectTargetDirectory;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem UXExit;
        private System.Windows.Forms.ToolStripMenuItem UXTools;
        private System.Windows.Forms.ToolStripMenuItem UXGenerateCSS;
        private System.Windows.Forms.ToolStripMenuItem UXHelp;
        private System.Windows.Forms.ToolStripMenuItem UXAbout;
        private System.Windows.Forms.Label UXSelectImagesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UXSelectImgs;
        private System.Windows.Forms.Button UXBrowseTarget;
        private System.Windows.Forms.Button UXGenerateSprite;
        private System.Windows.Forms.TextBox UXSourceImageText;
        private System.Windows.Forms.TextBox UXTargetDirText;
    }
}

