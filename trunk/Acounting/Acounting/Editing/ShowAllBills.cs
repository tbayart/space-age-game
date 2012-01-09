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
        // Stores the instance of the current form.
        private static ShowAllBills form;

        public static ShowAllBills GetForm(Form Main)
        {
            // If the form is null, create it here.
            if (form == null)
            {
                // Create it here.
                form = new ShowAllBills(Main);

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
    


        Form main;
        public ShowAllBills(Form Main)
        {
            this.main = Main;
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
                row["Type"] = Properties.Settings.Default.type1;
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
                row["Type"] = Properties.Settings.Default.type2;
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
                row["Type"] = Properties.Settings.Default.type3;
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
                row["Type"] = Properties.Settings.Default.type4;
                
                virtualtable.Rows.Add(row);
            }

        }

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int billID;
            DateTime date;
            double totalbill = 0;
            double paid;
            double remaining;
            string type;
            int name_id;
            string name_name;

            if (e.RowIndex  < 0)
            {
                return;
            }
            if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out billID))
            {
                type = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), out date);

                double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), out totalbill);
                double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), out paid);
                double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(), out remaining);

                name_name = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(), out name_id);
              

                EditBills edit = new EditBills(billID, date, totalbill, paid, remaining, type, name_id, name_name);
                edit.MdiParent = main;
                edit.Show();
            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
