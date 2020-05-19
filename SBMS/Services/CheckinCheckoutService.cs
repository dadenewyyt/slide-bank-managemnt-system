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

        private SearchAndFilterService searchAndFilterService;
        public CheckinCheckoutService() {
            searchAndFilterService = new SearchAndFilterService();
        }

        int drawer = 0;
        int box = 0;
        int cabinet = 0;

        public bool checkoutbySlideNoneExchange(int borrower_id, List<int> ids, DateTime fromDate, DateTime dueDate, String reason)
        {

            string list_of_ids_with_comma = "";
            bool errorfound = false;


            ids.ForEach(delegate (int sid)
            {
                list_of_ids_with_comma += sid + ",";
            });

            list_of_ids_with_comma = list_of_ids_with_comma.Remove(list_of_ids_with_comma.Length - 1);//reove tge kaqst ,

            using (SqlConnection connection = new SqlConnection(DBConnectionSingltonServices.connectionString))
            {
                SqlTransaction transaction;
                connection.Open();
                transaction = connection.BeginTransaction("CheckoutSlidesTransaction");

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Transaction = transaction;
                    
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
                        errorfound = true;
                        return false;
                    }
                }

                for (var i = 0; i < ids.Count; i++)
                {
                  
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;

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
                        command.Parameters.AddWithValue("@slide_id", Convert.ToInt32(ids[i]));
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
                            errorfound = true;
                            return false;
                        }
                    }
                }
                
                //now commit Transaction and catch error
                try
                {
                    if (errorfound == false)
                    {

                        transaction.Commit();
                        logger.Info("Commit:Both records are written to database.");
                        connection.Close();
                        return true;
                    }
                }
                catch (Exception ex)
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
                        logger.Error(ex, "Rollback Exception Type: {0}" + ex2.GetType());
                        errorfound = true;
                        return false;
                    }
                }

                //end result of adding to chekout table
                return true;
            }

        }

    public bool checkoutbySlideOutForExchange(int exchanged_contact_id, List<int> ids, String reason)
    {

        string list_of_ids_with_comma = "";
        bool errorfound = false;
        DataTable formerSlidesData = new DataTable();

       ids.ForEach(delegate (int sid)
        {
            list_of_ids_with_comma += sid + ",";
        });

        list_of_ids_with_comma = list_of_ids_with_comma.Remove(list_of_ids_with_comma.Length - 1);//reove tge kaqst ,

        using (SqlConnection connection = new SqlConnection(DBConnectionSingltonServices.connectionString))
        {
            SqlTransaction transaction;
            connection.Open();
            transaction = connection.BeginTransaction("Checkout Slides Transaction");

                for (var i = 0; i < ids.Count; i++)
                {
                    formerSlidesData = searchAndFilterService.SearchSlideById(ids[i]);

                    if (formerSlidesData.Rows.Count > 0)
                    {
                        DataRow rowa = formerSlidesData.Rows[0];
                        cabinet = Convert.ToInt32(rowa["cabinet_number"]);
                        box = Convert.ToInt32(rowa["box_number"]);
                        drawer = Convert.ToInt32(rowa["drawer_number"]);
                    }
                    else 
                    {
                        return false;
                    }
                   

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;
                        string insertQUery = "INSERT into slide_history (" +
                           "slide_id," +
                           "drawer," +
                           "cabinet," +
                           "box," +
                           "created_by," +
                           "historytype," +
                           "isreverted," +
                           "created_date)" +
                           "Values(" +
                           "@slide_id," +
                           "@drawer," +
                           "@box," +
                           "@cabinet," +
                           "@created_by," +
                           "@historytype," +
                           "@created_date)";
                        command.CommandText = insertQUery;

                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@slide_id", ids[i]);
                        command.Parameters.AddWithValue("@cabinet", cabinet);
                        command.Parameters.AddWithValue("@box", box);
                        command.Parameters.AddWithValue("@drawer", drawer);
                        command.Parameters.AddWithValue("@created", drawer);
                        command.Parameters.AddWithValue("@drawer", drawer);
                        command.Parameters.AddWithValue("@historytype", reason);
                        command.Parameters.AddWithValue("@created_date", DateTime.Now.ToString());
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
                            //MessageBox.Show("Checkout Database Error:" + ex.Message);
                            logger.Error(ex, "Checkout Exception Upating slides table");
                            errorfound = true;
                            return errorfound;

                        }
                    }
                } // insert tinto slide exhanges hitory

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.Transaction = transaction;  
                string updateDonorQuery = "UPDATE slides " +
                            "SET isBorrowed=1,isActive=0,isOutExchanged=1,updated_by=@updated_by,cabinet_number=0,drawer_number=0,box_number=0 WHERE id IN (SELECT value FROM STRING_SPLIT(@ids,','))";
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
                    logger.Error(ex, "Checkout Exception Upating slides table");
                    errorfound = true;
                    return errorfound;

                }
            }

            for (var i = 0; i < ids.Count; i++)
            {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;

                        string insertQUery = "INSERT into exchanges (" +
                            "slide_id," +
                            "exchange_contact_id," +
                            "exchange_date," +
                            "exchanged_by," +
                            "note)" +
                            "Values(" +
                            "@slide_id," +
                            "@exchange_contact_id," +
                            "@exchange_date," +
                            "@exchanged_by," +
                            "@cabinet," +
                            "@box," +
                            "@drawer," +
                            "@note)";

                        command.CommandText = insertQUery;
                        command.CommandType = CommandType.Text;

                        Console.WriteLine(ids[i]);
                        Console.WriteLine(Convert.ToInt32(ids[i]));

                        command.Parameters.AddWithValue("@slide_id", Convert.ToInt32(ids[i]));
                        command.Parameters.AddWithValue("@exchange_contact_id", exchanged_contact_id);
                        command.Parameters.AddWithValue("@exchange_date", DBNull.Value);
                        //command.Parameters.AddWithValue("@due_date", dueDate);
                        command.Parameters.AddWithValue("@note", reason);
                        command.Parameters.AddWithValue("@exchanged_by", "Full name=" + UserAccountServices.Full_name + "=Username=" + UserAccountServices.Username);
                       
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
                            logger.Error(ex, "Exception at Checkin/Checkout Services");
                            MessageBox.Show("Ex" + ex.StackTrace);
                            errorfound = true;
                            return false;
                        }
                    }
                }

                //now commit Transaction and catch error
                try
                {
                    if (errorfound == false)
                    {

                        transaction.Commit();
                        logger.Info("Commit:Both records are written to database.");
                        connection.Close();
                        return true;
                    }
                }
                catch (Exception ex) {
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
                        errorfound = true;
                        return false;
                    }
                }
                         
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
