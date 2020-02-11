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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
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
            // TODO: This line of code loads data into the 'sbmsDataSet.borrower_contact_list' table. You can move, or remove it, as needed.
            this.borrower_contact_listTableAdapter.Fill(this.sbmsDataSet.borrower_contact_list);
            // TODO: This line of code loads data into the 'sbmsDataSet.borrower_contact_list' table. You can move, or remove it, as needed.
            this.borrower_contact_listTableAdapter.Fill(this.sbmsDataSet.borrower_contact_list);

            Dictionary<int, string> borrowerDic = new Dictionary<int, string>();
            borrowerDic.Add(0, "--Select Borrower/Contact---");
            foreach (DataRow row in this.sbmsDataSet.borrower_contact_list.Rows)
            {
                borrowerDic.Add(Convert.ToInt32(row["id"]), row["fname"] + " " + row["lname"] + "  Org:   " + row["organisation"] + "  Position:  " + row["job_title"]);
            }

            cmb_borrowers.DataSource = new BindingSource(borrowerDic, null);
            ;

            cmb_borrowers.DisplayMember = "Value";
            cmb_borrowers.ValueMember = "Key";
            //cmb_borrowers.SelectedItem = 0;
            //cmb_borrowers.Bind();
            // this.borr.Fill(this.sbmsDataSet.slides_for_checkout);
        }

    }
}
