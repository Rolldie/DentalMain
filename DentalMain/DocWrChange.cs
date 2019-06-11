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
    public partial class DocWrChange : Form
    {
        public DocWrChange()
        {
            InitializeComponent();
        }

        private void DocWrChange_Load(object sender, EventArgs e)
        {
            Updating();
        }
        public void Updating()
        {
            this.docRecordLogTableAdapter.Fill(this.dBDS.docRecordLog);
            this.doctorsTableAdapter.Fill(this.dBDS.doctors);
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void DocWrChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["RecordLog"] is RecordLog f) f.Updating();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime TimeFrom, TimeTo, TimeBetw;
            DateTime.TryParse(textBox1.Text, out TimeFrom);
            DateTime.TryParse(textBox2.Text, out TimeTo);
            DateTime.TryParse(textBox3.Text, out TimeBetw);
            if(TimeFrom>DateTime.MinValue && TimeTo>DateTime.MinValue)
            {
                if(TimeBetw>DateTime.MinValue)
                {
                    while(TimeFrom<=TimeTo)
                    {
                        for(int i=0;i<groupBox1.Controls.Count;i++)
                        {
                            if ((groupBox1.Controls[i] as CheckBox).Checked && dBDS.docRecordLog.Select("doctor='"+
                                comboBox1.SelectedValue+"' and time='"+ Convert.ToDateTime(String.Format("{0: 30.12.1899 HH:mm}", TimeFrom)) +
                                "' and day_of_week='"+
                                Switcher(i)+"'").Count()==0 )
                            {
                                this.docRecordLogTableAdapter.Insert((int)comboBox1.SelectedValue, Convert.ToDateTime(String.Format("{0: 30.12.1899 HH:mm}", TimeFrom)), Switcher(i));
                            }
                        }
                        TimeFrom = TimeFrom.AddHours(TimeBetw.Hour).AddMinutes(TimeBetw.Minute).AddSeconds(TimeBetw.Second);
                    }
                }
                else
                {
                    for (int i = 0; i < groupBox1.Controls.Count; i++)
                    {
                        App.Text += groupBox1.Controls[i].Name;
                        if ((groupBox1.Controls[i] as CheckBox).Checked && dBDS.docRecordLog.Select("doctor='" + comboBox1.SelectedValue + "' and time='" + Convert.ToDateTime(String.Format("{0: 30.12.1899 HH:mm}", TimeFrom)) +
                            "' and day_of_week='" + Switcher(i) + "'").Count() == 0 && dBDS.docRecordLog.Select("doctor='" +
                            comboBox1.SelectedValue + "' and time='" + Convert.ToDateTime(String.Format("{0: 30.12.1899 HH:mm}", TimeTo)) +
                            "' and day_of_week='" + Switcher(i) + "'").Count()==0)
                        {
                            this.docRecordLogTableAdapter.Insert((int)comboBox1.SelectedValue, Convert.ToDateTime(String.Format("{0: 30.12.1899 HH:mm}", TimeFrom)), Switcher(i));
                            this.docRecordLogTableAdapter.Insert((int)comboBox1.SelectedValue, Convert.ToDateTime(String.Format("{0: 30.12.1899 HH:mm}", TimeTo)), Switcher(i));
                        }
                    }
                }
                this.docRecordLogTableAdapter.Fill(dBDS.docRecordLog);
            }

        }
        public string Switcher(int jk)
        {
            switch(jk)
            {
                case 0:
                    return "пн";
                case 1:
                    return "вт";
                case 2:
                    return "ср";
                case 3:
                    return "чт";
                case 4:
                    return "пт";
                case 5:
                    return "сб";
                case 6:
                    return "нд";
                default: return "";
            }
        }

        private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.docRecordLogTableAdapter.Update(dBDS.docRecordLog);
        }
    }
}
