using System.Data;
using System.Data.SqlClient;

namespace SBMS.Services
{
    class FilterService
    {
        public int SSID;
        public int SCID;
        public int DCID;
        public int SID;
        public int qunatity;

        public DataTable FilterSlides()
        {

            DataTable checkouSlideDT = new DataTable();
            string strCommandText = "SELECT top(2) s.id, s.bar_code, s.sequence, s.donor_id, s.cabinet_number, s.drawer_number, s.box_number, s.isDamaged, s.isReserved, s.isBorrowed, s.isActive, s.updated_date, s.created_date, s.created_by, s.last_updated_by, d.id AS donor_donor_id, d.donor_code, d.species_specific_id, d.species_stage_id, d.species_catgeroy_id, d.lower_density, d.average_density, d.upper_density, d.density_category_id, d.owner_id, d.acquired_date," +
                "d.country_code, d.comment, d.validation_id FROM dbo.slides AS s INNER JOIN dbo.donors AS d ON d.id = s.donor_id WHERE(d.isActive = 1) and(s.isBorrowed = 0) and(s.isReserved = 0) and(s.isDamaged = 0) ORDER BY s.id";
            SqlDataAdapter SlideCheckouFilterAdpter = new SqlDataAdapter(strCommandText, DatabaseServices.con);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(SlideCheckouFilterAdpter);
            checkouSlideDT.Clear();
            SlideCheckouFilterAdpter.Fill(checkouSlideDT);
            // if there are records, bind to Grid view & display
            return checkouSlideDT;
        }
    }
}
