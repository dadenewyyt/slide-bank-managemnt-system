using MSBMS.Reports.CrystalReports;
using MSBMS.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MSBMS
{
    public partial class Lending : Form
    {
        SearchAndFilterService searchAndFIlterService;
        public Lending()
        {
            InitializeComponent();
            searchAndFIlterService = new SearchAndFilterService();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lending_Load(object sender, System.EventArgs e)
        {
            grd_currentLending.AllowUserToAddRows = false;
            
            // TODO: This line of code loads data into the 'sbmsDataSet.current_lending_past_history' table. You can move, or remove it, as needed.
            this.current_lending_past_historyTableAdapter.Fill(this.sbmsDataSet.current_lending_past_history);
            // TODO: This line of code loads data into the 'speciece_specifics_dataBindingSource.species_specifics' table. You can move, or remove it, as needed.
            this.species_specificsTableAdapter.Fill(this.speciece_specifics_dataBindingSource.species_specifics);
            // TODO: This line of code loads data into the 'ownerDataBindingSource.owners' table. You can move, or remove it, as needed.
            this.ownersTableAdapter.Fill(this.ownerDataBindingSource.owners);
            // TODO: This line of code loads data into the 'sbmsDataSet.species_stages' table. You can move, or remove it, as needed.
            this.species_stagesTableAdapter.Fill(this.sbmsDataSet.species_stages);
            // TODO: This line of code loads data into the 'desnityCat_bindingDataSource.density_category' table. You can move, or remove it, as needed.
            this.density_categoryTableAdapter.Fill(this.desnityCat_bindingDataSource.density_category);
            // TODO: This line of code loads data into the 'sbmsDataSet.current_lending_history' table. You can move, or remove it, as needed.
            this.currentLendingHisotryTableAdapter.Fill(this.sbmsDataSet.current_lending_history);
            // TODO: This line of code loads data into the 'sbmsDataSet.borrower_contact_list' table. You can move, or remove it, as needed.
            this.borrower_contact_listTableAdapter.Fill(this.sbmsDataSet.contact_list);
            Dictionary<int, string> borrowerDic = new Dictionary<int, string>();
            borrowerDic.Add(-1, "--Select Full Name of the Borrower---");
            foreach (DataRow row in this.sbmsDataSet.contact_list.Rows)
            {
                borrowerDic.Add(Convert.ToInt32(row["id"]), row["fname"] + " " + row["lname"]);
            }

            cmb_borrowers_full_name.DataSource = new BindingSource(borrowerDic, null);

            cmb_borrowers_full_name.DisplayMember = "Value";
            cmb_borrowers_full_name.ValueMember = "Key";

            Dictionary<int, string> borrowerOrgDic = new Dictionary<int, string>();


            borrowerOrgDic.Add(-1, "--Select Organisations---");
            foreach (DataRow row in this.sbmsDataSet.contact_list.Rows)
            {
                borrowerOrgDic.Add(Convert.ToInt32(row["id"]), row["organisation"].ToString());
            }

            cmb_borrowers_org.DataSource = new BindingSource(borrowerOrgDic, null);

            cmb_borrowers_org.DisplayMember = "Value";
            cmb_borrowers_org.ValueMember = "Key";

            cmb_borrowers_org.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_borrowers_org.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void searchby_borrower(object sender, EventArgs e)
        {
            DataTable searched = new DataTable();
            if (this.cmb_borrowers_full_name.SelectedIndex != 0)
            {
                MessageBox.Show("Search" + this.cmb_borrowers_full_name.SelectedIndex);
                int id = this.cmb_borrowers_full_name.SelectedIndex;
                searched = searchAndFIlterService.SearchLendingByBorrowerId(id);

            }
            if (searched.Rows.Count>0)
            {
                MessageBox.Show("Search" + this.cmb_borrowers_full_name.SelectedIndex);
                grd_currentLending.DataSource = null;
                grd_currentLending.Refresh();
                grd_currentLending.DataSource = searched;
              
            }
            if (searched.Rows.Count == 0 && this.cmb_borrowers_full_name.SelectedIndex!=0)
            {
                MessageBox.Show("The Searched Borrower has not current lendings.", "System");
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable searched = new DataTable();
                if (this.cmb_borrowers_full_name.SelectedIndex != 0)
                {
                    MessageBox.Show("Search" + this.cmb_borrowers_full_name.SelectedItem.ToString());
                    int id = this.cmb_borrowers_full_name.SelectedIndex;
                    searched = searchAndFIlterService.SearchLendingByBorrowerId(id);

                }
                if (searched.Rows.Count > 0)
                {
                    //MessageBox.Show("Search" + this.cmb_borrowers_org.SelectedIndex);
                    grd_currentLending.DataSource = null;
                    grd_currentLending.Refresh();
                    grd_currentLending.DataSource = searched;

                }
                if (searched.Rows.Count == 0 && this.cmb_borrowers_full_name.SelectedIndex != 0)
                {
                    MessageBox.Show("Borrower has not current lendings.", "System");
                    grd_currentLending.DataSource = null;
                    grd_currentLending.Refresh();
                    grd_currentLending.DataSource = searched;
                }
            }
             
            catch (Exception ex) { 
            //TODO
            }

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable searched = new DataTable();
            if (this.cmb_borrowers_org.SelectedIndex != 0)
            {
                MessageBox.Show("Search" + this.cmb_borrowers_org.SelectedItem.ToString());
                int id = this.cmb_borrowers_org.SelectedIndex;
                searched = searchAndFIlterService.SearchLendingByBorrowerId(id);

            }
            if (searched.Rows.Count > 0)
            {
                //MessageBox.Show("Search" + this.cmb_borrowers_org.SelectedIndex);
                grd_currentLending.DataSource = null;
                grd_currentLending.Refresh();
                grd_currentLending.DataSource = searched;

            }
            if (searched.Rows.Count == 0 && this.cmb_borrowers_org.SelectedIndex != 0)
            {
                MessageBox.Show("Organisation has not current lendings.", "System");
                grd_currentLending.DataSource = null;
                grd_currentLending.Refresh();
                grd_currentLending.DataSource = searched;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintCurrentLendings print = new PrintCurrentLendings();
            print.MdiParent = this.MdiParent;
            print.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.grd_currentLending.Width, this.grd_currentLending.Height);
            grd_currentLending.DrawToBitmap(bm, new Rectangle(0,0,this.grd_currentLending.Width, this.grd_currentLending.Height));
            e.Graphics.DrawImage(bm, 10, 10);
        }
    }
}
