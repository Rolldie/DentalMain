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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            a = null;
        }
        public delegate void frst();
        public new void Update()
        {
          //  base.Update();
            this.doctorsTableAdapter.Fill(this.dBDS.doctors);
            this.postTableAdapter.Fill(this.dBDS.post);
            this.post_doctorTableAdapter.Fill(this.dBDS.post_doctor);
        }
        private void FilterBtn_Click(object sender, EventArgs e)
        {
            if (Field.SelectedIndex == 2)
            {
                try
                {
                    doctorsTableAdapter.FillBy(dBDS.doctors, (int)secretCmbBx.SelectedValue);
                    return;
                }
                catch { App.Text = "Немаэ посади у полі пошуку"; }
            }
            else
            {
                try { doctorsBindingSource.Filter = dBDS.doctors.Columns[Field.SelectedIndex].ColumnName + " Like '%" + FindText.Text + "%'"; }
                catch { try { doctorsBindingSource.Filter = dBDS.doctors.Columns[Field.SelectedIndex].ColumnName + " ='" + FindText.Text + "'"; } catch { App.Text = "Неправильно введені дані"; } }
            }
        }

        public void CreatingFieldsSearch()
        {
            for (int i=0;i<doctorGrid.ColumnCount;i++)
            {
                Field.Items.Add(doctorGrid.Columns[i].HeaderText);
            }
            Field.Items.Add("Посада");

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            Update();
            CreatingFieldsSearch();
            helpProvider1.HelpNamespace = Application.StartupPath + "//Help//help.chm";

        }

        private void Field_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Field.SelectedIndex == 2)
            {
                secretCmbBx.Visible = true;
            }
            else
            {
                Update();
                secretCmbBx.Visible = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            doctorsBindingSource.Filter = "";
            Update();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DoctorAdd a = new DoctorAdd();
            try { a.ShowDialog(); Update();} catch { return; }
            
        }

        private void Doctor_Activated(object sender, EventArgs e)
        {
            Update();
        }

        private void ИзменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int u = (int)doctorGrid.Rows[a.RowIndex].Cells[0].Value;
            DocChange f = new DocChange(u);
            f.ShowDialog();
            doctorsTableAdapter.Fill(dBDS.doctors);
            doctorGrid.CurrentCell = doctorGrid[0, a.RowIndex];
        }
        bool Chek = true;
        DataGridViewCellMouseEventArgs a = null;
        private void DoctorGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.RowIndex < doctorGrid.RowCount && e.ColumnIndex >= 0 && e.ColumnIndex < doctorGrid.ColumnCount)
                {
                    Chek = false;
                    RowSelector(e.RowIndex);
                    a = e;
                    if ((bool)doctorGrid[2, e.RowIndex].Value)
                    {
                        звільнитиЛікаряToolStripMenuItem.Text = "Відмінити вилучення";
                    }
                    else
                    {
                        звільнитиЛікаряToolStripMenuItem.Text = "Вилучити лікаря";
                    }
                }
                else
                    Chek = true;
            }
        }
        public void RowSelector(int ind)
        {
            doctorGrid.CurrentCell = doctorGrid.Rows[ind].Cells[0];
        }

        private void GridContm_Opening(object sender, CancelEventArgs e)
        {
            if (Chek)
            { e.Cancel = true; }
        }

        private void DoctorGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void DoctorGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                if (e.RowIndex >= 0 && e.RowIndex < doctorGrid.RowCount && e.ColumnIndex >= 0 && e.ColumnIndex < doctorGrid.ColumnCount)
                {
                    int u = (int)doctorGrid.Rows[e.RowIndex].Cells[0].Value;
                    DocChange f = new DocChange(u);
                    f.ShowDialog();
                    doctorsTableAdapter.Fill(dBDS.doctors);
                    doctorGrid.CurrentCell = doctorGrid[0, e.RowIndex];
                }
            }
        }

        private void ЗвільнитиЛікаряToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool bl = (bool)doctorGrid[2, a.RowIndex].Value;
            if(bl)
            {
                this.dBDS.doctors.FindByid_doctor((int)doctorGrid[0, a.RowIndex].Value).fired = false;
            }
            else
            {
                this.dBDS.doctors.FindByid_doctor((int)doctorGrid[0, a.RowIndex].Value).fired = true;
            }
            this.doctorsTableAdapter.Update(dBDS.doctors);
        }
    }
}
