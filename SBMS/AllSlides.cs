using System.Windows.Forms;

namespace SBMS
{
    public partial class AllSlides : Form
    {
        public AllSlides()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AllSlides_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet.slides' table. You can move, or remove it, as needed.
            this.slidesTableAdapter.Fill(this.sbmsDataSet.slides);

        }
    }
}
