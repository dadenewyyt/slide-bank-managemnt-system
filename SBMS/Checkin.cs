using MSBMS.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MSBMS
{
    public partial class Checkin : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        int current_lending_id = -1;
        int slide_id_checkin = -1;
        public int CurrentLending_Id_Checkin { get => current_lending_id; set => current_lending_id = value; }
        public int Slide_Id_Checkin { get => slide_id_checkin; set => slide_id_checkin = value; }
        public Checkin()
        {
            InitializeComponent();
        }

        private void Checkin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet1.current_lending_history' table. You can move, or remove it, as needed.
            this.currentLendingHisotryTableAdapter.Fill(this.sbmsDataSet1.current_lending_history);
            // TODO: This line of code loads data into the 'sbmsDataSet.species_specifics' table. You can move, or remove it, as needed.
            this.species_specificsTableAdapter.Fill(this.sbmsDataSet.species_specifics);
            // TODO: This line of code loads data into the 'desnityCat_bindingDataSource.density_category' table. You can move, or remove it, as needed.
            this.density_categoryTableAdapter.Fill(this.desnityCat_bindingDataSource.density_category);
            // TODO: This line of code loads data into the 'sbmsDataSet.species_category' table. You can move, or remove it, as needed.
            this.species_categoryTableAdapter.Fill(this.sbmsDataSet.species_category);
            cmb_returned_status.SelectedIndex = 0;
            grd_checkin_borrowed.AllowUserToAddRows = false;

        }

        private void find_borrowed_slide(object sender, KeyPressEventArgs e)
        {

            try 
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
                            txt_slide_scan_in.Text = txt_barcode.Text;
                            txt_barcode.Text = row["bar_code"].ToString();
                            txt_contry_code.Text = row["country_code"].ToString();
                            txt_donor_code.Text = row["donor_code"].ToString();
                            txt_slide_number.Text = row["sequence"].ToString();
                            txt_b_full_name.Text = row["fname"].ToString() + " " + row["lname"].ToString();
                            txt_org_borrower.Text = row["organisation"].ToString();
                            txt_due_Date.Text = row["due_date"].ToString();
                            txt_checked_out_date.Text = row["checked_out_date"].ToString();
                            txt_reason.Text = row["reason"].ToString();
                            txt_bby.Text = row["borrowed_by"].ToString();
                            txt_b_create_date.Text = row["b_created_date"].ToString();
                            Slide_Id_Checkin = Convert.ToInt32(row["slide_id"]);
                            CurrentLending_Id_Checkin = Convert.ToInt32(row["id"].ToString());
                        }

                    }
                    else
                    {
                        //txt_donor_code.BackColor = Color.Red;
                        MessageBox.Show("System can not find borrowed slide with the bardcode", "INFORMATION", MessageBoxButtons.OK);
                        logger.Info("System can not find borrowed slide with the bardcode");
                        Slide_Id_Checkin = -1;
                        CurrentLending_Id_Checkin = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception on Checkin Form");

            }
        }

        private void grd_checkin_borrowed_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                int rowIndexGird;
                rowIndexGird = e.RowIndex;

                if (grd_checkin_borrowed.Rows.Count > 0)
                {
                    MessageBox.Show("selected row:" + (rowIndexGird + 1).ToString());
                    txt_slide_scan_in.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["barcode"].Value + string.Empty;
                    txt_barcode.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["barcode"].Value + string.Empty;
                    txt_slide_number.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["sequence"].Value + string.Empty;
                    txt_contry_code.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["countrycode"].Value + string.Empty;
                    txt_donor_code.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["donorcode"].Value.ToString() + string.Empty;
                    txt_org_borrower.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["organisation"].Value.ToString();
                    txt_b_full_name.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["fname"].Value.ToString() + " " + grd_checkin_borrowed.Rows[e.RowIndex].Cells["lname"].Value.ToString();
                    txt_checked_out_date.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["checked_out_date"].Value + string.Empty;
                    txt_due_Date.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["duedate"].Value + string.Empty;
                    txt_reason.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["reason"].Value + string.Empty;
                    txt_bby.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["borrowed_by"].Value + string.Empty;
                    txt_b_create_date.Text = grd_checkin_borrowed.Rows[e.RowIndex].Cells["b_created_date"].Value + string.Empty;
                    Slide_Id_Checkin = Convert.ToInt32(grd_checkin_borrowed.Rows[e.RowIndex].Cells["slideId"].Value.ToString());
                    CurrentLending_Id_Checkin = Convert.ToInt32(grd_checkin_borrowed.Rows[e.RowIndex].Cells["currentLendingId"].Value.ToString());
                }
                else
                {
                    MessageBox.Show("NO Data to Select");
                }

        }

        public bool validateInputs() {

            if (cmb_returned_status.SelectedIndex == 0 ) {
                MessageBox.Show("Please , select valid value of Returned Status");
                return false;
            }

            if (String.IsNullOrEmpty(txt_barcode.Text))
            {
                MessageBox.Show("Please , select valid value of Returned Status");
                return false;
            }

            if (String.IsNullOrEmpty(txt_comment.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure to contine with comment being empty ? Press No to enter value or Yes to coninue checkin","Checkin",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (result.CompareTo(DialogResult.Yes)==0)
                     return true;
                else
                    return false;
            }
            return true;
        }

        private void btn_Checkin_Click(object sender, EventArgs e)
        {
            bool result = false;
            validateInputs();
            String caseValue = cmb_returned_status.SelectedItem.ToString();
            switch (caseValue) {
                case "OKAY": //OKAY
                     Console.WriteLine("caseValue");
                    result = CheckinSlideAsOkay(caseValue);
                    break;
                case "Damaged": //Damaged
                    result = CheckinSlidesMissingOrDamaged(caseValue);
                    break;
                case "Missing": //Missing
                    result = CheckinSlidesMissingOrDamaged(caseValue);
                    break;
                default:
                    break;            
            }

            if (result==true && caseValue=="Damaged") {

                MessageBox.Show("The selected slide has been checked-in succesfully as <Damaged>. \n Please , you can only use this slide until you replace it or change it as non damaged. See Replace slide Form for more.");
            }

            if (result == true && caseValue == "Missing") {

                MessageBox.Show("The selected slide has been checked-in succesfully as <Missing>. \n Please , you can only use this slide until you replace it or change it as non damaged. See Replace slide Form for more.");
            }

            if (result == true && caseValue == "Okay") {

                MessageBox.Show("The selected slide has been checked-in succesfully as <Okay>. \n Now you can search,select and borrow again this slide. Thankyou!");
            }

            if (result == false)
            {

                MessageBox.Show("The selected slide has not been checked-in. \n Please, reload the form or try again later. Thankyou!");
            }
        }

        public bool CheckinSlideAsOkay(String status) {
            bool result = true;

            MessageBox.Show(Slide_Id_Checkin.ToString());
            MessageBox.Show(CurrentLending_Id_Checkin.ToString());
           // return false;
            try
            {
                CheckinCheckoutService checkinCheckoutService = new CheckinCheckoutService();
                result = checkinCheckoutService.CheckinSlideAsOkay(status, Slide_Id_Checkin, CurrentLending_Id_Checkin);
                if (result == false)
                {
                    MessageBox.Show("Checkin was not succefull due some error, please try again");
                    
                    result = false;
                    txt_slide_scan_in_Click(null, null);
                    return result;
                }
            }
            
            catch (Exception ex)
            {
                logger.Error(ex, "Exception on Checkin Form");
                MessageBox.Show(ex.Message);
            }
            if (result) {
                
                MessageBox.Show("Successs: Checkin completed");
                logger.Info("Successs: Checkin completed");
                btnreload_data_Click(null,null); //refersh
                txt_slide_scan_in_Click(null, null);

            }

            return result;
        
        }

        public bool CheckinSlidesMissingOrDamaged(String status)
        {
            CheckinCheckoutService checkinCheckoutService = new CheckinCheckoutService();

            bool result = checkinCheckoutService.CheckinSlidesMissingOrDamaged(status, Slide_Id_Checkin, CurrentLending_Id_Checkin);
            if (result == false) {
                MessageBox.Show("Damaged: Checkin was not succefull due some error, please try again");
                return false;
            }
                return true;
        }

        private void txt_slide_scan_in_Click(object sender, EventArgs e)
        {
            
                txt_slide_scan_in.Text = "";
                txt_donor_code.Text = "";
                txt_slide_number.Text = "";
                txt_barcode.Text = "";
                txt_contry_code.Text = "";

                txt_barcode.Text = string.Empty;
                txt_slide_number.Text =string.Empty;
                txt_contry_code.Text =string.Empty;
                txt_donor_code.Text = string.Empty;
                txt_org_borrower.Text = "";
                txt_b_full_name.Text = "";
                txt_checked_out_date.Text = "";
                txt_due_Date.Text =  string.Empty;
                txt_reason.Text =string.Empty;
                txt_bby.Text = "";
                txt_b_create_date.Text = "";
                cmb_returned_status.SelectedIndex = 0;
                CurrentLending_Id_Checkin = -1;
        }

        private void btnreload_data_Click(object sender, EventArgs e)
        {
   
            grd_checkin_borrowed.DataSource = null;
            grd_checkin_borrowed.Refresh();
            this.currentLendingHisotryTableAdapter.Fill(this.sbmsDataSet1.current_lending_history);
            grd_checkin_borrowed.DataSource = this.sbmsDataSet1.current_lending_history;
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_slide_scan_in_Click(null,null);
            btnreload_data_Click(null, null);
        }
    }
}
