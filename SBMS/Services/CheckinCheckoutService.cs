using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SBMS.Services
{
    public class CheckinCheckoutService
    {

        //Get Connection from web.config file
        public bool checkoutbySlideIds(int borrower_id,List<int> id)
        {
            String list_of_ids_with_comma = "";
            id.ForEach(delegate (int d)
            {
                list_of_ids_with_comma += d.ToString() + ",";
            });

            using (SqlConnection connection = new SqlConnection(DatabaseServices.connectionString))
            {

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    string updateDonorQuery = "UPDATE slides " +
                        "SET isBorrowed=1,updated_by=@updated_by" +
                        "WHERE id IN (@ids)";
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
                        if (recordsAffected > 0)
                        {
                            return true;
                        }

                    }
                    catch (SqlException ex)
                    {
                        return false;

                    }
                }
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    string insertQUery = "INSERT current_lending " +
                        "SET borrower_id=@b_id,slide_id=@slide_id," +
                        "updated_by=@updated_by," +
                        "checked_out_date=@created_date," +
                        "due_date=@due_date,"+
                        "created_by=@created_by"+
                        "WHERE id =@id";
                    command.CommandText = insertQUery;
                    command.CommandType = CommandType.Text;

                    for (int i = 0; i < id.Count; i++) {
                        command.Parameters.AddWithValue("@slide_id", id[i]);
                        command.Parameters.AddWithValue("@b_id", borrower_id);
                        command.Parameters.AddWithValue("@created_by", "Full name=" + UserAccountServices.Full_name + "=Username=" + UserAccountServices.Username);
                        try
                        {

                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }
                            int recordsAffected = command.ExecuteNonQuery();
                            if (recordsAffected > 0)
                            {
                                return true;
                            }

                        }
                        catch (SqlException ex)
                        {
                            return false;

                        }
                    }

                    //end result of adding to chekout table

                }

                return false;
            }
        }
    }
}
