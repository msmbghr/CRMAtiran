using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTaskSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void myTXTDate1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                {
                    e.SuppressKeyPress = true;

                    SendKeys.Send("{TAB}");
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelEdit.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }
        
        taskingEntities t=new taskingEntities().Database.Connection=connections._connectionString;
        public void showAllData()
        {
            t.Configuration
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
