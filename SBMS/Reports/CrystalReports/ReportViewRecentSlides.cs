using CrystalDecisions.CrystalReports.Engine;
using SBMS.Reports.CrystalReports;
using SBMS.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SBMS
{
    public partial class ReportViewRecentSlides : Form
    {
        Dictionary<int, string> dictionaryDCatgerory;
        Dictionary<int, string> dictionarySpecifics;
        Dictionary<int, string> dictionaryStages;
        Dictionary<int, string> dictionarySCatgerory;
        LookUpServices lookupServices;
        public ReportViewRecentSlides()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ReportViewRecentSlides_Load(object sender, EventArgs e)
        {

            lookupServices = new LookUpServices();
            //get Speciece Specifics
            dictionarySpecifics = lookupServices.fetchLookupTables("species_specifics");
            dictionarySCatgerory = lookupServices.fetchLookupTables("species_category");
            dictionaryStages = lookupServices.fetchLookupTables("species_stages");
            dictionaryDCatgerory = lookupServices.fetchLookupTables("density_category");

            ReportDocument reportDocumument = new ReportDocument();
            DataGridView recentSLideDataGridView = new DataGridView();
            //just getting the Form 2 instance, you can implement it in any way you choose to (e.g. make it global...)

            //Slides slideFormsFromReport = this.ParentForm.MdiChildren.Any(child => child is Slides).().SingleOrDefault();
            Slides slideFormsFromReport = Application.OpenForms.OfType<Slides>().FirstOrDefault();

            if (slideFormsFromReport != null)
            {
                //MessageBox.Show("got SLides");
                recentSLideDataGridView = slideFormsFromReport.getDataGridView();
                          

                //added created date as filter of todays eneter slides 
                String query = "SELECT s.id, s.bar_code, s.sequence, s.donor_id, s.cabinet_number, s.drawer_number, s.box_number, s.isDamaged, s.isReserved, s.isBorrowed, s.isActive, s.updated_date, s.created_date, s.created_by, s.updated_by, d.id AS donor_donor_id, d.donor_code, d.species_specific_id, d.species_stage_id, d.species_catgeroy_id, d.lower_density, d.average_density, d.upper_density, d.density_category_id, d.owner_id, d.acquired_date, d.country_code, d.comment, d.validation_id FROM dbo.slides AS s INNER JOIN dbo.donors AS d ON d.id = s.donor_id WHERE (d.isActive = 1) AND(s.isActive = 1) AND(s.isBorrowed = 0) AND CAST(s.created_date AS DATE) = CAST(GETDATE() AS DATE) ORDER BY s.created_date DESC";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, DatabaseServices.GetConnection());
                dataAdapter.SelectCommand.CommandText =query;
                DataTable sqldatatable = new DataTable();
                
                dataAdapter.Fill(sqldatatable);
               
                CrystalReportRecentSlides crpt1Recent = new CrystalReportRecentSlides();
                crpt1Recent.Database.Tables["recent_slide_dataset"].SetDataSource(sqldatatable);
                crystalReportViewer1.ReportSource = crpt1Recent;




               
            }

        }
    }
}

