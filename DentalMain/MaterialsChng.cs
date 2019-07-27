using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace DentalMain
{
    public partial class MaterialsChng : Form
    {
        public MaterialsChng(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        int id;

        private void MaterialsChng_Load(object sender, EventArgs e)
        {
            materialsTableAdapter.Fill(dBDS.materials);
            FillControls();
        }

        public void FillControls()
        {
            dBDS.materialsRow a = dBDS.materials.FindByid_material(id);
            MatTextBox.Text = a.name_material;
            CostTextBox.Text = a.cost.ToString();
            if (a.image!=null)
            {
                MemoryStream memstr = new MemoryStream();
                foreach (byte a1 in a.image)
                {
                    memstr.WriteByte(a1);
                }
                pictureBox1.Image = Image.FromStream(memstr);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(MatTextBox.Text!="")
            {
                decimal f;
                decimal.TryParse(CostTextBox.Text.Replace(".", ","), out f);
                MemoryStream memstr = new MemoryStream();
                Image img = pictureBox1.Image ;
                byte[] b;
                if (img != null)
                {
                    img.Save(memstr, System.Drawing.Imaging.ImageFormat.Png);
                    b = memstr.ToArray();
                }
                else b = null;
                dBDS.materialsRow a= dBDS.materials.FindByid_material(id);
                materialsTableAdapter.Update(MatTextBox.Text.ToLower(), f, b,false, a.id_material, a.name_material.ToLower(), a.cost,false);
                if (Application.OpenForms["MainForm"] is MainForm u) u.UpdateWithSavePos();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ImgDirTextBox.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            ImgDirTextBox.Text = "";
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            App.ChangeObjectText(sender);
        }
    }
}
