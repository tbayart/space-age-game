namespace Acounting
{
    partial class Payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.storeDataSet = new Acounting.storeDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_Ammount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Debt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.Txt_DealerAmmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_DealerDebt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cmb_Dealer = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.Txt_SpendingsAmmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new Acounting.storeDataSetTableAdapters.paymentsTableAdapter();
            this.dealerpaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealerpaymentsTableAdapter = new Acounting.storeDataSetTableAdapters.dealerpaymentsTableAdapter();
            this.spendingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spendingsTableAdapter = new Acounting.storeDataSetTableAdapters.spendingsTableAdapter();
            this.vaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaultTableAdapter = new Acounting.storeDataSetTableAdapters.vaultTableAdapter();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namesTableAdapter = new Acounting.storeDataSetTableAdapters.namesTableAdapter();
            this.dealersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerpaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DataSource = this.agentsBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.errorProvider1.SetError(this.comboBox1, resources.GetString("comboBox1.Error"));
            this.comboBox1.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.comboBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.comboBox1, ((int)(resources.GetObject("comboBox1.IconPadding"))));
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.errorProvider1.SetError(this.tabControl1, resources.GetString("tabControl1.Error"));
            this.errorProvider1.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding"))));
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Txt_Ammount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Txt_Debt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.errorProvider1.SetError(this.tabPage1, resources.GetString("tabPage1.Error"));
            this.errorProvider1.SetIconAlignment(this.tabPage1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tabPage1, ((int)(resources.GetObject("tabPage1.IconPadding"))));
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // Txt_Ammount
            // 
            resources.ApplyResources(this.Txt_Ammount, "Txt_Ammount");
            this.errorProvider1.SetError(this.Txt_Ammount, resources.GetString("Txt_Ammount.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_Ammount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_Ammount.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_Ammount, ((int)(resources.GetObject("Txt_Ammount.IconPadding"))));
            this.Txt_Ammount.Name = "Txt_Ammount";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // Txt_Debt
            // 
            resources.ApplyResources(this.Txt_Debt, "Txt_Debt");
            this.errorProvider1.SetError(this.Txt_Debt, resources.GetString("Txt_Debt.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_Debt, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_Debt.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_Debt, ((int)(resources.GetObject("Txt_Debt.IconPadding"))));
            this.Txt_Debt.Name = "Txt_Debt";
            this.Txt_Debt.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.Txt_DealerAmmount);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Txt_DealerDebt);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Cmb_Dealer);
            this.errorProvider1.SetError(this.tabPage2, resources.GetString("tabPage2.Error"));
            this.errorProvider1.SetIconAlignment(this.tabPage2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tabPage2, ((int)(resources.GetObject("tabPage2.IconPadding"))));
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // Txt_DealerAmmount
            // 
            resources.ApplyResources(this.Txt_DealerAmmount, "Txt_DealerAmmount");
            this.errorProvider1.SetError(this.Txt_DealerAmmount, resources.GetString("Txt_DealerAmmount.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_DealerAmmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_DealerAmmount.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_DealerAmmount, ((int)(resources.GetObject("Txt_DealerAmmount.IconPadding"))));
            this.Txt_DealerAmmount.Name = "Txt_DealerAmmount";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // Txt_DealerDebt
            // 
            resources.ApplyResources(this.Txt_DealerDebt, "Txt_DealerDebt");
            this.errorProvider1.SetError(this.Txt_DealerDebt, resources.GetString("Txt_DealerDebt.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_DealerDebt, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_DealerDebt.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_DealerDebt, ((int)(resources.GetObject("Txt_DealerDebt.IconPadding"))));
            this.Txt_DealerDebt.Name = "Txt_DealerDebt";
            this.Txt_DealerDebt.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // Cmb_Dealer
            // 
            resources.ApplyResources(this.Cmb_Dealer, "Cmb_Dealer");
            this.Cmb_Dealer.DataSource = this.dealersBindingSource;
            this.Cmb_Dealer.DisplayMember = "Name";
            this.errorProvider1.SetError(this.Cmb_Dealer, resources.GetString("Cmb_Dealer.Error"));
            this.Cmb_Dealer.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.Cmb_Dealer, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Cmb_Dealer.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Cmb_Dealer, ((int)(resources.GetObject("Cmb_Dealer.IconPadding"))));
            this.Cmb_Dealer.Name = "Cmb_Dealer";
            this.Cmb_Dealer.TextChanged += new System.EventHandler(this.Cmb_Dealer_TextChanged);
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.Txt_SpendingsAmmount);
            this.tabPage3.Controls.Add(this.label7);
            this.errorProvider1.SetError(this.tabPage3, resources.GetString("tabPage3.Error"));
            this.errorProvider1.SetIconAlignment(this.tabPage3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tabPage3, ((int)(resources.GetObject("tabPage3.IconPadding"))));
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.errorProvider1.SetError(this.button3, resources.GetString("button3.Error"));
            this.errorProvider1.SetIconAlignment(this.button3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("button3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.button3, ((int)(resources.GetObject("button3.IconPadding"))));
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Txt_SpendingsAmmount
            // 
            resources.ApplyResources(this.Txt_SpendingsAmmount, "Txt_SpendingsAmmount");
            this.errorProvider1.SetError(this.Txt_SpendingsAmmount, resources.GetString("Txt_SpendingsAmmount.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_SpendingsAmmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_SpendingsAmmount.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_SpendingsAmmount, ((int)(resources.GetObject("Txt_SpendingsAmmount.IconPadding"))));
            this.Txt_SpendingsAmmount.Name = "Txt_SpendingsAmmount";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error"));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            this.paymentsBindingSource.DataSource = this.storeDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // dealerpaymentsBindingSource
            // 
            this.dealerpaymentsBindingSource.DataMember = "dealerpayments";
            this.dealerpaymentsBindingSource.DataSource = this.storeDataSet;
            // 
            // dealerpaymentsTableAdapter
            // 
            this.dealerpaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // spendingsBindingSource
            // 
            this.spendingsBindingSource.DataMember = "spendings";
            this.spendingsBindingSource.DataSource = this.storeDataSet;
            // 
            // spendingsTableAdapter
            // 
            this.spendingsTableAdapter.ClearBeforeFill = true;
            // 
            // vaultBindingSource
            // 
            this.vaultBindingSource.DataSource = this.storeDataSet;
            this.vaultBindingSource.Position = 0;
            // 
            // vaultTableAdapter
            // 
            this.vaultTableAdapter.ClearBeforeFill = true;
            // 
            // agentsBindingSource
            // 
            this.agentsBindingSource.DataMember = "names";
            this.agentsBindingSource.DataSource = this.storeDataSet;
            this.agentsBindingSource.Filter = "TypeAgent = 1";
            // 
            // namesTableAdapter
            // 
            this.namesTableAdapter.ClearBeforeFill = true;
            // 
            // dealersBindingSource
            // 
            this.dealersBindingSource.DataMember = "names";
            this.dealersBindingSource.DataSource = this.storeDataSet;
            this.dealersBindingSource.Filter = "TypeDealer = 1";
            // 
            // Payments
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerpaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private storeDataSet storeDataSet;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Debt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Ammount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private storeDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txt_DealerAmmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_DealerDebt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmb_Dealer;
        private System.Windows.Forms.BindingSource dealerpaymentsBindingSource;
        private storeDataSetTableAdapters.dealerpaymentsTableAdapter dealerpaymentsTableAdapter;
 
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Txt_SpendingsAmmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource spendingsBindingSource;
        private storeDataSetTableAdapters.spendingsTableAdapter spendingsTableAdapter;
        private System.Windows.Forms.BindingSource vaultBindingSource;
        private storeDataSetTableAdapters.vaultTableAdapter vaultTableAdapter;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private storeDataSetTableAdapters.namesTableAdapter namesTableAdapter;
        private System.Windows.Forms.BindingSource dealersBindingSource;
    }
}