using SBMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBMS
{
    public partial class Slides : Form
    {
        DataFetchService dataFetchService;
        private int Donor_Id_Slide = -1;
        public Slides()
        {
            

            InitializeComponent();
            rdoDamagedNo.Checked = true;
            rdoResevedNo.Checked = true;
        }

        public void clear()
        {
            txt_slide_scan.Text = string.Empty;
            txt_slide_sequence.Text = string.Empty;
            txt_country_code.Text = string.Empty;
            txt_donor_code.Text = string.Empty;
            cmb_specice_specifics.SelectedIndex = 0;
            cmb_specice_category.SelectedIndex = 0;
            cmb_specice_stage.SelectedIndex = 0;
            txt_lower_density.Text = string.Empty;
            txt_average_density.Text = string.Empty;
            txt_upper_density.Text = string.Empty;
            cmb_density_category.SelectedIndex = 0;
            cmb_owners.SelectedIndex = 0;
            txt_acquired_date.Text = "";
            cmb_validation.SelectedIndex = 0;
            txt_comment.Text = "";
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Slides_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet1.slides' table. You can move, or remove it, as needed.
            this.slidesTableAdapter.Fill(this.sbmsDataSet1.slides);
            // TODO: This line of code loads data into the 'sbmsDataSet.slides' table. You can move, or remove it, as needed.
            this.slidesTableAdapter.Fill(this.sbmsDataSet.slides);
            // TODO: This line of code loads data into the 'sbmsDataSet1.slides' table. You can move, or remove it, as needed.
            this.slidesTableAdapter.Fill(this.sbmsDataSet1.slides);
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

        private void enter_pressed(object sender, KeyPressEventArgs e)
        {
            Dictionary<string, string> separated = new Dictionary<string, string>() ;

            if (e.KeyChar == (char)13)
            {

                if (txt_slide_scan.TextLength != 8)
                {
                    MessageBox.Show("Slide Scan in must be 8 digits.", "INFORMATION", MessageBoxButtons.OK);
                    return;
                }

                if (int.TryParse(txt_slide_scan.Text.ToString(), out int n)==false) //numbers only
                {
                    MessageBox.Show("Slide Scan must all be numeric value.", "INFORMATION", MessageBoxButtons.OK);
                    return;
                }

                HelperServices helperService = new HelperServices();
                separated = helperService.SeperateBarCodeIntoCodes(txt_slide_scan.Text.ToString());

                if (separated == null) return;

                txt_country_code.Text = separated["CC"];
                txt_donor_code.Text = separated["DC"];
                txt_slide_sequence.Text = separated["SS"];
                txt_bar_code.Text = txt_slide_scan.Text;
              
            }

            
                //fetch if there is any thing found with that donor id..it should be a must found since we suppose donor is already exisiting

           if (separated.Count() > 0) { 
                    
            dataFetchService = new DataFetchService();
            DataTable slideInfoDonorDT = dataFetchService.FecthSlideByDonorCode(separated["DC"].ToString());

                if (slideInfoDonorDT.Rows.Count > 0)
                {
                    //fetch data
                    foreach (DataRow row in slideInfoDonorDT.Rows)
                    {

                        cmb_specice_specifics.SelectedIndex = Convert.ToInt32(row["species_specific_id"].ToString());
                        cmb_specice_category.SelectedIndex = Convert.ToInt32(row["species_catgeroy_id"].ToString());
                        cmb_specice_stage.SelectedIndex = Convert.ToInt32(row["species_stage_id"].ToString());
                        txt_lower_density.Text = row["lower_density"].ToString(); ;
                        txt_average_density.Text = row["average_density"].ToString(); 
                        txt_upper_density.Text = row["upper_density"].ToString(); ;
                        cmb_density_category.SelectedIndex = Convert.ToInt32(row["density_category_id"].ToString());
                        cmb_owners.SelectedIndex = Convert.ToInt32(row["owner_id"].ToString());
                        txt_acquired_date.Text = row["acquired_date"].ToString(); ;
                        cmb_validation.SelectedIndex = Convert.ToInt32(row["validation_id"].ToString());
                        txt_comment.Text = row["comment"].ToString();
                        Donor_Id_Slide = Convert.ToInt32(row["id"].ToString());
                    }

                    // txt_donor_code.Text = dgr_donors.Rows[e.RowIndex].Cells["donorcodeDataGridViewTextBoxColumn"].Value.ToString();
                   



                }
                else {

                    MessageBox.Show("The Entered Donor Code is New! System could not found any record on the database. Register the donor first and come back.", "ERROR", MessageBoxButtons.OK);
                }
                
            }


        }

        private void clicked_on(object sender, MouseEventArgs e)
        {
            txt_slide_scan.Text = "";
            txt_donor_code.Text = "";
            txt_slide_sequence.Text = "";
            txt_bar_code.Text = "";
            txt_country_code.Text = "";
        }

        private bool ValidateBeforeSave()
        {


            if (String.IsNullOrEmpty(txt_slide_scan.Text) || String.IsNullOrEmpty(txt_country_code.Text) || String.IsNullOrEmpty(txt_donor_code.Text) || String.IsNullOrEmpty(txt_slide_sequence.Text))
            {

                MessageBox.Show("Barcode , Donor code , Country code , Sequence Code should not be empty to save new Donor Information. Press enter after you entered scan in barcode or enter a valida barcode number.", "Validation ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            if (String.IsNullOrEmpty(txt_lower_density.Text) || String.IsNullOrEmpty(txt_average_density.Text) || String.IsNullOrEmpty(txt_upper_density.Text))
            {

                MessageBox.Show("Density Values Should not be Empty.", "Validation ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            if (cmb_specice_specifics.SelectedIndex == 0 || cmb_density_category.SelectedIndex == 0 || cmb_specice_category.SelectedIndex == 0 || cmb_specice_stage.SelectedIndex == 0 || cmb_validation.SelectedIndex == 0 || cmb_owners.SelectedIndex == 0)
            {
                MessageBox.Show("You can not save a data with the value --Select-- choice?", "Validation ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           

            return true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dataFetchService = new DataFetchService();
            int slideDuplicate = dataFetchService.CheckDuplicateSlideInfo(txt_slide_sequence.Text);

            if (slideDuplicate == 1)
            {

                MessageBox.Show("Slide with Sequence Code <" + txt_slide_sequence.Text.Trim() + "> already exists.", "Duplicate Entry no allowed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
                return;
            }

            bool isValid = ValidateBeforeSave();

            if (isValid == false)
            {
                MessageBox.Show("Data is not saved. Please enter correct and valid value for all data elements", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //TODO:check location data if occupied or not

            if (Donor_Id_Slide != -1)
            {
                // MessageBox.Show("Saving");
                DateTime dt = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(DatabaseServices.connectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        string insertSlideQuery = "INSERT into slides" +
                             "(bar_code,sequence,donor_id,cabinet_number,drawer_number,box_number,isDamaged,isReserved,isBorrowed,isActive,created_date,created_by) " +
                              "VALUES (@bar_code,@sequence,@donor_id,@cabinet_number,@drawer_number,@box_number,@isDamaged,@isReserved,@isBorrowed,@isActive,@created_date,@created_by)";

                        command.CommandType = CommandType.Text;
                        command.CommandText = insertSlideQuery;

                        command.Parameters.AddWithValue("@bar_code", txt_slide_scan.Text);
                        command.Parameters.AddWithValue("@sequence", txt_slide_sequence.Text);
                        command.Parameters.AddWithValue("@donor_id", Donor_Id_Slide);
                        command.Parameters.AddWithValue("@cabinet_number", Convert.ToInt32(txt_cabinet_number.Text).ToString());
                        command.Parameters.AddWithValue("@drawer_number", Convert.ToInt32(txt_drawer_number.Text).ToString());
                        command.Parameters.AddWithValue("@box_number", Convert.ToInt32(txt_box_number.Text).ToString());

                        if (rdoDamagedYes.Checked)
                            command.Parameters.AddWithValue("@isDamaged", true);
                        if (rdoDamagedNo.Checked)
                            command.Parameters.AddWithValue("@isDamaged", false);
                        if (rdoDamagedYes.Checked)
                            command.Parameters.AddWithValue("@isDamaged", true);
                        if (rdoResevedYes.Checked)
                            command.Parameters.AddWithValue("@isReserved", true);
                        if (rdoResevedNo.Checked)
                            command.Parameters.AddWithValue("@isReserved", false);
                        if (rdoDamagedYes.Checked)
                            command.Parameters.AddWithValue("@isActive", false);
                        else
                            command.Parameters.AddWithValue("@isActive", true);

                        command.Parameters.AddWithValue("@isBorrowed", false);
                        command.Parameters.AddWithValue("@created_date", DateTime.Today.Date);
                        command.Parameters.AddWithValue("@created_by", "Daniel");

                        try
                        {

                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }
                            int recordsAffected = command.ExecuteNonQuery();

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("System has found error. Sorry We are not able to save this time","System Error");
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            MessageBox.Show("Slide's Information Has been Saved Successfully", "Success");
                            clear();
                           // this.btn_reload_Click(null, null);
                            //this.btn_reload_Click(null, null);
                          //  lbl_editing_status.Visible = false;
                            // btn_deactivate.Enabled = false;
                          //  btn_save.Enabled = true;
                           // btn_save_edit.Enabled = false;
                            connection.Close();
                        }

                    }
                }
            }
        }
    }
}
