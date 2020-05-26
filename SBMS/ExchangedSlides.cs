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
    public partial class ExchangedSlides : Form
    {
        public ExchangedSlides()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExchangedSlides_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet.ExchangeSlidesIncomingDataTable' table. You can move, or remove it, as needed.
            this.exchangeSlidesIncomingDataTableTableAdapter.Fill(this.sbmsDataSet.ExchangeSlidesIncomingDataTable);
              // TODO: This line of code loads data into the 'sbmsDataSet.ExchangeCheckouReportTable' table. You can move, or remove it, as needed.
            this.exchangeCheckoutReportTableAdapter.Fill(this.sbmsDataSet.ExchangeCheckouReportTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllGoingExchangeSlidesReportViewPort reportView = new AllGoingExchangeSlidesReportViewPort();
            reportView.MdiParent = this.MdiParent;
            reportView.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllIncomingExchangeSlidesReportViewPort reportView = new AllIncomingExchangeSlidesReportViewPort();
            reportView.MdiParent = this.MdiParent;
            reportView.Show();
        }
    }
}
