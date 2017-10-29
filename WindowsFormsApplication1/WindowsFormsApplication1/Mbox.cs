using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace WindowsFormsApplication1
{

    public partial class Mbox : Form
    {
        [Category("Appearance")]
        [Description("The text displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public override string Text
        {
            
            set
            {
                label2.Text = value;
            }
        }
        public static int intBox { get; set; }
        public Mbox()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            intBox = 1;
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            intBox=2;
            this.Close();
        }

        private void Mbox_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Mbox_Load(object sender, EventArgs e)
        {
            label2.Text = this.Text;
        }
    }
}
