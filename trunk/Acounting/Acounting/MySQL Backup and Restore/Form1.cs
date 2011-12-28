﻿// MySQL Backup & Restore V1.1
// Release Date: 20 Sep 2011
// Project Site: http://www.codeproject.com/KB/database/mysqlbackuprestore.aspx
// License: This article, along with any associated source code and files, 
//          is licensed under The Apache License, Version 2.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace MySQL_Backup_and_Restore
{
    public partial class Form1 : Form
    {
        public bool Construct_SQL_In_One_Line_From_Same_Table = true;
        public bool DropAndRecreateTable = false;
        public bool DropAndRecreateDatabase = false;
        public bool AddDateToFilename = false;
        public bool EnableEncryption = false;
        string backupFile = "";
        public string FileExtension = "backup";

        public Form1(string[] args)
        {
            InitializeComponent();
            checkBox_ConstructSQLIn1Line.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            checkBox_AddDate.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            checkBox_DropDatabase.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            checkBox_encryption.CheckedChanged += new EventHandler(checkBox_encryption_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

      
 
        void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        void checkBox_encryption_CheckedChanged(object sender, EventArgs e)
        {
            textBox_encryptKey.ReadOnly = !checkBox_encryption.Checked;
            EnableEncryption = checkBox_encryption.Checked;
        }

        void textBox_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {        

            DropAndRecreateDatabase = checkBox_DropDatabase.Checked;
            DropAndRecreateTable = checkBox_DeleteTable.Checked;
            Construct_SQL_In_One_Line_From_Same_Table = checkBox_ConstructSQLIn1Line.Checked;
            AddDateToFilename = checkBox_AddDate.Checked;
             

            EnableEncryption = checkBox_encryption.Checked;
        }


        private void button_Backup_Click(object sender, EventArgs e)
        {
            RefreshData();
            Backup();

        }

     

        private void button_Restore_Click(object sender, EventArgs e)
        {

            RefreshData();
            Restore();
        }

        public void Backup()
        {
            
            string filter = "";
            try
            {
                #region Get the Backup Filename and Path

                if (FileExtension != "") filter = "*." + FileExtension + "|*." + FileExtension;

                
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Title = "Save Database Backup File";
                    saveFileDialog1.Filter = filter;
                    if (DialogResult.OK != saveFileDialog1.ShowDialog())
                        return;
                    backupFile = saveFileDialog1.FileName;
                    if (AddDateToFilename)
                    {
                        if (FileExtension != "")
                            backupFile = backupFile.Replace("." + FileExtension, DateTime.Now.ToString(" yyyy-MM-dd-HH-mm-ss") + "." + FileExtension);
                        else
                            backupFile += DateTime.Now.ToString(" yyyy-MM-dd-HH-mm-ss");
                    }

               
                #endregion

                // Start Backup Process
                MySqlBackupRestore mb = new MySqlBackupRestore("localhost", "root", "", "store", "3306", "charset=utf8");
                mb.DropAndRecreateDatabase = DropAndRecreateDatabase;
                mb.DropAndRecreateTable = DropAndRecreateTable;
                mb.Construct_SQL_In_One_Line_From_Same_Table = Construct_SQL_In_One_Line_From_Same_Table;

                if (EnableEncryption)
                {
                    mb.EncryptBackupFile = EnableEncryption;
                    mb.EncryptionKey = textBox_encryptKey.Text;
                }

                mb.Backup(backupFile);

                Encrypt(backupFile);
                // End of Backup Process

                MessageBox.Show("Backup Successfully.\n\nYour backup file is created at:\r\n" + backupFile, "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) // Log any error that occur during the backup process
            {
                string errorMessage = "Backup fail.\r\n\r\n" + ex.ToString();
                MessageBox.Show(errorMessage, "Error");
            }
        }

        private void Encrypt(string backupFile)
        {
          //  throw new NotImplementedException();
        }

        public void Restore()
        {
            
            // Locate backup file -----------------------------

            string filename = "";
            OpenFileDialog f2 = new OpenFileDialog();
            f2.Title = "Open Database Backup File";
            f2.Filter = "*." + FileExtension + "|*." + FileExtension + "|All Files|*.*";
            if (DialogResult.OK != f2.ShowDialog())
                return;

            filename = f2.FileName;

            // End of Locate backup file ----------------------

            try
            {
                MySqlBackupRestore mb = new MySqlBackupRestore("localhost", "root", "", "store", "3306", "charset = utf8;");

                if (EnableEncryption)
                {
                    mb.Restore(filename, true, textBox_encryptKey.Text);
                }
                else
                {
                    mb.Restore(filename);
                }

                MessageBox.Show("Restore successfull.", "Restore");
            }
            catch (Exception ex) // Log any error that occur during the backup process
            {
                string errorMessage = "Restore fail.\r\n\r\n" + ex.ToString();
                MessageBox.Show(errorMessage, "Error");
            }
        }
    }
}
