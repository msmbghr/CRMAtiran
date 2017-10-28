using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCRMAtiran
{
    public partial class ShowCustomers : Form
    {
        public ShowCustomers()
        {
            InitializeComponent();
        }
        public static IQueryable<CUSTOMERS1> query2;
        public List<CUSTOMERS1> fuc()
        {
            sacEntities ctx = new sacEntities();
            var query = ctx.CUSTOMERS.Where(c => c.black_list == 0 && c.active == "t" && c.special == "f").OrderBy(c => c.SHMO).Select(o => new CUSTOMERS1
            {
                SHMO = o.SHMO,
                MONAME = o.MONAME,
                tell1 = o.tell1,
                addre = o.addre,
                cell = o.cell
            }).ToList();
            return query;
        }
        private void ShowCustomers_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            dataGridView1.DataSource = fuc();
            query2 = fuc().AsQueryable();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }
        public partial class CUSTOMERS1
        {
            public CUSTOMERS1()
            { }

            public int SHMO { get; set; }
            public string MONAME { get; set; }
            public string addre { get; set; }
            public string tell1 { get; set; }
            public string tell2 { get; set; }
            public string cell { get; set; }

        }

        private void ShowCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ShowCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ShowCustomers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void radioButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                  
                    if (dataGridView1.CurrentRow == null) return;
                    if (dataGridView1.CurrentRow.Index + 1 >= 0)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0];
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (dataGridView1.CurrentRow == null) return;
                    if (dataGridView1.CurrentRow.Index - 1 >= 0)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0];
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
                    }
                }
                if (e.KeyCode == Keys.PageDown)
                {

                    if (dataGridView1.CurrentRow == null) return;
                    if (dataGridView1.CurrentRow.Index + 1 >= 0)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 20].Cells[0];
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
                    }
                }
                if (e.KeyCode == Keys.PageUp)
                {
                    if (dataGridView1.CurrentRow == null) return;
                    if (dataGridView1.CurrentRow.Index - 1 >= 0)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 20].Cells[0];
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
                    }
                }

                #region searchcode
               
                #endregion
            }
            catch
            { }
           
            selectdataindatagrid(e);
        }
        public static class passdata
        {
            public static int shMo { get; set; }
            public static string moName { get; set; }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        public void selectdataindatagrid(KeyEventArgs e)
        {
            try
            {
                int sh = (int)dataGridView1.SelectedCells[0].Value;
                string mname = (string)dataGridView1.SelectedCells[1].Value;
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyValue == 13)
                {
                    passdata.shMo = 0;
                    passdata.moName = null;
                    DialogResult dr = MessageBox.Show(" آيا مشتري انتخاب شده شما  **  " + mname + "  ** مي باشد؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        passdata.shMo = sh;
                        passdata.moName = mname;
                        this.Close();
                    }

                    e.Handled = true;
                }
            }
            catch
            {
            }

        }
        private void dataGridView1_KeyDown_1(object sender, KeyEventArgs e)
        {
            selectdataindatagrid(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rdbCode.Checked)
            {
                if (textBox1.Text == null || textBox1.Text == "")
                {
                    dataGridView1.DataSource = fuc();
                }
                else
                {
                    query2 = query2.Where(c => c.SHMO == (int.Parse(textBox1.Text)));
                    dataGridView1.DataSource = query2.ToList();
                }
            }
            if (rdbname.Checked)
            {
                if (textBox1.Text == null || textBox1.Text == "")
                {
                    dataGridView1.DataSource = fuc();
                }
                else
                {
                    query2 = query2.Where(c => c.MONAME==textBox1.Text);
                    dataGridView1.DataSource = query2.ToList();
                }
            }
            if (rdbIntoName.Checked)
            {
                if (textBox1.Text == null || textBox1.Text == "")
                {
                    dataGridView1.DataSource = fuc();
                }
                else
                {
                    query2 = query2.Where(c => c.MONAME.Contains(textBox1.Text));
                    dataGridView1.DataSource = query2.ToList();
                }
            }
        }
    }
}
