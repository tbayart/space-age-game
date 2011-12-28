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
using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;


namespace Acounting
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }
              

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.vault' table. You can move, or remove it, as needed.
            this.vaultTableAdapter.Fill(this.storeDataSet.vault);


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

                    CreateDB create = new CreateDB();
                    create.MdiParent = this;
                    create.Show();

                }

            }

        }
        
        #region menu items

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void كشفموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealersDebt dealersdebt = new DealersDebt();
            dealersdebt.MdiParent = this;
            dealersdebt.Show();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.MdiParent = this;
            items.Show();
        }


        private void agentDebtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AgentsDebt reports = new AgentsDebt();
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
            Sell sell = new Sell();
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

        #endregion

        public CultureInfo m_cultureInfo { get; set; }

        private void عربيToolStripMenuItem1_Click(object sender, EventArgs e)
        {
  
            Program.cul = new CultureInfo("ar");

            Application.UserAppDataRegistry.SetValue("Language","ar");

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

        private void حفظاسترجعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.cul.Name=="")
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


    }
}
