using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalMain
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        public delegate void frst();
        private void Services_Load(object sender, EventArgs e)
        {
            this.servicesTableAdapter.Fill(this.dBDS.services);
            helpProvider1.HelpNamespace = Application.StartupPath + "//Help//help.chm";
        }
        public void ThreadingUpdate()
        {
            Updater();
        }

        public void ResetBnd()
        {
            servicesBindingSource.ResetBindings(false);
        }

        public void Updater()
        {
            this.servicesTableAdapter.Fill(this.dBDS.services);
            frst a = new frst(ResetBnd);
            BeginInvoke(a);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (dBDS.services.Select("name_service='" + textBox1.Text.ToLower()+"'").Count() == 0)
                {
                    decimal f;
                    decimal.TryParse(textBox2.Text, out f);
                    servicesTableAdapter.Insert(textBox1.Text.ToLower(), f);
                    servicesTableAdapter.Fill(dBDS.services);
                    if (Application.OpenForms["MaterialsAndServices"] is MaterialsAndServices n) n.UpdServ();
                    if (Application.OpenForms["ServicesAndPosts"] is ServicesAndPosts m) m.ThreadingUpdate();
                    if (Application.OpenForms["MainForm"] is MainForm u) u.UpdateWithSavePos();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else App.Text = "Ці дані вже існують в базі";
                
            }
            else App.Text = "Не було введено поле Назва послуги";
        }
        bool Check = true;
        DataGridViewCellMouseEventArgs a = null;
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.RowIndex < ServGrid.RowCount && e.ColumnIndex >= 0 && e.ColumnIndex < ServGrid.ColumnCount)
                {
                    Check = false;
                    RowSelector(e.RowIndex);
                    a = e;
                }
                else
                    Check = true;
            }
        }
        public void RowSelector(int rowind)
        {
            ServGrid.CurrentCell = ServGrid.Rows[rowind].Cells[0];
        }

        private void GridMenu_Opening(object sender, CancelEventArgs e)
        {
            if (Check)
                e.Cancel = true;
        }

        private void змінитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicesChng f = new ServicesChng((int)ServGrid.Rows[a.RowIndex].Cells[0].Value);
            if (f.ShowDialog() == DialogResult.OK)
            {
                int jk = a.RowIndex;
                Updater();
                if (Application.OpenForms["ServicesAndPosts"] is ServicesAndPosts m) m.ThreadingUpdate();
                if (Application.OpenForms["MaterialsAndServices"] is MaterialsAndServices n) n.ThreadingUpdate();
                if (Application.OpenForms["MainForm"] is MainForm u) u.UpdateWithSavePos();
                try { RowSelector(jk); } catch { return; }
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочите вилучити цю послугу?", "Додаток Стоматологія", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                servicesTableAdapter.Delete((int)ServGrid.Rows[a.RowIndex].Cells[0].Value, ServGrid.Rows[a.RowIndex].Cells[1].Value.ToString(),(decimal)ServGrid.Rows[a.RowIndex].Cells[2].Value);
                servicesTableAdapter.Fill(dBDS.services);
                if (Application.OpenForms["ServicesAndPosts"] is ServicesAndPosts f) f.ThreadingUpdate();
                if (Application.OpenForms["MaterialsAndServices"] is MaterialsAndServices n) n.UpdServ();
                if (Application.OpenForms["MainForm"] is MainForm u) u.UpdateWithSavePos();
            }
        }
    }
}
