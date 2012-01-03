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
        ResourceManager rm;
        public Vault()
        {
            InitializeComponent();
        }

        private void Vault_Load(object sender, EventArgs e)
        {
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


            Txt_Nettotalbills.Text = netbills.ToString();

            Txt_Nettotalpurchasebills.Text = netpurchasebills.ToString();

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
