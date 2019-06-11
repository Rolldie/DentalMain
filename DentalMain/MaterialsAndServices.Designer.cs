namespace DentalMain
{
    partial class MaterialsAndServices
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
            this.ServSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MatTree = new System.Windows.Forms.TreeView();
            this.MatSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddServ = new System.Windows.Forms.Button();
            this.BtnAddMat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.servicesTableAdapter = new DentalMain.dBDSTableAdapters.servicesTableAdapter();
            this.materialsTableAdapter = new DentalMain.dBDSTableAdapters.materialsTableAdapter();
            this.serv_materialTableAdapter = new DentalMain.dBDSTableAdapters.serv_materialTableAdapter();
            this.dBDS = new DentalMain.dBDS();
            this.ServTree = new System.Windows.Forms.ListBox();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServSearch
            // 
            this.ServSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ServSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tableLayoutPanel1.SetColumnSpan(this.ServSearch, 2);
            this.ServSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServSearch.Location = new System.Drawing.Point(3, 29);
            this.ServSearch.Name = "ServSearch";
            this.ServSearch.Size = new System.Drawing.Size(256, 20);
            this.ServSearch.TabIndex = 1;
            this.ServSearch.TextChanged += new System.EventHandler(this.ServSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пошук по послузі";
            // 
            // MatTree
            // 
            this.MatTree.CheckBoxes = true;
            this.tableLayoutPanel1.SetColumnSpan(this.MatTree, 2);
            this.MatTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatTree.FullRowSelect = true;
            this.MatTree.HideSelection = false;
            this.MatTree.Location = new System.Drawing.Point(265, 75);
            this.MatTree.Name = "MatTree";
            this.MatTree.Size = new System.Drawing.Size(256, 297);
            this.MatTree.TabIndex = 3;
            this.MatTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.MatTree_AfterCheck);
            // 
            // MatSearch
            // 
            this.MatSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MatSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tableLayoutPanel1.SetColumnSpan(this.MatSearch, 2);
            this.MatSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatSearch.Location = new System.Drawing.Point(265, 29);
            this.MatSearch.Name = "MatSearch";
            this.MatSearch.Size = new System.Drawing.Size(256, 20);
            this.MatSearch.TabIndex = 1;
            this.MatSearch.TextChanged += new System.EventHandler(this.MatSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пошук по матеріалу";
            // 
            // BtnAddServ
            // 
            this.BtnAddServ.Location = new System.Drawing.Point(123, 3);
            this.BtnAddServ.Name = "BtnAddServ";
            this.BtnAddServ.Size = new System.Drawing.Size(136, 20);
            this.BtnAddServ.TabIndex = 4;
            this.BtnAddServ.Text = "Додати послуги...";
            this.BtnAddServ.UseVisualStyleBackColor = true;
            this.BtnAddServ.Click += new System.EventHandler(this.BtnAddServ_Click);
            // 
            // BtnAddMat
            // 
            this.BtnAddMat.Location = new System.Drawing.Point(385, 3);
            this.BtnAddMat.Name = "BtnAddMat";
            this.BtnAddMat.Size = new System.Drawing.Size(136, 20);
            this.BtnAddMat.TabIndex = 4;
            this.BtnAddMat.Text = "Додати матеріали...";
            this.BtnAddMat.UseVisualStyleBackColor = true;
            this.BtnAddMat.Click += new System.EventHandler(this.BtnAddMat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оберіть, або введіть послугу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(265, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Матеріали для послуги";
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // serv_materialTableAdapter
            // 
            this.serv_materialTableAdapter.ClearBeforeFill = true;
            // 
            // dBDS
            // 
            this.dBDS.DataSetName = "dBDS";
            this.dBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ServTree
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ServTree, 2);
            this.ServTree.DataSource = this.servicesBindingSource;
            this.ServTree.DisplayMember = "name_service";
            this.ServTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServTree.FormattingEnabled = true;
            this.ServTree.Location = new System.Drawing.Point(3, 75);
            this.ServTree.Name = "ServTree";
            this.ServTree.Size = new System.Drawing.Size(256, 297);
            this.ServTree.TabIndex = 5;
            this.ServTree.ValueMember = "id_service";
            this.ServTree.SelectedValueChanged += new System.EventHandler(this.ServTree_SelectedValueChanged);
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.dBDS;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ServTree, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddServ, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddMat, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ServSearch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MatSearch, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.MatTree, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 375);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // MaterialsAndServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.helpProvider1.SetHelpKeyword(this, "25");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.MinimumSize = new System.Drawing.Size(400, 219);
            this.Name = "MaterialsAndServices";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Матеріали за послугою";
            this.Load += new System.EventHandler(this.MaterialsAndServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ServSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView MatTree;
        private System.Windows.Forms.TextBox MatSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddServ;
        private System.Windows.Forms.Button BtnAddMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private dBDSTableAdapters.servicesTableAdapter servicesTableAdapter;
        private dBDSTableAdapters.materialsTableAdapter materialsTableAdapter;
        private dBDSTableAdapters.serv_materialTableAdapter serv_materialTableAdapter;
        private dBDS dBDS;
        private System.Windows.Forms.ListBox ServTree;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}