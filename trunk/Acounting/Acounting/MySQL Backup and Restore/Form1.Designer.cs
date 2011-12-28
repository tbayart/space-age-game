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
            this.button_Backup = new System.Windows.Forms.Button();
            this.button_Restore = new System.Windows.Forms.Button();
            this.checkBox_ConstructSQLIn1Line = new System.Windows.Forms.CheckBox();
            this.checkBox_DeleteTable = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_DropDatabase = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_AddDate = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_encryptKey = new System.Windows.Forms.TextBox();
            this.checkBox_encryption = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Backup
            // 
            this.button_Backup.Location = new System.Drawing.Point(263, 24);
            this.button_Backup.Name = "button_Backup";
            this.button_Backup.Size = new System.Drawing.Size(75, 24);
            this.button_Backup.TabIndex = 0;
            this.button_Backup.Text = "Backup";
            this.button_Backup.UseVisualStyleBackColor = true;
            this.button_Backup.Click += new System.EventHandler(this.button_Backup_Click);
            // 
            // button_Restore
            // 
            this.button_Restore.Location = new System.Drawing.Point(263, 69);
            this.button_Restore.Name = "button_Restore";
            this.button_Restore.Size = new System.Drawing.Size(75, 24);
            this.button_Restore.TabIndex = 1;
            this.button_Restore.Text = "Restore";
            this.button_Restore.UseVisualStyleBackColor = true;
            this.button_Restore.Click += new System.EventHandler(this.button_Restore_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(275, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 117);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add the following info into backup file";
            this.groupBox1.Visible = false;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_AddDate);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 55);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Naming of Backup File";
            // 
            // checkBox_AddDate
            // 
            this.checkBox_AddDate.AutoSize = true;
            this.checkBox_AddDate.Checked = true;
            this.checkBox_AddDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AddDate.Location = new System.Drawing.Point(6, 19);
            this.checkBox_AddDate.Name = "checkBox_AddDate";
            this.checkBox_AddDate.Size = new System.Drawing.Size(325, 17);
            this.checkBox_AddDate.TabIndex = 20;
            this.checkBox_AddDate.Text = "Add Date Time (Now) after filename. (yyyy-MM-dd-HH-mm-ss)";
            this.checkBox_AddDate.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox_encryptKey);
            this.groupBox4.Controls.Add(this.button_Restore);
            this.groupBox4.Controls.Add(this.checkBox_encryption);
            this.groupBox4.Controls.Add(this.button_Backup);
            this.groupBox4.Location = new System.Drawing.Point(12, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 113);
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
            this.textBox_encryptKey.Size = new System.Drawing.Size(140, 20);
            this.textBox_encryptKey.TabIndex = 1;
            // 
            // checkBox_encryption
            // 
            this.checkBox_encryption.AutoSize = true;
            this.checkBox_encryption.Checked = true;
            this.checkBox_encryption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_encryption.Enabled = false;
            this.checkBox_encryption.Location = new System.Drawing.Point(16, 24);
            this.checkBox_encryption.Name = "checkBox_encryption";
            this.checkBox_encryption.Size = new System.Drawing.Size(112, 17);
            this.checkBox_encryption.TabIndex = 0;
            this.checkBox_encryption.Text = "Enable encryption";
            this.checkBox_encryption.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 212);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup/Restore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Backup;
        private System.Windows.Forms.Button button_Restore;
        private System.Windows.Forms.CheckBox checkBox_ConstructSQLIn1Line;
        private System.Windows.Forms.CheckBox checkBox_DeleteTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_AddDate;
        private System.Windows.Forms.CheckBox checkBox_DropDatabase;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_encryptKey;
        private System.Windows.Forms.CheckBox checkBox_encryption;
        private System.Windows.Forms.Label label14;
    }
}