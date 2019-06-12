namespace DentalMain
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пацієнтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналЗаписуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посадиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиПосадуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняПослугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.послугиЗаПосадоюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матеріалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиМатеріалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матеріалиЗаПослугоюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.лікаріToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прийомиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ChangeView = new System.Windows.Forms.ToolStripButton();
            this.UpdButton = new System.Windows.Forms.ToolStripButton();
            this.closeWind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ChekDataView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPat = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolNumtel = new System.Windows.Forms.ToolStripLabel();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.PatientInfo = new System.Windows.Forms.TabPage();
            this.PatAppointm = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddPaided = new System.Windows.Forms.Button();
            this.labelDolg = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.BtnAppointm = new System.Windows.Forms.Button();
            this.RengBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TodayRad = new System.Windows.Forms.RadioButton();
            this.AllRad = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDS = new DentalMain.dBDS();
            this.BtnGetPat = new System.Windows.Forms.Button();
            this.LblPatient = new System.Windows.Forms.Label();
            this.Complaints = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.treeViewcompl = new System.Windows.Forms.TreeView();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnAddComplaint = new System.Windows.Forms.Button();
            this.ComplText = new System.Windows.Forms.TextBox();
            this.dataGridComplaints = new System.Windows.Forms.DataGridView();
            this.complaintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.datecomplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientscomplaintsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.Anamnesis = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.typeOfAnamn = new System.Windows.Forms.ComboBox();
            this.treeViewAnamn = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.AnamnSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddAnm = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.namediseaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.diseasesanamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeanamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsanamnesisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planletstab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.PlnLtsTree = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toothDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.possiblePltsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateplnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsplanletsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.PlnLtsDateTime = new System.Windows.Forms.DateTimePicker();
            this.BtnAddPlnLts = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.PlnLtsSearch = new System.Windows.Forms.TextBox();
            this.PlnLtsTooth = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.AnamnDispg = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label29 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.diseaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.anamndisdiseasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateanamndisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsanamnesisDiseasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeViewanamndis = new System.Windows.Forms.TreeView();
            this.label28 = new System.Windows.Forms.Label();
            this.BtnAddAnmdis = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.AnmndisSearch = new System.Windows.Forms.TextBox();
            this.Diagnosis = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_diag_patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsdiagspatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeViewDiag = new System.Windows.Forms.TreeView();
            this.BtnAddDiag = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.teethTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.appointment = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.PaidGB = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label31 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnPayByAvnc = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AppointBox = new System.Windows.Forms.ComboBox();
            this.patientsappointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HealingTreeDiag = new System.Windows.Forms.TreeView();
            this.includesChkBx = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MatTree = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ServSearch = new System.Windows.Forms.TextBox();
            this.ServTree = new System.Windows.Forms.TreeView();
            this.label14 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.змінитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentappointmentservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.patientsTableAdapter = new DentalMain.dBDSTableAdapters.patientsTableAdapter();
            this.complaintsTableAdapter = new DentalMain.dBDSTableAdapters.complaintsTableAdapter();
            this.diags_patientTableAdapter = new DentalMain.dBDSTableAdapters.diags_patientTableAdapter();
            this.planletsTableAdapter = new DentalMain.dBDSTableAdapters.planletsTableAdapter();
            this.anamnesisTableAdapter = new DentalMain.dBDSTableAdapters.anamnesisTableAdapter();
            this.appointmentTableAdapter = new DentalMain.dBDSTableAdapters.appointmentTableAdapter();
            this.appointment_servicesTableAdapter = new DentalMain.dBDSTableAdapters.appointment_servicesTableAdapter();
            this.doctorsTableAdapter = new DentalMain.dBDSTableAdapters.doctorsTableAdapter();
            this.possibleComplTableAdapter = new DentalMain.dBDSTableAdapters.possibleComplTableAdapter();
            this.possiblePltsTableAdapter = new DentalMain.dBDSTableAdapters.possiblePltsTableAdapter();
            this.diseases_anamTableAdapter = new DentalMain.dBDSTableAdapters.diseases_anamTableAdapter();
            this.servicesTableAdapter = new DentalMain.dBDSTableAdapters.servicesTableAdapter();
            this.post_servicesTableAdapter = new DentalMain.dBDSTableAdapters.post_servicesTableAdapter();
            this.serv_materialTableAdapter = new DentalMain.dBDSTableAdapters.serv_materialTableAdapter();
            this.post_doctorTableAdapter = new DentalMain.dBDSTableAdapters.post_doctorTableAdapter();
            this.postTableAdapter = new DentalMain.dBDSTableAdapters.postTableAdapter();
            this.materialsTableAdapter = new DentalMain.dBDSTableAdapters.materialsTableAdapter();
            this.appointment_materialsTableAdapter = new DentalMain.dBDSTableAdapters.appointment_materialsTableAdapter();
            this.anamnesisDiseasesTableAdapter = new DentalMain.dBDSTableAdapters.anamnesisDiseasesTableAdapter();
            this.anamndis_diseasesTableAdapter = new DentalMain.dBDSTableAdapters.anamndis_diseasesTableAdapter();
            this.diagnosisTableAdapter = new DentalMain.dBDSTableAdapters.diagnosisTableAdapter();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.PatientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            this.Complaints.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComplaints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientscomplaintsBindingSource)).BeginInit();
            this.Anamnesis.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseasesanamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsanamnesisBindingSource)).BeginInit();
            this.planletstab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.possiblePltsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsplanletsBindingSource)).BeginInit();
            this.AnamnDispg.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anamndisdiseasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsanamnesisDiseasesBindingSource)).BeginInit();
            this.Diagnosis.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsdiagspatientBindingSource)).BeginInit();
            this.appointment.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.PaidGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsappointmentBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentappointmentservicesBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.helpProvider1.SetHelpKeyword(this.menuStrip1, "6");
            this.helpProvider1.SetHelpNavigator(this.menuStrip1, System.Windows.Forms.HelpNavigator.TopicId);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пацієнтиToolStripMenuItem,
            this.журналЗаписуToolStripMenuItem,
            this.посадиToolStripMenuItem,
            this.матеріалиToolStripMenuItem,
            this.лікаріToolStripMenuItem,
            this.прийомиToolStripMenuItem,
            this.налаштуванняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.helpProvider1.SetShowHelp(this.menuStrip1, true);
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пацієнтиToolStripMenuItem
            // 
            this.пацієнтиToolStripMenuItem.Name = "пацієнтиToolStripMenuItem";
            this.пацієнтиToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.пацієнтиToolStripMenuItem.Text = "Пацієнти";
            this.пацієнтиToolStripMenuItem.Click += new System.EventHandler(this.пацієнтиToolStripMenuItem_Click);
            // 
            // журналЗаписуToolStripMenuItem
            // 
            this.журналЗаписуToolStripMenuItem.Name = "журналЗаписуToolStripMenuItem";
            this.журналЗаписуToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.журналЗаписуToolStripMenuItem.Text = "Журнал запису";
            this.журналЗаписуToolStripMenuItem.Click += new System.EventHandler(this.журналЗаписуToolStripMenuItem_Click);
            // 
            // посадиToolStripMenuItem
            // 
            this.посадиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиПосадуToolStripMenuItem,
            this.редагуванняПослугToolStripMenuItem,
            this.послугиЗаПосадоюToolStripMenuItem});
            this.посадиToolStripMenuItem.Name = "посадиToolStripMenuItem";
            this.посадиToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.посадиToolStripMenuItem.Text = "Посади та послуги";
            // 
            // додатиПосадуToolStripMenuItem
            // 
            this.додатиПосадуToolStripMenuItem.Name = "додатиПосадуToolStripMenuItem";
            this.додатиПосадуToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.додатиПосадуToolStripMenuItem.Text = "Редагування посад";
            this.додатиПосадуToolStripMenuItem.Click += new System.EventHandler(this.ДодатиПосадуToolStripMenuItem_Click);
            // 
            // редагуванняПослугToolStripMenuItem
            // 
            this.редагуванняПослугToolStripMenuItem.Name = "редагуванняПослугToolStripMenuItem";
            this.редагуванняПослугToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.редагуванняПослугToolStripMenuItem.Text = "Редагування послуг";
            this.редагуванняПослугToolStripMenuItem.Click += new System.EventHandler(this.редагуванняПослугToolStripMenuItem_Click);
            // 
            // послугиЗаПосадоюToolStripMenuItem
            // 
            this.послугиЗаПосадоюToolStripMenuItem.Name = "послугиЗаПосадоюToolStripMenuItem";
            this.послугиЗаПосадоюToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.послугиЗаПосадоюToolStripMenuItem.Text = "Послуги за посадою";
            this.послугиЗаПосадоюToolStripMenuItem.Click += new System.EventHandler(this.ПослугиЗаПосадоюToolStripMenuItem_Click);
            // 
            // матеріалиToolStripMenuItem
            // 
            this.матеріалиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиМатеріалиToolStripMenuItem,
            this.матеріалиЗаПослугоюToolStripMenuItem1});
            this.матеріалиToolStripMenuItem.Name = "матеріалиToolStripMenuItem";
            this.матеріалиToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.матеріалиToolStripMenuItem.Text = "Матеріали";
            // 
            // додатиМатеріалиToolStripMenuItem
            // 
            this.додатиМатеріалиToolStripMenuItem.Name = "додатиМатеріалиToolStripMenuItem";
            this.додатиМатеріалиToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.додатиМатеріалиToolStripMenuItem.Text = "Редагування матеріалів";
            this.додатиМатеріалиToolStripMenuItem.Click += new System.EventHandler(this.ДодатиМатеріалиToolStripMenuItem_Click);
            // 
            // матеріалиЗаПослугоюToolStripMenuItem1
            // 
            this.матеріалиЗаПослугоюToolStripMenuItem1.Name = "матеріалиЗаПослугоюToolStripMenuItem1";
            this.матеріалиЗаПослугоюToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.матеріалиЗаПослугоюToolStripMenuItem1.Text = "Матеріали за послугою";
            this.матеріалиЗаПослугоюToolStripMenuItem1.Click += new System.EventHandler(this.МатеріалиЗаПослугоюToolStripMenuItem1_Click);
            // 
            // лікаріToolStripMenuItem
            // 
            this.лікаріToolStripMenuItem.Name = "лікаріToolStripMenuItem";
            this.лікаріToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.лікаріToolStripMenuItem.Text = "Лікарі";
            this.лікаріToolStripMenuItem.Click += new System.EventHandler(this.лікаріToolStripMenuItem_Click);
            // 
            // прийомиToolStripMenuItem
            // 
            this.прийомиToolStripMenuItem.Name = "прийомиToolStripMenuItem";
            this.прийомиToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.прийомиToolStripMenuItem.Text = "Прийоми";
            this.прийомиToolStripMenuItem.Click += new System.EventHandler(this.прийомиToolStripMenuItem_Click);
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            this.налаштуванняToolStripMenuItem.Click += new System.EventHandler(this.налаштуванняToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeView,
            this.UpdButton,
            this.closeWind,
            this.toolStripSeparator1,
            this.ChekDataView,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripPat,
            this.toolStripSeparator3,
            this.toolNumtel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(710, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ChangeView
            // 
            this.ChangeView.Checked = true;
            this.ChangeView.CheckOnClick = true;
            this.ChangeView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChangeView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChangeView.Image = ((System.Drawing.Image)(resources.GetObject("ChangeView.Image")));
            this.ChangeView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeView.Name = "ChangeView";
            this.ChangeView.Size = new System.Drawing.Size(23, 22);
            this.ChangeView.Text = "Відобразити/скрити вкладки";
            this.ChangeView.CheckedChanged += new System.EventHandler(this.ChangeView_CheckedChanged);
            this.ChangeView.CheckStateChanged += new System.EventHandler(this.ChangeView_CheckStateChanged);
            // 
            // UpdButton
            // 
            this.UpdButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpdButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdButton.Image")));
            this.UpdButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(23, 22);
            this.UpdButton.Text = "Оновити дані на вкладках";
            this.UpdButton.Click += new System.EventHandler(this.UpdBtn_Click);
            // 
            // closeWind
            // 
            this.closeWind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeWind.Image = ((System.Drawing.Image)(resources.GetObject("closeWind.Image")));
            this.closeWind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeWind.Name = "closeWind";
            this.closeWind.Size = new System.Drawing.Size(23, 22);
            this.closeWind.Text = "Закрити всі вікна";
            this.closeWind.Click += new System.EventHandler(this.CloseWind_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ChekDataView
            // 
            this.ChekDataView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChekDataView.CheckOnClick = true;
            this.ChekDataView.Enabled = false;
            this.ChekDataView.Image = ((System.Drawing.Image)(resources.GetObject("ChekDataView.Image")));
            this.ChekDataView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChekDataView.Name = "ChekDataView";
            this.ChekDataView.Size = new System.Drawing.Size(133, 22);
            this.ChekDataView.Text = "Тільки ващі записи";
            this.ChekDataView.ToolTipText = "Только ваши записи";
            this.ChekDataView.CheckedChanged += new System.EventHandler(this.ChekDataView_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Пацієнт:";
            // 
            // toolStripPat
            // 
            this.toolStripPat.Name = "toolStripPat";
            this.toolStripPat.Size = new System.Drawing.Size(43, 22);
            this.toolStripPat.Text = "Немаэ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolNumtel
            // 
            this.toolNumtel.Name = "toolNumtel";
            this.toolNumtel.Size = new System.Drawing.Size(43, 22);
            this.toolNumtel.Text = "Немаэ";
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.PatientInfo);
            this.MainTab.Controls.Add(this.Complaints);
            this.MainTab.Controls.Add(this.Anamnesis);
            this.MainTab.Controls.Add(this.planletstab);
            this.MainTab.Controls.Add(this.AnamnDispg);
            this.MainTab.Controls.Add(this.Diagnosis);
            this.MainTab.Controls.Add(this.appointment);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Enabled = false;
            this.helpProvider1.SetHelpKeyword(this.MainTab, "5");
            this.helpProvider1.SetHelpNavigator(this.MainTab, System.Windows.Forms.HelpNavigator.TopicId);
            this.MainTab.Location = new System.Drawing.Point(0, 49);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.helpProvider1.SetShowHelp(this.MainTab, true);
            this.MainTab.Size = new System.Drawing.Size(710, 409);
            this.MainTab.TabIndex = 2;
            this.MainTab.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.MainTab_Selecting);
            this.MainTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.MainTab_Selected);
            // 
            // PatientInfo
            // 
            this.PatientInfo.Controls.Add(this.PatAppointm);
            this.PatientInfo.Controls.Add(this.textBox2);
            this.PatientInfo.Controls.Add(this.AddPaided);
            this.PatientInfo.Controls.Add(this.labelDolg);
            this.PatientInfo.Controls.Add(this.label30);
            this.PatientInfo.Controls.Add(this.BtnAppointm);
            this.PatientInfo.Controls.Add(this.RengBtn);
            this.PatientInfo.Controls.Add(this.ChangeBtn);
            this.PatientInfo.Controls.Add(this.AddBtn);
            this.PatientInfo.Controls.Add(this.label3);
            this.PatientInfo.Controls.Add(this.label2);
            this.PatientInfo.Controls.Add(this.TodayRad);
            this.PatientInfo.Controls.Add(this.AllRad);
            this.PatientInfo.Controls.Add(this.comboBox1);
            this.PatientInfo.Controls.Add(this.BtnGetPat);
            this.PatientInfo.Controls.Add(this.LblPatient);
            this.helpProvider1.SetHelpKeyword(this.PatientInfo, "7");
            this.helpProvider1.SetHelpNavigator(this.PatientInfo, System.Windows.Forms.HelpNavigator.TopicId);
            this.helpProvider1.SetHelpString(this.PatientInfo, "7");
            this.PatientInfo.Location = new System.Drawing.Point(4, 22);
            this.PatientInfo.Name = "PatientInfo";
            this.PatientInfo.Padding = new System.Windows.Forms.Padding(3);
            this.helpProvider1.SetShowHelp(this.PatientInfo, true);
            this.PatientInfo.Size = new System.Drawing.Size(702, 383);
            this.PatientInfo.TabIndex = 0;
            this.PatientInfo.Text = "Пацієнт";
            this.PatientInfo.UseVisualStyleBackColor = true;
            // 
            // PatAppointm
            // 
            this.PatAppointm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatAppointm.Location = new System.Drawing.Point(8, 174);
            this.PatAppointm.Name = "PatAppointm";
            this.PatAppointm.Size = new System.Drawing.Size(686, 23);
            this.PatAppointm.TabIndex = 14;
            this.PatAppointm.Text = "Прийоми пацієнта";
            this.PatAppointm.UseVisualStyleBackColor = true;
            this.PatAppointm.Click += new System.EventHandler(this.PatAppointm_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Visible = false;
            // 
            // AddPaided
            // 
            this.AddPaided.Location = new System.Drawing.Point(143, 280);
            this.AddPaided.Name = "AddPaided";
            this.AddPaided.Size = new System.Drawing.Size(150, 23);
            this.AddPaided.TabIndex = 12;
            this.AddPaided.Text = "Додати до довгу/авансу";
            this.AddPaided.UseVisualStyleBackColor = true;
            this.AddPaided.Visible = false;
            this.AddPaided.Click += new System.EventHandler(this.AddPaided_Click);
            // 
            // labelDolg
            // 
            this.labelDolg.AutoSize = true;
            this.labelDolg.Location = new System.Drawing.Point(63, 285);
            this.labelDolg.Name = "labelDolg";
            this.labelDolg.Size = new System.Drawing.Size(13, 13);
            this.labelDolg.TabIndex = 11;
            this.labelDolg.Text = "0";
            this.labelDolg.Visible = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(28, 285);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(39, 13);
            this.label30.TabIndex = 11;
            this.label30.Text = "Довг: ";
            this.label30.Visible = false;
            // 
            // BtnAppointm
            // 
            this.BtnAppointm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAppointm.Location = new System.Drawing.Point(7, 145);
            this.BtnAppointm.Name = "BtnAppointm";
            this.BtnAppointm.Size = new System.Drawing.Size(687, 23);
            this.BtnAppointm.TabIndex = 10;
            this.BtnAppointm.Text = "Щоденник пацієнта";
            this.BtnAppointm.UseVisualStyleBackColor = true;
            this.BtnAppointm.Click += new System.EventHandler(this.BtnAppointm_Click);
            // 
            // RengBtn
            // 
            this.RengBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RengBtn.Location = new System.Drawing.Point(6, 115);
            this.RengBtn.Name = "RengBtn";
            this.RengBtn.Size = new System.Drawing.Size(688, 23);
            this.RengBtn.TabIndex = 9;
            this.RengBtn.Text = "Відкрити папку з рентгеном";
            this.RengBtn.UseVisualStyleBackColor = true;
            this.RengBtn.Click += new System.EventHandler(this.RengBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeBtn.Location = new System.Drawing.Point(6, 85);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(688, 24);
            this.ChangeBtn.TabIndex = 8;
            this.ChangeBtn.Text = "Змінити";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(472, 29);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(79, 23);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Додати";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата народження:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер телефону: ";
            // 
            // TodayRad
            // 
            this.TodayRad.AutoSize = true;
            this.TodayRad.Location = new System.Drawing.Point(66, 8);
            this.TodayRad.Name = "TodayRad";
            this.TodayRad.Size = new System.Drawing.Size(85, 17);
            this.TodayRad.TabIndex = 4;
            this.TodayRad.Text = "На сьогодні";
            this.TodayRad.UseVisualStyleBackColor = true;
            this.TodayRad.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // AllRad
            // 
            this.AllRad.AutoSize = true;
            this.AllRad.Checked = true;
            this.AllRad.Location = new System.Drawing.Point(157, 8);
            this.AllRad.Name = "AllRad";
            this.AllRad.Size = new System.Drawing.Size(40, 17);
            this.AllRad.TabIndex = 4;
            this.AllRad.TabStop = true;
            this.AllRad.Text = "Всі";
            this.AllRad.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.comboBox1.DataSource = this.patientsBindingSource;
            this.comboBox1.DisplayMember = "full_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(369, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.TabStop = false;
            this.comboBox1.ValueMember = "id_patient";
            this.comboBox1.TextUpdate += new System.EventHandler(this.ComboBox1_TextUpdate);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.ComboBox1_TextChanged);
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
            // BtnGetPat
            // 
            this.BtnGetPat.Location = new System.Drawing.Point(441, 29);
            this.BtnGetPat.Name = "BtnGetPat";
            this.BtnGetPat.Size = new System.Drawing.Size(25, 21);
            this.BtnGetPat.TabIndex = 2;
            this.BtnGetPat.Text = "...";
            this.BtnGetPat.UseVisualStyleBackColor = true;
            this.BtnGetPat.Click += new System.EventHandler(this.BtnGetPat_Click);
            // 
            // LblPatient
            // 
            this.LblPatient.AutoSize = true;
            this.LblPatient.Location = new System.Drawing.Point(8, 34);
            this.LblPatient.Name = "LblPatient";
            this.LblPatient.Size = new System.Drawing.Size(52, 13);
            this.LblPatient.TabIndex = 1;
            this.LblPatient.Text = "Пацієнт: ";
            // 
            // Complaints
            // 
            this.Complaints.Controls.Add(this.tableLayoutPanel1);
            this.helpProvider1.SetHelpKeyword(this.Complaints, "8");
            this.helpProvider1.SetHelpNavigator(this.Complaints, System.Windows.Forms.HelpNavigator.TopicId);
            this.Complaints.Location = new System.Drawing.Point(4, 22);
            this.Complaints.Name = "Complaints";
            this.Complaints.Padding = new System.Windows.Forms.Padding(3);
            this.helpProvider1.SetShowHelp(this.Complaints, true);
            this.Complaints.Size = new System.Drawing.Size(702, 383);
            this.Complaints.TabIndex = 1;
            this.Complaints.Text = "Скарги";
            this.Complaints.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.01639F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.9836F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeViewcompl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddComplaint, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComplText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridComplaints, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 356);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "Перелік скарг пацієнта";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // treeViewcompl
            // 
            this.treeViewcompl.CheckBoxes = true;
            this.tableLayoutPanel1.SetColumnSpan(this.treeViewcompl, 2);
            this.treeViewcompl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewcompl.FullRowSelect = true;
            this.treeViewcompl.Location = new System.Drawing.Point(366, 75);
            this.treeViewcompl.Name = "treeViewcompl";
            this.treeViewcompl.Size = new System.Drawing.Size(317, 278);
            this.treeViewcompl.TabIndex = 6;
            this.treeViewcompl.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewcompl_AfterCheck);
            this.treeViewcompl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeViewcompl_MouseDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label15, 2);
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(366, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(317, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Можливі скарги (відмічено за поточні день та лікаря)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BtnAddComplaint
            // 
            this.BtnAddComplaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddComplaint.Location = new System.Drawing.Point(436, 3);
            this.BtnAddComplaint.Name = "BtnAddComplaint";
            this.BtnAddComplaint.Size = new System.Drawing.Size(247, 20);
            this.BtnAddComplaint.TabIndex = 4;
            this.BtnAddComplaint.Text = "Додати";
            this.BtnAddComplaint.UseVisualStyleBackColor = true;
            this.BtnAddComplaint.Click += new System.EventHandler(this.BtnAddComplaint_Click);
            // 
            // ComplText
            // 
            this.ComplText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComplText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tableLayoutPanel1.SetColumnSpan(this.ComplText, 2);
            this.ComplText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComplText.Location = new System.Drawing.Point(366, 29);
            this.ComplText.Name = "ComplText";
            this.ComplText.Size = new System.Drawing.Size(317, 20);
            this.ComplText.TabIndex = 7;
            this.ComplText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComplText_KeyDown);
            // 
            // dataGridComplaints
            // 
            this.dataGridComplaints.AllowUserToAddRows = false;
            this.dataGridComplaints.AutoGenerateColumns = false;
            this.dataGridComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridComplaints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.complaintDataGridViewTextBoxColumn,
            this.datecomplDataGridViewTextBoxColumn,
            this.doctor});
            this.dataGridComplaints.DataSource = this.patientscomplaintsBindingSource;
            this.dataGridComplaints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridComplaints.Location = new System.Drawing.Point(3, 29);
            this.dataGridComplaints.Name = "dataGridComplaints";
            this.dataGridComplaints.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridComplaints, 3);
            this.dataGridComplaints.Size = new System.Drawing.Size(357, 324);
            this.dataGridComplaints.TabIndex = 0;
            this.dataGridComplaints.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridComplaints_DataError);
            // 
            // complaintDataGridViewTextBoxColumn
            // 
            this.complaintDataGridViewTextBoxColumn.DataPropertyName = "complaint";
            this.complaintDataGridViewTextBoxColumn.DataSource = this.dBDS;
            this.complaintDataGridViewTextBoxColumn.DisplayMember = "possibleCompl.description_compl";
            this.complaintDataGridViewTextBoxColumn.HeaderText = "Опис скарги";
            this.complaintDataGridViewTextBoxColumn.Name = "complaintDataGridViewTextBoxColumn";
            this.complaintDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.complaintDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.complaintDataGridViewTextBoxColumn.ValueMember = "possibleCompl.id_compl";
            // 
            // datecomplDataGridViewTextBoxColumn
            // 
            this.datecomplDataGridViewTextBoxColumn.DataPropertyName = "date_compl";
            this.datecomplDataGridViewTextBoxColumn.FillWeight = 30F;
            this.datecomplDataGridViewTextBoxColumn.HeaderText = "Дата скарги";
            this.datecomplDataGridViewTextBoxColumn.Name = "datecomplDataGridViewTextBoxColumn";
            // 
            // doctor
            // 
            this.doctor.DataPropertyName = "doctor";
            this.doctor.DataSource = this.doctorsBindingSource;
            this.doctor.DisplayMember = "full_name";
            this.doctor.FillWeight = 20F;
            this.doctor.HeaderText = "Лікар";
            this.doctor.Name = "doctor";
            this.doctor.ReadOnly = true;
            this.doctor.ValueMember = "id_doctor";
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this.dBDS;
            // 
            // patientscomplaintsBindingSource
            // 
            this.patientscomplaintsBindingSource.DataMember = "patientscomplaints";
            this.patientscomplaintsBindingSource.DataSource = this.patientsBindingSource;
            this.patientscomplaintsBindingSource.Sort = "date_compl";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(366, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Скарга";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Anamnesis
            // 
            this.Anamnesis.Controls.Add(this.tableLayoutPanel2);
            this.helpProvider1.SetHelpKeyword(this.Anamnesis, "9");
            this.helpProvider1.SetHelpNavigator(this.Anamnesis, System.Windows.Forms.HelpNavigator.TopicId);
            this.Anamnesis.Location = new System.Drawing.Point(4, 22);
            this.Anamnesis.Name = "Anamnesis";
            this.Anamnesis.Padding = new System.Windows.Forms.Padding(3);
            this.helpProvider1.SetShowHelp(this.Anamnesis, true);
            this.Anamnesis.Size = new System.Drawing.Size(702, 383);
            this.Anamnesis.TabIndex = 4;
            this.Anamnesis.Text = "Анамнез (інші)";
            this.Anamnesis.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.78777F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.21223F));
            this.tableLayoutPanel2.Controls.Add(this.typeOfAnamn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.treeViewAnamn, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.AnamnSearch, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnAddAnm, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView4, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(686, 356);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // typeOfAnamn
            // 
            this.typeOfAnamn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeOfAnamn.FormattingEnabled = true;
            this.typeOfAnamn.Items.AddRange(new object[] {
            "Життя",
            "Алергологічний"});
            this.typeOfAnamn.Location = new System.Drawing.Point(123, 3);
            this.typeOfAnamn.Name = "typeOfAnamn";
            this.typeOfAnamn.Size = new System.Drawing.Size(264, 21);
            this.typeOfAnamn.TabIndex = 1;
            this.typeOfAnamn.Text = "Життя";
            this.typeOfAnamn.SelectedIndexChanged += new System.EventHandler(this.typeOfAnamn_SelectedIndexChanged);
            // 
            // treeViewAnamn
            // 
            this.treeViewAnamn.CheckBoxes = true;
            this.treeViewAnamn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAnamn.FullRowSelect = true;
            this.treeViewAnamn.Location = new System.Drawing.Point(393, 75);
            this.treeViewAnamn.Name = "treeViewAnamn";
            this.treeViewAnamn.Size = new System.Drawing.Size(290, 278);
            this.treeViewAnamn.TabIndex = 3;
            this.treeViewAnamn.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewAnamn_AfterCheck);
            this.treeViewAnamn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeViewcompl_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(393, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Список захворювань";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AnamnSearch
            // 
            this.AnamnSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AnamnSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AnamnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnamnSearch.Location = new System.Drawing.Point(393, 29);
            this.AnamnSearch.Name = "AnamnSearch";
            this.AnamnSearch.Size = new System.Drawing.Size(290, 20);
            this.AnamnSearch.TabIndex = 9;
            this.AnamnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnamnSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип анамнезу";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnAddAnm
            // 
            this.BtnAddAnm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddAnm.Location = new System.Drawing.Point(393, 3);
            this.BtnAddAnm.Name = "BtnAddAnm";
            this.BtnAddAnm.Size = new System.Drawing.Size(290, 20);
            this.BtnAddAnm.TabIndex = 8;
            this.BtnAddAnm.Text = "Додати захворювання";
            this.BtnAddAnm.UseVisualStyleBackColor = true;
            this.BtnAddAnm.Click += new System.EventHandler(this.BtnAddAnm_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namediseaseDataGridViewTextBoxColumn,
            this.typeanamnDataGridViewTextBoxColumn});
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridView4, 2);
            this.dataGridView4.DataSource = this.patientsanamnesisBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 29);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.tableLayoutPanel2.SetRowSpan(this.dataGridView4, 3);
            this.dataGridView4.Size = new System.Drawing.Size(384, 324);
            this.dataGridView4.TabIndex = 0;
            // 
            // namediseaseDataGridViewTextBoxColumn
            // 
            this.namediseaseDataGridViewTextBoxColumn.DataPropertyName = "name_disease";
            this.namediseaseDataGridViewTextBoxColumn.DataSource = this.diseasesanamBindingSource;
            this.namediseaseDataGridViewTextBoxColumn.DisplayMember = "disease_name";
            this.namediseaseDataGridViewTextBoxColumn.HeaderText = "Захворювання";
            this.namediseaseDataGridViewTextBoxColumn.Name = "namediseaseDataGridViewTextBoxColumn";
            this.namediseaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.namediseaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.namediseaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.namediseaseDataGridViewTextBoxColumn.ValueMember = "id_disease_anam";
            // 
            // diseasesanamBindingSource
            // 
            this.diseasesanamBindingSource.DataMember = "diseases_anam";
            this.diseasesanamBindingSource.DataSource = this.dBDS;
            // 
            // typeanamnDataGridViewTextBoxColumn
            // 
            this.typeanamnDataGridViewTextBoxColumn.DataPropertyName = "type_anamn";
            this.typeanamnDataGridViewTextBoxColumn.HeaderText = "type_anamn";
            this.typeanamnDataGridViewTextBoxColumn.Name = "typeanamnDataGridViewTextBoxColumn";
            this.typeanamnDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientsanamnesisBindingSource
            // 
            this.patientsanamnesisBindingSource.DataMember = "patientsanamnesis";
            this.patientsanamnesisBindingSource.DataSource = this.patientsBindingSource;
            // 
            // planletstab
            // 
            this.planletstab.Controls.Add(this.tableLayoutPanel3);
            this.planletstab.Controls.Add(this.label24);
            this.helpProvider1.SetHelpKeyword(this.planletstab, "10");
            this.helpProvider1.SetHelpNavigator(this.planletstab, System.Windows.Forms.HelpNavigator.TopicId);
            this.planletstab.Location = new System.Drawing.Point(4, 22);
            this.planletstab.Name = "planletstab";
            this.planletstab.Padding = new System.Windows.Forms.Padding(3);
            this.helpProvider1.SetShowHelp(this.planletstab, true);
            this.planletstab.Size = new System.Drawing.Size(702, 383);
            this.planletstab.TabIndex = 6;
            this.planletstab.Text = "План лікування";
            this.planletstab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.32319F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.6768F));
            this.tableLayoutPanel3.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.PlnLtsTree, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label25, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.PlnLtsDateTime, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.BtnAddPlnLts, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.label21, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.PlnLtsSearch, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.PlnLtsTooth, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label22, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label23, 1, 5);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(688, 356);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(374, 20);
            this.label20.TabIndex = 1;
            this.label20.Text = "Записи плану";
            this.label20.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PlnLtsTree
            // 
            this.PlnLtsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlnLtsTree.FullRowSelect = true;
            this.PlnLtsTree.Location = new System.Drawing.Point(383, 207);
            this.PlnLtsTree.Name = "PlnLtsTree";
            this.PlnLtsTree.ShowLines = false;
            this.PlnLtsTree.ShowPlusMinus = false;
            this.PlnLtsTree.ShowRootLines = false;
            this.PlnLtsTree.Size = new System.Drawing.Size(302, 146);
            this.PlnLtsTree.TabIndex = 7;
            this.PlnLtsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.PlnLtsTree_AfterSelect);
            this.PlnLtsTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeViewcompl_MouseDown);
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
            this.toothDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateplnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientsplanletsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.tableLayoutPanel3.SetRowSpan(this.dataGridView1, 9);
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(374, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView1_DataBindingComplete);
            // 
            // toothDataGridViewTextBoxColumn1
            // 
            this.toothDataGridViewTextBoxColumn1.DataPropertyName = "tooth";
            this.toothDataGridViewTextBoxColumn1.FillWeight = 25F;
            this.toothDataGridViewTextBoxColumn1.HeaderText = "Зуб(и)";
            this.toothDataGridViewTextBoxColumn1.Name = "toothDataGridViewTextBoxColumn1";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.DataSource = this.possiblePltsBindingSource;
            this.descriptionDataGridViewTextBoxColumn.DisplayMember = "name_plts";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "План";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.descriptionDataGridViewTextBoxColumn.ValueMember = "id_possiblPlts";
            // 
            // possiblePltsBindingSource
            // 
            this.possiblePltsBindingSource.DataMember = "possiblePlts";
            this.possiblePltsBindingSource.DataSource = this.dBDS;
            // 
            // dateplnDataGridViewTextBoxColumn
            // 
            this.dateplnDataGridViewTextBoxColumn.DataPropertyName = "date_pln";
            this.dateplnDataGridViewTextBoxColumn.FillWeight = 30F;
            this.dateplnDataGridViewTextBoxColumn.HeaderText = "Планована дата";
            this.dateplnDataGridViewTextBoxColumn.Name = "dateplnDataGridViewTextBoxColumn";
            // 
            // patientsplanletsBindingSource
            // 
            this.patientsplanletsBindingSource.DataMember = "patientsplanlets";
            this.patientsplanletsBindingSource.DataSource = this.patientsBindingSource;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Location = new System.Drawing.Point(383, 184);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(302, 20);
            this.label25.TabIndex = 5;
            this.label25.Text = "Можливі дії";
            this.label25.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PlnLtsDateTime
            // 
            this.PlnLtsDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlnLtsDateTime.Location = new System.Drawing.Point(383, 89);
            this.PlnLtsDateTime.Name = "PlnLtsDateTime";
            this.PlnLtsDateTime.Size = new System.Drawing.Size(302, 20);
            this.PlnLtsDateTime.TabIndex = 6;
            // 
            // BtnAddPlnLts
            // 
            this.BtnAddPlnLts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddPlnLts.Location = new System.Drawing.Point(383, 161);
            this.BtnAddPlnLts.Name = "BtnAddPlnLts";
            this.BtnAddPlnLts.Size = new System.Drawing.Size(302, 20);
            this.BtnAddPlnLts.TabIndex = 3;
            this.BtnAddPlnLts.Text = "Додати у план лікування";
            this.BtnAddPlnLts.UseVisualStyleBackColor = true;
            this.BtnAddPlnLts.Click += new System.EventHandler(this.BtnAddPlnLts_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(383, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(302, 20);
            this.label21.TabIndex = 1;
            this.label21.Text = "Зуб(и)";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PlnLtsSearch
            // 
            this.PlnLtsSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PlnLtsSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PlnLtsSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlnLtsSearch.Location = new System.Drawing.Point(383, 135);
            this.PlnLtsSearch.Name = "PlnLtsSearch";
            this.PlnLtsSearch.Size = new System.Drawing.Size(302, 20);
            this.PlnLtsSearch.TabIndex = 2;
            this.PlnLtsSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlnLtsSearch_KeyDown);
            // 
            // PlnLtsTooth
            // 
            this.PlnLtsTooth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlnLtsTooth.Location = new System.Drawing.Point(383, 43);
            this.PlnLtsTooth.Name = "PlnLtsTooth";
            this.PlnLtsTooth.Size = new System.Drawing.Size(302, 20);
            this.PlnLtsTooth.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Location = new System.Drawing.Point(383, 66);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(302, 20);
            this.label22.TabIndex = 1;
            this.label22.Text = "Планована дата";
            this.label22.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Location = new System.Drawing.Point(383, 112);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(302, 20);
            this.label23.TabIndex = 1;
            this.label23.Text = "План";
            this.label23.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(381, 160);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 13);
            this.label24.TabIndex = 1;
            // 
            // AnamnDispg
            // 
            this.AnamnDispg.Controls.Add(this.tableLayoutPanel4);
            this.helpProvider1.SetHelpKeyword(this.AnamnDispg, "11");
            this.helpProvider1.SetHelpNavigator(this.AnamnDispg, System.Windows.Forms.HelpNavigator.TopicId);
            this.AnamnDispg.Location = new System.Drawing.Point(4, 22);
            this.AnamnDispg.Name = "AnamnDispg";
            this.AnamnDispg.Padding = new System.Windows.Forms.Padding(3);
            this.helpProvider1.SetShowHelp(this.AnamnDispg, true);
            this.AnamnDispg.Size = new System.Drawing.Size(702, 383);
            this.AnamnDispg.TabIndex = 7;
            this.AnamnDispg.Text = "Анамнез (хвороби)";
            this.AnamnDispg.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.03262F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.96738F));
            this.tableLayoutPanel4.Controls.Add(this.label29, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dataGridView5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.treeViewanamndis, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.label28, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.BtnAddAnmdis, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label27, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.AnmndisSearch, 1, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(686, 353);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Location = new System.Drawing.Point(3, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(333, 20);
            this.label29.TabIndex = 3;
            this.label29.Text = "Записи хвороб";
            this.label29.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diseaseDataGridViewTextBoxColumn,
            this.dateanamndisDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.patientsanamnesisDiseasesBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 23);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersVisible = false;
            this.tableLayoutPanel4.SetRowSpan(this.dataGridView5, 4);
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(333, 327);
            this.dataGridView5.TabIndex = 0;
            this.dataGridView5.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView5_DataBindingComplete);
            this.dataGridView5.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView5_DataError);
            // 
            // diseaseDataGridViewTextBoxColumn
            // 
            this.diseaseDataGridViewTextBoxColumn.DataPropertyName = "disease";
            this.diseaseDataGridViewTextBoxColumn.DataSource = this.anamndisdiseasesBindingSource;
            this.diseaseDataGridViewTextBoxColumn.DisplayMember = "name_disease";
            this.diseaseDataGridViewTextBoxColumn.HeaderText = "Хвороба";
            this.diseaseDataGridViewTextBoxColumn.Name = "diseaseDataGridViewTextBoxColumn";
            this.diseaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.diseaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.diseaseDataGridViewTextBoxColumn.ValueMember = "id_disease";
            // 
            // anamndisdiseasesBindingSource
            // 
            this.anamndisdiseasesBindingSource.DataMember = "anamndis_diseases";
            this.anamndisdiseasesBindingSource.DataSource = this.dBDS;
            // 
            // dateanamndisDataGridViewTextBoxColumn
            // 
            this.dateanamndisDataGridViewTextBoxColumn.DataPropertyName = "date_anamndis";
            this.dateanamndisDataGridViewTextBoxColumn.FillWeight = 20F;
            this.dateanamndisDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateanamndisDataGridViewTextBoxColumn.Name = "dateanamndisDataGridViewTextBoxColumn";
            // 
            // patientsanamnesisDiseasesBindingSource
            // 
            this.patientsanamnesisDiseasesBindingSource.DataMember = "patientsanamnesisDiseases";
            this.patientsanamnesisDiseasesBindingSource.DataSource = this.patientsBindingSource;
            // 
            // treeViewanamndis
            // 
            this.treeViewanamndis.CheckBoxes = true;
            this.tableLayoutPanel4.SetColumnSpan(this.treeViewanamndis, 2);
            this.treeViewanamndis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewanamndis.Location = new System.Drawing.Point(342, 95);
            this.treeViewanamndis.Name = "treeViewanamndis";
            this.treeViewanamndis.ShowLines = false;
            this.treeViewanamndis.ShowPlusMinus = false;
            this.treeViewanamndis.ShowRootLines = false;
            this.treeViewanamndis.Size = new System.Drawing.Size(341, 255);
            this.treeViewanamndis.TabIndex = 2;
            this.treeViewanamndis.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewanamndis_AfterCheck);
            this.treeViewanamndis.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeViewcompl_MouseDown);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label28, 2);
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Location = new System.Drawing.Point(342, 72);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(341, 20);
            this.label28.TabIndex = 3;
            this.label28.Text = "Можливі хвороби";
            this.label28.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BtnAddAnmdis
            // 
            this.BtnAddAnmdis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddAnmdis.Location = new System.Drawing.Point(432, 23);
            this.BtnAddAnmdis.Name = "BtnAddAnmdis";
            this.BtnAddAnmdis.Size = new System.Drawing.Size(251, 20);
            this.BtnAddAnmdis.TabIndex = 4;
            this.BtnAddAnmdis.Text = "Додати до списку";
            this.BtnAddAnmdis.UseVisualStyleBackColor = true;
            this.BtnAddAnmdis.Click += new System.EventHandler(this.BtnAddAnmdis_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Location = new System.Drawing.Point(342, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 26);
            this.label27.TabIndex = 3;
            this.label27.Text = "Пошук";
            this.label27.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AnmndisSearch
            // 
            this.AnmndisSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AnmndisSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tableLayoutPanel4.SetColumnSpan(this.AnmndisSearch, 2);
            this.AnmndisSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnmndisSearch.Location = new System.Drawing.Point(342, 49);
            this.AnmndisSearch.Name = "AnmndisSearch";
            this.AnmndisSearch.Size = new System.Drawing.Size(341, 20);
            this.AnmndisSearch.TabIndex = 1;
            this.AnmndisSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnmndisSearch_KeyDown);
            // 
            // Diagnosis
            // 
            this.Diagnosis.Controls.Add(this.tableLayoutPanel5);
            this.helpProvider1.SetHelpKeyword(this.Diagnosis, "12");
            this.helpProvider1.SetHelpNavigator(this.Diagnosis, System.Windows.Forms.HelpNavigator.TopicId);
            this.Diagnosis.Location = new System.Drawing.Point(4, 22);
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.Padding = new System.Windows.Forms.Padding(3);
            this.helpProvider1.SetShowHelp(this.Diagnosis, true);
            this.Diagnosis.Size = new System.Drawing.Size(702, 383);
            this.Diagnosis.TabIndex = 2;
            this.Diagnosis.Text = "Діагноз";
            this.Diagnosis.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.treeViewDiag, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.BtnAddDiag, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.label11, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.diagnosisTextBox, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label13, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.teethTextBox, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label12, 1, 3);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(688, 356);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(354, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Перелік діагнозів пацієнта";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diagnosisDataGridViewTextBoxColumn,
            this.toothDataGridViewTextBoxColumn,
            this.finddateDataGridViewTextBoxColumn,
            this.id_diag_patient});
            this.dataGridView2.DataSource = this.patientsdiagspatientBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.tableLayoutPanel5.SetRowSpan(this.dataGridView2, 7);
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(354, 330);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView2_DataBindingComplete);
            this.dataGridView2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView2_DataError);
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataGridView2_UserDeletingRow);
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.DataSource = this.diagnosisBindingSource;
            this.diagnosisDataGridViewTextBoxColumn.DisplayMember = "name_diag";
            this.diagnosisDataGridViewTextBoxColumn.FillWeight = 70F;
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "Діагноз";
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            this.diagnosisDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.diagnosisDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.diagnosisDataGridViewTextBoxColumn.ValueMember = "id_diag";
            // 
            // diagnosisBindingSource
            // 
            this.diagnosisBindingSource.DataMember = "diagnosis";
            this.diagnosisBindingSource.DataSource = this.dBDS;
            // 
            // toothDataGridViewTextBoxColumn
            // 
            this.toothDataGridViewTextBoxColumn.DataPropertyName = "tooth";
            this.toothDataGridViewTextBoxColumn.FillWeight = 25F;
            this.toothDataGridViewTextBoxColumn.HeaderText = "Зуб(и)";
            this.toothDataGridViewTextBoxColumn.Name = "toothDataGridViewTextBoxColumn";
            // 
            // finddateDataGridViewTextBoxColumn
            // 
            this.finddateDataGridViewTextBoxColumn.DataPropertyName = "find_date";
            this.finddateDataGridViewTextBoxColumn.FillWeight = 30F;
            this.finddateDataGridViewTextBoxColumn.HeaderText = "Дата становлення";
            this.finddateDataGridViewTextBoxColumn.Name = "finddateDataGridViewTextBoxColumn";
            // 
            // id_diag_patient
            // 
            this.id_diag_patient.DataPropertyName = "id_diag_patient";
            this.id_diag_patient.HeaderText = "id_diag_patient";
            this.id_diag_patient.Name = "id_diag_patient";
            this.id_diag_patient.Visible = false;
            // 
            // patientsdiagspatientBindingSource
            // 
            this.patientsdiagspatientBindingSource.DataMember = "patientsdiags_patient";
            this.patientsdiagspatientBindingSource.DataSource = this.patientsBindingSource;
            // 
            // treeViewDiag
            // 
            this.treeViewDiag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDiag.Location = new System.Drawing.Point(363, 161);
            this.treeViewDiag.Name = "treeViewDiag";
            this.treeViewDiag.ShowPlusMinus = false;
            this.treeViewDiag.ShowRootLines = false;
            this.treeViewDiag.Size = new System.Drawing.Size(322, 192);
            this.treeViewDiag.TabIndex = 2;
            this.treeViewDiag.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewDiag_AfterSelect);
            this.treeViewDiag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeViewcompl_MouseDown);
            // 
            // BtnAddDiag
            // 
            this.BtnAddDiag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddDiag.Location = new System.Drawing.Point(363, 115);
            this.BtnAddDiag.Name = "BtnAddDiag";
            this.BtnAddDiag.Size = new System.Drawing.Size(322, 20);
            this.BtnAddDiag.TabIndex = 3;
            this.BtnAddDiag.Text = "Додати";
            this.BtnAddDiag.UseVisualStyleBackColor = true;
            this.BtnAddDiag.Click += new System.EventHandler(this.BtnAddDiag_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(363, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(322, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Можливі діагнози";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.diagnosisTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.diagnosisTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagnosisTextBox.Location = new System.Drawing.Point(363, 89);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(322, 20);
            this.diagnosisTextBox.TabIndex = 4;
            this.diagnosisTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiagnosisTextBox_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(363, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(322, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Зуб(и)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // teethTextBox
            // 
            this.teethTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teethTextBox.Location = new System.Drawing.Point(363, 43);
            this.teethTextBox.Name = "teethTextBox";
            this.teethTextBox.Size = new System.Drawing.Size(322, 20);
            this.teethTextBox.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(363, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(322, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Діагноз";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // appointment
            // 
            this.appointment.Controls.Add(this.tableLayoutPanel6);
            this.helpProvider1.SetHelpKeyword(this.appointment, "13");
            this.helpProvider1.SetHelpNavigator(this.appointment, System.Windows.Forms.HelpNavigator.TopicId);
            this.appointment.Location = new System.Drawing.Point(4, 22);
            this.appointment.Name = "appointment";
            this.appointment.Padding = new System.Windows.Forms.Padding(3);
            this.helpProvider1.SetShowHelp(this.appointment, true);
            this.appointment.Size = new System.Drawing.Size(702, 383);
            this.appointment.TabIndex = 5;
            this.appointment.Text = "Лікування";
            this.appointment.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button3, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.PaidGB, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.AppointBox, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.HealingTreeDiag, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.includesChkBx, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.label26, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.MatTree, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.ServSearch, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.ServTree, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.label14, 1, 2);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(685, 356);
            this.tableLayoutPanel6.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Прийом";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(459, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 20);
            this.button3.TabIndex = 11;
            this.button3.Text = "Змінити прийом";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PaidGB
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.PaidGB, 3);
            this.PaidGB.Controls.Add(this.button2);
            this.PaidGB.Controls.Add(this.treeView1);
            this.PaidGB.Controls.Add(this.label31);
            this.PaidGB.Controls.Add(this.label17);
            this.PaidGB.Controls.Add(this.button5);
            this.PaidGB.Controls.Add(this.label19);
            this.PaidGB.Controls.Add(this.label16);
            this.PaidGB.Controls.Add(this.label18);
            this.PaidGB.Controls.Add(this.BtnPayByAvnc);
            this.PaidGB.Controls.Add(this.button6);
            this.PaidGB.Controls.Add(this.textBox1);
            this.PaidGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaidGB.Location = new System.Drawing.Point(3, 200);
            this.PaidGB.Name = "PaidGB";
            this.PaidGB.Size = new System.Drawing.Size(679, 153);
            this.PaidGB.TabIndex = 24;
            this.PaidGB.TabStop = false;
            this.PaidGB.Text = "Оплата послуг";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Обнулить оплату";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(3, 32);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(428, 115);
            this.treeView1.TabIndex = 13;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(559, 157);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 13);
            this.label31.TabIndex = 23;
            this.label31.Text = "Аванс:";
            this.label31.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(437, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 31);
            this.label17.TabIndex = 12;
            this.label17.Text = "0 грн.";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(437, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Оплата повністю";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(440, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(211, 18);
            this.label19.TabIndex = 17;
            this.label19.Text = "Статус оплати: не розпочато";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(437, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(233, 31);
            this.label16.TabIndex = 10;
            this.label16.Text = "Загальна сумма: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Придбано:";
            // 
            // BtnPayByAvnc
            // 
            this.BtnPayByAvnc.Location = new System.Drawing.Point(437, 152);
            this.BtnPayByAvnc.Name = "BtnPayByAvnc";
            this.BtnPayByAvnc.Size = new System.Drawing.Size(116, 23);
            this.BtnPayByAvnc.TabIndex = 15;
            this.BtnPayByAvnc.Text = "Оплата з авансу";
            this.BtnPayByAvnc.UseVisualStyleBackColor = true;
            this.BtnPayByAvnc.Visible = false;
            this.BtnPayByAvnc.Click += new System.EventHandler(this.BtnPayByAvnc_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(437, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Оплата частково";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 16;
            // 
            // AppointBox
            // 
            this.AppointBox.DataSource = this.patientsappointmentBindingSource;
            this.AppointBox.DisplayMember = "time";
            this.AppointBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppointBox.FormatString = "t";
            this.AppointBox.FormattingEnabled = true;
            this.AppointBox.Location = new System.Drawing.Point(3, 23);
            this.AppointBox.Name = "AppointBox";
            this.AppointBox.Size = new System.Drawing.Size(222, 21);
            this.AppointBox.TabIndex = 0;
            this.AppointBox.ValueMember = "id_appointment";
            this.AppointBox.SelectedValueChanged += new System.EventHandler(this.AppointBox_SelectedValueChanged);
            // 
            // patientsappointmentBindingSource
            // 
            this.patientsappointmentBindingSource.DataMember = "patientsappointment";
            this.patientsappointmentBindingSource.DataSource = this.patientsBindingSource;
            // 
            // HealingTreeDiag
            // 
            this.HealingTreeDiag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HealingTreeDiag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HealingTreeDiag.HideSelection = false;
            this.HealingTreeDiag.HotTracking = true;
            this.HealingTreeDiag.Location = new System.Drawing.Point(3, 69);
            this.HealingTreeDiag.Name = "HealingTreeDiag";
            this.HealingTreeDiag.ShowLines = false;
            this.HealingTreeDiag.ShowPlusMinus = false;
            this.HealingTreeDiag.ShowRootLines = false;
            this.HealingTreeDiag.Size = new System.Drawing.Size(222, 99);
            this.HealingTreeDiag.TabIndex = 22;
            this.HealingTreeDiag.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.HealingTreeDiag_AfterSelect);
            // 
            // includesChkBx
            // 
            this.includesChkBx.AutoSize = true;
            this.includesChkBx.Checked = true;
            this.includesChkBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includesChkBx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.includesChkBx.Location = new System.Drawing.Point(231, 174);
            this.includesChkBx.Name = "includesChkBx";
            this.includesChkBx.Size = new System.Drawing.Size(222, 20);
            this.includesChkBx.TabIndex = 18;
            this.includesChkBx.Text = "Враховувати ціну";
            this.includesChkBx.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Location = new System.Drawing.Point(3, 46);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(222, 20);
            this.label26.TabIndex = 20;
            this.label26.Text = "Оберіть діагноз";
            this.label26.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Додати у сумму";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MatTree
            // 
            this.MatTree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MatTree.CheckBoxes = true;
            this.MatTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatTree.Location = new System.Drawing.Point(459, 69);
            this.MatTree.Name = "MatTree";
            this.MatTree.Size = new System.Drawing.Size(223, 99);
            this.MatTree.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(459, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Перелік можливих матеріалів для послуги";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(231, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Пошук послуги";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ServSearch
            // 
            this.ServSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ServSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ServSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServSearch.Location = new System.Drawing.Point(231, 23);
            this.ServSearch.Name = "ServSearch";
            this.ServSearch.Size = new System.Drawing.Size(222, 20);
            this.ServSearch.TabIndex = 5;
            this.ServSearch.TextChanged += new System.EventHandler(this.ServSearch_TextChanged);
            // 
            // ServTree
            // 
            this.ServTree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServTree.HideSelection = false;
            this.ServTree.HotTracking = true;
            this.ServTree.Location = new System.Drawing.Point(231, 69);
            this.ServTree.Name = "ServTree";
            this.ServTree.ShowLines = false;
            this.ServTree.ShowPlusMinus = false;
            this.ServTree.ShowRootLines = false;
            this.ServTree.Size = new System.Drawing.Size(222, 99);
            this.ServTree.TabIndex = 6;
            this.ServTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ServTree_AfterSelect);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(231, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(222, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Оберіть послугу";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.змінитиToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // змінитиToolStripMenuItem
            // 
            this.змінитиToolStripMenuItem.Name = "змінитиToolStripMenuItem";
            this.змінитиToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.змінитиToolStripMenuItem.Text = "Змінити";
            this.змінитиToolStripMenuItem.Click += new System.EventHandler(this.ЗмінитиToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.удалитьToolStripMenuItem.Text = "Вилучити";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.УдалитьToolStripMenuItem_Click);
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.dBDS;
            // 
            // appointmentappointmentservicesBindingSource
            // 
            this.appointmentappointmentservicesBindingSource.DataMember = "appointmentappointment_services";
            this.appointmentappointmentservicesBindingSource.DataSource = this.patientsappointmentBindingSource;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(710, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // complaintsTableAdapter
            // 
            this.complaintsTableAdapter.ClearBeforeFill = true;
            // 
            // diags_patientTableAdapter
            // 
            this.diags_patientTableAdapter.ClearBeforeFill = true;
            // 
            // planletsTableAdapter
            // 
            this.planletsTableAdapter.ClearBeforeFill = true;
            // 
            // anamnesisTableAdapter
            // 
            this.anamnesisTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // appointment_servicesTableAdapter
            // 
            this.appointment_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // possibleComplTableAdapter
            // 
            this.possibleComplTableAdapter.ClearBeforeFill = true;
            // 
            // possiblePltsTableAdapter
            // 
            this.possiblePltsTableAdapter.ClearBeforeFill = true;
            // 
            // diseases_anamTableAdapter
            // 
            this.diseases_anamTableAdapter.ClearBeforeFill = true;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // post_servicesTableAdapter
            // 
            this.post_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // serv_materialTableAdapter
            // 
            this.serv_materialTableAdapter.ClearBeforeFill = true;
            // 
            // post_doctorTableAdapter
            // 
            this.post_doctorTableAdapter.ClearBeforeFill = true;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // appointment_materialsTableAdapter
            // 
            this.appointment_materialsTableAdapter.ClearBeforeFill = true;
            // 
            // anamnesisDiseasesTableAdapter
            // 
            this.anamnesisDiseasesTableAdapter.ClearBeforeFill = true;
            // 
            // anamndis_diseasesTableAdapter
            // 
            this.anamndis_diseasesTableAdapter.ClearBeforeFill = true;
            // 
            // diagnosisTableAdapter
            // 
            this.diagnosisTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 458);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.helpProvider1.SetHelpKeyword(this, "4");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.helpProvider1.SetHelpString(this, "4");
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(726, 497);
            this.Name = "MainForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Стоматологічний додаток";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MainTab.ResumeLayout(false);
            this.PatientInfo.ResumeLayout(false);
            this.PatientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            this.Complaints.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComplaints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientscomplaintsBindingSource)).EndInit();
            this.Anamnesis.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseasesanamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsanamnesisBindingSource)).EndInit();
            this.planletstab.ResumeLayout(false);
            this.planletstab.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.possiblePltsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsplanletsBindingSource)).EndInit();
            this.AnamnDispg.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anamndisdiseasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsanamnesisDiseasesBindingSource)).EndInit();
            this.Diagnosis.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsdiagspatientBindingSource)).EndInit();
            this.appointment.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.PaidGB.ResumeLayout(false);
            this.PaidGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsappointmentBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentappointmentservicesBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void NewMethod()
        {
            this.dBDS = StDb.DB;
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пацієнтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лікаріToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналЗаписуToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ChangeView;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage PatientInfo;
        private dBDS dBDS;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private dBDSTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnGetPat;
        private System.Windows.Forms.Label LblPatient;
        private System.Windows.Forms.TabPage Diagnosis;
        private System.Windows.Forms.TabPage Anamnesis;
        private System.Windows.Forms.TabPage appointment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem матеріалиToolStripMenuItem;
        private System.Windows.Forms.BindingSource patientscomplaintsBindingSource;
        private dBDSTableAdapters.complaintsTableAdapter complaintsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource patientsdiagspatientBindingSource;
        private dBDSTableAdapters.diags_patientTableAdapter diags_patientTableAdapter;
        private System.Windows.Forms.BindingSource patientsplanletsBindingSource;
        private dBDSTableAdapters.planletsTableAdapter planletsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource patientsanamnesisBindingSource;
        private dBDSTableAdapters.anamnesisTableAdapter anamnesisTableAdapter;
        private dBDSTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeOfAnamn;
        private System.Windows.Forms.RadioButton AllRad;
        private System.Windows.Forms.RadioButton TodayRad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource patientsappointmentBindingSource;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView treeViewAnamn;
        private System.Windows.Forms.BindingSource appointmentappointmentservicesBindingSource;
        private dBDSTableAdapters.appointment_servicesTableAdapter appointment_servicesTableAdapter;
        private System.Windows.Forms.Button BtnAddAnm;
        private dBDSTableAdapters.doctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton ChekDataView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox teethTextBox;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.Button BtnAddDiag;
        private System.Windows.Forms.TreeView treeViewDiag;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private dBDSTableAdapters.possibleComplTableAdapter possibleComplTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripPat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolNumtel;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.ToolStripButton UpdButton;
        private System.Windows.Forms.Button RengBtn;
        private System.Windows.Forms.ToolStripMenuItem посадиToolStripMenuItem;
        private dBDSTableAdapters.possiblePltsTableAdapter possiblePltsTableAdapter;
        private System.Windows.Forms.TabPage planletstab;
        private System.Windows.Forms.ToolStripMenuItem додатиПосадуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem послугиЗаПосадоюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиМатеріалиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матеріалиЗаПослугоюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редагуванняПослугToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dBDSTableAdapters.diseases_anamTableAdapter diseases_anamTableAdapter;
        private dBDSTableAdapters.servicesTableAdapter servicesTableAdapter;
        private dBDSTableAdapters.post_servicesTableAdapter post_servicesTableAdapter;
        private dBDSTableAdapters.serv_materialTableAdapter serv_materialTableAdapter;
        private dBDSTableAdapters.post_doctorTableAdapter post_doctorTableAdapter;
        private dBDSTableAdapters.postTableAdapter postTableAdapter;
        private dBDSTableAdapters.materialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AppointBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView MatTree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ServSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TreeView ServTree;
        private dBDSTableAdapters.appointment_materialsTableAdapter appointment_materialsTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.BindingSource diseasesanamBindingSource;
        private System.Windows.Forms.Button BtnAppointm;
        private System.Windows.Forms.ToolStripMenuItem прийомиToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox includesChkBx;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.BindingSource possiblePltsBindingSource;
        private System.Windows.Forms.Button BtnAddPlnLts;
        private System.Windows.Forms.TextBox PlnLtsSearch;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox PlnLtsTooth;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker PlnLtsDateTime;
        private System.Windows.Forms.TextBox AnamnSearch;
        private System.Windows.Forms.TabPage AnamnDispg;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource patientsanamnesisDiseasesBindingSource;
        private dBDSTableAdapters.anamnesisDiseasesTableAdapter anamnesisDiseasesTableAdapter;
        private System.Windows.Forms.TreeView PlnLtsTree;
        private System.Windows.Forms.Button BtnAddAnmdis;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TreeView treeViewanamndis;
        private System.Windows.Forms.TextBox AnmndisSearch;
        private System.Windows.Forms.TreeView HealingTreeDiag;
        private dBDSTableAdapters.anamndis_diseasesTableAdapter anamndis_diseasesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem змінитиToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private dBDSTableAdapters.diagnosisTableAdapter diagnosisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn toothDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateplnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn diseaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource anamndisdiseasesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateanamndisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn namediseaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeanamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelDolg;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button AddPaided;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button BtnPayByAvnc;
        private System.Windows.Forms.GroupBox PaidGB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewComboBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toothDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_diag_patient;
        private System.Windows.Forms.Button PatAppointm;
        private System.Windows.Forms.ToolStripButton closeWind;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TreeView treeViewcompl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnAddComplaint;
        private System.Windows.Forms.TextBox ComplText;
        private System.Windows.Forms.DataGridView dataGridComplaints;
        private System.Windows.Forms.DataGridViewComboBoxColumn complaintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecomplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn doctor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TabPage Complaints;
    }
}

