using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSBMS.Services
{
    class ReplacementServices
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public ReplacementServices()
        {

        }

        public bool ReplaceSlides(int damgaged_slide_id, int reserved_slide_id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Services.DBConnectionSingltonServices.connectionString))
                {
                    SqlTransaction transaction;
                    connection.Open();
                    transaction = connection.BeginTransaction("ReplacementTransaction");

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;
                        string insertDonorQuery = "INSERT into replacements" +
                            "(damaged_slide_id,reserved_slide_id,replaced_by) " +
                             "VALUES (@damaged_slide_id,@reserved_slide_id,@replaced_by)";
                        command.CommandType = CommandType.Text;
                        command.CommandText = insertDonorQuery;
                        command.Parameters.AddWithValue("@damaged_slide_id", reserved_slide_id);
                        command.Parameters.AddWithValue("@reserved_slide_id", damgaged_slide_id);
                        command.Parameters.AddWithValue("@replaced_by", "Full name=" + UserAccountServices.Full_name + "=Username=" + UserAccountServices.Username);
                        try
                        {

                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }

                            int recordsAffected = command.ExecuteNonQuery();
                            //transaction.Commit();
                            //l//ogger.Info("Commit:Both records are written to database.");
                            //Console.WriteLine("Both records are written to database.");
                        }
                        catch (SqlException ex)
                        {
                            logger.Error(ex, "Replacment : Rollback Exception Type: {0}" + ex.GetType());
                            return false;

                        }
                    }

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;
                        string insertQUery = "Update slides SET isDamged=@isDamaged,updated_by=@updated_by,isReplace=@isReplaced WHERE id=@damaged_slide_id;";
                        command.CommandText = insertQUery;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@damaged_slide_id", Convert.ToInt32(damgaged_slide_id));
                        command.Parameters.AddWithValue("@isDamaged", 1);
                        command.Parameters.AddWithValue("@isReplaced", 1);
                        command.Parameters.AddWithValue("@updated_by", "Full name=" + UserAccountServices.Full_name + "=Username=" + UserAccountServices.Username);
                        try
                        {

                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }

                            int recordsAffected = command.ExecuteNonQuery();

                            transaction.Commit();

                            logger.Info("Commit:Both records are written to database.");

                            Console.WriteLine("Replaced records are written to database.");

                            return true;
                        }
                        catch (SqlException ex)
                        {

                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception ex2)
                            {
                                // This catch block will handle any errors that may have occurred
                                // on the server that would cause the rollback to fail, such as
                                // a closed connection.
                                logger.Error(ex, "Replacement: Rollback Exception Type: {0}" + ex2.GetType());
                                Console.WriteLine("  Message: {0}", ex2.Message);
                                return false;

                            }
                            //MessageBox.Show("Checkin Database Error Making slide as history:" + ex.Message);
                            logger.Error(ex, "Replacement: Service Replace Method Exception ");
                            return false;
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }

                }//main SQLconnection using closed     

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Replacement Service Exception");
                return false;
            }

        }

    }
}