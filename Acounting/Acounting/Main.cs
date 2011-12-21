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
            Sell sell = new Sell();
            sell.MdiParent = this;
            sell.Show();

        }

        private void vaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vault vault = new Vault();
            vault.MdiParent = this;
            vault.Show();
        }
    }
}
