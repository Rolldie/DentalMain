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
    public partial class PatientChng : Form
    {
        public PatientChng(int key)
        {
            InitializeComponent();
            identnumb = key;
        }
        int identnumb;

        private void PatientChng_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
        public delegate void frst();
        public void UpdateData()
        {
            this.patientsTableAdapter.Fill(dBDS.patients);
            frst a = new frst(GetData);
            BeginInvoke(a);
        }

        public void GetData()
        {
            dBDS.patientsRow a=dBDS.patients.FindByid_patient(identnumb);
            textBox1.Text =Text= a.full_name;
            try { dateTimePicker1.Value = a.date_of_birth; } catch { }
            maskedTextBox1.Text = a.phone_number;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            dBDS.patientsRow a = dBDS.patients.FindByid_patient(identnumb);
            if (dateTimePicker1.Value.Date == DateTime.Now.Date)
            {
                if (textBox1.Text != "")
                {
                    a.full_name = textBox1.Text;
                    if (maskedTextBox1.MaskCompleted)
                        a.phone_number = maskedTextBox1.Text;
                    else a.phone_number = null;
                    this.patientsTableAdapter.Update(dBDS.patients);
                    DialogResult = DialogResult.OK; SendDataToF();
                    Close();
                }
                else { MessageBox.Show("Не було введено ПІБ, яке є обов'язковим полем"); }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    a.full_name = textBox1.Text;
                    a.date_of_birth = dateTimePicker1.Value.Date;
                    if (maskedTextBox1.MaskCompleted)
                        a.phone_number = maskedTextBox1.Text;
                    else a.phone_number = null;
                    patientsTableAdapter.Update(dBDS.patients); DialogResult = DialogResult.OK;
                    SendDataToF();
                    Close();
                }
                else { MessageBox.Show("Не було введено ПІБ, яке є обов'язковим поле"); }
                
            }
        }

        public void SendDataToF()
        {
            if (Application.OpenForms["MainForm"] is MainForm f)
            {
                if (this.Owner == f) f.UpdatePatient(identnumb);
                else f.UpdatePatient();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
