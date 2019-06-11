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
    public partial class DocChange : Form
    {
        public DocChange(int key)
        {
            InitializeComponent();
            docid = key;
           
        }
        int docid;

        public void ThreadingUpdate()
        {
            Updater();
        }

        public delegate void frst();

        public void Updater()
        {
            this.doctorsTableAdapter.Fill(dBDS.doctors);
            this.post_doctorTableAdapter.Fill(dBDS.post_doctor);
            this.postTableAdapter.Fill(dBDS.post);
            DocChange f = this as DocChange;
            while (f == null) Thread.Sleep(5);
            //Ожидание окончания создания формы в потоке
            frst a = new frst(InitTree);
            BeginInvoke(a);
            a = new frst(FillTheControls);
            BeginInvoke(a);
        }

        public void InitTree()
        {
            bool am = true;
            foreach (dBDS.postRow a in dBDS.post)
            {
                PostTree.Nodes.Add(a.id_post_doc.ToString(), a.name_post); am = false;
            }
            if (am)
            {
                MessageBox.Show("Жодної посади було додано, щоб додати лікаря, додайте посаду");
                Posts f = Application.OpenForms["Posts"] as Posts;
                if (f is null)
                {
                    f = new Posts();
                    f.MdiParent = Application.OpenForms["MainForm"] as MainForm;
                    f.Show();
                }
                else
                {
                    f.Activate();
                }
                Close();
            }
        }
        public void FillTheControls()
        {
            foreach(dBDS.post_doctorRow s in dBDS.post_doctor.Select("doctor='"+docid+"'"))
            {
                PostTree.Nodes[s.post.ToString()].Checked = true;
            }
            textBox1.Text =Text= dBDS.doctors.FindByid_doctor(docid).full_name.ToString();
        }
        public bool IsChecked()
        {
            bool checker = true;
            for (int i = 0; i < dBDS.post.Count(); i++)
            { if (PostTree.Nodes[i].Checked) checker = false; }
            if (checker) return false;
            else return true;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && IsChecked())
            {
                dBDS.doctors.FindByid_doctor(docid).full_name = textBox1.Text;
                doctorsTableAdapter.Update(dBDS.doctors);
                foreach (TreeNode m in PostTree.Nodes)
                {
                    if (dBDS.post_doctor.Select("post='" + m.Name + "' and doctor='" + docid + "'").Count() == 0 && m.Checked)
                    {
                        post_doctorTableAdapter.Insert(Convert.ToInt32(m.Name), docid);
                    }
                    else if (m.Checked == false)
                    {
                        foreach (dBDS.post_doctorRow r in dBDS.post_doctor.Select("post='" + m.Name + "' and doctor='" + docid + "'"))
                            post_doctorTableAdapter.Delete(r.id_post_doctor, r.post, r.doctor);
                    }
                }
                MainForm f = Application.OpenForms["MainForm"] as MainForm;
                f.DocUpdate();
                Close();
            }
            else App.Text = "Не введена ПІБ, або не було обрано посаду";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DocChange_Load(object sender, EventArgs e)
        {
            ThreadingUpdate();
        }
    }
}
