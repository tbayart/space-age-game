using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Diagnostics;
using System.IO;
namespace MySQL_Backup_and_Restore
{
    public partial class BackupAr : Form
    {
        public BackupAr()
        {
            InitializeComponent();

        }




        private void button_Backup_Click(object sender, EventArgs e)
        {

            Backup();

        }



        private void button_Restore_Click(object sender, EventArgs e)
        {


            Restore();
        }

        public void Backup()
        {
            // Locate backup file -----------------------------

            string filename = "";
            string orgfilename = "C:\\Program Files\\MySQL\\MySQL Server 5.5\\bin\\backup.sql";
            SaveFileDialog f2 = new SaveFileDialog();
            f2.Title = "فتح ملف الحفظ";
            f2.Filter = "Backup files (*.backup)|*.backup";
            if (DialogResult.OK != f2.ShowDialog())
                return;

            filename = f2.FileName;

            ProcessStartInfo proc = new ProcessStartInfo("Backup.bat");
            Process proccess = Process.Start(proc);
            File.Copy(orgfilename, filename,true);
            File.Delete(orgfilename);
        }

        private void Encrypt(string backupFile)
        {
            //  throw new NotImplementedException();
        }

        public void Restore()
        {
            // Locate backup file -----------------------------

            string filename = "";
            string orgfilename = "C:\\Program Files\\MySQL\\MySQL Server 5.5\\bin\\backup.sql";
            OpenFileDialog f2 = new OpenFileDialog();
            f2.Title = "فتح ملف الحفظ";
            f2.Filter = "Backup files (*.backup)|*.backup";
            if (DialogResult.OK != f2.ShowDialog())
                return;

            filename = f2.FileName;
            File.Copy(filename, orgfilename,true);

            ProcessStartInfo proc = new ProcessStartInfo("Restore.bat");
            Process proccess = Process.Start(proc);


        }
    }
}
