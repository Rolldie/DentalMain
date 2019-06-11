namespace DentalMain
{
    partial class Appointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idappointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDS = new DentalMain.dBDS();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateappointmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paided = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.started = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appointmentTableAdapter = new DentalMain.dBDSTableAdapters.appointmentTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentappointmentservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointment_servicesTableAdapter = new DentalMain.dBDSTableAdapters.appointment_servicesTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentservicesappointmentmaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointment_materialsTableAdapter = new DentalMain.dBDSTableAdapters.appointment_materialsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnCancl = new System.Windows.Forms.Button();
            this.doctorsTableAdapter = new DentalMain.dBDSTableAdapters.doctorsTableAdapter();
            this.patientsTableAdapter = new DentalMain.dBDSTableAdapters.patientsTableAdapter();
            this.servicesTableAdapter = new DentalMain.dBDSTableAdapters.servicesTableAdapter();
            this.materialsTableAdapter = new DentalMain.dBDSTableAdapters.materialsTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idappservDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idappmatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentappointmentservicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentservicesappointmentmaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idappointmentDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.recordingdateDataGridViewTextBoxColumn,
            this.dateappointmDataGridViewTextBoxColumn,
            this.fullcostDataGridViewTextBoxColumn,
            this.paided,
            this.cancelDataGridViewCheckBoxColumn,
            this.started});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.DataSource = this.appointmentBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(774, 81);
            this.dataGridView1.TabIndex = 0;
            // 
            // idappointmentDataGridViewTextBoxColumn
            // 
            this.idappointmentDataGridViewTextBoxColumn.DataPropertyName = "id_appointment";
            this.idappointmentDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idappointmentDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idappointmentDataGridViewTextBoxColumn.Name = "idappointmentDataGridViewTextBoxColumn";
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "doctor";
            this.doctorDataGridViewTextBoxColumn.DataSource = this.doctorsBindingSource;
            this.doctorDataGridViewTextBoxColumn.DisplayMember = "full_name";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Доктор";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.doctorDataGridViewTextBoxColumn.ValueMember = "id_doctor";
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
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "patient";
            this.patientDataGridViewTextBoxColumn.DataSource = this.patientsBindingSource;
            this.patientDataGridViewTextBoxColumn.DisplayMember = "full_name";
            this.patientDataGridViewTextBoxColumn.HeaderText = "Пацієнт";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            this.patientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.patientDataGridViewTextBoxColumn.ValueMember = "id_patient";
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.dBDS;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            dataGridViewCellStyle1.Format = "t";
            this.timeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.timeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.timeDataGridViewTextBoxColumn.HeaderText = "Час";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // recordingdateDataGridViewTextBoxColumn
            // 
            this.recordingdateDataGridViewTextBoxColumn.DataPropertyName = "recording_date";
            this.recordingdateDataGridViewTextBoxColumn.HeaderText = "Дата запису";
            this.recordingdateDataGridViewTextBoxColumn.Name = "recordingdateDataGridViewTextBoxColumn";
            // 
            // dateappointmDataGridViewTextBoxColumn
            // 
            this.dateappointmDataGridViewTextBoxColumn.DataPropertyName = "date_appointm";
            this.dateappointmDataGridViewTextBoxColumn.HeaderText = "Дата прийому";
            this.dateappointmDataGridViewTextBoxColumn.Name = "dateappointmDataGridViewTextBoxColumn";
            // 
            // fullcostDataGridViewTextBoxColumn
            // 
            this.fullcostDataGridViewTextBoxColumn.DataPropertyName = "full_cost";
            this.fullcostDataGridViewTextBoxColumn.FillWeight = 40F;
            this.fullcostDataGridViewTextBoxColumn.HeaderText = "Повна ціна";
            this.fullcostDataGridViewTextBoxColumn.Name = "fullcostDataGridViewTextBoxColumn";
            // 
            // paided
            // 
            this.paided.DataPropertyName = "paided";
            this.paided.FillWeight = 40F;
            this.paided.HeaderText = "Оплачено";
            this.paided.Name = "paided";
            // 
            // cancelDataGridViewCheckBoxColumn
            // 
            this.cancelDataGridViewCheckBoxColumn.DataPropertyName = "cancel";
            this.cancelDataGridViewCheckBoxColumn.FillWeight = 50F;
            this.cancelDataGridViewCheckBoxColumn.HeaderText = "Відмінено";
            this.cancelDataGridViewCheckBoxColumn.Name = "cancelDataGridViewCheckBoxColumn";
            // 
            // started
            // 
            this.started.DataPropertyName = "started";
            this.started.HeaderText = "Розпочато";
            this.started.Name = "started";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.dBDS;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Пацієнт",
            "Лікар",
            "Дата прийому",
            "Дата запису"});
            this.comboBox1.Location = new System.Drawing.Point(65, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поле";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пошук";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оберіть прийом";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.dBDS;
            // 
            // appointmentappointmentservicesBindingSource
            // 
            this.appointmentappointmentservicesBindingSource.DataMember = "appointmentappointment_services";
            this.appointmentappointmentservicesBindingSource.DataSource = this.appointmentBindingSource;
            // 
            // appointment_servicesTableAdapter
            // 
            this.appointment_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Надані послуги за прийомом";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "materials";
            this.materialsBindingSource.DataSource = this.dBDS;
            // 
            // appointmentservicesappointmentmaterialsBindingSource
            // 
            this.appointmentservicesappointmentmaterialsBindingSource.DataMember = "appointment_servicesappointment_materials";
            this.appointmentservicesappointmentmaterialsBindingSource.DataSource = this.appointmentappointmentservicesBindingSource;
            // 
            // appointment_materialsTableAdapter
            // 
            this.appointment_materialsTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Надані матеріали за послугою";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(423, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(328, 24);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancl
            // 
            this.BtnCancl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancl.Location = new System.Drawing.Point(423, 42);
            this.BtnCancl.Name = "BtnCancl";
            this.BtnCancl.Size = new System.Drawing.Size(328, 22);
            this.BtnCancl.TabIndex = 7;
            this.BtnCancl.Text = "Відмінити зміни та оновити";
            this.BtnCancl.UseVisualStyleBackColor = true;
            this.BtnCancl.Click += new System.EventHandler(this.BtnCancl_Click);
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DataSource = this.patientsBindingSource;
            this.comboBox2.DisplayMember = "full_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(65, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(274, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "id_patient";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "patients";
            this.bindingSource1.DataSource = this.dBDS;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "doctors";
            this.bindingSource2.DataSource = this.dBDS;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 161);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idappservDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn1,
            this.serviceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.appointmentappointmentservicesBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 105);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(384, 53);
            this.dataGridView2.TabIndex = 4;
            // 
            // idappservDataGridViewTextBoxColumn
            // 
            this.idappservDataGridViewTextBoxColumn.DataPropertyName = "id_app_serv";
            this.idappservDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idappservDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idappservDataGridViewTextBoxColumn.Name = "idappservDataGridViewTextBoxColumn";
            // 
            // doctorDataGridViewTextBoxColumn1
            // 
            this.doctorDataGridViewTextBoxColumn1.DataPropertyName = "doctor";
            this.doctorDataGridViewTextBoxColumn1.DataSource = this.doctorsBindingSource;
            this.doctorDataGridViewTextBoxColumn1.DisplayMember = "full_name";
            this.doctorDataGridViewTextBoxColumn1.HeaderText = "Доктор";
            this.doctorDataGridViewTextBoxColumn1.Name = "doctorDataGridViewTextBoxColumn1";
            this.doctorDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.doctorDataGridViewTextBoxColumn1.ValueMember = "id_doctor";
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "service";
            this.serviceDataGridViewTextBoxColumn.DataSource = this.servicesBindingSource;
            this.serviceDataGridViewTextBoxColumn.DisplayMember = "name_service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Послуга";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.serviceDataGridViewTextBoxColumn.ValueMember = "id_service";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idappmatDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.appointmentservicesappointmentmaterialsBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(393, 105);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(384, 53);
            this.dataGridView3.TabIndex = 5;
            // 
            // idappmatDataGridViewTextBoxColumn
            // 
            this.idappmatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idappmatDataGridViewTextBoxColumn.DataPropertyName = "id_app_mat";
            this.idappmatDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idappmatDataGridViewTextBoxColumn.Frozen = true;
            this.idappmatDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idappmatDataGridViewTextBoxColumn.Name = "idappmatDataGridViewTextBoxColumn";
            this.idappmatDataGridViewTextBoxColumn.Width = 70;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "material";
            this.materialDataGridViewTextBoxColumn.DataSource = this.materialsBindingSource;
            this.materialDataGridViewTextBoxColumn.DisplayMember = "name_material";
            this.materialDataGridViewTextBoxColumn.Frozen = true;
            this.materialDataGridViewTextBoxColumn.HeaderText = "Матеріал";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materialDataGridViewTextBoxColumn.ValueMember = "id_material";
            this.materialDataGridViewTextBoxColumn.Width = 141;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 141;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(345, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "Відмінити пошук";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.BtnCancl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.MinimumSize = new System.Drawing.Size(820, 308);
            this.Name = "Appointments";
            this.Text = "Прийоми";
            this.Activated += new System.EventHandler(this.Appointments_Activated);
            this.Load += new System.EventHandler(this.Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentappointmentservicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentservicesappointmentmaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private dBDS dBDS;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private dBDSTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource appointmentappointmentservicesBindingSource;
        private dBDSTableAdapters.appointment_servicesTableAdapter appointment_servicesTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource appointmentservicesappointmentmaterialsBindingSource;
        private dBDSTableAdapters.appointment_materialsTableAdapter appointment_materialsTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnCancl;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private dBDSTableAdapters.doctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private dBDSTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private dBDSTableAdapters.servicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private dBDSTableAdapters.materialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idappointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateappointmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paided;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cancelDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn started;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idappservDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn doctorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idappmatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}