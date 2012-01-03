namespace Acounting
{
    partial class ReturnSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnSales));
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesReturnDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.Txt_Remaining = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_ToSell = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Cost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_ItemID = new System.Windows.Forms.TextBox();
            this.Txt_InStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_SellPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cmb_ItemName = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_BillID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.itemsTableAdapter = new Acounting.storeDataSetTableAdapters.itemsTableAdapter();
            this.billsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.billsreturnTableAdapter();
            this.salesitemsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesitemsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.salesitemsreturnTableAdapter();
            this.vaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaultTableAdapter = new Acounting.storeDataSetTableAdapters.vaultTableAdapter();
            this.salesReturnDetailsTableAdapter = new Acounting.storeDataSetTableAdapters.SalesReturnDetailsTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.namesTableAdapter = new Acounting.storeDataSetTableAdapters.namesTableAdapter();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReturnDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesitemsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errorProvider1.SetError(this.label8, resources.GetString("label8.Error"));
            this.errorProvider1.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Name = "label8";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.errorProvider1.SetError(this.groupBox4, resources.GetString("groupBox4.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox4, ((int)(resources.GetObject("groupBox4.IconPadding"))));
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.sellPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesReturnDetailsBindingSource;
            this.errorProvider1.SetError(this.dataGridView1, resources.GetString("dataGridView1.Error"));
            this.errorProvider1.SetIconAlignment(this.dataGridView1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataGridView1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.dataGridView1, ((int)(resources.GetObject("dataGridView1.IconPadding"))));
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
            // salesReturnDetailsBindingSource
            // 
            this.salesReturnDetailsBindingSource.DataMember = "SalesReturnDetails";
            this.salesReturnDetailsBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Txt_Remaining
            // 
            resources.ApplyResources(this.Txt_Remaining, "Txt_Remaining");
            this.errorProvider1.SetError(this.Txt_Remaining, resources.GetString("Txt_Remaining.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_Remaining, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_Remaining.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_Remaining, ((int)(resources.GetObject("Txt_Remaining.IconPadding"))));
            this.Txt_Remaining.Name = "Txt_Remaining";
            this.Txt_Remaining.ReadOnly = true;
            this.Txt_Remaining.TextChanged += new System.EventHandler(this.Txt_Remaining_TextChanged);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
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
            this.errorProvider1.SetError(this.groupBox3, resources.GetString("groupBox3.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox3, ((int)(resources.GetObject("groupBox3.IconPadding"))));
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.errorProvider1.SetError(this.label13, resources.GetString("label13.Error"));
            this.errorProvider1.SetIconAlignment(this.label13, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label13.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label13, ((int)(resources.GetObject("label13.IconPadding"))));
            this.label13.Name = "label13";
            // 
            // Txt_TotalBill
            // 
            resources.ApplyResources(this.Txt_TotalBill, "Txt_TotalBill");
            this.errorProvider1.SetError(this.Txt_TotalBill, resources.GetString("Txt_TotalBill.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_TotalBill, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_TotalBill.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_TotalBill, ((int)(resources.GetObject("Txt_TotalBill.IconPadding"))));
            this.Txt_TotalBill.Name = "Txt_TotalBill";
            this.Txt_TotalBill.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.errorProvider1.SetError(this.label12, resources.GetString("label12.Error"));
            this.errorProvider1.SetIconAlignment(this.label12, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label12.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label12, ((int)(resources.GetObject("label12.IconPadding"))));
            this.label12.Name = "label12";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // Txt_Paid
            // 
            resources.ApplyResources(this.Txt_Paid, "Txt_Paid");
            this.errorProvider1.SetError(this.Txt_Paid, resources.GetString("Txt_Paid.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_Paid, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_Paid.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_Paid, ((int)(resources.GetObject("Txt_Paid.IconPadding"))));
            this.Txt_Paid.Name = "Txt_Paid";
            this.Txt_Paid.TextChanged += new System.EventHandler(this.Txt_Paid_TextChanged);
            // 
            // Txt_AgentID
            // 
            resources.ApplyResources(this.Txt_AgentID, "Txt_AgentID");
            this.errorProvider1.SetError(this.Txt_AgentID, resources.GetString("Txt_AgentID.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_AgentID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_AgentID.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_AgentID, ((int)(resources.GetObject("Txt_AgentID.IconPadding"))));
            this.Txt_AgentID.Name = "Txt_AgentID";
            this.Txt_AgentID.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errorProvider1.SetError(this.label10, resources.GetString("label10.Error"));
            this.errorProvider1.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.label10.Name = "label10";
            // 
            // Cmb_AgentName
            // 
            resources.ApplyResources(this.Cmb_AgentName, "Cmb_AgentName");
            this.Cmb_AgentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_AgentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_AgentName.DataSource = this.namesBindingSource;
            this.Cmb_AgentName.DisplayMember = "Name";
            this.errorProvider1.SetError(this.Cmb_AgentName, resources.GetString("Cmb_AgentName.Error"));
            this.Cmb_AgentName.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.Cmb_AgentName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Cmb_AgentName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Cmb_AgentName, ((int)(resources.GetObject("Cmb_AgentName.IconPadding"))));
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
            this.errorProvider1.SetError(this.label9, resources.GetString("label9.Error"));
            this.errorProvider1.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.label9.Name = "label9";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.errorProvider1.SetError(this.button1, resources.GetString("button1.Error"));
            this.errorProvider1.SetIconAlignment(this.button1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("button1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.button1, ((int)(resources.GetObject("button1.IconPadding"))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // Txt_ToSell
            // 
            resources.ApplyResources(this.Txt_ToSell, "Txt_ToSell");
            this.errorProvider1.SetError(this.Txt_ToSell, resources.GetString("Txt_ToSell.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_ToSell, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_ToSell.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_ToSell, ((int)(resources.GetObject("Txt_ToSell.IconPadding"))));
            this.Txt_ToSell.Name = "Txt_ToSell";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
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
            this.errorProvider1.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Txt_Cost
            // 
            resources.ApplyResources(this.Txt_Cost, "Txt_Cost");
            this.errorProvider1.SetError(this.Txt_Cost, resources.GetString("Txt_Cost.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_Cost, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_Cost.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_Cost, ((int)(resources.GetObject("Txt_Cost.IconPadding"))));
            this.Txt_Cost.Name = "Txt_Cost";
            this.Txt_Cost.ReadOnly = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.errorProvider1.SetError(this.label11, resources.GetString("label11.Error"));
            this.errorProvider1.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding"))));
            this.label11.Name = "label11";
            // 
            // Txt_ItemID
            // 
            resources.ApplyResources(this.Txt_ItemID, "Txt_ItemID");
            this.errorProvider1.SetError(this.Txt_ItemID, resources.GetString("Txt_ItemID.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_ItemID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_ItemID.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_ItemID, ((int)(resources.GetObject("Txt_ItemID.IconPadding"))));
            this.Txt_ItemID.Name = "Txt_ItemID";
            this.Txt_ItemID.ReadOnly = true;
            // 
            // Txt_InStock
            // 
            resources.ApplyResources(this.Txt_InStock, "Txt_InStock");
            this.errorProvider1.SetError(this.Txt_InStock, resources.GetString("Txt_InStock.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_InStock, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_InStock.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_InStock, ((int)(resources.GetObject("Txt_InStock.IconPadding"))));
            this.Txt_InStock.Name = "Txt_InStock";
            this.Txt_InStock.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error"));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // Txt_SellPrice
            // 
            resources.ApplyResources(this.Txt_SellPrice, "Txt_SellPrice");
            this.errorProvider1.SetError(this.Txt_SellPrice, resources.GetString("Txt_SellPrice.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_SellPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_SellPrice.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_SellPrice, ((int)(resources.GetObject("Txt_SellPrice.IconPadding"))));
            this.Txt_SellPrice.Name = "Txt_SellPrice";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // Cmb_ItemName
            // 
            resources.ApplyResources(this.Cmb_ItemName, "Cmb_ItemName");
            this.Cmb_ItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_ItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_ItemName.DataSource = this.itemsBindingSource;
            this.Cmb_ItemName.DisplayMember = "ItemName";
            this.errorProvider1.SetError(this.Cmb_ItemName, resources.GetString("Cmb_ItemName.Error"));
            this.Cmb_ItemName.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.Cmb_ItemName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Cmb_ItemName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Cmb_ItemName, ((int)(resources.GetObject("Cmb_ItemName.IconPadding"))));
            this.Cmb_ItemName.Name = "Cmb_ItemName";
            this.Cmb_ItemName.TextChanged += new System.EventHandler(this.Cmb_ItemName_TextChanged);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.storeDataSet;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_BillID);
            this.errorProvider1.SetError(this.groupBox1, resources.GetString("groupBox1.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding"))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Txt_BillID
            // 
            resources.ApplyResources(this.Txt_BillID, "Txt_BillID");
            this.errorProvider1.SetError(this.Txt_BillID, resources.GetString("Txt_BillID.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_BillID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_BillID.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_BillID, ((int)(resources.GetObject("Txt_BillID.IconPadding"))));
            this.Txt_BillID.Name = "Txt_BillID";
            this.Txt_BillID.ReadOnly = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.errorProvider1.SetError(this.button2, resources.GetString("button2.Error"));
            this.errorProvider1.SetIconAlignment(this.button2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("button2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.button2, ((int)(resources.GetObject("button2.IconPadding"))));
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // billsreturnBindingSource
            // 
            this.billsreturnBindingSource.DataMember = "billsreturn";
            this.billsreturnBindingSource.DataSource = this.storeDataSet;
            // 
            // billsreturnTableAdapter
            // 
            this.billsreturnTableAdapter.ClearBeforeFill = true;
            // 
            // salesitemsreturnBindingSource
            // 
            this.salesitemsreturnBindingSource.DataMember = "salesitemsreturn";
            this.salesitemsreturnBindingSource.DataSource = this.storeDataSet;
            // 
            // salesitemsreturnTableAdapter
            // 
            this.salesitemsreturnTableAdapter.ClearBeforeFill = true;
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
            // salesReturnDetailsTableAdapter
            // 
            this.salesReturnDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // namesTableAdapter
            // 
            this.namesTableAdapter.ClearBeforeFill = true;
            // 
            // ReturnSales
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "ReturnSales";
            this.Load += new System.EventHandler(this.ReturnSales_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReturnDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesitemsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Txt_Remaining;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_TotalBill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Paid;
        private System.Windows.Forms.TextBox Txt_AgentID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cmb_AgentName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_ToSell;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_Cost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_ItemID;
        private System.Windows.Forms.TextBox Txt_InStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_SellPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmb_ItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_BillID;
        private System.Windows.Forms.Button button2;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private storeDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
 
        private System.Windows.Forms.BindingSource billsreturnBindingSource;
        private storeDataSetTableAdapters.billsreturnTableAdapter billsreturnTableAdapter;
        private System.Windows.Forms.BindingSource salesitemsreturnBindingSource;
        private storeDataSetTableAdapters.salesitemsreturnTableAdapter salesitemsreturnTableAdapter;
        private System.Windows.Forms.BindingSource vaultBindingSource;
        private storeDataSetTableAdapters.vaultTableAdapter vaultTableAdapter;
        private System.Windows.Forms.BindingSource salesReturnDetailsBindingSource;
        private storeDataSetTableAdapters.SalesReturnDetailsTableAdapter salesReturnDetailsTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource namesBindingSource;
        private storeDataSetTableAdapters.namesTableAdapter namesTableAdapter;
    }
}