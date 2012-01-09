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

        // Stores the instance of the current form.
        private static Items form;

        public static Items GetForm()
        {
            // If the form is null, create it here.
            if (form == null)
            {
                // Create it here.
                form = new Items();

                // Handle the closed event, when closed, set the form to null.
                // This syntax is for .NET 2.0. You can just create a delegate and
                //add that
                // to the form for previous versions.
                form.Closed += delegate
                {
                    // Set form to null.
                    form = null;
                };
            }

            // Return the form.
            return form;
        }
    

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

            if (dataGridView1.Rows.Count == 1)
            {
                newid = 0;
            }
            else
            {
                int.TryParse(dataGridView1.Rows[dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None) - 1].Cells[0].Value.ToString(), out newid);
            }
 
            newid++;
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

            savedata();

            timer1.Enabled = true;
        }

        private void savedata()
        {

 
                tabControl1.SelectedTab = tabPage1;
                tabControl1.Refresh();
                dataGridView1.Focus();

                SendKeys.Send("{UP}");

                SendKeys.Send("{DOWN}");

                itemsTableAdapter.Update(storeDataSet);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            savedata();

            timer1.Enabled = false;
        }

 
         
    }
}
