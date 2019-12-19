using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SBMS.Services
{
    public static class DatabaseServices
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

