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
    public partial class MDIChild : Form
    {
        public MDIChild()
        {
            InitializeComponent();
        }

               
        private void btn_slides_Click(object sender, EventArgs e)
        {
            Slides slide = new Slides();
            slide.ShowDialog();
        }

        private void btn_donors_Click(object sender, EventArgs e)
        {

            Donors donors = new Donors();
            donors.ShowDialog();
        }

        private void bn_borrowers_Click(object sender, EventArgs e)
        {
            Borrowers borrowers = new Borrowers();
            borrowers.ShowDialog();
        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {

            Checkin_Checkout checkin = new Checkin_Checkout();
            checkin.ShowDialog();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.ShowDialog();
        }

        private void btn_all_slides_Click(object sender, EventArgs e)
        {
            AllSlides allSlides = new AllSlides();
            allSlides.ShowDialog();
        }

        private void btn_archive_summary_Click(object sender, EventArgs e)
        {
            ArchiveSummary archiveSummary = new ArchiveSummary();
            archiveSummary.ShowDialog();
        }

        private void btn_lending_history_Click(object sender, EventArgs e)
        {
            Lending lending = new Lending();
            lending.ShowDialog();
        }
    }
}
