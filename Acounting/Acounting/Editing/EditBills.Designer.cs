namespace Acounting
{
    partial class EditBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBills));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allBillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsTableAdapter = new Acounting.storeDataSetTableAdapters.billsTableAdapter();
            this.billsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.billsreturnTableAdapter();
            this.purchasebillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasebillsTableAdapter = new Acounting.storeDataSetTableAdapters.purchasebillsTableAdapter();
            this.purchasebillsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasebillsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.purchasebillsreturnTableAdapter();
            this.namesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namesTableAdapter = new Acounting.storeDataSetTableAdapters.namesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.Txt_Type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Remaining = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_TotalBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Paid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_BillID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Txt_RowID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Txt_Cost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_ItemID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_InStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Units = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Cmb_ItemName = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Acounting.storeDataSetTableAdapters.itemsTableAdapter();
            this.vaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaultTableAdapter = new Acounting.storeDataSetTableAdapters.vaultTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.salesitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesitemsTableAdapter = new Acounting.storeDataSetTableAdapters.salesitemsTableAdapter();
            this.salesitemsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesitemsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.salesitemsreturnTableAdapter();
            this.purchasesitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesitemsTableAdapter = new Acounting.storeDataSetTableAdapters.purchasesitemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesitemsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesitemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.errorProvider1.SetError(this.dataGridView1, resources.GetString("dataGridView1.Error"));
            this.errorProvider1.SetIconAlignment(this.dataGridView1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataGridView1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.dataGridView1, ((int)(resources.GetObject("dataGridView1.IconPadding"))));
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // allBillsBindingSource
            // 
            this.allBillsBindingSource.DataMember = "AllBills";
            this.allBillsBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataMember = "bills";
            this.billsBindingSource.DataSource = this.storeDataSet;
            // 
            // billsTableAdapter
            // 
            this.billsTableAdapter.ClearBeforeFill = true;
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
            // purchasebillsBindingSource
            // 
            this.purchasebillsBindingSource.DataMember = "purchasebills";
            this.purchasebillsBindingSource.DataSource = this.storeDataSet;
            // 
            // purchasebillsTableAdapter
            // 
            this.purchasebillsTableAdapter.ClearBeforeFill = true;
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
            // namesBindingSource
            // 
            this.namesBindingSource.DataMember = "names";
            this.namesBindingSource.DataSource = this.storeDataSet;
            // 
            // namesTableAdapter
            // 
            this.namesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.Txt_Type);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_Remaining);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_TotalBill);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Paid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_BillID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.errorProvider1.SetError(this.groupBox1, resources.GetString("groupBox1.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding"))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Btn_Save
            // 
            resources.ApplyResources(this.Btn_Save, "Btn_Save");
            this.errorProvider1.SetError(this.Btn_Save, resources.GetString("Btn_Save.Error"));
            this.errorProvider1.SetIconAlignment(this.Btn_Save, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Btn_Save.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Btn_Save, ((int)(resources.GetObject("Btn_Save.IconPadding"))));
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.errorProvider1.SetError(this.label17, resources.GetString("label17.Error"));
            this.errorProvider1.SetIconAlignment(this.label17, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label17.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label17, ((int)(resources.GetObject("label17.IconPadding"))));
            this.label17.Name = "label17";
            // 
            // Txt_Type
            // 
            resources.ApplyResources(this.Txt_Type, "Txt_Type");
            this.errorProvider1.SetError(this.Txt_Type, resources.GetString("Txt_Type.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_Type, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_Type.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_Type, ((int)(resources.GetObject("Txt_Type.IconPadding"))));
            this.Txt_Type.Name = "Txt_Type";
            this.Txt_Type.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.errorProvider1.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error"));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.errorProvider1.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding"))));
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.Btn_Update);
            this.groupBox2.Controls.Add(this.Btn_Add);
            this.groupBox2.Controls.Add(this.Txt_RowID);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.Txt_Cost);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Txt_ItemID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Txt_InStock);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Txt_Price);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Txt_Units);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Cmb_ItemName);
            this.errorProvider1.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Btn_Update
            // 
            resources.ApplyResources(this.Btn_Update, "Btn_Update");
            this.errorProvider1.SetError(this.Btn_Update, resources.GetString("Btn_Update.Error"));
            this.errorProvider1.SetIconAlignment(this.Btn_Update, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Btn_Update.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Btn_Update, ((int)(resources.GetObject("Btn_Update.IconPadding"))));
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Add
            // 
            resources.ApplyResources(this.Btn_Add, "Btn_Add");
            this.errorProvider1.SetError(this.Btn_Add, resources.GetString("Btn_Add.Error"));
            this.errorProvider1.SetIconAlignment(this.Btn_Add, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Btn_Add.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Btn_Add, ((int)(resources.GetObject("Btn_Add.IconPadding"))));
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Txt_RowID
            // 
            resources.ApplyResources(this.Txt_RowID, "Txt_RowID");
            this.errorProvider1.SetError(this.Txt_RowID, resources.GetString("Txt_RowID.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_RowID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_RowID.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_RowID, ((int)(resources.GetObject("Txt_RowID.IconPadding"))));
            this.Txt_RowID.Name = "Txt_RowID";
            this.Txt_RowID.ReadOnly = true;
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.errorProvider1.SetError(this.label18, resources.GetString("label18.Error"));
            this.errorProvider1.SetIconAlignment(this.label18, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label18.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label18, ((int)(resources.GetObject("label18.IconPadding"))));
            this.label18.Name = "label18";
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
            this.Txt_ItemID.TextChanged += new System.EventHandler(this.Txt_ItemID_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errorProvider1.SetError(this.label8, resources.GetString("label8.Error"));
            this.errorProvider1.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Name = "label8";
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
            // Txt_Price
            // 
            resources.ApplyResources(this.Txt_Price, "Txt_Price");
            this.errorProvider1.SetError(this.Txt_Price, resources.GetString("Txt_Price.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_Price, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_Price.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_Price, ((int)(resources.GetObject("Txt_Price.IconPadding"))));
            this.Txt_Price.Name = "Txt_Price";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.errorProvider1.SetError(this.label9, resources.GetString("label9.Error"));
            this.errorProvider1.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.label9.Name = "label9";
            // 
            // Txt_Units
            // 
            resources.ApplyResources(this.Txt_Units, "Txt_Units");
            this.errorProvider1.SetError(this.Txt_Units, resources.GetString("Txt_Units.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_Units, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_Units.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_Units, ((int)(resources.GetObject("Txt_Units.IconPadding"))));
            this.Txt_Units.Name = "Txt_Units";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errorProvider1.SetError(this.label10, resources.GetString("label10.Error"));
            this.errorProvider1.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.label10.Name = "label10";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.errorProvider1.SetError(this.label12, resources.GetString("label12.Error"));
            this.errorProvider1.SetIconAlignment(this.label12, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label12.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label12, ((int)(resources.GetObject("label12.IconPadding"))));
            this.label12.Name = "label12";
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
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.storeDataSet;
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
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // salesitemsBindingSource
            // 
            this.salesitemsBindingSource.DataMember = "salesitems";
            this.salesitemsBindingSource.DataSource = this.storeDataSet;
            // 
            // salesitemsTableAdapter
            // 
            this.salesitemsTableAdapter.ClearBeforeFill = true;
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
            // purchasesitemsBindingSource
            // 
            this.purchasesitemsBindingSource.DataMember = "purchasesitems";
            this.purchasesitemsBindingSource.DataSource = this.storeDataSet;
            // 
            // purchasesitemsTableAdapter
            // 
            this.purchasesitemsTableAdapter.ClearBeforeFill = true;
            // 
            // EditBills
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditBills";
            this.Load += new System.EventHandler(this.EditBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesitemsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesitemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private storeDataSetTableAdapters.billsTableAdapter billsTableAdapter;
        private System.Windows.Forms.BindingSource billsreturnBindingSource;
        private storeDataSetTableAdapters.billsreturnTableAdapter billsreturnTableAdapter;
        private System.Windows.Forms.BindingSource purchasebillsBindingSource;
        private storeDataSetTableAdapters.purchasebillsTableAdapter purchasebillsTableAdapter;
        private System.Windows.Forms.BindingSource purchasebillsreturnBindingSource;
        private storeDataSetTableAdapters.purchasebillsreturnTableAdapter purchasebillsreturnTableAdapter;
        private System.Windows.Forms.BindingSource namesBindingSource;
        private storeDataSetTableAdapters.namesTableAdapter namesTableAdapter;
        private System.Windows.Forms.BindingSource allBillsBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_TotalBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Paid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_BillID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Remaining;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_Cost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_ItemID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_InStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Units;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Cmb_ItemName;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private storeDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingSource vaultBindingSource;
        private storeDataSetTableAdapters.vaultTableAdapter vaultTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource salesitemsBindingSource;
        private storeDataSetTableAdapters.salesitemsTableAdapter salesitemsTableAdapter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Txt_Type;
        private System.Windows.Forms.TextBox Txt_RowID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.BindingSource salesitemsreturnBindingSource;
        private storeDataSetTableAdapters.salesitemsreturnTableAdapter salesitemsreturnTableAdapter;
        private System.Windows.Forms.BindingSource purchasesitemsBindingSource;
        private storeDataSetTableAdapters.purchasesitemsTableAdapter purchasesitemsTableAdapter;
    }
}