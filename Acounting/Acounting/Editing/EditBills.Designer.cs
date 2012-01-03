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
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(882, 344);
            this.dataGridView1.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Details";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(801, 19);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(72, 37);
            this.Btn_Save.TabIndex = 14;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(584, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Type";
            // 
            // Txt_Type
            // 
            this.Txt_Type.Location = new System.Drawing.Point(587, 43);
            this.Txt_Type.Name = "Txt_Type";
            this.Txt_Type.ReadOnly = true;
            this.Txt_Type.Size = new System.Drawing.Size(100, 20);
            this.Txt_Type.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(484, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Remainning";
            // 
            // Txt_Remaining
            // 
            this.Txt_Remaining.Location = new System.Drawing.Point(487, 44);
            this.Txt_Remaining.Name = "Txt_Remaining";
            this.Txt_Remaining.ReadOnly = true;
            this.Txt_Remaining.Size = new System.Drawing.Size(76, 20);
            this.Txt_Remaining.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(279, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Bill";
            // 
            // Txt_TotalBill
            // 
            this.Txt_TotalBill.Location = new System.Drawing.Point(282, 44);
            this.Txt_TotalBill.Name = "Txt_TotalBill";
            this.Txt_TotalBill.ReadOnly = true;
            this.Txt_TotalBill.Size = new System.Drawing.Size(81, 20);
            this.Txt_TotalBill.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(394, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paid";
            // 
            // Txt_Paid
            // 
            this.Txt_Paid.Location = new System.Drawing.Point(397, 44);
            this.Txt_Paid.Name = "Txt_Paid";
            this.Txt_Paid.Size = new System.Drawing.Size(76, 20);
            this.Txt_Paid.TabIndex = 4;
            this.Txt_Paid.TextChanged += new System.EventHandler(this.Txt_Paid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bill ID";
            // 
            // Txt_BillID
            // 
            this.Txt_BillID.Location = new System.Drawing.Point(9, 44);
            this.Txt_BillID.Name = "Txt_BillID";
            this.Txt_BillID.ReadOnly = true;
            this.Txt_BillID.Size = new System.Drawing.Size(53, 20);
            this.Txt_BillID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(70, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Document Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(882, 86);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item";
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(752, 38);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 19;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(833, 38);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(31, 23);
            this.Btn_Add.TabIndex = 18;
            this.Btn_Add.Text = "+";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Txt_RowID
            // 
            this.Txt_RowID.Location = new System.Drawing.Point(207, 40);
            this.Txt_RowID.Name = "Txt_RowID";
            this.Txt_RowID.ReadOnly = true;
            this.Txt_RowID.Size = new System.Drawing.Size(58, 22);
            this.Txt_RowID.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(204, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 16);
            this.label18.TabIndex = 16;
            this.label18.Text = "Row ID";
            // 
            // Txt_Cost
            // 
            this.Txt_Cost.Location = new System.Drawing.Point(442, 40);
            this.Txt_Cost.Name = "Txt_Cost";
            this.Txt_Cost.ReadOnly = true;
            this.Txt_Cost.Size = new System.Drawing.Size(53, 22);
            this.Txt_Cost.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(439, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cost";
            // 
            // Txt_ItemID
            // 
            this.Txt_ItemID.Location = new System.Drawing.Point(282, 40);
            this.Txt_ItemID.Name = "Txt_ItemID";
            this.Txt_ItemID.ReadOnly = true;
            this.Txt_ItemID.Size = new System.Drawing.Size(58, 22);
            this.Txt_ItemID.TabIndex = 13;
            this.Txt_ItemID.TextChanged += new System.EventHandler(this.Txt_ItemID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(279, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Item ID";
            // 
            // Txt_InStock
            // 
            this.Txt_InStock.Location = new System.Drawing.Point(360, 40);
            this.Txt_InStock.Name = "Txt_InStock";
            this.Txt_InStock.ReadOnly = true;
            this.Txt_InStock.Size = new System.Drawing.Size(62, 22);
            this.Txt_InStock.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(357, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "In Stock";
            // 
            // Txt_Price
            // 
            this.Txt_Price.Location = new System.Drawing.Point(608, 40);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.Size = new System.Drawing.Size(61, 22);
            this.Txt_Price.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(605, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Price";
            // 
            // Txt_Units
            // 
            this.Txt_Units.Location = new System.Drawing.Point(520, 40);
            this.Txt_Units.Name = "Txt_Units";
            this.Txt_Units.Size = new System.Drawing.Size(62, 22);
            this.Txt_Units.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(517, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Units";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(9, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Item Name";
            // 
            // Cmb_ItemName
            // 
            this.Cmb_ItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_ItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_ItemName.DataSource = this.itemsBindingSource;
            this.Cmb_ItemName.DisplayMember = "ItemName";
            this.Cmb_ItemName.FormattingEnabled = true;
            this.Cmb_ItemName.Location = new System.Drawing.Point(12, 38);
            this.Cmb_ItemName.Name = "Cmb_ItemName";
            this.Cmb_ItemName.Size = new System.Drawing.Size(178, 24);
            this.Cmb_ItemName.TabIndex = 1;
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
            // EditBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditBills";
            this.Text = "EditBills";
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
    }
}