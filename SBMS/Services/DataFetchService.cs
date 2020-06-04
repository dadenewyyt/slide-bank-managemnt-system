using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace MSBMS.Services
{
    class DataFetchService
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public DataFetchService() { DBConnectionSingltonServices.GetConnection(); }

        public DataTable FecthSlideByDonorCode(string donorCode)
        {

            DataTable slideFromDonorDataTable = new DataTable();
            if (String.IsNullOrEmpty(donorCode) == false)
            {
                string selectquery = "select * from donors where donor_code=" + donorCode.Trim();
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectquery, DBConnectionSingltonServices.con))
                {

                    try
                    {

                        adapter.Fill(slideFromDonorDataTable);
                        return slideFromDonorDataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Donor Fetch Slide Page");
                        logger.Error(ex, "DataFetchService for Donor Fetch");
                        return slideFromDonorDataTable;
                    }

                }
            }
            return slideFromDonorDataTable;
        }
        public int CheckDuplicateDonorCode(string donorCode,string contrycode)
        {

            if (String.IsNullOrEmpty(donorCode) == false)
            {
                string selectquery = "select donor_code from donors where donor_code=" + donorCode.Trim() + "and country_code="+contrycode;
                using (SqlCommand command2 = new SqlCommand(selectquery, DBConnectionSingltonServices.con))
                {

                    try
                    {
                        //con.Open();
                        SqlDataReader cr = command2.ExecuteReader();
                        while (cr.Read())
                        {
                            if (cr.HasRows == true)
                            {

                                return 1;
                            }

                        }
                        cr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        logger.Error(ex, "DataFetchService for Donor Fetch");
                        return -1;
                    }

                }
            }
            return -1;
        }

        public int CheckDuplicateDonorCodeUpdate(string donorCode, int DonorId)
        {

            if (String.IsNullOrEmpty(donorCode) == false)
            {
                string selectquery = "select donor_code from donors where donor_code=" + donorCode.Trim() + "and id=" + DonorId;
                using (SqlCommand command2 = new SqlCommand(selectquery, DBConnectionSingltonServices.con))
                {

                    try
                    {
                        //con.Open();
                        SqlDataReader cr = command2.ExecuteReader();
                        while (cr.Read())
                        {
                            if (cr.HasRows == true)
                            {

                                return -1;
                            }

                        }
                        cr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        logger.Error(ex, "DataFetchService for Donor Fetch");
                        return -1;
                    }

                }
            }
            return 1;
        }

        public DataTable FecthBorrowedSlideByBarCode(string barcode)
        {
            DataTable BorrowedSlideByBarCode = new DataTable();

            if (String.IsNullOrEmpty(barcode) == false)
            {
                string selectquery = "SELECT * , l.created_by as borrowed_by, l.created_date as b_created_date FROM dbo.current_lending as l INNER JOIN dbo.borrowers AS b ON b.id = l.borrower_id INNER JOIN dbo.slides AS s ON s.id = l.slide_id INNER JOIN dbo.donors as d on d.id = s.donor_id WHERE (s.bar_code="+barcode+")ORDER BY d.donor_code,l.due_date ASC;";
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectquery, DBConnectionSingltonServices.con))
                {

                    try
                    {

                        adapter.Fill(BorrowedSlideByBarCode);
                        return BorrowedSlideByBarCode;
                    }
                    catch (Exception ex)
                    {
                       MessageBox.Show(ex.Message, "We are unable to find a slide with the barcode:"+barcode);
                       logger.Error(ex, "DataFetchService for Donor Fetch");

                        return BorrowedSlideByBarCode;
                    }

                }
            }
            return BorrowedSlideByBarCode;
        }

        public int CheckDuplicateSlideInfo(string sequence , string barcode)
        {

             //first get the donor id for the slide /////
            if (String.IsNullOrEmpty(sequence) == false)
            {
                string selectquery = "select id from slides where bar_code= "+barcode +" and sequence=" + sequence.Trim();
                using (SqlCommand command2 = new SqlCommand(selectquery, DBConnectionSingltonServices.con))
                {

                    try
                    {
                        //con.Open();
                        SqlDataReader cr = command2.ExecuteReader();
                        while (cr.Read())
                        {
                            if (cr.HasRows == true)
                            {

                                return 1;
                            }

                        }
                        cr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        logger.Error(ex, "DataFetchService for Donor Fetch");

                        return -1;
                    }

                }
            }
            return -1;
        }


        public int CheckDuplicateLocation(int cabinet, int drawer, int box)
        {


            string selectquery = "select sequence from slides where cabinet_number =" + cabinet + " and drawer_number = " + drawer + " and box_number=" + box;
            using (SqlCommand command2 = new SqlCommand(selectquery, DBConnectionSingltonServices.con))
            {

                try
                {
                    //con.Open();
                    SqlDataReader cr = command2.ExecuteReader();
                    while (cr.Read())
                    {
                        if (cr.HasRows == true)
                        {

                            return 1;
                        }

                    }
                    cr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    logger.Error(ex, "DataFetchService for Donor Fetch");
                    return -1;
                }
            }
            return -1;
        }

        public int CheckDuplicateLocationUpdate(int cabinet, int drawer, int box, int slide_id)
        {


            string selectquery = "select id from slides where cabinet_number =" + cabinet + " and drawer_number = " + drawer + " and box_number=" + box ;
            using (SqlCommand command2 = new SqlCommand(selectquery, DBConnectionSingltonServices.con))
            {

                try
                {
                    //con.Open();
                    SqlDataReader reader = command2.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows == true)
                        {
                            if (reader.GetInt32(0)!=slide_id)
                                return 1; //slide space is occupied
                            if (reader.GetInt32(0) == slide_id)
                                return -1; //slide space is occupied
                        }
                    }
                    reader.Close();
                    return 1; // occupied
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    logger.Error(ex, "DataFetchService for Donor Location Data Exception");

                    return 1;
                }
            }
          }

        public int CheckIfLocationOccuiped(int cabinet, int drawer, int box)
        {
            string selectquery = "select id from slides where cabinet_number =" + cabinet + " and drawer_number = " + drawer + " and box_number=" + box;
            using (SqlCommand command2 = new SqlCommand(selectquery, DBConnectionSingltonServices.con))
            {

                try
                {
                    //con.Open();
                    SqlDataReader cr = command2.ExecuteReader();
                    while (cr.Read())
                    {
                        if (cr.HasRows == true)
                        {

                            return 1;
                        }

                    }
                    cr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 1;
                }
            }
            return -1;
        }
    }
}
