using SBMS.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SBMS
{
    public partial class Checkin_Checkout : Form
    {
        int current_lending_id = -1;
        public int CurrentLending_Id_Checkin { get => current_lending_id; set => current_lending_id = value; }
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
            // TODO: This line of code loads data into the 'sbmsDataSet1.current_lending_history' table. You can move, or remove it, as needed.
            this.currentLendingHisotryTableAdapter.Fill(this.sbmsDataSet1.current_lending_history);
            // TODO: This line of code loads data into the 'sbmsDataSet.species_specifics' table. You can move, or remove it, as needed.
            this.species_specificsTableAdapter.Fill(this.sbmsDataSet.species_specifics);
            // TODO: This line of code loads data into the 'desnityCat_bindingDataSource.density_category' table. You can move, or remove it, as needed.
            this.density_categoryTableAdapter.Fill(this.desnityCat_bindingDataSource.density_category);
            // TODO: This line of code loads data into the 'sbmsDataSet.species_category' table. You can move, or remove it, as needed.
            this.species_categoryTableAdapter.Fill(this.sbmsDataSet.species_category);

        }

        private void find_borrowed_slide(object sender, KeyPressEventArgs e)
        {

            Dictionary<string, string> separated = new Dictionary<string, string>();

            if (e.KeyChar == (char)13)
            {

                if (txt_slide_scan_in.TextLength != 8)
                {
                    MessageBox.Show("Slide Scan in must be 8 digits.", "INFORMATION", MessageBoxButtons.OK);
                    return;
                }

                if (int.TryParse(txt_slide_scan_in.Text.ToString(), out int n) == false) //numbers only
                {
                    MessageBox.Show("Slide Scan must all be numeric value.", "INFORMATION", MessageBoxButtons.OK);
                    return;
                }

                HelperServices helperService = new HelperServices();
                separated = helperService.SeperateBarCodeIntoCodes(txt_slide_scan_in.Text.ToString());

               if (separated == null) return;

                txt_contry_code.Text = separated["CC"];
                txt_donor_code.Text = separated["DC"];
                txt_slide_number.Text = separated["SS"];
                txt_barcode.Text = txt_slide_scan_in.Text;

            }


            //fetch if there is any thing found with that donor id..it should be a must found since we suppose donor is already exisiting

            if (separated.Count() > 0)
            {

                DataFetchService dataFetchService = new DataFetchService();
                DataTable BorrowedSlideDT = dataFetchService.FecthBorrowedSlideByBarCode(txt_barcode.Text.ToString());

                if (BorrowedSlideDT.Rows.Count > 0)
                {
                    //fetch data
                    foreach (DataRow row in BorrowedSlideDT.Rows)
                    {
                        txt_barcode.Text = row["bar_code"].ToString();
                        txt_contry_code.Text = row["country_code"].ToString();
                        txt_donor_code.Text = row["donor_code"].ToString();
                        txt_slide_number.Text = row["sequence"].ToString();
                        txt_b_full_name.Text = row["sequence"].ToString() + " " +row["sequence"].ToString();
                        txt_org_borrower.Text = row["organisation"].ToString();
                        txt_due_Date.Text = row["due_date"].ToString();
                        txt_checked_out_date.Text = row["checked_out_date"].ToString();
                        txt_reason.Text =row["reason"].ToString();
                        txt_bby.Text = row["borrowed_by"].ToString();
                        txt_b_create_date.Text = row["b_created_date"].ToString();
                    }
                   
                }
                else
                {
                    //txt_donor_code.BackColor = Color.Red;
                    MessageBox.Show("System can not find borrowed slide with the bardcode", "INFORMATION", MessageBoxButtons.OK);
                }
            }
        }

        private void grd_checkin_borrowed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndexGird;
            rowIndexGird = e.RowIndex;

            if (grd_checkin_borrowed.Rows.Count > 0)
            {
                MessageBox.Show("selected row:" + (rowIndexGird + 1).ToString());

                txt_barcode.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["barcode"].Value + string.Empty;
                txt_slide_number.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["sequence"].Value + string.Empty;
                txt_contry_code.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["countrycode"].Value + string.Empty;
                txt_donor_code.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["donorcode"].Value.ToString()+ string.Empty;
                txt_org_borrower.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["organisation"].Value.ToString();
                txt_b_full_name.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["fname"].ToString() + grd_checkin_borrowed.Rows[e.RowIndex].Cells["lname"].ToString();
                txt_checked_out_date.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["checked_out_date"].Value + string.Empty;
                txt_due_Date.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["duedate"].Value + string.Empty;
                txt_reason.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["reason"].Value + string.Empty;
                txt_bby.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["borrowed_by"].Value + string.Empty;
                txt_b_create_date.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["b_created_date"].Value + string.Empty;

                CurrentLending_Id_Checkin = Convert.ToInt32(grd_checkin_borrowed.Rows[e.RowIndex].Cells["currentLendingId"].Value.ToString());
            }
            else
            {
                MessageBox.Show("NO Data to Select");
            }
        }
    }
}
