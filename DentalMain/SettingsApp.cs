using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalMain
{
    public partial class SettingsApp : Form
    {
        public SettingsApp(int a,int b)
        {
            InitializeComponent();
            RadioButton am = WorkMode.Controls["Rad" + b] as RadioButton;
            try { am.Checked = true; } catch { Rad2.Checked = true; }
            if (b == 1) DoctorGet.Enabled = false;
            ak = a;
        }
        int ak;
        private void DocIn_CheckedChanged(object sender, EventArgs e)
        {
            DoctorGet.Enabled = true;
        }

        private void ALLIn_CheckedChanged(object sender, EventArgs e)
        {
            DoctorGet.Enabled =true;
        }

        private void RegIn_CheckedChanged(object sender, EventArgs e)
        {
            DoctorGet.Enabled = false;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            UpdateDoc();
            DoctorGet.SelectedValue = ak;
        }
        
        public void UpdateDoc()
        {
            this.doctorsTableAdapter.Fill(this.dBDS.doctors);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm f = Application.OpenForms["MainForm"] as MainForm;
            if (Rad1.Checked) { f.SaveProp(0, 1); }
            else if (Rad2.Checked)
            {
                if (DoctorGet.Text=="") { MessageBox.Show("Не выбран врач! Если нет врача, которого можно выбрать, то добавьте его."); return; }
                DialogResult = DialogResult.OK;
                f.SaveProp((int)DoctorGet.SelectedValue, 2);
            }
        }

        private void DoctorGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void BtnChangeCon_Click(object sender, EventArgs e)
        {
            using (FileStream a = new FileStream("Connection.xml", FileMode.Truncate)) { a.Close(); }
            Application.Restart();
        }
    }
}
