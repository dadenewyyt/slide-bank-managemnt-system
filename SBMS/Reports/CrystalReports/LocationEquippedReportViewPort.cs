using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBMS.Reports.CrystalReports
{
    public partial class LocationEquippedReportViewPort : Form
    {
        public LocationEquippedReportViewPort()
        {
            InitializeComponent();
        }

        private void LocationEquippedReportViewPort_Load(object sender, EventArgs e)
        {
            LocationEquippiedCrystalReport locationEquippiedCrystalReport = new LocationEquippiedCrystalReport();

            //added created date as filter of todays eneter slides 
            String query = "SELECT s.bar_code, s.sequence,s.cabinet_number, s.drawer_number, s.box_number, s.isDamaged, s.isReserved, s.isBorrowed, s.isActive, d.donor_code, d.species_specific_id, d.species_stage_id, d.species_catgeroy_id, d.lower_density, d.average_density, d.upper_density, d.density_category_id, d.owner_id, d.acquired_date,  d.country_code FROM dbo.slides AS s INNER JOIN dbo.donors AS d ON d.id = s.donor_id WHERE(d.isActive = 1) and(s.cabinet_number != 0) and(s.drawer_number != 0)and(s.box_number != 0) ORDER BY d.donor_code; ";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Services.DatabaseServices.GetConnection());
            dataAdapter.SelectCommand.CommandText = query;
            DataTable sqldatatable = new DataTable();

            dataAdapter.Fill(sqldatatable);

            locationEquippiedCrystalReport.Database.Tables["locationData"].SetDataSource(sqldatatable);
            locationReportViewer.ReportSource = locationEquippiedCrystalReport;

        }

    }

}