using MSBMS.Services;
using System;
using System.Windows.Forms;

namespace MSBMS
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        // Display the new form.
        public MDIParent1()
        {
            InitializeComponent();
            MDIChild newMDIChild = new MDIChild();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            newMDIChild.Show();


            //Slides slide = new Slides();
           // slide.MdiParent = this;

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            string full_name = UserAccountServices.Full_name;
            //lbl_welcom.Text = " Welcome , " + full_name + "  system is logging update and save logs.";
            toolStripStatusLabel1.Text = " Welcome , " + full_name + "  system is logging update and save logs.";
        }

        private void btn_lgout_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            Login log = new Login();
            log.Show();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure ?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }
                Dispose();
                Application.Exit();
            }
          

        }

        private void MDIParent1_FormClosed(object sender, FormClosedEventArgs e)
        {

         Application.Exit();
           
        }
    }
}
