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
    public partial class Payments : Form
    {
        int selectedagentid=0;
        int selectedDealerID=0;
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet1.vault' table. You can move, or remove it, as needed.
            this.vaultTableAdapter.Fill(this.storeDataSet.vault);
            // TODO: This line of code loads data into the 'storeDataSet1.spendings' table. You can move, or remove it, as needed.
            this.spendingsTableAdapter.Fill(this.storeDataSet.spendings);
            // TODO: This line of code loads data into the 'storeDataSet.dealers' table. You can move, or remove it, as needed.
            this.dealersTableAdapter.Fill(this.storeDataSet.dealers);
            // TODO: This line of code loads data into the 'storeDataSet.dealerpayments' table. You can move, or remove it, as needed.
            this.dealerpaymentsTableAdapter.Fill(this.storeDataSet.dealerpayments);
            // TODO: This line of code loads data into the 'storeDataSet.payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.storeDataSet.payments);
            // TODO: This line of code loads data into the 'storeDataSet.agents' table. You can move, or remove it, as needed.
            this.agentsTableAdapter.Fill(this.storeDataSet.agents);
            comboBox1_TextChanged(null, null);

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                 
                if (!(comboBox1.Text == ""))
                {
                    DataRow filterrow = storeDataSet.agents.AsEnumerable().Where(i => i.Field<string>("AgentName") == comboBox1.Text).FirstOrDefault();
                    Txt_Debt.Text = filterrow["Debt"].ToString();
                    int.TryParse(filterrow["AgentID"].ToString(), out selectedagentid);
                }

            }
            catch (Exception ee)
            {
                errorProvider1.SetError(comboBox1, ee.Message);
            }
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //get last id
            int lastid=0;
            int ammount;

            if (Txt_Debt.Text =="")
            {
                errorProvider1.SetError(Txt_Debt, "Wrong Number !!");
                return;
            }

            //get ammount paid
            if (!int.TryParse(Txt_Ammount.Text,out ammount))
            {
                errorProvider1.SetError(Txt_Ammount,"Wrong Number !!");
                return;
            }

            
            if (storeDataSet.payments.Count == 0)
            {
                lastid = 1;
            }
            else
            {
                // get last idnumber
                DataRow lastrow = storeDataSet.payments.Last();

                int.TryParse(lastrow["Id"].ToString(), out lastid);

                lastid++;
            }

            //insert payment
            paymentsTableAdapter.Insert(lastid, DateTime.Now, ammount, selectedagentid);

            //decrement agent debt
            DataRow agentrow = storeDataSet.agents.FindByAgentID(selectedagentid);

            int olddebt, newdebt;
            int.TryParse(agentrow["Debt"].ToString(), out olddebt);
            newdebt = olddebt + ammount;

            agentrow["Debt"] = newdebt;
            agentsTableAdapter.Update(agentrow);

            //add mount payed to the vault
            int oldinhand, newinhand;
            DataRow vaultrow = storeDataSet.vault.First();

            int.TryParse(vaultrow["In_Hand"].ToString(), out oldinhand);
            Console.WriteLine(oldinhand);
            newinhand = oldinhand + ammount;
            Console.WriteLine(newinhand);
            vaultrow["In_Hand"] = newinhand;

            vaultTableAdapter.Update(vaultrow);


            vaultTableAdapter.Fill(storeDataSet.vault);
            agentsTableAdapter.Fill(storeDataSet.agents);
            paymentsTableAdapter.Fill(storeDataSet.payments);

            Txt_Ammount.Text = "";
            Txt_Ammount.Focus();
            comboBox1_TextChanged(null, null);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //get last id
            int lastid = 0;
            int ammount;

            //check dealer name

            if (Txt_DealerDebt.Text=="")
            {
                errorProvider1.SetError(Txt_DealerDebt, "Wrong Number !!");
                return;
            }


            //get ammount paid
            if (!int.TryParse(Txt_DealerAmmount.Text, out ammount))
            {
                errorProvider1.SetError(Txt_DealerAmmount, "Wrong Number !!");
                return;
            }


            if (storeDataSet.dealerpayments.Count == 0)
            {
                lastid = 1;
            }
            else
            {
                // get last idnumber
                DataRow lastrow = storeDataSet.dealerpayments.Last();

                int.TryParse(lastrow["PaymentID"].ToString(), out lastid);

                lastid++;
            }

            //insert payment
            dealerpaymentsTableAdapter.Insert(lastid, DateTime.Now, ammount, selectedDealerID);

            //decrement agent debt
            DataRow dealerrow = storeDataSet.dealers.FindByDealerID(selectedDealerID);

            int olddebt, newdebt;
            int.TryParse(dealerrow["Debt"].ToString(), out olddebt);
            newdebt = olddebt + ammount;

            dealerrow["Debt"] = newdebt;
            dealersTableAdapter.Update(dealerrow);


            //add mount payed to the vault
            int oldinhand, newinhand;
            DataRow vaultrow = storeDataSet.vault.First();

            int.TryParse(vaultrow["In_Hand"].ToString(), out oldinhand);
            newinhand = oldinhand - ammount;

            vaultrow["In_Hand"] = newinhand;

            vaultTableAdapter.Update(vaultrow);


            vaultTableAdapter.Fill(storeDataSet.vault);
            dealersTableAdapter.Fill(storeDataSet.dealers);
            dealerpaymentsTableAdapter.Fill(storeDataSet.dealerpayments);

            Txt_DealerAmmount.Text = "";
            Txt_DealerAmmount.Focus();

            Cmb_Dealer_TextChanged(null, null);
        }

        private void Cmb_Dealer_TextChanged(object sender, EventArgs e)
        {


            errorProvider1.Clear();
            try
            {

                if (!(Cmb_Dealer.Text == ""))
                {
                    DataRow filterrow = storeDataSet.dealers.AsEnumerable().Where(i => i.Field<string>("DealerName") == Cmb_Dealer.Text).FirstOrDefault();
                    if (filterrow == null)
                    {
                        return;
                    }
                    Txt_DealerDebt.Text = filterrow["Debt"].ToString();
                    int.TryParse(filterrow["DealerID"].ToString(), out selectedDealerID);
                }

            }
            catch (Exception ee)
            {
                errorProvider1.SetError(Cmb_Dealer, ee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //get last id
            int lastid = 0;
            int ammount;

            //get ammount paid
            if (!int.TryParse(Txt_SpendingsAmmount.Text, out ammount))
            {
                errorProvider1.SetError(Txt_SpendingsAmmount, "Wrong Number !!");
            }


            if (storeDataSet.spendings.Count == 0)
            {
                lastid = 1;
            }
            else
            {
                // get last idnumber
                DataRow lastrow = storeDataSet.spendings.Last();

                int.TryParse(lastrow["ID"].ToString(), out lastid);

                lastid++;
            }

            //insert payment
            spendingsTableAdapter.Insert(lastid, DateTime.Now, ammount);

            //add mount payed to the vault
            int oldinhand, newinhand;
            DataRow vaultrow = storeDataSet.vault.First();

            int.TryParse(vaultrow["In_Hand"].ToString(), out oldinhand);
            newinhand = oldinhand - ammount;
            vaultrow["In_Hand"] = newinhand;
            vaultTableAdapter.Update(vaultrow);


            vaultTableAdapter.Fill(storeDataSet.vault);
            spendingsTableAdapter.Fill(storeDataSet.spendings);

            Txt_SpendingsAmmount.Text = "";
            Txt_SpendingsAmmount.Focus();

        }
    }
}
