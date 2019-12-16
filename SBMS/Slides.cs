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
    public partial class Slides : Form
    {
        public Slides()
        {
            InitializeComponent();
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Slides_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet11.speciec_type' table. You can move, or remove it, as needed.
            this.speciec_typeTableAdapter.Fill(this.sbmsDataSet11.speciec_type);
            // TODO: This line of code loads data into the 'sbmsDataSet11.slides' table. You can move, or remove it, as needed.
            this.slidesTableAdapter1.Fill(this.sbmsDataSet11.slides);
            // TODO: This line of code loads data into the 'sbmsSlideDataSet.slides' table. You can move, or remove it, as needed.
            this.slidesTableAdapter.Fill(this.sbmsSlideDataSet.slides);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
