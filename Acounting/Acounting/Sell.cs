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
        double totalbill = 0;
        int billID;
        DataTable virtualdata;
        int salesID;
        double totalprice;
        double earnings;
        double remaining;
        int agentid;
  


        public Sell()
        {
            InitializeComponent();
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.names' table. You can move, or remove it, as needed.
            this.namesTableAdapter.Fill(this.storeDataSet.names);
            this.salesDetailsTableAdapter.Fill(this.storeDataSet.SalesDetails);              
            this.vaultTableAdapter.Fill(this.storeDataSet.vault);
            this.salesitemsTableAdapter.Fill(this.storeDataSet.salesitems);
            this.billsTableAdapter.Fill(this.storeDataSet.bills);
            this.itemsTableAdapter.Fill(this.storeDataSet.items);


            virtualdata = storeDataSet.SalesDetails.Clone();
            dataGridView1.DataSource = virtualdata;

            //get lastid
            salesID = storeDataSet.salesitems.Rows.Count;

            Cmb_ItemName_TextChanged(null, null);
            Cmb_AgentName_TextChanged(null, null);


            // new bill id
            billID = storeDataSet.bills.Count + 1;
            Txt_BillID.Text = billID.ToString();
  
          
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
            DataTable agents = storeDataSet.names;
            try
            {
                DataRow filterrow = agents.AsEnumerable().Where(i => i.Field<string>("Name") == Cmb_AgentName.Text && (i.Field<UInt64>("TypeAgent") != 0)).FirstOrDefault();
                
                Txt_AgentID.Text = filterrow["ID"].ToString();

                if (!int.TryParse(Txt_AgentID.Text, out agentid))
                {
                    errorProvider1.SetError(Txt_AgentID, "Error With AgentID");
                    return;
                }
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

            if (Txt_AgentID.Text == "")
            {
                errorProvider1.SetError(Cmb_AgentName, "Error with agentID");
                return;
            }
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

            if (!double.TryParse(Txt_ToSell.Text, out sellqty))
            {
                errorProvider1.SetError(Txt_ToSell, "Error With SellQty");
                Txt_ToSell.Focus();
                return;
            }
            else if (sellqty <=0)
            {
                errorProvider1.SetError(Txt_ToSell, "Less Than 0 ITEM ?????!!");
                Txt_ToSell.Focus();
                return;
            }

            double originalqty;
            double.TryParse(itemrow["Qty"].ToString(), out originalqty);

            if (sellqty>originalqty)
            {
                errorProvider1.SetError(Txt_ToSell, "Not enough items in stock");
                Txt_ToSell.Focus();
                return;
            }


            double sellprice;
            if (!double.TryParse(Txt_SellPrice.Text, out sellprice))
            {
                errorProvider1.SetError(Txt_SellPrice, "Error With Sellprice");
                Txt_SellPrice.Focus();
                return;
            }

            #endregion

            salesID++;
            
            totalprice = sellprice*sellqty;
            earnings = totalprice - (sellqty*cost);

            double billpaid;
            if (!double.TryParse(Txt_Paid.Text, out billpaid))
            {
                errorProvider1.SetError(Txt_Paid, "Error With Paid !");
                Txt_Paid.Focus();
                return;
            }

           

            
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

            remaining = totalbill - billpaid;
        
            Txt_TotalBill.Text = totalbill.ToString();
            Txt_Remaining.Text = remaining.ToString();
   


            // update items to reduce items qty


           itemrow = storeDataSet.items.FindByItemID(itemid);
           double.TryParse(itemrow["Qty"].ToString(), out originalqty);
           double newqty = originalqty - sellqty;
           itemrow["Qty"] = newqty;



           Cmb_ItemName_TextChanged(null, null);
           Cmb_AgentName_TextChanged(null, null);
           #endregion

           clear_items();


      
        }

        private void clear_items()
        {

            //clear items data
            Txt_ToSell.Text = "";
            Txt_SellPrice.Text = "";
            Cmb_AgentName.Enabled = false;
            button2.Enabled = true;
        }
        private void reset_back()
        {
            Cmb_AgentName.Enabled = true;
            Txt_SellPrice.Text = "";
            Txt_ToSell.Text = "";
            Txt_Paid.Text = "";
        }


        private void updatedataset()
        {
            billsTableAdapter.Update(storeDataSet);
            salesitemsTableAdapter.Update(storeDataSet);
            
            itemsTableAdapter.Update(storeDataSet);
            namesTableAdapter.Update(storeDataSet);
            vaultTableAdapter.Update(storeDataSet); 
        }

        private void button2_Click(object sender, EventArgs e)
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
                DataRow billrow = storeDataSet.bills.NewRow();

                billrow[0] = billID;               
                billrow[1] = DateTime.Now;
                billrow[2] = totalbill;
                billrow[3] = paid;
                billrow[4] = remaining;
                billrow[5] = agentid;

                storeDataSet.bills.Rows.Add(billrow);


                // get vault row for manipulation
                DataRow vaultrow = storeDataSet.vault.FindByidVault(0);

                double oldvalue, newvalue;
                double.TryParse(vaultrow["In_Hand"].ToString(), out oldvalue);

                Console.WriteLine(oldvalue);
                newvalue = oldvalue + paid;
                Console.WriteLine(newvalue);
                vaultrow["In_Hand"] = newvalue;

                            
                //find old debt
                double debt;
                DataRow agentrow = storeDataSet.names.FindByID(agentid);
                double.TryParse(agentrow["Debt"].ToString(), out debt);

                double newdebt = debt + remaining;

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
 

            #endregion 

                //reset back 
                reset_back();
            }
            
        }

       

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_Paid_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            double billpaid;
            if (!double.TryParse(Txt_Paid.Text, out billpaid))
            {
                errorProvider1.SetError(Txt_Paid,"Error With Paid Value");
                return;
            }

            remaining = totalbill - billpaid;
            Txt_Remaining.Text = remaining.ToString();
        }

        private void Cmb_AgentName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.namesTableAdapter.FillBy3(this.storeDataSet.names);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

 
 
    }
}
    
