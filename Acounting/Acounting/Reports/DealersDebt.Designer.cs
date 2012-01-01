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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dealersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.purchasebillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasebillsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealerpaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
 
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.purchasebillsTableAdapter = new Acounting.storeDataSetTableAdapters.purchasebillsTableAdapter();
            this.purchasebillsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.purchasebillsreturnTableAdapter();
            this.dealerpaymentsTableAdapter = new Acounting.storeDataSetTableAdapters.dealerpaymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dealersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerpaymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dealersBindingSource
            // 
            this.dealersBindingSource.DataMember = "dealers";
            this.dealersBindingSource.DataSource = this.storeDataSet;
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
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.storeDataSet;
            this.comboBox1.DisplayMember = "dealers.DealerName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ValueMember = "dealers.DealerName";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
 
            // 
            // reportViewer1
            // 
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dealersBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.purchasebillsBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.purchasebillsreturnBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.dealerpaymentsBindingSource;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.dealersBindingSource;
            reportDataSource6.Name = "DataSet2";
            reportDataSource6.Value = this.purchasebillsBindingSource;
            reportDataSource7.Name = "DataSet3";
            reportDataSource7.Value = this.purchasebillsreturnBindingSource;
            reportDataSource8.Name = "DataSet4";
            reportDataSource8.Value = this.dealerpaymentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
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
            // DealersDebt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DealersDebt";
            this.Load += new System.EventHandler(this.DealersDebt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dealersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerpaymentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource dealersBindingSource;
 
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource purchasebillsBindingSource;
        private System.Windows.Forms.BindingSource purchasebillsreturnBindingSource;
        private System.Windows.Forms.BindingSource dealerpaymentsBindingSource;
        private storeDataSetTableAdapters.purchasebillsTableAdapter purchasebillsTableAdapter;
        private storeDataSetTableAdapters.purchasebillsreturnTableAdapter purchasebillsreturnTableAdapter;
        private storeDataSetTableAdapters.dealerpaymentsTableAdapter dealerpaymentsTableAdapter;
    }
}