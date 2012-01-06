﻿using System;
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
using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;
using System.Net;
using System.Diagnostics;


namespace Acounting
{
    public partial class Main : Form
    {

        bool continuedata = true;

        public Main()
        {
            InitializeComponent();
        }
              

        private void Form1_Load(object sender, EventArgs e)
        {
            #region check for database

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
                    continuedata = false;
                    CreateDB create = new CreateDB();
                    create.MdiParent = this;
                    create.Show();



                }

            }
            #endregion

            #region check for values



            if (continuedata)
            {
                vaultTableAdapter.Fill(storeDataSet.vault);

                if (storeDataSet.vault.Count == 0)
                {
                    MessageBox.Show("يجب اضافة رصيد افتتاحي في الخزنة");

                    vaultToolStripMenuItem1_Click(null, null);
                }

                string imagepath = "";
                try
                {
                    imagepath = Application.UserAppDataRegistry.GetValue("Image").ToString();
                  //  pictureBox1.ImageLocation = imagepath;
          
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message);

                }
            }
           
            

            #endregion

            backgroundWorker1.RunWorkerAsync();



        }
        
        
        #region menu items


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.MdiParent = this;
            items.Show();
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
            Sell sell = new Sell();
            sell.MdiParent = this;
            sell.Show();
        }

     
        private void agentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Names names = new Names();
            names.MdiParent = this;
            names.Show();
        }

        private void staticAssetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticAssets staticassets = new StaticAssets();
            staticassets.MdiParent = this;
            staticassets.Show();
        }

        private void returnBuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBuy returnbuy = new ReturnBuy();
            returnbuy.MdiParent = this;
            returnbuy.Show();
        }

        private void returnSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnSales returnsales = new ReturnSales();
            returnsales.MdiParent = this;
            returnsales.Show();
        }


        private void حفظاسترجعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.cul.Name == "")
            {
                MySQL_Backup_and_Restore.Form1 form1 = new MySQL_Backup_and_Restore.Form1(null);
                form1.MdiParent = this;
                form1.Show();
            }
            else
            {
                MySQL_Backup_and_Restore.BackupAr barab = new MySQL_Backup_and_Restore.BackupAr(null);
                barab.MdiParent = this;
                barab.Show();
            }
        }



        private void عربيToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Program.cul = new CultureInfo("ar");

            Application.UserAppDataRegistry.SetValue("Language", "ar");

            FormLanguageSwitchSingleton.Instance.ChangeCurrentThreadUICulture(Program.cul);
            FormLanguageSwitchSingleton.Instance.ChangeLanguage(this);

        }

        private void englshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.cul = new CultureInfo("");

            FormLanguageSwitchSingleton.Instance.ChangeCurrentThreadUICulture(Program.cul);
            FormLanguageSwitchSingleton.Instance.ChangeLanguage(this);
            Application.UserAppDataRegistry.SetValue("Language",
          "");
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {

                DialogResult dr = MessageBox.Show("هل تريد  حذف قاعدة  البيانات؟؟", "", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    MySqlCommand command;
                    // Create a connection string without passing a database 
                    string ConnectionString =
                                    "server=localhost;User Id=root";

                    MySqlConnection Connection = new MySqlConnection(ConnectionString);
                    Connection.Open();
                    string line = "drop schema store";
                    command = new MySqlCommand(line, Connection);
                    command.ExecuteNonQuery();

                    Application.Restart();
                }


            }

            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }


        #endregion

        public CultureInfo m_cultureInfo { get; set; }

        private void changeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = openFileDialog1.ShowDialog();
            if (DialogResult == System.Windows.Forms.DialogResult.OK || DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                string filename;
                filename = openFileDialog1.FileName;
            //    pictureBox1.ImageLocation = filename;
                Application.UserAppDataRegistry.SetValue("Image", filename);
 
            }
           
        }

        private void showAllBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllBills showall = new ShowAllBills(this);
            showall.MdiParent = this;
            showall.Show();
        }

        private void اجمالياصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalItems totalitems = new TotalItems();
            totalitems.MdiParent = this;
            totalitems.Show();
        }

        private void itemsSalesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesItemsDetails salesitem = new SalesItemsDetails();
            salesitem.MdiParent = this;
            salesitem.Show();
        }

        private void كشفموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealersDebt dealersdebt = new DealersDebt();
            dealersdebt.MdiParent = this;
            dealersdebt.Show();
        }

        private void agentDebtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseItemsDetails purchaseitemsdetails = new PurchaseItemsDetails();
            purchaseitemsdetails.MdiParent = this;
            purchaseitemsdetails.Show();
        }
        bool continuecheck;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("1");
            try
            {
                Download("http://dl.dropbox.com/u/33013204/update.ver", "update.ver");
                while (true)
                {
                    Console.WriteLine("2");
                    if (continuecheck)
                    {
                        break;
                    }

                }
                Console.WriteLine("3");
                if (File.Exists(Application.StartupPath+"\\update.ver"))
                {
                    int currentver;
                    int newver;
                    string currentvers = "";
                    string newvers = "";

                    Console.WriteLine("4");
                    StreamReader file = new StreamReader(Application.StartupPath + "\\update.ver");
                    if (File.Exists(Application.StartupPath + "\\current.ver"))
                    {
                         StreamReader file2 = new StreamReader(Application.StartupPath + "\\current.ver");
                        
                         
                        currentvers = file2.ReadLine();
                    }     
                    newvers = file.ReadLine();
                    
                    int.TryParse(newvers, out newver);
                    int.TryParse(currentvers, out currentver);
                    Console.WriteLine(newver);
                    if (newver > currentver)
                    {
                        DialogResult ar = MessageBox.Show("Do u want to update?", "Update", MessageBoxButtons.YesNo);
                        if (ar == System.Windows.Forms.DialogResult.Yes)
                        {
                            Process.Start(Application.StartupPath + "\\AccountingUpdater.EXE");
                            Application.Exit();
                        }
                    }
                }    
            }
            catch (Exception ee)
            {
                throw;
  
            }
          
          
        }

        private void Download(string url, string file)
        {
            try
            {
                continuecheck = false;
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadFileAsync(new Uri(url), file);
            }
            catch (Exception ee)
            {

                throw;
            }
          
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            continuecheck = true;

        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
        /*
         use store;
set character set utf8;

load DATA local infile 'e:\\ahmed.csv'
into table items 

fields terminated by ';' 
lines terminated by '\n';
         */

    }
}
