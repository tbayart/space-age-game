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
    public partial class ShowAllBills : Form
    {
        public ShowAllBills()
        {
            InitializeComponent();
        }
        DataTable virtualtable;
        private void ShowAllBills_Load(object sender, EventArgs e)
        {
            virtualtable = storeDataSet.AllBills.Clone();
            dataGridView1.DataSource = virtualtable;
            this.namesTableAdapter.Fill(this.storeDataSet.names);
            this.purchasebillsreturnTableAdapter.Fill(this.storeDataSet.purchasebillsreturn);
            this.purchasebillsTableAdapter.Fill(this.storeDataSet.purchasebills);
            this.billsreturnTableAdapter.Fill(this.storeDataSet.billsreturn);
            this.billsTableAdapter.Fill(this.storeDataSet.bills);


            DataRow row;
            foreach (DataRow item in storeDataSet.bills.Rows)
            {
                row= virtualtable.NewRow();
                row["Bill_ID"] = item["BillID"];
                row["DocDate"] = item["DocDate"];
                row["TotalBill"] = item["TotalBill"];
                row["Paid"] = item["Paid"];
                row["Remaining"] = item["Remaining"];
                row["Names_ID"] = item["Names_ID"];
                int id=0;
                int.TryParse(row["Names_ID"].ToString(),out id);
                DataRow names = storeDataSet.names.FindByID(id);
                row["Names_Name"] = names["Name"];
                row["Type"] = 1;
                virtualtable.Rows.Add(row);
            }

            foreach (DataRow item in storeDataSet.billsreturn.Rows)
            {
                row = virtualtable.NewRow();
                row["Bill_ID"] = item["BillID"];
                row["DocDate"] = item["DocDate"];
                row["TotalBill"] = item["TotalBill"];
                row["Paid"] = item["Paid"];
                row["Remaining"] = item["Remaining"];
                row["Names_ID"] = item["Names_ID"];
                int id = 0;
                int.TryParse(row["Names_ID"].ToString(), out id);
                DataRow names = storeDataSet.names.FindByID(id);
                row["Names_Name"] = names["Name"];
                row["Type"] = 2;
                virtualtable.Rows.Add(row);
            }

            foreach (DataRow item in storeDataSet.purchasebills.Rows)
            {
                row = virtualtable.NewRow();
                row["Bill_ID"] = item["BillID"];
                row["DocDate"] = item["DocDate"];
                row["TotalBill"] = item["TotalBill"];
                row["Paid"] = item["Paid"];
                row["Remaining"] = item["Remaining"];
                row["Names_ID"] = item["Names_ID"];
                int id = 0;
                int.TryParse(row["Names_ID"].ToString(), out id);
                DataRow names = storeDataSet.names.FindByID(id);
                row["Names_Name"] = names["Name"];
                row["Type"] = 3;
                virtualtable.Rows.Add(row);
            }

            foreach (DataRow item in storeDataSet.purchasebillsreturn.Rows)
            {
                row = virtualtable.NewRow();
                row["Bill_ID"] = item["BillID"];
                row["DocDate"] = item["DocDate"];
                row["TotalBill"] = item["TotalBill"];
                row["Paid"] = item["Paid"];
                row["Remaining"] = item["Remaining"];
                row["Names_ID"] = item["Names_ID"];
                int id = 0;
                int.TryParse(row["Names_ID"].ToString(), out id);
                DataRow names = storeDataSet.names.FindByID(id);
                row["Names_Name"] = names["Name"];
                row["Type"] = 4;
                virtualtable.Rows.Add(row);
            }

        }
    }
}
