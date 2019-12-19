using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Services
{
    class LookUpServices
    {

        public LookUpServices() { DatabaseServices.GetConnection(); }
     

        public Dictionary<int, string> fetchLookupTables(String lookUptype)
        {

            DataTable dataTable= new DataTable();
            switch (lookUptype)
            {

                case "species_specifics":


                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM species_specifics ", DatabaseServices.con);
                        adapter.Fill(dataTable);


                    }
                    catch (Exception ex)
                    {
                        // Handle the error
                    }


                    break;
                case "species_category":


                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM species_category", DatabaseServices.con);
                        adapter.Fill(dataTable);


                    }
                    catch (Exception ex)
                    {
                        // Handle the error
                    }


                    break;

                case "species_stages":


                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM species_stages", DatabaseServices.con);
                        adapter.Fill(dataTable);


                    }
                    catch (Exception ex)
                    {
                        // Handle the error
                    }


                    break;
                case "density_category":


                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM density_category", DatabaseServices.con);
                        adapter.Fill(dataTable);


                    }
                    catch (Exception ex)
                    {
                        // Handle the error
                    }


                    break;

                case "owners":


                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM owners", DatabaseServices.con);
                        adapter.Fill(dataTable);


                    }
                    catch (Exception ex)
                    {
                        // Handle the error
                    }


                    break;
                case "validations":


                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM validations", DatabaseServices.con);
                        adapter.Fill(dataTable);

                    

                    }
                    catch (Exception ex)
                    {
                        // Handle the error
                    }


                    break;
                    
            }

            var dict = new Dictionary<int, string>();

            if (0 < dataTable.Rows.Count) {

                dict.Add(0, "--Select--");

                foreach (DataRow dr in dataTable.Rows)
                {
                    dict.Add(Int32.Parse(dr[0].ToString()), dr[1].ToString());

                }
            }
            
            return dict;
        }

            

    }
}
