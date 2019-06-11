namespace DentalMain
{
    partial class MaterialsAdd
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDS = new DentalMain.dBDS();
            this.materialsTableAdapter = new DentalMain.dBDSTableAdapters.materialsTableAdapter();
            this.namematerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_matTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.DirectoryImageTextBox = new System.Windows.Forms.TextBox();
            this.directorySetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namematerialDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "materials";
            this.materialsBindingSource.DataSource = this.dBDS;
            // 
            // dBDS
            // 
            this.dBDS.DataSetName = "dBDS";
            this.dBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // namematerialDataGridViewTextBoxColumn
            // 
            this.namematerialDataGridViewTextBoxColumn.DataPropertyName = "name_material";
            this.namematerialDataGridViewTextBoxColumn.HeaderText = "Назва матеріалу";
            this.namematerialDataGridViewTextBoxColumn.Name = "namematerialDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // Name_matTextBox
            // 
            this.Name_matTextBox.Location = new System.Drawing.Point(103, 12);
            this.Name_matTextBox.Name = "Name_matTextBox";
            this.Name_matTextBox.Size = new System.Drawing.Size(290, 20);
            this.Name_matTextBox.TabIndex = 1;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(103, 39);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(290, 20);
            this.CostTextBox.TabIndex = 2;
            // 
            // DirectoryImageTextBox
            // 
            this.DirectoryImageTextBox.Location = new System.Drawing.Point(103, 65);
            this.DirectoryImageTextBox.Name = "DirectoryImageTextBox";
            this.DirectoryImageTextBox.Size = new System.Drawing.Size(260, 20);
            this.DirectoryImageTextBox.TabIndex = 2;
            // 
            // directorySetBtn
            // 
            this.directorySetBtn.Location = new System.Drawing.Point(369, 65);
            this.directorySetBtn.Name = "directorySetBtn";
            this.directorySetBtn.Size = new System.Drawing.Size(24, 20);
            this.directorySetBtn.TabIndex = 3;
            this.directorySetBtn.Text = "...";
            this.directorySetBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Назва послуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ціна послуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Зображення";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 91);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(381, 36);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Додати послугу";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MaterialsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 512);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.directorySetBtn);
            this.Controls.Add(this.DirectoryImageTextBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.Name_matTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MaterialsAdd";
            this.Text = "Матеріали";
            this.Load += new System.EventHandler(this.MaterialsAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dBDS dBDS;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private dBDSTableAdapters.materialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namematerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Name_matTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox DirectoryImageTextBox;
        private System.Windows.Forms.Button directorySetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBtn;
    }
}