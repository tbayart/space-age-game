﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Acounting
{
    public partial class DealersDebt : Form
    {
        // Stores the instance of the current form.
        private static DealersDebt form;

        public static DealersDebt GetForm()
        {
            // If the form is null, create it here.
            if (form == null)
            {
                // Create it here.
                form = new DealersDebt();

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
    

        public DealersDebt()
        {
            InitializeComponent();
        }

        private void DealersDebt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.names' table. You can move, or remove it, as needed.
            this.namesTableAdapter.Fill(this.storeDataSet.names);
            // TODO: This line of code loads data into the 'storeDataSet.bills' table. You can move, or remove it, as needed.
            this.billsTableAdapter.Fill(this.storeDataSet.bills);
            // TODO: This line of code loads data into the 'storeDataSet.billsreturn' table. You can move, or remove it, as needed.
            this.billsreturnTableAdapter.Fill(this.storeDataSet.billsreturn);
            // TODO: This line of code loads data into the 'storeDataSet.payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.storeDataSet.payments);
            // TODO: This line of code loads data into the 'storeDataSet.Dealers' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'storeDataSet.purchasebills' table. You can move, or remove it, as needed.
            this.purchasebillsTableAdapter.Fill(this.storeDataSet.purchasebills);
            // TODO: This line of code loads data into the 'storeDataSet.purchasebillsreturn' table. You can move, or remove it, as needed.
            this.purchasebillsreturnTableAdapter.Fill(this.storeDataSet.purchasebillsreturn);
            // TODO: This line of code loads data into the 'storeDataSet.dealerpayments' table. You can move, or remove it, as needed.
            this.dealerpaymentsTableAdapter.Fill(this.storeDataSet.dealerpayments);
            // TODO: This line of code loads data into the 'storeDataSet.dealers' table. You can move, or remove it, as needed.



            string imgurl="",cName = "", cMobile1 = "", cMobile2 = "", cTelephone = "", cAddress = "";
            Boolean showimg = false;
            try
            {
                cName = Application.UserAppDataRegistry.GetValue("cName").ToString();
                cMobile1 = Application.UserAppDataRegistry.GetValue("cMobile1").ToString();
                cMobile2 = Application.UserAppDataRegistry.GetValue("cMobile2").ToString();
                cTelephone = Application.UserAppDataRegistry.GetValue("cTelephone").ToString();
                cAddress = Application.UserAppDataRegistry.GetValue("cAddress").ToString();

            }
            catch (Exception ee)
            {
                Program.mylog.LogError(Environment.NewLine + ee.Message + Environment.NewLine);
            }


            setreportparameters(cName, imgurl, showimg, 
                cMobile1, cMobile2, cAddress,cTelephone);

        }

        private void setreportparameters(string CName,string imgurl, Boolean showimg,
            string CMobile1,string CMobile2,string CAddress,string CTelephone)
        {

            ReportParameter p1 = new ReportParameter("CName", CName);
            ReportParameter p5 = new ReportParameter("CMobile1", CMobile1);
            ReportParameter p6 = new ReportParameter("CMobile2", CMobile2);
            ReportParameter p7 = new ReportParameter("CAddress", CAddress);
            ReportParameter p8 = new ReportParameter("CTelephone", CTelephone);

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1,p5,p6,p7,p8 });

            this.reportViewer1.RefreshReport();

        }





        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //get agentid
                int dealerid = 0;

                DataRow filterrow = storeDataSet.names.AsEnumerable().Where(i => i.Field<string>("Name") == comboBox1.Text).FirstOrDefault();

                if (filterrow == null)
                {
                    return;
                }
                if (!int.TryParse(filterrow["ID"].ToString(), out dealerid))
                {
                    return;
                }
                //filter the data
                purchasebillsBindingSource.Filter = "Names_ID = '" + dealerid.ToString() + "'";
                purchasebillsreturnBindingSource.Filter = "Names_ID = '" + dealerid.ToString() + "'";
                billsBindingSource.Filter = "Names_ID = '" + dealerid.ToString() + "'";
                billsreturnBindingSource.Filter = "Names_ID = '" + dealerid.ToString() + "'";

                namesBindingSource.Filter = "ID = '" + dealerid.ToString() + "'";
                paymentsBindingSource.Filter = "Names_ID = '" + dealerid.ToString() + "'";
                dealerpaymentsBindingSource.Filter = "Names_ID = '" + dealerid.ToString() + "'";
                //refresh the report
                reportViewer1.RefreshReport();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                purchasebillsBindingSource.RemoveFilter();
                purchasebillsreturnBindingSource.RemoveFilter();
                billsBindingSource.RemoveFilter();
                billsreturnBindingSource.RemoveFilter();  

                namesBindingSource.RemoveFilter(); 
                paymentsBindingSource.RemoveFilter(); 
                dealerpaymentsBindingSource.RemoveFilter();
                reportViewer1.RefreshReport();
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;

            }
        }
    }
}
