namespace Acounting
{
    partial class Buy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_BillID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.storeDataSet = new Acounting.storeDataSet();
            this.purchasesitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Txt_Remaining = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_TotalBill = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Paid = new System.Windows.Forms.TextBox();
            this.Txt_Cost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_ItemID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_InStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_BuyPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_ToBuy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_ItemName = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Txt_DealerID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cmb_DealerName = new System.Windows.Forms.ComboBox();
            this.dealersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.itemsTableAdapter = new Acounting.storeDataSetTableAdapters.itemsTableAdapter();
            this.purchasebillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasebillsTableAdapter = new Acounting.storeDataSetTableAdapters.purchasebillsTableAdapter();
            this.dealersTableAdapter = new Acounting.storeDataSetTableAdapters.dealersTableAdapter();
            this.purchasesitemsTableAdapter = new Acounting.storeDataSetTableAdapters.purchasesitemsTableAdapter();
            this.vaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaultTableAdapter = new Acounting.storeDataSetTableAdapters.vaultTableAdapter();
            this.purchaseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDetailsTableAdapter = new Acounting.storeDataSetTableAdapters.PurchaseDetailsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesitemsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_BillID);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill ID";
            // 
            // Txt_BillID
            // 
            this.Txt_BillID.Location = new System.Drawing.Point(20, 30);
            this.Txt_BillID.Name = "Txt_BillID";
            this.Txt_BillID.ReadOnly = true;
            this.Txt_BillID.Size = new System.Drawing.Size(100, 22);
            this.Txt_BillID.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(9, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(874, 299);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bill Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(868, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasesitemsBindingSource
            // 
            this.purchasesitemsBindingSource.DataMember = "purchasesitems";
            this.purchasesitemsBindingSource.DataSource = this.storeDataSet;
            // 
            // Txt_Remaining
            // 
            this.Txt_Remaining.Location = new System.Drawing.Point(502, 35);
            this.Txt_Remaining.Name = "Txt_Remaining";
            this.Txt_Remaining.ReadOnly = true;
            this.Txt_Remaining.Size = new System.Drawing.Size(92, 20);
            this.Txt_Remaining.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(499, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Remaining";
            // 
            // Txt_TotalBill
            // 
            this.Txt_TotalBill.Location = new System.Drawing.Point(397, 35);
            this.Txt_TotalBill.Name = "Txt_TotalBill";
            this.Txt_TotalBill.ReadOnly = true;
            this.Txt_TotalBill.Size = new System.Drawing.Size(86, 20);
            this.Txt_TotalBill.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(113, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add To Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(394, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Total Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Paid";
            // 
            // Txt_Paid
            // 
            this.Txt_Paid.Location = new System.Drawing.Point(289, 34);
            this.Txt_Paid.Name = "Txt_Paid";
            this.Txt_Paid.Size = new System.Drawing.Size(97, 20);
            this.Txt_Paid.TabIndex = 5;
            this.Txt_Paid.Text = "0";
            this.Txt_Paid.TextChanged += new System.EventHandler(this.Txt_Paid_TextChanged);
            // 
            // Txt_Cost
            // 
            this.Txt_Cost.Location = new System.Drawing.Point(373, 40);
            this.Txt_Cost.Name = "Txt_Cost";
            this.Txt_Cost.ReadOnly = true;
            this.Txt_Cost.Size = new System.Drawing.Size(53, 22);
            this.Txt_Cost.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cost";
            // 
            // Txt_ItemID
            // 
            this.Txt_ItemID.Location = new System.Drawing.Point(213, 40);
            this.Txt_ItemID.Name = "Txt_ItemID";
            this.Txt_ItemID.ReadOnly = true;
            this.Txt_ItemID.Size = new System.Drawing.Size(58, 22);
            this.Txt_ItemID.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Item ID";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 86);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item";
            // 
            // Txt_InStock
            // 
            this.Txt_InStock.Location = new System.Drawing.Point(291, 40);
            this.Txt_InStock.Name = "Txt_InStock";
            this.Txt_InStock.ReadOnly = true;
            this.Txt_InStock.Size = new System.Drawing.Size(62, 22);
            this.Txt_InStock.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "In Stock";
            // 
            // Txt_BuyPrice
            // 
            this.Txt_BuyPrice.Location = new System.Drawing.Point(539, 40);
            this.Txt_BuyPrice.Name = "Txt_BuyPrice";
            this.Txt_BuyPrice.Size = new System.Drawing.Size(61, 22);
            this.Txt_BuyPrice.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Buying Price";
            // 
            // Txt_ToBuy
            // 
            this.Txt_ToBuy.Location = new System.Drawing.Point(451, 40);
            this.Txt_ToBuy.Name = "Txt_ToBuy";
            this.Txt_ToBuy.Size = new System.Drawing.Size(62, 22);
            this.Txt_ToBuy.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Units To Buy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item Name";
            // 
            // Cmb_ItemName
            // 
            this.Cmb_ItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_ItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_ItemName.DataSource = this.itemsBindingSource;
            this.Cmb_ItemName.DisplayMember = "ItemName";
            this.Cmb_ItemName.FormattingEnabled = true;
            this.Cmb_ItemName.Location = new System.Drawing.Point(15, 38);
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
            // Txt_DealerID
            // 
            this.Txt_DealerID.Location = new System.Drawing.Point(201, 35);
            this.Txt_DealerID.Name = "Txt_DealerID";
            this.Txt_DealerID.ReadOnly = true;
            this.Txt_DealerID.Size = new System.Drawing.Size(66, 20);
            this.Txt_DealerID.TabIndex = 3;
            // 
            // groupBox3
            // 
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
            this.groupBox3.Location = new System.Drawing.Point(7, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 72);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dealer";
     
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Dealer ID";
            // 
            // Cmb_DealerName
            // 
            this.Cmb_DealerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_DealerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_DealerName.DataSource = this.dealersBindingSource;
            this.Cmb_DealerName.DisplayMember = "DealerName";
            this.Cmb_DealerName.FormattingEnabled = true;
            this.Cmb_DealerName.Location = new System.Drawing.Point(6, 34);
            this.Cmb_DealerName.Name = "Cmb_DealerName";
            this.Cmb_DealerName.Size = new System.Drawing.Size(178, 21);
            this.Cmb_DealerName.TabIndex = 4;
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
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Dealer Name";
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
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
            // dealersTableAdapter
            // 
            this.dealersTableAdapter.ClearBeforeFill = true;
            // 
            // purchasesitemsTableAdapter
            // 
            this.purchasesitemsTableAdapter.ClearBeforeFill = true;
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
            // purchaseDetailsBindingSource
            // 
            this.purchaseDetailsBindingSource.DataMember = "PurchaseDetails";
            this.purchaseDetailsBindingSource.DataSource = this.storeDataSet;
            // 
            // purchaseDetailsTableAdapter
            // 
            this.purchaseDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Buy";
            this.Text = "Buy";
            this.Load += new System.EventHandler(this.Buy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesitemsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_BillID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_Cost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_ItemID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_InStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_BuyPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_ToBuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_ItemName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Txt_Remaining;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_TotalBill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Paid;
        private System.Windows.Forms.TextBox Txt_DealerID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cmb_DealerName;
        private System.Windows.Forms.Label label9;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private storeDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingSource purchasebillsBindingSource;
        private storeDataSetTableAdapters.purchasebillsTableAdapter purchasebillsTableAdapter;
        private System.Windows.Forms.BindingSource dealersBindingSource;
        private storeDataSetTableAdapters.dealersTableAdapter dealersTableAdapter;
        private System.Windows.Forms.BindingSource purchasesitemsBindingSource;
        private storeDataSetTableAdapters.purchasesitemsTableAdapter purchasesitemsTableAdapter;
        private System.Windows.Forms.BindingSource vaultBindingSource;
        private storeDataSetTableAdapters.vaultTableAdapter vaultTableAdapter;
        private System.Windows.Forms.BindingSource purchaseDetailsBindingSource;
        private storeDataSetTableAdapters.PurchaseDetailsTableAdapter purchaseDetailsTableAdapter;
    }
}