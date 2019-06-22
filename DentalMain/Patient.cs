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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            UpdateData();
            FieldBx.SelectedIndex = 0;
            helpProvider1.HelpNamespace = Application.StartupPath + "//Help//help.chm";
        }

        private void FltrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                patientsBindingSource.Filter = dBDS.patients.Columns[FieldBx.SelectedIndex + 1].Caption.ToString() + " like '%" + FindTxtBx.Text + "%'";
            }
            catch
            {
                try
                {
                    DateTime a = Convert.ToDateTime(dateTimePicker1.Value);
                    patientsBindingSource.Filter = dBDS.patients.Columns[FieldBx.SelectedIndex + 1].Caption.ToString() + "=#" + String.Format("{0: MM-dd-yyyy}",a) + "#";
                }
                catch { App.Text = "Неправильно введені дані"; }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            patientsBindingSource.Filter = "";
        }

        private void PatientGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MainForm f = Application.OpenForms["MainForm"] as MainForm;
            f.UpdatePatient((int)PatientGrid.Rows[e.RowIndex].Cells[0].Value);
            Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            PatientAdd f = new PatientAdd();
            f.Owner = this;
            f.ShowDialog();
        }
        public void UpdateData()
        { 
            int rowin = -1;
            if (a != null)
            {
                rowin = PatientGrid.SelectedRows[0].Index;
            }
            this.patientsTableAdapter.Fill(this.dBDS.patients);
            if (rowin != -1)
            {
                RowSelector(rowin);
            }
        }
        public void UpdateData(int id)
        {
            this.patientsTableAdapter.Fill(this.dBDS.patients);
            patientsBindingSource.Position = patientsBindingSource.Find("id_patient", id);
        }

        private void FieldBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FieldBx.SelectedIndex==1)
            { dateTimePicker1.Visible = true; }
            else
            { dateTimePicker1.Visible = false; }
        }

        bool Chek = true;
        DataGridViewCellMouseEventArgs a = null;
        private void PatientGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.RowIndex<PatientGrid.RowCount && e.ColumnIndex>=0 && e.ColumnIndex<PatientGrid.ColumnCount)
                {
                    Chek =false;
                    RowSelector(e.RowIndex);
                    a = e;
                    if((bool)PatientGrid[4,e.RowIndex].Value)
                    {
                        відмітитиДляВилученняToolStripMenuItem.Text = "Відмінити вилучення";
                    }
                    else
                    {
                        відмітитиДляВилученняToolStripMenuItem.Text = "Відмітити для вилучення";
                    }
                }
                else
                    Chek =true;
            }
        }

        public void RowSelector(int rowind)
        {
            PatientGrid.CurrentCell = PatientGrid.Rows[rowind].Cells[0];
        }

        private void GridContm_Opening(object sender, CancelEventArgs e)
        {
            if(Chek)
            { e.Cancel = true; }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientChng f = new PatientChng((int)PatientGrid.Rows[a.RowIndex].Cells[0].Value);
            f.Owner = this;
            f.ShowDialog();
            UpdateData();
        }

        private void PatientGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void ВідмітитиДляВилученняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool jk = (bool)PatientGrid.SelectedCells[4].Value;
            int a= (int)PatientGrid.SelectedCells[0].Value;
            if (jk)
            {
                this.dBDS.patients.FindByid_patient(a).delete = false;
            }
            else
            {
                this.dBDS.patients.FindByid_patient(a).delete = true;
            }
            this.patientsTableAdapter.Update(dBDS.patients);
        }
    }
}
