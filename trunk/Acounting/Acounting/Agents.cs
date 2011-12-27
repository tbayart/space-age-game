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
            int.TryParse(bindingNavigatorPositionItem.Text, out newid);
            Console.WriteLine(newid);
            Txt_AgentID.Text = newid.ToString();

            if (dataGridView1.Rows.Count <= newid)
            {
                canchange = true;
            }
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

 
    }
}
