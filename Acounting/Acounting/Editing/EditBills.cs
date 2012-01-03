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


        int billID;
        DateTime date;
        double totalbill = 0;
        double paid;
        double remaining;
        int type;
        int name_id;
        string name_name;



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
            Txt_BillID.Text = billID.ToString();
            Txt_Name.Text = name_name;
            Txt_Paid.Text = paid.ToString();
            Txt_Remaining.Text = remaining.ToString();
            Txt_TotalBill.Text = totalbill.ToString();
        }
    }
}
