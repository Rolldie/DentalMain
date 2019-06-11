namespace DentalMain
{
    partial class SettingsApp
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
            this.Rad1 = new System.Windows.Forms.RadioButton();
            this.Rad2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorGet = new System.Windows.Forms.ComboBox();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDS = new DentalMain.dBDS();
            this.doctorsTableAdapter = new DentalMain.dBDSTableAdapters.doctorsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.WorkMode = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnChangeCon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).BeginInit();
            this.WorkMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rad1
            // 
            this.Rad1.AutoSize = true;
            this.Rad1.Location = new System.Drawing.Point(18, 24);
            this.Rad1.Name = "Rad1";
            this.Rad1.Size = new System.Drawing.Size(79, 17);
            this.Rad1.TabIndex = 0;
            this.Rad1.Text = "Без лікаря";
            this.Rad1.UseVisualStyleBackColor = true;
            this.Rad1.CheckedChanged += new System.EventHandler(this.RegIn_CheckedChanged);
            // 
            // Rad2
            // 
            this.Rad2.AutoSize = true;
            this.Rad2.Location = new System.Drawing.Point(18, 47);
            this.Rad2.Name = "Rad2";
            this.Rad2.Size = new System.Drawing.Size(75, 17);
            this.Rad2.TabIndex = 0;
            this.Rad2.Text = "З лікарем";
            this.Rad2.UseVisualStyleBackColor = true;
            this.Rad2.CheckedChanged += new System.EventHandler(this.DocIn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оберіть режим роботи";
            // 
            // DoctorGet
            // 
            this.DoctorGet.DataSource = this.doctorsBindingSource;
            this.DoctorGet.DisplayMember = "full_name";
            this.DoctorGet.FormattingEnabled = true;
            this.DoctorGet.Location = new System.Drawing.Point(183, 27);
            this.DoctorGet.Name = "DoctorGet";
            this.DoctorGet.Size = new System.Drawing.Size(206, 21);
            this.DoctorGet.TabIndex = 2;
            this.DoctorGet.ValueMember = "id_doctor";
            this.DoctorGet.SelectedIndexChanged += new System.EventHandler(this.DoctorGet_SelectedIndexChanged);
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
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(183, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Вийти без збереження";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WorkMode
            // 
            this.WorkMode.Controls.Add(this.label1);
            this.WorkMode.Controls.Add(this.Rad1);
            this.WorkMode.Controls.Add(this.Rad2);
            this.WorkMode.Location = new System.Drawing.Point(20, 12);
            this.WorkMode.Name = "WorkMode";
            this.WorkMode.Size = new System.Drawing.Size(157, 96);
            this.WorkMode.TabIndex = 4;
            this.WorkMode.TabStop = false;
            this.WorkMode.Text = "Режим роботи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Лікар";
            // 
            // BtnChangeCon
            // 
            this.BtnChangeCon.Location = new System.Drawing.Point(20, 114);
            this.BtnChangeCon.Name = "BtnChangeCon";
            this.BtnChangeCon.Size = new System.Drawing.Size(369, 36);
            this.BtnChangeCon.TabIndex = 5;
            this.BtnChangeCon.Text = "Змінити розташування бази (викличе перезавантаження)";
            this.BtnChangeCon.UseVisualStyleBackColor = true;
            this.BtnChangeCon.Click += new System.EventHandler(this.BtnChangeCon_Click);
            // 
            // SettingsApp
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(400, 156);
            this.Controls.Add(this.BtnChangeCon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WorkMode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoctorGet);
            this.Name = "SettingsApp";
            this.Text = "Налаштування";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDS)).EndInit();
            this.WorkMode.ResumeLayout(false);
            this.WorkMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Rad1;
        private System.Windows.Forms.RadioButton Rad2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DoctorGet;
        private dBDS dBDS;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private dBDSTableAdapters.doctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox WorkMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnChangeCon;
    }
}