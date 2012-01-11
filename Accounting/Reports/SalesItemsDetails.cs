using System;
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
    public partial class SalesItemsDetails : Form
    {
        // Stores the instance of the current form.
        private static SalesItemsDetails form;

        public static SalesItemsDetails GetForm()
        {
            // If the form is null, create it here.
            if (form == null)
            {
                // Create it here.
                form = new SalesItemsDetails();

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
    

        public SalesItemsDetails()
        {
            InitializeComponent();
        }

        private void SalesItemsDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.SalesItemsDetails' table. You can move, or remove it, as needed.
            this.salesItemsDetailsTableAdapter.Fill(this.storeDataSet.SalesItemsDetails);


            string imgurl = "", cName = "", cMobile1 = "", cMobile2 = "", cTelephone = "", cAddress = "";
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
                cMobile1, cMobile2, cAddress, cTelephone);

        }

        private void setreportparameters(string CName, string imgurl, Boolean showimg,
            string CMobile1, string CMobile2, string CAddress, string CTelephone)
        {

            ReportParameter p1 = new ReportParameter("CName", CName);
            ReportParameter p5 = new ReportParameter("CMobile1", CMobile1);
            ReportParameter p6 = new ReportParameter("CMobile2", CMobile2);
            ReportParameter p7 = new ReportParameter("CAddress", CAddress);
            ReportParameter p8 = new ReportParameter("CTelephone", CTelephone);

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1, p5, p6, p7, p8 });

            this.reportViewer1.RefreshReport();

        }
    }
}
