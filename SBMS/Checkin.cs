using System;
using System.Windows.Forms;

namespace SBMS
{
    public partial class Checkin_Checkout : Form
    {
        public Checkin_Checkout()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Checkin_Checkout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet.species_specifics' table. You can move, or remove it, as needed.
            this.species_specificsTableAdapter.Fill(this.sbmsDataSet.species_specifics);
            // TODO: This line of code loads data into the 'desnityCat_bindingDataSource.density_category' table. You can move, or remove it, as needed.
            this.density_categoryTableAdapter.Fill(this.desnityCat_bindingDataSource.density_category);
            // TODO: This line of code loads data into the 'sbmsDataSet.species_category' table. You can move, or remove it, as needed.
            this.species_categoryTableAdapter.Fill(this.sbmsDataSet.species_category);

        }
    }
}
