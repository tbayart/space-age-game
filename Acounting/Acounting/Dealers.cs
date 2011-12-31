using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Acounting
{
    public partial class Dealers : Form
    {
        bool canchange=false;
        public Dealers()
        {
            InitializeComponent();
        }

        private void Dealers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.dealers' table. You can move, or remove it, as needed.
            this.dealersTableAdapter.Fill(this.storeDataSet.dealers);
 

        }

     
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
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

            dealersTableAdapter.Update(storeDataSet);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            canchange = false;
        }

        private void Txt_Debt_TextChanged(object sender, EventArgs e)
        {
            if (canchange)
            {
                Txt_InialDebt.Text = Txt_Debt.Text;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Txt_DealerName.Focus();
            int newid;
            int.TryParse(bindingNavigatorPositionItem.Text, out newid);
            Console.WriteLine(newid);
            Txt_DealerID.Text = newid.ToString();

            if (dataGridView1.Rows.Count <= newid)
            {
                canchange = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            savedata();
            timer1.Enabled = false;
        }
 
    }
}
