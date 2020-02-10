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
    public partial class Borrowers : Form
    {
        private int borrower_update_id = -1;

        public Borrowers()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            txt_fname.Text = string.Empty;
            txt_lname.Text = string.Empty;
            txt_jtitle.Text = string.Empty;
            txt_org.Text = string.Empty;
            txt_oemail.Text = string.Empty;
            txt_pemail.Text = string.Empty;

            txt_mphone.Text = string.Empty;
            txt_ophone.Text = string.Empty;
            txt_fnum.Text = string.Empty;
            txt_country.Text = string.Empty;
            txt_city.Text = string.Empty;
            txt_pobox.Text = string.Empty;

            txt_hno.Text = string.Empty;
            txt_notes.Text = string.Empty;

        }
        private void reload_data()
        {

            this.borrowersTableAdapter.Fill(this.sbmsDataSet.borrowers);
        }

        private void dgr_borrower_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex;
            rowIndex = e.RowIndex;

            if (dgr_borrower.SelectedRows.Count > 0)
            {
                MessageBox.Show("selected row:" + (rowIndex + 1).ToString());

                txt_fname.Text = dgr_borrower.Rows[e.RowIndex].Cells["fnameDataGridViewTextBoxColumn"].Value.ToString();
                txt_lname.Text = dgr_borrower.Rows[e.RowIndex].Cells["lnameDataGridViewTextBoxColumn"].Value.ToString();
                txt_jtitle.Text = dgr_borrower.Rows[e.RowIndex].Cells["jobtitleDataGridViewTextBoxColumn"].Value.ToString();
                txt_org.Text = dgr_borrower.Rows[e.RowIndex].Cells["organisationDataGridViewTextBoxColumn"].Value.ToString();
                txt_oemail.Text = dgr_borrower.Rows[e.RowIndex].Cells["officalemailDataGridViewTextBoxColumn"].Value.ToString();
                txt_pemail.Text = dgr_borrower.Rows[e.RowIndex].Cells["personalemailDataGridViewTextBoxColumn"].Value.ToString();

                txt_mphone.Text = dgr_borrower.Rows[e.RowIndex].Cells["mobilephoneDataGridViewTextBoxColumn"].Value.ToString();
                txt_ophone.Text = dgr_borrower.Rows[e.RowIndex].Cells["officephoneDataGridViewTextBoxColumn"].Value.ToString();
                txt_fnum.Text = dgr_borrower.Rows[e.RowIndex].Cells["faxnumberDataGridViewTextBoxColumn"].Value.ToString();
                txt_country.Text = dgr_borrower.Rows[e.RowIndex].Cells["countryDataGridViewTextBoxColumn"].Value.ToString();
                txt_city.Text = dgr_borrower.Rows[e.RowIndex].Cells["cityDataGridViewTextBoxColumn"].Value.ToString();
                txt_pobox.Text = dgr_borrower.Rows[e.RowIndex].Cells["postcodeDataGridViewTextBoxColumn"].Value.ToString();

                txt_hno.Text = dgr_borrower.Rows[e.RowIndex].Cells["hnoDataGridViewTextBoxColumn"].Value.ToString();
                txt_notes.Text = dgr_borrower.Rows[e.RowIndex].Cells["fnameDataGridViewTextBoxColumn"].Value.ToString();

                //enable_disable_inputs(true); //enable for select

                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                //lbl_editing_status.Visible = true;
                btn_save.Enabled = false;
                borrower_update_id = Convert.ToInt32(dgr_borrower.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString());
            }
            else
            {
                //enable_disable_inputs(false); //disabble for select
                MessageBox.Show("NO Data to Select");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Services.DatabaseServices.connectionString))
            {

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    string insertDonorQuery = "INSERT into borrowers" +
                        "(fname,lname,job_title,organisation,offical_email,personal_email,mobile_phone,office_phone," +
                         "fax_number,country,city,hno,postcode,note,created_by) " +
                         "VALUES (@fname,@lname,@job_title,@organisation,@offical_email,@personal_email,@mobile_phone,@office_phone," +
                         "@fax_number,@country,@city,@hno,@postcode,@note,@created_by)";
                    command.CommandType = CommandType.Text;
                    command.CommandText = insertDonorQuery;
                    command.Parameters.AddWithValue("@fname", txt_fname.Text.Trim());
                    command.Parameters.AddWithValue("@lname", txt_lname.Text.Trim());
                    command.Parameters.AddWithValue("@job_title", txt_jtitle.Text.Trim());
                    command.Parameters.AddWithValue("@organisation", txt_org.Text.Trim());
                    command.Parameters.AddWithValue("@offical_email", txt_oemail.Text.Trim());
                    command.Parameters.AddWithValue("@personal_email", txt_pemail.Text.Trim());
                    command.Parameters.AddWithValue("@mobile_phone", txt_mphone.Text.Trim());
                    command.Parameters.AddWithValue("@office_phone", txt_ophone.Text.Trim());
                    command.Parameters.AddWithValue("@fax_number", txt_fnum.Text.Trim());
                    command.Parameters.AddWithValue("@country", txt_country.Text.Trim());
                    command.Parameters.AddWithValue("@hno", txt_hno.Text.Trim());
                    command.Parameters.AddWithValue("@note", txt_notes.Text.Trim());
                    command.Parameters.AddWithValue("@city", txt_city.Text.Trim());
                    command.Parameters.AddWithValue("@postcode", txt_pobox.Text.Trim());
                    command.Parameters.AddWithValue("@created_by", "Daniel");


                    try
                    {

                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        int recordsAffected = command.ExecuteNonQuery();

                        if (recordsAffected > 0)
                        {
                            MessageBox.Show("Borrower's Information Saved !", "Success");
                            reload_data();
                        }


                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        clear();
                        connection.Close();
                    }

                }
            }
        }

        private void Borrowers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet.borrowers' table. You can move, or remove it, as needed.
            this.borrowersTableAdapter.Fill(this.sbmsDataSet.borrowers);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (borrower_update_id != -1)
            {

                using (SqlConnection connection = new SqlConnection(Services.DatabaseServices.connectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        string updateDonorQuery = "UPDATE borrowers " +
                            "SET fname=@fname,lname=@lname,job_title=@job_title,organisation=@organisation," +
                                 "offical_email=@offical_email,personal_email=@personal_email,mobile_phone=@mobile_phone,office_phone=@office_phone," +
                                 "fax_number=@fax_number,country=@country,city=@city,hno=@hno,postcode=@postcode,note=@note,updated_by=@updated_by WHERE id=@id";

                        command.CommandType = CommandType.Text;
                        command.CommandText = updateDonorQuery;
                        command.Parameters.AddWithValue("@id", borrower_update_id);
                        command.Parameters.AddWithValue("@fname", txt_fname.Text.Trim());
                        command.Parameters.AddWithValue("@lname", txt_lname.Text.Trim());
                        command.Parameters.AddWithValue("@job_title", txt_jtitle.Text.Trim());
                        command.Parameters.AddWithValue("@organisation", txt_org.Text.Trim());
                        command.Parameters.AddWithValue("@offical_email", txt_oemail.Text.Trim());
                        command.Parameters.AddWithValue("@personal_email", txt_pemail.Text.Trim());
                        command.Parameters.AddWithValue("@mobile_phone", txt_mphone.Text.Trim());
                        command.Parameters.AddWithValue("@office_phone", txt_ophone.Text.Trim());
                        command.Parameters.AddWithValue("@fax_number", txt_fnum.Text.Trim());
                        command.Parameters.AddWithValue("@country", txt_country.Text.Trim());
                        command.Parameters.AddWithValue("@hno", txt_hno.Text.Trim());
                        command.Parameters.AddWithValue("@note", txt_notes.Text.Trim());
                        command.Parameters.AddWithValue("@city", txt_city.Text.Trim());
                        command.Parameters.AddWithValue("@postcode", txt_pobox.Text.Trim());
                        command.Parameters.AddWithValue("@updated_by", "Daniel Updated");


                        try
                        {

                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }
                            int recordsAffected = command.ExecuteNonQuery();

                            if (recordsAffected > 0)
                            {
                                MessageBox.Show("Borrower Information is Updated !", "Success");
                                reload_data();

                            }

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "ERROR Updating Borrower ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        finally
                        {

                            connection.Close();
                            clear();
                        }

                    }
                }
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure ?", "Delete Borrower", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            if (borrower_update_id != -1)
            {

                using (SqlConnection connection = new SqlConnection(Services.DatabaseServices.connectionString))
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        string updateDonorQuery = "UPDATE borrowers " +
                            "SET isdeleted=@deletedStatus WHERE id=@id";

                        command.CommandType = CommandType.Text;
                        command.CommandText = updateDonorQuery;
                        command.Parameters.AddWithValue("@id", borrower_update_id);
                        command.Parameters.AddWithValue("@deletedStatus", true);



                        try
                        {

                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }
                            int recordsAffected = command.ExecuteNonQuery();
                            MessageBox.Show(recordsAffected.ToString());

                            if (recordsAffected > 0)
                            {
                                MessageBox.Show("Borrower Information is Deleted !", "Success");
                                reload_data();

                            }

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "ERROR Deleting Borrower ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        finally
                        {

                            connection.Close();
                            clear();
                        }

                    }
                }
            }

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            dgr_borrower.ClearSelection();

            string searchValue = txt_search.Text.ToString();

            if (String.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please, type the organisation name on the search box");
                return;
            }

            bool found = false;
            // string searchCompar="";
            dgr_borrower.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgr_borrower.Rows)
                {
                    // searchCompar = String.Concat(row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
                    if (null != row.Cells[4].Value)
                    {
                        if (row.Cells[4].Value.ToString().Contains(searchValue))
                        {
                            row.Selected = true;
                            found = true;
                            MessageBox.Show("Borrower is found by organisation. See hightligthed", "Find Result");
                            break;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

            if (found == false)
            {
                MessageBox.Show("Borrower is not found. With a organisation name : " + searchValue.ToString(), "Find Result");
            }
        }

        private void enter_pressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_find_Click(null, null);
            }
        }

        private void btn_clear_selection_Click(object sender, EventArgs e)
        {
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_save.Enabled = true;
            dgr_borrower.ClearSelection();
            borrower_update_id = -1;
            clear();
        }
    }
}
