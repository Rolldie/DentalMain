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
    public partial class PatientChoose : Form
    {
        public PatientChoose()
        {
            InitializeComponent();
        }

        private void PatientChoose_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDS.patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.dBDS.patients);
            helpProvider1.HelpNamespace = Application.StartupPath + "//Help//help.chm";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                patientsBindingSource.Filter = "full_name like '%" + textBox1.Text + "%'";
            }
            catch
            {
                patientsBindingSource.Filter = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientAdd f = new PatientAdd();
            f.ShowDialog();
            patientsTableAdapter.Fill(dBDS.patients);
            if (Application.OpenForms["MainForm"] is MainForm u) u.UpdateWithSavePos();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(Application.OpenForms["RecordLog"] is RecordLog f)
            {
                f.patientid = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                //f.Updating();
                DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (Application.OpenForms["RecordLog"] is RecordLog f)
                {
                    f.patientid = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                    DialogResult = DialogResult.OK;
                }
                Close();
            }
        }
    }
}
