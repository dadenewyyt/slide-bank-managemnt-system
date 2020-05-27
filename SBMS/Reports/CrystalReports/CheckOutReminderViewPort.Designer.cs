namespace MSBMS.Reports.CrystalReports
{
    partial class CheckOutReminderViewPort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckoutRemindercrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CheckoutRemindercrystalReportViewer1
            // 
            this.CheckoutRemindercrystalReportViewer1.ActiveViewIndex = -1;
            this.CheckoutRemindercrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckoutRemindercrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckoutRemindercrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckoutRemindercrystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.CheckoutRemindercrystalReportViewer1.Name = "CheckoutRemindercrystalReportViewer1";
            this.CheckoutRemindercrystalReportViewer1.Size = new System.Drawing.Size(1001, 450);
            this.CheckoutRemindercrystalReportViewer1.TabIndex = 0;
            // 
            // CheckOutReminderViewPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.CheckoutRemindercrystalReportViewer1);
            this.Name = "CheckOutReminderViewPort";
            this.Text = "CheckOutReminderViewPort";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CheckOutReminderViewPort_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CheckoutRemindercrystalReportViewer1;
    }
}