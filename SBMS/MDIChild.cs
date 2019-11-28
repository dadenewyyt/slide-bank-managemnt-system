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
    public partial class MDIChild : Form
    {
        public MDIChild()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Slides slide = new Slides();
            slide.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Donors donors = new Donors();
            donors.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
