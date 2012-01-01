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
    public partial class Names : Form
    {
        public Names()
        {
            InitializeComponent();
        }

        private void Names_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.names' table. You can move, or remove it, as needed.
            this.namesTableAdapter.Fill(this.storeDataSet.names);

        }
    }
}
