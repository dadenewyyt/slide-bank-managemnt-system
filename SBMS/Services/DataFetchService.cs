using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace SBMS.Services
{
    class DataFetchService
    {

        public DataFetchService() { DatabaseServices.GetConnection(); }

        public DataTable FecthSlideByDonorCode(string donorCode)
        {

            DataTable slideFromDonorDataTable = new DataTable();
            if (String.IsNullOrEmpty(donorCode) == false)
            {
                string selectquery = "select * from donors where donor_code=" + donorCode.Trim();
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectquery, DatabaseServices.con))
                {

                    try
                    {

                        adapter.Fill(slideFromDonorDataTable);
                        return slideFromDonorDataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Donor Fetch Slide Page");
                        return slideFromDonorDataTable;
                    }

                }
            }
            return slideFromDonorDataTable;
        }
        public int CheckDuplicateDonorCode(string donorCode)
        {

            if (String.IsNullOrEmpty(donorCode) == false)
            {
                string selectquery = "select donor_code from donors where donor_code=" + donorCode.Trim();
                using (SqlCommand command2 = new SqlCommand(selectquery, DatabaseServices.con))
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
                using (SqlCommand command2 = new SqlCommand(selectquery, DatabaseServices.con))
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
                        return -1;
                    }

                }
            }
            return 1;
        }


        public int CheckDuplicateSlideInfo(string sequence)
        {

            if (String.IsNullOrEmpty(sequence) == false)
            {
                string selectquery = "select sequence from slides where sequence=" + sequence.Trim();
                using (SqlCommand command2 = new SqlCommand(selectquery, DatabaseServices.con))
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
                        return -1;
                    }

                }
            }
            return -1;
        }


        public int CheckDuplicateLocation(int cabinet, int drawer, int box)
        {


            string selectquery = "select sequence from slides where cabinet_number =" + cabinet + " and drawer_number = " + drawer + " and box_number=" + box;
            using (SqlCommand command2 = new SqlCommand(selectquery, DatabaseServices.con))
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
                    return -1;
                }
            }
            return -1;
        }

        public int CheckDuplicateLocationUpdate(int cabinet, int drawer, int box, int slide_id)
        {


            string selectquery = "select sequence from slides where cabinet_number =" + cabinet + " and drawer_number = " + drawer + " and box_number=" + box +
                " and id =" + slide_id; ;
            using (SqlCommand command2 = new SqlCommand(selectquery, DatabaseServices.con))
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
                    return -1;
                }
            }
            return 1;
        }
    }
}
