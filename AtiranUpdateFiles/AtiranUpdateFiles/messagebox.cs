using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtiranUpdateFiles
{
    public partial class messagebox : Form
    {
        public messagebox()
        {
            InitializeComponent();
        }
        public static string str { get; set; }
        public static string btnok { get; set; }
        public static string btncancel { get; set; }
        public static int sh { get; set; }


        private void messagebox_Load(object sender, EventArgs e)
        {
            Mainmessagebox m = new Mainmessagebox();
            m.ShowDialog();
            this.Close();
        }

        public void gettext(string msg,string btnOk,string btnCancel,int SH)
        {
            str = msg;
            btnok = btnOk;
            btncancel = btnCancel;
            sh = SH;
        }
    }
}
