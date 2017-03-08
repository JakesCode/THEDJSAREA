using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THEDJSAREA
{
    public partial class ArtworkSearch : Form
    {
        public ArtworkSearch()
        {
            InitializeComponent();
        }

        public string actualImageURL = "";
        public int imageIndex = 0;
        public string trackName = "";
        public int retries = 2;

        private void artworkSearchWindow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if(retries > 0)
            {
                retries--;

                url.Text = artworkSearchWindow.Url.ToString();
                if (artworkSearchWindow.Document.Body.GetElementsByTagName("img")[imageIndex].GetAttribute("src").Substring(0, 12) == "http://pixel")
                {
                    artworkSearchWindow.Navigate("http://www.thedjsarea.com/?s=" + trackName.Split(new[] { " - ", "–", "–" }, StringSplitOptions.None)[0].Replace("–", " ").Replace("–", "").Replace(" ", " +"));
                }
                else
                {
                    actualImageURL = artworkSearchWindow.Document.Body.GetElementsByTagName("img")[imageIndex].GetAttribute("src").Replace("-150x150", "");
                    this.Close();
                }
            } else
            {
                this.Close();
            }
        }

        private void retryBtn_Click(object sender, EventArgs e)
        {
            artworkSearchWindow.Navigate(url.Text);
            artworkSearchWindow.Focus();
        }
    }
}
