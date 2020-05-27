using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MSBMS.Services
{
    class LookUpServices
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public LookUpServices() { DBConnectionSingltonServices.GetConnection(); }


        public Dictionary<int, string> fetchLookupTables(String lookUptype)
        {

            DataTable dataTable = new DataTable();

              switch (lookUptype)
                {

                    case "species_specifics":


                        try
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM species_specifics ", DBConnectionSingltonServices.con);
                            adapter.Fill(dataTable);


                        }
                        catch (Exception ex)
                        {
                            // Handle the error
                            logger.Error(ex, "fetcing specifics");
                        }


                        break;
                    case "species_category":


                        try
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM species_category", DBConnectionSingltonServices.con);
                            adapter.Fill(dataTable);


                        }
                        catch (Exception ex)
                        {
                            // Handle the error
                            logger.Error(ex, "fetching category");
                        }


                        break;

                    case "species_stages":


                        try
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM species_stages", DBConnectionSingltonServices.con);
                            adapter.Fill(dataTable);


                        }
                        catch (Exception ex)
                        {
                            // Handle the error
                            logger.Error(ex, "fetching stage");

                        }


                        break;
                    case "density_category":


                        try
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM density_category", DBConnectionSingltonServices.con);
                            adapter.Fill(dataTable);


                        }
                        catch (Exception ex)
                        {
                            // Handle the error
                            logger.Error(ex, "fetching density");

                        }


                        break;

                    case "owners":


                        try
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM owners", DBConnectionSingltonServices.con);
                            adapter.Fill(dataTable);


                        }
                        catch (Exception ex)
                        {
                            // Handle the error
                            logger.Error(ex, "fetching owners");

                        }


                        break;
                    case "validations":


                        try
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM validations", DBConnectionSingltonServices.con);
                            adapter.Fill(dataTable);



                        }
                        catch (Exception ex)
                        {
                            // Handle the error
                            logger.Error(ex, "fetching validations");

                        }


                        break;

                }

                try
                {

                    var dict = new Dictionary<int, string>();

                    if (0 < dataTable.Rows.Count)
                    {

                        dict.Add(0, "--Select--");

                        foreach (DataRow dr in dataTable.Rows)
                        {
                            dict.Add(Int32.Parse(dr[0].ToString()), dr[1].ToString());

                        }
                    }

                    return dict;
                }
                catch (Exception ex)
                {

                    logger.Error(ex, "LookupService Exception");
                }

            return null;
        }
    }
}
    
    



