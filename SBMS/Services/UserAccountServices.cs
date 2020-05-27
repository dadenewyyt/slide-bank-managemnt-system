using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace MSBMS.Services
{
    static class UserAccountServices
    {

        static bool isLoggedIn = false;
        static string full_name;
        static string username;
        static string exchange_id_default;


        public static string Exchange_id_default { get => exchange_id_default; set => exchange_id_default = value; }

        public static string Full_name { get => full_name; set => full_name = value; }
        public static bool IsLoggedIn { get => isLoggedIn; set => isLoggedIn = value; }
        public static string Username { get => username; set => username = value; }

        public static bool login(string uname, string password)
        {

            using (SqlConnection connection = new SqlConnection(DBConnectionSingltonServices.connectionString))
            {

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    string checkQueryLogin = "select full_name from users where username=@username and password=@password";
                    command.CommandType = CommandType.Text;
                    command.CommandText = checkQueryLogin;

                    command.Parameters.AddWithValue("@username", uname);
                    command.Parameters.AddWithValue("@password", password);
                    try
                    {

                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        var fullname = command.ExecuteScalar();
                        if (fullname == null)
                            return false;
                        if (String.IsNullOrEmpty(fullname.ToString()) == false)
                        {
                            IsLoggedIn = true;
                            Username = uname;
                            Full_name = fullname.ToString();

                            return true;
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "ERROR Login Failed");
                    }
                    finally
                    {
                        connection.Close();
                    }

                }

            }

            IsLoggedIn = false;
            Username = null;
            Full_name = null;
            return false;
        }


    }
}
