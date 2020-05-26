using System;
using System.Windows.Forms;

namespace SBMS
{
    public partial class SlideHistory : Form
    {
        public SlideHistory()
        {
            InitializeComponent();
        }

        private void SlideHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stage_dataBindingSource.species_stages' table. You can move, or remove it, as needed.
            this.species_stagesTableAdapter.Fill(this.stage_dataBindingSource.species_stages);
            // TODO: This line of code loads data into the 'sbmsDataSet11.density_category' table. You can move, or remove it, as needed.
            this.density_categoryTableAdapter.Fill(this.sbmsDataSet11.density_category);
            // TODO: This line of code loads data into the 'sbmsDataSet1.species_category' table. You can move, or remove it, as needed.
            this.species_categoryTableAdapter.Fill(this.sbmsDataSet1.species_category);
            // TODO: This line of code loads data into the 'sbmsDataSet1.species_specifics' table. You can move, or remove it, as needed.
            this.species_specificsTableAdapter.Fill(this.sbmsDataSet1.species_specifics);
            // TODO: This line of code loads data into the 'sbmsDataSet1.slide_history' table. You can move, or remove it, as needed.
            this.slidesHistoryTableAdapter.Fill(this.sbmsDataSet1.slide_history);
            // TODO: This line of code loads data into the 'sbmsDataSet.slide_history' table. You can move, or remove it, as needed.
            this.slidesHistoryTableAdapter.Fill(this.sbmsDataSet.slide_history);

        }
    }
}
