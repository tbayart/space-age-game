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
        string type;
        int name_id;
        string name_name;

        int selected_row = 0;


        public EditBills(int billid,DateTime docdate,double totalbill,double paid,double remaining,string type,int names_id,string names_name)
        {
            billID = billid;
            date = docdate;
            this.totalbill = totalbill;
            this.paid = paid;
            this.remaining = remaining;
            this.type = type;
            this.name_id = names_id;
            this.name_name = names_name;

            InitializeComponent();
        }

        private void EditBills_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.salesitems' table. You can move, or remove it, as needed.
            this.salesitemsTableAdapter.Fill(this.storeDataSet.salesitems);
            this.vaultTableAdapter.Fill(this.storeDataSet.vault);          
            this.itemsTableAdapter.Fill(this.storeDataSet.items);
            this.namesTableAdapter.Fill(this.storeDataSet.names);
            this.vaultTableAdapter.Fill(this.storeDataSet.vault);
            this.purchasebillsTableAdapter.Fill(this.storeDataSet.purchasebills);
            this.itemsTableAdapter.Fill(this.storeDataSet.items);
            this.salesitemsTableAdapter.Fill(this.storeDataSet.salesitems);
            this.billsTableAdapter.Fill(this.storeDataSet.bills);


            Txt_BillID.Text = billID.ToString();
            Txt_Paid.Text = paid.ToString();
            Txt_Remaining.Text = remaining.ToString();
            Txt_TotalBill.Text = totalbill.ToString();
            Txt_Type.Text = type;

            if (type == Properties.Settings.Default.type1)
            {
                dataGridView1.DataSource = salesitemsBindingSource;

                salesitemsBindingSource.Filter = "Bills_BillID = '" + billID + "'";

            }


             
        }

        private void Cmb_ItemName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                DataTable items = storeDataSet.items;
                if (!(Cmb_ItemName.Text == ""))
                {
                    DataRow filterrow = items.AsEnumerable().Where(i => i.Field<string>("ItemName") == Cmb_ItemName.Text).FirstOrDefault();
                    Txt_InStock.Text = filterrow["Qty"].ToString();
                    Txt_ItemID.Text = filterrow["ItemID"].ToString();
                    Txt_Cost.Text = filterrow["Cost"].ToString();
                }

            }
            catch (Exception ee)
            {
                errorProvider1.SetError(Cmb_ItemName, ee.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (type == Properties.Settings.Default.type1)
            {

                //get information
                int id;
                double qty;
                double sellprice;
                int itemid;
                //if its an item or not
                if (e.RowIndex < 0)
                {
                    return;
                }



                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out id))
                {

                    int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), out itemid);
                    double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), out qty);
                    double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), out sellprice);


                    Txt_RowID.Text = id.ToString();
                    Txt_Units.Text = qty.ToString();
                    Txt_Price.Text = sellprice.ToString();
                    Txt_ItemID.Text = itemid.ToString();
                }

                selected_row = id;

            }
        }


     

        private void Txt_ItemID_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                int itemid = 0;
                if (Txt_ItemID.Text != "")
                {
                    int.TryParse(Txt_ItemID.Text, out itemid);
                }

                if (!(Cmb_ItemName.Text == ""))
                {
                    DataRow filterrow = storeDataSet.items.FindByItemID(itemid);

                    Txt_InStock.Text = filterrow["Qty"].ToString();
                    Txt_Cost.Text = filterrow["Cost"].ToString();
                }

            }
            catch (Exception ee)
            {
                errorProvider1.SetError(Cmb_ItemName, ee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sales items 
            if (type == Properties.Settings.Default.type1)
            {


                DataRow row = storeDataSet.salesitems.FindByID((uint)selected_row);

                row[3] = Txt_Units.Text;
                row[4] = Txt_Price.Text;
                

            }



        }
    }
}
