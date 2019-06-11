namespace DentalMain
{
    partial class SmallDataChanger
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
            this.anamndis_diseasesTableAdapter = new DentalMain.dBDSTableAdapters.anamndis_diseasesTableAdapter();
            this.diagnosisTableAdapter = new DentalMain.dBDSTableAdapters.diagnosisTableAdapter();
            this.planletsTableAdapter = new DentalMain.dBDSTableAdapters.planletsTableAdapter();
            this.possibleComplTableAdapter = new DentalMain.dBDSTableAdapters.possibleComplTableAdapter();
            this.dBDS = new DentalMain.dBDS();
            this.diseases_anamTableAdapter = new DentalMain.dBDSTableAdapters.diseases_anamTableAdapter();
            this.possiblePltsTableAdapter = new DentalMain.dBDSTableAdapters.possiblePltsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // anamndis_diseasesTableAdapter
            // 
            this.anamndis_diseasesTableAdapter.ClearBeforeFill = true;
            // 
            // diagnosisTableAdapter
            // 
            this.diagnosisTableAdapter.ClearBeforeFill = true;
            // 
            // planletsTableAdapter
            // 
            this.planletsTableAdapter.ClearBeforeFill = true;
            // 
            // possibleComplTableAdapter
            // 
            this.possibleComplTableAdapter.ClearBeforeFill = true;
            // 
            // dBDS
            // 
            this.dBDS.DataSetName = "dBDS";
            this.dBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diseases_anamTableAdapter
            // 
            this.diseases_anamTableAdapter.ClearBeforeFill = true;
            // 
            // possiblePltsTableAdapter
            // 
            this.possiblePltsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поле";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 55);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(335, 30);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Зберегти";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(12, 89);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(335, 30);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Відмінити";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // SmallDataChanger
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(356, 131);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "SmallDataChanger";
            this.Text = "Зміна даних";
            this.Load += new System.EventHandler(this.SmallDataChanger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dBDSTableAdapters.anamndis_diseasesTableAdapter anamndis_diseasesTableAdapter;
        private dBDSTableAdapters.diagnosisTableAdapter diagnosisTableAdapter;
        private dBDSTableAdapters.planletsTableAdapter planletsTableAdapter;
        private dBDSTableAdapters.possibleComplTableAdapter possibleComplTableAdapter;
        private dBDS dBDS;
        private dBDSTableAdapters.diseases_anamTableAdapter diseases_anamTableAdapter;
        private dBDSTableAdapters.possiblePltsTableAdapter possiblePltsTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}