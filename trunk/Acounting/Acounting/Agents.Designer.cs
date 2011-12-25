namespace Acounting
{
    partial class Agents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agents));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentsTableAdapter = new Acounting.storeDataSetTableAdapters.agentsTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.Txt_AgentName = new System.Windows.Forms.TextBox();
            this.Txt_Adress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_AgentID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Telephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.agentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialDebtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_InialDebt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentIDDataGridViewTextBoxColumn,
            this.agentNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.debtDataGridViewTextBoxColumn,
            this.initialDebtDataGridViewTextBoxColumn,
            this.initialDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.agentsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(759, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // agentsBindingSource
            // 
            this.agentsBindingSource.DataMember = "agents";
            this.agentsBindingSource.DataSource = this.storeDataSet;
            this.agentsBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.agentsBindingSource_AddingNew);
            this.agentsBindingSource.CurrentChanged += new System.EventHandler(this.agentsBindingSource_CurrentChanged);
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 425);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(765, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agents";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Txt_InialDebt);
            this.tabPage2.Controls.Add(this.bindingNavigator1);
            this.tabPage2.Controls.Add(this.Txt_Debt);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Txt_AgentName);
            this.tabPage2.Controls.Add(this.Txt_Adress);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.Txt_AgentID);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.Txt_Telephone);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(765, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.agentsBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(759, 25);
            this.bindingNavigator1.TabIndex = 45;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Txt_Debt
            // 
            this.Txt_Debt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Debt", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.Txt_Debt.Location = new System.Drawing.Point(24, 271);
            this.Txt_Debt.Name = "Txt_Debt";
            this.Txt_Debt.Size = new System.Drawing.Size(62, 20);
            this.Txt_Debt.TabIndex = 44;
            this.Txt_Debt.TextChanged += new System.EventHandler(this.Txt_Debt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Debt";
            // 
            // Txt_AgentName
            // 
            this.Txt_AgentName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "AgentName", true));
            this.Txt_AgentName.Location = new System.Drawing.Point(24, 122);
            this.Txt_AgentName.Name = "Txt_AgentName";
            this.Txt_AgentName.Size = new System.Drawing.Size(178, 20);
            this.Txt_AgentName.TabIndex = 40;
            // 
            // Txt_Adress
            // 
            this.Txt_Adress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Address", true));
            this.Txt_Adress.Location = new System.Drawing.Point(24, 164);
            this.Txt_Adress.Name = "Txt_Adress";
            this.Txt_Adress.Size = new System.Drawing.Size(178, 20);
            this.Txt_Adress.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Address";
            // 
            // Txt_AgentID
            // 
            this.Txt_AgentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "AgentID", true));
            this.Txt_AgentID.Location = new System.Drawing.Point(24, 69);
            this.Txt_AgentID.Name = "Txt_AgentID";
            this.Txt_AgentID.ReadOnly = true;
            this.Txt_AgentID.Size = new System.Drawing.Size(58, 20);
            this.Txt_AgentID.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "AgentID";
            // 
            // Txt_Telephone
            // 
            this.Txt_Telephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "Telephone", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.Txt_Telephone.Location = new System.Drawing.Point(24, 215);
            this.Txt_Telephone.Name = "Txt_Telephone";
            this.Txt_Telephone.Size = new System.Drawing.Size(178, 20);
            this.Txt_Telephone.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Agent NAme";
            // 
            // agentIDDataGridViewTextBoxColumn
            // 
            this.agentIDDataGridViewTextBoxColumn.DataPropertyName = "AgentID";
            this.agentIDDataGridViewTextBoxColumn.HeaderText = "AgentID";
            this.agentIDDataGridViewTextBoxColumn.Name = "agentIDDataGridViewTextBoxColumn";
            this.agentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agentNameDataGridViewTextBoxColumn
            // 
            this.agentNameDataGridViewTextBoxColumn.DataPropertyName = "AgentName";
            this.agentNameDataGridViewTextBoxColumn.HeaderText = "AgentName";
            this.agentNameDataGridViewTextBoxColumn.Name = "agentNameDataGridViewTextBoxColumn";
            this.agentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debtDataGridViewTextBoxColumn
            // 
            this.debtDataGridViewTextBoxColumn.DataPropertyName = "Debt";
            this.debtDataGridViewTextBoxColumn.HeaderText = "Debt";
            this.debtDataGridViewTextBoxColumn.Name = "debtDataGridViewTextBoxColumn";
            this.debtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // initialDebtDataGridViewTextBoxColumn
            // 
            this.initialDebtDataGridViewTextBoxColumn.DataPropertyName = "InitialDebt";
            this.initialDebtDataGridViewTextBoxColumn.HeaderText = "InitialDebt";
            this.initialDebtDataGridViewTextBoxColumn.Name = "initialDebtDataGridViewTextBoxColumn";
            this.initialDebtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // initialDateDataGridViewTextBoxColumn
            // 
            this.initialDateDataGridViewTextBoxColumn.DataPropertyName = "InitialDate";
            this.initialDateDataGridViewTextBoxColumn.HeaderText = "InitialDate";
            this.initialDateDataGridViewTextBoxColumn.Name = "initialDateDataGridViewTextBoxColumn";
            this.initialDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Txt_InialDebt
            // 
            this.Txt_InialDebt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "InitialDebt", true));
            this.Txt_InialDebt.Enabled = false;
            this.Txt_InialDebt.Location = new System.Drawing.Point(24, 330);
            this.Txt_InialDebt.Name = "Txt_InialDebt";
            this.Txt_InialDebt.Size = new System.Drawing.Size(100, 20);
            this.Txt_InialDebt.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "InitialDebt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Initial Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "mm-dd-yyyy";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentsBindingSource, "InitialDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agentsBindingSource, "InitialDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // Agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 449);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Agents";
            this.Text = "Agents";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Agents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private storeDataSetTableAdapters.agentsTableAdapter agentsTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Txt_Debt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_AgentName;
        private System.Windows.Forms.TextBox Txt_Adress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_AgentID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Telephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialDebtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_InialDebt;
    }
}