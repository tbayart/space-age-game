namespace Acounting
{
    partial class Names
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Names));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Chk_Dealer = new System.Windows.Forms.CheckBox();
            this.Chk_Agent = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_InialDebt = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Txt_Debt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Adress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Telephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialDebtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAgentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.typeDealerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.namesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.namesTableAdapter = new Acounting.storeDataSetTableAdapters.namesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.debtDataGridViewTextBoxColumn,
            this.initialDebtDataGridViewTextBoxColumn,
            this.initialDateDataGridViewTextBoxColumn,
            this.typeAgentDataGridViewTextBoxColumn,
            this.typeDealerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.namesBindingSource;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.Chk_Dealer);
            this.tabPage2.Controls.Add(this.Chk_Agent);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Txt_InialDebt);
            this.tabPage2.Controls.Add(this.bindingNavigator1);
            this.tabPage2.Controls.Add(this.Txt_Debt);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Txt_Name);
            this.tabPage2.Controls.Add(this.Txt_Adress);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.Txt_ID);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.Txt_Telephone);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Chk_Dealer
            // 
            resources.ApplyResources(this.Chk_Dealer, "Chk_Dealer");
            this.Chk_Dealer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.namesBindingSource, "TypeDealer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Chk_Dealer.Name = "Chk_Dealer";
            this.Chk_Dealer.UseVisualStyleBackColor = true;
            // 
            // Chk_Agent
            // 
            resources.ApplyResources(this.Chk_Agent, "Chk_Agent");
            this.Chk_Agent.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.namesBindingSource, "TypeAgent", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Chk_Agent.Name = "Chk_Agent";
            this.Chk_Agent.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.namesBindingSource, "InitialDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Txt_InialDebt
            // 
            resources.ApplyResources(this.Txt_InialDebt, "Txt_InialDebt");
            this.Txt_InialDebt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.namesBindingSource, "InitialDebt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Txt_InialDebt.Name = "Txt_InialDebt";
            // 
            // bindingNavigator1
            // 
            resources.ApplyResources(this.bindingNavigator1, "bindingNavigator1");
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.namesBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            // 
            // bindingNavigatorDeleteItem
            // 
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            // 
            // bindingNavigatorMoveNextItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            // 
            // Txt_Debt
            // 
            resources.ApplyResources(this.Txt_Debt, "Txt_Debt");
            this.Txt_Debt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.namesBindingSource, "Debt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Txt_Debt.Name = "Txt_Debt";
            this.Txt_Debt.TextChanged += new System.EventHandler(this.Txt_Debt_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Txt_Name
            // 
            resources.ApplyResources(this.Txt_Name, "Txt_Name");
            this.Txt_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.namesBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Txt_Name.Name = "Txt_Name";
            // 
            // Txt_Adress
            // 
            resources.ApplyResources(this.Txt_Adress, "Txt_Adress");
            this.Txt_Adress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.namesBindingSource, "Address", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Txt_Adress.Name = "Txt_Adress";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // Txt_ID
            // 
            resources.ApplyResources(this.Txt_ID, "Txt_ID");
            this.Txt_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.namesBindingSource, "ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // Txt_Telephone
            // 
            resources.ApplyResources(this.Txt_Telephone, "Txt_Telephone");
            this.Txt_Telephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.namesBindingSource, "Telephone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Txt_Telephone.Name = "Txt_Telephone";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            resources.ApplyResources(this.addressDataGridViewTextBoxColumn, "addressDataGridViewTextBoxColumn");
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            resources.ApplyResources(this.telephoneDataGridViewTextBoxColumn, "telephoneDataGridViewTextBoxColumn");
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debtDataGridViewTextBoxColumn
            // 
            this.debtDataGridViewTextBoxColumn.DataPropertyName = "Debt";
            resources.ApplyResources(this.debtDataGridViewTextBoxColumn, "debtDataGridViewTextBoxColumn");
            this.debtDataGridViewTextBoxColumn.Name = "debtDataGridViewTextBoxColumn";
            this.debtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // initialDebtDataGridViewTextBoxColumn
            // 
            this.initialDebtDataGridViewTextBoxColumn.DataPropertyName = "InitialDebt";
            resources.ApplyResources(this.initialDebtDataGridViewTextBoxColumn, "initialDebtDataGridViewTextBoxColumn");
            this.initialDebtDataGridViewTextBoxColumn.Name = "initialDebtDataGridViewTextBoxColumn";
            this.initialDebtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // initialDateDataGridViewTextBoxColumn
            // 
            this.initialDateDataGridViewTextBoxColumn.DataPropertyName = "InitialDate";
            resources.ApplyResources(this.initialDateDataGridViewTextBoxColumn, "initialDateDataGridViewTextBoxColumn");
            this.initialDateDataGridViewTextBoxColumn.Name = "initialDateDataGridViewTextBoxColumn";
            this.initialDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeAgentDataGridViewTextBoxColumn
            // 
            this.typeAgentDataGridViewTextBoxColumn.DataPropertyName = "TypeAgent";
            this.typeAgentDataGridViewTextBoxColumn.FalseValue = "0";
            resources.ApplyResources(this.typeAgentDataGridViewTextBoxColumn, "typeAgentDataGridViewTextBoxColumn");
            this.typeAgentDataGridViewTextBoxColumn.Name = "typeAgentDataGridViewTextBoxColumn";
            this.typeAgentDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeAgentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeAgentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeAgentDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // typeDealerDataGridViewTextBoxColumn
            // 
            this.typeDealerDataGridViewTextBoxColumn.DataPropertyName = "TypeDealer";
            this.typeDealerDataGridViewTextBoxColumn.FalseValue = "0";
            resources.ApplyResources(this.typeDealerDataGridViewTextBoxColumn, "typeDealerDataGridViewTextBoxColumn");
            this.typeDealerDataGridViewTextBoxColumn.Name = "typeDealerDataGridViewTextBoxColumn";
            this.typeDealerDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDealerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDealerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDealerDataGridViewTextBoxColumn.TrueValue = "1";
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
            // namesTableAdapter
            // 
            this.namesTableAdapter.ClearBeforeFill = true;
            // 
            // Names
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Names";
            this.Load += new System.EventHandler(this.Names_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox Chk_Agent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_InialDebt;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox Txt_Debt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Adress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Telephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Chk_Dealer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource namesBindingSource;
        private storeDataSetTableAdapters.namesTableAdapter namesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialDebtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeAgentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeDealerDataGridViewTextBoxColumn;

    }
}