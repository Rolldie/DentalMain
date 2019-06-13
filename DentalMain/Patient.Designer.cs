namespace DentalMain
{
    partial class Patient
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
            this.PatientGrid = new System.Windows.Forms.DataGridView();
            this.GridContm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDS = new DentalMain.dBDS();
            this.FindTxtBx = new System.Windows.Forms.TextBox();
            this.FieldBx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FltrBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.patientsTableAdapter = new DentalMain.dBDSTableAdapters.patientsTableAdapter();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.відмітитиДляВилученняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idpatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGrid)).BeginInit();
            this.GridContm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientGrid
            // 
            this.PatientGrid.AllowUserToAddRows = false;
            this.PatientGrid.AllowUserToDeleteRows = false;
            this.PatientGrid.AllowUserToOrderColumns = true;
            this.PatientGrid.AllowUserToResizeRows = false;
            this.PatientGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientGrid.AutoGenerateColumns = false;
            this.PatientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpatientDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.delete});
            this.PatientGrid.ContextMenuStrip = this.GridContm;
            this.PatientGrid.DataSource = this.patientsBindingSource;
            this.PatientGrid.Location = new System.Drawing.Point(12, 73);
            this.PatientGrid.MultiSelect = false;
            this.PatientGrid.Name = "PatientGrid";
            this.PatientGrid.RowHeadersVisible = false;
            this.PatientGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientGrid.Size = new System.Drawing.Size(593, 194);
            this.PatientGrid.TabIndex = 0;
            this.PatientGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGrid_CellDoubleClick);
            this.PatientGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatientGrid_CellMouseDown);
            this.PatientGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.PatientGrid_DataError);
            // 
            // GridContm
            // 
            this.GridContm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.відмітитиДляВилученняToolStripMenuItem});
            this.GridContm.Name = "GridContm";
            this.GridContm.Size = new System.Drawing.Size(211, 48);
            this.GridContm.Opening += new System.ComponentModel.CancelEventHandler(this.GridContm_Opening);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.изменитьToolStripMenuItem.Text = "Змінити";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.dBDS;
            // 
            // dBDS
            // 
            this.dBDS.DataSetName = "dBDS";
            this.dBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FindTxtBx
            // 
            this.FindTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTxtBx.Location = new System.Drawing.Point(69, 39);
            this.FindTxtBx.Name = "FindTxtBx";
            this.FindTxtBx.Size = new System.Drawing.Size(357, 20);
            this.FindTxtBx.TabIndex = 1;
            // 
            // FieldBx
            // 
            this.FieldBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldBx.FormattingEnabled = true;
            this.FieldBx.Items.AddRange(new object[] {
            "ПІБ",
            "Дата народження",
            "Номер телефону"});
            this.FieldBx.Location = new System.Drawing.Point(69, 14);
            this.FieldBx.Name = "FieldBx";
            this.FieldBx.Size = new System.Drawing.Size(357, 21);
            this.FieldBx.TabIndex = 2;
            this.FieldBx.SelectedIndexChanged += new System.EventHandler(this.FieldBx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поле";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Знайти:";
            // 
            // FltrBtn
            // 
            this.FltrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FltrBtn.Location = new System.Drawing.Point(432, 12);
            this.FltrBtn.Name = "FltrBtn";
            this.FltrBtn.Size = new System.Drawing.Size(78, 23);
            this.FltrBtn.TabIndex = 4;
            this.FltrBtn.Text = "Фільтр";
            this.FltrBtn.UseVisualStyleBackColor = true;
            this.FltrBtn.Click += new System.EventHandler(this.FltrBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(517, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(88, 50);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Додати пацієнта";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBtn.Location = new System.Drawing.Point(432, 39);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(78, 23);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Text = "Відмінити";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(357, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Visible = false;
            // 
            // відмітитиДляВилученняToolStripMenuItem
            // 
            this.відмітитиДляВилученняToolStripMenuItem.Name = "відмітитиДляВилученняToolStripMenuItem";
            this.відмітитиДляВилученняToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.відмітитиДляВилученняToolStripMenuItem.Text = "Відмітити для вилучення";
            this.відмітитиДляВилученняToolStripMenuItem.Click += new System.EventHandler(this.ВідмітитиДляВилученняToolStripMenuItem_Click);
            // 
            // idpatientDataGridViewTextBoxColumn
            // 
            this.idpatientDataGridViewTextBoxColumn.DataPropertyName = "id_patient";
            this.idpatientDataGridViewTextBoxColumn.FillWeight = 40F;
            this.idpatientDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idpatientDataGridViewTextBoxColumn.Name = "idpatientDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.FillWeight = 70F;
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.FillWeight = 70F;
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Номер телефону";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // delete
            // 
            this.delete.DataPropertyName = "delete";
            this.delete.FillWeight = 30F;
            this.delete.HeaderText = "Потрібно вилучити";
            this.delete.Name = "delete";
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 279);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.FltrBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FieldBx);
            this.Controls.Add(this.FindTxtBx);
            this.Controls.Add(this.PatientGrid);
            this.helpProvider1.SetHelpKeyword(this, "14");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.MinimumSize = new System.Drawing.Size(402, 212);
            this.Name = "Patient";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Пацієнти";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientGrid)).EndInit();
            this.GridContm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientGrid;
        private System.Windows.Forms.TextBox FindTxtBx;
        private System.Windows.Forms.ComboBox FieldBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FltrBtn;
        private System.Windows.Forms.Button AddBtn;
        private dBDS dBDS;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private dBDSTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip GridContm;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem відмітитиДляВилученняToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delete;
    }
}