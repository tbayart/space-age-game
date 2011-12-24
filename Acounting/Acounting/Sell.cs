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
        DataTable virtualdata;
        int salesID;
        int totalprice;
        int earnings;
        int remaining;
        int agentid;
        List<DataRow> itemstosell;


        public Sell()
        {
            InitializeComponent();
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.SalesDetails' table. You can move, or remove it, as needed.
            this.salesDetailsTableAdapter.Fill(this.storeDataSet.SalesDetails);
     
            this.spendingsTableAdapter.Fill(this.storeDataSet.spendings);
            this.vaultTableAdapter.Fill(this.storeDataSet.vault);
            this.salesitemsTableAdapter.Fill(this.storeDataSet.salesitems);
            this.billsTableAdapter.Fill(this.storeDataSet.bills);
            this.agentsTableAdapter.Fill(this.storeDataSet.agents);
            this.itemsTableAdapter.Fill(this.storeDataSet.items);

            //items to sell
            itemstosell = new List<DataRow>();

            virtualdata = storeDataSet.SalesDetails.Clone();
            dataGridView1.DataSource = virtualdata;

            //get lastid
            salesID = storeDataSet.salesitems.Rows.Count;

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

           
            if (!int.TryParse(Txt_AgentID.Text, out agentid))
            {
                errorProvider1.SetError(Txt_AgentID, "Error With AgentID");
                return;
            }

            salesID++;
            
            Console.WriteLine(storeDataSet.salesitems.Rows.Count);
          

            totalprice = sellprice*sellqty;
            earnings = totalprice - (sellqty*cost);

            int billpaid;
            if (!int.TryParse(Txt_Paid.Text, out billpaid))
            {
                errorProvider1.SetError(Txt_Paid, "Error With Paid !");
                return;
            }

            #endregion

            
            #region add items sales

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
            
            //add virtual data to datagrid

            DataRow detailsrow = virtualdata.NewRow();

            detailsrow[0] = Cmb_ItemName.Text;
            detailsrow[1] = sellqty;
            detailsrow[2] = sellprice;
            detailsrow[3] = totalprice;
            detailsrow[4] = earnings;

            virtualdata.Rows.Add(detailsrow);

            totalbill += totalprice;

            Console.WriteLine("added new sales " + salesID.ToString());

            //  update parameters for bill

            remaining = billpaid - totalbill;
        
            Txt_TotalBill.Text = totalbill.ToString();
            Txt_Remaining.Text = remaining.ToString();
   


            // update items to reduce items qty


           itemrow = storeDataSet.items.FindByItemID(itemid);
           int.TryParse(itemrow["Qty"].ToString(), out originalqty);
           int newqty = originalqty - sellqty;
           itemrow["Qty"] = newqty;


           
           Cmb_ItemName_TextChanged(null, null);
           Cmb_AgentName_TextChanged(null, null);
           #endregion

      
        }



        private void updatedataset()
        {
            billsTableAdapter.Update(storeDataSet);
            salesitemsTableAdapter.Update(storeDataSet);
            
            itemsTableAdapter.Update(storeDataSet);
            agentsTableAdapter.Update(storeDataSet);
            vaultTableAdapter.Update(storeDataSet);
/*
            this.vaultTableAdapter.Fill(this.storeDataSet.vault);
            this.salesitemsTableAdapter.Fill(this.storeDataSet.salesitems);
            this.billsTableAdapter.Fill(this.storeDataSet.bills);
            this.agentsTableAdapter.Fill(this.storeDataSet.agents);
            this.itemsTableAdapter.Fill(this.storeDataSet.items);
 * */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //show dialoge 

            DialogResult result = MessageBox.Show("Do you want to save ?", "Accounting", MessageBoxButtons.YesNo);
            
            
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                #region save


                // find paid ammount  
                int paid;

                int.TryParse(Txt_Paid.Text, out paid);
                
                //add bill
                DataRow billrow = storeDataSet.bills.NewRow();

                billrow[0] = billID;
                billrow[1] = agentid;
                billrow[2] = DateTime.Now;
                billrow[3] = totalbill;
                billrow[4] = paid;
                billrow[5] = remaining;
                storeDataSet.bills.Rows.Add(billrow);


                // get vault row for manipulation
                DataRow vaultrow = storeDataSet.vault.FindByidVault(0);

                int oldvalue, newvalue;
                int.TryParse(vaultrow["In_Hand"].ToString(), out oldvalue);

                Console.WriteLine(oldvalue);
                newvalue = oldvalue + paid;
                Console.WriteLine(newvalue);
                vaultrow["In_Hand"] = newvalue;

                            
                //find old debt
                int debt;
                DataRow agentrow = storeDataSet.agents.FindByAgentID(agentid);
                int.TryParse(agentrow["Debt"].ToString(), out debt);

                int newdebt = debt + remaining;

                //add newdebt to agent
                agentrow["Debt"] = newdebt;

                // update alll


                updatedataset();

                //reset globals
                totalbill = 0;
                totalprice = 0;
                earnings = 0;
                remaining = 0;

                virtualdata.Clear();


                billID = storeDataSet.bills.Count + 1;

                Txt_BillID.Text = billID.ToString();
                salesitemsBindingSource.Filter = "Bills_BillID='" + billID + "'";

            #endregion 
            }
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

 
 
    }
}
    
