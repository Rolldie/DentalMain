using System;
using System.Xml.Serialization;
using System.IO;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Text;
using System.Windows.Forms;

namespace DentalMain
{
    public partial class ConnectFrm : Form
    {
        public ConnectFrm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Application.StartupPath;
        }
        string constr;
        public bool ShakeConnection()
        {
            try
            {
                this.doctorsTableAdapter1.Fill(this.dBDS.doctors);
                this.appointment_servicesTableAdapter1.Fill(this.dBDS.appointment_services);
                this.appointmentTableAdapter1.Fill(this.dBDS.appointment);
                this.anamnesisTableAdapter.Fill(this.dBDS.anamnesis);
                this.planletsTableAdapter1.Fill(this.dBDS.planlets);
                this.diags_patientTableAdapter1.Fill(this.dBDS.diags_patient);
                this.complaintsTableAdapter1.Fill(this.dBDS.complaints);
                this.patientsTableAdapter1.Fill(this.dBDS.patients);
                this.possibleComplTableAdapter1.Fill(this.dBDS.possibleCompl);
                this.diseases_anamTableAdapter1.Fill(dBDS.diseases_anam);
                this.postTableAdapter1.Fill(dBDS.post);
                this.servicesTableAdapter1.Fill(dBDS.services);
                this.post_servicesTableAdapter1.Fill(dBDS.post_services);
                this.post_doctorTableAdapter1.Fill(dBDS.post_doctor);
                this.materialsTableAdapter1.Fill(dBDS.materials);
                this.serv_materialTableAdapter1.Fill(dBDS.serv_material);
                this.appointment_materialsTableAdapter1.Fill(dBDS.appointment_materials);
                label1.Text = "Проверка підключення закінчена"; return true;
            }
            catch{ label1.Text = "Не всі данні були отримані, або не було знайдено потрібну базу."; label2.Text = "Оберіть правильну базу даниї, бо закрийте программу."; button1.Enabled = true; return false; }
        }
        public class PropCon
        {
            public string ConnectionStr;

        }
        PropCon amn = new PropCon();
        private void ConnectFrm_Load(object sender, EventArgs e)
        {
            XmlSerializer a = new XmlSerializer(typeof(PropCon));
            try
            {
                using (FileStream u = new FileStream("Connection.xml", FileMode.Open))
                {
                    amn = (PropCon)a.Deserialize(u);
                    DentalMain.Properties.Settings.Default.ChangeCstr(amn.ConnectionStr);
                    DentalMain.Properties.Settings.Default.Save();
                    if (ShakeConnection())
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                
            }
            catch { label1.Text = "Це перший запуск, будьласка оберіть розположення БД"; button1.Enabled = true; }
            
        }
        public void CreateFileAndConnect()
        {
            XmlSerializer a = new XmlSerializer(typeof(PropCon));
            using (FileStream u = new FileStream("Connection.xml", FileMode.Create))
            {
                a.Serialize(u, amn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                constr = openFileDialog1.FileName;
                amn.ConnectionStr = constr;
                CreateFileAndConnect();
                DentalMain.Properties.Settings.Default.ChangeCstr(amn.ConnectionStr);
                DentalMain.Properties.Settings.Default.Save();
            }
            else return;
            DialogResult = DialogResult.OK;
            Close();
            
        }
    }
}
