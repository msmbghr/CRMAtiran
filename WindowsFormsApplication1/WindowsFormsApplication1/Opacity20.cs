using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Opacity20 : Form
    {
        public Opacity20()
        {
            InitializeComponent();
        }
        private void Opacity20_Load(object sender, EventArgs e)
        {
            Mbox m = new Mbox();
            m.ShowDialog();
            this.Close();
        }
    }
}
