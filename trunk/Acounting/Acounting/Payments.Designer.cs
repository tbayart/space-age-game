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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.agentsTableAdapter = new Acounting.storeDataSetTableAdapters.agentsTableAdapter();
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
            this.dealersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new Acounting.storeDataSetTableAdapters.paymentsTableAdapter();
            this.dealerpaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealerpaymentsTableAdapter = new Acounting.storeDataSetTableAdapters.dealerpaymentsTableAdapter();
            this.dealersTableAdapter = new Acounting.storeDataSetTableAdapters.dealersTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.Txt_SpendingsAmmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.spendingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spendingsTableAdapter = new Acounting.storeDataSetTableAdapters.spendingsTableAdapter();
            this.vaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaultTableAdapter = new Acounting.storeDataSetTableAdapters.vaultTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealersBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerpaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.agentsBindingSource;
            this.comboBox1.DisplayMember = "AgentName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // agentsBindingSource
            // 
            this.agentsBindingSource.DataMember = "agents";
            this.agentsBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(397, 219);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Txt_Ammount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Txt_Debt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(389, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Collect";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_Ammount
            // 
            this.Txt_Ammount.Location = new System.Drawing.Point(119, 115);
            this.Txt_Ammount.Name = "Txt_Ammount";
            this.Txt_Ammount.Size = new System.Drawing.Size(65, 20);
            this.Txt_Ammount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ammount";
            // 
            // Txt_Debt
            // 
            this.Txt_Debt.Location = new System.Drawing.Point(35, 115);
            this.Txt_Debt.Name = "Txt_Debt";
            this.Txt_Debt.ReadOnly = true;
            this.Txt_Debt.Size = new System.Drawing.Size(62, 20);
            this.Txt_Debt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Debt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agent Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.Txt_DealerAmmount);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Txt_DealerDebt);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Cmb_Dealer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(389, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pay";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Pay";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Txt_DealerAmmount
            // 
            this.Txt_DealerAmmount.Location = new System.Drawing.Point(119, 115);
            this.Txt_DealerAmmount.Name = "Txt_DealerAmmount";
            this.Txt_DealerAmmount.Size = new System.Drawing.Size(65, 20);
            this.Txt_DealerAmmount.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ammount";
            // 
            // Txt_DealerDebt
            // 
            this.Txt_DealerDebt.Location = new System.Drawing.Point(35, 115);
            this.Txt_DealerDebt.Name = "Txt_DealerDebt";
            this.Txt_DealerDebt.ReadOnly = true;
            this.Txt_DealerDebt.Size = new System.Drawing.Size(62, 20);
            this.Txt_DealerDebt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Debt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dealer Name";
            // 
            // Cmb_Dealer
            // 
            this.Cmb_Dealer.DataSource = this.dealersBindingSource;
            this.Cmb_Dealer.DisplayMember = "DealerName";
            this.Cmb_Dealer.FormattingEnabled = true;
            this.Cmb_Dealer.Location = new System.Drawing.Point(35, 52);
            this.Cmb_Dealer.Name = "Cmb_Dealer";
            this.Cmb_Dealer.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Dealer.TabIndex = 7;
            this.Cmb_Dealer.TextChanged += new System.EventHandler(this.Cmb_Dealer_TextChanged);
            // 
            // dealersBindingSource
            // 
            this.dealersBindingSource.DataMember = "dealers";
            this.dealersBindingSource.DataSource = this.storeDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.Txt_SpendingsAmmount);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(389, 193);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Spendings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // dealersTableAdapter
            // 
            this.dealersTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(154, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Pay";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Txt_SpendingsAmmount
            // 
            this.Txt_SpendingsAmmount.Location = new System.Drawing.Point(43, 60);
            this.Txt_SpendingsAmmount.Name = "Txt_SpendingsAmmount";
            this.Txt_SpendingsAmmount.Size = new System.Drawing.Size(65, 20);
            this.Txt_SpendingsAmmount.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ammount";
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
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 219);
            this.Controls.Add(this.tabControl1);
            this.Name = "Payments";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealersBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerpaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private storeDataSetTableAdapters.agentsTableAdapter agentsTableAdapter;
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
        private System.Windows.Forms.BindingSource dealersBindingSource;
        private storeDataSetTableAdapters.dealersTableAdapter dealersTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Txt_SpendingsAmmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource spendingsBindingSource;
        private storeDataSetTableAdapters.spendingsTableAdapter spendingsTableAdapter;
        private System.Windows.Forms.BindingSource vaultBindingSource;
        private storeDataSetTableAdapters.vaultTableAdapter vaultTableAdapter;
    }
}