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
    public partial class Appointm_Material : Form
    {
        public Appointm_Material(string Posl, string Mat)
        {
            InitializeComponent();
            Matlab.Text = Mat;
            ServLab.Text = Posl;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MainForm"] is MainForm f)
            {
                int m;
                int.TryParse(textBox1.Text, out m);
                if (m != 0)
                {
                    f.CountForMat = m; DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    App.Text = "Не правильно введені данні";
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            App.ChangeObjectText(sender);
        }
    }
}
