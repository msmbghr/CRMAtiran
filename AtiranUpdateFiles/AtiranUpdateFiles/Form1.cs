using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AtiranUpdateFiles
{
    public partial class frmchild : Form
    {
        public frmchild()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //loadingCircle1.Active = true;
            lblStatus.Text = " در حال متصل شدن به سرور";
            lblStatus.Visible = true;
            timerDot.Enabled = true;
            backdownload.RunWorkerAsync();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
           
        }

        private void backdownload_DoWork(object sender, DoWorkEventArgs e)
        {
           
            FTP_Functions ftp = new FTP_Functions();
            ftp.UpdateProgram();
        }

        private void timerDot_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = FTP_Functions.returnMSG;
            if (FTP_Functions.sizefile > 0)
            {
                progressBar1.Value = (FTP_Functions.sizefile * 100 / FTP_Functions.sizeAllfile);
                lblSize.Text = "MB " + (FTP_Functions.sizefile).ToString() + " حجم دانلود شده";
               // lblSize.Visible = true;
                label1.Text = progressBar1.Value.ToString();
                label1.Text += "%";
            }
            lblPathdown.Text = FTP_Functions.pathdown;

        }

        private void backdownload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //loadingCircle1.Active = false;
            timerDot.Enabled = false;
            FTP_Functions f = new FTP_Functions();
            if (f.updatetxtserver())
            {
                progressBar1.Value = 100;
                this.Close();
                //Application.Exit();
            }
            else
            {
                messagebox m = new messagebox();
                m.gettext("آپديت آتيران با خطا متوقف شده است", "تاييد", "انصراف", 1);
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backdownload_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }
    }
}
