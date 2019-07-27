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
    public partial class ServExp : Form
    {
        public ServExp()
        {
            InitializeComponent();
        }
        int a;
        private void button1_Click(object sender, EventArgs e)
        {
            try {a=Convert.ToInt32(textBox1.Text); ServicesAndPosts f = Application.OpenForms["ServicesAndPosts"] as ServicesAndPosts; f.GetCostFromServExp(a); Close();  }
            catch { App.Text = "Неправильно введена ціна, введіть 0 якщо не хочите вводити ціну"; }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            App.ChangeObjectText(sender);
        }
    }
}
