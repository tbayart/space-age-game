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
    public partial class Payments : Form
    {
        int selectedagentid;
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.storeDataSet.payments);
            // TODO: This line of code loads data into the 'storeDataSet.agents' table. You can move, or remove it, as needed.
            this.agentsTableAdapter.Fill(this.storeDataSet.agents);
            comboBox1_TextChanged(null, null);

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                 
                if (!(comboBox1.Text == ""))
                {
                    DataRow filterrow = storeDataSet.agents.AsEnumerable().Where(i => i.Field<string>("AgentName") == comboBox1.Text).FirstOrDefault();
                    Txt_Debt.Text = filterrow["Debt"].ToString();
                    int.TryParse(filterrow["AgentID"].ToString(), out selectedagentid);
                }

            }
            catch (Exception ee)
            {
                errorProvider1.SetError(comboBox1, ee.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //get last id
            int lastid=0;
            int ammount;

            //get ammount paid
            if (!int.TryParse(Txt_Ammount.Text,out ammount))
            {
                errorProvider1.SetError(Txt_Ammount,"Wrong Number !!");
            }

            
            if (storeDataSet.payments.Count == 0)
            {
                lastid = 1;
            }
            else
            {
                // get last idnumber
                DataRow lastrow = storeDataSet.payments.Last();

                int.TryParse(lastrow["Id"].ToString(), out lastid);

                lastid++;
            }

            //insert payment
            paymentsTableAdapter.Insert(lastid, DateTime.Now, ammount, selectedagentid);

            //decrement agent debt
            DataRow agentrow = storeDataSet.agents.FindByAgentID(selectedagentid);

            int olddebt, newdebt;
            int.TryParse(agentrow["Debt"].ToString(), out olddebt);
            newdebt = olddebt + ammount;

            agentrow["Debt"] = newdebt;
            agentsTableAdapter.Update(agentrow);

            agentsTableAdapter.Fill(storeDataSet.agents);
            paymentsTableAdapter.Fill(storeDataSet.payments);
            comboBox1_TextChanged(null, null);

        }
    }
}
