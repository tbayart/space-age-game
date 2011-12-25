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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.bills' table. You can move, or remove it, as needed.
            this.billsTableAdapter.Fill(this.storeDataSet.bills);
            // TODO: This line of code loads data into the 'storeDataSet.agents' table. You can move, or remove it, as needed.
            this.agentsTableAdapter.Fill(this.storeDataSet.agents);
                
            this.reportViewer3.RefreshReport();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //get agentid
                int agentid=0;
          
                DataRow filterrow = storeDataSet.agents.AsEnumerable().Where(i => i.Field<string>("AgentName") == comboBox1.Text).FirstOrDefault();              

                if (!int.TryParse(filterrow["AgentID"].ToString(), out agentid))
                {
                    return;                   
                }
                //filter the data
                billsBindingSource.Filter = "Agents_AgentID = '" + agentid.ToString() + "'";
                agentsBindingSource.Filter = "AgentName = '" + comboBox1.Text + "'";
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
