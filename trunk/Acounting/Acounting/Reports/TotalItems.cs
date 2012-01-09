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
        // Stores the instance of the current form.
        private static TotalItems form;

        public static TotalItems GetForm()
        {
            // If the form is null, create it here.
            if (form == null)
            {
                // Create it here.
                form = new TotalItems();

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
