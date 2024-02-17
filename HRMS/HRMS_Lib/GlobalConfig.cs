using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HRMS_Lib
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection()
        {
            SqlConnector sql = new SqlConnector();
            Connection = sql;
        }

        // CnnString - Connection String
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            //return ConfigurationManager.AppSettings[name];
        }
    }
}
