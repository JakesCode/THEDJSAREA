using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using TagLib;
using System.Net;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace THEDJSAREA
{
    public partial class TheDjsArea : Form
    {
        public TheDjsArea()
        {
            InitializeComponent();
            System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"artwork");
            System.IO.DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"artwork");
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            artwork.LoadCompleted += Artwork_LoadCompleted;
            imgIndex.Text = "Image Index: " + imageIndex.ToString();;
        }

        public string artworkFolderPath = AppDomain.CurrentDomain.BaseDirectory + @"artwork";

        public string correctURL = "";

        private void Artwork_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            WebClient webClient = new WebClient();
            string filename = Path.GetFileName(currentFileName).Replace(" - ", "").Replace(" ", "").Replace(".mp3", "").Replace("(", "").Replace(")", "") + ".jpg";
            try
            {
                webClient.DownloadFile(correctURL, artworkFolderPath + @"\" + filename);
            }
            catch
            {
            }
        }

        public string currentFileName = "";
        public string currentMonthValue = DateTime.Now.ToString("MM");
        public int imageIndex = 0;
        public bool canContinue = false;

        private void openFilesBtn_Click(object sender, EventArgs e)
        {
            filesCompleted.Controls.Clear();
            openFiles.Multiselect = true;
            openFiles.ShowDialog();
            canContinue = true;
            int amountOfFilesLeft = openFiles.FileNames.Length;
            xpos = 0;
            foreach (var file in openFiles.FileNames)
            {
                if(canContinue)
                {
                    filesLeft.Text = "Files Left: " + amountOfFilesLeft.ToString();
                    canContinue = false;
                    fileName.Text = file;

                    // Reset variables //
                    currentFileName = "";
                    progressGIF.Visible = true;
                    finished.Visible = false;
                    artwork2.Visible = false;
                    playTrackBtn.Enabled = false;
                    searchingWeb.Visible = false;

                    getFileInformation(file);
                    editID3(currentFileName);
                    amountOfFilesLeft--;
                }
            }
        }

        private void getFileInformation(string file)
        {
            string fileName = Path.GetFileName(file);
            currentFileName = file;

            // Now begins the tricky bit //
            // Firstly, we need to remove certain characters from the filename //
            fileName = fileName.Replace(" - ", " ");
            fileName = fileName.Replace(" & ", " ");
            fileName = fileName.Replace("(", "");
            fileName = fileName.Replace(")", "");
            fileName = fileName.Replace(" ", "-");
            string artworkURL = fileName.Replace(".mp3", ".jpg");

            // We now (hopefully) have the album artwork URL on TheDJsArea //

            correctURL = "http://www.thedjsarea.com/wp-content/uploads/2017/" + currentMonthValue + "/" + artworkURL;

            artwork.ImageLocation = correctURL;
        }

        public int xpos = 0;

        public void editID3(string currentFileName)
        {
            // Let's begin to edit the ID3. //
            TagLib.File currentFile = TagLib.File.Create(currentFileName);

            // We need to remove the extension, first. //
            string trackNameFull = Path.GetFileName(currentFileName).Replace(".mp3", "");

            // Let's split the filename into the artists, and then the track name. //
            var trackNameElements = trackNameFull.Split(new[] {'-', '–'});

            string artist = trackNameElements[0];
            string track = trackNameElements[1];
            
            // Add the ID3 //

            currentFile.Tag.Title = track.TrimEnd().TrimStart();
            currentFile.Tag.AlbumArtists = new[] { artist.TrimEnd().TrimStart() };
            currentFile.Tag.Performers = new[] { artist.TrimEnd().TrimStart() };
            currentFile.Tag.Album = track.TrimEnd().TrimStart();
            currentFile.Tag.Year = 2017;
            currentFile.Tag.Track = 1;
            currentFile.Tag.Genres = new[] { "House" };
            currentFile.Tag.Comment = "";
            currentFile.Tag.Composers = new[] { artist.TrimEnd().TrimStart() };
            currentFile.Tag.Copyright = "";
            currentFile.Tag.Disc = 1;

            // Get the artwork //
            // Work backwards to see what we called the image above //

            try
            {
                string filename = Path.GetFileName(currentFileName).Replace(" - ", "").Replace(" ", "").Replace(".mp3", "").Replace("(", "").Replace(")", "") + ".jpg";
                IPicture newArt = new Picture(artworkFolderPath + @"\" + filename);
                currentFile.Tag.Pictures = new IPicture[1] { newArt };

                PictureBox completedImageBox = new PictureBox() { Location = new System.Drawing.Point(xpos, 0), Width = 50, Height = 50, SizeMode = PictureBoxSizeMode.Zoom, ImageLocation = artworkFolderPath + @"\" + filename, BorderStyle = BorderStyle.FixedSingle };
                filesCompleted.Controls.Add(completedImageBox);
                xpos += 57;
            }
            catch
            {
                searchingWeb.Visible = true;
                //Clipboard.SetText(correctURL);
                //MessageBox.Show("Couldn't find the artwork. Please navigate to it in the following window.", "Search for artwork", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ArtworkSearch artworkSearchWindow = new ArtworkSearch();

                // Search TheDJsArea //
                artworkSearchWindow.trackName = Path.GetFileName(currentFileName);
                artworkSearchWindow.artworkSearchWindow.Navigate("http://www.thedjsarea.com/?s=" + Path.GetFileName(currentFileName).Substring(0, 20).Replace("–", " ").Replace("–", " ").Replace(" ", "+").Trim());
                artworkSearchWindow.Opacity = 0;
                artworkSearchWindow.imageIndex = imageIndex;
                artworkSearchWindow.ShowDialog();

                // Get actual URL from form //
                string actualArtworkUrl = artworkSearchWindow.actualImageURL;
                artwork2.Visible = true;
                artwork2.ImageLocation = actualArtworkUrl;
                artworkSearchWindow.Dispose();

                // Now set the image in the ID3 //
                string filename = Path.GetFileName(currentFileName).Replace(" - ", "").Replace(" ", "").Replace(".mp3", "").Replace("(", "").Replace(")", "") + ".jpg";
                WebClient webClient = new WebClient();
                try
                {
                    webClient.DownloadFile(actualArtworkUrl, artworkFolderPath + @"\" + filename);
                    IPicture newArt = new Picture(artworkFolderPath + @"\" + filename);
                    currentFile.Tag.Pictures = new IPicture[1] { newArt };

                    PictureBox completedImageBox = new PictureBox() { Location = new System.Drawing.Point(xpos, 0), Width = 50, Height = 50, SizeMode = PictureBoxSizeMode.Zoom, ImageLocation = artworkFolderPath + @"\" + filename, BorderStyle = BorderStyle.FixedSingle };
                    filesCompleted.Controls.Add(completedImageBox);
                    xpos += 57;
                }
                catch
                {
                }
                
            }

            // Save the new ID3 tags //

            try
            {
                currentFile.Save();
            } catch
            {
                MessageBox.Show("This file is in use.");
            }
            
            progressGIF.Visible = false;
            finished.Visible = true;
            playTrackBtn.Enabled = true;
            searchingWeb.Visible = false;
            canContinue = true;
        }

        private void playTrackBtn_Click(object sender, EventArgs e)
        {
            Process playTrack = new Process();
            playTrack.StartInfo.FileName = currentFileName;
            playTrack.Start();
        }

        private void wrongAlbumArtBtn_Click(object sender, EventArgs e)
        {
            openSingle.Reset();

            artwork.Image = null;
            imageIndex++;
            imgIndex.Text = "Image Index: " + imageIndex.ToString();

            openSingle.Multiselect = false;
            openSingle.ShowDialog();
            getFileInformation(openSingle.FileName);
            //editID3(currentFileName);
        }

        private void refreshIcon_Click(object sender, EventArgs e)
        {
            imageIndex = 0;
            imgIndex.Text = "Image Index: " + imageIndex.ToString();
        }

        private void fixFilenameBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove random en and em dashes //
                string fileNameToFix = fileName.Text;
                string fileNameFixed = fileNameToFix.Replace("—", "-").Replace("–", "-");
                System.IO.File.Move(fileNameToFix, fileNameFixed);
            }
            catch
            {
                MessageBox.Show("Unknown Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<string> trackImages = new List<string>();
        public static List<string> trackLinks = new List<string>();

        public int publicImgIndex = 0;
        public int publicLinkIndex = 8;
        public int page = 1;

        private void trackBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            trackImages = new List<string>();
            trackLinks = new List<string>();

            trackBrowser.Focus();
            SendKeys.Send("^0");
            SendKeys.Send("^-");
            SendKeys.Send("^-");

            if (trackBrowser.Url.ToString() == "http://www.thedjsarea.com/")
            {
                scrapePanel.Controls.Clear();
                for (int image = publicImgIndex; image < publicImgIndex + 12; image++)
                {
                    //MessageBox.Show(trackImages.Count.ToString());
                    trackImages.Add(trackBrowser.Document.Body.GetElementsByTagName("IMG")[image].GetAttribute("data-lazysrc"));
                }

                for (int link = publicLinkIndex; link < publicLinkIndex + 12; link++)
                {
                    //MessageBox.Show(trackLinks.Count.ToString());
                    trackLinks.Add(trackBrowser.Document.Body.GetElementsByTagName("A")[link].GetAttribute("href"));
                }

                int xpos = 0;

                for (int image = 0; image < 12; image++)
                {
                    PictureBox trackImagePictureBox = new PictureBox() { Location = new System.Drawing.Point(xpos, 15), Width = 75, Height = 75, SizeMode = PictureBoxSizeMode.Zoom, ImageLocation = trackImages[image], BorderStyle = BorderStyle.FixedSingle, Tag = trackLinks[image] };
                    trackImagePictureBox.Click += new EventHandler(this.HandleButtonClick);
                    scrapePanel.Controls.Add(trackImagePictureBox);
                    xpos += 77;
                }
            } else if (trackBrowser.Url.ToString().StartsWith("https://filescdn") || trackBrowser.Url.ToString().StartsWith("http://filescdn"))
            {
                var fileName = trackBrowser.Document.Body.GetElementsByTagName("h6")[0].InnerText.TrimStart().Replace(".mp3", "");

                Regex regex = new Regex(@"\$\(this\).jPlayer\(""setMedia"", {mp3:\""https:\/\/[a-z]+.filescdn.com.\d{3}\/.\/.{72}\/.{12}.mp3""\}\);");
                string pageHTML = trackBrowser.DocumentText;
                Match match = regex.Match(pageHTML);
                if (match.Success)
                {
                    string fileURL = match.Value.Replace(@"$(this).jPlayer(""setMedia"", {mp3:""", "").Replace(@"""});", "");
                    System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"music");
                    Downloader downloadBox = new Downloader();
                    downloadBox.URLToDownload = fileURL;
                    downloadBox.saveTo = @"C:\Users\Jake (King of Cool)\Desktop\New Music\" + fileName + ".mp3";
                    downloadBox.filename = fileName;
                    Clipboard.SetText(downloadBox.URLToDownload);
                    downloadBox.ShowDialog();
                    trackBrowser.Navigate("http://www.thedjsarea.com/");
                    downloadBox.Hide();
                    downloadBox.Dispose();
                    downloadBox.Close();  
                }
            } else
            {
                foreach (HtmlElement item in trackBrowser.Document.Body.GetElementsByTagName("A"))
                {
                    if (item.GetAttribute("href").StartsWith("https://www.filescdn") || item.GetAttribute("href").StartsWith("https://filescdn"))
                    {
                        // We've found the download link! //
                        //MessageBox.Show(item.GetAttribute("href"));
                        trackBrowser.Navigate(item.GetAttribute("href"));
                    }
                }
            }
        }

        void HandleButtonClick(object sender, EventArgs e)
        {
            trackBrowser.Navigate(((System.Windows.Forms.PictureBox)sender).Tag.ToString());
            trackBrowser.Focus();
        }

        private void trackBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            if(!(trackBrowser.Url.ToString().StartsWith("https://www.filescdn")) || !(trackBrowser.Url.ToString().StartsWith("http://www.thedjsarea")))
            {
                e.Cancel = true;
            }
        }

        private void pageUp_Click(object sender, EventArgs e)
        {
            if(!(publicImgIndex == 0 && publicLinkIndex == 8))
            {
                page = page -= 1;
                pageLabel.Text = "Page " + page.ToString();
                scrapePanel.Controls.Clear();
                publicImgIndex = publicImgIndex -= 12;
                publicLinkIndex = publicLinkIndex -= 12;
                trackBrowser.Navigate("http://www.thedjsarea.com/");
            }
        }

        private void pageDown_Click(object sender, EventArgs e)
        {
            page = page += 1;
            pageLabel.Text = "Page " + page.ToString();
            scrapePanel.Controls.Clear();
            publicImgIndex = publicImgIndex += 12;
            publicLinkIndex = publicLinkIndex += 12;
            trackBrowser.Navigate("http://www.thedjsarea.com/");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchTerm.Text.Length > 0)
            {
                trackBrowser.Navigate("http://www.thedjsarea.com/?s=" + searchTerm.Text.Replace(" ", " +"));
                searchTerm.Text = "";
            }
        }
    }
}
