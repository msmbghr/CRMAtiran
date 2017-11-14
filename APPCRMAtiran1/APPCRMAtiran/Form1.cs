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
        public static IQueryable<select_all_data> query3;


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
                query2 = query2.Where(cnt => cnt.conventionTypeID.HasValue == true && cnt.conventionTypeID.Value == cmbcontract.Items.IndexOf(cmbcontract.SelectedItem) + 1);

            }

            if (chboxnameCustomers.Checked && shMo > 0)
            {
                query2 = query2.Where(cut => cut.CustomerID == shMo);
            }
            if (chbxVersion.Checked && cmbversion.Items.IndexOf(cmbversion.Items.ToString()) != 0)
            {
                query2 = query2.Where(u => u.productID.HasValue == true && u.productID.Value == cmbversion.Items.IndexOf(cmbversion.SelectedItem) + 1);
            }
            if (chbxDate.Checked)
            {
                DateTime startdate = Convert.ToDateTime(myTXTDate1.getYear().ToString() + "/" + myTXTDate1.getMonth().ToString() + "/" + myTXTDate1.getDay().ToString());
                DateTime enddate = Convert.ToDateTime(myTXTDate2.getYear().ToString() + "/" + myTXTDate2.getMonth().ToString() + "/" + myTXTDate2.getDay().ToString());
                query2 = query2.Where(u => Convert.ToDateTime(u.taskCreationDate) >= startdate && Convert.ToDateTime(u.taskCreationDate) <= enddate);
            }
            dataGridView1.DataSource = query2.ToList();
            fcnfillrows();

        }
        public void MyquerysShowData2()
        {
            List<select_all_data> query1 = (from c in ctx.select_all_data.AsNoTracking() select c).ToList();
            query3 = query1.AsQueryable();
            if (chbxcompany2.Checked && cmbcompany2.Items.IndexOf(cmbcompany2.Items.ToString()) != 0)
            {
                query3 = query3.Where(c => c.CompanyID == cmbcompany2.Items.IndexOf(cmbcompany2.SelectedItem) + 1);
                if (chbxdeparment2.Checked && cmbdepartment2.Items.IndexOf(cmbdepartment2.Items.ToString()) != 0)
                {
                    query3 = query3.Where(d => d.departmentID.Value == cmbdepartment2.Items.IndexOf(cmbdepartment2.SelectedItem) + 1);
                    if (chbxproject2.Checked && cmbproject2.Items.IndexOf(cmbproject2.Items.ToString()) != 0)
                    {
                        query3 = query3.Where(p => p.projectID.Value == cmbproject2.Items.IndexOf(cmbproject2.SelectedItem) + 1);
                        if (chbxphase2.Checked && cmbphase.Items.IndexOf(cmbphase2.Items.ToString()) != 0)
                        {
                            query3 = query3.Where(ph => ph.phaseID.Value == cmbphase2.Items.IndexOf(cmbphase2.SelectedItem) + 1);
                        }
                    }
                }
            }
            if (chbxusername2.Checked && cmbusername2.Items.IndexOf(cmbusername2.Items.ToString()) != 0)
            {
                query3 = query3.Where(u => u.taskDoneUserID.Value == cmbusername2.Items.IndexOf(cmbusername2.SelectedItem) + 1);
            }
            if (chbxContract2.Checked && cmbcontract2.Items.IndexOf(cmbcontract2.Items.ToString()) != 0)
            {
                query3 = query3.Where(cnt => cnt.conventionTypeID.HasValue == true && cnt.conventionTypeID.Value == cmbcontract2.Items.IndexOf(cmbcontract2.SelectedItem) + 1);

            }

            if (chboxnameCustomers2.Checked && shMo > 0)
            {
                query3 = query3.Where(cut => cut.CustomerID == shMo);
            }
            if (chbxVersion2.Checked && cmbversion2.Items.IndexOf(cmbversion2.Items.ToString()) != 0)
            {
                query3 = query3.Where(u => u.productID.HasValue == true && u.productID.Value == cmbversion2.Items.IndexOf(cmbversion2.SelectedItem) + 1);
            }
            if (chbxDate2.Checked)
            {
                DateTime startdate = Convert.ToDateTime(myTXTDate3.getYear().ToString() + "/" + myTXTDate3.getMonth().ToString() + "/" + myTXTDate3.getDay().ToString());
                DateTime enddate = Convert.ToDateTime(myTXTDate4.getYear().ToString() + "/" + myTXTDate4.getMonth().ToString() + "/" + myTXTDate4.getDay().ToString());
                query3 = query3.Where(u => Convert.ToDateTime(u.taskCreationDate) >= startdate && Convert.ToDateTime(u.taskCreationDate) <= enddate);
            }
            dataGridView2.DataSource = query3.ToList();
            fcnfillrows2();

        }
        public void fcnfillrows()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }
        public void fcnfillrows2()
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = i + 1;
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
        public void fcnContract()
        {
            var qcompany = (from c in ctx.companyTask select c).ToList();
            cmbcompany2.DataSource = qcompany;
            cmbcompany2.ValueMember = "CompanyID";
            cmbcompany2.DisplayMember = "CompanyName";
        }
        public void departmantcomboContract()
        {
            var qdepartment = (from c in ctx.department
                               where
      c.companyTask.CompanyID == 1 + cmbcompany2.SelectedIndex
                               select c).ToList();
            cmbdepartment2.DataSource = qdepartment;
            cmbdepartment2.ValueMember = "DepartmentID";
            cmbdepartment2.DisplayMember = "DepartmentName";
        }
        public void fcnProduct()
        {
            var qProduct = (from c in ctx.product select c).ToList();
            cmbversion.DataSource = qProduct;
            cmbversion.ValueMember = "productID";
            cmbversion.DisplayMember = "name";
        }
        public void fcnProduct2()
        {
            var qProduct = (from c in ctx.product select c).ToList();
            cmbversion2.DataSource = qProduct;
            cmbversion2.ValueMember = "productID";
            cmbversion2.DisplayMember = "name";
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
        public void fcnphases2()
        {
            var qphase = (from c in ctx.Phase
                          where
      c.project.ProjectID == 1 + cmbproject2.SelectedIndex
                          select c).ToList();
            cmbphase2.DataSource = qphase;
            cmbphase2.ValueMember = "PhaseID";
            cmbphase2.DisplayMember = "PhaseName";
        }
        public void fcnusers()
        {
            var qusers = (from c in ctx.user select c).ToList();
            cmbusername.DataSource = qusers;
            cmbusername.ValueMember = "Userid";
            cmbusername.DisplayMember = "UserName";
        }
        public void fcnusers2()
        {
            var qusers = (from c in ctx.user select c).ToList();
            cmbusername2.DataSource = qusers;
            cmbusername2.ValueMember = "Userid";
            cmbusername2.DisplayMember = "UserName";
        }
        public void fcncontracts()
        {
            var qusers = (from c in ctx.conventionType select c).ToList();
            cmbcontract.DataSource = qusers;
            cmbcontract.ValueMember = "conventionTypeID";
            cmbcontract.DisplayMember = "name";
        }
        public void fcncontracts2()
        {
            var qusers = (from c in ctx.conventionType select c).ToList();
            cmbcontract2.DataSource = qusers;
            cmbcontract2.ValueMember = "conventionTypeID";
            cmbcontract2.DisplayMember = "name";
        }
        public void fcnProjects2()
        {
            var qcompany = (from p in ctx.project
                            join
     s in ctx.ShareProjectToDepartment on
     p.ProjectID equals s.project.ProjectID
                            join d in ctx.department on s.department.DepartmentID equals 1 + cmbdepartment2.SelectedIndex
                            select p).Distinct().ToList();
            cmbproject2.DataSource = qcompany;
            cmbproject2.ValueMember = "ProjectID";
            cmbproject2.DisplayMember = "ProjectName";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MyquerysShowData();            
            MyquerysShowData2();

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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxDate.Checked)
            {
                myTXTDate1.Enabled = true;
                myTXTDate2.Enabled = true;
                lblSince.Enabled = true;
                lbluntildate.Enabled = true;
            }
            else
            {

                myTXTDate1.Enabled = false;
                myTXTDate2.Enabled = false;
                lblSince.Enabled = false;
                lbluntildate.Enabled = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxcompany2.Checked)
            {
                fcnContract();
                cmbdepartment2.ResetText();
                cmbcompany2.Enabled = true;
                cmbusername2.ResetText();
                cmbproject2.ResetText();
            }
            else
                cmbcompany2.Enabled = false;
            cmbdepartment2.Enabled = false;
            chbxdeparment2.Checked = false;
            chbxproject2.Checked = false;
            cmbproject2.Enabled = false;
            cmbusername2.Enabled = false;
            chbxphase2.Checked = false;
            cmbphase2.ResetText();
            cmbdepartment2.ResetText();
            cmbusername2.ResetText();
            cmbproject2.ResetText();
        }
        private void cmbcompany2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcompany2.SelectedItem != null)
            {
                cmbdepartment2.ResetText();
                if (cmbdepartment2.Enabled)
                {
                    departmantcomboContract();
                        }
            }
        }
        private void chbxdeparment2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxcompany2.Checked && chbxdeparment2.Checked && cmbcompany2.Enabled)
            {
                cmbdepartment2.Enabled = true;
                departmantcomboContract();
                cmbusername2.ResetText();
                cmbproject2.ResetText();
            }
            else
            {
                cmbdepartment2.Enabled = false;
                chbxproject2.Checked = false;
                cmbproject2.Enabled = false;
                cmbusername2.Enabled = false;
                chbxphase2.Checked = false;
                cmbusername2.ResetText();
                cmbproject2.ResetText();
                cmbdepartment2.ResetText();
                cmbphase2.ResetText();
            }
        }
        private void chbxproject2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxproject2.Checked && chbxdeparment2.Checked && cmbdepartment2.Enabled)
            {
                cmbproject2.Enabled = true;
                cmbproject2.ResetText();
                fcnProjects2();
                cmbusername2.ResetText();
            }
            else
            {
                cmbproject2.Enabled = false;
                cmbusername2.Enabled = false;
                chbxphase2.Checked = false;
                cmbproject2.ResetText();
                cmbusername2.ResetText();
                cmbphase2.ResetText();
            }
        }
        private void chbxphase2_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbproject2.Enabled && chbxphase2.Checked)
            {
                cmbusername2.ResetText();
                fcnphases2();
                cmbphase2.Enabled = true;
            }
            else
                cmbphase2.Enabled = false;
            cmbusername2.ResetText();
            cmbphase2.ResetText();
        }
        private void chbxusername2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxusername2.Checked)
            {
                cmbusername2.Enabled = true;
                fcnusers2();

            }
            else
            {
                cmbusername2.Enabled = false;
            }
        }
        private void chbxVersion2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxVersion2.Checked)
            {
                cmbversion2.ResetText();
                fcnProduct2();
                cmbversion2.Enabled = true;
            }
            else
            {
                cmbversion2.Enabled = false;
                cmbversion2.ResetText();
            }
        }
        private void chbxContract2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxContract2.Checked)
            {
                cmbcontract2.ResetText();
                cmbcontract2.Enabled = true;
                fcncontracts2();
            }
            else
            {
                cmbcontract2.ResetText();
                cmbcontract2.Enabled = false;
            }
        }
        private void chboxnameCustomers2_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxnameCustomers2.Checked)
            {
                ShowCustomers shcust2 = new ShowCustomers();
                shcust2.ShowDialog();
                shMo = ShowCustomers.passdata.shMo;
                moName = ShowCustomers.passdata.moName;
                txtNameCustomers2.Text = moName;
            }
        }
        private void chbxDate2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxDate2.Checked)
            {
                myTXTDate3.Enabled = true;
                myTXTDate4.Enabled = true;
                lblSince2.Enabled = true;
                lbluntildate2.Enabled = true;
            }
            else
            {

                myTXTDate1.Enabled = false;
                myTXTDate2.Enabled = false;
                lblSince2.Enabled = false;
                lbluntildate2.Enabled = false;
            }
        }
        private void btnShowReport2_Click(object sender, EventArgs e)
        {
            MyquerysShowData2();
        }
        private void print2_Click(object sender, EventArgs e)
        {

        }
    }
}
