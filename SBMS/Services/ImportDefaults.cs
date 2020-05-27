using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MSBMS.Services
{
    public class ImportDefaultsService
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();


        public bool addDefaultCountryOfOrigin()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Services.DBConnectionSingltonServices.connectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        string insertDonorQuery = "INSERT into borrowers" +
                            "(fname,lname,job_title,organisation,offical_email,personal_email,mobile_phone,office_phone," +
                             "fax_number,country,city,hno,postcode,note,created_by,isDefault) " +
                             "VALUES (@fname,@lname,@job_title,@organisation,@offical_email,@personal_email,@mobile_phone,@office_phone," +
                             "@fax_number,@country,@city,@hno,@postcode,@note,@created_by,@isDefault)";
                        command.CommandType = CommandType.Text;
                        command.CommandText = insertDonorQuery;
                        command.Parameters.AddWithValue("@fname", "EPHI");
                        command.Parameters.AddWithValue("@lname", "EPHI");
                        command.Parameters.AddWithValue("@job_title", "EPHI");
                        command.Parameters.AddWithValue("@organisation", "EPHI");
                        command.Parameters.AddWithValue("@offical_email", "EPHI");
                        command.Parameters.AddWithValue("@personal_email", "EPHI");
                        command.Parameters.AddWithValue("@mobile_phone", "EPHI");
                        command.Parameters.AddWithValue("@office_phone", "EPHI");
                        command.Parameters.AddWithValue("@fax_number", "EPHI");
                        command.Parameters.AddWithValue("@country", "Ethiopia");
                        command.Parameters.AddWithValue("@hno", "EPHI");
                        command.Parameters.AddWithValue("@note", "EPHI");
                        command.Parameters.AddWithValue("@city", "EPHI");
                        command.Parameters.AddWithValue("@postcode", "EPHI");
                        command.Parameters.AddWithValue("@isDefault", 1);
                        command.Parameters.AddWithValue("@created_by", "System-Dont Delete");


                        try
                        {

                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }
                            int recordsAffected = command.ExecuteNonQuery();

                            if (recordsAffected > 0)
                            {
                                MessageBox.Show("System imported Country of Origin Information as EPHI/ETHIOPIA  !", "Success");
                                logger.Info("Default Country of Origin Data is Added");
                            }
                            return true;

                        }
                        catch (SqlException ex)
                        {
                            logger.Error(ex, "Default Country Exception Adding");
                            return false;
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Default Country Exception Adding");
                return false;
            }
        }


        public int CheckIfDefaultExisits()
        {

            DataTable searchResults = new DataTable();
            using (var con = new SqlConnection(DBConnectionSingltonServices.connectionString))
            using (var cmd = new SqlCommand("SELECT id FROM borrowers where isDefault=@isDefault", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@isDefault", 1);
                da.Fill(searchResults);
            }

            if (searchResults.Rows.Count > 0) {
                DataRow row = searchResults.Rows[0];
                return Convert.ToInt32(row["id"]);
            }
            return -1;
        }
    }
}
