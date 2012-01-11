namespace Acounting
{
    partial class Sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            this.Txt_BillID = new System.Windows.Forms.TextBox();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmb_ItemName = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Cost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_ItemID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_InStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_SellPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_ToSell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_Remaining = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_TotalBill = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Paid = new System.Windows.Forms.TextBox();
            this.Txt_AgentID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cmb_AgentName = new System.Windows.Forms.ComboBox();
            this.namesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.itemsTableAdapter = new Acounting.storeDataSetTableAdapters.itemsTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earningsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.salesitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsTableAdapter = new Acounting.storeDataSetTableAdapters.billsTableAdapter();
            this.salesitemsTableAdapter = new Acounting.storeDataSetTableAdapters.salesitemsTableAdapter();
            this.vaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaultTableAdapter = new Acounting.storeDataSetTableAdapters.vaultTableAdapter();
            this.salesDetailsTableAdapter = new Acounting.storeDataSetTableAdapters.SalesDetailsTableAdapter();
            this.namesTableAdapter = new Acounting.storeDataSetTableAdapters.namesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_BillID
            // 
            resources.ApplyResources(this.Txt_BillID, "Txt_BillID");
            this.Txt_BillID.Name = "Txt_BillID";
            this.Txt_BillID.ReadOnly = true;
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataMember = "bills";
            this.billsBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_BillID);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Cmb_ItemName
            // 
            this.Cmb_ItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_ItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_ItemName.DataSource = this.itemsBindingSource;
            this.Cmb_ItemName.DisplayMember = "ItemName";
            this.Cmb_ItemName.FormattingEnabled = true;
            resources.ApplyResources(this.Cmb_ItemName, "Cmb_ItemName");
            this.Cmb_ItemName.Name = "Cmb_ItemName";
            this.Cmb_ItemName.TextChanged += new System.EventHandler(this.Cmb_ItemName_TextChanged);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.storeDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Cost);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Txt_ItemID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Txt_InStock);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Txt_SellPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Txt_ToSell);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Cmb_ItemName);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Txt_Cost
            // 
            resources.ApplyResources(this.Txt_Cost, "Txt_Cost");
            this.Txt_Cost.Name = "Txt_Cost";
            this.Txt_Cost.ReadOnly = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // Txt_ItemID
            // 
            resources.ApplyResources(this.Txt_ItemID, "Txt_ItemID");
            this.Txt_ItemID.Name = "Txt_ItemID";
            this.Txt_ItemID.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // Txt_InStock
            // 
            resources.ApplyResources(this.Txt_InStock, "Txt_InStock");
            this.Txt_InStock.Name = "Txt_InStock";
            this.Txt_InStock.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Txt_SellPrice
            // 
            resources.ApplyResources(this.Txt_SellPrice, "Txt_SellPrice");
            this.Txt_SellPrice.Name = "Txt_SellPrice";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Txt_ToSell
            // 
            resources.ApplyResources(this.Txt_ToSell, "Txt_ToSell");
            this.Txt_ToSell.Name = "Txt_ToSell";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Txt_Remaining);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.Txt_TotalBill);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Txt_Paid);
            this.groupBox3.Controls.Add(this.Txt_AgentID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Cmb_AgentName);
            this.groupBox3.Controls.Add(this.label9);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // Txt_Remaining
            // 
            resources.ApplyResources(this.Txt_Remaining, "Txt_Remaining");
            this.Txt_Remaining.Name = "Txt_Remaining";
            this.Txt_Remaining.ReadOnly = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // Txt_TotalBill
            // 
            resources.ApplyResources(this.Txt_TotalBill, "Txt_TotalBill");
            this.Txt_TotalBill.Name = "Txt_TotalBill";
            this.Txt_TotalBill.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Txt_Paid
            // 
            resources.ApplyResources(this.Txt_Paid, "Txt_Paid");
            this.Txt_Paid.Name = "Txt_Paid";
            this.Txt_Paid.TextChanged += new System.EventHandler(this.Txt_Paid_TextChanged);
            // 
            // Txt_AgentID
            // 
            resources.ApplyResources(this.Txt_AgentID, "Txt_AgentID");
            this.Txt_AgentID.Name = "Txt_AgentID";
            this.Txt_AgentID.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // Cmb_AgentName
            // 
            this.Cmb_AgentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_AgentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_AgentName.DataSource = this.namesBindingSource;
            this.Cmb_AgentName.DisplayMember = "Name";
            this.Cmb_AgentName.FormattingEnabled = true;
            resources.ApplyResources(this.Cmb_AgentName, "Cmb_AgentName");
            this.Cmb_AgentName.Name = "Cmb_AgentName";
            this.Cmb_AgentName.TextChanged += new System.EventHandler(this.Cmb_AgentName_TextChanged);
            // 
            // namesBindingSource
            // 
            this.namesBindingSource.DataMember = "names";
            this.namesBindingSource.DataSource = this.storeDataSet;
            this.namesBindingSource.Filter = "TypeAgent = 1";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.sellPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.earningsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesDetailsBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            resources.ApplyResources(this.itemNameDataGridViewTextBoxColumn, "itemNameDataGridViewTextBoxColumn");
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            resources.ApplyResources(this.qtyDataGridViewTextBoxColumn, "qtyDataGridViewTextBoxColumn");
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellPriceDataGridViewTextBoxColumn
            // 
            this.sellPriceDataGridViewTextBoxColumn.DataPropertyName = "SellPrice";
            resources.ApplyResources(this.sellPriceDataGridViewTextBoxColumn, "sellPriceDataGridViewTextBoxColumn");
            this.sellPriceDataGridViewTextBoxColumn.Name = "sellPriceDataGridViewTextBoxColumn";
            this.sellPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            resources.ApplyResources(this.totalPriceDataGridViewTextBoxColumn, "totalPriceDataGridViewTextBoxColumn");
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // earningsDataGridViewTextBoxColumn
            // 
            this.earningsDataGridViewTextBoxColumn.DataPropertyName = "Earnings";
            resources.ApplyResources(this.earningsDataGridViewTextBoxColumn, "earningsDataGridViewTextBoxColumn");
            this.earningsDataGridViewTextBoxColumn.Name = "earningsDataGridViewTextBoxColumn";
            this.earningsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesDetailsBindingSource
            // 
            this.salesDetailsBindingSource.DataMember = "SalesDetails";
            this.salesDetailsBindingSource.DataSource = this.storeDataSet;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salesitemsBindingSource
            // 
            this.salesitemsBindingSource.DataMember = "salesitems";
            this.salesitemsBindingSource.DataSource = this.storeDataSet;
            // 
            // billsTableAdapter
            // 
            this.billsTableAdapter.ClearBeforeFill = true;
            // 
            // salesitemsTableAdapter
            // 
            this.salesitemsTableAdapter.ClearBeforeFill = true;
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
            // salesDetailsTableAdapter
            // 
            this.salesDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // namesTableAdapter
            // 
            this.namesTableAdapter.ClearBeforeFill = true;
            // 
            // Sell
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_BillID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cmb_ItemName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_InStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_SellPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_ToSell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_ItemID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Cmb_AgentName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_AgentID;
        private System.Windows.Forms.Label label10;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private storeDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
 
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private storeDataSetTableAdapters.billsTableAdapter billsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource salesitemsBindingSource;
        private storeDataSetTableAdapters.salesitemsTableAdapter salesitemsTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Paid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_Cost;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txt_TotalBill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_Remaining;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource vaultBindingSource;
        private storeDataSetTableAdapters.vaultTableAdapter vaultTableAdapter;
        private System.Windows.Forms.BindingSource salesDetailsBindingSource;
        private storeDataSetTableAdapters.SalesDetailsTableAdapter salesDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn earningsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource namesBindingSource;
        private storeDataSetTableAdapters.namesTableAdapter namesTableAdapter;
    }
}