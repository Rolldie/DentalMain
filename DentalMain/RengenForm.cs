using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DentalMain
{
    public partial class RengenForm : Form
    {
        public RengenForm(int id,int docid)
        {
            InitializeComponent();
            patid = id;
            Docid = docid;
        }
        int patid;
        int Docid;
        public void FillTree()
        {
            treeView1.Nodes.Clear();
            foreach(dBDS.rengenRow f in dBDS.rengen.Select("patient='"+patid+"'"))
            {
                treeView1.Nodes.Add(f.id_rengen.ToString(), f.date_rengen.ToString("dd.MM.yyyy ") + f.description);
            }
        }

        private void RengenForm_Load(object sender, EventArgs e)
        {
            doctorsTableAdapter.Fill(dBDS.doctors);
            rengenTableAdapter.Fill(dBDS.rengen);
            FillTree();
            CheckButtons();
        }
        public void CheckButtons()
        {
            if (treeView1.Nodes.Count == 0 || treeView1.SelectedNode==null)
            {
                BlockButtons(false);
            }
            else BlockButtons(true);
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.IsSelected) { button1.Enabled = true; button2.Enabled = true; }
            else { button1.Enabled = false; button2.Enabled = false;  return; }
            MemoryStream mem = new MemoryStream();
            byte[] jk = dBDS.rengen.FindByid_rengen(Convert.ToInt32(e.Node.Name)).photo_rg;
            foreach(byte j in jk)
            {
                mem.WriteByte(j);
            }
            Image img = Image.FromStream(mem);
            if (img != null)
            {
                pictureBox1.Image = img;
                mem.Close();
            }
            else return;
            mem.Close();

        }

        private void RengenForm_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            { e.Effect = DragDropEffects.All; }
        }
        public string description;
        private void RengenForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] jk = (string[])e.Data.GetData(DataFormats.FileDrop);
            Image img = Image.FromFile(jk[0]);
            if(img!=null)
            {
                DescForRengen mf = new DescForRengen();
                if (mf.ShowDialog()  != DialogResult.OK) return;
                MemoryStream f = new MemoryStream();
                img.Save(f, System.Drawing.Imaging.ImageFormat.Png);
                byte[] jake = f.ToArray();
                rengenTableAdapter.Insert(DateTime.Today, patid, Docid, jake,description);
                f.Close();
                pictureBox1.Image = img;
            }
            rengenTableAdapter.Fill(dBDS.rengen);
            FillTree();
            treeView1.SelectedNode = treeView1.Nodes[treeView1.Nodes.Count-1];
        }
        TreeNode fm;
        private void TreeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            TreeNode f=treeView1.GetNodeAt(e.Location);
            if (f!=null)
            {
                fm = f;
                treeView1.SelectedNode = f;
                contextMenuStrip.Show(treeView1, e.Location);
            }
        }

        private void ЗмінитиОписToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dBDS.rengenRow a = dBDS.rengen.FindByid_rengen(Convert.ToInt32(fm.Name));
            DescForRengen f = new DescForRengen(a.description);
            description = a.description;
            f.ShowDialog();
            this.rengenTableAdapter.UpdateForDescription(description, Convert.ToInt32(fm.Name));
            this.rengenTableAdapter.Fill(dBDS.rengen);
            FillTree();
            pictureBox1.Image = null;
            CheckButtons();
        }

        private void ВилучитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dBDS.rengenRow f = dBDS.rengen.FindByid_rengen(Convert.ToInt32(fm.Name));
            this.rengenTableAdapter.DeleteEasyQuery(f.id_rengen);
            this.rengenTableAdapter.Fill(dBDS.rengen);
            pictureBox1.Image = null;
            FillTree();
            CheckButtons();
        }
        public void BlockButtons(bool fk)
        {
            button1.Enabled = fk;
            button2.Enabled = fk;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            MemoryStream memstr = new MemoryStream();
            Image img = pictureBox1.Image;
            byte[] b;
            if (img != null)
            {
                img.Save(memstr, System.Drawing.Imaging.ImageFormat.Png);
                b = memstr.ToArray();
            }
            else b = null;
            dBDS.rengenRow f = dBDS.rengen.FindByid_rengen(Convert.ToInt32(treeView1.SelectedNode.Name));
            f.photo_rg = b;
            rengenTableAdapter.Update(f);
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
           // pictureBox1.Image.
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        Pen f = new Pen(new SolidBrush(Color.Red));
                        f.Width = 4;
                        int sheshpoX = pictureBox1.Width / 2 - pictureBox1.Image.Width / 2;
                        int sheshpoY = pictureBox1.Height / 2 - pictureBox1.Image.Height / 2;
                        g.DrawLine(f, new Point(e.X - sheshpoX, e.Y - sheshpoY), new Point(e.X + 1 - sheshpoX, e.Y + 1 - sheshpoY));
                        pictureBox1.Invalidate();
                    }
                }
                catch { MessageBox.Show("Для цього формату зображення не можливо малювати"); }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream();
            byte[] jk = dBDS.rengen.FindByid_rengen(Convert.ToInt32(treeView1.SelectedNode.Name)).photo_rg;
            foreach (byte j in jk)
            {
                mem.WriteByte(j);
            }
            Image img = Image.FromStream(mem);
            pictureBox1.Image = img;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog.FileName);
                if (img != null)
                {
                    DescForRengen mf = new DescForRengen();
                    if (mf.ShowDialog() != DialogResult.OK) return;
                    MemoryStream f = new MemoryStream();
                    img.Save(f, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] jake = f.ToArray();
                    rengenTableAdapter.Insert(DateTime.Today, patid, Docid, jake, description);
                    f.Close();
                   // pictureBox1.Image = img;
                }
                rengenTableAdapter.Fill(dBDS.rengen);
                FillTree();
                treeView1.SelectedNode = treeView1.Nodes[treeView1.Nodes.Count - 1];
            }
        }
    }
}
