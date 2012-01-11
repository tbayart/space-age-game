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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupAr));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_encryptKey = new System.Windows.Forms.TextBox();
            this.button_Restore = new System.Windows.Forms.Button();
            this.button_Backup = new System.Windows.Forms.Button();
            this.checkBox_DropDatabase = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_ConstructSQLIn1Line = new System.Windows.Forms.CheckBox();
            this.checkBox_DeleteTable = new System.Windows.Forms.CheckBox();
            this.backgroundRestore = new System.ComponentModel.BackgroundWorker();
            this.backgroundBackup = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox_encryptKey);
            this.groupBox4.Controls.Add(this.button_Restore);
            this.groupBox4.Controls.Add(this.button_Backup);
            this.errorProvider1.SetError(this.groupBox4, resources.GetString("groupBox4.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox4, ((int)(resources.GetObject("groupBox4.IconPadding"))));
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.errorProvider1.SetError(this.progressBar1, resources.GetString("progressBar1.Error"));
            this.errorProvider1.SetIconAlignment(this.progressBar1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("progressBar1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.progressBar1, ((int)(resources.GetObject("progressBar1.IconPadding"))));
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // textBox_encryptKey
            // 
            resources.ApplyResources(this.textBox_encryptKey, "textBox_encryptKey");
            this.errorProvider1.SetError(this.textBox_encryptKey, resources.GetString("textBox_encryptKey.Error"));
            this.errorProvider1.SetIconAlignment(this.textBox_encryptKey, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_encryptKey.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox_encryptKey, ((int)(resources.GetObject("textBox_encryptKey.IconPadding"))));
            this.textBox_encryptKey.Name = "textBox_encryptKey";
            this.textBox_encryptKey.UseSystemPasswordChar = true;
            // 
            // button_Restore
            // 
            resources.ApplyResources(this.button_Restore, "button_Restore");
            this.errorProvider1.SetError(this.button_Restore, resources.GetString("button_Restore.Error"));
            this.errorProvider1.SetIconAlignment(this.button_Restore, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("button_Restore.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.button_Restore, ((int)(resources.GetObject("button_Restore.IconPadding"))));
            this.button_Restore.Name = "button_Restore";
            this.button_Restore.UseVisualStyleBackColor = true;
            this.button_Restore.Click += new System.EventHandler(this.button_Restore_Click);
            // 
            // button_Backup
            // 
            resources.ApplyResources(this.button_Backup, "button_Backup");
            this.errorProvider1.SetError(this.button_Backup, resources.GetString("button_Backup.Error"));
            this.errorProvider1.SetIconAlignment(this.button_Backup, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("button_Backup.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.button_Backup, ((int)(resources.GetObject("button_Backup.IconPadding"))));
            this.button_Backup.Name = "button_Backup";
            this.button_Backup.UseVisualStyleBackColor = true;
            this.button_Backup.Click += new System.EventHandler(this.button_Backup_Click);
            // 
            // checkBox_DropDatabase
            // 
            resources.ApplyResources(this.checkBox_DropDatabase, "checkBox_DropDatabase");
            this.errorProvider1.SetError(this.checkBox_DropDatabase, resources.GetString("checkBox_DropDatabase.Error"));
            this.errorProvider1.SetIconAlignment(this.checkBox_DropDatabase, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("checkBox_DropDatabase.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.checkBox_DropDatabase, ((int)(resources.GetObject("checkBox_DropDatabase.IconPadding"))));
            this.checkBox_DropDatabase.Name = "checkBox_DropDatabase";
            this.checkBox_DropDatabase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.checkBox_DropDatabase);
            this.groupBox1.Controls.Add(this.checkBox_ConstructSQLIn1Line);
            this.groupBox1.Controls.Add(this.checkBox_DeleteTable);
            this.errorProvider1.SetError(this.groupBox1, resources.GetString("groupBox1.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding"))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkBox_ConstructSQLIn1Line
            // 
            resources.ApplyResources(this.checkBox_ConstructSQLIn1Line, "checkBox_ConstructSQLIn1Line");
            this.checkBox_ConstructSQLIn1Line.Checked = true;
            this.checkBox_ConstructSQLIn1Line.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorProvider1.SetError(this.checkBox_ConstructSQLIn1Line, resources.GetString("checkBox_ConstructSQLIn1Line.Error"));
            this.errorProvider1.SetIconAlignment(this.checkBox_ConstructSQLIn1Line, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("checkBox_ConstructSQLIn1Line.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.checkBox_ConstructSQLIn1Line, ((int)(resources.GetObject("checkBox_ConstructSQLIn1Line.IconPadding"))));
            this.checkBox_ConstructSQLIn1Line.Name = "checkBox_ConstructSQLIn1Line";
            this.checkBox_ConstructSQLIn1Line.UseVisualStyleBackColor = true;
            // 
            // checkBox_DeleteTable
            // 
            resources.ApplyResources(this.checkBox_DeleteTable, "checkBox_DeleteTable");
            this.errorProvider1.SetError(this.checkBox_DeleteTable, resources.GetString("checkBox_DeleteTable.Error"));
            this.errorProvider1.SetIconAlignment(this.checkBox_DeleteTable, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("checkBox_DeleteTable.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.checkBox_DeleteTable, ((int)(resources.GetObject("checkBox_DeleteTable.IconPadding"))));
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
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
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_encryptKey;
        private System.Windows.Forms.Button button_Restore;
        private System.Windows.Forms.Button button_Backup;
        private System.Windows.Forms.CheckBox checkBox_DropDatabase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_ConstructSQLIn1Line;
        private System.Windows.Forms.CheckBox checkBox_DeleteTable;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundRestore;
        private System.ComponentModel.BackgroundWorker backgroundBackup;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}