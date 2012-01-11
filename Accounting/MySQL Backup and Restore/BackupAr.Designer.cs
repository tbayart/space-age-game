namespace MySQL_Backup_and_Restore
{
    partial class BackupAr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupAr));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_Restore = new System.Windows.Forms.Button();
            this.button_Backup = new System.Windows.Forms.Button();
            this.checkBox_DropDatabase = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_ConstructSQLIn1Line = new System.Windows.Forms.CheckBox();
            this.checkBox_DeleteTable = new System.Windows.Forms.CheckBox();
            this.backgroundRestore = new System.ComponentModel.BackgroundWorker();
            this.backgroundBackup = new System.ComponentModel.BackgroundWorker();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.button_Restore);
            this.groupBox4.Controls.Add(this.button_Backup);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // button_Restore
            // 
            resources.ApplyResources(this.button_Restore, "button_Restore");
            this.button_Restore.Name = "button_Restore";
            this.button_Restore.UseVisualStyleBackColor = true;
            this.button_Restore.Click += new System.EventHandler(this.button_Restore_Click);
            // 
            // button_Backup
            // 
            resources.ApplyResources(this.button_Backup, "button_Backup");
            this.button_Backup.Name = "button_Backup";
            this.button_Backup.UseVisualStyleBackColor = true;
            this.button_Backup.Click += new System.EventHandler(this.button_Backup_Click);
            // 
            // checkBox_DropDatabase
            // 
            resources.ApplyResources(this.checkBox_DropDatabase, "checkBox_DropDatabase");
            this.checkBox_DropDatabase.Name = "checkBox_DropDatabase";
            this.checkBox_DropDatabase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.checkBox_DropDatabase);
            this.groupBox1.Controls.Add(this.checkBox_ConstructSQLIn1Line);
            this.groupBox1.Controls.Add(this.checkBox_DeleteTable);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkBox_ConstructSQLIn1Line
            // 
            resources.ApplyResources(this.checkBox_ConstructSQLIn1Line, "checkBox_ConstructSQLIn1Line");
            this.checkBox_ConstructSQLIn1Line.Checked = true;
            this.checkBox_ConstructSQLIn1Line.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ConstructSQLIn1Line.Name = "checkBox_ConstructSQLIn1Line";
            this.checkBox_ConstructSQLIn1Line.UseVisualStyleBackColor = true;
            // 
            // checkBox_DeleteTable
            // 
            resources.ApplyResources(this.checkBox_DeleteTable, "checkBox_DeleteTable");
            this.checkBox_DeleteTable.Name = "checkBox_DeleteTable";
            this.checkBox_DeleteTable.UseVisualStyleBackColor = true;
            // 
            // backgroundRestore
            // 
            this.backgroundRestore.WorkerReportsProgress = true;
            this.backgroundRestore.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundRestore_DoWork);
            this.backgroundRestore.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundRestore_ProgressChanged);
            this.backgroundRestore.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundRestore_RunWorkerCompleted);
            // 
            // backgroundBackup
            // 
            this.backgroundBackup.WorkerReportsProgress = true;
            this.backgroundBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundBackup_DoWork);
            this.backgroundBackup.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundBackup_ProgressChanged);
            this.backgroundBackup.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundBackup_RunWorkerCompleted);
            // 
            // BackupAr
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupAr";
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Restore;
        private System.Windows.Forms.Button button_Backup;
        private System.Windows.Forms.CheckBox checkBox_DropDatabase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_ConstructSQLIn1Line;
        private System.Windows.Forms.CheckBox checkBox_DeleteTable;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundRestore;
        private System.ComponentModel.BackgroundWorker backgroundBackup;
        private System.Windows.Forms.Button button1;
    }
}