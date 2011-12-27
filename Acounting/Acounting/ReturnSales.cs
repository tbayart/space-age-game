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
    public partial class ReturnSales : Form
    {
        public ReturnSales()
        {
            InitializeComponent();
        }

        private void ReturnSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.salesitemsreturn' table. You can move, or remove it, as needed.
            this.salesitemsreturnTableAdapter.Fill(this.storeDataSet.salesitemsreturn);
            // TODO: This line of code loads data into the 'storeDataSet.billsreturn' table. You can move, or remove it, as needed.
            this.billsreturnTableAdapter.Fill(this.storeDataSet.billsreturn);
            // TODO: This line of code loads data into the 'storeDataSet.agents' table. You can move, or remove it, as needed.
            this.agentsTableAdapter.Fill(this.storeDataSet.agents);
            // TODO: This line of code loads data into the 'storeDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.storeDataSet.items);

        }
    }
}
