namespace SBMS.Reports.CrystalReports
{
    partial class LocationEquippedReportViewPort
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
            this.locationReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // locationReportViewer
            // 
            this.locationReportViewer.ActiveViewIndex = -1;
            this.locationReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.locationReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationReportViewer.Location = new System.Drawing.Point(0, 0);
            this.locationReportViewer.Name = "locationReportViewer";
            this.locationReportViewer.Size = new System.Drawing.Size(800, 450);
            this.locationReportViewer.TabIndex = 0;
            // 
            // LocationEquippedReportViewPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.locationReportViewer);
            this.Name = "LocationEquippedReportViewPort";
            this.Text = "LocationEquippedReportViewPort";
            this.Load += new System.EventHandler(this.LocationEquippedReportViewPort_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer locationReportViewer;
    }
}