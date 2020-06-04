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
    public partial class CheckOutReminderViewPort : Form
    {
        public CheckOutReminderViewPort()
        {
            InitializeComponent();
        }

        private void CheckOutReminderViewPort_Load(object sender, EventArgs e)
        {
            DueDateBorrowedCrystalReport crpt1DueDate = new DueDateBorrowedCrystalReport();
            String query = "SELECT * FROM dbo.current_lending as l INNER JOIN dbo.contacts AS b ON b.id = l.borrower_id INNER JOIN dbo.slides AS s ON s.id = l.slide_id INNER JOIN dbo.donors as d on d.id = s.donor_id inner join dbo.species_category as sc on sc.id = d.species_catgeroy_id inner join dbo.species_specifics as ss on ss.id = d.species_specific_id inner join dbo.density_category as dc on dc.id = d.density_category_id where DATEDIFF(day, due_date, GETDATE()) > 0 and s.isBorrowed = 1 and isDamaged = 0 and isOutExchanged = 0 and isMissing = 0 and s.isActive = 1 ORDER BY d.donor_code,s.created_date ASC;";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, DBConnectionSingltonServices.GetConnection());
            dataAdapter.SelectCommand.CommandText = query;
            DataTable sqldatatable = new DataTable();
            dataAdapter.Fill(sqldatatable);
            crpt1DueDate.Database.Tables["current_lending_duedate_passed"].SetDataSource(sqldatatable);
            CheckoutRemindercrystalReportViewer1.ReportSource = crpt1DueDate;
        }
    }
}
