using SBMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SBMS
{
    public partial class Donors : Form
    {
        public Donors()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Donors_Load(object sender, EventArgs e)
        {

            LookUpServices lookupServices = new LookUpServices();

            //get Speciece Specifics
            Dictionary<int, string> dictionarySpecifics = lookupServices.fetchLookupTables("species_specifics");

            cmb_specice_specifics.DataSource = new BindingSource(dictionarySpecifics, null);
            cmb_specice_specifics.ValueMember = "Key";
            cmb_specice_specifics.DisplayMember = "Value";
            cmb_specice_specifics.SelectedIndex = 0;

            //get Speciece Specifics
            Dictionary<int, string> dictionarySCatgerory = lookupServices.fetchLookupTables("species_category");
            cmb_specice_category.DataSource = new BindingSource(dictionarySCatgerory, null);
            cmb_specice_category.ValueMember = "Key";
            cmb_specice_category.DisplayMember = "Value";

            cmb_specice_category.SelectedIndex = 0;

            //get Speciece Stage
            Dictionary<int, string> dictionaryStages = lookupServices.fetchLookupTables("species_stages");
            cmb_specice_stage.DataSource = new BindingSource(dictionaryStages, null);
            cmb_specice_stage.ValueMember = "Key";
            cmb_specice_stage.DisplayMember = "Value";
            cmb_specice_stage.SelectedIndex = 0;

            //get Speciece Specifics
            Dictionary<int, string> dictionaryDCatgerory = lookupServices.fetchLookupTables("density_category");
            cmb_density_category.DataSource = new BindingSource(dictionaryDCatgerory, null);
            cmb_density_category.ValueMember = "Key";
            cmb_density_category.DisplayMember = "Value";
            cmb_density_category.SelectedIndex = 0;


            //get validation
            Dictionary<int, string> dictionaryValidations = lookupServices.fetchLookupTables("validations");
            cmb_validation.DataSource = new BindingSource(dictionaryValidations, null);
            cmb_validation.ValueMember = "Key";
            cmb_validation.DisplayMember = "Value";
            cmb_validation.SelectedIndex = 0;

            //get owners 
            Dictionary<int, string> dictionaryOwners = lookupServices.fetchLookupTables("owners");
            cmb_owners.DataSource = new BindingSource(dictionaryOwners, null);
            cmb_owners.ValueMember = "Key";
            cmb_owners.DisplayMember = "Value";
            cmb_owners.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
