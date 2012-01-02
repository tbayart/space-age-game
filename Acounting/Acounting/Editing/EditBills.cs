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
    public partial class EditBills : Form
    {

        double totalbill = 0;
        int billID;
        double totalprice;
        double remaining;
        double paid;
        int name_id;
        string name_name;
        int type;
        DateTime date;

        public EditBills(int billid,DateTime docdate,double totalpill,double paid,double remaining,int type,int names_id,string names_name)
        {
            billID = billid;
            date = docdate;
            this.totalbill = totalpill;
            this.paid = paid;
            this.remaining = remaining;
            this.type = type;
            this.name_id = names_id;
            this.name_name = names_name;

            InitializeComponent();
        }

        private void EditBills_Load(object sender, EventArgs e)
        {
   
        }
    }
}
