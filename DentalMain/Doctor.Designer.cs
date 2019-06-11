namespace DentalMain
{
    partial class Doctor
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
            this.FilterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FindText = new System.Windows.Forms.TextBox();
            this.Field = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.doctorGrid = new System.Windows.Forms.DataGridView();
            this.GridContm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDS = new DentalMain.dBDS();
            this.doctorspostdoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secretCmbBx = new System.Windows.Forms.ComboBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new DentalMain.dBDSTableAdapters.doctorsTableAdapter();
            this.post_doctorTableAdapter = new DentalMain.dBDSTableAdapters.post_doctorTableAdapter();
            this.postTableAdapter = new DentalMain.dBDSTableAdapters.postTableAdapter();
            this.iddoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.doctorGrid)).BeginInit();
            this.GridContm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorspostdoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterBtn
            // 
            this.FilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterBtn.Location = new System.Drawing.Point(272, 12);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(75, 21);
            this.FilterBtn.TabIndex = 1;
            this.FilterBtn.Text = "Фільтр";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поле";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Знайти";
            // 
            // FindText
            // 
            this.FindText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindText.Location = new System.Drawing.Point(63, 35);
            this.FindText.Name = "FindText";
            this.FindText.Size = new System.Drawing.Size(203, 20);
            this.FindText.TabIndex = 3;
            // 
            // Field
            // 
            this.Field.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Field.FormattingEnabled = true;
            this.Field.Location = new System.Drawing.Point(63, 12);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(203, 21);
            this.Field.TabIndex = 4;
            this.Field.SelectedIndexChanged += new System.EventHandler(this.Field_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(353, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(78, 43);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Додати лікаря";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Location = new System.Drawing.Point(272, 35);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 20);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Відмінити";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // doctorGrid
            // 
            this.doctorGrid.AllowUserToAddRows = false;
            this.doctorGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorGrid.AutoGenerateColumns = false;
            this.doctorGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddoctorDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn});
            this.doctorGrid.ContextMenuStrip = this.GridContm;
            this.doctorGrid.DataSource = this.doctorsBindingSource;
            this.doctorGrid.Location = new System.Drawing.Point(12, 61);
            this.doctorGrid.MultiSelect = false;
            this.doctorGrid.Name = "doctorGrid";
            this.doctorGrid.RowHeadersVisible = false;
            this.doctorGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doctorGrid.Size = new System.Drawing.Size(419, 377);
            this.doctorGrid.TabIndex = 7;
            this.doctorGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DoctorGrid_CellMouseDoubleClick);
            this.doctorGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DoctorGrid_CellMouseDown);
            this.doctorGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DoctorGrid_DataError);
            // 
            // GridContm
            // 
            this.GridContm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem});
            this.GridContm.Name = "GridContm";
            this.GridContm.Size = new System.Drawing.Size(129, 26);
            this.GridContm.Opening += new System.ComponentModel.CancelEventHandler(this.GridContm_Opening);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.ИзменитьToolStripMenuItem_Click);
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this.dBDS;
            // 
            // dBDS
            // 
            this.dBDS.DataSetName = "dBDS";
            this.dBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // secretCmbBx
            // 
            this.secretCmbBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secretCmbBx.DataSource = this.postBindingSource;
            this.secretCmbBx.DisplayMember = "name_post";
            this.secretCmbBx.FormattingEnabled = true;
            this.secretCmbBx.Location = new System.Drawing.Point(63, 34);
            this.secretCmbBx.Name = "secretCmbBx";
            this.secretCmbBx.Size = new System.Drawing.Size(203, 21);
            this.secretCmbBx.TabIndex = 8;
            this.secretCmbBx.ValueMember = "id_post_doc";
            this.secretCmbBx.Visible = false;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "post";
            this.postBindingSource.DataSource = this.dBDS;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // post_doctorTableAdapter
            // 
            this.post_doctorTableAdapter.ClearBeforeFill = true;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // iddoctorDataGridViewTextBoxColumn
            // 
            this.iddoctorDataGridViewTextBoxColumn.DataPropertyName = "id_doctor";
            this.iddoctorDataGridViewTextBoxColumn.FillWeight = 40F;
            this.iddoctorDataGridViewTextBoxColumn.HeaderText = "Номер у базі";
            this.iddoctorDataGridViewTextBoxColumn.Name = "iddoctorDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "ПІБ доктора";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.secretCmbBx);
            this.Controls.Add(this.doctorGrid);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Field);
            this.Controls.Add(this.FindText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterBtn);
            this.DoubleBuffered = true;
            this.Name = "Doctor";
            this.Text = "Лікарі";
            this.Activated += new System.EventHandler(this.Doctor_Activated);
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorGrid)).EndInit();
            this.GridContm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorspostdoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FindText;
        private System.Windows.Forms.ComboBox Field;
        private System.Windows.Forms.Button AddBtn;
        private dBDS dBDS;
        private dBDSTableAdapters.doctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.DataGridView doctorGrid;
        private System.Windows.Forms.BindingSource doctorspostdoctorBindingSource;
        private dBDSTableAdapters.post_doctorTableAdapter post_doctorTableAdapter;
        private dBDSTableAdapters.postTableAdapter postTableAdapter;
        private System.Windows.Forms.ComboBox secretCmbBx;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.ContextMenuStrip GridContm;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
    }
}