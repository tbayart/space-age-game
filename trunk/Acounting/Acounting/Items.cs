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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.storeDataSet.items);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemsTableAdapter.Update(storeDataSet);
        }

 

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int qty;
                int cost;
                int.TryParse(dataGridView1[3, e.RowIndex].Value.ToString(), out qty);
                int.TryParse(dataGridView1[2, e.RowIndex].Value.ToString(), out cost);
                int total = cost * qty;
                dataGridView1[4, e.RowIndex].Value = total;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

 
         
    }
}
