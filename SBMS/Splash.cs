using MSBMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSBMS
{
    public partial class Splash : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        ImportDefaultsService importDefaultsService;

        public Splash()
        {
            InitializeComponent();

        }

        private void Splash_Load(object sender, EventArgs e)
        {
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 700) {
                timer1.Stop();
                this.Hide();
                Login log = new Login();
                log.ShowDialog();
                //this.
            }
        }
    }
}
