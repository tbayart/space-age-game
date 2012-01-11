using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Threading;


namespace AccountingUpdater
{
    public partial class Updater : Form
    {
        bool continuecheck;
        public Updater()
        {
            InitializeComponent();
        }

        private void Updater_Load(object sender, EventArgs e)
        {
 

            Thread.Sleep(3000);
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string line="";
            StreamReader file = new StreamReader(Application.StartupPath + "\\update.ver");
            file.ReadLine();
            continuecheck = true;
            while (true)
            {
                if (continuecheck == true )
                {
                    if ((line = file.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        string[] parts = line.Split(';');
                        string filename = parts[0];
                        string fileurl = parts[1];
                        Download(fileurl, filename);

                    }
                    else
                    {
                        MessageBox.Show("Finished");
                        File.Copy(Application.StartupPath+"\\update.ver", Application.StartupPath+"\\current.ver", true);
                        Process.Start(Application.StartupPath + "\\Acounting.EXE");
                        Application.Exit();

                    }
                    
                }
               

            }

        }

 
            private void Download(string url,string file)
            {
                 continuecheck = false;
                  WebClient webClient = new WebClient();
                  webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                  webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                  webClient.DownloadFileAsync(new Uri(url),file);
            }

            private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
            {
                  continuecheck = false;
                  backgroundWorker1.ReportProgress(e.ProgressPercentage);
            }
         


            private void Completed(object sender, AsyncCompletedEventArgs e)
            {
                   continuecheck = true;
                   
            }

            private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
            {
                progressBar1.Value = e.ProgressPercentage;
            }

            private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
            {
                progressBar1.Value = 0;
            }

    }
}

