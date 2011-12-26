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


 

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                double qty;
                double cost;
                double.TryParse(dataGridView1[3, e.RowIndex].Value.ToString(), out qty);
                double.TryParse(dataGridView1[2, e.RowIndex].Value.ToString(), out cost);
                double total = cost * qty;
                dataGridView1[4, e.RowIndex].Value = total;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Txt_ItemName.Focus();
            int newid;
            int.TryParse(bindingNavigatorPositionItem.Text, out newid);
            Console.WriteLine(newid);
            Txt_ItemID.Text = newid.ToString();

        }

        private void Txt_Qty_TextChanged(object sender, EventArgs e)
        {

            double cost;
            double qty;
            double.TryParse(Txt_Qty.Text, out qty);
            double.TryParse(Txt_Cost.Text, out cost);
            double totalcost = cost * qty;

            Txt_Totalcost.Text = totalcost.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemsTableAdapter.Update(storeDataSet);
        }

 
         
    }
}
