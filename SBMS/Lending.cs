using SBMS.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SBMS
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
            this.borrower_contact_listTableAdapter.Fill(this.sbmsDataSet.borrower_contact_list);
            Dictionary<int, string> borrowerDic = new Dictionary<int, string>();
            borrowerDic.Add(-1, "--Search Borrower Here---");
            foreach (DataRow row in this.sbmsDataSet.borrower_contact_list.Rows)
            {
                borrowerDic.Add(Convert.ToInt32(row["id"]), row["fname"] + " " + row["lname"] + "  Org:   " + row["organisation"] + "  Position:  " + row["job_title"]);
            }

            cmb_borrowers.DataSource = new BindingSource(borrowerDic, null);

            cmb_borrowers.DisplayMember = "Value";
            cmb_borrowers.ValueMember = "Key";

            cmb_borrowers.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_borrowers.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void searchby_borrower(object sender, EventArgs e)
        {
            DataTable searched = new DataTable();
            if (this.cmb_borrowers.SelectedIndex != 0)
            {
                MessageBox.Show("Search" + this.cmb_borrowers.SelectedIndex);
                int id = this.cmb_borrowers.SelectedIndex;
                searched = searchAndFIlterService.SearchLendingByBorrowerId(id);

            }
            if (searched != null)
            {
                grd_currentLending.DataSource = null;
                grd_currentLending.Refresh();
                grd_currentLending.DataSource = searched;
              
            }
            if (searched == null)
            {
                MessageBox.Show("The Searched Borrower has not current lendings.", "System");
            }
        }
    }
}
