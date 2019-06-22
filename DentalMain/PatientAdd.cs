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
                        this.patientsTableAdapter.Insert(textBox1.Text, null, maskedTextBox1.Text, 0);
                    else
                        this.patientsTableAdapter.Insert(textBox1.Text, null, null, 0);
                }
                else
                {
                    if (maskedTextBox1.MaskCompleted)
                        this.patientsTableAdapter.Insert(textBox1.Text, dateTimePicker1.Value.Date, maskedTextBox1.Text, 0);
                    else
                        this.patientsTableAdapter.Insert(textBox1.Text, dateTimePicker1.Value.Date, null, 0);
                }
                this.patientsTableAdapter.Fill(dBDS.patients);
            }
            else
            { 
                MessageBox.Show("Не було заповнено поле ПІБ, яке є обов'язковим!");
                return;
            }
            DialogResult = DialogResult.OK;
            int maxind = 0;
            foreach (dBDS.patientsRow am in dBDS.patients)
            {
                if (am.id_patient > maxind) maxind = am.id_patient;
            }
            if (Owner is MainForm a)
            {
                a.UpdatePatient(maxind);
            }
            else if (Owner is Patient f) f.UpdateData(maxind);
            else if (Owner is PatientChoose m) m.idforadd = maxind;
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
