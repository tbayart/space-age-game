using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using   System.Configuration;
namespace Acounting
{
    public partial class Sell : Form
    {
        int totalbill = 0;
        int billID;
        
        public Sell()
        {
            InitializeComponent();
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.vault' table. You can move, or remove it, as needed.
            this.vaultTableAdapter.Fill(this.storeDataSet.vault);
            // TODO: This line of code loads data into the 'storeDataSet.salesitems' table. You can move, or remove it, as needed.
            this.salesitemsTableAdapter.Fill(this.storeDataSet.salesitems);
            // TODO: This line of code loads data into the 'storeDataSet.bills' table. You can move, or remove it, as needed.
            this.billsTableAdapter.Fill(this.storeDataSet.bills);
            // TODO: This line of code loads data into the 'storeDataSet.agents' table. You can move, or remove it, as needed.
            this.agentsTableAdapter.Fill(this.storeDataSet.agents);
            // TODO: This line of code loads data into the 'storeDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.storeDataSet.items);
            Cmb_ItemName_TextChanged(null, null);
            Cmb_AgentName_TextChanged(null, null);

              billID = storeDataSet.bills.Count + 1;

              Txt_BillID.Text = billID.ToString();
              salesitemsBindingSource.Filter = "Bills_BillID='" + billID + "'";
          
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

        private void Cmb_AgentName_TextChanged(object sender, EventArgs e)
        {
            DataTable agents = storeDataSet.agents;
            try
            {
                DataRow filterrow = agents.AsEnumerable().Where(i => i.Field<string>("AgentName") == Cmb_AgentName.Text).FirstOrDefault();
                
                Txt_AgentID.Text = filterrow["AgentID"].ToString();
            }
            catch (Exception ee)
            {
                errorProvider1.SetError(Cmb_AgentName, ee.Message);
             

            }
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

            DataRow itemrow = storeDataSet.items.FindByItemID(itemid);



            int cost;
            if (!int.TryParse(Txt_Cost.Text, out cost))
            {
                errorProvider1.SetError(Txt_Cost, "Error With Cost");
                return;
            }

            int sellqty;

            if (!int.TryParse(Txt_ToSell.Text, out sellqty))
            {
                errorProvider1.SetError(Txt_ToSell, "Error With SellQty");
                return;
            }
            else if (sellqty <=0)
            {
                errorProvider1.SetError(Txt_ToSell, "Less Than 0 ITEM ?????!!");
                return;
            }

            int originalqty;
            int.TryParse(itemrow["Qty"].ToString(),out originalqty);

            if (sellqty>originalqty)
            {
                errorProvider1.SetError(Txt_ToSell, "Not enough items in stock");
                return;
            }


            int sellprice;
            if (!int.TryParse(Txt_SellPrice.Text, out sellprice))
            {
                errorProvider1.SetError(Txt_SellPrice, "Error With Sellprice");
                return;
            }

            int agentid;
            if (!int.TryParse(Txt_AgentID.Text, out agentid))
            {
                errorProvider1.SetError(Txt_AgentID, "Error With AgentID");
                return;
            }

            int salesID = storeDataSet.salesitems.Rows.Count + 1;
            Console.WriteLine(storeDataSet.salesitems.Rows.Count);
          

            int totalprice = sellprice*sellqty;
            int earnings = totalprice - (sellqty*cost);

            int billpaid;
            if (!int.TryParse(Txt_Paid.Text, out billpaid))
            {
                errorProvider1.SetError(Txt_Paid, "Error With AgentID");
                return;
            }

            #endregion

            #region check bill
            // check if same bill exists on database 
            Console.WriteLine("billid " + billID.ToString());

            //find the bill or add a new one of not found
            DataRow billrow = storeDataSet.bills.FindByBillID(billID);
            if (billrow==null)
            {
                billsTableAdapter.Insert(billID, agentid, dateTimePicker1.Value,0,0,0);
                billrow = storeDataSet.bills.FindByBillID(billID);
            }


            #endregion


            // add items sales 

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

          


        }



        private void updatedataset()
        {
            billsTableAdapter.Fill(storeDataSet.bills);
            salesitemsTableAdapter.Fill(storeDataSet.salesitems);
            itemsTableAdapter.Fill(storeDataSet.items);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            // find paid ammount
            DataRow billrow;
            int paid;
            int remaining;
            billrow = storeDataSet.bills.FindByBillID(billID);

            int.TryParse(billrow["Paid"].ToString(), out paid);
            int.TryParse(billrow["Remaining"].ToString(), out remaining);

            Console.WriteLine(paid);
            //put ammount in the vault

            DataRow vaultrow = storeDataSet.vault.FindByidVault(0);

            int oldvalue, newvalue;
            int.TryParse(vaultrow["In_Hand"].ToString(), out oldvalue);

            Console.WriteLine(oldvalue);
            newvalue = oldvalue + paid;
            Console.WriteLine(newvalue);
            vaultrow["In_Hand"] = newvalue;

            vaultTableAdapter.Update(vaultrow);

            // find agent id
            int agentID;
            int.TryParse(billrow["Agents_AgentID"].ToString(), out agentID);

            //find old debt
            int debt;
            DataRow agentrow = storeDataSet.agents.FindByAgentID(agentID);
            int.TryParse(agentrow["Debt"].ToString(), out debt);

            int newdebt = debt + remaining;

            //add newdebt to agent
            agentrow["Debt"] = newdebt;

            // update agent
            agentsTableAdapter.Update(agentrow);


            updatedataset();
            totalbill = 0;

            billID = storeDataSet.bills.Count + 1;

            Txt_BillID.Text = billID.ToString();
            salesitemsBindingSource.Filter = "Bills_BillID='" + billID + "'";
        }

        private void Cmb_ItemName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
 
    }
}
    
