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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                // Create a connection string without passing a database 
                string ConnectionString =
                                "server=localhost;User Id=root;database=store;charset=utf8";

                MySqlConnection Connection = new MySqlConnection(ConnectionString);


                Connection.Open();
            }
            catch (MySqlException ee)
            {
                if (ee.Message == "Unknown database 'store'")
                {

                    foreach (string item in Directory.EnumerateFiles("Sql"))
                    {
                        RunScript(item);
                    }

                }

            }

        }




        //
        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.MdiParent = this;
            items.Show();
        }


        private void agentDebtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Reports reports = new Reports();
            reports.MdiParent = this;
            reports.Show();
        }



        private void buyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.MdiParent = this;
            buy.Show();
        }

        private void paymentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.MdiParent = this;
            payments.Show();
        }

        private void vaultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vault vault = new Vault();
            vault.MdiParent = this;
            vault.Show();
        }

        private void sellToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReturnSell sell = new ReturnSell();
            sell.MdiParent = this;
            sell.Show();
        }

        private void dealersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dealers dealers = new Dealers();
            dealers.MdiParent = this;
            dealers.Show();
        }

        private void agentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Agents agents = new Agents();
            agents.MdiParent = this;
            agents.Show();
        }
    }
}
