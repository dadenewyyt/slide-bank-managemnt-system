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
    public partial class Checkout : Form
    {
        Dictionary<int, string> dictionaryDCatgerory;
        Dictionary<int, string> dictionarySpecifics;
        Dictionary<int, string> dictionaryStages;
        Dictionary<int, string> dictionarySCatgerory;
        FilterService filterService;
        LookUpServices lookupServices;
        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet.species_category' table. You can move, or remove it, as needed.
            this.species_categoryTableAdapter.Fill(this.sbmsDataSet.species_category);
            // TODO: This line of code loads data into the 'sbmsDataSet.species_stages' table. You can move, or remove it, as needed.
            this.species_stagesTableAdapter.Fill(this.sbmsDataSet.species_stages);
            // TODO: This line of code loads data into the 'sbmsDataSet1.density_category' table. You can move, or remove it, as needed.
            this.density_categoryTableAdapter.Fill(this.sbmsDataSet1.density_category);
            // TODO: This line of code loads data into the 'sbmsDataSet.borrower_contact_list' table. You can move, or remove it, as needed.
            this.borrower_contact_listTableAdapter.Fill(this.sbmsDataSet.borrower_contact_list);
            // TODO: This line of code loads data into the 'sbmsDataSet.slides_for_checkout' table. You can move, or remove it, as needed.
            this.slidesCheckoutTableAdapter.Fill(this.sbmsDataSet.slides_for_checkout);
          

            Dictionary<int, string> borrowerDic  = new Dictionary<int, string>();
            borrowerDic.Add(0, "--Select Borrower/Contact---");
            foreach (DataRow row in this.sbmsDataSet.borrower_contact_list.Rows)
            {
                borrowerDic.Add(Convert.ToInt32(row["id"]), row["fname"] + " " + row["lname"] + "  Org:   "+ row["organisation"] + "  Position:  " + row["job_title"]);
            }
           
            cmb_borrowers.DataSource =  new BindingSource(borrowerDic, null);
            ;

            cmb_borrowers.DisplayMember = "Value";
            cmb_borrowers.ValueMember = "Key";
            //cmb_borrowers.SelectedItem = 0;
            //cmb_borrowers.Bind();
            // this.borr.Fill(this.sbmsDataSet.slides_for_checkout);

            DataGridViewCheckBoxColumn dgvCheckBox = new DataGridViewCheckBoxColumn();
            dgvCheckBox.HeaderText = "Select";
            dgvCheckBox.ReadOnly = false;
            dgvCheckBox.DefaultCellStyle.BackColor = Color.Red;
            dgvCheckBox.Name = "DGVCheckBox";
            grd_slides_for_checkout.Columns.Insert(0,dgvCheckBox);
            grd_slides_for_checkout.ReadOnly = false;

             lookupServices = new LookUpServices();

            //get Speciece Specifics
             dictionarySpecifics = lookupServices.fetchLookupTables("species_specifics");

            cmb_specice_specifics.DataSource = new BindingSource(dictionarySpecifics, null);
            cmb_specice_specifics.ValueMember = "Key";
            cmb_specice_specifics.DisplayMember = "Value";
            cmb_specice_specifics.SelectedIndex = 0;

            //get Speciece Specifics
            dictionarySCatgerory = lookupServices.fetchLookupTables("species_category");
            cmb_specice_category.DataSource = new BindingSource(dictionarySCatgerory, null);
            cmb_specice_category.ValueMember = "Key";
            cmb_specice_category.DisplayMember = "Value";

            cmb_specice_category.SelectedIndex = 0;

            //get Speciece Stage
            dictionaryStages = lookupServices.fetchLookupTables("species_stages");
            cmb_specice_stage.DataSource = new BindingSource(dictionaryStages, null);
            cmb_specice_stage.ValueMember = "Key";
            cmb_specice_stage.DisplayMember = "Value";
            cmb_specice_stage.SelectedIndex = 0;

            //get Speciece Specifics
            dictionaryDCatgerory = lookupServices.fetchLookupTables("density_category");
            cmb_density_category.DataSource = new BindingSource(dictionaryDCatgerory, null);
            cmb_density_category.ValueMember = "Key";
            cmb_density_category.DisplayMember = "Value";
            cmb_density_category.SelectedIndex = 0;

           
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate
            btn_dayCalculaor_Click(null,null);
            if (Int32.Parse(txt_days.Text.ToString()) == 0 || Int32.Parse(txt_days.Text.ToString()) < 0) {
                MessageBox.Show("Checkout date can not be O days or -ve Day Value.(You can not borrow backward ?", "Invalid ");
                return;

            }
        }

        private void selected_slides_checkout_ready(object sender, DataGridViewCellEventArgs e)
        {
            //GET BACKL
        }

        private DataGridView CopyDataGridView(DataGridView dgv_org)
        {
            DataGridView dgv_copy = new DataGridView();
            try
            {
                if (dgv_copy.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dgv_copy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.SelectedRows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgv_copy.Rows.Add(row);
                }
                dgv_copy.AllowUserToAddRows = false;
                dgv_copy.Refresh();

            }
            catch (Exception ex)
            {
                //ex.ShowExceptionErrorMsg("Copy DataGridViw", ex);
            }
            return dgv_copy;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        

            // Datat
            DataTable dt = new DataTable();
            dt.Columns.Add("BarCode");
            dt.Columns.Add("DonorCode");
            dt.Columns.Add("SlideSeq#");
            dt.Columns.Add("DC");
            dt.Columns.Add("SS");
            dt.Columns.Add("SC");
            dt.Columns.Add("LD");
            dt.Columns.Add("AD");
            dt.Columns.Add("UD");
            dt.Columns.Add("Cabinet#");
            dt.Columns.Add("Box#");
            dt.Columns.Add("Drawer#");
          

            foreach (DataGridViewRow drv in grd_slides_for_checkout.Rows) {

                bool chkBoxSelect = Convert.ToBoolean(drv.Cells["DGVCheckBox"].Value);

                if (chkBoxSelect) {
                    dt.Rows.Add(drv.Cells[2].Value, drv.Cells[3].Value, drv.Cells[4].Value, dictionaryDCatgerory[Convert.ToInt32(drv.Cells[5].Value)],dictionarySpecifics[Convert.ToInt32(drv.Cells[5].Value)], dictionarySCatgerory[Convert.ToInt32(drv.Cells[7].Value)], drv.Cells[8].Value, drv.Cells[9].Value, drv.Cells[10].Value, drv.Cells[11].Value, drv.Cells[12].Value, drv.Cells[13].Value);
                 
                    drv.DefaultCellStyle.BackColor = Color.Gray;
                    drv.DefaultCellStyle.ForeColor = Color.Aqua;
                }
                dataGridView1.DataSource = dt;
            }

        }

        private bool ValidateSearch() { 
        
         if(cmb_specice_category.SelectedIndex==-1 && chk_SC.Checked) { 

                MessageBox.Show("You have selected invalid value for specice Catgeroy", "Invalid Search Criteria");
                return false;
        }

        if(cmb_specice_specifics.SelectedIndex==-1 && chk_SS.Checked) {
        
             MessageBox.Show("You have selected invalid value for specice specifics", "Invalid Search Criteria");
             return false;
        }

        if (cmb_specice_stage.SelectedIndex == -1 && chk_S.Checked)
        {

            MessageBox.Show("You have selected invalid value for specice stage", "Invalid Search Criteria");
            return false;
        }

        if (cmb_density_category.SelectedIndex == -1 && chk_DC.Checked)
        {

            MessageBox.Show("You have selected invalid value for density catgeroy", "Invalid Search Criteria");
            return false;
        }


         return true;
        }

    //cmb_specice_specifics.SelectedIndex == -1 || cmb_specice_stage.SelectedIndex==-1 || cmb_density_category.SelectedIndex==-1) {


    private void btn_search_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            timer1.Enabled = true;
           
         
           

        }

        private void btn_dayCalculaor_Click(object sender, EventArgs e)
        {
            DateTime d1 = txt_from_date.Value;
            DateTime d2 = txt_due_date.Value;
            TimeSpan days =  d2 - d1;
            txt_days.Text = Convert.ToString(Math.Round(Double.Parse(days.TotalDays.ToString()),1));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value > 99)
            {
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                timer1.Enabled = false;

                bool isValid = ValidateSearch();
                
                if (isValid == true)
                {

                    filterService = new FilterService();
                    filterService.SCID = cmb_specice_category.SelectedIndex;
                    filterService.SSID = cmb_specice_specifics.SelectedIndex;
                    filterService.SID = cmb_specice_stage.SelectedIndex;
                    filterService.DCID = cmb_density_category.SelectedIndex;
                    filterService.qunatity = Convert.ToInt32(numeric_qunaity_txt.Value);

                    DataTable dt = filterService.FilterSlides();
                    grd_slides_for_checkout.DataSource = dt;

                }
            }
        }

        private void chk_SS_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_SS.Checked)
                cmb_specice_specifics.Enabled = false;
            else
                cmb_specice_specifics.Enabled = true;

        }

        private void chk_SC_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_SC.Checked)
                cmb_specice_category.Enabled = false;
            else
                cmb_specice_category.Enabled = true;
        }

        private void chk_S_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_S.Checked)
                cmb_specice_stage.Enabled = false;
            else
                cmb_specice_stage.Enabled = true;
        }

        private void chk_DC_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_DC.Checked)
                cmb_density_category.Enabled = false;
            else
                cmb_density_category.Enabled = true;
        }

        private void btn_Add_borrower_Click(object sender, EventArgs e)
        {
            Borrowers b = new Borrowers();
         
            b.MdiParent = this.ParentForm;
            b.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cmb_borrowers.Refresh();
            cmb_borrowers.DataSource = null;
            cmb_borrowers.Items.Clear();
            Dictionary<int, string> borrowerDic = new Dictionary<int, string>();
            borrowerDic.Add(0, "--Select Borrower/Contact---");
            foreach (DataRow row in this.sbmsDataSet.borrower_contact_list.Rows)
            {
                borrowerDic.Add(Convert.ToInt32(row["id"]), row["fname"] + " " + row["lname"] + "  Org:   " + row["organisation"] + "  Position:  " + row["job_title"]);
            }

            cmb_borrowers.DataSource = new BindingSource(borrowerDic, null);
            cmb_borrowers.DisplayMember = "Value";
            cmb_borrowers.ValueMember = "Key";
        }
    }
}

