using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace DentalMain
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConnectFrm a = new ConnectFrm();
            if (a.ShowDialog() == DialogResult.OK)
                Application.Run(new MainForm());
            else
                Application.Exit();
        }
    }
    public static class App
    {
        private static string text;
        public static string Text
        {
            get { return text; }
            set
            {
                text = value;
                MainForm a = Application.OpenForms["MainForm"] as MainForm;
                if (a != null)
                { a.ChangeStBr(text); }
            }
        }
        private static int mode;
        public static int Mode
        {
            get { return mode;}
            set { mode = value; }
        }
        public static void ChangeObjectText(object sender)
        {
            if(sender is TextBox f)
            {
                Decimal.TryParse(f.Text, out decimal ValForAdd);
                if (ValForAdd == 0)
                {
                    f.ForeColor = Color.Red;

                }
                else
                {
                    f.ForeColor = Color.Black;
                }
            }
        }
        public static void ChangeObjectTextTime(object sender)
        {
            if (sender is TextBox f)
            {
                DateTime.TryParse(f.Text, out DateTime ValForAdd);
                if (ValForAdd == DateTime.MinValue)
                {
                    f.ForeColor = Color.Red;

                }
                else
                {
                    f.ForeColor = Color.Black;
                }
            }
            else if(sender is MaskedTextBox mf)
            {
                DateTime.TryParse(mf.Text, out DateTime ValForAdd);
                if (ValForAdd == DateTime.MinValue)
                {
                    mf.ForeColor = Color.Red;

                }
                else
                {
                    mf.ForeColor = Color.Black;
                }
            }
        }
    }
    public static class StDb
    {
        public static dBDS.appointmentDataTable db = new dBDS.appointmentDataTable();
        public static dBDS DB = new dBDS();
    }
}