using MSBMS.Services;
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

namespace MSBMS.Reports.CrystalReports
{
    public partial class PrintCurrentLendings : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public PrintCurrentLendings()
        {
            InitializeComponent();
        }

        private void PrintCurrentLendings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet.current_lending_history' table. You can move, or remove it, as needed.
            try
            {
                //added created date as filter of todays eneter slides 
                String query = "  SELECT * from current_lending c inner join slides as s on s.id = c.slide_id inner join donors as d on d.id = s.donor_id inner join contacts as b on b.id = c.borrower_id inner join species_specifics as ss on ss.id = d.species_specific_id inner join species_category as sc on sc.id = d.species_catgeroy_id  inner join species_stages as st on st.id = d.species_stage_id inner join density_category as dc on dc.id = d.density_category_id  WHERE c.isHistory = 0 and c.reason <> 'Exchange' and isDefault=0 and b.isExchange=0;";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, DBConnectionSingltonServices.GetConnection());
                dataAdapter.SelectCommand.CommandText = query;
                DataTable sqldatatable = new DataTable();
                dataAdapter.Fill(sqldatatable);
                CrystalReportCurrentLendings crystalReportCurrentLending = new CrystalReportCurrentLendings();
                crystalReportCurrentLending.Database.Tables["checkedout_slides_details"].SetDataSource(sqldatatable);
                crystalReportViewer1.ReportSource = crystalReportCurrentLending;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "All Borrowed  Slide Report generation has some expections");
            }
        }
    }
}
