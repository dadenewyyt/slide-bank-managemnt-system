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
    public partial class AllIncomingExchangeSlidesReportViewPort : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public AllIncomingExchangeSlidesReportViewPort()
        {
            InitializeComponent();
        }

        private void AllIncomingExchangeSlidesReportViewPort_Load(object sender, EventArgs e)
        {
            try
            {

                String query = "SELECT * FROM  slides AS s inner join donors AS d ON d.id = s.donor_id inner join density_category as dc on dc.id = d.density_category_id inner join species_category as sc on sc.id = d.species_catgeroy_id inner join species_specifics as ss on ss.id = d.species_specific_id inner join species_stages as st on st.id = d.species_stage_id inner join borrowers as b on b.id = d.exchange_id WHERE d.isExchange = 1 ORDER BY s.id; ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, DBConnectionSingltonServices.GetConnection());
                dataAdapter.SelectCommand.CommandText = query;
                DataTable sqldatatable = new DataTable();
                dataAdapter.Fill(sqldatatable);
                CrystalReportIncomingExchangeCheckout crystalReportIncomingExchangeCheckout = new CrystalReportIncomingExchangeCheckout();
                crystalReportIncomingExchangeCheckout.Database.Tables["ExchangeSlidesIncomingDataTable"].SetDataSource(sqldatatable);
                crystalReportViewer1.ReportSource = crystalReportIncomingExchangeCheckout;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Checkout Report generation has some expections");
            }
        }
    }
}
