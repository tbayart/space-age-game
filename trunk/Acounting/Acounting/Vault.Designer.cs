namespace Acounting
{
    partial class Vault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vault));
            this.Cmd_Add = new System.Windows.Forms.Button();
            this.Txt_AddOpenning = new System.Windows.Forms.TextBox();
            this.vaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new Acounting.storeDataSet();
            this.vaultTableAdapter = new Acounting.storeDataSetTableAdapters.vaultTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.collectedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.paidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.collectedTableAdapter = new Acounting.storeDataSetTableAdapters.collectedTableAdapter();
            this.paidTableAdapter = new Acounting.storeDataSetTableAdapters.paidTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmd_Add
            // 
            resources.ApplyResources(this.Cmd_Add, "Cmd_Add");
            this.errorProvider1.SetError(this.Cmd_Add, resources.GetString("Cmd_Add.Error"));
            this.errorProvider1.SetIconAlignment(this.Cmd_Add, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Cmd_Add.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Cmd_Add, ((int)(resources.GetObject("Cmd_Add.IconPadding"))));
            this.Cmd_Add.Name = "Cmd_Add";
            this.Cmd_Add.UseVisualStyleBackColor = true;
            this.Cmd_Add.Click += new System.EventHandler(this.Cmd_Add_Click);
            // 
            // Txt_AddOpenning
            // 
            resources.ApplyResources(this.Txt_AddOpenning, "Txt_AddOpenning");
            this.errorProvider1.SetError(this.Txt_AddOpenning, resources.GetString("Txt_AddOpenning.Error"));
            this.errorProvider1.SetIconAlignment(this.Txt_AddOpenning, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Txt_AddOpenning.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Txt_AddOpenning, ((int)(resources.GetObject("Txt_AddOpenning.IconPadding"))));
            this.Txt_AddOpenning.Name = "Txt_AddOpenning";
            // 
            // vaultBindingSource
            // 
            this.vaultBindingSource.DataMember = "vault";
            this.vaultBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vaultTableAdapter
            // 
            this.vaultTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vaultBindingSource, "Opennings", true));
            this.errorProvider1.SetError(this.textBox1, resources.GetString("textBox1.Error"));
            this.errorProvider1.SetIconAlignment(this.textBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox1, ((int)(resources.GetObject("textBox1.IconPadding"))));
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.collectedBindingSource, "CollectedTotal", true));
            this.errorProvider1.SetError(this.textBox2, resources.GetString("textBox2.Error"));
            this.errorProvider1.SetIconAlignment(this.textBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox2, ((int)(resources.GetObject("textBox2.IconPadding"))));
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // collectedBindingSource
            // 
            this.collectedBindingSource.DataMember = "collected";
            this.collectedBindingSource.DataSource = this.storeDataSet;
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paidBindingSource, "PaidTotal", true));
            this.errorProvider1.SetError(this.textBox3, resources.GetString("textBox3.Error"));
            this.errorProvider1.SetIconAlignment(this.textBox3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox3, ((int)(resources.GetObject("textBox3.IconPadding"))));
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            // 
            // paidBindingSource
            // 
            this.paidBindingSource.DataMember = "paid";
            this.paidBindingSource.DataSource = this.storeDataSet;
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vaultBindingSource, "In_Hand", true));
            this.errorProvider1.SetError(this.textBox4, resources.GetString("textBox4.Error"));
            this.errorProvider1.SetIconAlignment(this.textBox4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox4, ((int)(resources.GetObject("textBox4.IconPadding"))));
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            // 
            // collectedTableAdapter
            // 
            this.collectedTableAdapter.ClearBeforeFill = true;
            // 
            // paidTableAdapter
            // 
            this.paidTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // Vault
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_AddOpenning);
            this.Controls.Add(this.Cmd_Add);
            this.Name = "Vault";
            this.Load += new System.EventHandler(this.Vault_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cmd_Add;
        private System.Windows.Forms.TextBox Txt_AddOpenning;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource vaultBindingSource;
        private storeDataSetTableAdapters.vaultTableAdapter vaultTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.BindingSource collectedBindingSource;
        private storeDataSetTableAdapters.collectedTableAdapter collectedTableAdapter;
        private System.Windows.Forms.BindingSource paidBindingSource;
        private storeDataSetTableAdapters.paidTableAdapter paidTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}