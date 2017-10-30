using Stimulsoft.Report;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int shMo = 0;
        string moName = "";
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        sacEntities ctx = new sacEntities();


        public partial class task1
        {
            public task1()
            { }
            public string taskCreationDate { get; set; }
            // public string taskDoneDate { get; set; }
            public string comment { get; set; }
            public string Moname { get; set; }
            public int tedad { get; set; }
            public string lastContract { get; set; }
            public string nameProduct { get; set; }
            public int countOfSys { get; set; }
            public int idcompany { get; set; }
            public int taskDoneUserID { get; set; }
            public int conventionTypeID { get; set; }
            public int CustomerID { get; set; }
            public int CompanyID { get; set; }
            public int departmentID { get; set; }
            public int phaseID { get; set; }
            public int projectID { get; set; }
            public int shmo { get; set; }



        }
        public static IQueryable<select_all_data> query2;

        public void MyquerysShowData()
        {
            List<select_all_data> query1 = (from c in ctx.select_all_data.AsNoTracking() select c).ToList();
            query2 = query1.AsQueryable();
            if (chbxcompany.Checked && cmbcompany.Items.IndexOf(cmbcompany.Items.ToString()) != 0)
            {
                query2 = query2.Where(c => c.CompanyID == cmbcompany.Items.IndexOf(cmbcompany.SelectedItem) + 1);
                if (chbxdeparment.Checked && cmbdepartment.Items.IndexOf(cmbdepartment.Items.ToString()) != 0)
                {
                    query2 = query2.Where(d => d.departmentID.Value == cmbdepartment.Items.IndexOf(cmbdepartment.SelectedItem) + 1);
                    if (chbxproject.Checked && cmbproject.Items.IndexOf(cmbproject.Items.ToString()) != 0)
                    {
                        query2 = query2.Where(p => p.projectID.Value == cmbproject.Items.IndexOf(cmbproject.SelectedItem) + 1);
                        if (chbxphase.Checked && cmbphase.Items.IndexOf(cmbphase.Items.ToString()) != 0)
                        {
                            query2 = query2.Where(ph => ph.phaseID.Value == cmbphase.Items.IndexOf(cmbphase.SelectedItem) + 1);
                        }
                    }
                }
            }
            if (chbxusername.Checked && cmbusername.Items.IndexOf(cmbusername.Items.ToString()) != 0)
            {
                query2 = query2.Where(u => u.taskDoneUserID.Value == cmbusername.Items.IndexOf(cmbusername.SelectedItem) + 1);
            }
            if (chbxContract.Checked && cmbcontract.Items.IndexOf(cmbcontract.Items.ToString()) != 0)
            {
                query2 = query2.Where(cnt =>cnt.conventionTypeID.HasValue==true && cnt.conventionTypeID.Value== cmbcontract.Items.IndexOf(cmbcontract.SelectedItem) + 1);
                
            }

            if (chboxnameCustomers.Checked && shMo > 0)
            {
                query2 = query2.Where(cut => cut.SHMO == shMo);
            }
            if (chbxVersion.Checked && cmbversion.Items.IndexOf(cmbversion.Items.ToString()) != 0)
            {
                query2 = query2.Where(u => u.productID.HasValue==true && u.productID.Value == cmbversion.Items.IndexOf(cmbversion.SelectedItem) + 1);
            }
            dataGridView1.DataSource = query2.ToList();
            fcnfillrows();

        }


        public void fcnfillrows()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }
        public void departmantcombo()
        {
            var qdepartment = (from c in ctx.department
                               where
      c.companyTask.CompanyID == 1 + cmbcompany.SelectedIndex
                               select c).ToList();
            cmbdepartment.DataSource = qdepartment;
            cmbdepartment.ValueMember = "DepartmentID";
            cmbdepartment.DisplayMember = "DepartmentName";
        }
        public void fcn()
        {
            var qcompany = (from c in ctx.companyTask select c).ToList();
            cmbcompany.DataSource = qcompany;
            cmbcompany.ValueMember = "CompanyID";
            cmbcompany.DisplayMember = "CompanyName";


        }

        public void fcnProduct()
        {
            var qProduct = (from c in ctx.product select c).ToList();
            cmbversion.DataSource = qProduct;
            cmbversion.ValueMember = "productID";
            cmbversion.DisplayMember = "name";


        }


        public void fcnProjects()
        {
            var qcompany = (from p in ctx.project
                            join
     s in ctx.ShareProjectToDepartment on
     p.ProjectID equals s.project.ProjectID
                            join d in ctx.department on s.department.DepartmentID equals 1 + cmbdepartment.SelectedIndex
                            select p).Distinct().ToList();
            cmbproject.DataSource = qcompany;
            cmbproject.ValueMember = "ProjectID";
            cmbproject.DisplayMember = "ProjectName";

        }
        public void fcnphases()
        {
            var qphase = (from c in ctx.Phase
                          where
      c.project.ProjectID == 1 + cmbproject.SelectedIndex
                          select c).ToList();
            cmbphase.DataSource = qphase;
            cmbphase.ValueMember = "PhaseID";
            cmbphase.DisplayMember = "PhaseName";
        }
        public void fcnusers()
        {
            var qusers = (from c in ctx.user select c).ToList();
            cmbusername.DataSource = qusers;
            cmbusername.ValueMember = "Userid";
            cmbusername.DisplayMember = "UserName";
        }

        public void fcncontracts()
        {
            var qusers = (from c in ctx.conventionType select c).ToList();
            cmbcontract.DataSource = qusers;
            cmbcontract.ValueMember = "conventionTypeID";
            cmbcontract.DisplayMember = "name";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MyquerysShowData();            // dataGridView1.DataSource = query2.ToList();
        }

        private void chboxnameCustomers_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxnameCustomers.Checked)
            {
                ShowCustomers shcust = new ShowCustomers();
                shcust.ShowDialog();
                shMo = ShowCustomers.passdata.shMo;
                moName = ShowCustomers.passdata.moName;
                txtNameCustomers.Text = moName;
            }
        }

        private void cmbcompany_Enter(object sender, EventArgs e)
        {

        }

        private void cmbcompany_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmbcompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcompany.SelectedItem != null)
            {
                cmbdepartment.ResetText();
                if (cmbdepartment.Enabled)
                {
                    departmantcombo();
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxcompany.Checked)
            {
                fcn();
                cmbdepartment.ResetText();
                cmbcompany.Enabled = true;
                cmbusername.ResetText();
                cmbproject.ResetText();
            }
            else
                cmbcompany.Enabled = false;
            cmbdepartment.Enabled = false;
            chbxdeparment.Checked = false;
            chbxproject.Checked = false;
            cmbproject.Enabled = false;
            cmbusername.Enabled = false;
            chbxphase.Checked = false;
            cmbphase.ResetText();
            cmbdepartment.ResetText();
            cmbusername.ResetText();
            cmbproject.ResetText();
           // cmbcompany.ResetText();
        }

        private void chbxdeparment_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxcompany.Checked && chbxdeparment.Checked && cmbcompany.Enabled)
            {
                cmbdepartment.Enabled = true;
                departmantcombo();
                cmbusername.ResetText();
                cmbproject.ResetText();
            }
            else
            {
                cmbdepartment.Enabled = false;
                chbxproject.Checked = false;
                cmbproject.Enabled = false;
                cmbusername.Enabled = false;
                chbxphase.Checked = false;
                cmbusername.ResetText();
                cmbproject.ResetText();
                cmbdepartment.ResetText();
                cmbphase.ResetText();
            }
        }

        private void chbxproject_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxproject.Checked && chbxdeparment.Checked && cmbdepartment.Enabled)
            {
                cmbproject.Enabled = true;
                cmbproject.ResetText();
                fcnProjects();
                cmbusername.ResetText();
            }
            else
            {
                cmbproject.Enabled = false;
                cmbusername.Enabled = false;
                chbxphase.Checked = false;
                cmbproject.ResetText();
                cmbusername.ResetText();
                cmbphase.ResetText();
            }
        }

        private void chbxphase_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbproject.Enabled && chbxphase.Checked)
            {
                cmbusername.ResetText();
                fcnphases();
                cmbphase.Enabled = true;
            }
            else
                cmbphase.Enabled = false;
            cmbusername.ResetText();
            cmbphase.ResetText();

        }

        private void chbxusername_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxusername.Checked)
            {
                cmbusername.Enabled = true;
                fcnusers();

            }
            else
            {
                cmbusername.Enabled = false;
            }
        }

        private void chbxContract_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxContract.Checked)
            {
                cmbcontract.ResetText();
                cmbcontract.Enabled = true;
                fcncontracts();
            }
            else
            {
                cmbcontract.ResetText();
                cmbcontract.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyquerysShowData();
        }

        private void chbxVersion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxVersion.Checked)
            {
                cmbversion.ResetText();
                fcnProduct();
                cmbversion.Enabled = true;
            }
            else
            {
                cmbversion.Enabled = false;
                cmbversion.ResetText();
            }

        }

        private void cmbcontract_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StiReport st = new StiReport();
            string Path = @"Report\stiReport1.mrt";
            st.Load(Path);
            st.RegBusinessObject("CRMObject", query2.ToList()); // نام شیئی که در دیزانر ایجاد کردیم
            st.Dictionary.SynchronizeBusinessObjects(2);
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myTXTDate1.getYear().ToString() + "/" + myTXTDate1.getMonth().ToString() + "/" + myTXTDate1.getDay().ToString());
        }
    }
}
