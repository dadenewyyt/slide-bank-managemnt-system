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
    public partial class CheckOutReminderViewPort : Form
    {
        public CheckOutReminderViewPort()
        {
            InitializeComponent();
        }

        private void CheckOutReminderViewPort_Load(object sender, EventArgs e)
        {
            DueDateBorrowedCrystalReport crpt1DueDate = new DueDateBorrowedCrystalReport();
            String query = "SELECT * , l.created_by as borrowed_by, l.created_date as b_created_date FROM  dbo.current_lending as l INNER JOIN dbo.borrowers AS b ON b.id = l.borrower_id INNER JOIN dbo.slides AS s ON s.id = l.slide_id INNER JOIN dbo.donors as d on d.id = s.donor_id WHERE l.due_date >= getdate() ORDER BY d.donor_code,s.created_date ASC; ";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, DatabaseServices.GetConnection());
            dataAdapter.SelectCommand.CommandText = query;
            DataTable sqldatatable = new DataTable();
            dataAdapter.Fill(sqldatatable);
            crpt1DueDate.Database.Tables["CheckoutReminder"].SetDataSource(sqldatatable);
            CheckoutRemindercrystalReportViewer1.ReportSource = crpt1DueDate;
        }
    }
}
