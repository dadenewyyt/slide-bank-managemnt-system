using SBMS.Reports.CrystalReports;
using SBMS.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SBMS
{
    public partial class Slides : Form
    {

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private int slide_id = -1;
        DataFetchService dataFetchService;
        public int donor_id = -1;
        public bool history_flag = false;

        //LookUpServices lookUpServices;

        public int Slides_Id_Update { get => slide_id; set => slide_id = value; }


        //fetched id when a bardcode is entered =>scan in
        private int Donor_Id_Slide { get => slide_id; set => slide_id = value; }


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
            txt_drawer_number.Text = "";
            txt_cabinet_number.Text = "";
            txt_box_number.Text = "";
            txt_bar_code.Text = "";
            txt_donor_code.BackColor = Color.Red;


        }

        public void enable_disable_inputs(bool flag)
        {

            cmb_specice_specifics.Enabled = flag;
            cmb_specice_category.Enabled = flag;
            cmb_specice_stage.Enabled = flag;
            txt_lower_density.ReadOnly = flag;
            txt_average_density.ReadOnly = flag;
            txt_upper_density.ReadOnly = flag;
            cmb_density_category.Enabled = flag;
            cmb_owners.Enabled = flag;
            txt_acquired_date.Enabled = flag;
            cmb_validation.Enabled = flag;
            txt_comment.ReadOnly = flag; ;
            txt_drawer_number.ReadOnly = !flag;
            txt_cabinet_number.ReadOnly = !flag;
            txt_box_number.ReadOnly = !flag;
            //txt_bar_code.Enabled = flag;


        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Slides_Load(object sender, EventArgs e)
        {

            dgr_allslides.AllowUserToAddRows = false;
            dgr_recentslides.AllowUserToAddRows = false;
            dgr_locations.AllowUserToAddRows = false;

            // TODO: This line of code loads data into the 'sbmsDataSet.locationData' table. You can move, or remove it, as needed.
            this.locationDataAdapter.Fill(this.sbmsDataSet.locationData);
            // TODO: This line of code loads data into the 'sbmsDataSet1.slides' table. You can move, or remove it, as needed.
            this.slidesTableAdapter.Fill(this.sbmsDataSet.slides);

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
            Dictionary<string, string> separated = new Dictionary<string, string>();
            try
            {

                if (e.KeyChar == (char)13)
                {

                    if (txt_slide_scan.TextLength != 8)
                    {
                        MessageBox.Show("Slide Scan in must be 8 digits.", "INFORMATION", MessageBoxButtons.OK);
                        return;
                    }

                    if (int.TryParse(txt_slide_scan.Text.ToString(), out int n) == false) //numbers only
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

                if (separated.Count() > 0)
                {

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
                        txt_donor_code.BackColor = Color.Green;
                    }
                    else
                    {
                        txt_donor_code.BackColor = Color.Red;
                        MessageBox.Show("The Entered Donor Code is New! System not found any record associted with the donor code. Register the donor first and come back.", "INFORMATION", MessageBoxButtons.OK);
                    }
                }
            }//end of try 
            catch (Exception ex) {
                logger.Error(ex, "Slide page with donor id search error");
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

            if (history_flag == true)
            {
                if (String.IsNullOrEmpty(txt_cabinet_number.Text) || String.IsNullOrEmpty(txt_drawer_number.Text) || String.IsNullOrEmpty(txt_box_number.Text))
                {

                    MessageBox.Show("Location Data is empty or not valid. Please , correct", "Validation ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;

                }
            }


            return true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            int cabinet = 0, drawer = 0, box = 0; bool isValid = true; //0,0,0 is imaginary postion


            dataFetchService = new DataFetchService();
            int slideDuplicate = dataFetchService.CheckDuplicateSlideInfo(txt_slide_sequence.Text,txt_bar_code.Text);

            if (slideDuplicate == 1)
            {

                MessageBox.Show("Slide with Sequence Code <" + txt_slide_sequence.Text.Trim() + "> already exists.", "Duplicate Entry no allowed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
                return;
            }

            if (history_flag == false)
            {
                isValid = true;// ValidateBeforeSave();
            }



            if (isValid == false && history_flag == false)
            {
                MessageBox.Show("Data is not saved. Please enter correct and valid value for all data elements", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //TODO:check location data if occupied or not


            //check damaged is selecty
            if (history_flag == true)
            {

                DialogResult result = MessageBox.Show("You have stated that slide is Damaged ?  Are you sure to save this slide ? Slide will never have real exisitince in physical location", "Damaged Slide Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    //execute normal code recheck slide as no 
                    //turn on damaged off to NO
                    rdoDamagedNo.Checked = true;
                    location_panel.Enabled = true;
                }
            }

            //convert to int
            if (history_flag == false)
            {
                cabinet = Convert.ToInt32(txt_cabinet_number.Text.ToString());
                drawer = Convert.ToInt32(txt_drawer_number.Text.ToString());
                box = Convert.ToInt32(txt_box_number.Text.ToString());
            }

            bool isValidLocation = true;

            if (history_flag == false)
                isValidLocation = ValidateSlideLocationData("save");

            if (Donor_Id_Slide != -1 && isValidLocation == true)
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

                        command.Parameters.AddWithValue("@cabinet_number", cabinet);
                        command.Parameters.AddWithValue("@drawer_number", drawer);
                        command.Parameters.AddWithValue("@box_number", box);


                        if (rdoDamagedYes.Checked)
                            command.Parameters.AddWithValue("@isDamaged", true);
                        if (rdoDamagedNo.Checked)
                            command.Parameters.AddWithValue("@isDamaged", false);

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
                        command.Parameters.AddWithValue("@created_by", "Full name="+UserAccountServices.Full_name + "=Username="+UserAccountServices.Username);

                        try
                        {

                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }

                            int recordsAffected = command.ExecuteNonQuery();

                            if (recordsAffected > 0)
                            {
                                MessageBox.Show("Slide's Information Saved !", "Success");
                                reload_data();

                            }

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "ERROR SAVING Slides", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            logger.Error(ex, "Slide Saving error Exception");

                        }
                        finally
                        {
                            clear();
                            this.btn_clear_selection_Click(null, null);
                            //this.btn_reload_Click(null, null);
                            lbl_editing_status.Visible = false;
                           // btn_deactivate.Enabled = false;
                            btn_save.Enabled = true;
                            btn_edit_update.Enabled = false;
                            connection.Close();
                        }

                    }
                }
            }
        }

        private void selected_row(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex;
            rowIndex = e.RowIndex;
            
            try
            {

                if (dgr_recentslides.Rows.Count > 0)
                {
                    MessageBox.Show("you selected row:" + (rowIndex + 1).ToString());

                    txt_bar_code.Text = dgr_recentslides.Rows[e.RowIndex].Cells["barcoderecentslidesGridViewColumn"].Value + string.Empty;
                    txt_slide_sequence.Text = dgr_recentslides.Rows[e.RowIndex].Cells["sequencerecentslidesGridViewColumn"].Value + string.Empty;
                    txt_country_code.Text = dgr_recentslides.Rows[e.RowIndex].Cells["ccrecentslidesGridViewColumn"].Value + string.Empty;
                    txt_donor_code.Text = dgr_recentslides.Rows[e.RowIndex].Cells["donorcodrecentslidesGridViewColumn"].Value.ToString();
                    cmb_specice_specifics.SelectedIndex = Convert.ToInt32(dgr_recentslides.Rows[e.RowIndex].Cells["ssrecentslidesGridViewColumn"].Value);
                    cmb_specice_category.SelectedIndex = Convert.ToInt32(dgr_recentslides.Rows[e.RowIndex].Cells["screcentslidesGridViewColumn"].Value);
                    cmb_specice_stage.SelectedIndex = Convert.ToInt32(dgr_recentslides.Rows[e.RowIndex].Cells["strecentslidesGridViewColumn"].Value);
                    txt_lower_density.Text = dgr_recentslides.Rows[e.RowIndex].Cells["ldrecentslidesGridViewColumn"].Value + string.Empty;
                    txt_average_density.Text = dgr_recentslides.Rows[e.RowIndex].Cells["adrecentslidesGridViewColumn"].Value + string.Empty;
                    txt_upper_density.Text = dgr_recentslides.Rows[e.RowIndex].Cells["udrecentslidesGridViewColumn"].Value.ToString();
                    cmb_density_category.SelectedIndex = Convert.ToInt32(dgr_recentslides.Rows[e.RowIndex].Cells["dcrecentslidesGridViewColumn"].Value);
                    cmb_owners.SelectedIndex = Convert.ToInt32(dgr_recentslides.Rows[e.RowIndex].Cells["ownerrecentslidesGridViewColumn"].Value);
                    txt_acquired_date.Text = dgr_recentslides.Rows[e.RowIndex].Cells["adaterecentslidesGridViewColumn"].Value.ToString();
                    cmb_validation.SelectedIndex = Convert.ToInt32(dgr_recentslides.Rows[e.RowIndex].Cells["validationrecentslidesGridViewColumn"].Value);
                    txt_comment.Text = dgr_recentslides.Rows[e.RowIndex].Cells["commentrecentslidesGridViewColumn"].Value.ToString();

                    if (Convert.ToBoolean(dgr_recentslides.Rows[e.RowIndex].Cells["isDamagedrecentslidesGridViewColumn"].Value))
                        rdoDamagedYes.Checked = true;
                    else
                        rdoDamagedNo.Checked = true;

                    if (Convert.ToBoolean(dgr_recentslides.Rows[e.RowIndex].Cells["isResevedrecentslidesGridViewColumn"].Value))
                        rdoResevedYes.Checked = true;
                    else
                        rdoResevedNo.Checked = true;
                    txt_cabinet_number.Text = dgr_recentslides.Rows[e.RowIndex].Cells["cabinetrecentslidesGridViewColumn"].Value.ToString();
                    txt_drawer_number.Text = dgr_recentslides.Rows[e.RowIndex].Cells["drawerrecentslidesGridViewColumn"].Value.ToString();
                    txt_box_number.Text = dgr_recentslides.Rows[e.RowIndex].Cells["boxrecentslidesGridViewColumn"].Value.ToString();

                    enable_disable_inputs(true); //enable for select

                    btn_edit_update.Enabled = true;
                    lbl_editing_status.Visible = true;
                    btn_save.Enabled = false;
                    Slides_Id_Update = Convert.ToInt32(dgr_recentslides.Rows[e.RowIndex].Cells["idrecentslidesGridViewColumn"].Value.ToString());
                }
                else
                {
                    enable_disable_inputs(false); //disabble for select
                    MessageBox.Show("NO Data to Select");
                }
            }//end of catch
            catch (Exception ex)
            {

            }
        }

        private void btn_edit_update_Click(object sender, EventArgs e)
        {
            bool isValidated = ValidateSlideLocationData("update");

            if (isValidated == false)
            {
                btn_clear_selection_Click(null, null);
                return;
            }

            if (isValidated == true && Slides_Id_Update != -1)
            {
                // MessageBox.Show("Saving");
                DateTime dt = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(DatabaseServices.connectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        string updateDonorQuery = "UPDATE slides " +
                            "SET updated_by=@updated_by,isDamaged=@isDamaged,isReserved=@isReserved,cabinet_number=@cabinet,drawer_number=@drawer,box_number=@box WHERE id=@id";

                        command.CommandType = CommandType.Text;
                        command.CommandText = updateDonorQuery;
                        command.Parameters.AddWithValue("@id", Slides_Id_Update);
                        command.Parameters.AddWithValue("@cabinet", Convert.ToInt32(txt_cabinet_number.Text.ToString()));
                        command.Parameters.AddWithValue("@box", Convert.ToInt32(txt_box_number.Text.ToString()));
                        command.Parameters.AddWithValue("@drawer", Convert.ToInt32(txt_drawer_number.Text.ToString()));

                        if (rdoDamagedYes.Checked == true)
                            command.Parameters.AddWithValue("@isDamaged", true);
                        if (rdoDamagedNo.Checked == true)
                            command.Parameters.AddWithValue("@isDamaged", false);

                        if (rdoResevedYes.Checked == true)
                            command.Parameters.AddWithValue("@isReserved", true);
                        if (rdoResevedNo.Checked == true)
                            command.Parameters.AddWithValue("@isReserved", false);

                        command.Parameters.AddWithValue("@updated_by", "Full name=" + UserAccountServices.Full_name + "=Username=" + UserAccountServices.Username);

                        try
                        {

                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }
                            int recordsAffected = command.ExecuteNonQuery();

                            if (recordsAffected > 0)
                            {
                                MessageBox.Show("Slide's Information Updated !", "Success");
                                reload_data();

                            }

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR: Updating Slide");
                            return;
                        }
                        finally
                        {

                            connection.Close();
                            btn_clear_selection_Click(null, null);
                            clear();
                            enable_disable_inputs(false);
                        }

                    }
                }
            }
        }

        private void btn_clear_selection_Click(object sender, EventArgs e)
        {
            try
            {
                btn_edit_update.Enabled = false;
                btn_save.Enabled = true;
                enable_disable_inputs(false); //diable inputs them
                if(dgr_recentslides.SelectedRows.Count>0)
                   dgr_recentslides.ClearSelection();
                Donor_Id_Slide = -1;
                Slides_Id_Update = -1;
                dgr_allslides.ClearSelection();
                lbl_editing_status.Visible = false;
                clear();
            }
            catch (Exception ex) {
            }
   

        }

        private bool ValidateSlideLocationData(string state)
        {
            int n;

            if (String.IsNullOrEmpty(txt_cabinet_number.Text) || String.IsNullOrEmpty(txt_drawer_number.Text) || String.IsNullOrEmpty(txt_box_number.Text))
            {

                MessageBox.Show("Location of Slide data is empty or not valid. Please , correct", "Validation ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            if (int.TryParse(txt_cabinet_number.Text, out n) == false)
            {
                MessageBox.Show("The cabinet number scan should only be digits", "Error");
                return false;
            }

            if (int.TryParse(txt_box_number.Text, out n) == false)
            {
                MessageBox.Show("The box number should only be digits", "Error");
                return false;
            }

            if (int.TryParse(txt_drawer_number.Text, out n) == false)
            {
                MessageBox.Show("The drawer number should only be digits", "Error");
                return false;

            }

            //convert to int
            int cabinet = Convert.ToInt32(txt_cabinet_number.Text.ToString());
            int drawer = Convert.ToInt32(txt_drawer_number.Text.ToString());
            int box = Convert.ToInt32(txt_box_number.Text.ToString());

            int isLocationOccupied = 0;
            dataFetchService = new DataFetchService();
            if (cabinet > 0 && drawer > 0 && box > 0 && state=="save")
                isLocationOccupied = dataFetchService.CheckIfLocationOccuiped(cabinet, drawer, box);
            if (cabinet > 0 && drawer > 0 && box > 0 && state == "update")
                isLocationOccupied = dataFetchService.CheckDuplicateLocationUpdate(cabinet, drawer, box,Slides_Id_Update);

            if (isLocationOccupied == 1)
            {

                MessageBox.Show("Slide exisit at [Cabinet = " + cabinet + " , Drawer = " + drawer + " , Box = " + box + "]. Please check for unoccupied slide location.", "Duplicate Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_clear_selection_Click(null, null);
                clear();
                enable_disable_inputs(false);
                return false;
            }

            return true;
        }

        private void reload_data()
        {

            this.recent_slide_datasetTableAdapter.Fill(this.sbmsDataSet.recent_slide_dataset);
            this.slidesTableAdapter.Fill(this.sbmsDataSet.slides);

        }

        private void btn_find_all_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search_all.Text.ToString() != "")
                {
                    int donor = Convert.ToInt32(txt_search_all.Text.ToString());
                    SearchAndFilterService searchAndFilterService = new SearchAndFilterService();
                    DataTable dt = searchAndFilterService.SearchSlideByDonor(donor);


                    if (dt == null)
                    {

                        MessageBox.Show("Slid/s with the donor code" + donor + " was not found! ");
                    }
                    else
                    {
                        dgr_allslides.DataSource = null;
                        dgr_allslides.Refresh();
                        dgr_allslides.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("Donor number is empty or invalid,renter");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Donorr number is empty or invalid,renter");
                logger.Error(ex, "Slide Form");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgr_recentslides.DataSource = this.recentslidedatasetBindingSource;

            reload_data();
        }

        private void selected_row_all_slides(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndexGird;
            rowIndexGird = e.RowIndex;
            try
            {
                if (dgr_allslides.Rows.Count > 0)
                {
                    MessageBox.Show("you selected row:" + (rowIndexGird + 1).ToString());

                    txt_bar_code.Text = dgr_allslides.Rows[e.RowIndex].Cells["barcodeallslidesGridViewTextBoxColumn"].Value + string.Empty;
                    txt_slide_sequence.Text = dgr_allslides.Rows[e.RowIndex].Cells["sequenceallslidesGridViewTextBoxColumn"].Value + string.Empty;
                    txt_country_code.Text = dgr_allslides.Rows[e.RowIndex].Cells["ccallslidesGridViewTextBoxColumn"].Value + string.Empty;
                    txt_donor_code.Text = dgr_allslides.Rows[e.RowIndex].Cells["donorallslidesGridViewTextBoxColumn"].Value.ToString();
                    cmb_specice_specifics.SelectedIndex = Convert.ToInt32(dgr_allslides.Rows[e.RowIndex].Cells["ssallslidesGridViewColumn"].Value);
                    cmb_specice_category.SelectedIndex = Convert.ToInt32(dgr_allslides.Rows[e.RowIndex].Cells["scallsldesGridViewColumn"].Value);
                    cmb_specice_stage.SelectedIndex = Convert.ToInt32(dgr_allslides.Rows[e.RowIndex].Cells["stallsldesGridViewColumn"].Value);
                    txt_lower_density.Text = dgr_allslides.Rows[e.RowIndex].Cells["ldallsldesGridViewColumn"].Value + string.Empty;
                    txt_average_density.Text = dgr_allslides.Rows[e.RowIndex].Cells["adallsldesGridViewColumn"].Value + string.Empty;
                    txt_upper_density.Text = dgr_allslides.Rows[e.RowIndex].Cells["udallsldesGridViewColumn"].Value.ToString();
                    cmb_density_category.SelectedIndex = Convert.ToInt32(dgr_allslides.Rows[e.RowIndex].Cells["dcallsldesGridViewColumn"].Value);
                    cmb_owners.SelectedIndex = Convert.ToInt32(dgr_allslides.Rows[e.RowIndex].Cells["ownerallsldesGridViewColumn"].Value);
                    txt_acquired_date.Text = dgr_allslides.Rows[e.RowIndex].Cells["adateallsldesGridViewColumn"].Value.ToString();
                    cmb_validation.SelectedIndex = Convert.ToInt32(dgr_allslides.Rows[e.RowIndex].Cells["vdateallsldesGridViewColumn"].Value);
                    txt_comment.Text = dgr_allslides.Rows[e.RowIndex].Cells["commentallsldesGridViewColumn"].Value.ToString();

                    if (Convert.ToBoolean(dgr_allslides.Rows[e.RowIndex].Cells["isDamagedallsldesGridViewColumn"].Value))
                        rdoDamagedYes.Checked = true;
                    else
                        rdoDamagedNo.Checked = true;

                    if (Convert.ToBoolean(dgr_allslides.Rows[e.RowIndex].Cells["isReservedallsldesGridViewColumn"].Value))
                        rdoResevedYes.Checked = true;
                    else
                        rdoResevedNo.Checked = true;
                    txt_cabinet_number.Text = dgr_allslides.Rows[e.RowIndex].Cells["cabinetallsldesGridViewColumn"].Value.ToString();
                    txt_drawer_number.Text = dgr_allslides.Rows[e.RowIndex].Cells["drawerallsldesGridViewColumn"].Value.ToString();
                    txt_box_number.Text = dgr_allslides.Rows[e.RowIndex].Cells["boxallsldesGridViewColumn"].Value.ToString();

                    enable_disable_inputs(true); //enable for select

                    btn_edit_update.Enabled = true;
                    lbl_editing_status.Visible = true;
                    btn_save.Enabled = false;
                    Slides_Id_Update = Convert.ToInt32(dgr_allslides.Rows[e.RowIndex].Cells["idallsldesGridViewColumn"].Value.ToString());
                }
                else
                {
                    enable_disable_inputs(false); //disabble for select
                    MessageBox.Show("NO Data to Select");
                }
            }
            catch (Exception ex) { 
                //TODO
            }

        }

        private void rdoDamagedYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDamagedYes.Checked)
            {
                location_panel.Enabled = false;
                history_flag = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportViewRecentSlides s = new ReportViewRecentSlides();
            s.MdiParent = this.ParentForm;
            s.Show();
        }

        public DataGridView getDataGridView()
        {
            return this.dgr_recentslides;
        }

        public DataGridView getLocationDataGridView()
        {
            return this.dgr_locations;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllSlidesReportViewePort allSlidesReportViewPort = new AllSlidesReportViewePort();
            allSlidesReportViewPort.MdiParent = this.ParentForm;
            allSlidesReportViewPort.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search_slide_recent.Text.ToString() != "")
                {
                    int number = Convert.ToInt32(txt_search_slide_recent.Text.ToString());
                    SearchAndFilterService searchAndFilterService = new SearchAndFilterService();
                    DataTable dt = searchAndFilterService.SearchSlideByNumber(number);


                    if (dt == null)
                    {

                        MessageBox.Show("Slide with that number" + number + " was not found! ");
                    }
                    else
                    {
                        dgr_recentslides.DataSource = null;
                        dgr_recentslides.Refresh();
                        dgr_recentslides.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("Slide number is empty or invalid,renter");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Slide number is empty or invalid,renter");
            }
}

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_print_locations_Click(object sender, EventArgs e)
        {
            LocationEquippedReportViewPort locationEquippedReportViewPort = new LocationEquippedReportViewPort();
            locationEquippedReportViewPort.MdiParent = this.ParentForm;
            locationEquippedReportViewPort.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dgr_allslides.DataSource = this.slidesBindingSource;
        }

        private void btn_location_search_Click(object sender, EventArgs e)
        {
            
            try
            {
                int cabinet = Decimal.ToInt32(numeric_cabinet.Value);
                int drawer = Decimal.ToInt32(numeric_drawer.Value);
                int box = Decimal.ToInt32(numeric_box.Value);

                if (cabinet!=0 && drawer!=0 && box!=0)
                {
                    int number = Convert.ToInt32(txt_search_slide_recent.Text.ToString());
                    SearchAndFilterService searchAndFilterService = new SearchAndFilterService();
                    DataTable dt = searchAndFilterService.SearchLocationOccupied(cabinet,drawer,box);
                    if (dt.Rows.Count>0)
                    {

                        MessageBox.Show("Location at Cabinet:"+cabinet+" Drawer: " +drawer+"Box:"+ box +"was not found! ");
                    }
                    else
                    {
                        dgr_locations.DataSource = null;
                        dgr_locations.Refresh();
                        dgr_locations.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("Corerct some invalid value entered");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Slide number is empty or invalid,renter");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.dgr_locations.DataSource = this.slidesBindingSource;
        }
    }
}
