using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SBMS.Services
{
    public static class DBConnectionSingltonServices
    {
        public static String connectionString = ConfigurationManager.ConnectionStrings["SBMS.Properties.Settings.sbmsConnectionStringDaniel"].ConnectionString;

        //try singlton here
        public static SqlConnection con = null;

        //Get Connection from web.config file
        public static SqlConnection GetConnection()
        {
            if (con == null)
            {

                con = new SqlConnection(connectionString);
                con.Open();
                return con;
            }
            else
            {
                return con;
            }
        }

    }
}

