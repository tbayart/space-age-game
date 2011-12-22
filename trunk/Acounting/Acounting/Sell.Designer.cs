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
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.itemsTableAdapter = new Acounting.storeDataSetTableAdapters.itemsTableAdapter();
            this.agentsTableAdapter = new Acounting.storeDataSetTableAdapters.agentsTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsTableAdapter = new Acounting.storeDataSetTableAdapters.billsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.salesitemsTableAdapter = new Acounting.storeDataSetTableAdapters.salesitemsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.vaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaultTableAdapter = new Acounting.storeDataSetTableAdapters.vaultTableAdapter();
            this.billsBillIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earningsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_BillID
            // 
            this.Txt_BillID.Location = new System.Drawing.Point(25, 34);
            this.Txt_BillID.Name = "Txt_BillID";
            this.Txt_BillID.ReadOnly = true;
            this.Txt_BillID.Size = new System.Drawing.Size(100, 22);
            this.Txt_BillID.TabIndex = 0;
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_BillID);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill";
            // 
            // Cmb_ItemName
            // 
            this.Cmb_ItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_ItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_ItemName.DataSource = this.itemsBindingSource;
            this.Cmb_ItemName.DisplayMember = "ItemName";
            this.Cmb_ItemName.FormattingEnabled = true;
            this.Cmb_ItemName.Location = new System.Drawing.Point(20, 42);
            this.Cmb_ItemName.Name = "Cmb_ItemName";
            this.Cmb_ItemName.Size = new System.Drawing.Size(178, 24);
            this.Cmb_ItemName.TabIndex = 1;     
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
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item";
            // 
            // Txt_Cost
            // 
            this.Txt_Cost.Location = new System.Drawing.Point(378, 44);
            this.Txt_Cost.Name = "Txt_Cost";
            this.Txt_Cost.ReadOnly = true;
            this.Txt_Cost.Size = new System.Drawing.Size(53, 22);
            this.Txt_Cost.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cost";
            // 
            // Txt_ItemID
            // 
            this.Txt_ItemID.Location = new System.Drawing.Point(218, 44);
            this.Txt_ItemID.Name = "Txt_ItemID";
            this.Txt_ItemID.ReadOnly = true;
            this.Txt_ItemID.Size = new System.Drawing.Size(58, 22);
            this.Txt_ItemID.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Item ID";
            // 
            // Txt_InStock
            // 
            this.Txt_InStock.Location = new System.Drawing.Point(296, 44);
            this.Txt_InStock.Name = "Txt_InStock";
            this.Txt_InStock.ReadOnly = true;
            this.Txt_InStock.Size = new System.Drawing.Size(62, 22);
            this.Txt_InStock.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "In Stock";
            // 
            // Txt_SellPrice
            // 
            this.Txt_SellPrice.Location = new System.Drawing.Point(544, 44);
            this.Txt_SellPrice.Name = "Txt_SellPrice";
            this.Txt_SellPrice.Size = new System.Drawing.Size(61, 22);
            this.Txt_SellPrice.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Selling Price";
            // 
            // Txt_ToSell
            // 
            this.Txt_ToSell.Location = new System.Drawing.Point(456, 44);
            this.Txt_ToSell.Name = "Txt_ToSell";
            this.Txt_ToSell.Size = new System.Drawing.Size(62, 22);
            this.Txt_ToSell.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Units To Sell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item Name";
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
            this.groupBox3.Location = new System.Drawing.Point(2, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 72);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agent";
            // 
            // Txt_Remaining
            // 
            this.Txt_Remaining.Location = new System.Drawing.Point(507, 39);
            this.Txt_Remaining.Name = "Txt_Remaining";
            this.Txt_Remaining.ReadOnly = true;
            this.Txt_Remaining.Size = new System.Drawing.Size(92, 20);
            this.Txt_Remaining.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(504, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Remaining";
            // 
            // Txt_TotalBill
            // 
            this.Txt_TotalBill.Location = new System.Drawing.Point(402, 39);
            this.Txt_TotalBill.Name = "Txt_TotalBill";
            this.Txt_TotalBill.ReadOnly = true;
            this.Txt_TotalBill.Size = new System.Drawing.Size(86, 20);
            this.Txt_TotalBill.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(399, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Total Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Paid";
            // 
            // Txt_Paid
            // 
            this.Txt_Paid.Location = new System.Drawing.Point(294, 38);
            this.Txt_Paid.Name = "Txt_Paid";
            this.Txt_Paid.Size = new System.Drawing.Size(97, 20);
            this.Txt_Paid.TabIndex = 5;
            this.Txt_Paid.Text = "0";
            // 
            // Txt_AgentID
            // 
            this.Txt_AgentID.Location = new System.Drawing.Point(206, 39);
            this.Txt_AgentID.Name = "Txt_AgentID";
            this.Txt_AgentID.ReadOnly = true;
            this.Txt_AgentID.Size = new System.Drawing.Size(66, 20);
            this.Txt_AgentID.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Agent ID";
            // 
            // Cmb_AgentName
            // 
            this.Cmb_AgentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_AgentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_AgentName.DataSource = this.agentsBindingSource;
            this.Cmb_AgentName.DisplayMember = "AgentName";
            this.Cmb_AgentName.FormattingEnabled = true;
            this.Cmb_AgentName.Location = new System.Drawing.Point(11, 38);
            this.Cmb_AgentName.Name = "Cmb_AgentName";
            this.Cmb_AgentName.Size = new System.Drawing.Size(178, 21);
            this.Cmb_AgentName.TabIndex = 4;
            this.Cmb_AgentName.ValueMember = "AgentName";
            this.Cmb_AgentName.TextChanged += new System.EventHandler(this.Cmb_AgentName_TextChanged);
            // 
            // agentsBindingSource
            // 
            this.agentsBindingSource.DataMember = "agents";
            this.agentsBindingSource.DataSource = this.storeDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Agent Name";
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(4, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(874, 299);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bill Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billsBillIDDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.sellPriceDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.earningsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesitemsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(868, 280);
            this.dataGridView1.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add To Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salesitemsTableAdapter
            // 
            this.salesitemsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // billsBillIDDataGridViewTextBoxColumn
            // 
            this.billsBillIDDataGridViewTextBoxColumn.DataPropertyName = "Bills_BillID";
            this.billsBillIDDataGridViewTextBoxColumn.HeaderText = "Bills_BillID";
            this.billsBillIDDataGridViewTextBoxColumn.Name = "billsBillIDDataGridViewTextBoxColumn";
            this.billsBillIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellPriceDataGridViewTextBoxColumn
            // 
            this.sellPriceDataGridViewTextBoxColumn.DataPropertyName = "SellPrice";
            this.sellPriceDataGridViewTextBoxColumn.HeaderText = "SellPrice";
            this.sellPriceDataGridViewTextBoxColumn.Name = "sellPriceDataGridViewTextBoxColumn";
            this.sellPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // earningsDataGridViewTextBoxColumn
            // 
            this.earningsDataGridViewTextBoxColumn.DataPropertyName = "Earnings";
            this.earningsDataGridViewTextBoxColumn.HeaderText = "Earnings";
            this.earningsDataGridViewTextBoxColumn.Name = "earningsDataGridViewTextBoxColumn";
            this.earningsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 612);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sell";
            this.Text = "Sell";
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
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private storeDataSetTableAdapters.agentsTableAdapter agentsTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn billsBillIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn earningsDataGridViewTextBoxColumn;
    }
}