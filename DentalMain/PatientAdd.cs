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
    public partial class PatientAdd : Form
    {
        public PatientAdd()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
        public delegate void frst();
        public void Add()
        {
            if (textBox1.Text != "")
            {
                if (dateTimePicker1.Value.Date == DateTime.Now.Date)
                {
                    if (maskedTextBox1.MaskCompleted)
                        dBDS.patients.Rows.Add(null, textBox1.Text, null, maskedTextBox1.Text, 0);
                    else
                        dBDS.patients.Rows.Add(null, textBox1.Text, null, null, 0);
                    patientsTableAdapter.Update(dBDS.patients);
                }
                else
                {
                    if (maskedTextBox1.MaskCompleted)
                        dBDS.patients.Rows.Add(null, textBox1.Text, dateTimePicker1.Value.Date, maskedTextBox1.Text, 0);
                    else
                        dBDS.patients.Rows.Add(null, textBox1.Text, dateTimePicker1.Value.Date, null, 0);
                    patientsTableAdapter.Update(dBDS.patients);
                }
            }
            else
            { 
                MessageBox.Show("Не було заповнено поле ПІБ, яке є обов'язковим!");
                return;
            }
            if (Application.OpenForms["MainForm"] is MainForm a) a.UpdatePatient(dBDS.patients.Last().id_patient);
            if (Application.OpenForms["Patient"] is Patient f) {  f.ThreadingUpdateTrue(); }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
