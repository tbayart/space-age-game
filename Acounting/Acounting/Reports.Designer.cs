﻿namespace Acounting
{
    partial class Reports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasebillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasebillsreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealerpaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.agentsTableAdapter = new Acounting.storeDataSetTableAdapters.agentsTableAdapter();
            this.billsTableAdapter = new Acounting.storeDataSetTableAdapters.billsTableAdapter();
            this.billsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.billsreturnTableAdapter();
            this.paymentsTableAdapter = new Acounting.storeDataSetTableAdapters.paymentsTableAdapter();
            this.dealersTableAdapter = new Acounting.storeDataSetTableAdapters.dealersTableAdapter();
            this.purchasebillsTableAdapter = new Acounting.storeDataSetTableAdapters.purchasebillsTableAdapter();
            this.purchasebillsreturnTableAdapter = new Acounting.storeDataSetTableAdapters.purchasebillsreturnTableAdapter();
            this.dealerpaymentsTableAdapter = new Acounting.storeDataSetTableAdapters.dealerpaymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerpaymentsBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // dealersBindingSource
            // 
            this.dealersBindingSource.DataMember = "dealers";
            this.dealersBindingSource.DataSource = this.storeDataSet;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 520);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(854, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agentsBindingSource, "AgentName", true));
            this.comboBox1.DataSource = this.storeDataSet;
            this.comboBox1.DisplayMember = "agents.AgentName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(725, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "agents.AgentName";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(848, 488);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 494);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.dealersBindingSource;
            reportDataSource6.Name = "DataSet2";
            reportDataSource6.Value = this.purchasebillsBindingSource;
            reportDataSource7.Name = "DataSet3";
            reportDataSource7.Value = this.purchasebillsreturnBindingSource;
            reportDataSource8.Name = "DataSet4";
            reportDataSource8.Value = this.dealerpaymentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Acounting.DealersDebtAr.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(848, 488);
            this.reportViewer1.TabIndex = 0;
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
            // dealersTableAdapter
            // 
            this.dealersTableAdapter.ClearBeforeFill = true;
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
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 520);
            this.Controls.Add(this.tabControl1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasebillsreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerpaymentsBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private storeDataSet storeDataSet;
        private storeDataSetTableAdapters.agentsTableAdapter agentsTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private storeDataSetTableAdapters.billsTableAdapter billsTableAdapter;
        private System.Windows.Forms.BindingSource billsreturnBindingSource;
        private storeDataSetTableAdapters.billsreturnTableAdapter billsreturnTableAdapter;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private storeDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dealersBindingSource;
        private System.Windows.Forms.BindingSource purchasebillsBindingSource;
        private System.Windows.Forms.BindingSource purchasebillsreturnBindingSource;
        private System.Windows.Forms.BindingSource dealerpaymentsBindingSource;
        private storeDataSetTableAdapters.dealersTableAdapter dealersTableAdapter;
        private storeDataSetTableAdapters.purchasebillsTableAdapter purchasebillsTableAdapter;
        private storeDataSetTableAdapters.purchasebillsreturnTableAdapter purchasebillsreturnTableAdapter;
        private storeDataSetTableAdapters.dealerpaymentsTableAdapter dealerpaymentsTableAdapter;
    }
}