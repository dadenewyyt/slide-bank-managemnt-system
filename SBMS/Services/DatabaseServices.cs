using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Services
{
    class DatabaseServices
    {
        public String connectionString = ConfigurationManager.ConnectionStrings["SBMS.Properties.Settings.sbmsConnectionStringDaniel"].ConnectionString;

        //Get Connection from web.config file
        public static OdbcConnection GetConnection()
        {
            OdbcConnection con = new OdbcConnection();
            con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SBMS.Properties.Settings.sbmsConnectionStringDaniel"].ConnectionString;
            return con;
        }


    }

}
