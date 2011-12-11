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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
        }

        private void Agents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.agents' table. You can move, or remove it, as needed.
            this.agentsTableAdapter.Fill(this.storeDataSet.agents);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agentsTableAdapter.Update(storeDataSet);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
