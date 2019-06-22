using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalMain
{
    public partial class RecordLog : Form
    {
        public RecordLog(int DocID)
        {
            InitializeComponent();
            docid = DocID;
            sources[0] = bindingSource1;
            sources[1] = bindingSource2;
            sources[2] = bindingSource3;
            sources[3] = bindingSource4;
            sources[0].Sort = "time";
            sources[1].Sort = "time";
            sources[2].Sort = "time";
            sources[3].Sort = "time";
        }
        int docid;

        private string GetWeekday(DateTime a)
        {
            switch (a.DayOfWeek.ToString())
            {
                case "Monday":
                    return "Пн";
                case "Tuesday":
                    return "Вт";
                case "Wednesday":
                    return "Ср";
                case "Thursday":
                    return "Чт";
                case "Friday":
                    return "Пт";
                case "Saturday":
                    return "Сб";
                case "Sunday":
                    return "Нд";
                default:
                    return "";
            }
        }
        private delegate void frst();
         
        
        public void labelsEditor()
        {
            DateTime f = DateCalendar.SelectionStart.Date;
            label1.Text = String.Format("{0: dddd dd/MM/yyyy}", f);f = f.AddDays(1);
            label2.Text = String.Format("{0: dddd dd/MM/yyyy}", f); f = f.AddDays(1);
            label3.Text = String.Format("{0: dddd dd/MM/yyyy}", f); f = f.AddDays(1);
            label4.Text = String.Format("{0: dddd dd/MM/yyyy}", f);
        }

        private void RecordLog_Load(object sender, EventArgs e)
        {
            ThreadingUpdate();
            helpProvider1.HelpNamespace = Application.StartupPath + "//Help//help.chm";
        }
        public void ThreadingUpdate()
        {
           // Thread thread = new Thread(Updating);
           // thread.IsBackground = true;
           //thread.Start();
            Updating();
        }
        public void Updating()
        {
            this.doctorsTableAdapter.Fill(dBDS.doctors);
            this.docRecordLogTableAdapter.Fill(dBDS.docRecordLog);
            this.patientsTableAdapter.Fill(dBDS.patients);
            this.appointmentTableAdapter.Fill(dBDS.appointment);
            CheckDoctors();
            Filter();
        }

        public void CheckDoctors()
        {
            if(doctorsBindingSource.Count==0)
            {
                if (MessageBox.Show("Не було додано жодного лікаря, бажаєте додати лікаря?", "Додаток Стоматологія", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DoctorAdd f = new DoctorAdd();
                    f.ShowDialog();
                    Updating();
                }
                else
                    Close();
            }
        }
        BindingSource[] sources = new BindingSource[4];
        public void Filler(DateTime a)
        {
            foreach (dBDS.appointmentRow f in dBDS.appointment.Select("doctor='" + (int)DoctorBox.SelectedValue + "' and date_appointm=#" + String.Format("{0: MM-dd-yyyy}", a) + "# and patient is null"))
            {
                f.Delete();
            }
            foreach (dBDS.appointmentRow f in StDb.db.Select("doctor='" + (int)DoctorBox.SelectedValue + "' and date_appointm=#" + String.Format("{0: MM-dd-yyyy}", a)+"# and patient is null"))
            {
                if (dBDS.appointment.Select("doctor='" + (int)DoctorBox.SelectedValue + "' and date_appointm=#" + String.Format("{0: MM-dd-yyyy}", a) + "# and time='" + f.time + "'").Count() == 0)
                    dBDS.appointment.Rows.Add(null,DoctorBox.SelectedValue, null, f.time, DateTime.Today, a.Date, 0, false);
            }
            foreach (dBDS.docRecordLogRow f in dBDS.docRecordLog.Select("doctor='" + (int)DoctorBox.SelectedValue + "' and day_of_week='" + GetWeekday(a) + "'"))
            {
                if (dBDS.appointment.Select("doctor='" + (int)DoctorBox.SelectedValue + "' and date_appointm=#" + String.Format("{0: MM-dd-yyyy}", a) + "# and time='" + f.time + "'").Count() == 0)
                {  dBDS.appointment.Rows.Add(null, DoctorBox.SelectedValue, null, f.time, DateTime.Today, a.Date, 0, false); }
            }
            dBDS.appointment.AcceptChanges();
            if (docid > 0) { DoctorBox.SelectedValue = docid; docid = 0; }
        }

        public void Filter()
        {
            DateTime u = DateCalendar.SelectionStart;
            if (DoctorBox.Items.Count > 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    if(DoctorBox.SelectedItem==null) DoctorBox.SelectedIndex = 0;
                    sources[i].Filter = "doctor='" + (int)DoctorBox.SelectedValue + "' and date_appointm=#" + String.Format("{0: MM-dd-yyyy}", u.Date) + "#";
                    Filler(u);
                    mas[i] = u;
                    u = u.AddDays(1);
                }
            }
            labelsEditor();
        }
        private void DateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            Filter();
        }

        DateTime[] mas = new DateTime[4];
        public void GridValueChanged(int k, DataGridViewCellEventArgs e)
        {
            DataGridView f = Controls["Day" + k + "Grid"] as DataGridView;
            if (this == null) return;
            if (e.ColumnIndex == 0)
            {
                int fk;
                if (f!=null)
                {
                    int.TryParse(f[0, e.RowIndex].Value.ToString(), out fk);
                    if (fk == 0)
                    {
                        foreach (dBDS.appointmentRow m in dBDS.appointment.Select("doctor='" + (int)DoctorBox.SelectedValue + "' and date_appointm=#" + String.Format("{0: MM-dd-yyyy}", mas[k - 1]) + "# and time='" + f[1, e.RowIndex].Value + "'"))
                        {
                            this.appointmentTableAdapter.DeleteQuery(m.doctor, m.time, m.date_appointm, m.full_cost, m.cancel);
                        }
                        if (this.MdiParent is MainForm l) l.FindWhatToUpdate();
                    }
                    else
                    {
                        if (patitem == -1)
                        {
                            this.appointmentTableAdapter.Insert((int)DoctorBox.SelectedValue, fk, (DateTime)f[1, e.RowIndex].Value, DateTime.Today, mas[k - 1], 0, false, 0, false);
                        }
                        else
                        {
                            this.appointmentTableAdapter.UpdateQuery(fk, (int)DoctorBox.SelectedValue, (DateTime)f[1, e.RowIndex].Value, mas[k - 1]);
                        }
                        if (this.MdiParent is MainForm l) l.FindWhatToUpdate();
                    }               
                }
            }

        }

        
        
        private void Day1Grid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           e.Cancel = true;
        }

        private void DoctorBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DoctorBox.SelectedValue != null)
            {
                Filter();
            }
        }

        private void Day1Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GridValueChanged(1, e);
        }

        private void Day2Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GridValueChanged(2, e);
        }

        private void Day3Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GridValueChanged(3, e);
        }

        private void Day4Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GridValueChanged(4,e);
        }

        private void Day1Grid_SelectionChanged(object sender, EventArgs e)
        {
            SelectionChangeRec(1);
        }

        private void Day2Grid_SelectionChanged(object sender, EventArgs e)
        {
            SelectionChangeRec(2);
        }

        private void Day3Grid_SelectionChanged(object sender, EventArgs e)
        {
            SelectionChangeRec(3);
        }

        private void Day4Grid_SelectionChanged(object sender, EventArgs e)
        {
            SelectionChangeRec(4);
        }

        public void SelectionChangeRec(int ind)
        {
            if ((Controls["Day" + ind + "Grid"] as DataGridView).SelectedRows.Count > 0)
            {
                int ua;
                int.TryParse((Controls["Day" + ind + "Grid"] as DataGridView).SelectedCells[0].Value.ToString(), out ua);
                if (ua != 0)
                {
                    patitem = ua;
                }
                else
                    patitem = -1;
            }
        }
        int patitem = -1;

        private void button5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DocWrChange"] is DocWrChange f)
            {
                f.Activate();
            }
            else
            {
                f = new DocWrChange();
                f.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillStaticWrit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillStaticWrit(2);
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            FillStaticWrit(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FillStaticWrit(4);
        }

        public void FillStaticWrit(int keo)
        {
            try
            {
                if (StDb.db.Select("doctor='" + DoctorBox.SelectedValue + "' and date_appointm=#" + String.Format("{0: MM-dd-yyyy}", mas[keo - 1]) + "# and time='" + DateTime.Parse("30.12.1899 " + Controls["maskedTextBox" + keo].Text) + "'").Count() == 0 &&
                   dBDS.appointment.Select("doctor='" + DoctorBox.SelectedValue + "' and date_appointm=#" + String.Format("{0: MM-dd-yyyy}", mas[keo - 1]) + "# and time='" + DateTime.Parse("30.12.1899 " + Controls["maskedTextBox" + keo].Text) + "'").Count() == 0)
                {
                    StDb.db.Rows.Add(null, (int)DoctorBox.SelectedValue, null, DateTime.Parse("30.12.1899 " + Controls["maskedTextBox" + keo].Text), null, mas[keo - 1], 0, false,0,false);
                    dBDS.appointment.Rows.Add(null, (int)DoctorBox.SelectedValue, null, DateTime.Parse("30.12.1899 " + Controls["maskedTextBox" + keo].Text), null, mas[keo - 1], 0, false,0,false);
                }
                else App.Text = "Такий запис вже існує";
            }
            catch { App.Text = "Не правильно введений час"; }
        }


        public void DoubleClickWork(int ind, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex >= 0 && e.ColumnIndex >= 0 && (bool)(Controls["Day" + ind + "Grid"] as DataGridView)[3,e.RowIndex].Value==false)
            {
                DataGridView mk = Controls["Day" + ind + "Grid"] as DataGridView;
                mk.CurrentCell = mk[e.ColumnIndex, e.RowIndex];
                PatientChoose f = new PatientChoose();
                DialogResult m = f.ShowDialog();
                if (m == DialogResult.OK)
                {
                    patientsTableAdapter.Fill(dBDS.patients);
                    if (dBDS.appointment.Select("patient='"+patientid+"' and date_appointm =#" + String.Format("{0: MM-dd-yyyy}", mas[ind - 1]) + "# and time='" + mk[1, e.RowIndex].Value + "'").Count() == 0)
                    {
                        mk.SelectedRows[0].Cells[0].Value = patientid;
                    }
                    else App.Text = "Ця людина вже зареэстрована на такий час";
                }
                else if (m == DialogResult.Abort)
                    mk.SelectedRows[0].Cells[0].Value = 0;
            }
            else { App.Text = "Цей прийом вже розпочато!!"; }
        }
        private void Day1Grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DoubleClickWork(1, e);
        }
        public int patientid = 0;

        private void Day2Grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DoubleClickWork(2, e);
        }

        private void Day3Grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DoubleClickWork(3, e);
        }

        private void Day4Grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DoubleClickWork(4, e);
        }

        private void MaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            App.ChangeObjectTextTime(sender);
        }

        private void MaskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            App.ChangeObjectTextTime(sender);
        }

        private void MaskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            App.ChangeObjectTextTime(sender);
        }

        private void MaskedTextBox4_TextChanged(object sender, EventArgs e)
        {
            App.ChangeObjectTextTime(sender);
        }
    }
}
