using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalMain
{
    public partial class Appointments : Form
    {
        public Appointments(int appointm,bool am)
        {
            InitializeComponent();
            if (am)
            {
                aptm = appointm;
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
                patid = appointm;
                amam = am;
            }
        }
        int patid;
        int aptm = -1;
        bool amam=true;
        private void Appointments_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "//Help//help.chm";
            this.materialsTableAdapter.Fill(this.dBDS.materials);
            this.servicesTableAdapter.Fill(this.dBDS.services);
            this.patientsTableAdapter.Fill(this.dBDS.patients);
            this.doctorsTableAdapter.Fill(this.dBDS.doctors);
            this.appointment_materialsTableAdapter.Fill(this.dBDS.appointment_materials);
            this.appointment_servicesTableAdapter.Fill(this.dBDS.appointment_services);
            this.appointmentTableAdapter.Fill(this.dBDS.appointment);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void GetToAppointm(int appointm)
        {
            appointmentBindingSource.Filter = "";
            if (appointm != -1)appointmentBindingSource.Position=appointmentBindingSource.Find("id_appointment", appointm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.appointmentTableAdapter.Update(dBDS.appointment);
                this.appointment_materialsTableAdapter.Update(this.dBDS.appointment_materials);
                this.appointment_servicesTableAdapter.Update(this.dBDS.appointment_services);
                dBDS.AcceptChanges();
                if (this.MdiParent is MainForm f)
                {
                    f.FindWhatToUpdate();
                }
                if (Application.OpenForms["RecordLog"] is RecordLog m) m.Updating();
            }
            catch
            {
                App.Text = "Не вдалося зберегти дані, можливо вони некоректно заповнені";
            }
        }
        public void UpdForm()
        {
            this.appointmentTableAdapter.Fill(dBDS.appointment);
            this.appointment_materialsTableAdapter.Fill(this.dBDS.appointment_materials);
            this.appointment_servicesTableAdapter.Fill(this.dBDS.appointment_services);
        }
        private void BtnCancl_Click(object sender, EventArgs e)
        {
            UpdForm();
        }

        private void Appointments_Activated(object sender, EventArgs e)
        {
            if (amam)
            {
                 UpdForm();
                GetToAppointm(aptm);
            }
            else
            {amam = true;
                UpdForm();
                comboBox2.SelectedValue = patid;
                FilterByPat();
                
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                comboBox2.Visible = true; dateTimePicker1.Visible = false;
                comboBox2.DataSource =bindingSource1;
                comboBox2.DisplayMember = "full_name";
                comboBox2.ValueMember = "id_patient";
            }
            else if (comboBox1.SelectedIndex==1)
            {
                comboBox2.Visible = true; dateTimePicker1.Visible = false;
                comboBox2.DataSource = bindingSource2;
                comboBox2.DisplayMember = "full_name";
                comboBox2.ValueMember = "id_doctor";
            }
            else { comboBox2.Visible = false; dateTimePicker1.Visible = true; }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    appointmentBindingSource.Filter = "patient='" + comboBox2.SelectedValue + "'";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    appointmentBindingSource.Filter = "doctor='" + comboBox2.SelectedValue + "'";
                }
            }
            catch { appointmentBindingSource.Filter = ""; }
        }
        public void FilterByPat()
        {
            appointmentBindingSource.Filter = "patient='" + comboBox2.SelectedValue + "'";
        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 2)
            {
                appointmentBindingSource.Filter = "date_appointm=#" + string.Format("{0: MM-dd-yyyy}", dateTimePicker1.Value) + "#";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                appointmentBindingSource.Filter = "recording_date=#" + string.Format("{0: MM-dd-yyyy}", dateTimePicker1.Value) + "#";
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            appointmentBindingSource.Filter = "";
        }
    }
}
