using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AtiranUpdateFiles
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        private void frmmain_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (count < 0)
            //{
            //    timer1.Enabled = false;
            //    pictureBox1.Visible = false;
            //    frmchild f = new frmchild(); f.ShowDialog();
            //}
            //count--;
        }

        private void frmmain_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void frmmain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"FTPSetting.xml");
            string ftpServerIP = xmldoc.SelectSingleNode("setting/IPServer").InnerText;
            string ftpUserID = xmldoc.SelectSingleNode("setting/FTPUserName").InnerText;
            string ftpPassword = xmldoc.SelectSingleNode("setting/FTPPassword").InnerText;
            string ServerPath = xmldoc.SelectSingleNode("setting/ServerPath").InnerText;
            string ftpuri = @"ftp://" + ftpServerIP + ServerPath;
            string localpath = xmldoc.SelectSingleNode("setting/LocalPath").InnerText;//D:\sac#2\atiran2\Release
            FTP_Functions f = new FTP_Functions();
            f.testcompare(ftpServerIP, ftpUserID, ftpPassword, ftpuri, localpath);
            int size = 0;
            switch (f.codeMsg)
            {
               
                case 1:
                    FTP_Functions.returnMSG = "آتيران شما آپديت مي باشد";
                    Thread.Sleep(1000);
                    Application.Exit();
                    break;
                case 2:
                    messagebox m = new messagebox();
                    m.gettext("آيا با بروز رساني موافق هستيد؟", "تاييد", "انصراف", 2);

                    //m.gettext("آيا مي خواهيد آتيران شما آپديت شود ؟", "تاييد", "انصراف",2);
                    m.ShowDialog();
                    if (Mainmessagebox.Valueint == 1)
                    {
                        if (Directory.Exists(@localpath))
                        {
                            DateTime d = DateTime.Now;
                            PersianCalendar pc = new PersianCalendar();
                            string str = pc.GetYear(d).ToString() + pc.GetMonth(d) + pc.GetDayOfMonth(d) + pc.GetHour(d)+ pc.GetMinute(d)+ pc.GetSecond(d);
                            Directory.Move(@localpath, @localpath + str);
                            Directory.CreateDirectory(@localpath);
                           
                                FTP_Functions.returnMSG = "شروع عمليات آپديت";
                                f.KillProgramAT();
                                f.sizePath(ftpuri, localpath);
                                size = FTP_Functions.sizeAllfile;
                                frmchild c = new frmchild();
                                c.ShowDialog();
                            messagebox m1 = new messagebox();
                            m1.gettext("برنامه آتيران با موفقيت آپديت شد", "تاييد", "انصراف", 1);
                            m1.ShowDialog();
                            Application.Exit();
                            break;
                            
                        }
                        else
                        {
                            Directory.CreateDirectory(localpath);
                            FTP_Functions.returnMSG = "شروع عمليات آپديت";
                            f.KillProgramAT();
                            f.sizePath(ftpuri, localpath);
                            size = FTP_Functions.sizeAllfile;
                            frmchild c = new frmchild();
                            c.ShowDialog();
                            messagebox m1 = new messagebox();
                            m1.gettext("برنامه آتيران با موفقيت آپديت شد", "تاييد", "انصراف", 1);
                            m1.ShowDialog();
                            Application.Exit();
                            break;
                        }
                       
                    }
                    else
                    {
                        Application.Exit();
                    }
                    break;
                case 3:
                    FTP_Functions.returnMSG = "فايل سرور يا كلاينت موجود نمي باشد";
                    Thread.Sleep(1000);
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblStatus.Visible = true;
            lblStatus.Text = FTP_Functions.returnMSG;

        }
    }
}
