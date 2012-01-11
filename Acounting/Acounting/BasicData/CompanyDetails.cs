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
    public partial class CompanyDetails : Form
    {
        public CompanyDetails()
        {
            InitializeComponent();
        }

        private void CompanyDetails_Load(object sender, EventArgs e)
        {
            string cName = "", cMobile1 = "", cMobile2 = "", cTelephone = "", cAddress = "";
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
           
            Txt_CAddress.Text = cAddress;
            Txt_CMobile1.Text = cMobile1;
            Txt_CMobile2.Text = cMobile2;
            Txt_CName.Text = cName;
            Txt_CTelephone.Text = cTelephone;

              
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            string cName, cMobile1, cMobile2, cTelephone, cAddress;


            cAddress = Txt_CAddress.Text;
            cMobile1 = Txt_CMobile1.Text;
            cMobile2 = Txt_CMobile2.Text;
            cName = Txt_CName.Text;
            cTelephone = Txt_CTelephone.Text;


            try
            {
                Application.UserAppDataRegistry.SetValue("cName", cName);
                Application.UserAppDataRegistry.SetValue("cMobile1", cMobile1);
                Application.UserAppDataRegistry.SetValue("cMobile2", cMobile2);
                Application.UserAppDataRegistry.SetValue("cTelephone", cTelephone);
                Application.UserAppDataRegistry.SetValue("cAddress", cAddress);

            }
            catch (Exception ee)
            {

                Program.mylog.LogError(Environment.NewLine + ee.Message + Environment.NewLine);
            }

            Btn_Exit_Click(null, null);
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
