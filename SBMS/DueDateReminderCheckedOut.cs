using SBMS.Reports.CrystalReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBMS
{
    public partial class DueDateReminderCheckedOut : Form
    {
        public DueDateReminderCheckedOut()
        {
            InitializeComponent();
        }

        private void CheckoutReminder_Load(object sender, EventArgs e)
        {
           this.current_lending_duedate_passed_TableAdapter.Fill(this.sbmsDataSet.current_lending_duedate_passed);
           
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_Click_1(object sender, EventArgs e)
        {
            CheckOutReminderViewPort checkoutReminderViewPort = new CheckOutReminderViewPort();
            checkoutReminderViewPort.MdiParent = this.ParentForm;
            checkoutReminderViewPort.Show();
        }
    }
}
