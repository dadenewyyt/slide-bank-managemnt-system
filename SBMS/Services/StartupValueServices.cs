using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace MSBMS.Services
{
    static class StartupValueServices
    {

     
        static int exchange_id_default;


        public static int Exchange_id_default { get => exchange_id_default; set => exchange_id_default = value; }

    }
}
