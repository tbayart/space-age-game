namespace Acounting
{
    partial class AgentsDebt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentsDebt));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();

            this.billsTableAdapter = new Acounting.storeDataSetTableAdapters.billsTableAdapter();
            this.billsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.billsreturnTableAdapter();
            this.paymentsTableAdapter = new Acounting.storeDataSetTableAdapters.paymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agentsBindingSource, "AgentName", true));
            this.comboBox1.DataSource = this.storeDataSet;
            this.comboBox1.DisplayMember = "agents.AgentName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ValueMember = "agents.AgentName";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // reportViewer3
            // 
            resources.ApplyResources(this.reportViewer3, "reportViewer3");
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.agentsBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.billsBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.billsreturnBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.paymentsBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer3.LocalReport.EnableExternalImages = true;
            this.reportViewer3.LocalReport.EnableHyperlinks = true;
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer3.LocalReport.ReportPath = "Reports\\AgentsDebtAr.rdlc";
            this.reportViewer3.Name = "reportViewer3";
            // 
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
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
            // AgentsDebt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer3);
            this.Name = "AgentsDebt";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource agentsBindingSource;
        private storeDataSet storeDataSet;

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private storeDataSetTableAdapters.billsTableAdapter billsTableAdapter;
        private System.Windows.Forms.BindingSource billsreturnBindingSource;
        private storeDataSetTableAdapters.billsreturnTableAdapter billsreturnTableAdapter;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private storeDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter;
    }
}