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

        string filename = "";
        string orgfilename = "C:\\Program Files\\MySQL\\MySQL Server 5.5\\bin\\backup.sql";

        public BackupAr()
        {
            InitializeComponent();

        }

        #region RESTORE

        private void button_Restore_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox_encryptKey.Text == "")
            {
                errorProvider1.SetError(textBox_encryptKey, "No Password");
                return;
            }


            progressBar1.Visible = true;

            OpenFileDialog f2 = new OpenFileDialog();
            f2.Title = "فتح ملف الحفظ";
            f2.Filter = "Backup files (*.backup)|*.backup";
            if (DialogResult.OK != f2.ShowDialog())
            {
                progressBar1.Visible = false;
                return;
            }

            filename = f2.FileName;

            backgroundRestore.RunWorkerAsync();
        }

        private void backgroundRestore_DoWork(object sender, DoWorkEventArgs e)
        {
            EncDec.Decrypt(filename, orgfilename, textBox_encryptKey.Text);

            ProcessStartInfo proc = new ProcessStartInfo("Restore.bat");
            proc.Verb = "runas";
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            Process proccess = Process.Start(proc);
            proccess.WaitForExit();
        }

        private void backgroundRestore_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = false;
            MessageBox.Show("Done");
        }

        private void backgroundRestore_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Visible = true;
        }

        #endregion


        #region BACKUP

        private void button_Backup_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox_encryptKey.Text == "")
            {
                errorProvider1.SetError(textBox_encryptKey, "No Password");
                return;
            }
            
            progressBar1.Visible = true;

            SaveFileDialog f2 = new SaveFileDialog();
            f2.Title = "فتح ملف الحفظ";
            f2.Filter = "Backup files (*.backup)|*.backup";
            if (DialogResult.OK != f2.ShowDialog())
            {
                progressBar1.Visible = false;
                return;
            }

            filename = f2.FileName;

            backgroundBackup.RunWorkerAsync();

        }

        private void backgroundBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo("Backup.bat");
            proc.Verb = "runas";
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            Process proccess = Process.Start(proc);
            File.Copy(orgfilename, filename, true);
            File.Delete(orgfilename);

            proccess.WaitForExit();

            EncDec.Encrypt(filename, filename + ".enc", textBox_encryptKey.Text);
            File.Copy(filename + ".enc", filename, true);
            File.Delete(filename + ".enc");
        }

        private void backgroundBackup_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Visible = true;
        }

        private void backgroundBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = false;
            MessageBox.Show("Done");
        }

        #endregion
    }
}
