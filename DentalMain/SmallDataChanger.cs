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
    public partial class SmallDataChanger : Form
    {
        public SmallDataChanger(string UsPnt,TreeNode am)
        {
            InitializeComponent();
            usepoint = UsPnt;
            indofdata = Convert.ToInt32(am.Name);
            prevdata = am.Text;
        }
        public SmallDataChanger(string UsPnt,TreeNode am, string nesc)
        {
            InitializeComponent();
            usepoint = UsPnt;
            indofdata = Convert.ToInt32(am.Name);
            prevdata = am.Text;
            typeofanm = nesc;
            
        }
        string usepoint;
        int indofdata;
        string prevdata,typeofanm;
        
        public void UsePointFinder()
        {
            if (usepoint == "Compl")
            {
                possibleComplTableAdapter.Fill(dBDS.possibleCompl);
            }
            else if (usepoint == "AnmAll")
            {
                diseases_anamTableAdapter.Fill(dBDS.diseases_anam);
            }
            else if (usepoint == "Pln")
            {
                possiblePltsTableAdapter.Fill(dBDS.possiblePlts);
            }
            else if (usepoint == "AnmDis")
            {
                anamndis_diseasesTableAdapter.Fill(dBDS.anamndis_diseases);
            }
            else if (usepoint == "Diag")
            {
                diagnosisTableAdapter.Fill(dBDS.diagnosis);
            }
            else if(usepoint=="Obj")
            {
                possibleObjectiveTableAdapter.Fill(dBDS.possibleObjective);
            }
            FillTxtBx();
        }
        public void FillTxtBx()
        {
            if (usepoint == "Compl")
            {
                textBox1.Text = dBDS.possibleCompl.FindByid_compl(indofdata).description_compl;
            }
            else if (usepoint == "AnmAll")
            {
                textBox1.Text=dBDS.diseases_anam.FindByid_disease_anam(indofdata).disease_name;
            }
            else if (usepoint == "Pln")
            {
                textBox1.Text=dBDS.possiblePlts.FindByid_possiblPlts(indofdata).name_plts;
            }
            else if (usepoint == "AnmDis")
            {
                textBox1.Text=dBDS.anamndis_diseases.FindByid_disease(indofdata).name_disease;
            }
            else if (usepoint == "Diag")
            {
                textBox1.Text = dBDS.diagnosis.FindByid_diag(indofdata).name_diag;
            }
            else if( usepoint=="Obj")
            {
                textBox1.Text = dBDS.possibleObjective.FindByid_objective(indofdata).description_objective;
            }
        }
        private void SmallDataChanger_Load(object sender, EventArgs e)
        {
            UsePointFinder();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string jk = textBox1.Text.ToLower();
            if (usepoint == "Compl")
            {
                possibleComplTableAdapter.Update(jk,false, indofdata, prevdata,false);
            }
            else if (usepoint == "AnmAll")
            {
                diseases_anamTableAdapter.Update(jk, typeofanm,false, indofdata, prevdata, typeofanm,false);
            }
            else if (usepoint == "Pln")
            {
                possiblePltsTableAdapter.Update(jk,false, indofdata, prevdata,false);
            }
            else if (usepoint == "AnmDis")
            {
                anamndis_diseasesTableAdapter.Update(jk,false, indofdata, prevdata,false);
            }
            else if (usepoint == "Diag")
            {
                diagnosisTableAdapter.Update(jk,false, indofdata, prevdata,false);
            }
            else if(usepoint=="Obj")
            {
                possibleObjectiveTableAdapter.Update(jk,false, indofdata, prevdata,false);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
