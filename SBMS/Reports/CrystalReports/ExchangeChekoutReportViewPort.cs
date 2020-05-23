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
    public partial class ExchangeCheckoutReportViewPort : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public ExchangeCheckoutReportViewPort()
        {
            InitializeComponent();
        }

        private void ExchangeCheckoutReportViewPort_Load(object sender, EventArgs e)
        {

            try
            {

                Selection selectionInstance = Application.OpenForms.OfType<Selection>().FirstOrDefault();

                string list_of_ids_with_comma = "";

                if (selectionInstance != null)
                {
                    List<int> ids = selectionInstance.getSlideIDs();
                    ids.ForEach(delegate (int sid)
                    {
                        list_of_ids_with_comma += sid + ",";
                    });

                    list_of_ids_with_comma = list_of_ids_with_comma.Remove(list_of_ids_with_comma.Length - 1);//reove tge kaqst ,
                }
                //list_of_ids_with_comma="1";
                //added created date as filter of todays eneter slides 
                String query = "SELECT * from exchanges c inner join slides as s on s.id = c.slide_id  inner join donors as d on d.id = s.donor_id inner join borrowers as b on b.id = c.exchange_contact_id inner join species_specifics as ss on ss.id = d.species_specific_id inner join species_category as sc on sc.id = d.species_catgeroy_id inner join species_stages as st on st.id = d.species_stage_id inner join density_category as dc on dc.id = d.density_category_id  WHERE s.id IN (" + list_of_ids_with_comma +");";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, DBConnectionSingltonServices.GetConnection());
                dataAdapter.SelectCommand.CommandText = query;
                DataTable sqldatatable = new DataTable();
                dataAdapter.Fill(sqldatatable);
                CrystalReportExchangeCheckout crystalReportExchangeCheckout = new CrystalReportExchangeCheckout();
                crystalReportExchangeCheckout.Database.Tables["ExchangeCheckouReportTable"].SetDataSource(sqldatatable);
                crystalReportViewer2.ReportSource = crystalReportExchangeCheckout;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Checkout Report generation has some expections");
            }
        }

        private void SearchChekoutReportViewPort_Load_1(object sender, EventArgs e)
        {

        }
    }
}
