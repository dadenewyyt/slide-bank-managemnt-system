using SBMS.Services;
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
            // TODO: This line of code loads data into the 'speciceDataSet.species_category' table. You can move, or remove it, as needed.
            this.species_categoryTableAdapter.Fill(this.specieCatgeoryDataSet.species_category);
            // TODO: This line of code loads data into the 'ownerDataBindingSource.owners' table. You can move, or remove it, as needed.
            this.ownersTableAdapter.Fill(this.ownerDataBindingSource.owners);
            // TODO: This line of code loads data into the 'validationDataBindingSource.validations' table. You can move, or remove it, as needed.
            this.validationsTableAdapter.Fill(this.validationDataBindingSource.validations);
            // TODO: This line of code loads data into the 'desnityCat_bindingDataSource.density_category' table. You can move, or remove it, as needed.
            this.density_categoryTableAdapter.Fill(this.desnityCat_bindingDataSource.density_category);
            // TODO: This line of code loads data into the 'stage_dataBindingSource.species_stages' table. You can move, or remove it, as needed.
            this.species_stagesTableAdapter.Fill(this.stage_dataBindingSource.species_stages);
            // TODO: This line of code loads data into the 'speciece_specifics_dataBindingSource.species_specifics' table. You can move, or remove it, as needed.
            this.species_specificsTableAdapter.Fill(this.speciece_specifics_dataBindingSource.species_specifics);
            // TODO: This line of code loads data into the 'sbmsDataSet.donors' table. You can move, or remove it, as needed.
            this.slidesTableAdapter.Fill(this.sbmsDataSet.slides);
            this.recent_slide_datasetTableAdapter.Fill(this.sbmsDataSet.recent_slide_dataset);

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
    }
}
