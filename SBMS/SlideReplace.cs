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
    public partial class CheckOutReminder : Form
    {
        public CheckOutReminder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validateAndSearchFlags() {

            if (String.IsNullOrEmpty(txt_to_replace.Text)) {
                MessageBox.Show("Slide to replace should not be empty");
                return false;
            }
            if (String.IsNullOrEmpty(txt_replaced.Text))
            {
                MessageBox.Show("Replaced with slide should not be empty");
                return false;
            }

            return true;
        }

        private bool validateSlideSequenceIds()
        {
            
            if (String.IsNullOrEmpty(txt_to_replace.Text))
            {
                MessageBox.Show("Slide to replace should not be empty");
                return false;
            }
            if (String.IsNullOrEmpty(txt_replaced.Text))
            {
                MessageBox.Show("Replaced with slide should not be empty");
                return false;
            }

            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Validate and //trun search flag on frist

            bool Validation1st = validateAndSearchFlags();

        }

        private void SlideReplace_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'speciceCatgeroyDataSet.species_category' table. You can move, or remove it, as needed.
            this.species_categoryTableAdapter1.Fill(this.speciceCatgeroyDataSet.species_category);

        }
    }
}
