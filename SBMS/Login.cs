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
    public partial class Login : Form
    {
        private Boolean login_flag = false;

        public Login()
        {
            InitializeComponent();

            //This is the part needed to create a custom shaped Form
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = 565;
            this.Height = 436;
            this.TransparencyKey = SystemColors.Control;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDIParent1 parent = new MDIParent1();

            parent.Show();



        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Modal = true;

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_progress.Show();
            if (progressBar1.Value <= 99)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                login_flag = UserAccountServices.login(txt_name.Text.ToString().Trim(), txt_pass.Text.ToString());

                if (login_flag == true)
                {
                    panel_progress.Hide();
                    this.Hide();
                    TopMost = false;
                    MDIParent1 mdiParent1 = new MDIParent1();
                    mdiParent1.ShowDialog();

                }
                if (login_flag == false && progressBar1.Value == 100)
                {
                    MessageBox.Show("Inorrect , Could you please make sure you type a correct username and password", "Security", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    timer1.Enabled = false;
                    panel_progress.Hide();
                    progressBar1.Value = 0;
                    panel_progress.Hide();

                    //this.Show();
                    //TopMost = false;
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void enter_pressed(object sender, KeyEventArgs e)
        {

        }

        private void enter_key(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button4_Click(null, null);
            }
        }
    }
}
