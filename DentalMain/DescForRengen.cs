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
    public partial class DescForRengen : Form
    {
        public DescForRengen()
        {
            InitializeComponent();
        }
        public DescForRengen(string jade)
        {
            InitializeComponent();
            jade2 = jade;
        }
        string jade2;
        private void Button1_Click(object sender, EventArgs e)
        {
                if (Application.OpenForms["RengenForm"] is RengenForm f)
                { f.description = textBox1.Text; DialogResult = DialogResult.OK; }
                Close();
        }

        private void DescForRengen_Load(object sender, EventArgs e)
        {
            this.Activate();
            if (jade2 != null) { textBox1.Text = jade2; button1.Text = "Змінити опис"; }
        }
    }
}
