using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

namespace SBMS.Services
{
    public class CheckinCheckoutService
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public bool checkoutbySlideIds(int borrower_id, List<int> ids, DateTime fromDate, DateTime dueDate, String reason)
        {

            string list_of_ids_with_comma = "";

            ids.ForEach(delegate (int sid)
            {
                list_of_ids_with_comma += sid + ",";
            });

            list_of_ids_with_comma = list_of_ids_with_comma.Remove(list_of_ids_with_comma.Length - 1);//reove tge kaqst ,

            using (SqlConnection connection = new SqlConnection(DBConnectionSingltonServices.connectionString))
            {

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    string updateDonorQuery = "UPDATE slides " +
                        "SET isBorrowed=1,updated_by=@updated_by WHERE id IN (SELECT value FROM STRING_SPLIT(@ids,','))";
                    command.CommandText = updateDonorQuery;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ids", list_of_ids_with_comma);
                    command.Parameters.AddWithValue("@updated_by", "Full name=" + UserAccountServices.Full_name + "=Username=" + UserAccountServices.Username);
                    try
                    {

                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        int recordsAffected = command.ExecuteNonQuery();


                    }
                    catch (SqlException ex)
                    {
                        //MessageBox.Show("Checkout Database Error:" + ex.Message);
                        logger.Error(ex, "Checkin Database Error");
                        return false;
                    }
                }

                ids.ForEach(delegate (int sid)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        string insertQUery = "INSERT into current_lending " +
                            "(borrower_id," +
                            "slide_id," +
                            "checked_out_date," +
                            "due_date," +
                            "reason," +
                            "created_by)" +
                            "Values(" +
                            "@b_id," +
                            "@slide_id," +
                            "@checked_out_date," +
                            "@due_date," +
                            "@reason," +
                            "@created_by)";
                        command.CommandText = insertQUery;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@b_id", borrower_id);
                        command.Parameters.AddWithValue("@slide_id", sid);
                        command.Parameters.AddWithValue("@checked_out_date", fromDate);
                        command.Parameters.AddWithValue("@due_date", dueDate);
                        command.Parameters.AddWithValue("@reason", reason);
                        command.Parameters.AddWithValue("@created_by", "Full name=" + UserAccountServices.Full_name + "=Username=" + UserAccountServices.Username);
                        try
                        {

                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }

                            int recordsAffected = command.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            logger.Error(ex, "Exception at CheckinCheckoutServices");
                        }
                    }
                });
                connection.Close();
                //end result of adding to chekout table
                return true;
            }

        }

        public bool CheckinSlideIsOkay(string status, int slide_id, int current_lending_id)
        {

            //first update the slide using slide id to be isBorrowed = 0 than isBorrowed=1
            using (SqlConnection connection = new SqlConnection(DBConnectionSingltonServices.connectionString))
            {
                SqlTransaction transaction;
                connection.Open();
                transaction = connection.BeginTransaction("CheckinSlidesTransaction");

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Transaction = transaction;
                    string updateCheckinQuery = "UPDATE slides " +
                        "SET isBorrowed=0,updated_by=@updated_by WHERE id=@slide_id;";
                    command.CommandText = updateCheckinQuery;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@slide_id", slide_id);
                    command.Parameters.AddWithValue("@updated_by", "Full name=" + UserAccountServices.Full_name + "=Username=" + UserAccountServices.Username);
                    try
                    {

                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        int recordsAffected = command.ExecuteNonQuery();


                    }
                    catch (SqlException ex)
                    {
                        logger.Error(ex, "Exception at CheckinCheckoutServices");
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            // This catch block will handle any errors that may have occurred
                            // on the server that would cause the rollback to fail, such as
                            // a closed connection.
                            logger.Error(ex,"Rollback Exception Type: {0}"+ ex2.GetType());
                            
                        }
                        return false;
                    }
                }

                //then make current lending slide as hisotry 

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Transaction = transaction;
                    string insertQUery = "Update current_lending SET isHistory=1,updated_by=@updated_by,checkinstatus=@status WHERE id=@current_lending_id;";
                    command.CommandText = insertQUery;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@current_lending_id", current_lending_id);
                    command.Parameters.AddWithValue("@slide_id", slide_id);
                    command.Parameters.AddWithValue("@status", status);
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
                        Console.WriteLine("Both records are written to database."); 
                    }
                    catch (SqlException ex)
                    {
                        //MessageBox.Show("Checkin Database Error Making slide as history:" + ex.Message);
                        logger.Error(ex, "Checkin Database Error Making slide as history");
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            // This catch block will handle any errors that may have occurred
                            // on the server that would cause the rollback to fail, such as
                            // a closed connection.
                            logger.Error(ex, "Rollback Exception Type: {0}" + ex2.GetType());
                            Console.WriteLine("  Message: {0}", ex2.Message);
                        }
                        return false;
                    }
                }
                connection.Close();
                //end result of adding to chekout table
                return true;
            }
        }
       

        public bool CheckinSlidesDamaged(string status, int slide_id, int current_lending_id)
        {

            //first update the slide using slide id to be isBorrowed = 0 than isBorrowed=1
            using (SqlConnection connection = new SqlConnection(DBConnectionSingltonServices.connectionString))
            {

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    string updateCheckinQuery = "UPDATE slides " +
                        "SET isBorrowed=0,isDamaged=1,updated_by=@updated_by WHERE id=@slide_id";
                    command.CommandText = updateCheckinQuery;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@slide_id", slide_id);
                    command.Parameters.AddWithValue("@updated_by", "Full name=" + UserAccountServices.Full_name + "=Username=" + UserAccountServices.Username);
                    try
                    {

                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        int recordsAffected = command.ExecuteNonQuery();


                    }
                    catch (SqlException ex)
                    {
                        //MessageBox.Show("Checkin Database Error updating borrowed status:" + ex.Message);
                        logger.Error(ex, "Checkin Database Error updating borrowed status");
                        return false;
                    }
                }

                //then make current lending slide as hisotry and report reason condition

                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        string insertQUery = "Update current_lending SET checkinStatus=@checkinStatus,isHistory=1,updated_by=@updated_by WHERE id=@current_lending_id ";
                        command.CommandText = insertQUery;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@current_lending_id", current_lending_id);
                        command.Parameters.AddWithValue("@checkinStatus", status);
                        command.Parameters.AddWithValue("@slide_id", slide_id);
                        command.Parameters.AddWithValue("@updated_by", "Full name=" + UserAccountServices.Full_name + "=Username=" + UserAccountServices.Username);
                        try
                        {

                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }

                            int recordsAffected = command.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            //MessageBox.Show("Checkin Database Error Making slide as history:" + ex.Message);
                            logger.Error(ex, "Checkin Database Error updating borrowed status");
                            return false;
                        }
                    }
                    connection.Close();
                    //end result of adding to chekout table
                    return true;
                }
            }
        }
    }
}
