using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Shell32;

namespace AtiranUpdateFiles
{
    public partial class Mainmessagebox : Form
    {
        public Mainmessagebox()
        {
            InitializeComponent();
            ConfigureXML();
        }
        public static int Valueint;

        string programName;
        string programNameOnDesktop;
        string localpath;
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Valueint = 1;
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Valueint = 2;
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mainmessagebox_Load(object sender, EventArgs e)
        {
            label2.Text = messagebox.str;
            btnOk.Text = messagebox.btnok;
            btncancel.Text = messagebox.btncancel;
            if (messagebox.sh==1)
            {
                btncancel.Visible = false;
                btnOk.Visible = false;
                button1.Visible = true;
            }
            if (messagebox.sh==2)
            {
                btnOk.Visible = true;
                btncancel.Visible = true;
                button1.Visible = false;
            }
        }
        FTP_Functions f = new FTP_Functions();
        public void ConfigureXML()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"FTPSetting.xml");
            localpath = xmldoc.SelectSingleNode("setting/LocalPath").InnerText;//D:\sac#2\atiran2\Release
            programName = xmldoc.SelectSingleNode("setting/programName").InnerText;
            programNameOnDesktop = xmldoc.SelectSingleNode("setting/programNameOnDesktop").InnerText;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = localpath + "\\" + programName;
            f.CreateShortcutAtiran(programName, localpath, programNameOnDesktop);////درست كردن ميانبر
            //f.DeleteStartupFolderShortcuts(str1);
            //f.CreateShortcutAtiran(programName, localpath, programNameOnDesktop);////درست كردن ميانبر
            this.Close();

        }
    }
}
