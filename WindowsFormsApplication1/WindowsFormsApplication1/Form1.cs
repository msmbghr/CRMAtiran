using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Opacity20 c = new Opacity20();
            c.ShowDialog();
            int i = Mbox.intBox;
            if (i==1)
            {
                label1.Text = "شما تاييد كرديد";
            }
            if (i==2)
            {
                label1.Text = "شما انصراف داديد";

            }
        }
    }
}
