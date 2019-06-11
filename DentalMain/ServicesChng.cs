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
    public partial class ServicesChng : Form
    {
        public ServicesChng(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        int id;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                decimal f;
                decimal.TryParse(textBox2.Text, out f);
                servicesTableAdapter.Update(textBox1.Text.ToLower(), f, id, dBDS.services.FindByid_service(id).name_service, dBDS.services.FindByid_service(id).cost);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public void FillCntrls()
        {
            dBDS.servicesRow a = dBDS.services.FindByid_service(id);
            textBox1.Text = a.name_service;
            textBox2.Text = a.cost.ToString();
        }

        private void ServicesChng_Load(object sender, EventArgs e)
        {
            servicesTableAdapter.Fill(dBDS.services);
            FillCntrls();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
