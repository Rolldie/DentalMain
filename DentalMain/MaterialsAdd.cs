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
    public partial class MaterialsAdd : Form
    {
        public MaterialsAdd()
        {
            InitializeComponent();
        }

        private void MaterialsAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDS.materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.dBDS.materials);

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
