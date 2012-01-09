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
        // Stores the instance of the current form.
        private static PurchaseItemsDetails form;

        public static PurchaseItemsDetails GetForm()
        {
            // If the form is null, create it here.
            if (form == null)
            {
                // Create it here.
                form = new PurchaseItemsDetails();

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
