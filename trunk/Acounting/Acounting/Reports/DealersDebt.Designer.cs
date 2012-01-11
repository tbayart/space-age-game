namespace Acounting
{
    partial class DealersDebt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DealersDebt));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.namesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.purchasebillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasebillsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealerpaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.purchasebillsTableAdapter = new Acounting.storeDataSetTableAdapters.purchasebillsTableAdapter();
            this.purchasebillsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.purchasebillsreturnTableAdapter();
            this.dealerpaymentsTableAdapter = new Acounting.storeDataSetTableAdapters.dealerpaymentsTableAdapter();
            this.namesTableAdapter = new Acounting.storeDataSetTableAdapters.namesTableAdapter();
            this.billsTableAdapter = new Acounting.storeDataSetTableAdapters.billsTableAdapter();
            this.billsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.billsreturnTableAdapter();
            this.paymentsTableAdapter = new Acounting.storeDataSetTableAdapters.paymentsTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerpaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // namesBindingSource
            // 
            this.namesBindingSource.DataMember = "names";
            this.namesBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasebillsBindingSource
            // 
            this.purchasebillsBindingSource.DataMember = "purchasebills";
            this.purchasebillsBindingSource.DataSource = this.storeDataSet;
            // 
            // purchasebillsreturnBindingSource
            // 
            this.purchasebillsreturnBindingSource.DataMember = "purchasebillsreturn";
            this.purchasebillsreturnBindingSource.DataSource = this.storeDataSet;
            // 
            // dealerpaymentsBindingSource
            // 
            this.dealerpaymentsBindingSource.DataMember = "dealerpayments";
            this.dealerpaymentsBindingSource.DataSource = this.storeDataSet;
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataMember = "bills";
            this.billsBindingSource.DataSource = this.storeDataSet;
            // 
            // billsreturnBindingSource
            // 
            this.billsreturnBindingSource.DataMember = "billsreturn";
            this.billsreturnBindingSource.DataSource = this.storeDataSet;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            this.paymentsBindingSource.DataSource = this.storeDataSet;
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.storeDataSet;
            this.comboBox1.DisplayMember = "names.Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // reportViewer1
            // 
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            reportDataSource1.Name = "Names";
            reportDataSource1.Value = this.namesBindingSource;
            reportDataSource2.Name = "Purchasebills";
            reportDataSource2.Value = this.purchasebillsBindingSource;
            reportDataSource3.Name = "Purchasebillsreturn";
            reportDataSource3.Value = this.purchasebillsreturnBindingSource;
            reportDataSource4.Name = "Dealerpayments";
            reportDataSource4.Value = this.dealerpaymentsBindingSource;
            reportDataSource5.Name = "Bills";
            reportDataSource5.Value = this.billsBindingSource;
            reportDataSource6.Name = "Billsreturn";
            reportDataSource6.Value = this.billsreturnBindingSource;
            reportDataSource7.Name = "Payments";
            reportDataSource7.Value = this.paymentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.EnableHyperlinks = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.LocalReport.ReportPath = "Reports\\DealersDebtAr.rdlc";
            this.reportViewer1.Name = "reportViewer1";
            // 
            // purchasebillsTableAdapter
            // 
            this.purchasebillsTableAdapter.ClearBeforeFill = true;
            // 
            // purchasebillsreturnTableAdapter
            // 
            this.purchasebillsreturnTableAdapter.ClearBeforeFill = true;
            // 
            // dealerpaymentsTableAdapter
            // 
            this.dealerpaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // namesTableAdapter
            // 
            this.namesTableAdapter.ClearBeforeFill = true;
            // 
            // billsTableAdapter
            // 
            this.billsTableAdapter.ClearBeforeFill = true;
            // 
            // billsreturnTableAdapter
            // 
            this.billsreturnTableAdapter.ClearBeforeFill = true;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DealersDebt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DealersDebt";
            this.Load += new System.EventHandler(this.DealersDebt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerpaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private storeDataSet storeDataSet;
 
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource purchasebillsBindingSource;
        private System.Windows.Forms.BindingSource purchasebillsreturnBindingSource;
        private System.Windows.Forms.BindingSource dealerpaymentsBindingSource;
        private storeDataSetTableAdapters.purchasebillsTableAdapter purchasebillsTableAdapter;
        private storeDataSetTableAdapters.purchasebillsreturnTableAdapter purchasebillsreturnTableAdapter;
        private storeDataSetTableAdapters.dealerpaymentsTableAdapter dealerpaymentsTableAdapter;
        private System.Windows.Forms.BindingSource namesBindingSource;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private System.Windows.Forms.BindingSource billsreturnBindingSource;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private storeDataSetTableAdapters.namesTableAdapter namesTableAdapter;
        private storeDataSetTableAdapters.billsTableAdapter billsTableAdapter;
        private storeDataSetTableAdapters.billsreturnTableAdapter billsreturnTableAdapter;
        private storeDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}