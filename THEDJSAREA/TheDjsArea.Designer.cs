namespace THEDJSAREA
{
    partial class TheDjsArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheDjsArea));
            this.openFilesBtn = new System.Windows.Forms.Button();
            this.openFiles = new System.Windows.Forms.OpenFileDialog();
            this.artwork = new System.Windows.Forms.PictureBox();
            this.progressGIF = new System.Windows.Forms.PictureBox();
            this.finished = new System.Windows.Forms.PictureBox();
            this.artwork2 = new System.Windows.Forms.PictureBox();
            this.playTrackBtn = new System.Windows.Forms.Button();
            this.searchingWeb = new System.Windows.Forms.PictureBox();
            this.wrongAlbumArtBtn = new System.Windows.Forms.Button();
            this.imgIndex = new System.Windows.Forms.Label();
            this.openSingle = new System.Windows.Forms.OpenFileDialog();
            this.refreshIcon = new System.Windows.Forms.PictureBox();
            this.fixFilenameBtn = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.trackBrowser = new System.Windows.Forms.WebBrowser();
            this.scrapePanel = new System.Windows.Forms.Panel();
            this.pageUp = new System.Windows.Forms.PictureBox();
            this.pageDown = new System.Windows.Forms.PictureBox();
            this.filesLeft = new System.Windows.Forms.Label();
            this.filesCompleted = new System.Windows.Forms.Panel();
            this.searchTerm = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.artwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artwork2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchingWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageDown)).BeginInit();
            this.SuspendLayout();
            // 
            // openFilesBtn
            // 
            this.openFilesBtn.Location = new System.Drawing.Point(12, 12);
            this.openFilesBtn.Name = "openFilesBtn";
            this.openFilesBtn.Size = new System.Drawing.Size(114, 37);
            this.openFilesBtn.TabIndex = 0;
            this.openFilesBtn.Text = "Open Files";
            this.openFilesBtn.UseVisualStyleBackColor = true;
            this.openFilesBtn.Click += new System.EventHandler(this.openFilesBtn_Click);
            // 
            // openFiles
            // 
            this.openFiles.Multiselect = true;
            this.openFiles.Title = "Select Music";
            // 
            // artwork
            // 
            this.artwork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.artwork.Location = new System.Drawing.Point(132, 12);
            this.artwork.Name = "artwork";
            this.artwork.Size = new System.Drawing.Size(400, 400);
            this.artwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.artwork.TabIndex = 1;
            this.artwork.TabStop = false;
            // 
            // progressGIF
            // 
            this.progressGIF.Image = ((System.Drawing.Image)(resources.GetObject("progressGIF.Image")));
            this.progressGIF.Location = new System.Drawing.Point(12, 71);
            this.progressGIF.Name = "progressGIF";
            this.progressGIF.Size = new System.Drawing.Size(54, 67);
            this.progressGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.progressGIF.TabIndex = 2;
            this.progressGIF.TabStop = false;
            this.progressGIF.Visible = false;
            // 
            // finished
            // 
            this.finished.Image = ((System.Drawing.Image)(resources.GetObject("finished.Image")));
            this.finished.Location = new System.Drawing.Point(12, 144);
            this.finished.Name = "finished";
            this.finished.Size = new System.Drawing.Size(114, 85);
            this.finished.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finished.TabIndex = 3;
            this.finished.TabStop = false;
            this.finished.Visible = false;
            // 
            // artwork2
            // 
            this.artwork2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.artwork2.Location = new System.Drawing.Point(132, 12);
            this.artwork2.Name = "artwork2";
            this.artwork2.Size = new System.Drawing.Size(400, 400);
            this.artwork2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.artwork2.TabIndex = 6;
            this.artwork2.TabStop = false;
            this.artwork2.Visible = false;
            // 
            // playTrackBtn
            // 
            this.playTrackBtn.Enabled = false;
            this.playTrackBtn.Location = new System.Drawing.Point(12, 372);
            this.playTrackBtn.Name = "playTrackBtn";
            this.playTrackBtn.Size = new System.Drawing.Size(114, 37);
            this.playTrackBtn.TabIndex = 7;
            this.playTrackBtn.Text = "Play Track";
            this.playTrackBtn.UseVisualStyleBackColor = true;
            this.playTrackBtn.Click += new System.EventHandler(this.playTrackBtn_Click);
            // 
            // searchingWeb
            // 
            this.searchingWeb.Image = ((System.Drawing.Image)(resources.GetObject("searchingWeb.Image")));
            this.searchingWeb.Location = new System.Drawing.Point(72, 71);
            this.searchingWeb.Name = "searchingWeb";
            this.searchingWeb.Size = new System.Drawing.Size(54, 67);
            this.searchingWeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchingWeb.TabIndex = 8;
            this.searchingWeb.TabStop = false;
            this.searchingWeb.Visible = false;
            // 
            // wrongAlbumArtBtn
            // 
            this.wrongAlbumArtBtn.Location = new System.Drawing.Point(12, 235);
            this.wrongAlbumArtBtn.Name = "wrongAlbumArtBtn";
            this.wrongAlbumArtBtn.Size = new System.Drawing.Size(114, 37);
            this.wrongAlbumArtBtn.TabIndex = 9;
            this.wrongAlbumArtBtn.Text = "Wrong Album Art";
            this.wrongAlbumArtBtn.UseVisualStyleBackColor = true;
            this.wrongAlbumArtBtn.Click += new System.EventHandler(this.wrongAlbumArtBtn_Click);
            // 
            // imgIndex
            // 
            this.imgIndex.AutoSize = true;
            this.imgIndex.Location = new System.Drawing.Point(12, 281);
            this.imgIndex.Name = "imgIndex";
            this.imgIndex.Size = new System.Drawing.Size(108, 13);
            this.imgIndex.TabIndex = 10;
            this.imgIndex.Text = "Current Image Index: ";
            // 
            // openSingle
            // 
            this.openSingle.Title = "Open Single File";
            // 
            // refreshIcon
            // 
            this.refreshIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshIcon.Image = ((System.Drawing.Image)(resources.GetObject("refreshIcon.Image")));
            this.refreshIcon.Location = new System.Drawing.Point(91, 271);
            this.refreshIcon.Name = "refreshIcon";
            this.refreshIcon.Size = new System.Drawing.Size(35, 35);
            this.refreshIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshIcon.TabIndex = 11;
            this.refreshIcon.TabStop = false;
            this.refreshIcon.Click += new System.EventHandler(this.refreshIcon_Click);
            // 
            // fixFilenameBtn
            // 
            this.fixFilenameBtn.Location = new System.Drawing.Point(12, 306);
            this.fixFilenameBtn.Name = "fixFilenameBtn";
            this.fixFilenameBtn.Size = new System.Drawing.Size(114, 37);
            this.fixFilenameBtn.TabIndex = 12;
            this.fixFilenameBtn.Text = "Fix Filename";
            this.fixFilenameBtn.UseVisualStyleBackColor = true;
            this.fixFilenameBtn.Click += new System.EventHandler(this.fixFilenameBtn_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(12, 347);
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Size = new System.Drawing.Size(114, 20);
            this.fileName.TabIndex = 13;
            // 
            // trackBrowser
            // 
            this.trackBrowser.Location = new System.Drawing.Point(540, 89);
            this.trackBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.trackBrowser.Name = "trackBrowser";
            this.trackBrowser.ScriptErrorsSuppressed = true;
            this.trackBrowser.Size = new System.Drawing.Size(471, 297);
            this.trackBrowser.TabIndex = 14;
            this.trackBrowser.Url = new System.Uri("http://www.thedjsarea.com/", System.UriKind.Absolute);
            this.trackBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.trackBrowser_DocumentCompleted);
            this.trackBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.trackBrowser_NewWindow);
            // 
            // scrapePanel
            // 
            this.scrapePanel.Location = new System.Drawing.Point(15, 418);
            this.scrapePanel.Name = "scrapePanel";
            this.scrapePanel.Size = new System.Drawing.Size(953, 116);
            this.scrapePanel.TabIndex = 15;
            // 
            // pageUp
            // 
            this.pageUp.Image = ((System.Drawing.Image)(resources.GetObject("pageUp.Image")));
            this.pageUp.Location = new System.Drawing.Point(974, 419);
            this.pageUp.Name = "pageUp";
            this.pageUp.Size = new System.Drawing.Size(40, 40);
            this.pageUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pageUp.TabIndex = 16;
            this.pageUp.TabStop = false;
            this.pageUp.Click += new System.EventHandler(this.pageUp_Click);
            // 
            // pageDown
            // 
            this.pageDown.Image = ((System.Drawing.Image)(resources.GetObject("pageDown.Image")));
            this.pageDown.Location = new System.Drawing.Point(974, 465);
            this.pageDown.Name = "pageDown";
            this.pageDown.Size = new System.Drawing.Size(40, 40);
            this.pageDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pageDown.TabIndex = 17;
            this.pageDown.TabStop = false;
            this.pageDown.Click += new System.EventHandler(this.pageDown_Click);
            // 
            // filesLeft
            // 
            this.filesLeft.AutoSize = true;
            this.filesLeft.Location = new System.Drawing.Point(12, 52);
            this.filesLeft.Name = "filesLeft";
            this.filesLeft.Size = new System.Drawing.Size(0, 13);
            this.filesLeft.TabIndex = 18;
            this.filesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filesCompleted
            // 
            this.filesCompleted.AutoScroll = true;
            this.filesCompleted.Location = new System.Drawing.Point(539, 13);
            this.filesCompleted.Name = "filesCompleted";
            this.filesCompleted.Size = new System.Drawing.Size(472, 70);
            this.filesCompleted.TabIndex = 19;
            // 
            // searchTerm
            // 
            this.searchTerm.Location = new System.Drawing.Point(540, 392);
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.Size = new System.Drawing.Size(428, 20);
            this.searchTerm.TabIndex = 20;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(974, 391);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(40, 22);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "Go";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(973, 513);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(41, 13);
            this.pageLabel.TabIndex = 22;
            this.pageLabel.Text = "Page 1";
            this.pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TheDjsArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1019, 537);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTerm);
            this.Controls.Add(this.filesCompleted);
            this.Controls.Add(this.filesLeft);
            this.Controls.Add(this.pageDown);
            this.Controls.Add(this.pageUp);
            this.Controls.Add(this.scrapePanel);
            this.Controls.Add(this.trackBrowser);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.fixFilenameBtn);
            this.Controls.Add(this.refreshIcon);
            this.Controls.Add(this.imgIndex);
            this.Controls.Add(this.wrongAlbumArtBtn);
            this.Controls.Add(this.searchingWeb);
            this.Controls.Add(this.playTrackBtn);
            this.Controls.Add(this.artwork2);
            this.Controls.Add(this.finished);
            this.Controls.Add(this.progressGIF);
            this.Controls.Add(this.artwork);
            this.Controls.Add(this.openFilesBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TheDjsArea";
            this.Text = "Jake\'s DJsArea Scraper";
            ((System.ComponentModel.ISupportInitialize)(this.artwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artwork2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchingWeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFilesBtn;
        private System.Windows.Forms.OpenFileDialog openFiles;
        private System.Windows.Forms.PictureBox artwork;
        private System.Windows.Forms.PictureBox progressGIF;
        private System.Windows.Forms.PictureBox finished;
        private System.Windows.Forms.PictureBox artwork2;
        private System.Windows.Forms.Button playTrackBtn;
        private System.Windows.Forms.PictureBox searchingWeb;
        private System.Windows.Forms.Button wrongAlbumArtBtn;
        private System.Windows.Forms.Label imgIndex;
        private System.Windows.Forms.OpenFileDialog openSingle;
        private System.Windows.Forms.PictureBox refreshIcon;
        private System.Windows.Forms.Button fixFilenameBtn;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.WebBrowser trackBrowser;
        private System.Windows.Forms.Panel scrapePanel;
        private System.Windows.Forms.PictureBox pageUp;
        private System.Windows.Forms.PictureBox pageDown;
        private System.Windows.Forms.Label filesLeft;
        private System.Windows.Forms.Panel filesCompleted;
        private System.Windows.Forms.TextBox searchTerm;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label pageLabel;
    }
}

