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
    public partial class Dealers : Form
    {
        public Dealers()
        {
            InitializeComponent();
        }

        private void Dealers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.dealers' table. You can move, or remove it, as needed.
            this.dealersTableAdapter.Fill(this.storeDataSet.dealers);
            // TODO: This line of code loads data into the 'storeDataSet.dealers' table. You can move, or remove it, as needed.
            this.dealersTableAdapter.Fill(this.storeDataSet.dealers);

        }

   
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
dealersTableAdapter.Update(storeDataSet);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
this.Close();
        }
 
    }
}
