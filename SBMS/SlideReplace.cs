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
    public partial class SlideReplace : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        bool damaged_selected = false;
        bool replace_selected = false;
        int damaged_speciece = -1;
        int replacement_speciece = -1;

        int damaged_slide_id = -1;
        int replaced_slide_id = -1;

        public SlideReplace()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validateAndSearchFlags() {


            return true;
        }

        private bool validateSlideSequenceIds()
        {
          

            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Validate and //trun search flag on frist

            bool Validation1st = validateAndSearchFlags();

        }

        private void SlideReplace_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbmsDataSet1.owners' table. You can move, or remove it, as needed.
            this.ownersTableAdapter1.Fill(this.sbmsDataSet1.owners);
            // TODO: This line of code loads data into the 'sbmsDataSet.validations' table. You can move, or remove it, as needed.
            this.validationsTableAdapter1.Fill(this.sbmsDataSet.validations);
            // TODO: This line of code loads data into the 'sbmsDataSet.species_stages' table. You can move, or remove it, as needed.
            this.species_stagesTableAdapter1.Fill(this.sbmsDataSet.species_stages);
            // TODO: This line of code loads data into the 'sbmsDataSet.species_specifics' table. You can move, or remove it, as needed.
            this.species_specificsTableAdapter1.Fill(this.sbmsDataSet.species_specifics);
            // TODO: This line of code loads data into the 'sbmsDataSet.species_category' table. You can move, or remove it, as needed.
            this.species_categoryTableAdapter2.Fill(this.sbmsDataSet.species_category);
            // TODO: This line of code loads data into the 'sbmsDataSet1.density_category' table. You can move, or remove it, as needed.
            this.density_categoryTableAdapter1.Fill(this.sbmsDataSet1.density_category);
            // TODO: This line of code loads data into the 'sbmsDataSet.slide_reserved_for_replacement' table. You can move, or remove it, as needed.
            this.slide_reserved_for_replacementTableAdapter.Fill(this.sbmsDataSet.slide_reserved_for_replacement);
            // TODO: This line of code loads data into the 'sbmsDataSet.slide_to_replace' table. You can move, or remove it, as needed.
            this.slide_to_replaceTableAdapter.Fill(this.sbmsDataSet.slide_to_replace);
            // TODO: This line of code loads data into the 'speciceCatgeroyDataSet.species_category' table. You can move, or remove it, as needed.
            this.species_categoryTableAdapter1.Fill(this.speciceCatgeroyDataSet.species_category);
           
            grd_replace.AllowUserToAddRows = false;
            grd_damaged.AllowUserToAddRows = false;
            lbl_selection_damaged.ForeColor = Color.Red;


        }

        private void grd_damaged_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndexGird;
            rowIndexGird = e.RowIndex;

            if (grd_damaged.Rows.Count > 0) {
                string barcode  = grd_damaged.Rows[e.RowIndex].Cells["barcode"].Value + string.Empty;
                damaged_slide_id = Convert.ToInt32(grd_damaged.Rows[e.RowIndex].Cells["iddamagedDataGridViewTextBoxColumn"].Value);
                lbl_selection_damaged.ForeColor = Color.Green;
                lbl_selection_damaged.Text = "Damaged Slide selected => Bardcode:" + barcode;
                damaged_selected = true;
                damaged_speciece = Convert.ToInt32(grd_damaged.Rows[e.RowIndex].Cells["speciesspecificdamagedDataGridViewComboBoxColumn"].Value);

            }

        }

        private void grd_replace_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndexGird;
            rowIndexGird = e.RowIndex;

            if (grd_replace.Rows.Count > 0)
            {
                string barcode = grd_replace.Rows[e.RowIndex].Cells["barcodereplacdataGridViewTextBoxColumn"].Value + string.Empty;
                replaced_slide_id = Convert.ToInt32(grd_replace.Rows[e.RowIndex].Cells["idreplaceGridViewTextBoxColumn1"].Value);
                lbl_selection_replace.ForeColor = Color.Green;
                lbl_selection_replace.Text = "Replacement Slide Selected => Bardcode:" + barcode;
                replace_selected = true;
                replacement_speciece = Convert.ToInt32(grd_replace.Rows[e.RowIndex].Cells["speciecereplaceaGridViewComboBoxColumn"].Value);

            }

        }
        public bool ValidateSelection() {

            if (damaged_selected == true && replace_selected == false)
            {
                MessageBox.Show("Select the Replacement Slide. Come back.");
                return false;
            }
            if (replace_selected == true && damaged_selected == false)
            {
                MessageBox.Show("Select the Damaged Slide to be replaced.Come back.");
                return false;
            }
            if (damaged_selected == false && replace_selected == false)
            {
                MessageBox.Show("Nothing is Selected ?");
                return false;
            }
            if (damaged_speciece != replacement_speciece)
            {
                DialogResult result = MessageBox.Show("Speciecs doesn match! Are you sure you would like to proceed? ", "Replacment Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No) return false;
            }
            if (damaged_slide_id == -1)
            {
                return false;
            }
            if (replaced_slide_id != -1)
            {
                return false;
            }
            return true;
        }

        

        private void btn_replace_Click(object sender, EventArgs e)
        {
            bool isEverythingOk = ValidateSelection();

            if (isEverythingOk == true) { 
            
                //replacment starts nows

            
            }

            
        }
    }
}
