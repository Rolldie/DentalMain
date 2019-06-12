namespace DentalMain
{
    partial class Materials
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
            this.MatGrid = new System.Windows.Forms.DataGridView();
            this.id_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namematerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridcomb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.змінитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDS = new DentalMain.dBDS();
            this.materialsTableAdapter = new DentalMain.dBDSTableAdapters.materialsTableAdapter();
            this.Name_matTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.DirectoryImageTextBox = new System.Windows.Forms.TextBox();
            this.directorySetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.MatGrid)).BeginInit();
            this.datagridcomb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // MatGrid
            // 
            this.MatGrid.AllowUserToAddRows = false;
            this.MatGrid.AllowUserToDeleteRows = false;
            this.MatGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatGrid.AutoGenerateColumns = false;
            this.MatGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_material,
            this.namematerialDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.MatGrid.ContextMenuStrip = this.datagridcomb;
            this.MatGrid.DataSource = this.materialsBindingSource;
            this.MatGrid.Location = new System.Drawing.Point(12, 133);
            this.MatGrid.MultiSelect = false;
            this.MatGrid.Name = "MatGrid";
            this.MatGrid.RowHeadersVisible = false;
            this.MatGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MatGrid.Size = new System.Drawing.Size(300, 296);
            this.MatGrid.TabIndex = 0;
            this.MatGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MatGrid_CellMouseDown);
            this.MatGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // id_material
            // 
            this.id_material.DataPropertyName = "id_material";
            this.id_material.HeaderText = "id_material";
            this.id_material.Name = "id_material";
            this.id_material.Visible = false;
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
            this.costDataGridViewTextBoxColumn.FillWeight = 30F;
            this.costDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // datagridcomb
            // 
            this.datagridcomb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.змінитиToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.datagridcomb.Name = "datagridcomb";
            this.datagridcomb.Size = new System.Drawing.Size(128, 48);
            this.datagridcomb.Opening += new System.ComponentModel.CancelEventHandler(this.datagridcomb_Opening);
            // 
            // змінитиToolStripMenuItem
            // 
            this.змінитиToolStripMenuItem.Name = "змінитиToolStripMenuItem";
            this.змінитиToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.змінитиToolStripMenuItem.Text = "Змінити";
            this.змінитиToolStripMenuItem.Click += new System.EventHandler(this.змінитиToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.видалитиToolStripMenuItem.Text = "Вилучити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
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
            // Name_matTextBox
            // 
            this.Name_matTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_matTextBox.Location = new System.Drawing.Point(103, 12);
            this.Name_matTextBox.Name = "Name_matTextBox";
            this.Name_matTextBox.Size = new System.Drawing.Size(209, 20);
            this.Name_matTextBox.TabIndex = 1;
            this.Name_matTextBox.TextChanged += new System.EventHandler(this.Name_matTextBox_TextChanged);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CostTextBox.Location = new System.Drawing.Point(103, 39);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(209, 20);
            this.CostTextBox.TabIndex = 2;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // DirectoryImageTextBox
            // 
            this.DirectoryImageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryImageTextBox.Enabled = false;
            this.DirectoryImageTextBox.Location = new System.Drawing.Point(103, 65);
            this.DirectoryImageTextBox.Name = "DirectoryImageTextBox";
            this.DirectoryImageTextBox.Size = new System.Drawing.Size(179, 20);
            this.DirectoryImageTextBox.TabIndex = 2;
            this.DirectoryImageTextBox.TextChanged += new System.EventHandler(this.DirectoryImageTextBox_TextChanged);
            // 
            // directorySetBtn
            // 
            this.directorySetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.directorySetBtn.Location = new System.Drawing.Point(288, 65);
            this.directorySetBtn.Name = "directorySetBtn";
            this.directorySetBtn.Size = new System.Drawing.Size(24, 20);
            this.directorySetBtn.TabIndex = 3;
            this.directorySetBtn.Text = "...";
            this.directorySetBtn.UseVisualStyleBackColor = true;
            this.directorySetBtn.Click += new System.EventHandler(this.DirectorySetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Назва матеріалу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ціна матеріалу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Зображення";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(12, 91);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(300, 36);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Додати матеріал";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.jpg|*.png";
            // 
            // Materials
            // 
            this.AcceptButton = this.AddBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 439);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.directorySetBtn);
            this.Controls.Add(this.DirectoryImageTextBox);
            this.Controls.Add(this.Name_matTextBox);
            this.Controls.Add(this.MatGrid);
            this.helpProvider1.SetHelpKeyword(this, "24");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.MinimumSize = new System.Drawing.Size(342, 274);
            this.Name = "Materials";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Матеріали";
            this.Load += new System.EventHandler(this.MaterialsAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatGrid)).EndInit();
            this.datagridcomb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MatGrid;
        private dBDS dBDS;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private dBDSTableAdapters.materialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.TextBox Name_matTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox DirectoryImageTextBox;
        private System.Windows.Forms.Button directorySetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ContextMenuStrip datagridcomb;
        private System.Windows.Forms.ToolStripMenuItem змінитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn namematerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}