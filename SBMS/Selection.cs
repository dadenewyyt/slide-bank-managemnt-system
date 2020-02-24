using SBMS.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SBMS
{
    public partial class Selection : Form
    {
        

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
        SearchAndFilterService searchAndFilterService;
        CheckinCheckoutService checkinCheckoutService;
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
            // TODO: This line of code loads data into the 'sbmsDataSet.slide_search' table. You can move, or remove it, as needed.
            this.slide_searchTableAdapter.Fill(this.sbmsDataSet.slide_search);
            // TODO: This line of code loads data into the 'sbmsDataSet.borrower_contact_list' table. You can move, or remove it, as needed.
            this.borrower_contact_listTableAdapter.Fill(this.sbmsDataSet.borrower_contact_list);
 
            Dictionary<int, string> borrowerDic = new Dictionary<int, string>();
            borrowerDic.Add(-1, "--Select Borrower/Contact---");
            foreach (DataRow row in this.sbmsDataSet.borrower_contact_list.Rows)
            {
                borrowerDic.Add(Convert.ToInt32(row["id"]), row["fname"] + " " + row["lname"] + "  Org:   " + row["organisation"] + "  Position:  " + row["job_title"]);
            }

            cmb_borrowers.DataSource = new BindingSource(borrowerDic, null);
            
            cmb_borrowers.DisplayMember = "Value";
            cmb_borrowers.ValueMember = "Key";
            //cmb_borrowers.SelectedItem = 0;
            //cmb_borrowers.Bind();
            // this.borr.Fill(this.sbmsDataSet.slides_for_checkout);
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            showValidationMessage();
            this.searchForPfCriteria();
            this.searchPvs();
            this.searchPfPvs();
            this.searchPms();
            this.searchPos();
            this.searchOthers();
          
            mergedSearchResult.Clear();
            mergedSearchResult.Merge(pv_ld_datatable);
            mergedSearchResult.Merge(pf_ld_datatable);
            mergedSearchResult.Merge(pfpv_ld_datatable);
            mergedSearchResult.Merge(po_ld_datatable);
            mergedSearchResult.Merge(pm_ld_datatable);
            mergedSearchResult.Merge(others_ld_datatable);
            grd_search_results.DataSource = null;
            grd_search_results.DataSource = mergedSearchResult;
            resetDataSetsAftersearch();

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

            if (others_on == true && others_ld_q.Value > 0)
            {
                int ld_q = Convert.ToInt32(others_ld_q.Value);
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
                int ld_q = Convert.ToInt32(pv_md_q.Value);
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
                pv_ld_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pv", hd_q, "C");
                pv_ld_datatable.Merge(pv_hd_datatable);
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
                int md_q = Convert.ToInt32(pf_ld_q.Value);
                pf_md_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pf", md_q, "B");
                pf_ld_datatable.Merge(pf_md_datatable);
            }

            if (pf_on == true && pf_hd_q.Value > 0)
            {
                int hd_q = Convert.ToInt32(pf_ld_q.Value);
                pf_hd_datatable = searchAndFilterService.searchSlideByParasiteQuanityAndDensity("pf", hd_q, "C");
                pf_ld_datatable.Merge(pf_hd_datatable);
            }
        }

        private void showValidationMessage() {
            if (pv_on == false)
            {
                MessageBox.Show("Pv will be excluded from search");
            }
            if (pf_on == false)
            {
                MessageBox.Show("Pf will be excluded from search");
            }
            if (pvpf_on == false)
            {
                MessageBox.Show("PvPf will be excluded from search");
            }
            if (po_on == false)
            {
                MessageBox.Show("Po will be excluded from search");
            }
            if (pm_on == false)
            {
                MessageBox.Show("Pm will be excluded from search");
            }
            if (others_on == false)
            {
                MessageBox.Show("Others  will be excluded from search");
            }

        }
        private void chk_others_CheckedChanged(object sender, EventArgs e)
        {
            others_hd_q.Enabled = false;
            others_ld_q.Enabled = false;
            others_md_q.Enabled = false;
            others_on = false;
        }

        private void chk_pm_CheckedChanged(object sender, EventArgs e)
        {
            pm_hd_q.Enabled = false;
            pm_ld_q.Enabled = false;
            pm_md_q.Enabled = false;
            pm_on = false;
        }

        private void chk_po_CheckedChanged(object sender, EventArgs e)
        {
            po_hd_q.Enabled = false;
            po_ld_q.Enabled = false;
            po_md_q.Enabled = false;
            po_on = false;
        }

        private void chk_pfpv_CheckedChanged(object sender, EventArgs e)
        {
            pfpv_hd_q.Enabled = false;
            pfpv_ld_q.Enabled = false;
            pfpv_md_q.Enabled = false;
            pvpf_on = false;
        }

        private void chk_pv_CheckedChanged(object sender, EventArgs e)
        {
            pv_hd_q.Enabled = false;
            pv_ld_q.Enabled = false;
            pv_md_q.Enabled = false;
            pv_on = false;
        }

        private void chk_pf_CheckedChanged(object sender, EventArgs e)
        {
            pf_hd_q.Enabled = false;
            pf_ld_q.Enabled = false;
            pf_md_q.Enabled = false;
            pf_on = false;
        }
        private bool validate_before_Checkout() {

            
            if (cmb_borrowers.SelectedIndex == 0)
            {
                MessageBox.Show("Please, select a borrower to checkout for");
                return false;
            }

            if (cmb_reason.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select a a reason for checkout");
                return false;
            }

            if (txt_days.Value<=0) {

                MessageBox.Show("Numdays is 0 or invalid. That means no checkout ? calculate the number of days for checkout");
                return false;
            }

            return true;
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            bool isValid = validate_before_Checkout();
            List<int> ids = new List<int>();
            if (isValid == true)
            {

                int slides_id = -1;
                DialogResult dialogResult = MessageBox.Show("You are going to checkout all below slides. Are you sure ?", "Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in grd_search_results.Rows)
                    {
                        for (int i = 0; i < grd_search_results.Columns.Count; i++)
                        {
                            String header = grd_search_results.Columns[i].HeaderText;
                            String cellText = row.Cells[i].ToString();
                            var cellValue = row.Cells[i].Value;
                            Console.WriteLine("COlumn:" + header);
                            // Console.WriteLine("Row TExt:"+cellText);
                            Console.WriteLine("Value:" + cellValue);
                            if (header == "id" && cellValue != null)
                                ids.Add(Convert.ToInt32(cellValue.ToString()));
                        }
                    }

                    bool isOkay = checkinCheckoutService.checkoutbySlideIds(cmb_borrowers.SelectedIndex, ids,txt_from_date.Value,txt_due_date.Value,cmb_reason.SelectedItem.ToString());

                    if (isOkay)
                    {
                        MessageBox.Show("Successfull! Slides are Checked Out!");
                        this.slide_searchTableAdapter.Fill(this.sbmsDataSet.slide_search);
                    }
                }
            }
        }

        private void btn_dayCalculaor_Click(object sender, EventArgs e)
        {
            DateTime d1 = txt_from_date.Value;
            DateTime d2 = txt_due_date.Value;
            TimeSpan days = d2 - d1;
            txt_days.Value =Convert.ToDecimal(Math.Round(Double.Parse(days.TotalDays.ToString()), 1));
        }
    }
}
