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
    public partial class StaticAssets : Form
    {
        public StaticAssets()
        {
            InitializeComponent();
        }

        private void StaticAssets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.staticassests' table. You can move, or remove it, as needed.
            this.staticassestsTableAdapter.Fill(this.storeDataSet.staticassests);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Txt_AssetName.Focus();
            int newid;
            int.TryParse(bindingNavigatorPositionItem.Text, out newid);

            Console.WriteLine(newid);

            Txt_AssetID.Text = newid.ToString();
   
        }

        private void Txt_Cost_TextChanged(object sender, EventArgs e)
        {

            double cost;
            double qty;
            double.TryParse(Txt_Qty.Text, out qty);
            double.TryParse(Txt_Cost.Text, out cost);
            double totalcost = cost * qty;

            Txt_TotalCost.Text = totalcost.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

            staticassestsTableAdapter.Update(storeDataSet);
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            double totalasset = 0;
            double totalcost = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                double.TryParse(dataGridView1[4, i].Value.ToString(), out totalcost);
                totalasset += totalcost;
                Txt_ttc.Text = totalasset.ToString();
            }
        }

 

        private void timer1_Tick(object sender, EventArgs e)
        {
            savedata();

            timer1.Enabled = false;
        }
    }
}
