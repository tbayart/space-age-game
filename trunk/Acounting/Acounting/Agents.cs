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

        bool canchange = false;
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

            agentsTableAdapter.Update(storeDataSet);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Txt_AgentName.Focus();
            int newid;

            try
            {

                int.TryParse(dataGridView1.Rows[dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None)].Cells[0].Value.ToString(), out newid);


            }
            catch (Exception ee)
            {

                newid = 0;
            }

            newid++;
            Txt_AgentID.Text = newid.ToString();

            canchange = true;
            
        }

 
        private void Txt_Debt_TextChanged(object sender, EventArgs e)
        {
            if (canchange)
            {
                Txt_InialDebt.Text = Txt_Debt.Text;
            }
           
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            canchange = false;
        }

        private void agentsBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            savedata();

            timer1.Enabled = false;
        }

 
    }
}
