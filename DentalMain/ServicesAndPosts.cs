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
    public partial class ServicesAndPosts : Form
    {
        public ServicesAndPosts()
        {
            InitializeComponent();    
        }
        public delegate void frst();
        public delegate void scnd(List<TreeNode> k, List<string> mk);
        public void ThreadingUpdate()
        {
            Updating();
        }
        public void Updating()
        {
            this.postTableAdapter.Fill(this.dBDS.post);
            this.servicesTableAdapter.Fill(this.dBDS.services);
            this.post_servicesTableAdapter.Fill(this.dBDS.post_services);
            List<TreeNode>k = new List<TreeNode>();
            List<string> mk = new List<string>();
            foreach (dBDS.servicesRow a in dBDS.services)
            {
                k.Add(new TreeNode { Text = (string)a.name_service.ToLower(), Name = (string)a.id_service.ToString() });
                mk.Add((string)a.name_service.ToLower());
            }
            scnd ukra = new scnd(FillTree);
            BeginInvoke(ukra,k,mk);
            frst m = new frst(ResetBind);
            m += CheckPosts;
            BeginInvoke(m);
        }

        public void CheckPosts()
        {
            if (dBDS.post.Count()==0)
            {
                if (MessageBox.Show("Будь ласка додайте посаду!", "Додаток Стоматологія", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Posts f = Application.OpenForms["Posts"] as Posts;
                    if (f != null) { f.Activate(); }
                    else { f = new Posts(); f.ShowDialog(); }ThreadingUpdate();
                }
                else { Close(); }
            }
        }
        public void ResetBind()
        {
            postBindingSource.ResetBindings(false);
            postdocspostservicesBindingSource.ResetBindings(false);
        }

        private void ServicesAndPosts_Load(object sender, EventArgs e)
        {
            ThreadingUpdate();
        }

        private void postdocspostservicesBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {  
            try { Uncheck(); Check(); } catch { }
        }

        private void BtnAddPost_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Posts"] is Posts f) f.Close();
            f = new Posts();
            f.ShowDialog();
            ThreadingUpdate();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        public void FillTree(List<TreeNode> k, List<string> mk)
        {
            treeView1.Nodes.Clear();
            textBox1.AutoCompleteCustomSource.Clear();
            treeView1.BeginUpdate();
            treeView1.Nodes.AddRange(k.ToArray());
            treeView1.EndUpdate();
            textBox1.AutoCompleteCustomSource.AddRange(mk.ToArray());
        }

        public void Uncheck()
        {
            checker = false;
            foreach (TreeNode a in treeView1.Nodes)
            {
                a.Checked = false;
            }
            checker = true;
        }
        public void Check()
        {
            checker = false;
            foreach (dBDS.post_servicesRow a in dBDS.post_services.Select("post='" + comboBox1.SelectedValue + "'"))
            {
                treeView1.Nodes[a.service.ToString()].Checked = true;
            }
            checker = true;
        }

        public void ThreadPostServUpd()
        {
           post_servicesTableAdapter.Fill(dBDS.post_services);
           frst m = new frst(ResetBindCurPost);
           BeginInvoke(m);  
        }

        public void ThreadPostUpdate()
        {
            Thread m = new Thread(PostUpdate);
            m.IsBackground = true;
            m.Start();
        }

        public void PostUpdate()
        {
            postTableAdapter.Fill(dBDS.post);
            frst f = new frst(ResetBind);
            BeginInvoke(f);
        }

        public void ResetBindCurPost()
        {
            postdocspostservicesBindingSource.ResetBindings(false);
        }

        bool checker = true;
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (checker)
            {
                if (e.Node.Checked == true)
                {
                    post_servicesTableAdapter.Insert((int)comboBox1.SelectedValue, Convert.ToInt32(e.Node.Name));
                }
                else
                {
                    foreach (dBDS.post_servicesRow a in dBDS.post_services.Select("post='" + comboBox1.SelectedValue + "' and service='" +e.Node.Name+"'"))
                    {
                        post_servicesTableAdapter.Delete(a.id_post_serv, a.post, a.service);
                    }
                }
                Thread u = new Thread(ThreadPostServUpd);
                u.IsBackground = true; u.Start();
                if (Application.OpenForms["MainForm"] is MainForm mm) mm.UpdateWithSavePos();
            }
        }
        int ua = 0;
        public void GetCostFromServExp(int um)
        {
            ua = um;
        }

        private void BtnAddServ_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            { 
                if(dBDS.services.Select("name_service='"+textBox1.Text.ToLower()+"'").Count()==0)
                {
                    ServExp f = new ServExp();
                    f.ShowDialog();
                    servicesTableAdapter.Insert(textBox1.Text.ToLower(), ua);
                    servicesTableAdapter.Fill(dBDS.services);
                    post_servicesTableAdapter.Insert((int)comboBox1.SelectedValue, dBDS.services.Last().id_service);
                    post_servicesTableAdapter.Fill(dBDS.post_services);
                    checker = false;
                    treeView1.Nodes.Add(dBDS.services.Last().id_service.ToString(), textBox1.Text).Checked = true;
                    textBox1.AutoCompleteCustomSource.Add(textBox1.Text);
                    checker = true;
                }
                else if (dBDS.post_services.Select("service='" + dBDS.services.FindByid_service(Convert.ToInt32(treeView1.Nodes[textBox1.AutoCompleteCustomSource.IndexOf(textBox1.Text.ToLower())].Name)).id_service + "' and post='" + (int)comboBox1.SelectedValue + "'").Count()== 0)
                {
                    foreach(dBDS.servicesRow a in dBDS.services.Select("name_service='"+textBox1.Text.ToLower()+"'"))
                    {
                        treeView1.Nodes[a.id_service.ToString()].Checked = true;
                    } 
                }
                if (Application.OpenForms["MainForm"] is MainForm u) u.UpdateWithSavePos();
                else { App.Text = "Такий запис вже існує"; }
            }
            else
            {
                App.Text = "Назва послуги не введена";
            }
        }

        public void ResetBindServ()
        {
            servicesBindingSource.ResetBindings(false);
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BtnAddServ_Click(sender, new EventArgs());
            }
        }
    }
}
