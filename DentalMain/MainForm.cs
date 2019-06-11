using System;
using System.Collections.Generic;
using Microsoft;
using Microsoft.Win32;
using Microsoft.Office.Interop;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Threading; 
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Word = Microsoft.Office.Interop.Word;


namespace DentalMain
{

    #region Класс главной формы

    public partial class MainForm : Form
    {
        

        #region Создание компонентов, работа с элементами формы, файлами хмл, доп переменные

        public MainForm() //Ініціалізація компонентів форми
        {
 
            InitializeComponent();
        }
        bool checker = false;
        TreeNode am = null;
        readonly CreatorForms mf = new CreatorForms();
        properties prop = new properties();
        readonly ApplicationWork work = new ApplicationWork();
        int Point = 0;
        public delegate void frst(); //Делегати для роботи з потоками
        public delegate void second();
        private void MainForm_Load(object sender, EventArgs e)
        {
            FindWhatToUpdate();
            helpProvider1.HelpNamespace = Application.StartupPath + "//Help//help.chm";
        }
        public void ChangeStBr(string text)  //Зміна статус бару
        {
            toolStripStatusLabel1.Text = text;
        }
        public void SaveProp(int a, int b) //Збереження у файл поточних налаштувань у програмі
        {
            prop.DocID = a;
            prop.Mode = b;
            work.SaveProperties(prop);
            MainTab.SelectedIndex = 0;
            FindWhatToUpdate();
            ChekDataView.Checked = false;
        }

        public void CloseBtnUpdate() //refresh btn off
        {
            UpdButton.Enabled = false;
        }
        public void OpenBtnUpdate() //Refresh btn on
        {
            UpdButton.Enabled = true;
        }

        private void ChangeView_CheckedChanged(object sender, EventArgs e) //Зміна стану перемикача виду
        {
            if (ChangeView.Checked == true)
            {
                MainTab.Visible = true;
                CloserWindows();
            }
            else
            {
                MainTab.Visible = false;
                CloserWindows();
            }
        }
        public void CloserWindows()
        {
            if (Application.OpenForms.Count>1) closeWind.Enabled = true;
            else closeWind.Enabled = false;
        }
        #endregion
        //Done

        #region Вызов форм из класса

        private void журналЗаписуToolStripMenuItem_Click(object sender, EventArgs e) //Виклик форми Журнал запису
        {
            ChangeView.Checked = false;
            mf.RecordLogForm(prop.DocID);
        }
        private void пацієнтиToolStripMenuItem_Click(object sender, EventArgs e) //Виклик форми Пацієнти
        {
            ChangeView.Checked = false;
            mf.PatientForm();
        }
        private void лікаріToolStripMenuItem_Click(object sender, EventArgs e) //Виклик форми Лікарі
        {
            ChangeView.Checked = false;
            mf.DoctorForm();
        }
        private void BtnGetPat_Click(object sender, EventArgs e) //Виклик форми для вибору пацієнта з форми Пацієнти
        {
            Patient f = new Patient();
            f.ShowDialog();
        }
        private void ChangeBtn_Click(object sender, EventArgs e)  //Форма зміни даних про пацієнта (виклик)
        {
            mf.ChangePatientFormDialog((int)comboBox1.SelectedValue);
        }
        private void налаштуванняToolStripMenuItem_Click(object sender, EventArgs e) //Форма налаштування (виклик)
        {
            if(mf.SettingsAppFormDialog(prop) ==DialogResult.OK)
            {
                if (Application.OpenForms["SettingsApp"] is SettingsApp f) f.Close();
                this.CloserWindows();
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)  //Додавання пацієнту (виклик, через форму)
        {
            Point = mf.PatientAddFormDialog();
            UpdatePatient();
        }
        private void ПослугиЗаПосадоюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeView.Checked = false;
            mf.ServicesAndPostsForm();
        }

        private void ДодатиПосадуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeView.Checked = false;
            mf.PostsForm();
        }

        private void ДодатиМатеріалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeView.Checked = false;
            mf.MaterialsForm();
        }

        private void МатеріалиЗаПослугоюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeView.Checked = false;
            mf.MaterialsAndServicesFrom();
        }

        private void редагуванняПослугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeView.Checked = false;
            mf.ServicesForm();
        }
        private void прийомиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeView.Checked = false;
            mf.AppointmentsForm(-1,true);
        }
        private void PatAppointm_Click(object sender, EventArgs e)
        {
            ChangeView.Checked = false;
            if (comboBox1.Text != "") mf.AppointmentsForm((int)comboBox1.SelectedValue, false);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeView.Checked = false;
            mf.AppointmentsForm((int)AppointBox.SelectedValue,true);
            
        }

        #endregion 
        //Done

        #region Обновление данных

        private void UpdBtn_Click(object sender, EventArgs e)
        {
            FindWhatToUpdate();
        }  //Кнопка обновления на основе текущей вкладки

        private void MainTab_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (comboBox1.SelectedValue == null)
                e.Cancel = true;
        } //Отмена выбора вкладок если пациент пуст

        private void MainTab_Selected(object sender, TabControlEventArgs e)  //Виключення/включення кнопки перемикача для зміни відображення записів стосовно одного або декількох лікарів
        {
            if (e.TabPageIndex >= 1 && e.TabPageIndex <= 6)
                ChekDataView.Enabled = true;
            else ChekDataView.Enabled = false;
            if (e.TabPageIndex != 0)
            {
                FindWhatToUpdate();
            }
        }

        public void FindWhatToUpdate()
        {
            DocUpdate();
            if (MainTab.SelectedIndex == 0)
            {
                if (comboBox1.SelectedItem != null)
                    Point = (int)comboBox1.SelectedValue;
                comboBox1.BeginUpdate();
                UpdatePatient();
                comboBox1.EndUpdate();
                if (comboBox1.Text == "" && comboBox1.Items.Count != 0) comboBox1.SelectedIndex = 0;
            }
            else if (MainTab.SelectedIndex == 1) ComplUpdate();
            else if (MainTab.SelectedIndex == 2) AnamnUpdate();
            else if (MainTab.SelectedIndex == 3) PlnLtsUpdate();
            else if (MainTab.SelectedIndex == 4) AnamnDisUpdate();
            else if (MainTab.SelectedIndex == 5) DiagUpdate();
            else if (MainTab.SelectedIndex == 6) AppointmentUpdate();
            CloserWindows();
        }   //Найти, что обновить

        public void ComplUpdate()
        {
            this.complaintsTableAdapter.Fill(this.dBDS.complaints);
            this.possibleComplTableAdapter.Fill(this.dBDS.possibleCompl);
            UpdateComplaints();
            CheckComplTree();
            patientscomplaintsBindingSource.Sort = "date_compl DESC";
        }

        public void AnamnUpdate()
        {
            this.diseases_anamTableAdapter.Fill(dBDS.diseases_anam);
            this.anamnesisTableAdapter.Fill(this.dBDS.anamnesis);
            FillTheAnamn();
        }

        public void AppointmentUpdate()
        {
            FillAppoint();
            AppointFillTree();
            MatTree.Nodes.Clear();
            patientsappointmentBindingSource.Filter = "date_appointm=#" + String.Format("{0: MM-dd-yyyy}", DateTime.Today) + "# and Cancel=false" + (ChekDataView.Checked? " and doctor='" + prop.DocID + "'":"");
            HealingTreeFill();
            foreach (dBDS.appointmentRow f in dBDS.appointment.Select("date_appointm=#" + String.Format("{0: MM-dd-yyyy}", DateTime.Today) + "# and Cancel=false and patient='" + comboBox1.SelectedValue + "'"))
            {
                if (f.time.TimeOfDay <= DateTime.Now.TimeOfDay)
                    AppointBox.SelectedValue = f.id_appointment;
            }
            if (AppointBox.Text != "" && HealingTreeDiag.SelectedNode != null) CheckAppointmChoose(true);
            else if (patientsappointmentBindingSource.Count != 0)
            {
                CheckAppointmChoose(false); button3.Enabled = true;
            }
            else CheckAppointmChoose(false);
        }

        public void AnamnDisUpdate()
        {
            this.anamndis_diseasesTableAdapter.Fill(dBDS.anamndis_diseases);
            this.anamnesisDiseasesTableAdapter.Fill(dBDS.anamnesisDiseases);
            AnamnDisTreeFill();
            AnamnDisTreeCheck();
        }

        public void DiagUpdate()
        {
            this.diagnosisTableAdapter.Fill(dBDS.diagnosis);
            this.diags_patientTableAdapter.Fill(dBDS.diags_patient);
            DiagFill();
        }

        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)  //Удаление из дерева
        {
            if (sender is ToolStripMenuItem mn)
            {
                string jeimi = (mn.Owner as ContextMenuStrip).SourceControl.Name;
                if (jeimi == "treeViewAnamn") this.diseases_anamTableAdapter.Delete(Convert.ToInt32(am.Name), am.Text.ToLower(), typeOfAnamn.Text);
                else if (jeimi == "treeViewcompl") this.possibleComplTableAdapter.Delete(Convert.ToInt32(am.Name), am.Text.ToLower());
                else if (jeimi == "PlnLtsTree") this.possiblePltsTableAdapter.Delete(Convert.ToInt32(am.Name), am.Text.ToLower());
                else if (jeimi == "treeViewanamndis") this.anamndis_diseasesTableAdapter.Delete(Convert.ToInt32(am.Name), am.Text.ToLower());
                else if (jeimi == "treeViewDiag")
                {
                    this.diagnosisTableAdapter.Delete(Convert.ToInt32(am.Name), am.Text.ToLower());
                    DeleteDiagFromAppointm(Convert.ToInt32(am.Name));
                }
                FindWhatToUpdate();
            }
        }
        public void DeleteDiagFromAppointm(int diagid)
        {
            foreach (dBDS.appointment_servicesRow f in dBDS.appointment_services.Select("appointm_diagnosis='" + diagid + "'"))
                f.Delete();
            this.appointment_servicesTableAdapter.Update(dBDS.appointment_services);
        }
        private void ЗмінитиToolStripMenuItem_Click(object sender, EventArgs e)   //изменение элемента списка
        {
            if (sender is ToolStripMenuItem mn)
            {
                string jeimi = (mn.Owner as ContextMenuStrip).SourceControl.Name;
                if (jeimi == "treeViewAnamn") { if (mf.AnamnezAnthrFormDialog(am, typeOfAnamn.Text)) FindWhatToUpdate(); }
                else if (jeimi == "treeViewcompl") { if (mf.ComplaintsFormDialog(am)) FindWhatToUpdate(); }
                else if (jeimi == "PlnLtsTree") { if (mf.PlanLetsFormDialog(am)) FindWhatToUpdate(); }
                else if (jeimi == "treeViewanamndis") { if (mf.AnamnezDiseaseFormDialog(am)) FindWhatToUpdate(); }
                else if (jeimi == "treeViewDiag") { if (mf.DiagnosisFormDialog(am)) FindWhatToUpdate(); }
            }
        } 

        #endregion 
        //Done

        #region Касаемо Доктор
        public void DocUpdate()
        {
            doctorsTableAdapter.Fill(dBDS.doctors);
            prop = work.FileInitialization(prop);
            Namingform();
        }
        public void Namingform()  //Формування назви головної форми та блокування функцій в залежності від режиму роботи
        {
            try
            {
                Text = "Додаток Стоматологія: " + dBDS.doctors.FindByid_doctor(prop.DocID).full_name;
                MainTab.Enabled = true;
            }
            catch
            {
                Text = "Додаток Стоматологія: Не обран лікар"; prop.Mode = 1;
                MainTab.Enabled = false;
            }
        }
        public void DocInit() //Зчитування або створення файлу з налаштуваннями режиму та доктора для програми
        {
            prop = work.FileInitialization(prop);
            Namingform();
        }

        #endregion
        //Done

        #region Касаемо Пациент


        public void UpdatePatient()
        {
            try { Point = (int)comboBox1.SelectedValue; } catch { Point = 0; }
            if (TodayRad.Checked == true)
            {
                this.patientsTableAdapter.FillbyApp(this.dBDS.patients, DateTime.Now.Date, prop.DocID);
                AddBtn.Enabled = false; BtnGetPat.Enabled = false;
            }
            else
            {
                this.patientsTableAdapter.Fill(this.dBDS.patients); AddBtn.Enabled = true; BtnGetPat.Enabled = true;
            }
            appointmentTableAdapter.Fill(dBDS.appointment);
            if (Point > 0) ChangePat();
            else if (Point == -1) IntForPatAdd();
            ChangeBtnEnabled();
            ChangeLbls();
        }
        //Обновление даных пациентов с учетом переключателя и переход на указаную индексом запись
        public void UpdatePatient(int index)
        {
            if (TodayRad.Checked == true)
            {
                this.patientsTableAdapter.FillbyApp(this.dBDS.patients, DateTime.Now.Date, prop.DocID);
                AddBtn.Enabled = false; BtnGetPat.Enabled = false;
            }
            else
            {
                this.patientsTableAdapter.Fill(this.dBDS.patients); AddBtn.Enabled = true; BtnGetPat.Enabled = true;
            }
            comboBox1.SelectedValue = index;
            ChangeBtnEnabled();
        }
        public void ChangeBtnEnabled()
        {
            if (comboBox1.Text == "")
            {
                ChangeBtn.Enabled = false;
                RengBtn.Enabled = false;
                BtnAppointm.Enabled = false;
                PatAppointm.Enabled = false;
            }
            else
            {
                ChangeBtn.Enabled = true;
                RengBtn.Enabled = true;
                BtnAppointm.Enabled = true;
                PatAppointm.Enabled = true;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FindWhatToUpdate();
        }
        public void ChangePat()  //Зміна пацієнту в полі Пацієнт
        {
            comboBox1.SelectedValue = Point;
            Point = 0;
        }
        public void IntForPatAdd() // Обирання Пацієнта після додавання
        {
            Point = 0;
            comboBox1.SelectedIndex = (int)comboBox1.Items.Count - 1;
        }
        public void GoToMF(int jk)    //Інтерфейс взаємодії який використовується формою Пацієнти
        {
            Point = jk;
            UpdatePatient();
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                ChangeLbls();
                ChangeBtnEnabled();
            }
        }
        public void ChangeLbls()   //Знаходження даних пацієнта та відображення їх на вкладці у підписах
        {
            dBDS.patientsRow a = null;
            try
            {
                a = dBDS.patients.FindByid_patient((int)comboBox1.SelectedValue);
            }
            catch
            {
                toolStripPat.Text = "Не обрано";
                label3.Text = "Дата народження: Немає"; label2.Text=toolNumtel.Text = "Номер телефону: Немає"; return;
            }
            if (a.Isphone_numberNull()==false || a.phone_number !="") label2.Text = toolNumtel.Text = "Номер телефону: " + a.phone_number;
            else label2.Text = toolNumtel.Text = "Номер телефону: Немає";
            try
            {
                if (a.date_of_birth != null) label3.Text = "Дата народження: " + String.Format("{0:dd.MM.yyyy}", a.date_of_birth);
                else label3.Text = "Дата народження: Немає";
            }
            catch { label3.Text = "Дата народження: Немає"; }
            toolStripPat.Text = a.full_name;
            FindPaidedCost();
        }
        private void ChekDataView_CheckedChanged(object sender, EventArgs e)   //Зміна відображення записів стосовно одного або декількох лікарів
        {
            if (ChekDataView.Checked)
            {
                patientscomplaintsBindingSource.Filter = "[doctor]='" + prop.DocID + "'";
                patientsdiagspatientBindingSource.Filter = "[doctor]='" + prop.DocID + "'";
                patientsplanletsBindingSource.Filter = "[doctor]='" + prop.DocID + "'";
                patientsanamnesisDiseasesBindingSource.Filter = "[doctor]='" + prop.DocID + "'";
                patientsappointmentBindingSource.Filter = "[doctor]='" + prop.DocID + "'";
                FindWhatToUpdate();
            }
            else
            {
                patientscomplaintsBindingSource.Filter = "";
                patientsdiagspatientBindingSource.Filter = "";
                patientsplanletsBindingSource.Filter = "";
                patientsanamnesisDiseasesBindingSource.Filter = "";
                patientsappointmentBindingSource.Filter = "";
                FindWhatToUpdate();
            }
        }
        public void UpdateWithSavePos()
        {
            try
            {
                Point = (int)comboBox1.SelectedValue; UpdatePatient();
                MainTab.SelectedIndex = 0;
            }
            catch { return; }
        }
        private void RengBtn_Click(object sender, EventArgs e)
        {
            work.InitPatDir((int)comboBox1.SelectedValue,comboBox1.Text);
        }
        private void BtnAppointm_Click(object sender, EventArgs e)
        {
            WaitPlsForm former = new WaitPlsForm(); former.Owner = this;
            former.Show();
            Word.Application fm = new Word.Application();
            Word.Document objdoc = fm.Documents.Add();
            Word.Paragraph objpar = objdoc.Paragraphs.Add();
            objpar.Range.Font.Name = "Times New Roman";
            objpar.Range.Font.Size = 14;
            objpar.Range.Text = "Пацієнт: " + comboBox1.Text + "\n";objpar.Range.Font.Size = 14;
            objpar.Range.Font.Name = "Times New Roman";
            anamnesisTableAdapter.Fill(dBDS.anamnesis);
            diseases_anamTableAdapter.Fill(dBDS.diseases_anam);
            this.diagnosisTableAdapter.Fill(dBDS.diagnosis);
            this.diags_patientTableAdapter.Fill(dBDS.diags_patient);
            string promperm = "";
            foreach (dBDS.anamnesisRow f in dBDS.anamnesis.Select("patient='" + comboBox1.SelectedValue + "' and type_anamn='Життя'"))
            {
                promperm += f.diseases_anamRow.disease_name+", ";
            }
            if(promperm!="")objpar.Range.Text += "Анамнез життя: "+promperm.Substring(0, promperm.Length - 2) + ".";
            promperm = "";
            foreach (dBDS.anamnesisRow f in dBDS.anamnesis.Select("patient='" + comboBox1.SelectedValue + "' and type_anamn='Алергологічний'"))
            {
                promperm += f.diseases_anamRow.disease_name + ", ";
            }
            if(promperm!="")objpar.Range.Text += "Анамнез алергологічний: "+promperm.Substring(0, promperm.Length - 2) + ".";
            promperm = "";
            foreach (dBDS.diags_patientRow f in dBDS.diags_patient.Select("patient='" + comboBox1.SelectedValue +"'"))
            {
                promperm += f.diagnosisRow.name_diag + (f.tooth == "" ? ", " : ", зуб(ы): " + f.tooth + ", ");
            }
            if (promperm != "") objpar.Range.Text += "Перелік всіх діагнозів: " + promperm.Substring(0, promperm.Length - 2) + ".";

            this.appointmentTableAdapter.Fill(dBDS.appointment);
            objpar.Range.Font.Size = 14;
            objpar.Range.Text += "\rСписок відвідувань:";
            
            objpar.Range.Bold = 3;
            
            this.possibleComplTableAdapter.Fill(dBDS.possibleCompl);
            this.complaintsTableAdapter.Fill(dBDS.complaints);
            this.anamndis_diseasesTableAdapter.Fill(dBDS.anamndis_diseases);
            this.anamnesisDiseasesTableAdapter.Fill(dBDS.anamnesisDiseases);
            
            servicesTableAdapter.Fill(dBDS.services);
            appointment_servicesTableAdapter.Fill(dBDS.appointment_services);
            Word.Paragraph objpar2 = objdoc.Paragraphs.Add();
            foreach (dBDS.appointmentRow f in dBDS.appointment.Select("patient='" + comboBox1.SelectedValue + "' and Cancel=false and Started=true"))
            {
                objpar2.Range.Text += "________________________________________________________";
                objpar2.Range.Font.Size = 11;
                string date = String.Format("{0: MM-dd-yyyy}", f.date_appointm.Date);
                objpar2.Range.Text += ("ЛІКУВАННЯ ВІД" + String.Format("{0: dd.MM.yyyy}", f.date_appointm.Date) + String.Format("{0: HH:mm}", f.time)).ToString();
                objpar2.Range.Font.Size = 20;
                objpar2.Range.Bold = 3;
                string frm = "";
                foreach (dBDS.complaintsRow m in dBDS.complaints.Select("patient='" + comboBox1.SelectedValue + "' and date_compl=#" + date + "#"))
                {
                    frm += m.possibleComplRow.description_compl + ", ";
                }
                if (frm != "")
                {
                    objpar2.Range.Text += "СКАРГИ: ";
                    objpar2.Range.Bold = 3;
                    objpar2.Range.Font.Size = 11;
                    objpar2.Range.Text+=frm.Substring(0, frm.Length - 2) + ".";
                    objpar2.Range.Bold = 0;
                }
                frm = "";
                foreach (dBDS.anamnesisDiseasesRow m in dBDS.anamnesisDiseases.Select("patient='" + comboBox1.SelectedValue + "' and date_anamndis=#" + date + "#"))
                {
                    frm += m.anamndis_diseasesRow.name_disease + ", ";
                }
                if (frm != "")
                {
                    objpar2.Range.Text += "АНАМНЕЗ ХВОРОБИ ЗА ЦЕЙ ДЕНЬ: ";
                    objpar2.Range.Bold = 3;
                    objpar2.Range.Font.Size = 11;
                    objpar2.Range.Text += frm.Substring(0, frm.Length - 2) + ".";
                    objpar2.Range.Bold = 0;
                }

                frm = "";
                foreach (dBDS.diags_patientRow m in dBDS.diags_patient.Select("patient='" + comboBox1.SelectedValue + "' and find_date=#" + date + "#"))
                {
                    frm += m.diagnosisRow.name_diag + (m.tooth == "" ? ", " : ", зуб(и): " + m.tooth + ", ");
                }
                if (frm != "")
                {
                    objpar2.Range.Text += "ДІАГНОЗИ ЗА ЦЕЙ ДЕНЬ: ";
                    objpar2.Range.Bold = 3;
                    objpar2.Range.Font.Size = 11;
                    objpar2.Range.Text += frm.Substring(0, frm.Length - 2) + ".";
                    objpar2.Range.Bold = 0;
                }
                frm = "";
                objpar2.Range.Text += "ПОСЛУГИ: ";
                objpar2.Range.Bold = 3;
                objpar2.Range.Font.Size = 11;
                foreach (dBDS.diags_patientRow m in dBDS.diags_patient.Select("patient='" + comboBox1.SelectedValue + "'"))
                {
                    foreach (dBDS.appointment_servicesRow no in dBDS.appointment_services.Select("appoinment='" + f.id_appointment + "' and appointm_diagnosis='" + m.id_diag_patient + "'"))
                    {
                        frm += dBDS.services.FindByid_service(no.service).name_service + ", ";
                    }
                    if (frm != "")
                    {
                        objpar2.Range.Text += "ПО ДІАГНОЗУ: "+m.diagnosisRow.name_diag + " ПОСЛУГИ:" ;
                        objpar2.Range.Bold = 0;
                        objpar2.Range.Text+= frm.Substring(0, frm.Length - 2)+"."; 
                        frm = "";
                    }
                }
            }
            work.InitDaysheetDir((int)comboBox1.SelectedValue, comboBox1.Text);
            try { objdoc.SaveAs2(Path.GetDirectoryName(Application.ExecutablePath) + @"\Пацієнти\" + comboBox1.SelectedValue + "_" + comboBox1.Text + @"\Щоденник лікування\Щоденник лікування.doc"); objdoc.Close(); fm.Application.Quit(); former.Close(); }
            catch { MessageBox.Show("Сталася помилка при збережені документу, можливо він знаходиться у відкритому стані!"); try { fm.Application.Quit(); former.Close(); } catch { former.Close(); } }

        }
        public void FindPaidedCost()
        {
            if (comboBox1.Text != "")
            {
                dBDS.patientsRow f = dBDS.patients.FindByid_patient((int)comboBox1.SelectedValue);
                decimal fulcostsum=0, paidedsum=0;
                foreach(dBDS.appointmentRow m in dBDS.appointment.Select("patient='"+f.id_patient+"' and doctor='"+prop.DocID+"' and started=true"))
                {
                    fulcostsum += m.full_cost;
                    if (f.debt < 0)
                    {
                        if (f.debt + (m.full_cost - m.paided) < (decimal)0)
                        { f.debt += (m.full_cost - m.paided); m.paided = m.full_cost; }
                        else
                        {
                           m.paided -= f.debt;
                           f.debt -= f.debt;
                        }
                    }
                    paidedsum += m.paided;
                }
                if (fulcostsum - paidedsum > 0)
                { 
                    labelDolg.Text = String.Format("{0: #.##}",fulcostsum-paidedsum);
                }
                else if(f.debt<0)
                {
                    labelDolg.Text = String.Format("{0: #.##}", f.debt);
                }
            }
            try
            {
                this.patientsTableAdapter.Update(dBDS.patients);
                this.appointmentTableAdapter.Update(dBDS.appointment);
            }
            catch { App.Text = "Помилка!";  FindWhatToUpdate(); }
        }

        private void AddPaided_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(textBox2.Text, out decimal ValForAdd);
            dBDS.patientsRow m = dBDS.patients.FindByid_patient((int)comboBox1.SelectedValue);
            m.debt += ValForAdd*(-1);
            FindPaidedCost();
        }
        #endregion
        //almst

        #region Вкладка Жалобы


        private void BtnAddComplaint_Click(object sender, EventArgs e)   //Додавання скарги
        {
            if (ComplText.Text != "")
            {
                if (dBDS.possibleCompl.Select("description_compl='" + ComplText.Text + "'").Count() == 0)
                {
                    this.possibleComplTableAdapter.Insert(ComplText.Text.ToLower());
                    this.possibleComplTableAdapter.Fill(dBDS.possibleCompl);
                    treeViewcompl.BeginUpdate();
                    treeViewcompl.Nodes.Add(dBDS.possibleCompl.Last().id_compl.ToString(), dBDS.possibleCompl.Last().description_compl).Checked = true;
                    ComplText.AutoCompleteCustomSource.Add(dBDS.possibleCompl.Last().description_compl);
                    treeViewcompl.EndUpdate();
                }

                else if (dBDS.complaints.Select("patient='" + (int)comboBox1.SelectedValue + "' and complaint='" + dBDS.possibleCompl.FindByid_compl(Convert.ToInt32(treeViewcompl.Nodes[ComplText.AutoCompleteCustomSource.IndexOf(ComplText.Text.ToLower())].Name)).id_compl + "' and date_compl=#" + String.Format("{0: MM-dd-yyyy}", DateTime.Now.Date) + "# and doctor='" + prop.DocID + "'").Count() == 0)
                {
                    treeViewcompl.BeginUpdate();
                    foreach (dBDS.possibleComplRow a in dBDS.possibleCompl.Select("description_compl='" + ComplText.Text.ToLower() + "'"))
                    {
                        treeViewcompl.Nodes[a.id_compl.ToString()].Checked = true;
                    }
                    treeViewcompl.EndUpdate();
                }
                else App.Text = "Такий запис на сьогодні вже існує";
            }
            else
                App.Text = "Не введена, або не правильно введена скарга";
        }

        public void UpdateComplaints()
        {
            treeViewcompl.BeginUpdate();
            treeViewcompl.Nodes.Clear();
            ComplText.AutoCompleteCustomSource.Clear();
            List<TreeNode> Tree = new List<TreeNode>();
            List<string> Search = new List<string>();
            foreach (dBDS.possibleComplRow a in dBDS.possibleCompl)
            {
                Tree.Add(new TreeNode(a.description_compl.ToLower()) { Name = a.id_compl.ToString() });
                Search.Add(a.description_compl.ToLower());
            }
            treeViewcompl.Nodes.AddRange(Tree.ToArray());
            ComplText.AutoCompleteCustomSource.AddRange(Search.ToArray());
            treeViewcompl.EndUpdate();
        }

        public void UnchComplTree()
        {
            checker = true;
            foreach (TreeNode a in treeViewcompl.Nodes)
            {
                a.Checked = false;
            }
            checker = false;
        }
        public void CheckComplTree()
        {
            checker = true;
            foreach (dBDS.complaintsRow a in dBDS.complaints.Select("patient='" + (int)comboBox1.SelectedValue + "' and date_compl=#" + String.Format("{0: MM-dd-yyyy}", DateTime.Now.Date) + "# and doctor='" + prop.DocID + "'"))
            {
                treeViewcompl.Nodes[a.complaint.ToString()].Checked = true;
            }
            checker = false;
        }
        private void treeViewcompl_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (checker == false && e.Node.Checked == true)
            {
                if (dBDS.complaints.Select("patient='" + (int)comboBox1.SelectedValue + "' and complaint='" + e.Node.Name + "' and date_compl=#" + String.Format("{0: MM-dd-yyyy}", DateTime.Now.Date) + "# and doctor='" + prop.DocID + "'").Count() > 0)
                {
                    App.Text = "Такая запись с сегодняшней датой уже существует";
                }
                else
                {
                    this.complaintsTableAdapter.Insert(Convert.ToInt32(e.Node.Name), (int)comboBox1.SelectedValue, DateTime.Today, prop.DocID);
                    this.complaintsTableAdapter.Fill(dBDS.complaints);
                }
            }
            else if (checker == false && e.Node.Checked == false)
            {
                foreach (dBDS.complaintsRow a in dBDS.complaints.Select("patient='" + (int)comboBox1.SelectedValue + "' and complaint='" + e.Node.Name + "' and date_compl=#" + String.Format("{0: MM-dd-yyyy}", DateTime.Now.Date) + "# and doctor='" + prop.DocID + "'"))
                { this.complaintsTableAdapter.Delete(a.id_compl, a.patient, a.date_compl, a.doctor); }
                this.complaintsTableAdapter.Fill(dBDS.complaints);
            }
        }
        private void DataGridComplaints_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void ComplText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                BtnAddComplaint_Click(sender, new EventArgs());
        }
        #endregion
        //Done

        #region Вкладка Анамнез жизни и аллергологический


        public void FillTheAnamn()
        {
            patientsanamnesisBindingSource.Filter = "type_anamn='" + typeOfAnamn.Text + "'";
            treeViewAnamn.BeginUpdate();
            treeViewAnamn.Nodes.Clear();
            AnamnSearch.AutoCompleteCustomSource.Clear();
            List<TreeNode> Tree = new List<TreeNode>();
            List<string> Search = new List<string>();
            foreach (dBDS.diseases_anamRow m in dBDS.diseases_anam.Select("type_anamn='" + typeOfAnamn.Text + "'"))
            {
                Tree.Add(new TreeNode(m.disease_name.ToLower()){ Name = m.id_disease_anam.ToString() });
                Search.Add(m.disease_name.ToLower());
            }
            treeViewAnamn.Nodes.AddRange(Tree.ToArray());
            AnamnSearch.AutoCompleteCustomSource.AddRange(Search.ToArray());
            CheckTreeAnamn();
            treeViewAnamn.EndUpdate();
        }


        private void typeOfAnamn_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnamnUpdate();
        }

        private void BtnAddAnm_Click(object sender, EventArgs e)
        {
            if (dBDS.diseases_anam.Select("type_anamn='" + typeOfAnamn.Text + "' and disease_name='" + AnamnSearch.Text + "'").Count() == 0)
            {
                if (AnamnSearch.Text != "")
                {
                    this.diseases_anamTableAdapter.Insert(AnamnSearch.Text.ToLower(), typeOfAnamn.Text);
                    this.diseases_anamTableAdapter.Fill(dBDS.diseases_anam);
                    AnamnSearch.AutoCompleteCustomSource.Add(AnamnSearch.Text.ToLower());
                    treeViewAnamn.Nodes.Add(dBDS.diseases_anam.Last().id_disease_anam.ToString(), AnamnSearch.Text.ToLower()).Checked = true;
                }
                else App.Text = "Не було введено захворювання!";
            }
            else
            {
                if (AnamnSearch.Text != "")
                {
                    int anid = Convert.ToInt32(treeViewAnamn.Nodes[AnamnSearch.AutoCompleteCustomSource.IndexOf(AnamnSearch.Text.ToLower())].Name);
                    if (dBDS.anamnesis.Select("type_anamn='" + typeOfAnamn.Text
                        + "' and name_disease='" + anid
                        + "' and patient='" + comboBox1.SelectedValue + "'").Count() == 0)
                    {
                        treeViewAnamn.Nodes[anid.ToString()].Checked = true;
                    }
                    else App.Text = "Цей запис вже існує!";
                }
                else App.Text = "Не було введено захворювання!";
            }
        }

        private void treeViewAnamn_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (checker == false)
            {
                if (e.Node.Checked)
                {
                    this.anamnesisTableAdapter.Insert(Convert.ToInt32(e.Node.Name), (int)comboBox1.SelectedValue, typeOfAnamn.Text);
                }
                else
                {
                    foreach (dBDS.anamnesisRow f in dBDS.anamnesis.Select("type_anamn='" + typeOfAnamn.Text + "' and name_disease='" + e.Node.Name + "' and patient='" + (int)comboBox1.SelectedValue + "'"))
                    {
                        this.anamnesisTableAdapter.DeleteQuery(f.id_anam, f.name_disease, f.patient, f.type_anamn);
                    }
                }
                this.anamnesisTableAdapter.Fill(dBDS.anamnesis);
            }
        }
        public void CheckTreeAnamn()
        {
            checker = true;
            treeViewAnamn.BeginUpdate();
            foreach (dBDS.anamnesisRow r in dBDS.anamnesis.Select("type_anamn='" + typeOfAnamn.Text + "' and patient='" + (int)comboBox1.SelectedValue + "'"))
            {
                treeViewAnamn.Nodes[r.name_disease.ToString()].Checked = true;
            }
            treeViewAnamn.EndUpdate();
            checker = false;
        }
        private void AnamnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) BtnAddAnm_Click(sender, new EventArgs());
        }

        #endregion
        //Done

        #region  Вкладка План лечения пациента 

        //План лікування


        public void PlnLtsUpdate()
        {
            FillPlnLts();
        }
        public void FillPlnLts()
        {
            this.possiblePltsTableAdapter.Fill(dBDS.possiblePlts);
            this.planletsTableAdapter.Fill(dBDS.planlets);
            FillPlnLtsTree();
        }
        public void FillPlnLtsTree()
        {
            PlnLtsTree.BeginUpdate();
            PlnLtsTree.Nodes.Clear();
            PlnLtsSearch.AutoCompleteCustomSource.Clear();
            List<TreeNode> Tree = new List<TreeNode>();
            List<string> Search = new List<string>();
            foreach (dBDS.possiblePltsRow m in dBDS.possiblePlts)
            {
                Tree.Add(new TreeNode(m.name_plts.ToLower()) { Name = m.id_possiblPlts.ToString() });
                Search.Add(m.name_plts.ToLower());
            }
            PlnLtsSearch.AutoCompleteCustomSource.AddRange(Search.ToArray());
            PlnLtsTree.Nodes.AddRange(Tree.ToArray());
            PlnLtsTree.EndUpdate();
        }

        private void PlnLtsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PlnLtsSearch.Text = e.Node.Text;
        }

        private void BtnAddPlnLts_Click(object sender, EventArgs e)
        {
            if (dBDS.possiblePlts.Select("name_plts='" + PlnLtsSearch.Text + "'").Count() == 0)
            {
                if (PlnLtsSearch.Text != "")
                {
                    this.possiblePltsTableAdapter.Insert(PlnLtsSearch.Text.ToLower());
                    this.possiblePltsTableAdapter.Fill(dBDS.possiblePlts);
                    PlnLtsSearch.AutoCompleteCustomSource.Add(PlnLtsSearch.Text.ToLower());
                    PlnLtsTree.Nodes.Add(dBDS.possiblePlts.Last().id_possiblPlts.ToString(), PlnLtsSearch.Text.ToLower());
                    this.planletsTableAdapter.Insert(PlnLtsTooth.Text,
                        Convert.ToInt32(PlnLtsTree.Nodes[PlnLtsSearch.AutoCompleteCustomSource.IndexOf(PlnLtsSearch.Text.ToLower())].Name),
                        PlnLtsDateTime.Value.Date, (int)comboBox1.SelectedValue, prop.DocID);
                    this.planletsTableAdapter.Fill(dBDS.planlets);
                }
                else App.Text = "Не було введено запис плану!";
            }
            else
            {
                if (PlnLtsSearch.Text != "")
                {
                    int anid = Convert.ToInt32(PlnLtsTree.Nodes[PlnLtsSearch.AutoCompleteCustomSource.IndexOf(PlnLtsSearch.Text.ToLower())].Name);
                    if (dBDS.planlets.Select("tooth='" + PlnLtsTooth.Text
                        + "' and description='" + anid
                        + "' and patient='" + comboBox1.SelectedValue + "' and doctor='" + prop.DocID + "' and date_pln=#" + String.Format("{0: MM-dd-yyyy}", DateTime.Today) + "#").Count() == 0)
                    {
                        this.planletsTableAdapter.Insert(PlnLtsTooth.Text, anid, PlnLtsDateTime.Value.Date, (int)comboBox1.SelectedValue, prop.DocID);
                    }
                    this.planletsTableAdapter.Fill(dBDS.planlets);
                }
                else App.Text = "Не було введено запис плану!";
            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            planletsTableAdapter.Update(dBDS.planlets);
        }
        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.planletsTableAdapter.Update(dBDS.planlets);
        }

        private void PlnLtsSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAddAnmdis_Click(sender, new EventArgs());
            }
        }
        #endregion
        //Done

        #region Вкладка Анамнез Болезни

        public void AnamnDisTreeFill()
        {
            treeViewanamndis.BeginUpdate();
            treeViewanamndis.Nodes.Clear();
            AnmndisSearch.AutoCompleteCustomSource.Clear();
            List<TreeNode> Tree = new List<TreeNode>();
            List<string> Search = new List<string>();
            foreach (dBDS.anamndis_diseasesRow m in dBDS.anamndis_diseases)
            {
                Tree.Add(new TreeNode(m.name_disease.ToLower()) { Name = m.id_disease.ToString() });
                Search.Add(m.name_disease.ToLower());
            }
            treeViewanamndis.Nodes.AddRange(Tree.ToArray());
            AnmndisSearch.AutoCompleteCustomSource.AddRange(Search.ToArray());
            treeViewanamndis.EndUpdate();
        }


        private void DataGridView5_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            anamnesisDiseasesTableAdapter.Update(dBDS.anamnesisDiseases);
        }

        private void BtnAddAnmdis_Click(object sender, EventArgs e)
        {
            if (AnmndisSearch.Text != "")
            {
                if (dBDS.anamndis_diseases.Select("name_disease='" + AnmndisSearch.Text.ToLower() + "'").Count() == 0)
                {
                    this.anamndis_diseasesTableAdapter.Insert(AnmndisSearch.Text.ToLower());
                    anamndis_diseasesTableAdapter.Fill(dBDS.anamndis_diseases);
                    AnmndisSearch.AutoCompleteCustomSource.Add(AnmndisSearch.Text.ToLower());
                    treeViewanamndis.Nodes.Add(dBDS.anamndis_diseases.Last().id_disease.ToString(), AnmndisSearch.Text.ToLower()).Checked = true;
                }
                else
                {
                    int amn = AnmndisSearch.AutoCompleteCustomSource.IndexOf(AnmndisSearch.Text.ToLower());
                    if (treeViewanamndis.Nodes[amn].Checked == false)
                        treeViewanamndis.Nodes[amn].Checked = true;
                }
            }
            else App.Text = "Не було введено запис анамнезу!";
        }

        public void AnamnDisTreeCheck()
        {
            checker = true;
            foreach (dBDS.anamnesisDiseasesRow f in dBDS.anamnesisDiseases.Select("patient='" + comboBox1.SelectedValue + "' and date_anamndis=#"
                + String.Format("{0: MM-dd-yyyy}", DateTime.Today) + "#"))
            {
                treeViewanamndis.Nodes[f.disease.ToString().ToLower()].Checked = true;
            }
            checker = false;
        }

        private void TreeViewanamndis_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (checker == false)
            {
                if (e.Node.Checked)
                {
                    this.anamnesisDiseasesTableAdapter.Insert((int)comboBox1.SelectedValue, DateTime.Today, Convert.ToInt32(e.Node.Name),prop.DocID);
                }
                else
                {
                    foreach (dBDS.anamnesisDiseasesRow f in dBDS.anamnesisDiseases.Select("patient='" + comboBox1.SelectedValue + "' and date_anamndis=#"
                        + string.Format("{0: MM-dd-yyyy}", DateTime.Today) + "# and disease='" + e.Node.Name + "'"))
                    {
                        this.anamnesisDiseasesTableAdapter.Delete(f.id_ananmdis, f.patient, f.date_anamndis, f.disease,f.doctor);
                    }
                }
                this.anamnesisDiseasesTableAdapter.Fill(dBDS.anamnesisDiseases);
            }
        }
        private void AnmndisSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAddAnmdis_Click(sender, new EventArgs());
            }
        }


        #endregion
        //Done

        #region Диагноз

        private void DataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            diags_patientTableAdapter.Update(dBDS.diags_patient);
        }

        private void DiagnosisTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAddDiag_Click(sender, new EventArgs());
            }
        }

        private void BtnAddDiag_Click(object sender, EventArgs e)
        {
            if(diagnosisTextBox.Text!="")
            {
                int kf = diagnosisTextBox.AutoCompleteCustomSource.IndexOf(diagnosisTextBox.Text.ToLower());
                if(kf==-1)
                {
                    diagnosisTableAdapter.Insert(diagnosisTextBox.Text.ToLower());
                    diagnosisTableAdapter.Fill(dBDS.diagnosis);
                    diagnosisTextBox.AutoCompleteCustomSource.Add(diagnosisTextBox.Text.ToLower());
                    treeViewDiag.Nodes.Add(dBDS.diagnosis.Last().id_diag.ToString(), diagnosisTextBox.Text.ToLower());
                    diags_patientTableAdapter.Insert(dBDS.diagnosis.Last().id_diag, teethTextBox.Text, DateTime.Today, (int)comboBox1.SelectedValue, prop.DocID);
                }
                else
                {
                    int mkf = Convert.ToInt32(treeViewDiag.Nodes[kf].Name);
                    if (dBDS.diags_patient.Select("diagnosis='"+mkf+"' and tooth='"+teethTextBox.Text+"' and find_date=#"+String.Format("{0: MM-dd-yyyy}",DateTime.Today)+"# and patient='"+comboBox1.SelectedValue+"' and doctor='"+prop.DocID+"'").Count()==0)
                        diags_patientTableAdapter.Insert(Convert.ToInt32(treeViewDiag.Nodes[kf].Name), teethTextBox.Text, DateTime.Today, (int)comboBox1.SelectedValue, prop.DocID);
                }
                diags_patientTableAdapter.Fill(dBDS.diags_patient);
            }
            else { App.Text = "Не було введено діагноз!"; }
        }
        public void DiagFill()
        {
            treeViewDiag.BeginUpdate();
            treeViewDiag.Nodes.Clear();
            diagnosisTextBox.AutoCompleteCustomSource.Clear();
            List<TreeNode> Tree = new List<TreeNode>();
            List<string> Search = new List<string>();
            foreach (dBDS.diagnosisRow f in dBDS.diagnosis)
            {
                Tree.Add(new TreeNode(f.name_diag.ToLower()) { Name = f.id_diag.ToString() });
                Search.Add(f.name_diag.ToLower());
            }
            treeViewDiag.Nodes.AddRange(Tree.ToArray());
            diagnosisTextBox.AutoCompleteCustomSource.AddRange(Search.ToArray());
            treeViewDiag.EndUpdate();
        }

        private void TreeViewDiag_AfterSelect(object sender, TreeViewEventArgs e)
        {
            diagnosisTextBox.Text = e.Node.Text;
        }
        private void DataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DeleteDiagFromAppointm((int)e.Row.Cells[3].Value);
        }

        #endregion
        //Done

        #region Вкладка Лечение(обслуживание) пациентов

        public void FillAppoint()
        {
            this.servicesTableAdapter.Fill(dBDS.services);
            this.diagnosisTableAdapter.Fill(dBDS.diagnosis);
            this.diags_patientTableAdapter.Fill(dBDS.diags_patient);
            this.postTableAdapter.Fill(dBDS.post);
            this.post_servicesTableAdapter.Fill(dBDS.post_services);
            this.post_doctorTableAdapter.Fill(dBDS.post_doctor);
            this.appointmentTableAdapter.Fill(dBDS.appointment);
            this.appointment_servicesTableAdapter.Fill(dBDS.appointment_services);
            this.appointment_materialsTableAdapter.Fill(dBDS.appointment_materials);
            this.materialsTableAdapter.Fill(dBDS.materials);
            this.serv_materialTableAdapter.Fill(dBDS.serv_material);
        }

        public void CheckAppointmChoose(bool fa)
        {
            button3.Enabled = fa;
            for (int i = 0; i < tableLayoutPanel6.Controls.Count; i++)
                tableLayoutPanel6.Controls[i].Enabled = fa;
            tableLayoutPanel6.Controls["AppointBox"].Enabled = true;
            tableLayoutPanel6.Controls["label5"].Enabled = true;
            tableLayoutPanel6.Controls["label26"].Enabled = true;
            tableLayoutPanel6.Controls["HealingTreeDiag"].Enabled = true;
            tableLayoutPanel6.Controls["PaidGB"].Enabled = true;
          
        }

        public void AppointFillTree()
        {
            ServTree.BeginUpdate();
            ServTree.Nodes.Clear();
            ServSearch.AutoCompleteCustomSource.Clear();
            List<TreeNode> Tree = new List<TreeNode>();
            List<string> Search = new List<string>();
            foreach (dBDS.post_doctorRow f in dBDS.post_doctor.Select("doctor='" + prop.DocID + "'"))
            {
                foreach (dBDS.post_servicesRow m in dBDS.post_services.Select("post='" + f.post + "'"))
                {
                    if (ServTree.Nodes.IndexOfKey(m.service.ToString()) == -1)
                    {
                        Tree.Add(new TreeNode(m.servicesRow.name_service.ToLower()) { Name = m.service.ToString() });
                        Search.Add(m.servicesRow.name_service.ToLower());
                    }
                }
            }ServTree.Nodes.AddRange(Tree.ToArray());
            ServSearch.AutoCompleteCustomSource.AddRange(Search.ToArray());
            ServTree.EndUpdate();
        }
        private void ServTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FillMatTree();
        }

        public void FillMatTree()
        {
            MatTree.Nodes.Clear();
            foreach (dBDS.serv_materialRow f in dBDS.serv_material.Select("service='" + ServTree.SelectedNode.Name + "'"))
            {
                MatTree.Nodes.Add(f.material.ToString(), f.materialsRow.name_material);
            }
        }

        public int CountForMat { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            dBDS.appointmentRow j = dBDS.appointment.FindByid_appointment((int)AppointBox.SelectedValue);
            j.started = true;
            this.appointmentTableAdapter.Update(j);
            if (AppointBox.Text != "")
            {
                if (ServTree.SelectedNode != null && HealingTreeDiag.SelectedNode != null)
                {
                    this.appointment_servicesTableAdapter.Insert(prop.DocID, Convert.ToInt32(ServTree.SelectedNode.Name),
                        (int)AppointBox.SelectedValue, Convert.ToInt32(HealingTreeDiag.SelectedNode.Name), includesChkBx.Checked);
                    this.appointment_servicesTableAdapter.Fill(dBDS.appointment_services);
                    foreach (TreeNode m in MatTree.Nodes)
                    {
                        if (m.Checked)
                        {
                            Appointm_Material f = new Appointm_Material(ServTree.SelectedNode.Text, m.Text);
                            if (f.ShowDialog() == DialogResult.OK)
                            {
                                this.appointment_materialsTableAdapter.Insert(Convert.ToInt32(m.Name), dBDS.appointment_services.Last().id_app_serv, CountForMat);
                            }
                        }
                    }
                    this.appointment_materialsTableAdapter.Fill(dBDS.appointment_materials);
                }
                else App.Text = "Не була обрана послуга, або діагноз, які є обов'язковими!";
            }
            UpdateCost();
        }

        public void UpdateCost()
        {
            decimal sum = 0;
            treeView1.Nodes.Clear();
            foreach (dBDS.appointment_servicesRow m in dBDS.appointment_services.Select("appoinment='" + AppointBox.SelectedValue + "'"))
            {
                dBDS.servicesRow fk = dBDS.services.FindByid_service(m.service);
                if (m.includes)
                {
                    sum += fk.cost;
                    treeView1.Nodes.Add(m.id_app_serv.ToString(), fk.name_service + ": " + fk.cost+"; Діагноз: "+dBDS.diags_patient.FindByid_diag_patient(m.appointm_diagnosis).diagnosisRow.name_diag+";");
                    decimal dblsum = 0;
                    foreach (dBDS.appointment_materialsRow s in dBDS.appointment_materials.Select("app_doctor_service='" + m.id_app_serv + "'"))
                    {
                        dBDS.materialsRow mk = dBDS.materials.FindByid_material(s.material);
                        sum += s.count * mk.cost;
                        dblsum += s.count * mk.cost;
                        treeView1.Nodes[m.id_app_serv.ToString()].Nodes.Add(s.id_app_mat.ToString(), mk.name_material + ": " + mk.cost + " х" + s.count);
                    }
                    treeView1.Nodes[m.id_app_serv.ToString()].Text += " Матеріали: " + dblsum;
                }
                else
                {
                    treeView1.Nodes.Add(m.id_app_serv.ToString(), fk.name_service + ": Не враховується; Діагноз: " + dBDS.diags_patient.FindByid_diag_patient(m.appointm_diagnosis).diagnosisRow.name_diag + ";");
                    foreach (dBDS.appointment_materialsRow s in dBDS.appointment_materials.Select("app_doctor_service='" + m.id_app_serv + "'"))
                    {
                        dBDS.materialsRow mk = dBDS.materials.FindByid_material(s.material);
                        treeView1.Nodes[m.id_app_serv.ToString()].Nodes.Add(s.id_app_mat.ToString(), mk.name_material + ": " + 0 + " х" + s.count);
                    }
                    treeView1.Nodes[m.id_app_serv.ToString()].Text += " Матеріали: Не враховується";
                }
            }
            dBDS.appointment.FindByid_appointment((int)AppointBox.SelectedValue).full_cost = sum;
            this.appointmentTableAdapter.Update(dBDS.appointment);
            label17.Text = sum.ToString() + " грн.";
            CheckPaided();
        }

        private void ServSearch_TextChanged(object sender, EventArgs e)
        {
            try { ServTree.SelectedNode = ServTree.Nodes[ServSearch.AutoCompleteCustomSource.IndexOf(ServSearch.Text)]; }
            catch { return; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (AppointBox.Text == "") return; 
            dBDS.appointmentRow m = dBDS.appointment.FindByid_appointment((int)AppointBox.SelectedValue); 
            m.paided = m.full_cost;
            CheckPaided();
            appointmentTableAdapter.Update(dBDS.appointment);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (AppointBox.Text == "") return;
            dBDS.appointmentRow m = dBDS.appointment.FindByid_appointment((int)AppointBox.SelectedValue);
            decimal.TryParse(textBox1.Text.Replace(".", ","),out decimal mk);
            if (m.paided + mk > 0)
                m.paided += mk;
            else
                m.paided = 0;
            CheckPaided();
        }
        public void CheckPaided()
        {
            if (AppointBox.Text == "") return;
            dBDS.appointmentRow m = dBDS.appointment.FindByid_appointment((int)AppointBox.SelectedValue);
            if ((m.full_cost.ToString("#.##") == m.paided.ToString("#.##")  || m.full_cost<m.paided) && m.started == true)
            {
                label19.Text = "Статус оплати: все оплачено";
            }
            else if (m.full_cost > m.paided)
            {

                label19.Text = "Статус оплати:";
                if (m.paided > 0) label19.Text += " оплачено: " + m.paided.ToString("#.##");
                label19.Text += " довг: " + (m.full_cost - m.paided).ToString("#.##") + " грн.";
            }
            else { label19.Text = "Статус оплати: не розпочато"; }
            decimal jk=dBDS.patients.FindByid_patient((int)comboBox1.SelectedValue).debt;
            if (jk < 0) label31.Text = "Аванс: " + String.Format("{0:#.##}", jk * (-1));
            else label31.Text = "Аванс: немає";
        }
        public void UpdateAppointm()
        {
            this.appointmentTableAdapter.Fill(dBDS.appointment);
            this.appointment_servicesTableAdapter.Fill(dBDS.appointment_services);
            this.appointment_materialsTableAdapter.Fill(dBDS.appointment_materials);
        }

        public void HealingTreeFill()
        {
            HealingTreeDiag.BeginUpdate();
            HealingTreeDiag.Nodes.Clear();
            foreach(dBDS.diags_patientRow f in dBDS.diags_patient.Select("patient='"+comboBox1.SelectedValue+"'"))
            {
                HealingTreeDiag.Nodes.Add(f.id_diag_patient.ToString(), f.diagnosisRow.name_diag + " зуб(и): " + f.tooth);
            }
            HealingTreeDiag.EndUpdate();
        }

        private void HealingTreeDiag_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (AppointBox.Text != "" && HealingTreeDiag.SelectedNode != null) { CheckAppointmChoose(true); UpdateCost(); }
            else CheckAppointmChoose(false);
        }

        private void DataGridView5_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void DataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void BtnPayByAvnc_Click(object sender, EventArgs e)
        {
            if (AppointBox.Text == "") return;
            dBDS.patientsRow f = dBDS.patients.FindByid_patient((int)comboBox1.SelectedValue);
            dBDS.appointmentRow m = dBDS.appointment.FindByid_appointment((int)AppointBox.SelectedValue);
            if (f.debt > 0) return;
            if (m.paided < m.full_cost)
            {
                if(f.debt+(m.full_cost-m.paided)<0)
                {
                    f.debt += (m.full_cost-m.paided);
                    m.paided = m.full_cost;
                }
                else
                {
                     f.debt -= f.debt;
                     m.paided -=f.debt;
                }
            }
            App.Text += f.debt;
            this.patientsTableAdapter.Update(dBDS.patients);
            this.appointmentTableAdapter.Update(dBDS.appointment);
            CheckPaided();
        }

        private void AppointBox_SelectedValueChanged(object sender, EventArgs e)
        { 
            if (AppointBox.Text != "" && MainTab.SelectedIndex == 6)
                UpdateCost();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (AppointBox.Text == "") return;
            dBDS.appointment.FindByid_appointment((int)AppointBox.SelectedValue).paided = 0;
            appointmentTableAdapter.Update(dBDS.appointment);
        }

        private void TreeViewcompl_MouseDown(object sender, MouseEventArgs e)
        {
            TreeContextMenu(sender, e);
        }

        public void TreeContextMenu(object sender, MouseEventArgs e)
        {
            if (sender is TreeView tree)
            {
                if (e.Button != MouseButtons.Right) return;
                TreeNode node = tree.GetNodeAt(e.X, e.Y);
                TreeNode Backnode = tree.SelectedNode;
                tree.SelectedNode = node;
                if (node == null) { tree.SelectedNode = Backnode; return; }
                am = node;
                contextMenuStrip1.Show(tree, e.X, e.Y);
            }
        }

        private void CloseWind_Click(object sender, EventArgs e)
        {
            Form[] a = new Form[this.MdiChildren.Count()];
            int i = 0;
            foreach (Form f in this.MdiChildren)
            {
                a[i] = f;
                i++;
            }
            for (int j=0;j<i;j++)
            {
                if (a[j] is MainForm) continue;
                a[j].Close();
            }
            CloserWindows();
        }

        private void ChangeView_CheckStateChanged(object sender, EventArgs e)
        {
          //  CloserWindows();
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            CloserWindows();
        }

        private void ComboBox1_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            try { comboBox1.SelectedValue = dBDS.patients.Select("full_name='" + comboBox1.Text + "'").First()[0]; }
            catch { comboBox1.SelectedItem = comboBox1.Items[0]; }
        }

        #endregion
        //looks Done

    }
    #endregion

    #region Запись/Считывание файлов, создание форм, обьявление различных класов

    //технічна частина

    public class properties //Клас який відображає налаштування програми
    {
        public int DocID;
        public int Mode;
    }
    public class ApplicationWork
    {
        public void InitPatDir(int pat_id,string full_nm)
        {
            try
            {
                System.Diagnostics.Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + @"\Пацієнти\" + pat_id+ "_" + full_nm + @"\Рентген");
            }
            catch
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + @"\Пацієнти\" + pat_id + "_" + full_nm + @"\Рентген");
                System.Diagnostics.Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + @"\Пацієнти\" + pat_id + "_" + full_nm + @"\Рентген");
            }

        }
        public void InitDaysheetDir(int pat_id, string full_nm)
        {
            try
            {
                System.Diagnostics.Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + @"\Пацієнти\" + pat_id + "_" + full_nm + @"\Щоденик лікування");
            }
            catch
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + @"\Пацієнти\" + pat_id + "_" + full_nm + @"\Щоденник лікування");
                System.Diagnostics.Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + @"\Пацієнти\" + pat_id + "_" + full_nm + @"\Щоденник лікування");
            }
        }
        public properties FileInitialization(properties prop)
        {
            try
            {
                XmlSerializer f = new XmlSerializer(typeof(properties));
                using (FileStream r = new FileStream("settings.xml", FileMode.Open))
                {
                    prop = (properties)f.Deserialize(r);
                }
            }
            catch
            {
                XmlSerializer f = new XmlSerializer(typeof(properties));
                using (FileStream r = new FileStream("settings.xml", FileMode.Create))
                {
                    prop.DocID = -1;
                    prop.Mode = 3;
                    f.Serialize(r, prop);
                }
            }
            App.Mode = prop.Mode;
            return prop;
        }
        public void SaveProperties(properties prop)
        {
            XmlSerializer f = new XmlSerializer(typeof(properties));
            using (FileStream r = new FileStream("settings.xml", FileMode.Create))
            {
                f.Serialize(r, prop);
            }
        }
    }


    //Створення та визов форм


    public class CreatorForms
    {
        public bool AnamnezAnthrFormDialog(TreeNode am,string anmtp)
        {
            SmallDataChanger f = new SmallDataChanger("AnmAll", am,anmtp);
            return f.ShowDialog()==DialogResult.OK;
        }
        public bool ComplaintsFormDialog(TreeNode am)
        {
            SmallDataChanger f = new SmallDataChanger("Compl", am);
            return f.ShowDialog()==DialogResult.OK;
        }
        public bool PlanLetsFormDialog(TreeNode am)
        {
            SmallDataChanger f = new SmallDataChanger("Pln", am);
            return f.ShowDialog()==DialogResult.OK;
        }
        public bool AnamnezDiseaseFormDialog(TreeNode am)
        {
            SmallDataChanger f = new SmallDataChanger("AnmDis", am);
             return f.ShowDialog()==DialogResult.OK;
        }
        public bool DiagnosisFormDialog(TreeNode am)
        {
            SmallDataChanger f = new SmallDataChanger("Diag",am);
            return f.ShowDialog()==DialogResult.OK;
        }


        public void AppointmentsForm(int jade,bool jkk)
        {
            if (jkk)
            {
                if (Application.OpenForms["Appointments"] is Appointments f)
                {
                    f.UpdForm();
                    f.GetToAppointm(jade);
                    f.Activate();
                }
                else
                {
                    f = new Appointments(jade, true);
                    f.MdiParent = Application.OpenForms[0] as MainForm;
                    f.Show();
                }
            }
            else
            {
                if (Application.OpenForms["Appointments"] is Appointments f)
                {
                    f.Close();
                    f = new Appointments(jade, false);
                    f.MdiParent = Application.OpenForms[0] as MainForm;
                    f.Show();
                }
                else
                {
                    f = new Appointments(jade, false);
                    f.MdiParent = Application.OpenForms[0] as MainForm;
                    f.Show();
                }
            }
        }
        public void ServicesForm()
        {
            if (Application.OpenForms["Services"] is Services f) f.Activate();
            else
            {
                f = new Services();
                f.MdiParent = Application.OpenForms[0] as MainForm;
                f.Show();
            }
        }
        public void MaterialsAndServicesFrom()
        {
            if (Application.OpenForms["MaterialsAndServices"] is MaterialsAndServices f) f.Activate();
            else
            {
                f = new MaterialsAndServices();
                f.MdiParent = Application.OpenForms[0] as MainForm;
                f.Show();
            }
        }
        public void MaterialsForm()
        {
            if (Application.OpenForms["Materials"] is Materials f) f.Activate();
            else
            {
                f = new Materials();
                f.MdiParent = Application.OpenForms[0] as MainForm;
                f.Show();
            }
        }
        public void PostsForm()
        {
            Posts f = Application.OpenForms["Posts"] as Posts;
            if (f is null)
            {
                f = new Posts();
                f.MdiParent = Application.OpenForms[0] as MainForm;
                f.Show();
            }
            else f.Activate();
        }
        public void ServicesAndPostsForm()
        {
            ServicesAndPosts f = Application.OpenForms["ServicesAndPosts"] as ServicesAndPosts;
            if (f is null)
            {
                f = new ServicesAndPosts();
                f.MdiParent = Application.OpenForms[0] as MainForm;
                f.Show();
            }
            else f.Activate();
        }
        public void DoctorForm()
        {
            Doctor f = Application.OpenForms["Doctor"] as Doctor;
            if (f is null)
            {
                f = new Doctor();
                f.MdiParent = Application.OpenForms[0] as MainForm;
                f.Show();
            }
            else f.Activate();
        }
        public void PatientForm()
        {
            Patient f = Application.OpenForms["Patient"] as Patient;
            if (f is null)
            {
                f = new Patient();
                f.MdiParent = Application.OpenForms[0] as MainForm;
                f.Show();
            }
            else f.Activate();
        }
        public void RecordLogForm(int docid)
        {
            RecordLog f = Application.OpenForms["RecordLog"] as RecordLog;
            if (f is null)
            {
                f = new RecordLog(docid);
                f.MdiParent = Application.OpenForms[0] as MainForm;
                f.Show();
            }
            else f.Activate();
        }
        public void ChangePatientFormDialog(int index)
        {
            PatientChng f = new PatientChng(index);
            f.Owner = Application.OpenForms[0];
            f.ShowDialog();
        }
        public DialogResult SettingsAppFormDialog(properties prop)
        {
            SettingsApp f = new SettingsApp(prop.DocID, prop.Mode);
            return f.ShowDialog();
        }
        public int PatientAddFormDialog()
        {
            PatientAdd f = new PatientAdd();
            if (f.ShowDialog() == DialogResult.OK) return -1;
            else return 0;
        }
    }
        #endregion
    //done
}
