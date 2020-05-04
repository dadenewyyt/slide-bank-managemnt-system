using SBMS.Services;
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
    public partial class AllSlidesReportViewePort : Form
    {
        public AllSlidesReportViewePort()
        {
            InitializeComponent();
        }

        private void AllSlidesReportViewePort_Load(object sender, EventArgs e)
        {
            String query = "SELECT s.id, s.bar_code, s.sequence, s.donor_id, s.cabinet_number, s.drawer_number, s.box_number, s.isDamaged, s.isReserved, s.isBorrowed, s.isActive, s.updated_date, s.created_date, s.created_by, s.updated_by, d.id AS donor_donor_id, d.donor_code, d.species_specific_id, d.species_stage_id, d.species_catgeroy_id, d.lower_density, d.average_density, d.upper_density, d.density_category_id, d.owner_id, d.acquired_date, d.country_code, d.comment, d.validation_id FROM dbo.slides AS s INNER JOIN dbo.donors AS d ON d.id = s.donor_id ORDER BY s.created_date DESC";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, DBConnectionSingltonServices.GetConnection());
            dataAdapter.SelectCommand.CommandText = query;
            DataTable sqldatatable = new DataTable();
            dataAdapter.Fill(sqldatatable);

            CrystalReportAllSlides crpt1AllSlides = new CrystalReportAllSlides();
            crpt1AllSlides.Database.Tables["recent_slide_dataset"].SetDataSource(sqldatatable);
            crystalReportViewer1.ReportSource = crpt1AllSlides;
        }
    }
}
