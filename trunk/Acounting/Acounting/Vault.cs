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
    public partial class Vault : Form
    {
        public Vault()
        {
            InitializeComponent();
        }

        private void Vault_Load(object sender, EventArgs e)
        {
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
                
                
            }
           


        }
    }
}
