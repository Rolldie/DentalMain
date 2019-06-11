using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
    }
    public static class StDb
    {
        public static dBDS.appointmentDataTable db = new dBDS.appointmentDataTable();
        public static dBDS DB = new dBDS();
    }
}