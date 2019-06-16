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
    public partial class MaterialsAndServices : Form
    {
        public MaterialsAndServices()
        {
            InitializeComponent();
        }

        public delegate void frst();
        public delegate void scnd(List<TreeNode> k,List<string> mk,List<string> sk);

        private void MaterialsAndServices_Load(object sender, EventArgs e)
        {
            ThreadingUpdate();
            helpProvider1.HelpNamespace = Application.StartupPath + "//Help//help.chm";
        }

        public void ThreadingUpdate()
        {
            Updating();
        }

        public void CheckFull()
        {
            if (ServTree.Items.Count==0)
            {
                if (MessageBox.Show("Будь ласка додайте послугу!", "Додаток Стоматологія", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Application.OpenForms["Services"] is Services m) m.Close();
                    Services f = new Services();
                    f.ShowDialog(); 
                    ThreadingUpdate();
                }
                else { Close(); }
            }
        }
        public void UpdServ()
        {
            servicesTableAdapter.Fill(dBDS.services);
        }

        public void Updating()
        {
            materialsTableAdapter.Fill(dBDS.materials);
            servicesTableAdapter.Fill(dBDS.services);
            serv_materialTableAdapter.Fill(dBDS.serv_material);
            List<TreeNode> trees = new List<TreeNode>();
            List<string> mk = new List<string>();
            List<string> sk = new List<string>();
            foreach (dBDS.materialsRow a in dBDS.materials)
            {
                trees.Add(new TreeNode { Text = a.name_material.ToLower(), Name = a.id_material.ToString() });
                mk.Add(a.name_material);
            }
            foreach (dBDS.servicesRow a in dBDS.services) { sk.Add(a.name_service.ToLower()); }
            scnd del = new scnd(FillTreeAndSearch);
            BeginInvoke(del, trees,mk,sk);
            frst ded=new frst(CheckMatTree);
            ded += ResetBnd;
            ded += CheckFull;
            BeginInvoke(ded);
        }

        public void ResetBnd()
        {
            servicesBindingSource.ResetBindings(false);
        }
        public void FillTreeAndSearch(List<TreeNode> k,List<string> mk,List<string> sk)
        {
            MatTree.BeginUpdate();
            MatTree.Nodes.Clear();
            MatTree.Nodes.AddRange(k.ToArray());
            MatTree.EndUpdate();
            MatSearch.AutoCompleteCustomSource.Clear();
            MatSearch.AutoCompleteCustomSource.AddRange(mk.ToArray());
            ServSearch.AutoCompleteCustomSource.Clear();
            ServSearch.AutoCompleteCustomSource.AddRange(sk.ToArray());
        }

        public void UnCheckMatTree()
        {
            checker = false;
            foreach(TreeNode a in MatTree.Nodes)
            {
                a.Checked = false;
            }
            checker = true;
        }

        bool checker = true;
        public void CheckMatTree()
        {
            checker = false;
            try
            {
                foreach (dBDS.serv_materialRow a in dBDS.serv_material.Select("service='" + ServTree.SelectedValue+ "'"))
                {
                    MatTree.Nodes[a.material.ToString()].Checked = true;
                }
                checker = true;
            }
            catch { }
        }

        private void MatTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (checker)
            {
                if(e.Node.Checked)
                {
                    if(dBDS.serv_material.Select("service='"+ServTree.SelectedValue+"' and material='"+e.Node.Name+"'").Count()==0)
                    {
                        serv_materialTableAdapter.Insert((int)ServTree.SelectedValue, Convert.ToInt32(e.Node.Name));
                    }
                }
                else
                {
                    foreach(dBDS.serv_materialRow a in dBDS.serv_material.Select("service='" + ServTree.SelectedValue + "' and material='" + e.Node.Name + "'"))
                    {
                        serv_materialTableAdapter.Delete(a.id_serv_mat, a.service, a.material);  
                    }

                }
                serv_materialTableAdapter.Fill(dBDS.serv_material);
            }
        }

        private void ServSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ServTree.SelectedIndex = ServSearch.AutoCompleteCustomSource.IndexOf(ServSearch.Text.ToLower());
            }
            catch { }
        }

        private void MatSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MatTree.SelectedNode = MatTree.Nodes[MatSearch.AutoCompleteCustomSource.IndexOf(MatSearch.Text.ToLower())];
            }
            catch { }
        }
        public void UpdateForFormsMat()
        {
            ThreadingUpdate();
        }

        private void ServTree_SelectedValueChanged(object sender, EventArgs e)
        {
            UnCheckMatTree(); CheckMatTree();
        }

        private void BtnAddServ_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["Services"] is Services f)f.Close();
            f = new Services();
            f.ShowDialog();
        }

        private void BtnAddMat_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Materials"] is Materials f) f.Close();
            f = new Materials();
            f.ShowDialog();
        }
    }
}
