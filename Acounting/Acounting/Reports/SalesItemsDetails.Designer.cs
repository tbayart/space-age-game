namespace Acounting
{
    partial class SalesItemsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesItemsDetails));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SalesDetails_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.salesDetailsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDetailsٌReportTableAdapter = new Acounting.storeDataSetTableAdapters.SalesDetailsٌReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDetails_ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDetailsReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesDetails_ReportBindingSource
            // 
            this.SalesDetails_ReportBindingSource.DataMember = "SalesDetailsٌReport";
            this.SalesDetails_ReportBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SalesDetails_ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.EnableHyperlinks = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.LocalReport.ReportPath = "Reports\\SalesItemsDetailsAr.rdlc";
            this.reportViewer1.Name = "reportViewer1";
            // 
            // salesDetailsReportBindingSource
            // 
            this.salesDetailsReportBindingSource.DataMember = "SalesDetailsٌReport";
            this.salesDetailsReportBindingSource.DataSource = this.storeDataSet;
            // 
            // salesDetailsٌReportTableAdapter
            // 
            this.salesDetailsٌReportTableAdapter.ClearBeforeFill = true;
            // 
            // SalesItemsDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "SalesItemsDetails";
            this.Load += new System.EventHandler(this.SalesItemsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesDetails_ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDetailsReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource salesDetailsReportBindingSource;
        private storeDataSetTableAdapters.SalesDetailsٌReportTableAdapter salesDetailsٌReportTableAdapter;
        private System.Windows.Forms.BindingSource SalesDetails_ReportBindingSource;
    }
}