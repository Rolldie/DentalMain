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
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
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
            }
            else return;

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
                App.Text = "somethingHappened";
                DescForRengen mf = new DescForRengen();
                if (mf.ShowDialog()  != DialogResult.OK) return;
                MemoryStream f = new MemoryStream();
                img.Save(f, System.Drawing.Imaging.ImageFormat.Png);
                byte[] jake = f.ToArray();
                rengenTableAdapter.Insert(DateTime.Today, patid, Docid, jake,description);
            }
            rengenTableAdapter.Fill(dBDS.rengen);
            FillTree();
            
        }
        TreeNode fm;
        private void TreeView1_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode f=treeView1.GetNodeAt(e.Location);
            if(f!=null)
            {
                fm = f;
                treeView1.SelectedNode = f;
                contextMenuStrip.Show(treeView1, e.Location);
            }
        }

        private void ЗмінитиОписToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DescForRengen f = new DescForRengen(dBDS.rengen.FindByid_rengen(Convert.ToInt32(fm.Name)).description);
            f.ShowDialog();
            //this.rengenTableAdapter.Update()
        }
    }
}
