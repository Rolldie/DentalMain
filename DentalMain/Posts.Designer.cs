namespace DentalMain
{
    partial class Posts
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
            this.PostGrid = new System.Windows.Forms.DataGridView();
            this.idpostdocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.змінитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDS = new DentalMain.dBDS();
            this.button2 = new System.Windows.Forms.Button();
            this.postTableAdapter = new DentalMain.dBDSTableAdapters.postTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PostGrid)).BeginInit();
            this.GridMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // PostGrid
            // 
            this.PostGrid.AllowUserToAddRows = false;
            this.PostGrid.AllowUserToDeleteRows = false;
            this.PostGrid.AutoGenerateColumns = false;
            this.PostGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PostGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PostGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpostdocDataGridViewTextBoxColumn,
            this.namepostDataGridViewTextBoxColumn});
            this.PostGrid.ContextMenuStrip = this.GridMenu;
            this.PostGrid.DataSource = this.postBindingSource;
            this.PostGrid.Location = new System.Drawing.Point(12, 69);
            this.PostGrid.Name = "PostGrid";
            this.PostGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PostGrid.Size = new System.Drawing.Size(283, 310);
            this.PostGrid.TabIndex = 0;
            this.PostGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PostGrid_CellMouseDown);
            this.PostGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView2_DataError);
            // 
            // idpostdocDataGridViewTextBoxColumn
            // 
            this.idpostdocDataGridViewTextBoxColumn.DataPropertyName = "id_post_doc";
            this.idpostdocDataGridViewTextBoxColumn.HeaderText = "Номер у базі";
            this.idpostdocDataGridViewTextBoxColumn.Name = "idpostdocDataGridViewTextBoxColumn";
            this.idpostdocDataGridViewTextBoxColumn.Width = 71;
            // 
            // namepostDataGridViewTextBoxColumn
            // 
            this.namepostDataGridViewTextBoxColumn.DataPropertyName = "name_post";
            this.namepostDataGridViewTextBoxColumn.HeaderText = "Назва посади";
            this.namepostDataGridViewTextBoxColumn.Name = "namepostDataGridViewTextBoxColumn";
            this.namepostDataGridViewTextBoxColumn.Width = 95;
            // 
            // GridMenu
            // 
            this.GridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.змінитиToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.GridMenu.Name = "GridMenu";
            this.GridMenu.Size = new System.Drawing.Size(127, 48);
            this.GridMenu.Opening += new System.ComponentModel.CancelEventHandler(this.GridMenu_Opening);
            // 
            // змінитиToolStripMenuItem
            // 
            this.змінитиToolStripMenuItem.Name = "змінитиToolStripMenuItem";
            this.змінитиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.змінитиToolStripMenuItem.Text = "Змінити";
            this.змінитиToolStripMenuItem.Click += new System.EventHandler(this.змінитиToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "post";
            this.postBindingSource.DataSource = this.dBDS;
            // 
            // dBDS
            // 
            this.dBDS.DataSetName = "dBDS";
            this.dBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Додати посаду";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Posts
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 391);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PostGrid);
            this.Name = "Posts";
            this.Text = "Посади лікарів";
            this.Load += new System.EventHandler(this.Posts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PostGrid)).EndInit();
            this.GridMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PostGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource postBindingSource;
        private dBDS dBDS;
        private dBDSTableAdapters.postTableAdapter postTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpostdocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepostDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip GridMenu;
        private System.Windows.Forms.ToolStripMenuItem змінитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
    }
}