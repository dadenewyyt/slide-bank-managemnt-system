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
    public partial class SlideReplace : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public SlideReplace()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validateAndSearchFlags() {


            return true;
        }

        private bool validateSlideSequenceIds()
        {
          

            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Validate and //trun search flag on frist

            bool Validation1st = validateAndSearchFlags();

        }

        private void SlideReplace_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet.slide_reserved_for_replacement' table. You can move, or remove it, as needed.
            this.slide_reserved_for_replacementTableAdapter.Fill(this.sbmsDataSet.slide_reserved_for_replacement);
            // TODO: This line of code loads data into the 'sbmsDataSet.slide_to_replace' table. You can move, or remove it, as needed.
            this.slide_to_replaceTableAdapter.Fill(this.sbmsDataSet.slide_to_replace);
            // TODO: This line of code loads data into the 'speciceCatgeroyDataSet.species_category' table. You can move, or remove it, as needed.
            this.species_categoryTableAdapter1.Fill(this.speciceCatgeroyDataSet.species_category);

        }
    }
}
