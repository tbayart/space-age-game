namespace MySQL_Backup_and_Restore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Backup = new System.Windows.Forms.Button();
            this.button_Restore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Server = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Database = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.checkBox_ConstructSQLIn1Line = new System.Windows.Forms.CheckBox();
            this.checkBox_DeleteTable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_DropDatabase = new System.Windows.Forms.CheckBox();
            this.checkBox_dontDisplay = new System.Windows.Forms.CheckBox();
            this.checkBox_Save = new System.Windows.Forms.CheckBox();
            this.textBox_FileExtension = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_choseFolder = new System.Windows.Forms.Button();
            this.textBox_folder = new System.Windows.Forms.TextBox();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_AddDate = new System.Windows.Forms.CheckBox();
            this.lb_exampleFilename = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_encryptKey = new System.Windows.Forms.TextBox();
            this.checkBox_encryption = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_otherDetails = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Backup
            // 
            this.button_Backup.Location = new System.Drawing.Point(443, 237);
            this.button_Backup.Name = "button_Backup";
            this.button_Backup.Size = new System.Drawing.Size(75, 24);
            this.button_Backup.TabIndex = 0;
            this.button_Backup.Text = "Backup";
            this.button_Backup.UseVisualStyleBackColor = true;
            this.button_Backup.Click += new System.EventHandler(this.button_Backup_Click);
            // 
            // button_Restore
            // 
            this.button_Restore.Location = new System.Drawing.Point(443, 282);
            this.button_Restore.Name = "button_Restore";
            this.button_Restore.Size = new System.Drawing.Size(75, 24);
            this.button_Restore.TabIndex = 1;
            this.button_Restore.Text = "Restore";
            this.button_Restore.UseVisualStyleBackColor = true;
            this.button_Restore.Click += new System.EventHandler(this.button_Restore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Server
            // 
            this.textBox_Server.Location = new System.Drawing.Point(111, 18);
            this.textBox_Server.Name = "textBox_Server";
            this.textBox_Server.Size = new System.Drawing.Size(219, 20);
            this.textBox_Server.TabIndex = 3;
            this.textBox_Server.Text = "localhost";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(111, 44);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(219, 20);
            this.textBox_Username.TabIndex = 4;
            this.textBox_Username.Text = "root";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(111, 70);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(219, 20);
            this.textBox_Password.TabIndex = 5;
            // 
            // textBox_Database
            // 
            this.textBox_Database.Location = new System.Drawing.Point(111, 96);
            this.textBox_Database.Name = "textBox_Database";
            this.textBox_Database.Size = new System.Drawing.Size(219, 20);
            this.textBox_Database.TabIndex = 6;
            this.textBox_Database.Text = "store";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(111, 122);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(219, 20);
            this.textBox_Port.TabIndex = 7;
            // 
            // checkBox_ConstructSQLIn1Line
            // 
            this.checkBox_ConstructSQLIn1Line.AutoSize = true;
            this.checkBox_ConstructSQLIn1Line.Checked = true;
            this.checkBox_ConstructSQLIn1Line.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ConstructSQLIn1Line.Location = new System.Drawing.Point(12, 28);
            this.checkBox_ConstructSQLIn1Line.Name = "checkBox_ConstructSQLIn1Line";
            this.checkBox_ConstructSQLIn1Line.Size = new System.Drawing.Size(294, 17);
            this.checkBox_ConstructSQLIn1Line.TabIndex = 10;
            this.checkBox_ConstructSQLIn1Line.Text = "Construct all INSERT command of same table into 1 line.";
            this.checkBox_ConstructSQLIn1Line.UseVisualStyleBackColor = true;
            // 
            // checkBox_DeleteTable
            // 
            this.checkBox_DeleteTable.AutoSize = true;
            this.checkBox_DeleteTable.Location = new System.Drawing.Point(12, 51);
            this.checkBox_DeleteTable.Name = "checkBox_DeleteTable";
            this.checkBox_DeleteTable.Size = new System.Drawing.Size(345, 17);
            this.checkBox_DeleteTable.TabIndex = 12;
            this.checkBox_DeleteTable.Text = "Delete and recreate all tables during restore process. (Drop Table)";
            this.checkBox_DeleteTable.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_DropDatabase);
            this.groupBox1.Controls.Add(this.checkBox_ConstructSQLIn1Line);
            this.groupBox1.Controls.Add(this.checkBox_DeleteTable);
            this.groupBox1.Location = new System.Drawing.Point(15, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 117);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add the following info into backup file";
            // 
            // checkBox_DropDatabase
            // 
            this.checkBox_DropDatabase.AutoSize = true;
            this.checkBox_DropDatabase.Location = new System.Drawing.Point(12, 74);
            this.checkBox_DropDatabase.Name = "checkBox_DropDatabase";
            this.checkBox_DropDatabase.Size = new System.Drawing.Size(276, 17);
            this.checkBox_DropDatabase.TabIndex = 13;
            this.checkBox_DropDatabase.Text = "Delete and recreate the database. (Drop Database)";
            this.checkBox_DropDatabase.UseVisualStyleBackColor = true;
            // 
            // checkBox_dontDisplay
            // 
            this.checkBox_dontDisplay.AutoSize = true;
            this.checkBox_dontDisplay.Location = new System.Drawing.Point(79, 193);
            this.checkBox_dontDisplay.Name = "checkBox_dontDisplay";
            this.checkBox_dontDisplay.Size = new System.Drawing.Size(127, 17);
            this.checkBox_dontDisplay.TabIndex = 14;
            this.checkBox_dontDisplay.Text = "Don\'t display all text.";
            this.checkBox_dontDisplay.UseVisualStyleBackColor = true;
            // 
            // checkBox_Save
            // 
            this.checkBox_Save.AutoSize = true;
            this.checkBox_Save.Location = new System.Drawing.Point(224, 193);
            this.checkBox_Save.Name = "checkBox_Save";
            this.checkBox_Save.Size = new System.Drawing.Size(133, 17);
            this.checkBox_Save.TabIndex = 15;
            this.checkBox_Save.Text = "Auto save parameters";
            this.checkBox_Save.UseVisualStyleBackColor = true;
            // 
            // textBox_FileExtension
            // 
            this.textBox_FileExtension.Location = new System.Drawing.Point(126, 48);
            this.textBox_FileExtension.Name = "textBox_FileExtension";
            this.textBox_FileExtension.Size = new System.Drawing.Size(100, 20);
            this.textBox_FileExtension.TabIndex = 16;
            this.textBox_FileExtension.Text = "backup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button_choseFolder);
            this.groupBox2.Controls.Add(this.textBox_folder);
            this.groupBox2.Controls.Add(this.textBox_filename);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.checkBox_AddDate);
            this.groupBox2.Controls.Add(this.lb_exampleFilename);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_FileExtension);
            this.groupBox2.Location = new System.Drawing.Point(15, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 169);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Naming of Backup File";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Choose Folder:";
            // 
            // button_choseFolder
            // 
            this.button_choseFolder.BackgroundImage = global::MySQL_Backup_and_Restore.Properties.Resources.folder_open_sharp_thick;
            this.button_choseFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_choseFolder.Location = new System.Drawing.Point(310, 70);
            this.button_choseFolder.Name = "button_choseFolder";
            this.button_choseFolder.Size = new System.Drawing.Size(28, 28);
            this.button_choseFolder.TabIndex = 25;
            this.button_choseFolder.UseVisualStyleBackColor = true;
            this.button_choseFolder.Click += new System.EventHandler(this.button_choseFolder_Click);
            // 
            // textBox_folder
            // 
            this.textBox_folder.Location = new System.Drawing.Point(96, 74);
            this.textBox_folder.Name = "textBox_folder";
            this.textBox_folder.Size = new System.Drawing.Size(208, 20);
            this.textBox_folder.TabIndex = 24;
            // 
            // textBox_filename
            // 
            this.textBox_filename.Location = new System.Drawing.Point(126, 22);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.Size = new System.Drawing.Size(100, 20);
            this.textBox_filename.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Use a fix filename:";
            // 
            // checkBox_AddDate
            // 
            this.checkBox_AddDate.AutoSize = true;
            this.checkBox_AddDate.Location = new System.Drawing.Point(17, 102);
            this.checkBox_AddDate.Name = "checkBox_AddDate";
            this.checkBox_AddDate.Size = new System.Drawing.Size(325, 17);
            this.checkBox_AddDate.TabIndex = 20;
            this.checkBox_AddDate.Text = "Add Date Time (Now) after filename. (yyyy-MM-dd-HH-mm-ss)";
            this.checkBox_AddDate.UseVisualStyleBackColor = true;
            // 
            // lb_exampleFilename
            // 
            this.lb_exampleFilename.AutoSize = true;
            this.lb_exampleFilename.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exampleFilename.Location = new System.Drawing.Point(17, 147);
            this.lb_exampleFilename.Name = "lb_exampleFilename";
            this.lb_exampleFilename.Size = new System.Drawing.Size(47, 11);
            this.lb_exampleFilename.TabIndex = 19;
            this.lb_exampleFilename.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Example of backup filename:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "File Extension Name:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(222, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(318, 28);
            this.label13.TabIndex = 44;
            this.label13.Text = "This is a freeware Licensed under Apache License, Version 2.0\r\nhttp://www.apache." +
                "org/licenses/LICENSE-2.0.html";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 520);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(544, 56);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Software License";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox_encryptKey);
            this.groupBox4.Controls.Add(this.checkBox_encryption);
            this.groupBox4.Location = new System.Drawing.Point(384, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 166);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encryption of Backup File";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "(Optional)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 39);
            this.label7.TabIndex = 3;
            this.label7.Text = "Note: This key will not be saved.\r\nUsed for encryption and\r\ndecryption of backup " +
                "file.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password:";
            // 
            // textBox_encryptKey
            // 
            this.textBox_encryptKey.Location = new System.Drawing.Point(16, 69);
            this.textBox_encryptKey.Name = "textBox_encryptKey";
            this.textBox_encryptKey.ReadOnly = true;
            this.textBox_encryptKey.Size = new System.Drawing.Size(140, 20);
            this.textBox_encryptKey.TabIndex = 1;
            // 
            // checkBox_encryption
            // 
            this.checkBox_encryption.AutoSize = true;
            this.checkBox_encryption.Location = new System.Drawing.Point(16, 24);
            this.checkBox_encryption.Name = "checkBox_encryption";
            this.checkBox_encryption.Size = new System.Drawing.Size(112, 17);
            this.checkBox_encryption.TabIndex = 0;
            this.checkBox_encryption.Text = "Enable encryption";
            this.checkBox_encryption.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "Other Connection:\r\nDetails";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_otherDetails
            // 
            this.textBox_otherDetails.Location = new System.Drawing.Point(111, 148);
            this.textBox_otherDetails.Name = "textBox_otherDetails";
            this.textBox_otherDetails.Size = new System.Drawing.Size(219, 20);
            this.textBox_otherDetails.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Database:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Port:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MySQL_Backup_and_Restore.Properties.Resources.logo;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(409, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 175);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 588);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_otherDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox_Save);
            this.Controls.Add(this.checkBox_dontDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.textBox_Database);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_Server);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Restore);
            this.Controls.Add(this.button_Backup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL Database Backup & Restore Tools V1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Backup;
        private System.Windows.Forms.Button button_Restore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Server;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Database;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.CheckBox checkBox_ConstructSQLIn1Line;
        private System.Windows.Forms.CheckBox checkBox_DeleteTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_dontDisplay;
        private System.Windows.Forms.CheckBox checkBox_Save;
        private System.Windows.Forms.TextBox textBox_FileExtension;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_AddDate;
        private System.Windows.Forms.Label lb_exampleFilename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_filename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_DropDatabase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_encryptKey;
        private System.Windows.Forms.CheckBox checkBox_encryption;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_otherDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_choseFolder;
        private System.Windows.Forms.TextBox textBox_folder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}