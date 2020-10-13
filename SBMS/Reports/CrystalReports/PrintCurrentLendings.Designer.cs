namespace MSBMS.Reports.CrystalReports
{
    partial class PrintCurrentLendings
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
            this.components = new System.ComponentModel.Container();
            this.currentlendinghistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sbmsDataSet = new MSBMS.sbmsDataSet();
            this.currentLendingHisotryTableAdapter = new MSBMS.sbmsDataSetTableAdapters.currentLendingHisotryTableAdapter();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.currentlendinghistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // currentlendinghistoryBindingSource
            // 
            this.currentlendinghistoryBindingSource.DataMember = "current_lending_history";
            this.currentlendinghistoryBindingSource.DataSource = this.sbmsDataSet;
            // 
            // sbmsDataSet
            // 
            this.sbmsDataSet.DataSetName = "sbmsDataSet";
            this.sbmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currentLendingHisotryTableAdapter
            // 
            this.currentLendingHisotryTableAdapter.ClearBeforeFill = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(922, 629);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // PrintCurrentLendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 629);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "PrintCurrentLendings";
            this.Text = "PrintCurrentLendings";
            this.Load += new System.EventHandler(this.PrintCurrentLendings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentlendinghistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private sbmsDataSet sbmsDataSet;
        private System.Windows.Forms.BindingSource currentlendinghistoryBindingSource;
        private sbmsDataSetTableAdapters.currentLendingHisotryTableAdapter currentLendingHisotryTableAdapter;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}