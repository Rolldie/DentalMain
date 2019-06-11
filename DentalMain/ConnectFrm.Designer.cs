namespace DentalMain
{
    partial class ConnectFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.anamnesisTableAdapter = new DentalMain.dBDSTableAdapters.anamnesisTableAdapter();
            this.dBDS = new DentalMain.dBDS();
            this.tableAdapterManager1 = new DentalMain.dBDSTableAdapters.TableAdapterManager();
            this.appointment_materialsTableAdapter1 = new DentalMain.dBDSTableAdapters.appointment_materialsTableAdapter();
            this.appointment_servicesTableAdapter1 = new DentalMain.dBDSTableAdapters.appointment_servicesTableAdapter();
            this.appointmentTableAdapter1 = new DentalMain.dBDSTableAdapters.appointmentTableAdapter();
            this.complaintsTableAdapter1 = new DentalMain.dBDSTableAdapters.complaintsTableAdapter();
            this.diagnosisTableAdapter1 = new DentalMain.dBDSTableAdapters.diagnosisTableAdapter();
            this.diags_patientTableAdapter1 = new DentalMain.dBDSTableAdapters.diags_patientTableAdapter();
            this.diseases_anamTableAdapter1 = new DentalMain.dBDSTableAdapters.diseases_anamTableAdapter();
            this.docRecordLogTableAdapter1 = new DentalMain.dBDSTableAdapters.docRecordLogTableAdapter();
            this.doctorsTableAdapter1 = new DentalMain.dBDSTableAdapters.doctorsTableAdapter();
            this.materialsTableAdapter1 = new DentalMain.dBDSTableAdapters.materialsTableAdapter();
            this.patientsTableAdapter1 = new DentalMain.dBDSTableAdapters.patientsTableAdapter();
            this.planletsTableAdapter1 = new DentalMain.dBDSTableAdapters.planletsTableAdapter();
            this.possibleComplTableAdapter1 = new DentalMain.dBDSTableAdapters.possibleComplTableAdapter();
            this.possiblePltsTableAdapter1 = new DentalMain.dBDSTableAdapters.possiblePltsTableAdapter();
            this.post_doctorTableAdapter1 = new DentalMain.dBDSTableAdapters.post_doctorTableAdapter();
            this.post_servicesTableAdapter1 = new DentalMain.dBDSTableAdapters.post_servicesTableAdapter();
            this.postTableAdapter1 = new DentalMain.dBDSTableAdapters.postTableAdapter();
            this.serv_materialTableAdapter1 = new DentalMain.dBDSTableAdapters.serv_materialTableAdapter();
            this.servicesTableAdapter1 = new DentalMain.dBDSTableAdapters.servicesTableAdapter();
            this.weekendsTableAdapter1 = new DentalMain.dBDSTableAdapters.weekendsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перевірка підключення...";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(15, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(451, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Змінити розміщення бази";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "*.accdb|*.mdb";
            this.openFileDialog1.Title = "Оберіть базу даних";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Перевірка підключення...";
            // 
            // anamnesisTableAdapter
            // 
            this.anamnesisTableAdapter.ClearBeforeFill = true;
            // 
            // dBDS
            // 
            this.dBDS.DataSetName = "dBDS";
            this.dBDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.anamndis_diseasesTableAdapter = null;
            this.tableAdapterManager1.anamnesisDiseasesTableAdapter = null;
            this.tableAdapterManager1.anamnesisTableAdapter = this.anamnesisTableAdapter;
            this.tableAdapterManager1.appointment_materialsTableAdapter = this.appointment_materialsTableAdapter1;
            this.tableAdapterManager1.appointment_servicesTableAdapter = this.appointment_servicesTableAdapter1;
            this.tableAdapterManager1.appointmentTableAdapter = this.appointmentTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = true;
            this.tableAdapterManager1.complaintsTableAdapter = this.complaintsTableAdapter1;
            this.tableAdapterManager1.diagnosisTableAdapter = this.diagnosisTableAdapter1;
            this.tableAdapterManager1.diags_patientTableAdapter = this.diags_patientTableAdapter1;
            this.tableAdapterManager1.diseases_anamTableAdapter = this.diseases_anamTableAdapter1;
            this.tableAdapterManager1.docRecordLogTableAdapter = this.docRecordLogTableAdapter1;
            this.tableAdapterManager1.doctorsTableAdapter = this.doctorsTableAdapter1;
            this.tableAdapterManager1.materialsTableAdapter = this.materialsTableAdapter1;
            this.tableAdapterManager1.patientsTableAdapter = this.patientsTableAdapter1;
            this.tableAdapterManager1.planletsTableAdapter = this.planletsTableAdapter1;
            this.tableAdapterManager1.possibleComplTableAdapter = this.possibleComplTableAdapter1;
            this.tableAdapterManager1.possiblePltsTableAdapter = this.possiblePltsTableAdapter1;
            this.tableAdapterManager1.post_doctorTableAdapter = this.post_doctorTableAdapter1;
            this.tableAdapterManager1.post_servicesTableAdapter = this.post_servicesTableAdapter1;
            this.tableAdapterManager1.postTableAdapter = this.postTableAdapter1;
            this.tableAdapterManager1.serv_materialTableAdapter = this.serv_materialTableAdapter1;
            this.tableAdapterManager1.servicesTableAdapter = this.servicesTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = DentalMain.dBDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.weekendsTableAdapter = this.weekendsTableAdapter1;
            // 
            // appointment_materialsTableAdapter1
            // 
            this.appointment_materialsTableAdapter1.ClearBeforeFill = true;
            // 
            // appointment_servicesTableAdapter1
            // 
            this.appointment_servicesTableAdapter1.ClearBeforeFill = true;
            // 
            // appointmentTableAdapter1
            // 
            this.appointmentTableAdapter1.ClearBeforeFill = true;
            // 
            // complaintsTableAdapter1
            // 
            this.complaintsTableAdapter1.ClearBeforeFill = true;
            // 
            // diagnosisTableAdapter1
            // 
            this.diagnosisTableAdapter1.ClearBeforeFill = true;
            // 
            // diags_patientTableAdapter1
            // 
            this.diags_patientTableAdapter1.ClearBeforeFill = true;
            // 
            // diseases_anamTableAdapter1
            // 
            this.diseases_anamTableAdapter1.ClearBeforeFill = true;
            // 
            // docRecordLogTableAdapter1
            // 
            this.docRecordLogTableAdapter1.ClearBeforeFill = true;
            // 
            // doctorsTableAdapter1
            // 
            this.doctorsTableAdapter1.ClearBeforeFill = true;
            // 
            // materialsTableAdapter1
            // 
            this.materialsTableAdapter1.ClearBeforeFill = true;
            // 
            // patientsTableAdapter1
            // 
            this.patientsTableAdapter1.ClearBeforeFill = true;
            // 
            // planletsTableAdapter1
            // 
            this.planletsTableAdapter1.ClearBeforeFill = true;
            // 
            // possibleComplTableAdapter1
            // 
            this.possibleComplTableAdapter1.ClearBeforeFill = true;
            // 
            // possiblePltsTableAdapter1
            // 
            this.possiblePltsTableAdapter1.ClearBeforeFill = true;
            // 
            // post_doctorTableAdapter1
            // 
            this.post_doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // post_servicesTableAdapter1
            // 
            this.post_servicesTableAdapter1.ClearBeforeFill = true;
            // 
            // postTableAdapter1
            // 
            this.postTableAdapter1.ClearBeforeFill = true;
            // 
            // serv_materialTableAdapter1
            // 
            this.serv_materialTableAdapter1.ClearBeforeFill = true;
            // 
            // servicesTableAdapter1
            // 
            this.servicesTableAdapter1.ClearBeforeFill = true;
            // 
            // weekendsTableAdapter1
            // 
            this.weekendsTableAdapter1.ClearBeforeFill = true;
            // 
            // ConnectFrm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 90);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConnectFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перевірка підключення до бази";
            this.Load += new System.EventHandler(this.ConnectFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dBDSTableAdapters.anamnesisTableAdapter anamnesisTableAdapter;
        private dBDS dBDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private dBDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private dBDSTableAdapters.appointment_materialsTableAdapter appointment_materialsTableAdapter1;
        private dBDSTableAdapters.appointment_servicesTableAdapter appointment_servicesTableAdapter1;
        private dBDSTableAdapters.appointmentTableAdapter appointmentTableAdapter1;
        private dBDSTableAdapters.complaintsTableAdapter complaintsTableAdapter1;
        private dBDSTableAdapters.diagnosisTableAdapter diagnosisTableAdapter1;
        private dBDSTableAdapters.diags_patientTableAdapter diags_patientTableAdapter1;
        private dBDSTableAdapters.diseases_anamTableAdapter diseases_anamTableAdapter1;
        private dBDSTableAdapters.docRecordLogTableAdapter docRecordLogTableAdapter1;
        private dBDSTableAdapters.doctorsTableAdapter doctorsTableAdapter1;
        private dBDSTableAdapters.materialsTableAdapter materialsTableAdapter1;
        private dBDSTableAdapters.patientsTableAdapter patientsTableAdapter1;
        private dBDSTableAdapters.planletsTableAdapter planletsTableAdapter1;
        private dBDSTableAdapters.possibleComplTableAdapter possibleComplTableAdapter1;
        private dBDSTableAdapters.possiblePltsTableAdapter possiblePltsTableAdapter1;
        private dBDSTableAdapters.post_doctorTableAdapter post_doctorTableAdapter1;
        private dBDSTableAdapters.post_servicesTableAdapter post_servicesTableAdapter1;
        private dBDSTableAdapters.postTableAdapter postTableAdapter1;
        private dBDSTableAdapters.serv_materialTableAdapter serv_materialTableAdapter1;
        private dBDSTableAdapters.servicesTableAdapter servicesTableAdapter1;
        private dBDSTableAdapters.weekendsTableAdapter weekendsTableAdapter1;
        private System.Windows.Forms.Label label2;
    }
}