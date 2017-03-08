namespace THEDJSAREA
{
    partial class Downloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Downloader));
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.filesCDNDownloader = new System.ComponentModel.BackgroundWorker();
            this.downloadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(13, 13);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(512, 55);
            this.downloadProgress.TabIndex = 0;
            this.downloadProgress.Click += new System.EventHandler(this.downloadProgress_Click);
            // 
            // filesCDNDownloader
            // 
            this.filesCDNDownloader.WorkerReportsProgress = true;
            this.filesCDNDownloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.filesCDNDownloader_DoWork);
            this.filesCDNDownloader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.filesCDNDownloader_ProgressChanged);
            this.filesCDNDownloader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.filesCDNDownloader_RunWorkerCompleted);
            // 
            // downloadingLabel
            // 
            this.downloadingLabel.AutoSize = true;
            this.downloadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadingLabel.Location = new System.Drawing.Point(8, 79);
            this.downloadingLabel.Name = "downloadingLabel";
            this.downloadingLabel.Size = new System.Drawing.Size(159, 20);
            this.downloadingLabel.TabIndex = 1;
            this.downloadingLabel.Text = "Now Downloading....";
            this.downloadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(537, 114);
            this.Controls.Add(this.downloadingLabel);
            this.Controls.Add(this.downloadProgress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Downloader";
            this.Text = "Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker filesCDNDownloader;
        public System.Windows.Forms.Label downloadingLabel;
        public System.Windows.Forms.ProgressBar downloadProgress;
    }
}