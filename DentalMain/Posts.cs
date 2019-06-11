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
    public partial class Posts : Form
    {
        public Posts()
        {
            InitializeComponent();
            
        }
        public void ThreadingUpdater()
        {
            Updater();
        }
        public delegate void frst();
        public void Updater()
        {
            postTableAdapter.Fill(dBDS.post);
            frst a = new frst(ResetBind);
            BeginInvoke(a);
        }

        public void ResetBind()
        {
            postBindingSource.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bool am = true;
                foreach(dBDS.postRow a in dBDS.post)
                { if (a.name_post == textBox1.Text) { am = false; break; }  }
                if (am)
                {
                    postTableAdapter.Insert(textBox1.Text);
                    postTableAdapter.Fill(dBDS.post);
                    if(Application.OpenForms["ServicesAndPosts"] is ServicesAndPosts f)f.ThreadPostUpdate();
                    if (Application.OpenForms["MaterialsAndServices"] is MaterialsAndServices n) n.ThreadingUpdate();
                }
                else App.Text = "Ця посада вже існує";

            }
            else App.Text = "Данні не були введені";
        }

        private void Posts_Load(object sender, EventArgs e)
        {
            ThreadingUpdater();
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel=true;
        }
        bool Check=true;
        DataGridViewCellMouseEventArgs a = null;
        private void PostGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.RowIndex < PostGrid.RowCount && e.ColumnIndex >= 0 && e.ColumnIndex < PostGrid.ColumnCount)
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
            PostGrid.CurrentCell = PostGrid.Rows[rowind].Cells[0];
        }

        private void GridMenu_Opening(object sender, CancelEventArgs e)
        {
            if (Check)
                e.Cancel = true;
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ви дійсно хочите вилучити цю посаду?","Додаток Стоматологія",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                postTableAdapter.Delete((int)PostGrid.Rows[a.RowIndex].Cells[0].Value, PostGrid.Rows[a.RowIndex].Cells[1].Value.ToString());
                postTableAdapter.Fill(dBDS.post);
                if (Application.OpenForms["ServicesAndPosts"] is ServicesAndPosts f) { f.ThreadingUpdate(); }
            }
        }

        private void змінитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostChng f = new PostChng((int)PostGrid.Rows[a.RowIndex].Cells[0].Value);
            if(f.ShowDialog()==DialogResult.OK)
            {
                int jk = a.RowIndex;
                Updater();
                if (Application.OpenForms["ServicesAndPosts"] is ServicesAndPosts u) u.ThreadPostUpdate();
                try { RowSelector(jk); } catch { return; }
            }
        }
    }
}
