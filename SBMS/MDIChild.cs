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

        private void button1_Click(object sender, EventArgs e)
        {
            Slides slide = new Slides();
            slide.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Donors donors = new Donors();
            donors.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Borrowers borrowers = new Borrowers();
            borrowers.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Lending lending = new Lending();
            lending.ShowDialog();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Borrowers borrowers = new Borrowers();
            borrowers.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Slides slide = new Slides();
            slide.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Checkin_Checkout checkin = new Checkin_Checkout();
            checkin.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Donors donor = new Donors();
            donor.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            AllSlides allSlides = new AllSlides();
            allSlides.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ArchiveSummary archiveSummary = new ArchiveSummary();
            archiveSummary.ShowDialog();
        }
    }
}
