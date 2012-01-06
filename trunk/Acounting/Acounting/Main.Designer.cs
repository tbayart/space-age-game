namespace Acounting
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staticAssetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حفظاسترجعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vaultToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.كشفموردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اجمالياصنافToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentDebtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsSalesDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عربيToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عربيToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.englshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsTableAdapter = new Acounting.storeDataSetTableAdapters.itemsTableAdapter();
            this.vaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaultTableAdapter = new Acounting.storeDataSetTableAdapters.vaultTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.storageToolStripMenuItem,
            this.reportsToolStripMenuItem1,
            this.عربيToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.agentsToolStripMenuItem1,
            this.staticAssetsToolStripMenuItem,
            this.حفظاسترجعToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            resources.ApplyResources(this.dataToolStripMenuItem, "dataToolStripMenuItem");
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            resources.ApplyResources(this.itemToolStripMenuItem, "itemToolStripMenuItem");
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // agentsToolStripMenuItem1
            // 
            this.agentsToolStripMenuItem1.Name = "agentsToolStripMenuItem1";
            resources.ApplyResources(this.agentsToolStripMenuItem1, "agentsToolStripMenuItem1");
            this.agentsToolStripMenuItem1.Click += new System.EventHandler(this.agentsToolStripMenuItem1_Click);
            // 
            // staticAssetsToolStripMenuItem
            // 
            this.staticAssetsToolStripMenuItem.Name = "staticAssetsToolStripMenuItem";
            resources.ApplyResources(this.staticAssetsToolStripMenuItem, "staticAssetsToolStripMenuItem");
            this.staticAssetsToolStripMenuItem.Click += new System.EventHandler(this.staticAssetsToolStripMenuItem_Click);
            // 
            // حفظاسترجعToolStripMenuItem
            // 
            resources.ApplyResources(this.حفظاسترجعToolStripMenuItem, "حفظاسترجعToolStripMenuItem");
            this.حفظاسترجعToolStripMenuItem.Name = "حفظاسترجعToolStripMenuItem";
            this.حفظاسترجعToolStripMenuItem.Click += new System.EventHandler(this.حفظاسترجعToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // storageToolStripMenuItem
            // 
            this.storageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyToolStripMenuItem1,
            this.sellToolStripMenuItem1,
            this.paymentsToolStripMenuItem1,
            this.vaultToolStripMenuItem1,
            this.returnBuyToolStripMenuItem,
            this.returnSaleToolStripMenuItem,
            this.showAllBillsToolStripMenuItem});
            this.storageToolStripMenuItem.Name = "storageToolStripMenuItem";
            resources.ApplyResources(this.storageToolStripMenuItem, "storageToolStripMenuItem");
            // 
            // buyToolStripMenuItem1
            // 
            this.buyToolStripMenuItem1.Name = "buyToolStripMenuItem1";
            resources.ApplyResources(this.buyToolStripMenuItem1, "buyToolStripMenuItem1");
            this.buyToolStripMenuItem1.Click += new System.EventHandler(this.buyToolStripMenuItem1_Click);
            // 
            // sellToolStripMenuItem1
            // 
            this.sellToolStripMenuItem1.Name = "sellToolStripMenuItem1";
            resources.ApplyResources(this.sellToolStripMenuItem1, "sellToolStripMenuItem1");
            this.sellToolStripMenuItem1.Click += new System.EventHandler(this.sellToolStripMenuItem1_Click);
            // 
            // paymentsToolStripMenuItem1
            // 
            this.paymentsToolStripMenuItem1.Name = "paymentsToolStripMenuItem1";
            resources.ApplyResources(this.paymentsToolStripMenuItem1, "paymentsToolStripMenuItem1");
            this.paymentsToolStripMenuItem1.Click += new System.EventHandler(this.paymentsToolStripMenuItem1_Click);
            // 
            // vaultToolStripMenuItem1
            // 
            this.vaultToolStripMenuItem1.Name = "vaultToolStripMenuItem1";
            resources.ApplyResources(this.vaultToolStripMenuItem1, "vaultToolStripMenuItem1");
            this.vaultToolStripMenuItem1.Click += new System.EventHandler(this.vaultToolStripMenuItem1_Click);
            // 
            // returnBuyToolStripMenuItem
            // 
            this.returnBuyToolStripMenuItem.Name = "returnBuyToolStripMenuItem";
            resources.ApplyResources(this.returnBuyToolStripMenuItem, "returnBuyToolStripMenuItem");
            this.returnBuyToolStripMenuItem.Click += new System.EventHandler(this.returnBuyToolStripMenuItem_Click);
            // 
            // returnSaleToolStripMenuItem
            // 
            this.returnSaleToolStripMenuItem.Name = "returnSaleToolStripMenuItem";
            resources.ApplyResources(this.returnSaleToolStripMenuItem, "returnSaleToolStripMenuItem");
            this.returnSaleToolStripMenuItem.Click += new System.EventHandler(this.returnSaleToolStripMenuItem_Click);
            // 
            // showAllBillsToolStripMenuItem
            // 
            this.showAllBillsToolStripMenuItem.Name = "showAllBillsToolStripMenuItem";
            resources.ApplyResources(this.showAllBillsToolStripMenuItem, "showAllBillsToolStripMenuItem");
            this.showAllBillsToolStripMenuItem.Click += new System.EventHandler(this.showAllBillsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.كشفموردToolStripMenuItem,
            this.اجمالياصنافToolStripMenuItem,
            this.agentDebtToolStripMenuItem,
            this.itemsSalesDetailsToolStripMenuItem});
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            resources.ApplyResources(this.reportsToolStripMenuItem1, "reportsToolStripMenuItem1");
            // 
            // كشفموردToolStripMenuItem
            // 
            this.كشفموردToolStripMenuItem.Name = "كشفموردToolStripMenuItem";
            resources.ApplyResources(this.كشفموردToolStripMenuItem, "كشفموردToolStripMenuItem");
            this.كشفموردToolStripMenuItem.Click += new System.EventHandler(this.كشفموردToolStripMenuItem_Click);
            // 
            // اجمالياصنافToolStripMenuItem
            // 
            this.اجمالياصنافToolStripMenuItem.Name = "اجمالياصنافToolStripMenuItem";
            resources.ApplyResources(this.اجمالياصنافToolStripMenuItem, "اجمالياصنافToolStripMenuItem");
            this.اجمالياصنافToolStripMenuItem.Click += new System.EventHandler(this.اجمالياصنافToolStripMenuItem_Click);
            // 
            // agentDebtToolStripMenuItem
            // 
            this.agentDebtToolStripMenuItem.Name = "agentDebtToolStripMenuItem";
            resources.ApplyResources(this.agentDebtToolStripMenuItem, "agentDebtToolStripMenuItem");
            this.agentDebtToolStripMenuItem.Click += new System.EventHandler(this.agentDebtToolStripMenuItem_Click);
            // 
            // itemsSalesDetailsToolStripMenuItem
            // 
            this.itemsSalesDetailsToolStripMenuItem.Name = "itemsSalesDetailsToolStripMenuItem";
            resources.ApplyResources(this.itemsSalesDetailsToolStripMenuItem, "itemsSalesDetailsToolStripMenuItem");
            this.itemsSalesDetailsToolStripMenuItem.Click += new System.EventHandler(this.itemsSalesDetailsToolStripMenuItem_Click);
            // 
            // عربيToolStripMenuItem
            // 
            this.عربيToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عربيToolStripMenuItem1,
            this.englshToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.عربيToolStripMenuItem.Name = "عربيToolStripMenuItem";
            resources.ApplyResources(this.عربيToolStripMenuItem, "عربيToolStripMenuItem");
            // 
            // عربيToolStripMenuItem1
            // 
            this.عربيToolStripMenuItem1.Name = "عربيToolStripMenuItem1";
            resources.ApplyResources(this.عربيToolStripMenuItem1, "عربيToolStripMenuItem1");
            this.عربيToolStripMenuItem1.Click += new System.EventHandler(this.عربيToolStripMenuItem1_Click);
            // 
            // englshToolStripMenuItem
            // 
            this.englshToolStripMenuItem.Name = "englshToolStripMenuItem";
            resources.ApplyResources(this.englshToolStripMenuItem, "englshToolStripMenuItem");
            this.englshToolStripMenuItem.Click += new System.EventHandler(this.englshToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            resources.ApplyResources(this.checkForUpdatesToolStripMenuItem, "checkForUpdatesToolStripMenuItem");
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // vaultBindingSource
            // 
            this.vaultBindingSource.DataMember = "vault";
            this.vaultBindingSource.DataSource = this.storeDataSet;
            // 
            // vaultTableAdapter
            // 
            this.vaultTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private storeDataSet storeDataSet;
        private storeDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem storageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vaultToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agentDebtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticAssetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عربيToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عربيToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem englshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حفظاسترجعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem كشفموردToolStripMenuItem;
        private System.Windows.Forms.BindingSource vaultBindingSource;
        private storeDataSetTableAdapters.vaultTableAdapter vaultTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem اجمالياصنافToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem itemsSalesDetailsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem showAllBillsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
    }
}

