using System;
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
            slide.MdiParent = this.ParentForm;
            slide.Show();
        }

        private void btn_donors_Click(object sender, EventArgs e)
        {

            Donors donors = new Donors();
            donors.MdiParent = this.ParentForm;

            donors.Show();
        }

        private void bn_borrowers_Click(object sender, EventArgs e)
        {
            Borrowers borrowers = new Borrowers();
            borrowers.MdiParent = this.ParentForm;

            borrowers.Show();
        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {

            Checkin_Checkout checkin = new Checkin_Checkout();
            checkin.MdiParent = this.ParentForm;
            checkin.Show();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.MdiParent = this.ParentForm;
            checkout.Show();
        }

        private void btn_all_slides_Click(object sender, EventArgs e)
        {
            AllSlides allSlides = new AllSlides();
            allSlides.MdiParent = this.ParentForm;

            allSlides.Show();
        }

        private void btn_archive_summary_Click(object sender, EventArgs e)
        {
            ArchiveSummary archiveSummary = new ArchiveSummary();
            archiveSummary.MdiParent = this.ParentForm;

            archiveSummary.Show();
        }

        private void btn_lending_history_Click(object sender, EventArgs e)
        {
            Lending lending = new Lending();
            lending.MdiParent = this.ParentForm;

            lending.Show();
        }

        private void btn_user_account_Click(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Selection selection = new Selection();
            selection.MdiParent = this.ParentForm;
            selection.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SlideHistory slideHistory = new SlideHistory();
            slideHistory.MdiParent = this.ParentForm;
            slideHistory.Show();
        }
    }
}
