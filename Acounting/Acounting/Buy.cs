using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Resources;
using System.Globalization;

namespace Acounting
{
    public partial class Buy : Form
    {

        double totalbill = 0;
        int billID; 
        DataTable virtualdata;
        int purchaseID;
        double totalprice;
        double remaining;
        int dealerId;

        ResourceManager rm;


        public Buy()
        {
            InitializeComponent();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            this.namesTableAdapter.Fill(this.storeDataSet.names);
            this.purchaseDetailsTableAdapter.Fill(this.storeDataSet.PurchaseDetails);
            this.vaultTableAdapter.Fill(this.storeDataSet.vault);
            this.purchasesitemsTableAdapter.Fill(this.storeDataSet.purchasesitems);
            this.purchasebillsTableAdapter.Fill(this.storeDataSet.purchasebills);
            this.itemsTableAdapter.Fill(this.storeDataSet.items);

            

            Cmb_ItemName_TextChanged(null, null);
            Cmb_DealerName_TextChanged(null,null);


            //make a ghost table
            virtualdata = storeDataSet.PurchaseDetails.Clone();
            dataGridView1.DataSource = virtualdata;

            //get purchase lastid
            purchaseID = storeDataSet.purchasesitems.Rows.Count;
 
            //new bill id      
            billID = storeDataSet.purchasebills.Count + 1;

            Txt_BillID.Text = billID.ToString();
             
            rm = new ResourceManager(typeof(Buy));
            Console.WriteLine(rm.BaseName);
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

        private void Cmb_DealerName_TextChanged(object sender, EventArgs e)
        {
            DataTable dealers = storeDataSet.names ;
            try
            {
                DataRow filterrow = dealers.AsEnumerable().Where(i => i.Field<string>("Name") == Cmb_DealerName.Text && (i.Field<UInt64>("TypeDealer") != 0 )).FirstOrDefault();

                Txt_DealerID.Text = filterrow["ID"].ToString();

                if (!int.TryParse(Txt_DealerID.Text, out dealerId))
                {

                    errorProvider1.SetError(Txt_DealerID, rm.GetString("DealerIDerr", Program.cul));
                    return;
                }
            }
            catch (Exception ee)
            {
                if (ee is NullReferenceException)
                {
                    if (rm!=null)
                    {
                        
                        errorProvider1.SetError(Txt_DealerID, rm.GetString("DealerIDerr",Program.cul));
                    }
                     
                }
           //     errorProvider1.SetError(Cmb_DealerName, ee.Message);


            }
        }

        private void clear_items()
        {

            //clear items data
            Txt_ToBuy.Text = "";
            Txt_BuyPrice.Text = "";
            Cmb_DealerName.Enabled = false;
            button2.Enabled = true;
        }
        private void reset_back()
        {
            Cmb_DealerName.Enabled = true;
            Txt_BuyPrice.Text = "";
            Txt_ToBuy.Text = "";
            Txt_Paid.Text = "";
        }


        private void updatedataset()
        {
            purchasebillsTableAdapter.Update(storeDataSet);
            purchasesitemsTableAdapter.Update(storeDataSet);
            itemsTableAdapter.Update(storeDataSet);
            namesTableAdapter.Update(storeDataSet);
            vaultTableAdapter.Update(storeDataSet);            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region check and make sure everything ok
            errorProvider1.Clear();
            // check data not empty


            if (Txt_DealerID.Text == "")
            {
                errorProvider1.SetError(Cmb_DealerName, rm.GetString("DealerIDerr", Program.cul));
                return;
            }

            int itemid;
            if (!int.TryParse(Txt_ItemID.Text, out itemid))
            {
                errorProvider1.SetError(Txt_DealerID, rm.GetString("DealerIDerr", Program.cul));
                return;
            }

            #region itemscheck
            //find current itemrow
            DataRow itemrow = storeDataSet.items.FindByItemID(itemid);

            //items check

            double buyqty;

            if (!double.TryParse(Txt_ToBuy.Text, out buyqty))
            {
                errorProvider1.SetError(Txt_ToBuy, "Error With Quantity");
                return;
            }
            else if (buyqty <= 0)
            {
                errorProvider1.SetError(Txt_ToBuy, "Less Than 0 ITEM ?????!!");
                return;
            }
            double buyprice;

            if (!double.TryParse(Txt_BuyPrice.Text, out buyprice))
            {
                errorProvider1.SetError(Txt_BuyPrice, "Error with Price!");
                return;
            }

            double originalqty;
            double.TryParse(itemrow["Qty"].ToString(), out originalqty);

            #endregion


            #region dealers


            totalprice = buyprice * buyqty;


            double billpaid;
            if (!double.TryParse(Txt_Paid.Text, out billpaid))
            {
                errorProvider1.SetError(Txt_Paid, "Error With Paid !");
                return;
            }

            #endregion

            #endregion

            purchaseID++;

            #region add items sales

            // add items sales  
            DataRow newrow = storeDataSet.purchasesitems.NewRow();
            newrow[0] = purchaseID;
            newrow[1] = billID;
            newrow[2] = itemid;
            newrow[3] = buyqty;
            newrow[4] = buyprice; 
            newrow[5] = totalprice; 
            storeDataSet.purchasesitems.Rows.Add(newrow);

            //add virtual data to datagrid

            DataRow detailsrow = virtualdata.NewRow();

            detailsrow[0] = Cmb_ItemName.Text;
            detailsrow[1] = buyqty;
            detailsrow[2] = buyprice;
            detailsrow[3] = totalprice;

            virtualdata.Rows.Add(detailsrow);


            totalbill += totalprice;

            //  update parameters for bill

            remaining = billpaid - totalbill ;

            Txt_TotalBill.Text = totalbill.ToString();
            Txt_Remaining.Text = remaining.ToString();



            // update items to add items qty

            itemrow = storeDataSet.items.FindByItemID(itemid);
            double.TryParse(itemrow["Qty"].ToString(), out originalqty);
            double newqty = originalqty + buyqty;
            itemrow["Qty"] = newqty;
            itemrow["Cost"] = buyprice;
            double totalcost = buyprice * newqty;
            itemrow["TotalCost"] = totalcost;

            button2.Enabled = true;
            Cmb_ItemName_TextChanged(null, null);
            Cmb_DealerName_TextChanged(null, null);
            #endregion


            clear_items();
            

        }

        private void Txt_Paid_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            double billpaid;
            if (!double.TryParse(Txt_Paid.Text, out billpaid))
            {
                errorProvider1.SetError(Txt_Paid, "Error With Paid Value");
                return;
            }

            remaining = billpaid - totalbill;
            Txt_Remaining.Text = remaining.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
                    DataRow billrow = storeDataSet.purchasebills.NewRow();

                    billrow[0] = billID;
                    billrow[1] = DateTime.Now;
                    billrow[2] = totalbill;
                    billrow[3] = paid;
                    billrow[4] = remaining;
                    billrow[5] = dealerId;

                    storeDataSet.purchasebills.Rows.Add(billrow);


                    // get vault row for manipulation
                    DataRow vaultrow = storeDataSet.vault.FindByidVault(0);

                    double oldvalue, newvalue;
                    double.TryParse(vaultrow["In_Hand"].ToString(), out oldvalue);

                    Console.WriteLine(oldvalue);
                    newvalue = oldvalue - paid;
                    Console.WriteLine(newvalue);
                    vaultrow["In_Hand"] = newvalue;


                    //find old debt
                    double debt;
                    DataRow dealerrow = storeDataSet.names.FindByID(dealerId);

                    double.TryParse(dealerrow["Debt"].ToString(), out debt);

                    double newdebt = debt + remaining;

                    //add newdebt to agent
                    dealerrow["Debt"] = newdebt;

                    // update alll
                    updatedataset();

                    //reset globals
                    totalbill = 0;
                    totalprice = 0;
                    remaining = 0;

                    virtualdata.Clear();


                    billID = storeDataSet.purchasebills.Count + 1;

                    Txt_BillID.Text = billID.ToString();
 

                    #endregion

                    clear_items();
                }

            }
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.namesTableAdapter.FillBy1(this.storeDataSet.names);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

 

    }
}
