using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyTaskSystem
{
    public static class connections 
    {
        public static readonly string _connectionString;

        public static  void Myconnections()
        {
            //XmlDocument xmldoc = new XmlDocument();
            //xmldoc.Load(@"GetInfo.xml");
            //string Server = xmldoc.SelectSingleNode("sal/Server").InnerText;
            //string dbName = xmldoc.SelectSingleNode("sal/DatabaseName").InnerText;
            //_connectionString = "Data Source="+Server+";Initial Catalog="+dbName+";User ID=sa;Password=sac-100";
        }
    }
}
