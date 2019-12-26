﻿using SBMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SBMS
{
    public partial class Donors : Form
    {
        
        private int id_update = -1;

        public int Id_update { get => id_update; set => id_update = value; }

        public void clear() {
            txt_barcode.Text = string.Empty;
            txt_country_code.Text = string.Empty;
            txt_donor_code.Text = string.Empty;
            cmb_specice_specifics.SelectedIndex = 0;
            cmb_specice_category.SelectedIndex = 0;
            cmb_specice_stage.SelectedIndex =0;
            txt_lower_density.Text = string.Empty;
            txt_average_density.Text = string.Empty;
            txt_upper_density.Text = string.Empty;
            cmb_density_category.SelectedIndex = 0;
            cmb_owners.SelectedIndex = 0;
            txt_acquired_date.Text = "";
            cmb_validation.SelectedIndex =0;
            txt_comment.Text = "";
        }

        public Donors()
        {
            InitializeComponent();
            dgr_donors.ClearSelection();

            // dgr_donors.DataSource = bindingSourceDonorsDataGrid;

            // GetData("select * from donors");
            /* dgr_donors.Columns.Add("id", "id");
             dgr_donors.Columns.Add("bar_code", "BCode");
             dgr_donors.Columns.Add("country_code", "CCode");
             dgr_donors.Columns.Add("donor_code", "DCode");
             dgr_donors.Columns.Add("Specifics", "Specifics");
             dgr_donors.Columns.Add("S", "Stage");
             dgr_donors.Columns.Add("DCatgeorys", "Density_Catgeorys");
             dgr_donors.Columns.Add("LDensity", "Lower");
             dgr_donors.Columns.Add("Average", "Average");
             dgr_donors.Columns.Add("Upper", "Upper");
             dgr_donors.Columns.Add("BarCode", "BarCode");
             dgr_donors.Columns.Add("Owner", "Owner");
             dgr_donors.Columns.Add("acdate", "AcquiredDate");
             dgr_donors.Columns.Add("validated", "Validated?");
             dgr_donors.Columns.Add("Comment", "Comment");
             dgr_donors.Columns.Add("CreatedBy", "Created By");
             dgr_donors.Columns.Add("UpdatedBy", "Updated By");
             dgr_donors.Columns.Add("CD", "Created_Date");
             dgr_donors.Columns.Add("UDate", "Last Updated Date");

             dgr_donors.Columns.Add("WHO", "IsWHO");
             dgr_donors.Columns.Add("isActive", "is Active");


             GetData("select * from donors");*/
        }

        private void GetData(string selectCommand)
    {
           // bindingSourceDonorsDataGrid = new BindingSource();
            dataAdapterDonorsDataGridview = new SqlDataAdapter();
        try
        {
            // Specify a connection string.  
            // Replace <SQL Server> with the SQL Server for your Northwind sample database.
            // Replace "Integrated Security=True" with user login information if necessary.
            

                // Create a new data adapter based on the specified query.
                dataAdapterDonorsDataGridview = new SqlDataAdapter(selectCommand, DatabaseServices.connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. 
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapterDonorsDataGridview);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapterDonorsDataGridview.Fill(table);
                donorsBindingSource.DataSource = table;
               // dgr_donors.AutoGenerateColumns = false;

                
                // Resize the DataGridView columns to fit the newly loaded content.
               // dgr_donors.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
        catch (SqlException)
        {
            MessageBox.Show("To run this example, replace the value of the " +
                "connectionString variable with a connection string that is " +
                "valid for your system.");
        }
    }

        private void Donors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'speciceDataSet.species_category' table. You can move, or remove it, as needed.
            this.species_categoryTableAdapter.Fill(this.speciceDataSet.species_category);
            // TODO: This line of code loads data into the 'donorsDataSet.donors' table. You can move, or remove it, as needed.
            this.donorsTableAdapter1.Fill(this.donorsDataSet.donors);
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
            this.donorsTableAdapter.Fill(this.sbmsDataSet.donors);

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


           
        private void btn_reload_Click(object sender, EventArgs e)
        {
           
            dgr_donors.DataSource = donorsBindingSource.DataSource;
            GetData("select * from donors;");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

           
           
                // MessageBox.Show("Saving");
                DateTime dt = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(DatabaseServices.connectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        string insertDonorQuery = "INSERT into donors" +
                            "(bar_code,country_code,donor_code,species_specific_id,species_stage_id,species_catgeroy_id,density_category_id,lower_density," +
                             "average_density,upper_density,owner_id,acquired_date,validation_id,comment,created_by,updated_by,created_date,updated_date) " +
                             "VALUES (@bar_code,@country_code,@donor_code,@species_specific_id,@species_stage_id,@species_catgeroy_id,@density_category_id,@lower_density," +
                             "@average_density,@upper_density,@owner_id,@acquired_date," +
                             "@validation_id,@comment,@created_by,@updated_by,@created_date,@updated_date)";
                        command.CommandType = CommandType.Text;
                        command.CommandText = insertDonorQuery;
                        command.Parameters.AddWithValue("@bar_code", txt_barcode.Text.ToString());
                        command.Parameters.AddWithValue("@country_code", txt_country_code.Text.ToString());
                        command.Parameters.AddWithValue("@donor_code", txt_donor_code.Text.ToString());
                        command.Parameters.AddWithValue("@species_specific_id", cmb_specice_specifics.SelectedIndex.ToString());
                        command.Parameters.AddWithValue("@species_catgeroy_id", cmb_specice_category.SelectedIndex.ToString());
                        command.Parameters.AddWithValue("@species_stage_id", cmb_specice_stage.SelectedIndex.ToString());
                        command.Parameters.AddWithValue("@density_category_id", cmb_density_category.SelectedIndex.ToString());
                        command.Parameters.AddWithValue("@lower_density", txt_lower_density.Text.ToString());
                        command.Parameters.AddWithValue("@average_density", txt_average_density.Text.ToString());
                        command.Parameters.AddWithValue("@upper_density", txt_upper_density.Text.ToString());
                        command.Parameters.AddWithValue("@owner_id", cmb_owners.SelectedIndex.ToString());
                        command.Parameters.AddWithValue("@acquired_date", txt_acquired_date.Value);
                        command.Parameters.AddWithValue("@validation_id", cmb_validation.SelectedIndex.ToString());
                        command.Parameters.AddWithValue("@comment", txt_comment.Text.ToString());
                        command.Parameters.AddWithValue("@created_by", "Daniel Adenew, Sofware Engineer");
                        command.Parameters.AddWithValue("@updated_by", "");
                        command.Parameters.AddWithValue("@created_date", dt.ToString("yyyy/MM/dd"));
                        command.Parameters.AddWithValue("@updated_date", "");

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
                            MessageBox.Show(ex.Message.ToString(), "ERROR SAVING");
                        }
                        finally
                        {
                            MessageBox.Show("Donor Information Saved Successfully", "Success");
                            clear();
                            this.btn_reload_Click(null,null);
                            this.btn_reload_Click(null,null);
                            connection.Close();
                        }

                    }
              
            }
        }

        private void dgr_donors_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int rowIndex;
            rowIndex = e.RowIndex; 
          
            if (dgr_donors.SelectedRows.Count > 0)
            {
                MessageBox.Show("you selected row:" + (rowIndex+1).ToString());
               
                txt_barcode.Text = dgr_donors.Rows[e.RowIndex].Cells["barcodeDataGridViewTextBoxColumn"].Value + string.Empty;
                txt_country_code.Text = dgr_donors.Rows[e.RowIndex].Cells["countrycodeDataGridViewTextBoxColumn"].Value + string.Empty;
                txt_donor_code.Text = dgr_donors.Rows[e.RowIndex].Cells["donorcodeDataGridViewTextBoxColumn"].Value.ToString();
                cmb_specice_specifics.SelectedIndex = Convert.ToInt32(dgr_donors.Rows[e.RowIndex].Cells["speciesspecificidDataGridViewTextBoxColumn"].Value);
                cmb_specice_category.SelectedIndex = Convert.ToInt32(dgr_donors.Rows[e.RowIndex].Cells["speciesstageidDataGridViewTextBoxColumn"].Value);
                cmb_specice_stage.SelectedIndex = Convert.ToInt32(dgr_donors.Rows[e.RowIndex].Cells["SCategory"].Value);
                txt_lower_density.Text = dgr_donors.Rows[e.RowIndex].Cells["lowerdensityDataGridViewTextBoxColumn"].Value + string.Empty;
                txt_average_density.Text = dgr_donors.Rows[e.RowIndex].Cells["averagedensityDataGridViewTextBoxColumn"].Value + string.Empty;
                txt_upper_density.Text = dgr_donors.Rows[e.RowIndex].Cells["upperdensityDataGridViewTextBoxColumn"].Value.ToString();
                cmb_density_category.SelectedIndex = Convert.ToInt32(dgr_donors.Rows[e.RowIndex].Cells["densitycategoryidDataGridViewTextBoxColumn"].Value);
                cmb_owners.SelectedIndex = Convert.ToInt32(dgr_donors.Rows[e.RowIndex].Cells["owneridDataGridViewTextBoxColumn"].Value);
                txt_acquired_date.Text = dgr_donors.Rows[e.RowIndex].Cells["acquireddateDataGridViewTextBoxColumn"].Value.ToString();
                cmb_validation.SelectedIndex = Convert.ToInt32(dgr_donors.Rows[e.RowIndex].Cells["validationidDataGridViewTextBoxColumn"].Value);
                txt_comment.Text = dgr_donors.Rows[e.RowIndex].Cells["commentDataGridViewTextBoxColumn"].Value.ToString();

                btn_deactivate.Enabled = true;
                btn_save_edit.Enabled = true;
                lbl_editing_status.Visible = true;
                btn_save.Enabled = false;
                Id_update = Convert.ToInt32(dgr_donors.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString());
            }
            else
            {
                MessageBox.Show("NOData to Select");
            }

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string searchValue = txt_search_box.Text;
            bool found = false;
           dgr_donors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgr_donors.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        found = true;
                        MessageBox.Show("Donor is found. See hightligthed","Find Result");
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            if (found==false) {
                MessageBox.Show("Donor is not found. With a Donor Code : " + searchValue.ToString(), "Find Result");
            }
        }

        private void btn_save_edit_Click(object sender, EventArgs e)
        {

            if (Id_update != -1)
            {
                // MessageBox.Show("Saving");
                DateTime dt = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(DatabaseServices.connectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        string updateDonorQuery = "UPDATE donors " +
                            "SET bar_code=@bar_code,country_code=@country_code,donor_code=@donor_code,species_specific_id=@species_specific_id," +
                            "species_stage_id=@species_stage_id,density_category_id=@density_category_id,lower_density=@lower_density,average_density=@average_density,upper_density=@upper_density," +
                            "owner_id=@owner_id,acquired_date=@acquired_date,validation_id=@validation_id,comment=@comment,updated_by=@updated_by,updated_date=@updated_date WHERE id=@id";

                        command.CommandType = CommandType.Text;
                        command.CommandText = updateDonorQuery;
                        command.Parameters.AddWithValue("@id", Id_update);
                        command.Parameters.AddWithValue("@bar_code", txt_barcode.Text.ToString());
                        command.Parameters.AddWithValue("@country_code", txt_country_code.Text.ToString());
                        command.Parameters.AddWithValue("@donor_code", txt_donor_code.Text.ToString());
                        command.Parameters.AddWithValue("@species_specific_id", cmb_specice_specifics.SelectedIndex.ToString());
                        command.Parameters.AddWithValue("@species_stage_id", cmb_specice_stage.SelectedIndex.ToString());
                        command.Parameters.AddWithValue("@density_category_id", cmb_density_category.SelectedIndex.ToString());
                        command.Parameters.AddWithValue("@lower_density", txt_lower_density.Text.ToString());
                        command.Parameters.AddWithValue("@average_density", txt_average_density.Text.ToString());
                        command.Parameters.AddWithValue("@upper_density", txt_upper_density.Text.ToString());
                        command.Parameters.AddWithValue("@owner_id", cmb_owners.SelectedIndex.ToString());
                        command.Parameters.AddWithValue("@acquired_date", txt_acquired_date.Value);
                        command.Parameters.AddWithValue("@validation_id", cmb_validation.SelectedIndex.ToString());
                        command.Parameters.AddWithValue("@comment", txt_comment.Text.ToString());
                        command.Parameters.AddWithValue("@updated_by", "Test User");
                        command.Parameters.AddWithValue("@updated_date", dt.ToString("yyyy/MM/dd"));

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
                            MessageBox.Show(ex.Message, "ERROR: Updating Record");
                     
                        }
                        finally
                        {
                            MessageBox.Show("Donor's Information Updated Successfully", "Success");
                            clear();
                            this.btn_reload_Click(null,null);
                            this.btn_reload_Click(null, null);
                            lbl_editing_status.Visible = false;
                           // btn_deactivate.Enabled = false;
                            btn_save.Enabled = true;
                            btn_save_edit.Enabled = false;
                            connection.Close();
                        }

                    }
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }

