namespace Acounting
{
    partial class Vault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vault));
            this.Cmd_Add = new System.Windows.Forms.Button();
            this.Txt_AddOpenning = new System.Windows.Forms.TextBox();
            this.vaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.vaultTableAdapter = new Acounting.storeDataSetTableAdapters.vaultTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.collectedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.paidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.collectedTableAdapter = new Acounting.storeDataSetTableAdapters.collectedTableAdapter();
            this.paidTableAdapter = new Acounting.storeDataSetTableAdapters.paidTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Txt_totalpurchasebillsreturn = new System.Windows.Forms.TextBox();
            this.totalPurchasesReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Txt_totalpurchasebills = new System.Windows.Forms.TextBox();
            this.totalPurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Nettotalpurchasebills = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Nettotalbills = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_totalbillsreturn = new System.Windows.Forms.TextBox();
            this.totalBillsReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Txt_totalbills = new System.Windows.Forms.TextBox();
            this.totalBillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.totalEarningsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.totalPurchaseTableAdapter = new Acounting.storeDataSetTableAdapters.TotalPurchaseTableAdapter();
            this.totalPurchasesReturnTableAdapter = new Acounting.storeDataSetTableAdapters.TotalPurchasesReturnTableAdapter();
            this.totalBillsTableAdapter = new Acounting.storeDataSetTableAdapters.TotalBillsTableAdapter();
            this.totalBillsReturnTableAdapter = new Acounting.storeDataSetTableAdapters.TotalBillsReturnTableAdapter();
            this.totalEarningsTableAdapter = new Acounting.storeDataSetTableAdapters.TotalEarningsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPurchasesReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPurchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBillsReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalEarningsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmd_Add
            // 
            resources.ApplyResources(this.Cmd_Add, "Cmd_Add");
            this.Cmd_Add.Name = "Cmd_Add";
            this.Cmd_Add.UseVisualStyleBackColor = true;
            this.Cmd_Add.Click += new System.EventHandler(this.Cmd_Add_Click);
            // 
            // Txt_AddOpenning
            // 
            resources.ApplyResources(this.Txt_AddOpenning, "Txt_AddOpenning");
            this.Txt_AddOpenning.Name = "Txt_AddOpenning";
            // 
            // vaultBindingSource
            // 
            this.vaultBindingSource.DataMember = "vault";
            this.vaultBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vaultTableAdapter
            // 
            this.vaultTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vaultBindingSource, "Opennings", true));
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.collectedBindingSource, "CollectedTotal", true));
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // collectedBindingSource
            // 
            this.collectedBindingSource.DataMember = "collected";
            this.collectedBindingSource.DataSource = this.storeDataSet;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paidBindingSource, "PaidTotal", true));
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            // 
            // paidBindingSource
            // 
            this.paidBindingSource.DataMember = "paid";
            this.paidBindingSource.DataSource = this.storeDataSet;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vaultBindingSource, "In_Hand", true));
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            // 
            // collectedTableAdapter
            // 
            this.collectedTableAdapter.ClearBeforeFill = true;
            // 
            // paidTableAdapter
            // 
            this.paidTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vaultBindingSource, "In_Hand", true));
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            // 
            // Txt_totalpurchasebillsreturn
            // 
            this.Txt_totalpurchasebillsreturn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.totalPurchasesReturnBindingSource, "Expr1", true));
            resources.ApplyResources(this.Txt_totalpurchasebillsreturn, "Txt_totalpurchasebillsreturn");
            this.Txt_totalpurchasebillsreturn.Name = "Txt_totalpurchasebillsreturn";
            this.Txt_totalpurchasebillsreturn.ReadOnly = true;
            // 
            // totalPurchasesReturnBindingSource
            // 
            this.totalPurchasesReturnBindingSource.DataMember = "TotalPurchasesReturn";
            this.totalPurchasesReturnBindingSource.DataSource = this.storeDataSet;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.collectedBindingSource, "CollectedTotal", true));
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            // 
            // Txt_totalpurchasebills
            // 
            this.Txt_totalpurchasebills.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.totalPurchaseBindingSource, "TotalPurchase", true));
            resources.ApplyResources(this.Txt_totalpurchasebills, "Txt_totalpurchasebills");
            this.Txt_totalpurchasebills.Name = "Txt_totalpurchasebills";
            this.Txt_totalpurchasebills.ReadOnly = true;
            // 
            // totalPurchaseBindingSource
            // 
            this.totalPurchaseBindingSource.DataMember = "TotalPurchase";
            this.totalPurchaseBindingSource.DataSource = this.storeDataSet;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // Txt_Nettotalpurchasebills
            // 
            resources.ApplyResources(this.Txt_Nettotalpurchasebills, "Txt_Nettotalpurchasebills");
            this.Txt_Nettotalpurchasebills.Name = "Txt_Nettotalpurchasebills";
            this.Txt_Nettotalpurchasebills.ReadOnly = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // Txt_Nettotalbills
            // 
            resources.ApplyResources(this.Txt_Nettotalbills, "Txt_Nettotalbills");
            this.Txt_Nettotalbills.Name = "Txt_Nettotalbills";
            this.Txt_Nettotalbills.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // Txt_totalbillsreturn
            // 
            this.Txt_totalbillsreturn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.totalBillsReturnBindingSource, "Expr1", true));
            resources.ApplyResources(this.Txt_totalbillsreturn, "Txt_totalbillsreturn");
            this.Txt_totalbillsreturn.Name = "Txt_totalbillsreturn";
            this.Txt_totalbillsreturn.ReadOnly = true;
            // 
            // totalBillsReturnBindingSource
            // 
            this.totalBillsReturnBindingSource.DataMember = "TotalBillsReturn";
            this.totalBillsReturnBindingSource.DataSource = this.storeDataSet;
            // 
            // Txt_totalbills
            // 
            this.Txt_totalbills.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.totalBillsBindingSource, "TotalToalBills", true));
            resources.ApplyResources(this.Txt_totalbills, "Txt_totalbills");
            this.Txt_totalbills.Name = "Txt_totalbills";
            this.Txt_totalbills.ReadOnly = true;
            // 
            // totalBillsBindingSource
            // 
            this.totalBillsBindingSource.DataMember = "TotalBills";
            this.totalBillsBindingSource.DataSource = this.storeDataSet;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.totalEarningsBindingSource, "TotalEarnings", true));
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            // 
            // totalEarningsBindingSource
            // 
            this.totalEarningsBindingSource.DataMember = "TotalEarnings";
            this.totalEarningsBindingSource.DataSource = this.storeDataSet;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // totalPurchaseTableAdapter
            // 
            this.totalPurchaseTableAdapter.ClearBeforeFill = true;
            // 
            // totalPurchasesReturnTableAdapter
            // 
            this.totalPurchasesReturnTableAdapter.ClearBeforeFill = true;
            // 
            // totalBillsTableAdapter
            // 
            this.totalBillsTableAdapter.ClearBeforeFill = true;
            // 
            // totalBillsReturnTableAdapter
            // 
            this.totalBillsReturnTableAdapter.ClearBeforeFill = true;
            // 
            // totalEarningsTableAdapter
            // 
            this.totalEarningsTableAdapter.ClearBeforeFill = true;
            // 
            // Vault
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Txt_Nettotalbills);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_totalbillsreturn);
            this.Controls.Add(this.Txt_totalbills);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Txt_Nettotalpurchasebills);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Txt_totalpurchasebillsreturn);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Txt_totalpurchasebills);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_AddOpenning);
            this.Controls.Add(this.Cmd_Add);
            this.Name = "Vault";
            this.Load += new System.EventHandler(this.Vault_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPurchasesReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPurchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBillsReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalEarningsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cmd_Add;
        private System.Windows.Forms.TextBox Txt_AddOpenning;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource vaultBindingSource;
        private storeDataSetTableAdapters.vaultTableAdapter vaultTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.BindingSource collectedBindingSource;
        private storeDataSetTableAdapters.collectedTableAdapter collectedTableAdapter;
        private System.Windows.Forms.BindingSource paidBindingSource;
        private storeDataSetTableAdapters.paidTableAdapter paidTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox Txt_Nettotalpurchasebills;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox Txt_totalpurchasebillsreturn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox Txt_totalpurchasebills;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Nettotalbills;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_totalbillsreturn;
        private System.Windows.Forms.TextBox Txt_totalbills;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource totalPurchaseBindingSource;
        private storeDataSetTableAdapters.TotalPurchaseTableAdapter totalPurchaseTableAdapter;
        private System.Windows.Forms.BindingSource totalPurchasesReturnBindingSource;
        private storeDataSetTableAdapters.TotalPurchasesReturnTableAdapter totalPurchasesReturnTableAdapter;
        private System.Windows.Forms.BindingSource totalBillsBindingSource;
        private storeDataSetTableAdapters.TotalBillsTableAdapter totalBillsTableAdapter;
        private System.Windows.Forms.BindingSource totalBillsReturnBindingSource;
        private storeDataSetTableAdapters.TotalBillsReturnTableAdapter totalBillsReturnTableAdapter;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource totalEarningsBindingSource;
        private storeDataSetTableAdapters.TotalEarningsTableAdapter totalEarningsTableAdapter;
    }
}