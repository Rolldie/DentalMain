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
    public partial class PostChng : Form
    {
        public PostChng(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        int id;


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!="")
            {
                postTableAdapter.Update(textBox2.Text, id, dBDS.post.FindByid_post_doc(id).name_post);
                DialogResult = DialogResult.OK;
                if (Application.OpenForms["ServicesAndPosts"] is ServicesAndPosts c) c.PostUpdate();
                Close();
            }
        }

        private void PostChng_Load(object sender, EventArgs e)
        {
            postTableAdapter.Fill(dBDS.post);
            FillContr();
            textBox2.Focus();
        }

        public void FillContr()
        {
            textBox2.Text = dBDS.post.FindByid_post_doc(id).name_post;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
