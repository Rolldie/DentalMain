namespace DentalMain
{
    partial class AdmPanelForm
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
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDS = new DentalMain.dBDS();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new DentalMain.dBDSTableAdapters.patientsTableAdapter();
            this.doctorsTableAdapter = new DentalMain.dBDSTableAdapters.doctorsTableAdapter();
            this.diags_patientTableAdapter = new DentalMain.dBDSTableAdapters.diags_patientTableAdapter();
            this.diagnosisTableAdapter = new DentalMain.dBDSTableAdapters.diagnosisTableAdapter();
            this.appointment_servicesTableAdapter = new DentalMain.dBDSTableAdapters.appointment_servicesTableAdapter();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.anamndis_diseasesTableAdapter = new DentalMain.dBDSTableAdapters.anamndis_diseasesTableAdapter();
            this.anamnesisDiseasesTableAdapter = new DentalMain.dBDSTableAdapters.anamnesisDiseasesTableAdapter();
            this.appointmentTableAdapter = new DentalMain.dBDSTableAdapters.appointmentTableAdapter();
            this.diseases_anamTableAdapter = new DentalMain.dBDSTableAdapters.diseases_anamTableAdapter();
            this.materialsTableAdapter = new DentalMain.dBDSTableAdapters.materialsTableAdapter();
            this.possibleComplTableAdapter = new DentalMain.dBDSTableAdapters.possibleComplTableAdapter();
            this.possibleObjectiveTableAdapter = new DentalMain.dBDSTableAdapters.possibleObjectiveTableAdapter();
            this.possiblePltsTableAdapter = new DentalMain.dBDSTableAdapters.possiblePltsTableAdapter();
            this.servicesTableAdapter = new DentalMain.dBDSTableAdapters.servicesTableAdapter();
            this.anamnesisTableAdapter = new DentalMain.dBDSTableAdapters.anamnesisTableAdapter();
            this.appointment_materialsTableAdapter = new DentalMain.dBDSTableAdapters.appointment_materialsTableAdapter();
            this.complaintsTableAdapter = new DentalMain.dBDSTableAdapters.complaintsTableAdapter();
            this.docRecordLogTableAdapter = new DentalMain.dBDSTableAdapters.docRecordLogTableAdapter();
            this.objectively_dataTableAdapter = new DentalMain.dBDSTableAdapters.objectively_dataTableAdapter();
            this.planletsTableAdapter = new DentalMain.dBDSTableAdapters.planletsTableAdapter();
            this.post_doctorTableAdapter = new DentalMain.dBDSTableAdapters.post_doctorTableAdapter();
            this.post_servicesTableAdapter = new DentalMain.dBDSTableAdapters.post_servicesTableAdapter();
            this.postTableAdapter = new DentalMain.dBDSTableAdapters.postTableAdapter();
            this.rengenTableAdapter = new DentalMain.dBDSTableAdapters.rengenTableAdapter();
            this.serv_materialTableAdapter = new DentalMain.dBDSTableAdapters.serv_materialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this.dBDS;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // diags_patientTableAdapter
            // 
            this.diags_patientTableAdapter.ClearBeforeFill = true;
            // 
            // diagnosisTableAdapter
            // 
            this.diagnosisTableAdapter.ClearBeforeFill = true;
            // 
            // appointment_servicesTableAdapter
            // 
            this.appointment_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(659, 397);
            this.treeView1.TabIndex = 1;
            // 
            // anamndis_diseasesTableAdapter
            // 
            this.anamndis_diseasesTableAdapter.ClearBeforeFill = true;
            // 
            // anamnesisDiseasesTableAdapter
            // 
            this.anamnesisDiseasesTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // diseases_anamTableAdapter
            // 
            this.diseases_anamTableAdapter.ClearBeforeFill = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // possibleComplTableAdapter
            // 
            this.possibleComplTableAdapter.ClearBeforeFill = true;
            // 
            // possibleObjectiveTableAdapter
            // 
            this.possibleObjectiveTableAdapter.ClearBeforeFill = true;
            // 
            // possiblePltsTableAdapter
            // 
            this.possiblePltsTableAdapter.ClearBeforeFill = true;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // anamnesisTableAdapter
            // 
            this.anamnesisTableAdapter.ClearBeforeFill = true;
            // 
            // appointment_materialsTableAdapter
            // 
            this.appointment_materialsTableAdapter.ClearBeforeFill = true;
            // 
            // complaintsTableAdapter
            // 
            this.complaintsTableAdapter.ClearBeforeFill = true;
            // 
            // docRecordLogTableAdapter
            // 
            this.docRecordLogTableAdapter.ClearBeforeFill = true;
            // 
            // objectively_dataTableAdapter
            // 
            this.objectively_dataTableAdapter.ClearBeforeFill = true;
            // 
            // planletsTableAdapter
            // 
            this.planletsTableAdapter.ClearBeforeFill = true;
            // 
            // post_doctorTableAdapter
            // 
            this.post_doctorTableAdapter.ClearBeforeFill = true;
            // 
            // post_servicesTableAdapter
            // 
            this.post_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // rengenTableAdapter
            // 
            this.rengenTableAdapter.ClearBeforeFill = true;
            // 
            // serv_materialTableAdapter
            // 
            this.serv_materialTableAdapter.ClearBeforeFill = true;
            // 
            // AdmPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 437);
            this.Controls.Add(this.treeView1);
            this.Name = "AdmPanelForm";
            this.Text = "Адміністрування БД";
            this.Load += new System.EventHandler(this.AdmPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dBDS dBDS;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private dBDSTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private dBDSTableAdapters.doctorsTableAdapter doctorsTableAdapter;
        private dBDSTableAdapters.diags_patientTableAdapter diags_patientTableAdapter;
        private dBDSTableAdapters.diagnosisTableAdapter diagnosisTableAdapter;
        private dBDSTableAdapters.appointment_servicesTableAdapter appointment_servicesTableAdapter;
        private System.Windows.Forms.TreeView treeView1;
        private dBDSTableAdapters.anamndis_diseasesTableAdapter anamndis_diseasesTableAdapter;
        private dBDSTableAdapters.anamnesisDiseasesTableAdapter anamnesisDiseasesTableAdapter;
        private dBDSTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private dBDSTableAdapters.diseases_anamTableAdapter diseases_anamTableAdapter;
        private dBDSTableAdapters.materialsTableAdapter materialsTableAdapter;
        private dBDSTableAdapters.possibleComplTableAdapter possibleComplTableAdapter;
        private dBDSTableAdapters.possibleObjectiveTableAdapter possibleObjectiveTableAdapter;
        private dBDSTableAdapters.possiblePltsTableAdapter possiblePltsTableAdapter;
        private dBDSTableAdapters.servicesTableAdapter servicesTableAdapter;
        private dBDSTableAdapters.anamnesisTableAdapter anamnesisTableAdapter;
        private dBDSTableAdapters.appointment_materialsTableAdapter appointment_materialsTableAdapter;
        private dBDSTableAdapters.complaintsTableAdapter complaintsTableAdapter;
        private dBDSTableAdapters.docRecordLogTableAdapter docRecordLogTableAdapter;
        private dBDSTableAdapters.objectively_dataTableAdapter objectively_dataTableAdapter;
        private dBDSTableAdapters.planletsTableAdapter planletsTableAdapter;
        private dBDSTableAdapters.post_doctorTableAdapter post_doctorTableAdapter;
        private dBDSTableAdapters.post_servicesTableAdapter post_servicesTableAdapter;
        private dBDSTableAdapters.postTableAdapter postTableAdapter;
        private dBDSTableAdapters.rengenTableAdapter rengenTableAdapter;
        private dBDSTableAdapters.serv_materialTableAdapter serv_materialTableAdapter;
    }
}