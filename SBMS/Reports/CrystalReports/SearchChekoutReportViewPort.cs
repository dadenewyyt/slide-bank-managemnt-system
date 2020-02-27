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
    public partial class SearchChekoutReportViewPort : Form
    {
        public SearchChekoutReportViewPort()
        {
            InitializeComponent();
        }

        private void SearchChekoutReportViewPort_Load(object sender, EventArgs e)
        {
            CrystalReportSearchCheckout crpt1SearchCheckout = new CrystalReportSearchCheckout();

            Selection selectionFormCurrentInstance = Application.OpenForms.OfType<Selection>().FirstOrDefault();
            if (selectionFormCurrentInstance != null)
            {
                MessageBox.Show("Search Engine is Passing the Search Results to Report Engine");
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                DataGridView grd_clone = selectionFormCurrentInstance.getDataGridView();
                dt = grd_clone.DataSource as DataTable; //get the data source
                ds.Tables.Add(dt);
                crystalReportViewer1.Refresh();
                crpt1SearchCheckout.Database.Tables["slide_search"].SetDataSource(ds);
                crystalReportViewer1.ReportSource = crpt1SearchCheckout;
               
            }
                

            
        }
    }
}
