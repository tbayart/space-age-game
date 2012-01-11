namespace Acounting
{
    partial class PurchaseItemsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseItemsDetails));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.purchaseItemsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.purchaseItemsDetailsTableAdapter = new Acounting.storeDataSetTableAdapters.PurchaseItemsDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemsDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseItemsDetailsBindingSource
            // 
            this.purchaseItemsDetailsBindingSource.DataMember = "PurchaseItemsDetails";
            this.purchaseItemsDetailsBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.purchaseItemsDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.LocalReport.ReportPath = "Reports\\PurchaseItemsDetailsAR.rdlc";
            this.reportViewer1.Name = "reportViewer1";
            // 
            // purchaseItemsDetailsTableAdapter
            // 
            this.purchaseItemsDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // PurchaseItemsDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "PurchaseItemsDetails";
            this.Load += new System.EventHandler(this.PurchaseItemsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemsDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource purchaseItemsDetailsBindingSource;
        private storeDataSetTableAdapters.PurchaseItemsDetailsTableAdapter purchaseItemsDetailsTableAdapter;
    }
}