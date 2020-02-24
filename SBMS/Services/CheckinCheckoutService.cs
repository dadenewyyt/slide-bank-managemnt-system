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
        public bool checkoutbySlideIds(int borrower_id, List<int> ids, DateTime fromDate, DateTime dueDate, String reason)
        {
            string list_of_ids_with_comma = "";

            ids.ForEach(delegate (int sid)
            {
                list_of_ids_with_comma += sid + ",";
            });

           list_of_ids_with_comma = list_of_ids_with_comma.Remove(list_of_ids_with_comma.Length - 1);//reove tge kaqst ,

            using (SqlConnection connection = new SqlConnection(DatabaseServices.connectionString))
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
                        MessageBox.Show("Checkout Database Error:" + ex.Message);
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
                                MessageBox.Show("Checkout Database Error:" + ex.Message);
                            }
                        }
                    });
                    connection.Close();
                    //end result of adding to chekout table
                return true;
            }

        }
    }
}

