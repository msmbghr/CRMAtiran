﻿using System;
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
        taskingEntities t;
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
            txteditProvity.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
        }

        public void rdfs()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }
        public void ShowAllData()
        {
            t = new taskingEntities();
            var q = from c in t.tblTask select c;
            dataGridView1.DataSource = q.ToList();
            rdfs();

        }

        //taskingEntities t=new taskingEntities().Database.Connection=connections._connectionString;

        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panelEdit.Visible = false;

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            string dateTask = myTXTDate1.getYear().ToString() + "/" + myTXTDate1.getMonth().ToString() + "/" + myTXTDate1.getDay().ToString();
            t = new taskingEntities();
            tblTask tbl = new tblTask();
            tbl.priority =int.Parse( txtPrivoty.Text);
            tbl.nameCustomer = txtCustomers.Text;
            tbl.description = rchtxtTasks.Text;
            if (chbxDone.Checked)
                tbl.done = true;
            tbl.dateDone = dateTask;
            t.tblTask.Add(tbl);
            t.SaveChanges();
            MessageBox.Show("Test");
            ShowAllData();
        }
    }
}
