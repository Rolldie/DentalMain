using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalMain
{
    public partial class UserControl1 : ErrorProvider
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public new void SetError(Control obj,string str)
        {
            //base.SetError(obj, str);
            if(obj is TextBox f)
            {
                Graphics m=null;
                m.FillRectangle(new SolidBrush(Color.Red), new Rectangle(f.Width - 100, f.Height + 100, f.Width, f.Height));
                
            }
        }


    }
}
