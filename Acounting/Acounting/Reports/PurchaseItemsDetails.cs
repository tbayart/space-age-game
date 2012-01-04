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
    public partial class PurchaseItemsDetails : Form
    {
        public PurchaseItemsDetails()
        {
            InitializeComponent();
        }

        private void PurchaseItemsDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.PurchaseItemsDetails' table. You can move, or remove it, as needed.
            this.purchaseItemsDetailsTableAdapter.Fill(this.storeDataSet.PurchaseItemsDetails);

            this.reportViewer1.RefreshReport();
        }
    }
}
