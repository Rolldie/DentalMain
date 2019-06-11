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
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ServSearch
            // 
            this.ServSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ServSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ServSearch.Location = new System.Drawing.Point(12, 34);
            this.ServSearch.Name = "ServSearch";
            this.ServSearch.Size = new System.Drawing.Size(292, 20);
            this.ServSearch.TabIndex = 1;
            this.ServSearch.TextChanged += new System.EventHandler(this.ServSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пошук по послузі";
            // 
            // MatTree
            // 
            this.MatTree.CheckBoxes = true;
            this.MatTree.FullRowSelect = true;
            this.MatTree.HideSelection = false;
            this.MatTree.Location = new System.Drawing.Point(323, 72);
            this.MatTree.Name = "MatTree";
            this.MatTree.Size = new System.Drawing.Size(279, 366);
            this.MatTree.TabIndex = 3;
            this.MatTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.MatTree_AfterCheck);
            // 
            // MatSearch
            // 
            this.MatSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MatSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.MatSearch.Location = new System.Drawing.Point(323, 34);
            this.MatSearch.Name = "MatSearch";
            this.MatSearch.Size = new System.Drawing.Size(279, 20);
            this.MatSearch.TabIndex = 1;
            this.MatSearch.TextChanged += new System.EventHandler(this.MatSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пошук по матеріалу";
            // 
            // BtnAddServ
            // 
            this.BtnAddServ.Location = new System.Drawing.Point(114, 10);
            this.BtnAddServ.Name = "BtnAddServ";
            this.BtnAddServ.Size = new System.Drawing.Size(190, 23);
            this.BtnAddServ.TabIndex = 4;
            this.BtnAddServ.Text = "Додати послуги...";
            this.BtnAddServ.UseVisualStyleBackColor = true;
            this.BtnAddServ.Click += new System.EventHandler(this.BtnAddServ_Click);
            // 
            // BtnAddMat
            // 
            this.BtnAddMat.Location = new System.Drawing.Point(434, 10);
            this.BtnAddMat.Name = "BtnAddMat";
            this.BtnAddMat.Size = new System.Drawing.Size(168, 23);
            this.BtnAddMat.TabIndex = 4;
            this.BtnAddMat.Text = "Додати матеріали...";
            this.BtnAddMat.UseVisualStyleBackColor = true;
            this.BtnAddMat.Click += new System.EventHandler(this.BtnAddMat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оберіть, або введіть послугу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
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
            this.ServTree.DataSource = this.servicesBindingSource;
            this.ServTree.DisplayMember = "name_service";
            this.ServTree.FormattingEnabled = true;
            this.ServTree.Location = new System.Drawing.Point(12, 73);
            this.ServTree.Name = "ServTree";
            this.ServTree.Size = new System.Drawing.Size(292, 368);
            this.ServTree.TabIndex = 5;
            this.ServTree.ValueMember = "id_service";
            this.ServTree.SelectedValueChanged += new System.EventHandler(this.ServTree_SelectedValueChanged);
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.dBDS;
            // 
            // MaterialsAndServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 459);
            this.Controls.Add(this.ServTree);
            this.Controls.Add(this.BtnAddMat);
            this.Controls.Add(this.BtnAddServ);
            this.Controls.Add(this.MatTree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatSearch);
            this.Controls.Add(this.ServSearch);
            this.DoubleBuffered = true;
            this.Name = "MaterialsAndServices";
            this.Text = "Матеріали за послугою";
            this.Load += new System.EventHandler(this.MaterialsAndServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}