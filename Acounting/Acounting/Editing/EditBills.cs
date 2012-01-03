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
        double oldremaining;
        double oldpaid;
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
            this.oldpaid = paid;
            this.oldremaining = remaining;
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


                DataRow filterrow = storeDataSet.items.FindByItemID(itemid);
                Cmb_ItemName.Text = filterrow["ItemName"].ToString();
                Txt_InStock.Text = filterrow["Qty"].ToString();
                Txt_Cost.Text = filterrow["Cost"].ToString();


            }
            catch (Exception ee)
            {
                errorProvider1.SetError(Cmb_ItemName, ee.Message);
            }
        }



        private void Btn_Update_Click(object sender, EventArgs e)
        {
            #region if type1
            if (type == Properties.Settings.Default.type1)
            {
                int qty;
                int sellprice;
                int cost;
                int itemid;
                //sales items 
                
                

                int.TryParse(Txt_ItemID.Text, out itemid);

                DataRow itemrow = storeDataSet.items.FindByItemID(itemid);

                int itemqty;
                int.TryParse(itemrow["Qty"].ToString(), out itemqty);
                int.TryParse(itemrow["Cost"].ToString(), out cost);

                DataRow row = storeDataSet.salesitems.FindByID((uint)selected_row);

                int.TryParse(row["Qty"].ToString(), out qty);

                itemrow["Qty"] = itemqty + qty;

                int newqty;
                int.TryParse(Txt_Units.Text, out newqty);

                int.TryParse(itemrow["Qty"].ToString(), out itemqty);

                itemqty -=newqty;
                itemrow["Qty"] = itemqty;
                itemrow["TotalCost"] = itemqty * cost;

                int.TryParse(Txt_Price.Text,out sellprice);
                row["Qty"] = newqty;
                row["SellPrice"] = sellprice; 
                row["Cost"] = cost;
                row["TotalPrice"] = sellprice * newqty;
                row["Earnings"] = (sellprice - cost) * newqty;

                Txt_ItemID_TextChanged(null, null);
                UpdateTotalBill();
            }
            #endregion


        }

        private void UpdateTotalBill()
        {
            totalbill = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int totalprice;
                int.TryParse(dataGridView1.Rows[i].Cells["TotalPrice"].Value.ToString(), out totalprice);
                totalbill += totalprice;
                Txt_TotalBill.Text = totalbill.ToString();
            }
            Txt_Paid_TextChanged(null, null);
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            #region if type1
            if (type == Properties.Settings.Default.type1)
            {

                #region check and make sure everything ok
                errorProvider1.Clear();
                // check data not empty

                int salesID;

                DataRow lastsalesrow = storeDataSet.salesitems.Last();
                int.TryParse(lastsalesrow["ID"].ToString(), out salesID);


                salesID++;

                int itemid;
                if (!int.TryParse(Txt_ItemID.Text, out itemid))
                {
                    errorProvider1.SetError(Txt_ItemID, "Error With ItemID");

                    return;
                }

                DataRow itemrow = storeDataSet.items.FindByItemID(itemid);

                double cost;
                if (!double.TryParse(Txt_Cost.Text, out cost))
                {
                    errorProvider1.SetError(Txt_Cost, "Error With Cost");

                    return;
                }

                double sellqty;

                if (!double.TryParse(Txt_Units.Text, out sellqty))
                {
                    errorProvider1.SetError(Txt_Units, "Error With SellQty");
                    Txt_Units.Focus();
                    return;
                }
                else if (sellqty <= 0)
                {
                    errorProvider1.SetError(Txt_Units, "Less Than 0 ITEM ?????!!");
                    Txt_Units.Focus();
                    return;
                }

                double originalqty;
                double.TryParse(itemrow["Qty"].ToString(), out originalqty);

                if (sellqty > originalqty)
                {
                    errorProvider1.SetError(Txt_Units, "Not enough items in stock");
                    Txt_Units.Focus();
                    return;
                }


                double sellprice;
                if (!double.TryParse(Txt_Price.Text, out sellprice))
                {
                    errorProvider1.SetError(Txt_Price, "Error With Sellprice");
                    Txt_Price.Focus();
                    return;
                }

                #endregion


                #region add items sales

                double totalprice = sellprice * sellqty;
                double earnings = totalprice - (sellqty * cost);


                // add items sales  
                DataRow newrow = storeDataSet.salesitems.NewRow();
                newrow[0] = salesID;
                newrow[1] = billID;
                newrow[2] = itemid;
                newrow[3] = sellqty;
                newrow[4] = sellprice;
                newrow[5] = cost;
                newrow[6] = totalprice;
                newrow[7] = earnings;
                storeDataSet.salesitems.Rows.Add(newrow);

                totalbill += totalprice;

                //  update parameters for bill
                double billpaid;
                double.TryParse(Txt_Paid.Text, out billpaid);
                remaining = totalbill - billpaid;

                Txt_TotalBill.Text = totalbill.ToString();
                Txt_Remaining.Text = remaining.ToString();



                // update items to reduce items qty


                itemrow = storeDataSet.items.FindByItemID(itemid);
                double.TryParse(itemrow["Qty"].ToString(), out originalqty);
                double newqty = originalqty - sellqty;
                itemrow["Qty"] = newqty;



                Cmb_ItemName_TextChanged(null, null);

                #endregion
                
            }
            #endregion
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            #region if type1
            if (type == Properties.Settings.Default.type1)
            {
                //show dialoge 

                DialogResult result = MessageBox.Show("Do you want to save ?", "Accounting", MessageBoxButtons.YesNo);


                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    #region save


                    // find paid ammount  
                    double paid;

                    double.TryParse(Txt_Paid.Text, out paid);


                    //make sure paid is right
                    Txt_Paid_TextChanged(null, null);

                    //add bill
                    DataRow billrow = storeDataSet.bills.FindByBillID(billID);

                    billrow[0] = billID;
                    billrow[1] = DateTime.Now;
                    billrow[2] = totalbill;
                    billrow[3] = paid;
                    billrow[4] = remaining;
                    billrow[5] = name_id;
                    
                    // get vault row for manipulation
                    DataRow vaultrow = storeDataSet.vault.FindByidVault(0);

                    double oldvalue, newvalue;
                    double.TryParse(vaultrow["In_Hand"].ToString(), out oldvalue);

                    Console.WriteLine(oldvalue);
                    newvalue = oldvalue + (paid - oldpaid);
                    Console.WriteLine(newvalue);
                    vaultrow["In_Hand"] = newvalue;


                    //find old debt
                    double debt;
                    DataRow agentrow = storeDataSet.names.FindByID(name_id);
                    double.TryParse(agentrow["Debt"].ToString(), out debt);

                    double newdebt = debt + (remaining - oldremaining);

                    //add newdebt to agent
                    agentrow["Debt"] = newdebt;

                    // update alll


                    updatedataset1();

                    this.Close();
                    #endregion

 
                }


            }
            #endregion
        }

        private void updatedataset1()
        {
            billsTableAdapter.Update(storeDataSet);
            salesitemsTableAdapter.Update(storeDataSet);
            itemsTableAdapter.Update(storeDataSet);
            namesTableAdapter.Update(storeDataSet);
            vaultTableAdapter.Update(storeDataSet); 
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

        private void Txt_Paid_TextChanged(object sender, EventArgs e)
        {
            #region if type1
            if (type == Properties.Settings.Default.type1)
            {
                errorProvider1.Clear();
                double billpaid;
                if (!double.TryParse(Txt_Paid.Text, out billpaid))
                {
                    errorProvider1.SetError(Txt_Paid, "Error With Paid Value");
                    return;
                }

                remaining = totalbill - billpaid;
                Txt_Remaining.Text = remaining.ToString();
            }
            #endregion
        }

    }
}
