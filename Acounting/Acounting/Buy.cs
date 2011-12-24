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




    }
}
