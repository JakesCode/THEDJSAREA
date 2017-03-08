namespace THEDJSAREA
{
    partial class ArtworkSearch
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
            this.artworkSearchWindow = new System.Windows.Forms.WebBrowser();
            this.url = new System.Windows.Forms.TextBox();
            this.retryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // artworkSearchWindow
            // 
            this.artworkSearchWindow.Location = new System.Drawing.Point(0, 47);
            this.artworkSearchWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.artworkSearchWindow.Name = "artworkSearchWindow";
            this.artworkSearchWindow.ScriptErrorsSuppressed = true;
            this.artworkSearchWindow.Size = new System.Drawing.Size(724, 420);
            this.artworkSearchWindow.TabIndex = 0;
            this.artworkSearchWindow.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.artworkSearchWindow_DocumentCompleted);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(13, 15);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(614, 20);
            this.url.TabIndex = 1;
            // 
            // retryBtn
            // 
            this.retryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryBtn.Location = new System.Drawing.Point(633, 10);
            this.retryBtn.Name = "retryBtn";
            this.retryBtn.Size = new System.Drawing.Size(75, 28);
            this.retryBtn.TabIndex = 2;
            this.retryBtn.Text = "Retry";
            this.retryBtn.UseVisualStyleBackColor = true;
            this.retryBtn.Click += new System.EventHandler(this.retryBtn_Click);
            // 
            // ArtworkSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 467);
            this.Controls.Add(this.retryBtn);
            this.Controls.Add(this.url);
            this.Controls.Add(this.artworkSearchWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArtworkSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ArtworkSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.WebBrowser artworkSearchWindow;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Button retryBtn;
    }
}