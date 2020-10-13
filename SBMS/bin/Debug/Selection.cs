using MSBMS.Reports.CrystalReports;
using MSBMS.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MSBMS
{
    public partial class Selection : Form
    {

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        List<int> ids = new List<int>();
        DataGridView cloneOfSearchResults = new DataGridView();
        bool pv_on = true;
        bool pf_on = true;
        bool pvpf_on = true;

        bool po_on = true;
        bool pm_on = true;
        bool others_on = true;
        DataTable mergedSearchResult = new DataTable();
        //pf
        DataTable pf_ld_datatable = new DataTable();
        DataTable pf_md_datatable = new DataTable();
        DataTable pf_hd_datatable = new DataTable();
        //pv
        DataTable pv_ld_datatable = new DataTable();
        DataTable pv_md_datatable = new DataTable();
        DataTable pv_hd_datatable = new DataTable();
        //pfpv
        DataTable pfpv_hd_datatable = new DataTable();
        DataTable pfpv_ld_datatable = new DataTable();
        DataTable pfpv_md_datatable = new DataTable();
        //po
        DataTable po_ld_datatable = new DataTable();
        DataTable po_md_datatable = new DataTable();
        DataTable po_hd_datatable = new DataTable();
        //pm
        DataTable pm_ld_datatable = new DataTable();
        DataTable pm_md_datatable = new DataTable();
        DataTable pm_hd_datatable = new DataTable();
        //others
        DataTable others_ld_datatable = new DataTable();
        DataTable others_md_datatable = new DataTable();
        DataTable others_hd_datatable = new DataTable();

        //borrela
        DataTable bo_ld_datatable = new DataTable();
        DataTable bo_md_datatable = new DataTable();
        DataTable bo_hd_datatable = new DataTable();

        //negatives
        DataTable negatives_datatable = new DataTable();

        SearchAndFilterService searchAndFilterService;
        CheckinCheckoutService checkinCheckoutService;
        bool skip_days_validation = false;
        public Selection()
        {
            InitializeComponent();
            searchAndFilterService = new SearchAndFilterService(); //initliaise
            checkinCheckoutService = new CheckinCheckoutService();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Selection_Load(object sender, EventArgs e)
        {
            //logger.Trace(this.ToString());
            grd_search_results.AllowUserToAddRows = false;

            // TODO: This line of code loads data into the 'sbmsDataSet.slide_search' table. You can move, or remove it, as needed.
            this.slide_searchTableAdapter.Fill(this.sbmsDataSet.slide_search);
            // TODO: This line of code loads data into the 'sbmsDataSet.borrower_contact_list' table. You can move, or remove it, as needed.
            this.contact_listTableAdapter.Fill(this.sbmsDataSet.contact_list);

            Dictionary<int, string> borrowerDic = new Dictionary<int, string>();
            borrowerDic.Add(-1, "---Select Contact---");
            foreach (DataRow row in this.sbmsDataSet.contact_list.Rows)
            {
                if (Boolean.Parse(row["isExchange"].ToString())==false)
                    borrowerDic.Add(Convert.ToInt32(row["id"]), "Country[ " + row["country"] + " ] Organisation [ " + row["country"] + "] Person: [ " + row["fname"] + " " + row["lname"] + " ]");
            }

            cmb_borrowers.DataSource = new BindingSource(borrowerDic, null);

            cmb_borrowers.DisplayMember = "Value";
            cmb_borrowers.ValueMember = "Key";
            cmb_borrowers.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_borrowers.AutoCompleteSource = AutoCompleteSource.ListItems;
            txt_total_request.Text = "0";
            txt_found_in_bank.Text = grd_search_results.Rows.Count.ToString();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            //this.showValidationMessage();
            this.searchForPfCriteria();
            this.searchPvs();
            this.searchPfPvs();
            this.searchPms();
            this.searchPos();
            this.searchOthers();
            this.searchNegatives();
            this.searchBorrella();


            mergedSearchResult.Clear();
            if (pv_ld_datatable.Rows.Count > 0)
            {
                mergedSearchResult.Merge(pv_ld_datatable);
            }
            if (pf_ld_datatable.Rows.Count > 0)
            {
                mergedSearchResult.Merge(pf_ld_datatable);
            }
            if (pfpv_ld_datatable.Rows.Count > 0)
            {
                mergedSearchResult.Merge(pfpv_ld_datatable);
            }

            if (po_ld_datatable.Rows.Count > 0)
            {
                mergedSearchResult.Merge(po_ld_datatable);
            }
            if (pm_ld_datatable.Rows.Count > 0)
            {
                mergedSearchResult.Merge(pm_ld_datatable);
            }
            if (others_ld_datatable.Rows.Count > 0)
            {
                mergedSearchResult.Merge(others_ld_datatable);
            }
            if (bo_ld_datatable.Rows.Count > 0)
            {
                mergedSearchResult.Merge(bo_ld_datatable);
            }

            if (negatives_datatable.Rows.Count > 0)
            {
                mergedSearchResult.Merge(negatives_datatable);
            }

            grd_search_results.DataSource = null;
            // grd_search_results.Refresh();
            grd_search_results.DataSource = mergedSearchResult;

            resetDataSetsAftersearch();
            logger.Info("Search Result for " + UserAccountServices.Full_name + " count:" + mergedSearchResult.Rows.Count.ToString());
            // cloneOfSearchResults = grd_search_results;
            txt_found_in_bank.Text = grd_search_results.Rows.Count.ToString();
            Decimal total = addupNumericValues();
            txt_total_request.Text = total.ToString();
        }

        private Decimal addupNumericValues() {

            Decimal sum = 0;

            sum += pv_hd_q.Value;
            sum += pv_ld_q.Value;
            sum += pv_md_q.Value;

            sum += pf_hd_q.Value;
            sum += pf_ld_q.Value;
            sum += pf_md_q.Value;

            sum += pfpv_hd_q.Value;
            sum += pfpv_ld_q.Value;
            sum += pfpv_md_q.Value;

            sum += po_hd_q.Value;
            sum += po_ld_q.Value;
            sum += po_md_q.Value;

            sum += pm_hd_q.Value;
            sum += pm_ld_q.Value;
            sum += pm_md_q.Value;

            sum += negatives_q.Value;
            sum += others_all_q.Value;
            sum += borrela_all_q.Value;

            return sum;

        }
        private void resetDataSetsAftersearch() {
            pf_ld_datatable.Clear();
            pf_md_datatable.Clear();
            pf_hd_datatable.Clear();
            //pv
            pv_ld_datatable.Clear();
            pv_md_datatable.Clear();
            pv_hd_datatable.Clear();
            //pfpv
            pfpv_hd_datatable.Clear();
            pfpv_ld_datatable.Clear();
            pfpv_md_datatable.Clear();
            //po
            po_ld_datatable.Clear();
            po_md_datatable.Clear();
            po_hd_datatable.Clear();
            //pm
            pm_ld_datatable.Clear(); ;
            pm_md_datatable.Clear();
            pm_hd_datatable.Clear();
            //others
            others_ld_datatable.Clear();
            others_md_datatable.Clear();
            others_hd_datatable.Clear();

            //borrella
            bo_ld_datatable.Clear();
            bo_md_datatable.Clear();
            bo_hd_datatable.Clear();

            //negative
            negatives_datatable.Clear();

            //mereged
            // mergedSearchResult.Clear();
        }

        private void searchPfPvs() {

            if (pvpf_on == true && pfpv_ld_q.Value > 0)
            {
                int ld_q = Convert.ToInt32(pfpv_ld_q.Value);
                pfpv_ld_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pfpv", ld_q, "A");
            }

            if (pvpf_on == true && pfpv_md_q.Value > 0)
            {
                int md_q = Convert.ToInt32(pfpv_md_q.Value);
                pfpv_md_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pfpv", md_q, "B");
                pfpv_ld_datatable.Merge(pfpv_md_datatable);
            }

            if (pvpf_on == true && pfpv_hd_q.Value > 0)
            {
                int hd_q = Convert.ToInt32(pfpv_hd_q.Value);
                pfpv_hd_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pfpv", hd_q, "C");
                pfpv_ld_datatable.Merge(pfpv_hd_datatable);
            }


        }
        private void searchOthers()
        {

            if (others_on == true && others_all_q.Value > 0)
            {
                int ld_q = Convert.ToInt32(others_all_q.Value);
                others_ld_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("others", ld_q, "A");
            }

            if (others_on == true && pm_md_q.Value > 0)
            {
                int md_q = Convert.ToInt32(po_md_q.Value);
                others_md_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("others", md_q, "B");
                others_ld_datatable.Merge(others_md_datatable);
            }

            if (others_on == true && pm_hd_q.Value > 0)
            {
                int hd_q = Convert.ToInt32(pm_hd_q.Value);
                others_hd_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("others", hd_q, "C");
                others_ld_datatable.Merge(others_hd_datatable);

            }

        }
        private void searchPms()
        {

            if (pm_on == true && pm_ld_q.Value > 0)
            {
                int ld_q = Convert.ToInt32(pm_ld_q.Value);
                pm_ld_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pm", ld_q, "A");
            }

            if (pm_on == true && pm_md_q.Value > 0)
            {
                int md_q = Convert.ToInt32(po_md_q.Value);
                pm_md_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pm", md_q, "B");
                pm_ld_datatable.Merge(pm_md_datatable);
            }

            if (pm_on== true && pm_hd_q.Value > 0)
            {
                int hd_q = Convert.ToInt32(pm_hd_q.Value);
                pm_hd_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pm", hd_q, "C");
                pm_ld_datatable.Merge(pm_hd_datatable);

            }

        }
        private void searchPos()
        {

            if (po_on == true && po_ld_q.Value > 0)
            {
                int ld_q = Convert.ToInt32(pfpv_ld_q.Value);
                po_ld_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("po", ld_q, "A");
            }

            if (po_on == true && po_md_q.Value > 0)
            {
                int md_q = Convert.ToInt32(po_md_q.Value);
                po_md_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("po", md_q, "B");
                po_ld_datatable.Merge(po_md_datatable);
            }

            if (po_on == true && po_hd_q.Value > 0)
            {
                int hd_q = Convert.ToInt32(po_hd_q.Value);
                po_hd_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("po", hd_q, "C");
                po_ld_datatable.Merge(po_hd_datatable);
            }

        }

        private void searchPvs() {

            if (pv_on == true && pv_ld_q.Value > 0)
            {
                int ld_q = Convert.ToInt32(pv_ld_q.Value);
                pv_ld_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pv", ld_q, "A");
            }

            if (pv_on == true && pv_md_q.Value > 0)
            {
                int md_q = Convert.ToInt32(pv_md_q.Value);
                pv_md_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pv", md_q, "B");
                pv_ld_datatable.Merge(pv_md_datatable);
            }

            if (pv_on == true && pv_hd_q.Value > 0)
            {
                int hd_q = Convert.ToInt32(pv_hd_q.Value);
                pv_hd_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pv", hd_q, "C");
                pv_ld_datatable.Merge(pv_hd_datatable);
            }

        }
        //Borrella Search
        private void searchBorrella()
        {

            if (borrela_all_q.Value > 0)
            {
                int ld_q = Convert.ToInt32(borrela_all_q.Value);
                bo_ld_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("borrella", ld_q, "A");
            }

        }

        //Negatives Search
        private void searchNegatives()
        {

            if (negatives_q.Value > 0)
            {
                int q = Convert.ToInt32(negatives_q.Value);
                negatives_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("negatives", q, "C"); //there is or there no density for negative but we search LD/MD/HD any
            }

           
        }

        private void searchForPfCriteria() {

            if (pf_on == true && pf_ld_q.Value > 0)
            {
                int ld_q = Convert.ToInt32(pf_ld_q.Value);
                pf_ld_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pf", ld_q, "A");
            }
            if (pf_on == true && pf_md_q.Value > 0)
            {
                int md_q = Convert.ToInt32(pf_md_q.Value);
                pf_md_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pf", md_q, "B");
                pf_ld_datatable.Merge(pf_md_datatable);
            }

            if (pf_on == true && pf_hd_q.Value > 0)
            {
                int hd_q = Convert.ToInt32(pf_hd_q.Value);
                pf_hd_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pf", hd_q, "C");
                pf_ld_datatable.Merge(pf_hd_datatable);
            }
        }   
      
        private bool validate_before_Checkout() {

           
            if (cmb_borrowers.SelectedIndex == 0)
            {
                MessageBox.Show("Please, select a Contacts");
                return false;
            }

            if (cmb_reason.SelectedIndex == -1 && skip_days_validation == false)
            {
                MessageBox.Show("Please, select a a reason for checkout");
                return false;
            }

            if (txt_days.Value<=0 && skip_days_validation==false) {

                MessageBox.Show("Numdays is 0 or invalid. That means no checkout ? calculate the number of days for checkout");
                return false;
            }

            return true;
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {

            if (grd_search_results.Rows.Count <= 0)
            {
                MessageBox.Show("Search is result is empty, Nothing to checkout.");
                return;
            }

            bool isValid = validate_before_Checkout();

           
            try
            {
               
                if (isValid == true)
                {
                    int slides_id = -1;
                    DialogResult dialogResult = MessageBox.Show("You are going to checkout all below slides. Are you sure ?", "Checkout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in grd_search_results.Rows)
                        {
                            for (int i = 0; i < grd_search_results.Columns.Count; i++)
                            {
                                String header = grd_search_results.Columns[i].HeaderText;
                                String cellText = row.Cells[i].ToString();
                                var cellValue = row.Cells[i].Value;
                                // Console.WriteLine("COlumn:" + header);
                                // Console.WriteLine("Row TExt:"+cellText);
                                //Console.WriteLine("Value:" + cellValue);
                                if (header == "id" && cellValue != null)
                                    ids.Add(Convert.ToInt32(cellValue.ToString()));
                            }
                        }

                        bool isExchange = false;

                        if (ids != null)
                        {
                            logger.Info("checkout started ids are not null: " + UserAccountServices.Full_name);
                            //MessageBox.Show("Checkout proccess is started succesfull");
                            this.slide_searchTableAdapter.Fill(this.sbmsDataSet.slide_search);
                        }

                        bool isOkay = false;

                        if (String.CompareOrdinal(cmb_reason.SelectedItem.ToString(), "Exchange") == 0) {
                            isOkay = checkinCheckoutService.checkoutbySlideOutForExchange(Convert.ToInt32(cmb_borrowers.SelectedValue.ToString()), ids, cmb_reason.SelectedItem.ToString());
                            isExchange = true;
                        }
                        else 
                        {
                            isOkay = checkinCheckoutService.checkoutbySlideNoneExchange(Convert.ToInt32(cmb_borrowers.SelectedValue.ToString()), ids, txt_from_date.Value, txt_due_date.Value, cmb_reason.SelectedItem.ToString());
                        }

                        if (isOkay == false)
                        {

                            MessageBox.Show("Checkout is not Succesfull. \n Please , try again with reset search ");
                            this.slide_searchTableAdapter.Fill(this.sbmsDataSet.slide_search);
                            grd_search_results.DataSource = slidesearchBindingSource;
                            return;
                        }


                        if (isOkay == true && isExchange == false)
                        {


                            this.Invoke(new Action(() => { MessageBox.Show("Success! The selected slides are checkedout for Borrower with" + cmb_borrowers.SelectedItem.ToString()); }));

                            this.Invoke(new Action(() => {
                                SearchChekoutReportViewPort v = new SearchChekoutReportViewPort();
                                v.MdiParent = this.ParentForm;
                                v.Show();
                            }));

                            MessageBox.Show("Print out is being genereated");


                            grd_search_results.DataSource = null;
                            grd_search_results.Refresh();
                            this.slide_searchTableAdapter.Fill(this.sbmsDataSet.slide_search);
                            grd_search_results.DataSource = slidesearchBindingSource;

                            button1_Click(null,null);
                            button2_Click(null, null);
                        }

                        if (isOkay==true && isExchange==true)
                        {

                            
                            this.Invoke(new Action(() => { MessageBox.Show("Success! The selected slides are Exchanged with " + cmb_borrowers.SelectedItem.ToString()); }));

                            this.Invoke(new Action(() => {
                                ExchangeCheckoutReportViewPort v = new ExchangeCheckoutReportViewPort();
                                v.MdiParent = this.ParentForm;
                                v.Show(); }));

                            MessageBox.Show("Print out is being genereated");
                            grd_search_results.DataSource = null;
                            grd_search_results.Refresh();
                            this.slide_searchTableAdapter.Fill(this.sbmsDataSet.slide_search);
                            grd_search_results.DataSource = slidesearchBindingSource;
                            button1_Click(null, null);
                            button2_Click(null, null);
                        }

                    }
                }
            }
            catch (Exception ex) {
                //LOGGER HERE
                logger.Error(ex,"Search Checkout Search"+ex.StackTrace.ToString()) ;

            }
        }

        private void btn_dayCalculaor_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime d1 = txt_from_date.Value;
                DateTime d2 = txt_due_date.Value;
                TimeSpan days = d2 - d1;
                txt_days.Value = Convert.ToDecimal(Math.Round(Double.Parse(days.TotalDays.ToString()), 1));
                
                if (txt_days.Value > 0)
                {
                    txt_days.ForeColor = System.Drawing.Color.Yellow;
                    txt_days.BackColor = System.Drawing.Color.Green;
                    btn_dayCalculaor.ForeColor = System.Drawing.Color.Yellow;
                    btn_dayCalculaor.BackColor = System.Drawing.Color.Green;
            }
                else
                {
                    txt_days.ForeColor = System.Drawing.Color.Black;
                    txt_days.BackColor = System.Drawing.Color.Red;
                    btn_dayCalculaor.ForeColor = System.Drawing.Color.Black;
                    btn_dayCalculaor.BackColor = System.Drawing.Color.Red;
                    txt_days.Value = 0;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.StackTrace);
            }
        }

        public List<int> getSlideIDs()
        {
            if (ids != null && ids.Count > 0)
                return this.ids;
            else
                logger.Error("Slide IDS for checkout is empty currenly");
            return null;
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {

            Dictionary<int, string> borrowerDic = new Dictionary<int, string>();
            borrowerDic.Add(-1, "--Select Exchange---");
            foreach (DataRow row in this.sbmsDataSet.contact_list.Rows)
            {
                if (Boolean.Parse(row["isExchange"].ToString())==true)
                    borrowerDic.Add(Convert.ToInt32(row["id"]), "Country[ " + row["country"] + " ] Organisation [ " + row["country"] + "] Person: [ " + row["fname"] + " " + row["lname"] + " ]");
            }

            cmb_borrowers.DataSource = new BindingSource(borrowerDic, null);

            cmb_borrowers.DisplayMember = "Value";
            cmb_borrowers.ValueMember = "Key";
            //cmb_borrowers.SelectedItem = 0;
            //cmb_borrowers.Bind();
            // this.borr.Fill(this.sbmsDataSet.slides_for_checkout);
        }

  
        private void btn_Add_borrower_Click(object sender, EventArgs e)
        {
            Contacts b = new Contacts();
            b.MdiParent = this.MdiParent;
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pf_ld_q.Value = 0;
            pf_md_q.Value = 0;
            pf_hd_q.Value = 0;

            pv_md_q.Value = 0;
            pv_ld_q.Value = 0;
            pv_hd_q.Value = 0;

            pfpv_ld_q.Value = 0;
            pfpv_hd_q.Value = 0;
            pfpv_md_q.Value = 0;

            po_ld_q.Value = 0;
            po_hd_q.Value = 0;
            po_md_q.Value = 0;

            pm_ld_q.Value = 0;
            pm_hd_q.Value = 0;
            pm_md_q.Value = 0;

            others_all_q.Value = 0;
            borrela_all_q.Value = 0;
            negatives_q.Value = 0;



            // TODO: This line of code loads data into the 'sbmsDataSet.slide_search' table. You can move, or remove it, as needed.
            this.slide_searchTableAdapter.Fill(this.sbmsDataSet.slide_search);
            grd_search_results.DataSource = null;
            grd_search_results.DataSource = slidesearchBindingSource;
            grd_search_results.Refresh();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet.slide_search' table. You can move, or remove it, as needed.
            this.slide_searchTableAdapter.Fill(this.sbmsDataSet.slide_search);
            grd_search_results.DataSource = null;
            grd_search_results.DataSource = slidesearchBindingSource;
            grd_search_results.Refresh();
            ids = new List<int>();
        }

        private void cmb_reason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_reason.SelectedItem.ToString() == "Exchange")
            {
                DialogResult result = MessageBox.Show("You have selected : Checkout is as Exchange.\n Please , note that this sides will be returned back again \n in the normal checkin circulation", "Exchange", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    txt_from_date.Enabled = false;
                    txt_due_date.Enabled = false;
                    txt_days.Enabled = false;
                    skip_days_validation = true;
                    btn_dayCalculaor.Enabled = false;

                    Dictionary<int, string> borrowerDic = new Dictionary<int, string>();
                    borrowerDic.Add(-1, "--Select Exchange Contacts---");
                    foreach (DataRow row in this.sbmsDataSet.contact_list.Rows)
                    {
                        if (Boolean.Parse(row["isExchange"].ToString()))
                            borrowerDic.Add(Convert.ToInt32(row["id"]), row["fname"] + " " + row["lname"] + "  Country:   " + row["country"] + "  City:  " + row["city"]);
                    }

                    cmb_borrowers.DataSource = new BindingSource(borrowerDic, null);

                    cmb_borrowers.DisplayMember = "Value";
                    cmb_borrowers.ValueMember = "Key";
                    cmb_borrowers.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cmb_borrowers.AutoCompleteSource = AutoCompleteSource.ListItems;
                    lbl_ont.Text = "Exchanger";
                }
               

            }
            else
            {
             
                Dictionary<int, string> borrowerDic = new Dictionary<int, string>();
                borrowerDic.Add(-1, "--Select Borrower Contacts---");
                foreach (DataRow row in this.sbmsDataSet.contact_list.Rows)
                {
                    if (Boolean.Parse(row["isExchange"].ToString())==false)
                        borrowerDic.Add(Convert.ToInt32(row["id"]), row["fname"] + " " + row["lname"] + "  Country:   " + row["country"] + "  City:  " + row["city"]);
                }

                cmb_borrowers.DataSource = new BindingSource(borrowerDic, null);

                cmb_borrowers.DisplayMember = "Value";
                cmb_borrowers.ValueMember = "Key";
                cmb_borrowers.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmb_borrowers.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmb_reason.SelectedIndex = 0;
                txt_from_date.Enabled = true;
                txt_due_date.Enabled = true;
                txt_days.Enabled = true;
                skip_days_validation = false;
                btn_dayCalculaor.Enabled = true;
                lbl_ont.Text = "Borrowers";
            }

        }
    }
}
