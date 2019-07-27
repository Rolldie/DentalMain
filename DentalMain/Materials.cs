using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DentalMain
{
    public partial class Materials : Form
    {
        public Materials()
        {
            InitializeComponent();
        }

        private void MaterialsAdd_Load(object sender, EventArgs e)
        {
            Updater();
            helpProvider1.HelpNamespace = Application.StartupPath + "//Help//help.chm";
        }

        public delegate void frst();
        public void Updater()
        {
            try { this.materialsTableAdapter.Fill(this.dBDS.materials); }
            catch(Exception ex) { MessageBox.Show(ex.Message+"\n Возможно следует перезапустить приложение."); }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(Name_matTextBox.Text!="")
            {
                if (dBDS.materials.Select("name_material='" + Name_matTextBox.Text.ToLower() + "'").Count() == 0)
                {
                    decimal f;
                    decimal.TryParse(CostTextBox.Text.Replace(".", ","), out f);
                    MemoryStream memstr = new MemoryStream();
                    Image img;
                    try { img = Image.FromFile(DirectoryImageTextBox.Text); } catch { img = null; }
                    byte[] b;
                    if (img != null)
                    {
                        img.Save(memstr, System.Drawing.Imaging.ImageFormat.Png);
                        b = memstr.ToArray();
                    }
                    else b = null;
                    this.materialsTableAdapter.Insert(Name_matTextBox.Text.ToLower(), f, b);
                    Updater();
                    if (Application.OpenForms["MaterialsAndServices"] is MaterialsAndServices c) c.UpdateForFormsMat();
                    if (Application.OpenForms["MainForm"] is MainForm u) u.UpdateWithSavePos();
                    CostTextBox.Text = "";
                    Name_matTextBox.Text = "";
                    DirectoryImageTextBox.Text = "";
                }
                else App.Text = "Ці данні вже є в базі";
            }
        }

        bool Check = true;
        private void datagridcomb_Opening(object sender, CancelEventArgs e)
        {
            if (Check)
                e.Cancel = true;
        }

        public void RowSelector(int rowind)
        {
            MatGrid.CurrentCell = MatGrid.Rows[rowind].Cells[1];
        }

        DataGridViewCellMouseEventArgs a = null;
        private void MatGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.RowIndex < MatGrid.RowCount && e.ColumnIndex >= 0 && e.ColumnIndex < MatGrid.ColumnCount)
                {
                    Check = false;
                    RowSelector(e.RowIndex);
                    a = e;
                }
                else
                    Check = true;
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void змінитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialsChng f = new MaterialsChng((int)MatGrid.Rows[a.RowIndex].Cells[0].Value);
            if (f.ShowDialog() == DialogResult.OK)
            {
                int jk = a.RowIndex;
                Updater();
                if (Application.OpenForms["MaterialsAndServices"] is MaterialsAndServices c) c.Updating();
                try { RowSelector(jk); } catch { return; }
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочите вилучити цей матеріал?", "Додаток Стоматологія", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dBDS.materialsRow f = dBDS.materials.FindByid_material((int)MatGrid[0, a.RowIndex].Value);
                if (f.delete) f.delete = false;
                else f.delete = true;
                materialsTableAdapter.Update(f);
                if (Application.OpenForms["MaterialsAndServices"] is MaterialsAndServices c) c.Updating();
            }
        }
        private void DirectorySetBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                DirectoryImageTextBox.Text = openFileDialog1.FileName;
            }
            
        }
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            App.ChangeObjectText(sender);
        }

    }
}
