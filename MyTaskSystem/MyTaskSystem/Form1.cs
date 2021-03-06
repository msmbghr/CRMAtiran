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
        taskingEntities context;
        int Id = 0;
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
            txteditProvity.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txteditNameCustoemrs.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            rcheditdescriptions.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string[] s = dataGridView1.CurrentRow.Cells[5].Value.ToString().Split('/');
            myTXTDate2.setYear = int.Parse(s[0]);
            myTXTDate2.setMonth = int.Parse(s[1]);
            myTXTDate2.setday = int.Parse(s[2]);
            Id=int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tblTask tblsave = context.tblTask.Where(c => c.id == Id).FirstOrDefault<tblTask>();
            if (tblsave!=null)
            {
                string dateEditTask = myTXTDate2.getYear().ToString() + "/" + myTXTDate2.getMonth().ToString() + "/" + myTXTDate2.getDay().ToString();
                tblsave.priority =int.Parse( txteditProvity.Text);
                tblsave.nameCustomer = txteditNameCustoemrs.Text;
                tblsave.description = rcheditdescriptions.Text;
                tblsave.dateDone = dateEditTask;
                if (chbxEditDone.Checked)
                    tblsave.done = true;
                else
                {
                    tblsave.done = false;
                }
                context.Entry(tblsave).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("اطلاعات با موفقيت ويرايش شد");
            }
            ShowAllData();
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
            context = new taskingEntities();
            var q = from c in context.tblTask orderby c.priority descending select c;
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
        public void cleartxt()
        {
            txtPrivoty.ResetText();
            txtCustomers.ResetText();
            rchtxtTasks.ResetText();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            string dateTask = myTXTDate1.getYear().ToString() + "/" + myTXTDate1.getMonth().ToString() + "/" + myTXTDate1.getDay().ToString();
            context = new taskingEntities();
            tblTask tbl = new tblTask();
            tbl.priority = int.Parse(txtPrivoty.Text);
            tbl.nameCustomer = txtCustomers.Text;
            tbl.description = rchtxtTasks.Text;
            if (chbxDone.Checked)
                tbl.done = true;
            tbl.dateDone = dateTask;
            context.tblTask.Add(tbl);
            context.SaveChanges();
            ShowAllData();
            cleartxt();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            panelEdit.Visible = true;
            txteditProvity.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txteditNameCustoemrs.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            rcheditdescriptions.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string[] s = dataGridView1.CurrentRow.Cells[5].Value.ToString().Split('/');
            myTXTDate2.setYear = int.Parse(s[0]);
            myTXTDate2.setMonth = int.Parse(s[1]);
            myTXTDate2.setday = int.Parse(s[2]);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
