using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'storeDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.storeDataSet.items);
            Console.WriteLine("asdasd");
 
        }

        private void agentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            Agents agents = new Agents();
            agents.MdiParent = this;
            agents.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.MdiParent = this;
            items.Show();
        }

        private void dealersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dealers dealers = new Dealers();
            dealers.MdiParent = this;
            dealers.Show();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnSell sell = new ReturnSell();
            sell.MdiParent = this;
            sell.Show();

        }

        private void vaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vault vault = new Vault();
            vault.MdiParent = this;
            vault.Show();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.MdiParent = this;
            payments.Show();
        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.MdiParent = this;
            buy.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.MdiParent = this;
            reports.Show();
        }
    }
}
