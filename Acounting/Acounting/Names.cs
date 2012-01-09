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
    public partial class Names : Form
    {

        // Stores the instance of the current form.
        private static Names form;

        public static Names GetForm()
        {
            // If the form is null, create it here.
            if (form == null)
            {
                // Create it here.
                form = new Names();

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
    


        bool canchange = false;

        public Names()
        {
            InitializeComponent();
        }

        private void Names_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.names' table. You can move, or remove it, as needed.
            this.namesTableAdapter.Fill(this.storeDataSet.names);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Txt_Name.Focus();
            int newid;

            if (dataGridView1.Rows.Count == 1 )
            {
                newid = 0;
            }
            else
            {
                int.TryParse(dataGridView1.Rows[dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None) - 1].Cells[0].Value.ToString(), out newid);
            }
            dateTimePicker1.Refresh();
            dateTimePicker1.Invalidate();

            Chk_Agent.Checked = true;
            Chk_Dealer.Checked = true;

            Chk_Agent.Checked = false;
            Chk_Dealer.Checked = false;


            newid++;
            Txt_ID.Text = newid.ToString();
            canchange = true;
        }

        private void Txt_Debt_TextChanged(object sender, EventArgs e)
        {
            if (canchange)
            {
                Txt_InialDebt.Text = Txt_Debt.Text;
            }
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

            namesTableAdapter.Update(storeDataSet);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            savedata();
            timer1.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            canchange = false;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
