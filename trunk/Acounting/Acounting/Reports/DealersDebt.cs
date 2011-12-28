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
    public partial class DealersDebt : Form
    {
        public DealersDebt()
        {
            InitializeComponent();
        }

        private void DealersDebt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.purchasebills' table. You can move, or remove it, as needed.
            this.purchasebillsTableAdapter.Fill(this.storeDataSet.purchasebills);
            // TODO: This line of code loads data into the 'storeDataSet.purchasebillsreturn' table. You can move, or remove it, as needed.
            this.purchasebillsreturnTableAdapter.Fill(this.storeDataSet.purchasebillsreturn);
            // TODO: This line of code loads data into the 'storeDataSet.dealerpayments' table. You can move, or remove it, as needed.
            this.dealerpaymentsTableAdapter.Fill(this.storeDataSet.dealerpayments);
            // TODO: This line of code loads data into the 'storeDataSet.dealers' table. You can move, or remove it, as needed.
            this.dealersTableAdapter.Fill(this.storeDataSet.dealers);

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //get agentid
                int dealerid = 0;

                DataRow filterrow = storeDataSet.dealers.AsEnumerable().Where(i => i.Field<string>("DealerName") == comboBox1.Text).FirstOrDefault();

                if (!int.TryParse(filterrow["DealerID"].ToString(), out dealerid))
                {
                    return;
                }
                //filter the data
                purchasebillsBindingSource.Filter = "Dealers_DealerID = '" + dealerid.ToString() + "'";
                dealersBindingSource.Filter = "DealerName = '" + comboBox1.Text + "'";
                purchasebillsreturnBindingSource.Filter = "Dealers_DealerID = '" + dealerid.ToString() + "'";
                dealerpaymentsBindingSource.Filter = "Dealers_DealerID = '" + dealerid.ToString() + "'";
                //refresh the report
                reportViewer1.RefreshReport();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
