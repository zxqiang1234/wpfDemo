using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Apptest1
{
    class SqlHelp
    {
        public static string GetConnectionStringsConfig(string connectionName)
 {
     string connectionString = ConfigurationManager.AppSettings["DownloadPath"]; ;
            return connectionString;
 }
}

}
