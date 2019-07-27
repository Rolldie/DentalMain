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
    public partial class AdmPanelForm : Form
    {
        public AdmPanelForm()
        {
            InitializeComponent();
        }

        private void AdmPanelForm_Load(object sender, EventArgs e)
        {
            this.anamndis_diseasesTableAdapter.Fill(dBDS.anamndis_diseases);
            this.anamnesisDiseasesTableAdapter.Fill(dBDS.anamnesisDiseases);
            this.appointmentTableAdapter.Fill(dBDS.appointment);
            this.servicesTableAdapter.Fill(dBDS.services);
            this.materialsTableAdapter.Fill(dBDS.materials);
            this.possibleComplTableAdapter.Fill(dBDS.possibleCompl);
            this.possibleObjectiveTableAdapter.Fill(dBDS.possibleObjective);
            this.possiblePltsTableAdapter.Fill(dBDS.possiblePlts);
            this.doctorsTableAdapter.Fill(this.dBDS.doctors);
            this.patientsTableAdapter.Fill(this.dBDS.patients);
            this.diagnosisTableAdapter.Fill(this.dBDS.diagnosis);
            this.diags_patientTableAdapter.Fill(this.dBDS.diags_patient);
            this.appointment_servicesTableAdapter.Fill(this.dBDS.appointment_services);
            CreateList ();
        }
        public void CreateList()
        {
            List<TreeNode> f = new List<TreeNode>();
            foreach (dBDS.anamndis_diseasesRow m in dBDS.anamndis_diseases.Select("[delete]=true"))
            {
                f.Add(new TreeNode("Объект - анамнез хвороби: " + m.name_disease));
            }
            foreach (dBDS.anamnesisDiseasesRow m in dBDS.anamnesisDiseases.Select("[delete]=true"))
            {
                f.Add(new TreeNode("Объект - анамнез хвороби пацієнта: " +m.patientsRow.full_name+" "+ m.anamndis_diseasesRow.name_disease));
            }
            foreach (dBDS.appointmentRow m in dBDS.appointment.Select("[delete]=true"))
            {
                f.Add(new TreeNode("Объект - прийом: " + m.doctorsRow.full_name + " " + m.patientsRow.full_name+" "+m.date_appointm+" "+m.time));
            }
            foreach (dBDS.diagnosisRow m in dBDS.diagnosis.Select("[delete]=true"))
            {
                f.Add(new TreeNode("Объект - діагнози: " + m.name_diag));
            }
            foreach(dBDS.diags_patientRow fm in dBDS.diags_patient.Select("[delete]=true"))
            {
                f.Add(new TreeNode("Объект - диагноз пациента :" + fm.diagnosisRow.name_diag + " " + fm.tooth));
            }
            foreach (dBDS.diseases_anamRow m in dBDS.diseases_anam.Select("[delete]=true"))
            {
                f.Add(new TreeNode("Объект - анамнез(інші): " + m.disease_name + " " + m.type_anamn));
            }
            foreach(dBDS.doctorsRow m in dBDS.doctors.Select("[fired]=true"))
            {
                f.Add(new TreeNode("Объект - Лыкар: " + m.full_name + " " + m.phone_number));
            }
            foreach (dBDS.materialsRow m in dBDS.materials.Select("[delete]=true"))
            {
                f.Add(new TreeNode("Объект - матеріал: " + m.name_material + " " + m.cost));
            }
            foreach (dBDS.patientsRow m in dBDS.patients.Select("[delete]=true"))
            {
                f.Add(new TreeNode("Объект - Пациенты: " + m.full_name + " " + m.phone_number));
            }
            foreach (dBDS.possibleComplRow m in dBDS.possibleCompl.Select("[delete]=true"))
            {
                f.Add(new TreeNode("Объект - Скарги: " + m.description_compl));
            }
            foreach (dBDS.possibleObjectiveRow m in dBDS.possibleObjective.Select("[delete]=true"))
            {
                f.Add(new TreeNode("Объект - Об'єктивні дані: " + m.description_objective));
            }
            foreach (dBDS.possiblePltsRow m in dBDS.possiblePlts.Select("[delete]=true"))
            {
                f.Add(new TreeNode("Объект - записи плану лікування: " + m.name_plts));
            }
            foreach (dBDS.servicesRow m in dBDS.services.Select("[delete]=true"))
            {
                TreeNode mk=new TreeNode("Объект - Послуги: " + m.name_service+" " +m.cost);
                f.Add(mk);
            }
            treeView1.Nodes.AddRange(f.ToArray());
        }
        public void RecursFindChilds(dBDS.anamndis_diseasesDataTable f)
        {
            
        }
        public void RecursFindChilds(dBDS.anamnesisDataTable f)
        {
            
        }
    }
}
