using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace THEDJSAREA
{
    public partial class Downloader : Form
    {
        public Downloader()
        {
            InitializeComponent();
            filesCDNDownloader.RunWorkerAsync();
        }

        public string URLToDownload = "";
        public string saveTo = "";
        public string filename = "";
        public bool status = false;

        private void filesCDNDownloader_DoWork(object sender, DoWorkEventArgs e)
        {
            if(filename == "")
            {
                MessageBox.Show("Test");
            } else
            {
                try
                {
                    downloadingLabel.Text = "Now Downloading: " + filename;

                    System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(URLToDownload);
                    System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
                    response.Close();
                    long iSize = response.ContentLength;

                    long iRunningByteTotal = 0;
                    WebClient client = new WebClient();
                    Stream strRemote = client.OpenRead(URLToDownload);
                    FileStream strLocal = new FileStream(saveTo, FileMode.Create, FileAccess.Write, FileShare.None);
                    int iByteSize = 0;
                    byte[] byteBuffer = new byte[1024];

                    while ((iByteSize = strRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                    {
                        strLocal.Write(byteBuffer, 0, iByteSize);
                        iRunningByteTotal += iByteSize;
                        double dIndex = (double)(iRunningByteTotal);
                        double dTotal = (double)iSize;
                        double dProgressPercentage = (dIndex / dTotal);
                        int iProgressPercentage = (int)(dProgressPercentage * 100);
                        filesCDNDownloader.ReportProgress(iProgressPercentage);
                    }

                    strRemote.Close();
                    status = true;
                }
                catch
                {

                }
            }

            
            
        }

        private void filesCDNDownloader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            downloadProgress.Value = e.ProgressPercentage;
        }

        private void filesCDNDownloader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(status)
            {
                this.Close();
            } else
            {
                GC.Collect();
            }
        }

        private void downloadProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
