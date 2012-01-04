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
    public partial class TotalItems : Form
    {
        public TotalItems()
        {
            InitializeComponent();
        }

        private void TotalItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.storeDataSet.items);

            this.reportViewer1.RefreshReport();
        }
    }
}
