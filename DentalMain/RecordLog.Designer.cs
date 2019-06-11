namespace DentalMain
{
    partial class RecordLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateCalendar = new System.Windows.Forms.MonthCalendar();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDS = new DentalMain.dBDS();
            this.patient = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date_appointm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day1Grid = new System.Windows.Forms.DataGridView();
            this.patientDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.timeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.started = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Day3Grid = new System.Windows.Forms.DataGridView();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.Day4Grid = new System.Windows.Forms.DataGridView();
            this.patientDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.Doctorl = new System.Windows.Forms.Label();
            this.DoctorBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.doctorsTableAdapter = new DentalMain.dBDSTableAdapters.doctorsTableAdapter();
            this.appointmentTableAdapter = new DentalMain.dBDSTableAdapters.appointmentTableAdapter();
            this.docRecordLogTableAdapter = new DentalMain.dBDSTableAdapters.docRecordLogTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.patientsTableAdapter = new DentalMain.dBDSTableAdapters.patientsTableAdapter();
            this.Day2Grid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day3Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day4Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day2Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // DateCalendar
            // 
            this.DateCalendar.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.DateCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.DateCalendar.Location = new System.Drawing.Point(0, 0);
            this.DateCalendar.MaxSelectionCount = 1;
            this.DateCalendar.Name = "DateCalendar";
            this.DateCalendar.TabIndex = 0;
            this.DateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateCalendar_DateChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "doctorsappointment";
            this.bindingSource1.DataSource = this.doctorsBindingSource;
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
            // patient
            // 
            this.patient.DataPropertyName = "patient";
            this.patient.DataSource = this.patientsBindingSource;
            dataGridViewCellStyle1.NullValue = "--";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patient.DefaultCellStyle = dataGridViewCellStyle1;
            this.patient.DisplayMember = "full_name";
            this.patient.HeaderText = "Пацієнт";
            this.patient.Name = "patient";
            this.patient.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.patient.ValueMember = "id_patient";
            this.patient.Width = 194;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.dBDS;
            // 
            // date_appointm
            // 
            this.date_appointm.DataPropertyName = "date_appointm";
            this.date_appointm.HeaderText = "date_appointm";
            this.date_appointm.Name = "date_appointm";
            this.date_appointm.Visible = false;
            // 
            // Day1Grid
            // 
            this.Day1Grid.AllowUserToAddRows = false;
            this.Day1Grid.AllowUserToDeleteRows = false;
            this.Day1Grid.AllowUserToResizeRows = false;
            this.Day1Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Day1Grid.AutoGenerateColumns = false;
            this.Day1Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Day1Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Day1Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientDataGridViewTextBoxColumn2,
            this.timeDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.started});
            this.Day1Grid.DataSource = this.bindingSource1;
            this.Day1Grid.Location = new System.Drawing.Point(19, 222);
            this.Day1Grid.MultiSelect = false;
            this.Day1Grid.Name = "Day1Grid";
            this.Day1Grid.RowHeadersVisible = false;
            this.Day1Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Day1Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Day1Grid.Size = new System.Drawing.Size(197, 221);
            this.Day1Grid.TabIndex = 1;
            this.Day1Grid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Day1Grid_CellMouseDoubleClick);
            this.Day1Grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Day1Grid_CellValueChanged);
            this.Day1Grid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Day1Grid_DataError);
            this.Day1Grid.SelectionChanged += new System.EventHandler(this.Day1Grid_SelectionChanged);
            // 
            // patientDataGridViewTextBoxColumn2
            // 
            this.patientDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.patientDataGridViewTextBoxColumn2.DataPropertyName = "patient";
            this.patientDataGridViewTextBoxColumn2.DataSource = this.patientsBindingSource;
            this.patientDataGridViewTextBoxColumn2.DisplayMember = "full_name";
            this.patientDataGridViewTextBoxColumn2.Frozen = true;
            this.patientDataGridViewTextBoxColumn2.HeaderText = "Пацієнт";
            this.patientDataGridViewTextBoxColumn2.Name = "patientDataGridViewTextBoxColumn2";
            this.patientDataGridViewTextBoxColumn2.ReadOnly = true;
            this.patientDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patientDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.patientDataGridViewTextBoxColumn2.ValueMember = "id_patient";
            this.patientDataGridViewTextBoxColumn2.Width = 140;
            // 
            // timeDataGridViewTextBoxColumn2
            // 
            this.timeDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.timeDataGridViewTextBoxColumn2.DataPropertyName = "time";
            dataGridViewCellStyle2.Format = "t";
            this.timeDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.timeDataGridViewTextBoxColumn2.FillWeight = 39F;
            this.timeDataGridViewTextBoxColumn2.HeaderText = "Час";
            this.timeDataGridViewTextBoxColumn2.Name = "timeDataGridViewTextBoxColumn2";
            this.timeDataGridViewTextBoxColumn2.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn2.Width = 54;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "date_appointm";
            this.dataGridViewTextBoxColumn1.HeaderText = "date_appointm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // started
            // 
            this.started.DataPropertyName = "started";
            this.started.HeaderText = "started";
            this.started.Name = "started";
            this.started.Visible = false;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "doctorsappointment";
            this.bindingSource2.DataSource = this.doctorsBindingSource;
            // 
            // Day3Grid
            // 
            this.Day3Grid.AllowUserToAddRows = false;
            this.Day3Grid.AllowUserToDeleteRows = false;
            this.Day3Grid.AllowUserToResizeRows = false;
            this.Day3Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Day3Grid.AutoGenerateColumns = false;
            this.Day3Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Day3Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Day3Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn2});
            this.Day3Grid.DataSource = this.bindingSource3;
            this.Day3Grid.Location = new System.Drawing.Point(425, 221);
            this.Day3Grid.MultiSelect = false;
            this.Day3Grid.Name = "Day3Grid";
            this.Day3Grid.RowHeadersVisible = false;
            this.Day3Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Day3Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Day3Grid.Size = new System.Drawing.Size(197, 221);
            this.Day3Grid.TabIndex = 1;
            this.Day3Grid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Day3Grid_CellMouseDoubleClick);
            this.Day3Grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Day3Grid_CellValueChanged);
            this.Day3Grid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Day1Grid_DataError);
            this.Day3Grid.SelectionChanged += new System.EventHandler(this.Day3Grid_SelectionChanged);
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "patient";
            this.patientDataGridViewTextBoxColumn.DataSource = this.patientsBindingSource;
            this.patientDataGridViewTextBoxColumn.DisplayMember = "full_name";
            this.patientDataGridViewTextBoxColumn.HeaderText = "Пацієнт";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            this.patientDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.patientDataGridViewTextBoxColumn.ValueMember = "id_patient";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            dataGridViewCellStyle3.Format = "t";
            this.timeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.timeDataGridViewTextBoxColumn.FillWeight = 39F;
            this.timeDataGridViewTextBoxColumn.HeaderText = "Час";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date_appointm";
            this.dataGridViewTextBoxColumn2.HeaderText = "date_appointm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "started";
            this.dataGridViewCheckBoxColumn2.HeaderText = "started";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Visible = false;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "doctorsappointment";
            this.bindingSource3.DataSource = this.doctorsBindingSource;
            // 
            // Day4Grid
            // 
            this.Day4Grid.AllowUserToAddRows = false;
            this.Day4Grid.AllowUserToDeleteRows = false;
            this.Day4Grid.AllowUserToResizeRows = false;
            this.Day4Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Day4Grid.AutoGenerateColumns = false;
            this.Day4Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Day4Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Day4Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientDataGridViewTextBoxColumn3,
            this.time,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn3});
            this.Day4Grid.DataSource = this.bindingSource4;
            this.Day4Grid.Location = new System.Drawing.Point(628, 221);
            this.Day4Grid.MultiSelect = false;
            this.Day4Grid.Name = "Day4Grid";
            this.Day4Grid.RowHeadersVisible = false;
            this.Day4Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Day4Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Day4Grid.Size = new System.Drawing.Size(197, 221);
            this.Day4Grid.TabIndex = 1;
            this.Day4Grid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Day4Grid_CellMouseDoubleClick);
            this.Day4Grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Day4Grid_CellValueChanged);
            this.Day4Grid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Day1Grid_DataError);
            this.Day4Grid.SelectionChanged += new System.EventHandler(this.Day4Grid_SelectionChanged);
            // 
            // patientDataGridViewTextBoxColumn3
            // 
            this.patientDataGridViewTextBoxColumn3.DataPropertyName = "patient";
            this.patientDataGridViewTextBoxColumn3.DataSource = this.patientsBindingSource;
            this.patientDataGridViewTextBoxColumn3.DisplayMember = "full_name";
            this.patientDataGridViewTextBoxColumn3.HeaderText = "Пацієнт";
            this.patientDataGridViewTextBoxColumn3.Name = "patientDataGridViewTextBoxColumn3";
            this.patientDataGridViewTextBoxColumn3.ReadOnly = true;
            this.patientDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patientDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.patientDataGridViewTextBoxColumn3.ValueMember = "id_patient";
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            dataGridViewCellStyle4.Format = "t";
            this.time.DefaultCellStyle = dataGridViewCellStyle4;
            this.time.FillWeight = 39F;
            this.time.HeaderText = "Час";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date_appointm";
            this.dataGridViewTextBoxColumn3.HeaderText = "date_appointm";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "started";
            this.dataGridViewCheckBoxColumn3.HeaderText = "started";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Visible = false;
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataMember = "doctorsappointment";
            this.bindingSource4.DataSource = this.doctorsBindingSource;
            // 
            // Doctorl
            // 
            this.Doctorl.AutoSize = true;
            this.Doctorl.Location = new System.Drawing.Point(19, 177);
            this.Doctorl.Name = "Doctorl";
            this.Doctorl.Size = new System.Drawing.Size(35, 13);
            this.Doctorl.TabIndex = 2;
            this.Doctorl.Text = "Лікар";
            // 
            // DoctorBox
            // 
            this.DoctorBox.DataSource = this.doctorsBindingSource;
            this.DoctorBox.DisplayMember = "full_name";
            this.DoctorBox.FormattingEnabled = true;
            this.DoctorBox.Location = new System.Drawing.Point(60, 174);
            this.DoctorBox.Name = "DoctorBox";
            this.DoctorBox.Size = new System.Drawing.Size(240, 21);
            this.DoctorBox.TabIndex = 3;
            this.DoctorBox.ValueMember = "id_doctor";
            this.DoctorBox.SelectedValueChanged += new System.EventHandler(this.DoctorBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Понедельник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вторник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Среда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Четверг";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBox1.Location = new System.Drawing.Point(19, 449);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.Text = "10:00";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(103, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBox2.Location = new System.Drawing.Point(222, 449);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBox2.TabIndex = 6;
            this.maskedTextBox2.Text = "10:00";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(306, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBox3.Location = new System.Drawing.Point(425, 448);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBox3.TabIndex = 6;
            this.maskedTextBox3.Text = "10:00";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(509, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 20);
            this.button3.TabIndex = 7;
            this.button3.Text = "добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBox4.Location = new System.Drawing.Point(628, 447);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBox4.TabIndex = 6;
            this.maskedTextBox4.Text = "10:00";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(712, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 20);
            this.button4.TabIndex = 7;
            this.button4.Text = "добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // docRecordLogTableAdapter
            // 
            this.docRecordLogTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(306, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 21);
            this.button5.TabIndex = 8;
            this.button5.Text = "Змінити або створити розклад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // Day2Grid
            // 
            this.Day2Grid.AllowUserToAddRows = false;
            this.Day2Grid.AllowUserToDeleteRows = false;
            this.Day2Grid.AllowUserToResizeRows = false;
            this.Day2Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Day2Grid.AutoGenerateColumns = false;
            this.Day2Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Day2Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Day2Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.Day2Grid.DataSource = this.bindingSource2;
            this.Day2Grid.Location = new System.Drawing.Point(222, 222);
            this.Day2Grid.MultiSelect = false;
            this.Day2Grid.Name = "Day2Grid";
            this.Day2Grid.RowHeadersVisible = false;
            this.Day2Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Day2Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Day2Grid.Size = new System.Drawing.Size(197, 221);
            this.Day2Grid.TabIndex = 9;
            this.Day2Grid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Day2Grid_CellMouseDoubleClick);
            this.Day2Grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Day2Grid_CellValueChanged);
            this.Day2Grid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Day1Grid_DataError);
            this.Day2Grid.SelectionChanged += new System.EventHandler(this.Day2Grid_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "patient";
            this.dataGridViewTextBoxColumn7.DataSource = this.patientsBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "full_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Пацієнт";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "id_patient";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "time";
            dataGridViewCellStyle5.Format = "t";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn8.FillWeight = 39F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Час";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date_appointm";
            this.dataGridViewTextBoxColumn4.HeaderText = "date_appointm";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "started";
            this.dataGridViewCheckBoxColumn1.HeaderText = "started";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(16, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Натисніть двічі лівою кнопкою миши на запис з часом, для того щоб обрати пацієнта" +
    "";
            // 
            // RecordLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 493);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Day2Grid);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorBox);
            this.Controls.Add(this.Doctorl);
            this.Controls.Add(this.Day4Grid);
            this.Controls.Add(this.Day3Grid);
            this.Controls.Add(this.Day1Grid);
            this.Controls.Add(this.DateCalendar);
            this.helpProvider1.SetHelpKeyword(this, "15");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(855, 999);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(518, 395);
            this.Name = "RecordLog";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Журнал запису до лікарів";
            this.Load += new System.EventHandler(this.RecordLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day3Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day4Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day2Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar DateCalendar;
        private System.Windows.Forms.DataGridView Day1Grid;
        private System.Windows.Forms.DataGridView Day3Grid;
        private System.Windows.Forms.DataGridView Day4Grid;
        private System.Windows.Forms.Label Doctorl;
        private System.Windows.Forms.ComboBox DoctorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Button button4;
        private dBDS dBDS;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private dBDSTableAdapters.doctorsTableAdapter doctorsTableAdapter;
        private dBDSTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private dBDSTableAdapters.docRecordLogTableAdapter docRecordLogTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private dBDSTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_appointm;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView Day2Grid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewComboBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn patientDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn patientDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn started;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}