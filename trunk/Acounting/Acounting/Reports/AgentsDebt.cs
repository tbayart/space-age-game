﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Acounting
{
    public partial class AgentsDebt : Form
    {
        public AgentsDebt()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.storeDataSet.payments);
            // TODO: This line of code loads data into the 'storeDataSet.billsreturn' table. You can move, or remove it, as needed.
            this.billsreturnTableAdapter.Fill(this.storeDataSet.billsreturn);
            // TODO: This line of code loads data into the 'storeDataSet.bills' table. You can move, or remove it, as needed.
            this.billsTableAdapter.Fill(this.storeDataSet.bills);
            // TODO: This line of code loads data into the 'storeDataSet.agents' table. You can move, or remove it, as needed.
            this.agentsTableAdapter.Fill(this.storeDataSet.agents);

 
        }
 

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //get agentid
                int agentid = 0;

                DataRow filterrow = storeDataSet.agents.AsEnumerable().Where(i => i.Field<string>("AgentName") == comboBox1.Text).FirstOrDefault();

                if (!int.TryParse(filterrow["AgentID"].ToString(), out agentid))
                {
                    return;
                }
                //filter the data
                billsBindingSource.Filter = "Agents_AgentID = '" + agentid.ToString() + "'";
                agentsBindingSource.Filter = "AgentName = '" + comboBox1.Text + "'";
                billsreturnBindingSource.Filter = "Agents_AgentID = '" + agentid.ToString() + "'";
                paymentsBindingSource.Filter = "Agents_AgentID = '" + agentid.ToString() + "'";
                //refresh the report
                reportViewer3.RefreshReport();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

  

 

     
 
    }
}
