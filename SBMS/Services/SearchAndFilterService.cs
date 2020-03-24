using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SBMS.Services
{
    class SearchAndFilterService
    {
        public int SSID;
        public int SCID;
        public int DCID;
        public int SID;
        public int qunatity;

        public DataTable FilterSlides()
        {

            DataTable checkouSlideDT = new DataTable();
            string strCommandText = "SELECT top(2) s.id, s.bar_code, s.sequence, s.donor_id, s.cabinet_number, s.drawer_number, s.box_number, s.isDamaged, s.isReserved, s.isBorrowed, s.isActive, s.updated_date, s.created_date, s.created_by, s.updated_by, d.id AS donor_donor_id, d.donor_code, d.species_specific_id, d.species_stage_id, d.species_catgeroy_id, d.lower_density, d.average_density, d.upper_density, d.density_category_id, d.owner_id, d.acquired_date," +
                "d.country_code, d.comment, d.validation_id FROM dbo.slides AS s INNER JOIN dbo.donors AS d ON d.id = s.donor_id WHERE(d.isActive = 1) and(s.isBorrowed = 0) and(s.isReserved = 0) and(s.isDamaged = 0) ORDER BY s.id";
            SqlDataAdapter SlideCheckouFilterAdpter = new SqlDataAdapter(strCommandText, DatabaseServices.con);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(SlideCheckouFilterAdpter);
            checkouSlideDT.Clear();
            SlideCheckouFilterAdpter.Fill(checkouSlideDT);
            // if there are records, bind to Grid view & display
            return checkouSlideDT;
        }

        public DataTable searchSlideByParasiteQuanityAndDensity(string parasiste,int quantity,string density)
        {
            DataTable searchResults = new DataTable();
            using (var con = new SqlConnection(DatabaseServices.connectionString))
            using (var cmd = new SqlCommand("dbo.sp_slidesearchengine", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parasite_type", parasiste);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@density", density);
                da.Fill(searchResults);
            }
         
            return searchResults;
        }

        public DataTable SearchLendingByBorrowerId(int id) {
            DataTable searchResults = new DataTable();
            using (var con = new SqlConnection(DatabaseServices.connectionString))
            using (var cmd = new SqlCommand("SELECT * FROM  dbo.current_lending as l INNER JOIN dbo.borrowers AS b ON b.id = l.borrower_id INNER JOIN dbo.slides AS s ON s.id = l.slide_id INNER JOIN dbo.donors as d on d.id = s.donor_id where borrower_id=@id", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                da.Fill(searchResults);
            }

            if (searchResults != null)
                return searchResults;
            return null;
        }

        public DataTable SearchSlideByNumber(int number)
        {

            DataTable checkouSlideDT = new DataTable();
            string strCommandText = "SELECT top(500) s.id, s.bar_code, s.sequence, s.donor_id, s.cabinet_number, s.drawer_number, s.box_number, s.isDamaged, s.isReserved, s.isBorrowed, s.isActive, s.updated_date, s.created_date, s.created_by, s.updated_by, d.id AS donor_donor_id, d.donor_code, d.species_specific_id, d.species_stage_id, d.species_catgeroy_id, d.lower_density, d.average_density, d.upper_density, d.density_category_id, d.owner_id, d.acquired_date," +
                "d.country_code, d.comment, d.validation_id FROM dbo.slides AS s INNER JOIN dbo.donors AS d ON d.id = s.donor_id WHERE(d.isActive = 1) and(s.isBorrowed = 0) and(s.isReserved = 0) and(s.isDamaged = 0) and (s.sequence="+number+") ORDER BY d.id";
            SqlDataAdapter SlideCheckouFilterAdpter = new SqlDataAdapter(strCommandText, DatabaseServices.con);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(SlideCheckouFilterAdpter);
            checkouSlideDT.Clear();
            SlideCheckouFilterAdpter.Fill(checkouSlideDT);
            // if there are records, bind to Grid view & display
            return checkouSlideDT;
        }

        public DataTable SearchSlideByDonor(int donor)
        {

            DataTable checkouSlideDT = new DataTable();
            string strCommandText = "SELECT top(500) s.id, s.bar_code, s.sequence, s.donor_id, s.cabinet_number, s.drawer_number, s.box_number, s.isDamaged, s.isReserved, s.isBorrowed, s.isActive, s.updated_date, s.created_date, s.created_by, s.updated_by, d.id AS donor_donor_id, d.donor_code, d.species_specific_id, d.species_stage_id, d.species_catgeroy_id, d.lower_density, d.average_density, d.upper_density, d.density_category_id, d.owner_id, d.acquired_date," +
                "d.country_code, d.comment, d.validation_id FROM dbo.slides AS s INNER JOIN dbo.donors AS d ON d.id = s.donor_id WHERE(d.isActive = 1) and(s.isBorrowed = 0) and(s.isReserved = 0) and(s.isDamaged = 0) and (d.donor_code=" + donor + ") ORDER BY d.id";
            SqlDataAdapter SlideCheckouFilterAdpter = new SqlDataAdapter(strCommandText, DatabaseServices.con);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(SlideCheckouFilterAdpter);
            checkouSlideDT.Clear();
            SlideCheckouFilterAdpter.Fill(checkouSlideDT);
            // if there are records, bind to Grid view & display
            return checkouSlideDT;
        }

        public DataTable SearchLocationOccupied(int c , int d , int b)
        {

            DataTable locationData = new DataTable();
            string strCommandText = "SELECT s.bar_code, s.sequence,s.cabinet_number, s.drawer_number, s.box_number, s.isDamaged, s.isReserved, s.isBorrowed, s.isActive, d.donor_code, d.species_specific_id, d.species_stage_id, d.species_catgeroy_id, d.lower_density, d.average_density, d.upper_density, d.density_category_id, d.owner_id, d.acquired_date, d.country_code FROM dbo.slides AS s INNER JOIN dbo.donors AS d ON d.id = s.donor_id WHERE(d.isActive = 1) and(s.cabinet_number == "+c+") and(s.drawer_number ="+d+")and(s.box_number = "+b+") ORDER BY s.cabinet_number; ";
            SqlDataAdapter SlideCheckouFilterAdpter = new SqlDataAdapter(strCommandText, DatabaseServices.con);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(SlideCheckouFilterAdpter);
            locationData.Clear();
            SlideCheckouFilterAdpter.Fill(locationData);
            // if there are records, bind to Grid view & display
            return locationData;
        }
    }
}
