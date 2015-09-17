namespace PptyMgmtSys
{
    partial class createTenant
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.document = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.bankAccount = new System.Windows.Forms.TextBox();
            this.bsb = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantDocumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantAccountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantBSBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sql689558DataSet = new PptyMgmtSys.sql689558DataSet();
            this.tenantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertymanagementDataSet = new PptyMgmtSys.propertymanagementDataSet();
            this.tenantTableAdapter = new PptyMgmtSys.propertymanagementDataSetTableAdapters.tenantTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tenantTableAdapter1 = new PptyMgmtSys.sql689558DataSetTableAdapters.tenantTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql689558DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertymanagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(184, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of Birth";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(184, 82);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(165, 20);
            this.phone.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Document";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bank Account No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "BSB";
            // 
            // document
            // 
            this.document.Location = new System.Drawing.Point(184, 150);
            this.document.Name = "document";
            this.document.Size = new System.Drawing.Size(165, 20);
            this.document.TabIndex = 10;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(570, 42);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(165, 20);
            this.contact.TabIndex = 11;
            // 
            // bankAccount
            // 
            this.bankAccount.Location = new System.Drawing.Point(570, 79);
            this.bankAccount.Name = "bankAccount";
            this.bankAccount.Size = new System.Drawing.Size(165, 20);
            this.bankAccount.TabIndex = 12;
            // 
            // bsb
            // 
            this.bsb.Location = new System.Drawing.Point(572, 112);
            this.bsb.Name = "bsb";
            this.bsb.Size = new System.Drawing.Size(165, 20);
            this.bsb.TabIndex = 13;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(572, 162);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 14;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(662, 162);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenantIDDataGridViewTextBoxColumn,
            this.tenantNameDataGridViewTextBoxColumn,
            this.tenantPhoneDataGridViewTextBoxColumn,
            this.tenantDOBDataGridViewTextBoxColumn,
            this.tenantDocumentDataGridViewTextBoxColumn,
            this.tenantContactDataGridViewTextBoxColumn,
            this.tenantAccountNoDataGridViewTextBoxColumn,
            this.tenantBSBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tenantBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(40, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(822, 213);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tenantIDDataGridViewTextBoxColumn
            // 
            this.tenantIDDataGridViewTextBoxColumn.DataPropertyName = "TenantID";
            this.tenantIDDataGridViewTextBoxColumn.HeaderText = "TenantID";
            this.tenantIDDataGridViewTextBoxColumn.Name = "tenantIDDataGridViewTextBoxColumn";
            this.tenantIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenantNameDataGridViewTextBoxColumn
            // 
            this.tenantNameDataGridViewTextBoxColumn.DataPropertyName = "TenantName";
            this.tenantNameDataGridViewTextBoxColumn.HeaderText = "TenantName";
            this.tenantNameDataGridViewTextBoxColumn.Name = "tenantNameDataGridViewTextBoxColumn";
            this.tenantNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenantPhoneDataGridViewTextBoxColumn
            // 
            this.tenantPhoneDataGridViewTextBoxColumn.DataPropertyName = "TenantPhone";
            this.tenantPhoneDataGridViewTextBoxColumn.HeaderText = "TenantPhone";
            this.tenantPhoneDataGridViewTextBoxColumn.Name = "tenantPhoneDataGridViewTextBoxColumn";
            this.tenantPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenantDOBDataGridViewTextBoxColumn
            // 
            this.tenantDOBDataGridViewTextBoxColumn.DataPropertyName = "TenantDOB";
            this.tenantDOBDataGridViewTextBoxColumn.HeaderText = "TenantDOB";
            this.tenantDOBDataGridViewTextBoxColumn.Name = "tenantDOBDataGridViewTextBoxColumn";
            this.tenantDOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenantDocumentDataGridViewTextBoxColumn
            // 
            this.tenantDocumentDataGridViewTextBoxColumn.DataPropertyName = "TenantDocument";
            this.tenantDocumentDataGridViewTextBoxColumn.HeaderText = "TenantDocument";
            this.tenantDocumentDataGridViewTextBoxColumn.Name = "tenantDocumentDataGridViewTextBoxColumn";
            this.tenantDocumentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenantContactDataGridViewTextBoxColumn
            // 
            this.tenantContactDataGridViewTextBoxColumn.DataPropertyName = "TenantContact";
            this.tenantContactDataGridViewTextBoxColumn.HeaderText = "TenantContact";
            this.tenantContactDataGridViewTextBoxColumn.Name = "tenantContactDataGridViewTextBoxColumn";
            this.tenantContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenantAccountNoDataGridViewTextBoxColumn
            // 
            this.tenantAccountNoDataGridViewTextBoxColumn.DataPropertyName = "TenantAccountNo";
            this.tenantAccountNoDataGridViewTextBoxColumn.HeaderText = "TenantAccountNo";
            this.tenantAccountNoDataGridViewTextBoxColumn.Name = "tenantAccountNoDataGridViewTextBoxColumn";
            this.tenantAccountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenantBSBDataGridViewTextBoxColumn
            // 
            this.tenantBSBDataGridViewTextBoxColumn.DataPropertyName = "TenantBSB";
            this.tenantBSBDataGridViewTextBoxColumn.HeaderText = "TenantBSB";
            this.tenantBSBDataGridViewTextBoxColumn.Name = "tenantBSBDataGridViewTextBoxColumn";
            this.tenantBSBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenantBindingSource1
            // 
            this.tenantBindingSource1.DataMember = "tenant";
            this.tenantBindingSource1.DataSource = this.sql689558DataSet;
            // 
            // sql689558DataSet
            // 
            this.sql689558DataSet.DataSetName = "sql689558DataSet";
            this.sql689558DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenantBindingSource
            // 
            this.tenantBindingSource.DataMember = "tenant";
            this.tenantBindingSource.DataSource = this.propertymanagementDataSet;
            // 
            // propertymanagementDataSet
            // 
            this.propertymanagementDataSet.DataSetName = "propertymanagementDataSet";
            this.propertymanagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenantTableAdapter
            // 
            this.tenantTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // tenantTableAdapter1
            // 
            this.tenantTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.create);
            this.Controls.Add(this.bsb);
            this.Controls.Add(this.bankAccount);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.document);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "createTenant";
            this.Text = "createTenant";
            this.Load += new System.EventHandler(this.createTenant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql689558DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertymanagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox document;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox bankAccount;
        private System.Windows.Forms.TextBox bsb;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private propertymanagementDataSet propertymanagementDataSet;
        private System.Windows.Forms.BindingSource tenantBindingSource;
        private propertymanagementDataSetTableAdapters.tenantTableAdapter tenantTableAdapter;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private sql689558DataSet sql689558DataSet;
        private System.Windows.Forms.BindingSource tenantBindingSource1;
        private sql689558DataSetTableAdapters.tenantTableAdapter tenantTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantDocumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantAccountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantBSBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}