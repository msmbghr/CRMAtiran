using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace AtiranUpdateFiles
{
    class FTP_Functions
    {
        static public string filetstserver;
        public string filetstClient;
        static string ftpServerIP;
        static string ftpUserID;
        static string ftpPassword;
        static string ftpuri;
        public int codeMsg;
        static public string returnMSG = "در حال متصل شدن به سرور";
        static public int sizefile;
        static public int sizeAllfile;
        static public string pathdown;
        static string ftplocalpath;
        static string pathCI;
        public int testcompare(string serverIP, string UserID, string Password, string uri, string localpath)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"FTPSetting.xml");
            pathCI = xmldoc.SelectSingleNode("setting/pathCICode").InnerText;
            bool filexistS = File.Exists(@pathCI);
            if (filexistS)
            {
                StreamReader sr1 = new StreamReader(@pathCI);
                filetstClient = sr1.ReadToEnd();
                sr1.Close();
                filetstserver = stringFTP(uri, UserID, Password);
                if (filetstserver == filetstClient)
                {
                    codeMsg = 1;//آتيران شما آپديت مي باشد
                }
                else
                {
                    //StreamWriter sw = new StreamWriter(@pathCI);
                    //sw.Write(filetstserver);
                    //sw.Close();

                    ftpServerIP = serverIP; ftpUserID = UserID; ftpPassword = Password; ftpuri = uri; ftplocalpath = localpath;
                   // sizePath(ftpuri, ftplocalpath);

                    codeMsg = 2;//آتيران شما آپديت نشده است
                }
            }
            else
            {
                codeMsg = 3;//فايل تست سرور يا كلاينت موجود نمي باشد
            }
            return codeMsg;
        }
        public bool updatetxtserver() {
            try
            {
                StreamWriter sw = new StreamWriter(@pathCI);
                sw.Write(filetstserver);
                sw.Close();
                return true;
            }
            catch
            {
                return false;
            }
           
        }
        public void sizePath(string uri, string localPath)
        {
            FtpWebRequest listRequest = (FtpWebRequest)WebRequest.Create(uri);
            listRequest.UsePassive = true;
            listRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            listRequest.Credentials = new NetworkCredential(ftpUserID, ftpPassword); ;
            List<string> lines = new List<string>();
            using (FtpWebResponse listResponse = (FtpWebResponse)listRequest.GetResponse())
            using (Stream listStream = listResponse.GetResponseStream())
            using (StreamReader listReader = new StreamReader(listStream))
            {
                while (!listReader.EndOfStream)
                {
                    lines.Add(listReader.ReadLine());
                }
            }
            foreach (string line in lines)
            {
                string[] segments = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                string name = segments[3].Trim();
                string permissions = segments[2];
                int lngh = segments.Length;
                string localFilePath = Path.Combine(ftplocalpath, name);
                string fileUrl = uri + name;
                if (permissions == "<DIR>")
                {
                    for (int i = 4; i < lngh; i++)
                    {
                        localFilePath += " " + segments[i];
                        fileUrl += " " + segments[i];
                    }
                    sizePath(fileUrl + "/", localFilePath);
                }
                else
                {
                    for (int i = 4; i < lngh; i++)
                    {
                        localFilePath += " " + segments[i];
                        fileUrl += " " + segments[i];
                    }
                    sizeAllfile += (Convert.ToInt32(segments[2]) / 1048576);
                }
            }
            //Thread.Sleep(500);
        }

        public string stringFTP(string ftpuri, string ftpUserID, string ftpPassword)
        {
            try
            {
                WebClient request = new WebClient();
                request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);             
                Stream str = request.OpenRead(ftpuri + "code.txt");
                StreamReader st = new StreamReader(str);
                string getDataCodeServer = st.ReadToEnd();
                returnMSG = "در حال دريافت اطلاعات از سرور";
                Thread.Sleep(500);
                return getDataCodeServer;
            }
            catch (Exception ex)
            {

                messagebox m1 = new messagebox();
                m1.gettext("سيستم شما به سرور متصل نيست", "تاييد", "انصراف", 1);
                m1.ShowDialog(); Application.Exit();
                
            }
            return "";
                
        }

        public void KillProgramAT()
        {
            try
            {
                Process[] GetPArry = Process.GetProcesses();
                foreach (Process testProcess in GetPArry)
                {
                    string ProcessName = testProcess.ProcessName;

                    ProcessName = ProcessName.ToLower();
                    if (ProcessName.CompareTo("atiran") == 0)
                    {
                        returnMSG = "در حال بستن آتيرانهاي باز شده";
                        testProcess.Kill();
                        Thread.Sleep(1000);
                    }
                }
            }
            catch (Exception) { }
        }


        public void UpdateProgram() { copy_ftp(ftpuri,ftplocalpath); }
        public void copy_ftp(string uri, string localPath)
        {
            FtpWebRequest listRequest = (FtpWebRequest)WebRequest.Create(uri);
            listRequest.UsePassive = true;
            returnMSG = " در حال آپديت شدن نرم افزار آتيران";
            listRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            listRequest.Credentials = new NetworkCredential(ftpUserID, ftpPassword); ;
            List<string> lines = new List<string>();
            using (FtpWebResponse listResponse = (FtpWebResponse)listRequest.GetResponse())
            using (Stream listStream = listResponse.GetResponseStream())
            using (StreamReader listReader = new StreamReader(listStream))
            {
                while (!listReader.EndOfStream)
                {
                    lines.Add(listReader.ReadLine());
                }
            }
            foreach (string line in lines)
            {
                string[] segments = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                string name = segments[3].Trim();
                string permissions = segments[2];
                int lngh = segments.Length;
                string localFilePath = Path.Combine(localPath, name);
                string fileUrl = uri + name;
                if (permissions == "<DIR>")
                {
                    for (int i = 4; i < lngh; i++)
                    {
                        localFilePath += " " + segments[i];
                        fileUrl += " " + segments[i];
                    }
                    Directory.CreateDirectory(localFilePath);
                    copy_ftp(fileUrl + "/", localFilePath);
                }
                else
                {
                    for (int i = 4; i < lngh; i++)
                    {
                        localFilePath += " " + segments[i];
                        fileUrl += " " + segments[i];
                    }
                    WebClient request = new WebClient();
                    request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                    request.DownloadFile(fileUrl, localFilePath);
                    pathdown = fileUrl;
                    sizefile += (Convert.ToInt32(segments[2]) / 1048576);
                }
            }
            //StreamWriter sw = new StreamWriter(@pathCI);
            //sw.Write(filetstserver);
            //sw.Close();
        }

    }

}
