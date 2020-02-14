using System;
using System.Windows.Forms;

namespace SBMS
{
    public partial class SlideHistory : Form
    {
        public SlideHistory()
        {
            InitializeComponent();
        }

        private void SlideHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet.slide_history' table. You can move, or remove it, as needed.
            this.slidesHistoryTableAdapter.Fill(this.sbmsDataSet.slide_history);

        }
    }
}
