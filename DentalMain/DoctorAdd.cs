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
    public partial class DoctorAdd : Form
    {
        public DoctorAdd()
        {
            InitializeComponent();
            postTableAdapter.Fill(dBDS.post);
            doctorsTableAdapter.Fill(dBDS.doctors);
            post_doctorTableAdapter.Fill(dBDS.post_doctor);
            InitTree();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                if (IsChecked())
                {
                    doctorsTableAdapter.Insert(textBox1.Text);
                    doctorsTableAdapter.Fill(dBDS.doctors);
                    for (int i=0;i<dBDS.post.Count;i++)
                    {
                        if (PostTree.Nodes[i].Checked) post_doctorTableAdapter.Insert(Convert.ToInt32(PostTree.Nodes[i].Name), dBDS.doctors.Last().id_doctor);
                    }
                    DialogResult = DialogResult.OK;
                    if (Application.OpenForms["RecordLog"] is RecordLog f) f.ThreadingUpdate();
                    Close();
                }
                else
                {
                    App.Text = "Не введены данные или не выбрана должность";
                }
            }
        }
        public bool IsChecked()
        {
            bool checker = true;
            for(int i=0;i<dBDS.post.Count();i++)
            { if (PostTree.Nodes[i].Checked) checker = false;  }
            if (checker) return false;
            else return true;
           
        }

        public void InitTree()
        {
            bool am = true;
            foreach(dBDS.postRow a in dBDS.post)
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
