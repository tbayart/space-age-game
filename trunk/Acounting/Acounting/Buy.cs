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
    public partial class Buy : Form
    {

        int totalbill = 0;
        int billID;
        
        public Buy()
        {
            InitializeComponent();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.ItemsPurchase' table. You can move, or remove it, as needed.
           // this.itemsPurchaseTableAdapter.Fill(this.storeDataSet.ItemsPurchase);
            // TODO: This line of code loads data into the 'storeDataSet1.ItemPurchase' table. You can move, or remove it, as needed.
       
            this.vaultTableAdapter.Fill(this.storeDataSet.vault);
            this.purchasesitemsTableAdapter.Fill(this.storeDataSet.purchasesitems);
            this.dealersTableAdapter.Fill(this.storeDataSet.dealers);
            this.purchasebillsTableAdapter.Fill(this.storeDataSet.purchasebills);

       

            this.itemsTableAdapter.Fill(this.storeDataSet.items);
            Cmb_ItemName_TextChanged(null, null);
            Cmb_DealerName_TextChanged(null,null);

            billID = storeDataSet.purchasebills.Count + 1;

            Txt_BillID.Text = billID.ToString();

            purchasesitemsBindingSource.Filter = "PurchaseBills_BillID='" + billID + "'";
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
            DataTable dealers = storeDataSet.dealers ;
            try
            {
                DataRow filterrow = dealers.AsEnumerable().Where(i => i.Field<string>("DealerName") == Cmb_DealerName.Text).FirstOrDefault();

                Txt_DealerID.Text = filterrow["DealerID"].ToString();
            }
            catch (Exception ee)
            {
                errorProvider1.SetError(Cmb_DealerName, ee.Message);


            }
        }



        private void updatedataset()
        {
            this.vaultTableAdapter.Fill(this.storeDataSet.vault);
            this.purchasesitemsTableAdapter.Fill(this.storeDataSet.purchasesitems);
            this.dealersTableAdapter.Fill(this.storeDataSet.dealers);
            this.purchasebillsTableAdapter.Fill(this.storeDataSet.purchasebills);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region check and make sure everything ok
            errorProvider1.Clear();
            // check data not empty

            int itemid;
            if (!int.TryParse(Txt_ItemID.Text, out itemid))
            {
                errorProvider1.SetError(Txt_ItemID, "Error With ItemID");
                return;
            }

            #region itemscheck
            //find current itemrow
            DataRow itemrow = storeDataSet.items.FindByItemID(itemid);

            //items check

            int buyqty;

            if (!int.TryParse(Txt_ToBuy.Text, out buyqty))
            {
                errorProvider1.SetError(Txt_ToBuy, "Error With Quantity");
                return;
            }
            else if (buyqty <= 0)
            {
                errorProvider1.SetError(Txt_ToBuy, "Less Than 0 ITEM ?????!!");
                return;
            }
            int buyprice;

            if (! int.TryParse(Txt_BuyPrice.ToString(),out buyprice))
            {
                errorProvider1.SetError(Txt_BuyPrice, "Error With Price");
                return;
            }

            int originalqty;
            int.TryParse(itemrow["Qty"].ToString(), out originalqty);
            #endregion


            #region 
            int dealerid;
            if (!int.TryParse(Txt_DealerID.Text, out dealerid))
            {
                errorProvider1.SetError(Txt_DealerID, "Error With DealerID");
                return;
            }

            //get last purchaseid
            int purchaseID = storeDataSet.purchasesitems.Rows.Count + 1;
            Console.WriteLine(storeDataSet.purchasesitems.Rows.Count);


            int totalprice = buyprice * buyqty;
            

            int billpaid;
            if (!int.TryParse(Txt_Paid.Text, out billpaid))
            {
                errorProvider1.SetError(Txt_Paid, "Error With Paid !");
                return;
            }

            #endregion



            #region check bill
            // check if same bill exists on database 
            Console.WriteLine("billid " + billID.ToString());

            //find the bill or add a new one of not found
            DataRow billrow = storeDataSet.purchasebills.FindByBillID(billID);
            if (billrow == null)
            {
                purchasebillsTableAdapter.Insert(billID, dealerid, DateTime.Now, 0, 0, 0);
                billrow = storeDataSet.bills.FindByBillID(billID);
            }


            #endregion

            #region add bill

            // add items sales 
            /*
                        salesitemsTableAdapter.Insert((uint)salesID, billID, itemid, sellqty, sellprice, cost, totalprice, earnings);
                        totalbill += totalprice;
                        Console.WriteLine("added new sales " + salesID.ToString());

                        //  update bill
                        updatedataset();

                        int remaining = billpaid - totalbill;
                        billrow = storeDataSet.bills.FindByBillID(billID);
                        billrow["TotalBill"] = totalbill;
                        billrow["Paid"] = billpaid;
                        billrow["Remaining"] = remaining;

                        billsTableAdapter.Update(billrow);

                        Txt_TotalBill.Text = totalbill.ToString();
                        Txt_Remaining.Text = remaining.ToString();

                        updatedataset();

                        // update items to reduce items qty


                        itemrow = storeDataSet.items.FindByItemID(itemid);
                        int.TryParse(itemrow["Qty"].ToString(), out originalqty);
                        int newqty = originalqty - sellqty;
                        itemrow["Qty"] = newqty;

                        itemsTableAdapter.Update(itemrow);
                        updatedataset();
                        Cmb_ItemName_TextChanged(null, null);
                        Cmb_AgentName_TextChanged(null, null);


                           */

            #endregion

            #endregion
        }




    }
}
