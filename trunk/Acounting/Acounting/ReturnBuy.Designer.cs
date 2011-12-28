namespace Acounting
{
    partial class ReturnBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBuy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_BillID = new System.Windows.Forms.TextBox();
            this.Txt_DealerID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_Remaining = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_TotalBill = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Paid = new System.Windows.Forms.TextBox();
            this.Cmb_DealerName = new System.Windows.Forms.ComboBox();
            this.dealersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Cost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_ItemID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaultTableAdapter = new Acounting.storeDataSetTableAdapters.vaultTableAdapter();
            this.dealersTableAdapter = new Acounting.storeDataSetTableAdapters.dealersTableAdapter();
            this.itemsTableAdapter = new Acounting.storeDataSetTableAdapters.itemsTableAdapter();
            this.Txt_InStock = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Txt_BuyPrice = new System.Windows.Forms.TextBox();
            this.Txt_ToBuy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_ItemName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.purchasebillsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasebillsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.purchasebillsreturnTableAdapter();
            this.purchasesitemsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesitemsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.purchasesitemsreturnTableAdapter();
            this.purchaseReturnDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseReturnDetailsTableAdapter = new Acounting.storeDataSetTableAdapters.PurchaseReturnDetailsTableAdapter();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesitemsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReturnDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
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
            // Txt_DealerID
            // 
            resources.ApplyResources(this.Txt_DealerID, "Txt_DealerID");
            this.errorProvider1.SetError(this.Txt_DealerID, resources.GetString("Txt_DealerID.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_DealerID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_DealerID.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_DealerID, ((int)(resources.GetObject("Txt_DealerID.IconPadding"))));
            this.Txt_DealerID.Name = "Txt_DealerID";
            this.Txt_DealerID.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errorProvider1.SetError(this.label10, resources.GetString("label10.Error"));
            this.errorProvider1.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.label10.Name = "label10";
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
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.Txt_Remaining);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.Txt_TotalBill);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Txt_Paid);
            this.groupBox3.Controls.Add(this.Txt_DealerID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Cmb_DealerName);
            this.groupBox3.Controls.Add(this.label9);
            this.errorProvider1.SetError(this.groupBox3, resources.GetString("groupBox3.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox3, ((int)(resources.GetObject("groupBox3.IconPadding"))));
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // Txt_Remaining
            // 
            resources.ApplyResources(this.Txt_Remaining, "Txt_Remaining");
            this.errorProvider1.SetError(this.Txt_Remaining, resources.GetString("Txt_Remaining.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_Remaining, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_Remaining.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_Remaining, ((int)(resources.GetObject("Txt_Remaining.IconPadding"))));
            this.Txt_Remaining.Name = "Txt_Remaining";
            this.Txt_Remaining.ReadOnly = true;
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
            // Cmb_DealerName
            // 
            resources.ApplyResources(this.Cmb_DealerName, "Cmb_DealerName");
            this.Cmb_DealerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_DealerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_DealerName.DataSource = this.dealersBindingSource;
            this.Cmb_DealerName.DisplayMember = "DealerName";
            this.errorProvider1.SetError(this.Cmb_DealerName, resources.GetString("Cmb_DealerName.Error"));
            this.Cmb_DealerName.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.Cmb_DealerName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Cmb_DealerName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Cmb_DealerName, ((int)(resources.GetObject("Cmb_DealerName.IconPadding"))));
            this.Cmb_DealerName.Name = "Cmb_DealerName";
            this.Cmb_DealerName.ValueMember = "DealerName";
            this.Cmb_DealerName.TextChanged += new System.EventHandler(this.Cmb_DealerName_TextChanged);
            // 
            // dealersBindingSource
            // 
            this.dealersBindingSource.DataMember = "dealers";
            this.dealersBindingSource.DataSource = this.storeDataSet;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.errorProvider1.SetError(this.label9, resources.GetString("label9.Error"));
            this.errorProvider1.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.label9.Name = "label9";
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
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error"));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errorProvider1.SetError(this.label8, resources.GetString("label8.Error"));
            this.errorProvider1.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Name = "label8";
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
            // dealersTableAdapter
            // 
            this.dealersTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
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
            this.costDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchaseReturnDetailsBindingSource;
            this.errorProvider1.SetError(this.dataGridView1, resources.GetString("dataGridView1.Error"));
            this.errorProvider1.SetIconAlignment(this.dataGridView1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataGridView1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.dataGridView1, ((int)(resources.GetObject("dataGridView1.IconPadding"))));
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
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
            // Txt_BuyPrice
            // 
            resources.ApplyResources(this.Txt_BuyPrice, "Txt_BuyPrice");
            this.errorProvider1.SetError(this.Txt_BuyPrice, resources.GetString("Txt_BuyPrice.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_BuyPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_BuyPrice.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_BuyPrice, ((int)(resources.GetObject("Txt_BuyPrice.IconPadding"))));
            this.Txt_BuyPrice.Name = "Txt_BuyPrice";
            // 
            // Txt_ToBuy
            // 
            resources.ApplyResources(this.Txt_ToBuy, "Txt_ToBuy");
            this.errorProvider1.SetError(this.Txt_ToBuy, resources.GetString("Txt_ToBuy.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_ToBuy, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_ToBuy.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_ToBuy, ((int)(resources.GetObject("Txt_ToBuy.IconPadding"))));
            this.Txt_ToBuy.Name = "Txt_ToBuy";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
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
            this.Cmb_ItemName.ValueMember = "ItemName";
            this.Cmb_ItemName.TextChanged += new System.EventHandler(this.Cmb_ItemName_TextChanged);
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
            this.groupBox2.Controls.Add(this.Txt_BuyPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Txt_ToBuy);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Cmb_ItemName);
            this.errorProvider1.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // purchasebillsreturnBindingSource
            // 
            this.purchasebillsreturnBindingSource.DataMember = "purchasebillsreturn";
            this.purchasebillsreturnBindingSource.DataSource = this.storeDataSet;
            // 
            // purchasebillsreturnTableAdapter
            // 
            this.purchasebillsreturnTableAdapter.ClearBeforeFill = true;
            // 
            // purchasesitemsreturnBindingSource
            // 
            this.purchasesitemsreturnBindingSource.DataMember = "purchasesitemsreturn";
            this.purchasesitemsreturnBindingSource.DataSource = this.storeDataSet;
            // 
            // purchasesitemsreturnTableAdapter
            // 
            this.purchasesitemsreturnTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseReturnDetailsBindingSource
            // 
            this.purchaseReturnDetailsBindingSource.DataMember = "PurchaseReturnDetails";
            this.purchaseReturnDetailsBindingSource.DataSource = this.storeDataSet;
            // 
            // purchaseReturnDetailsTableAdapter
            // 
            this.purchaseReturnDetailsTableAdapter.ClearBeforeFill = true;
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
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            resources.ApplyResources(this.costDataGridViewTextBoxColumn, "costDataGridViewTextBoxColumn");
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            resources.ApplyResources(this.totalDataGridViewTextBoxColumn, "totalDataGridViewTextBoxColumn");
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReturnBuy
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ReturnBuy";
            this.Load += new System.EventHandler(this.ReturnBuy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesitemsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReturnDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_BillID;
        private System.Windows.Forms.TextBox Txt_DealerID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Txt_Remaining;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_TotalBill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Paid;
        private System.Windows.Forms.ComboBox Cmb_DealerName;
        private System.Windows.Forms.BindingSource dealersBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Cost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_ItemID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource vaultBindingSource;
        private storeDataSetTableAdapters.vaultTableAdapter vaultTableAdapter;
        private storeDataSetTableAdapters.dealersTableAdapter dealersTableAdapter;
        private storeDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.TextBox Txt_InStock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_BuyPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_ToBuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_ItemName;
        private System.Windows.Forms.BindingSource purchasebillsreturnBindingSource;
        private storeDataSetTableAdapters.purchasebillsreturnTableAdapter purchasebillsreturnTableAdapter;
        private System.Windows.Forms.BindingSource purchasesitemsreturnBindingSource;
        private storeDataSetTableAdapters.purchasesitemsreturnTableAdapter purchasesitemsreturnTableAdapter;
        private System.Windows.Forms.BindingSource purchaseReturnDetailsBindingSource;
        private storeDataSetTableAdapters.PurchaseReturnDetailsTableAdapter purchaseReturnDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}