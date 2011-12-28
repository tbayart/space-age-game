using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.Common;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace Acounting
{
    public partial class CreateDB : Form
    {
        public bool RunScript(string FileName)
        {


            using (StreamReader reader = new StreamReader(FileName))
            {

                MySqlCommand command;
                // Create a connection string without passing a database 
                string ConnectionString =
                                "server=localhost;User Id=root";

                MySqlConnection Connection = new MySqlConnection(ConnectionString);
                Connection.Open();
                try
                {


                    string line = "";
                    string l;
                    while (true)
                    {
                        // Clear line if its been used already 
                        if (line.EndsWith(";"))
                            line = "";

                        l = reader.ReadLine();

                        // is this eof? 
                        if (l == null) break;
                        // Trim off rubbish at end 
                        l = l.TrimEnd();
                        // Don't call if it's empty 
                        if (l == "") continue;
                        // If it's a comment dont call 
                        if (l.StartsWith("--")) continue;

                        // Add l to line 
                        line += l;
                        // Test for end of line character and continue reading if needed 
                        if (!line.EndsWith(";")) continue;

                        // mysql generated files start and end with series of commented out 
                        // lines. 
                        // These are not true comment out but are parsed by mysql to determine 
                        // the version number. If version higher than current version then they're 
                        // not run. So we need to remove the comment marks and pass the command 
                        // in. Im using mysql 5, so all valid 
                        if (line.StartsWith("/*!"))
                        {
                            if (line.EndsWith("*/;"))
                            {
                                int start = line.IndexOf(" ");
                                if (start == -1)
                                    continue;
                                line = line.Substring(start + 1);
                                line = line.Remove(line.Length - 4) + ";";
                            }
                            else continue;
                        }//if (line.StartsWith("/*!")) 

                        // Now we have a full line, run it in mysql 
                        command = new MySqlCommand(line, Connection);
                        command.ExecuteNonQuery();
                    }// while true 
                }
                finally
                {
                    Connection.Close();
                }
            }// using 

            return true;
        }// function

        public CreateDB()
        {
            InitializeComponent();
        }

        private void CreateDB_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
             
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 5;
            foreach (string item in Directory.EnumerateFiles("Sql"))
            {
                RunScript(item);
                backgroundWorker1.ReportProgress(i);
                i += 5;

            }
             
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Must Restart Program !!");
            
            this.Close();
            Application.Restart();
            
        }
    }
}
