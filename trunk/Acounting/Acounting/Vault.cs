using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace Acounting
{
    public partial class Vault : Form
    {
        // Stores the instance of the current form.
        private static Vault form;

        public static Vault GetForm()
        {
            // If the form is null, create it here.
            if (form == null)
            {
                // Create it here.
                form = new Vault();

                // Handle the closed event, when closed, set the form to null.
                // This syntax is for .NET 2.0. You can just create a delegate and
                //add that
                // to the form for previous versions.
                form.Closed += delegate
                {
                    // Set form to null.
                    form = null;
                };
            }

            // Return the form.
            return form;
        }


        ResourceManager rm;
        public Vault()
        {
            InitializeComponent();
        }

        private void Vault_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.names' table. You can move, or remove it, as needed.
            this.namesTableAdapter.Fill(this.storeDataSet.names);
            // TODO: This line of code loads data into the 'storeDataSet.TotalSpendings' table. You can move, or remove it, as needed.
            this.totalSpendingsTableAdapter.Fill(this.storeDataSet.TotalSpendings);
            // TODO: This line of code loads data into the 'storeDataSet1.TotalPurchasereturnRemaining' table. You can move, or remove it, as needed.
            this.totalPurchasereturnRemainingTableAdapter.Fill(this.storeDataSet1.TotalPurchasereturnRemaining);
            // TODO: This line of code loads data into the 'storeDataSet1.TotalBillsreturnRemaining' table. You can move, or remove it, as needed.
            this.totalBillsreturnRemainingTableAdapter.Fill(this.storeDataSet1.TotalBillsreturnRemaining);
            // TODO: This line of code loads data into the 'storeDataSet1.TotalBillsRemaining' table. You can move, or remove it, as needed.
            this.totalBillsRemainingTableAdapter.Fill(this.storeDataSet1.TotalBillsRemaining);
            // TODO: This line of code loads data into the 'storeDataSet1.TotalPruchaseRemaining' table. You can move, or remove it, as needed.
            this.totalPruchaseRemainingTableAdapter.Fill(this.storeDataSet1.TotalPruchaseRemaining);
            // TODO: This line of code loads data into the 'storeDataSet.TotalEarnings' table. You can move, or remove it, as needed.
            this.totalEarningsTableAdapter.Fill(this.storeDataSet.TotalEarnings);
            // TODO: This line of code loads data into the 'storeDataSet.TotalBillsReturn' table. You can move, or remove it, as needed.
            this.totalBillsReturnTableAdapter.Fill(this.storeDataSet.TotalBillsReturn);
            // TODO: This line of code loads data into the 'storeDataSet.TotalBills' table. You can move, or remove it, as needed.
            this.totalBillsTableAdapter.Fill(this.storeDataSet.TotalBills);
            // TODO: This line of code loads data into the 'storeDataSet.TotalPurchasesReturn' table. You can move, or remove it, as needed.
            this.totalPurchasesReturnTableAdapter.Fill(this.storeDataSet.TotalPurchasesReturn);
            // TODO: This line of code loads data into the 'storeDataSet.TotalPurchase' table. You can move, or remove it, as needed.
            this.totalPurchaseTableAdapter.Fill(this.storeDataSet.TotalPurchase);
            // TODO: This line of code loads data into the 'storeDataSet.paid' table. You can move, or remove it, as needed.
            this.paidTableAdapter.Fill(this.storeDataSet.paid);
            // TODO: This line of code loads data into the 'storeDataSet.collected' table. You can move, or remove it, as needed.
            this.collectedTableAdapter.Fill(this.storeDataSet.collected);
            // TODO: This line of code loads data into the 'storeDataSet.vault' table. You can move, or remove it, as needed.
            this.vaultTableAdapter.Fill(this.storeDataSet.vault);
            Cmd_Add.Enabled = false;
            Txt_AddOpenning.ReadOnly = true;

            double DatabaseOpenning;

            Console.WriteLine(Txt_AddOpenning.Text);

            rm = new ResourceManager(this.GetType());

            DataRow row1 = storeDataSet.vault.FindByidVault(0);
            if (row1 == null)
            {
                Cmd_Add.Enabled = true;
                Txt_AddOpenning.ReadOnly = false;
            }
            else
            {
                double.TryParse(row1["Opennings"].ToString(), out DatabaseOpenning);
                if (DatabaseOpenning == 0)
                {
                    Cmd_Add.Enabled = true;
                    Txt_AddOpenning.ReadOnly = false;
                }
                else
                {
                    Cmd_Add.Enabled = false;
                    Txt_AddOpenning.ReadOnly = true;
                }
            }

            int totalbills, totalbillsreturn, totalpurchasebills, totalpurchasebillsreturn;
            int.TryParse(Txt_totalbills.Text, out totalbills);
            int.TryParse(Txt_totalbillsreturn.Text, out totalbillsreturn);
            int.TryParse(Txt_totalpurchasebills.Text, out totalpurchasebills);
            int.TryParse(Txt_totalpurchasebillsreturn.Text, out totalpurchasebillsreturn);

            int netbills = totalbills - totalbillsreturn;
            int netpurchasebills = totalpurchasebills - totalpurchasebillsreturn;


            int dealerdebt, totalpurchaseremaining, totalpurchasereturnremaining, agentdebt, totalbillremaining, totalbillreturnremaing;


            int.TryParse(storeDataSet1.TotalPruchaseRemaining.Rows[0][0].ToString(), out totalpurchaseremaining);
            int.TryParse(storeDataSet1.TotalPurchasereturnRemaining.Rows[0][0].ToString(), out totalpurchasereturnremaining);

            int.TryParse(storeDataSet1.TotalBillsRemaining.Rows[0][0].ToString(), out totalbillremaining);
            int.TryParse(storeDataSet1.TotalBillsreturnRemaining.Rows[0][0].ToString(), out totalbillreturnremaing);

            dealerdebt = totalpurchaseremaining - totalpurchasereturnremaining;
            agentdebt = totalbillremaining - totalbillreturnremaing;

            gettotal();

            dealerdebt += totaldealer;
            agentdebt += totalagent;


            Txt_DealerDebt.Text = dealerdebt.ToString();
            Txt_AgentDebt.Text = agentdebt.ToString();


            Txt_Nettotalbills.Text = netbills.ToString();
            Txt_Nettotalpurchasebills.Text = netpurchasebills.ToString();


            


        }
        int totalagent = 0;
        int totaldealer = 0;
        public void gettotal()
        {

            int current = 0;
            foreach (DataRow item in storeDataSet.names)
            {
                int.TryParse(item["InitialDebt"].ToString(), out current);
                if (current >0)
                {
                    totalagent += current;
                }
                else if(current<0)
                {
                    totaldealer += current;
                }
            }
        }

        private void Cmd_Add_Click(object sender, EventArgs e)
        {
             
            double Openning;
            
            DataRow row1 = storeDataSet.vault.FindByidVault(0);
            if (row1 == null)
            {
                if (double.TryParse(Txt_AddOpenning.Text, out Openning))
                {
                    vaultTableAdapter.Insert(0, Openning, Openning);
                    Cmd_Add.Enabled = false;
                    Txt_AddOpenning.ReadOnly = true;

                }
                else
                {
                    errorProvider1.SetError(Txt_AddOpenning,rm.GetString("AddOpenningerr",Program.cul));
                }
                
                
            }
           


        }
    }
}
