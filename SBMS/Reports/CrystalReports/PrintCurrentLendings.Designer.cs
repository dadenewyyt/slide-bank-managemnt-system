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
            this.grd_currentLending_preview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.sbmsDataSet = new MSBMS.sbmsDataSet();
            this.currentlendinghistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentLendingHisotryTableAdapter = new MSBMS.sbmsDataSetTableAdapters.currentLendingHisotryTableAdapter();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowerdensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averagedensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upperdensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.densitycategoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesspecificidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesstageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinetnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedoutdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.grd_currentLending_preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentlendinghistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_currentLending_preview
            // 
            this.grd_currentLending_preview.AutoGenerateColumns = false;
            this.grd_currentLending_preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grd_currentLending_preview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_currentLending_preview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.sequenceDataGridViewTextBoxColumn,
            this.countrycodeDataGridViewTextBoxColumn,
            this.donorcodeDataGridViewTextBoxColumn,
            this.lowerdensityDataGridViewTextBoxColumn,
            this.averagedensityDataGridViewTextBoxColumn,
            this.upperdensityDataGridViewTextBoxColumn,
            this.densitycategoryidDataGridViewTextBoxColumn,
            this.speciesspecificidDataGridViewTextBoxColumn,
            this.speciesstageidDataGridViewTextBoxColumn,
            this.cabinetnumberDataGridViewTextBoxColumn,
            this.drawernumberDataGridViewTextBoxColumn,
            this.boxnumberDataGridViewTextBoxColumn,
            this.checkedoutdateDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.fname,
            this.lnameDataGridViewTextBoxColumn,
            this.organisationDataGridViewTextBoxColumn,
            this.personalemailDataGridViewTextBoxColumn,
            this.mobilephoneDataGridViewTextBoxColumn,
            this.officephoneDataGridViewTextBoxColumn});
            this.grd_currentLending_preview.DataSource = this.currentlendinghistoryBindingSource;
            this.grd_currentLending_preview.Location = new System.Drawing.Point(1, 42);
            this.grd_currentLending_preview.Name = "grd_currentLending_preview";
            this.grd_currentLending_preview.Size = new System.Drawing.Size(968, 443);
            this.grd_currentLending_preview.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sbmsDataSet
            // 
            this.sbmsDataSet.DataSetName = "sbmsDataSet";
            this.sbmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currentlendinghistoryBindingSource
            // 
            this.currentlendinghistoryBindingSource.DataMember = "current_lending_history";
            this.currentlendinghistoryBindingSource.DataSource = this.sbmsDataSet;
            // 
            // currentLendingHisotryTableAdapter
            // 
            this.currentLendingHisotryTableAdapter.ClearBeforeFill = true;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "bar_code";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "bar_code";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            this.sequenceDataGridViewTextBoxColumn.DataPropertyName = "sequence";
            this.sequenceDataGridViewTextBoxColumn.HeaderText = "sequence";
            this.sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
            // 
            // countrycodeDataGridViewTextBoxColumn
            // 
            this.countrycodeDataGridViewTextBoxColumn.DataPropertyName = "country_code";
            this.countrycodeDataGridViewTextBoxColumn.HeaderText = "country_code";
            this.countrycodeDataGridViewTextBoxColumn.Name = "countrycodeDataGridViewTextBoxColumn";
            // 
            // donorcodeDataGridViewTextBoxColumn
            // 
            this.donorcodeDataGridViewTextBoxColumn.DataPropertyName = "donor_code";
            this.donorcodeDataGridViewTextBoxColumn.HeaderText = "donor_code";
            this.donorcodeDataGridViewTextBoxColumn.Name = "donorcodeDataGridViewTextBoxColumn";
            // 
            // lowerdensityDataGridViewTextBoxColumn
            // 
            this.lowerdensityDataGridViewTextBoxColumn.DataPropertyName = "lower_density";
            this.lowerdensityDataGridViewTextBoxColumn.HeaderText = "lower_density";
            this.lowerdensityDataGridViewTextBoxColumn.Name = "lowerdensityDataGridViewTextBoxColumn";
            // 
            // averagedensityDataGridViewTextBoxColumn
            // 
            this.averagedensityDataGridViewTextBoxColumn.DataPropertyName = "average_density";
            this.averagedensityDataGridViewTextBoxColumn.HeaderText = "average_density";
            this.averagedensityDataGridViewTextBoxColumn.Name = "averagedensityDataGridViewTextBoxColumn";
            // 
            // upperdensityDataGridViewTextBoxColumn
            // 
            this.upperdensityDataGridViewTextBoxColumn.DataPropertyName = "upper_density";
            this.upperdensityDataGridViewTextBoxColumn.HeaderText = "upper_density";
            this.upperdensityDataGridViewTextBoxColumn.Name = "upperdensityDataGridViewTextBoxColumn";
            // 
            // densitycategoryidDataGridViewTextBoxColumn
            // 
            this.densitycategoryidDataGridViewTextBoxColumn.DataPropertyName = "density_category_id";
            this.densitycategoryidDataGridViewTextBoxColumn.HeaderText = "density_category_id";
            this.densitycategoryidDataGridViewTextBoxColumn.Name = "densitycategoryidDataGridViewTextBoxColumn";
            // 
            // speciesspecificidDataGridViewTextBoxColumn
            // 
            this.speciesspecificidDataGridViewTextBoxColumn.DataPropertyName = "species_specific_id";
            this.speciesspecificidDataGridViewTextBoxColumn.HeaderText = "species_specific_id";
            this.speciesspecificidDataGridViewTextBoxColumn.Name = "speciesspecificidDataGridViewTextBoxColumn";
            // 
            // speciesstageidDataGridViewTextBoxColumn
            // 
            this.speciesstageidDataGridViewTextBoxColumn.DataPropertyName = "species_stage_id";
            this.speciesstageidDataGridViewTextBoxColumn.HeaderText = "species_stage_id";
            this.speciesstageidDataGridViewTextBoxColumn.Name = "speciesstageidDataGridViewTextBoxColumn";
            // 
            // cabinetnumberDataGridViewTextBoxColumn
            // 
            this.cabinetnumberDataGridViewTextBoxColumn.DataPropertyName = "cabinet_number";
            this.cabinetnumberDataGridViewTextBoxColumn.HeaderText = "cabinet_number";
            this.cabinetnumberDataGridViewTextBoxColumn.Name = "cabinetnumberDataGridViewTextBoxColumn";
            // 
            // drawernumberDataGridViewTextBoxColumn
            // 
            this.drawernumberDataGridViewTextBoxColumn.DataPropertyName = "drawer_number";
            this.drawernumberDataGridViewTextBoxColumn.HeaderText = "drawer_number";
            this.drawernumberDataGridViewTextBoxColumn.Name = "drawernumberDataGridViewTextBoxColumn";
            // 
            // boxnumberDataGridViewTextBoxColumn
            // 
            this.boxnumberDataGridViewTextBoxColumn.DataPropertyName = "box_number";
            this.boxnumberDataGridViewTextBoxColumn.HeaderText = "box_number";
            this.boxnumberDataGridViewTextBoxColumn.Name = "boxnumberDataGridViewTextBoxColumn";
            // 
            // checkedoutdateDataGridViewTextBoxColumn
            // 
            this.checkedoutdateDataGridViewTextBoxColumn.DataPropertyName = "checked_out_date";
            this.checkedoutdateDataGridViewTextBoxColumn.HeaderText = "checked_out_date";
            this.checkedoutdateDataGridViewTextBoxColumn.Name = "checkedoutdateDataGridViewTextBoxColumn";
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "due_date";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "due_date";
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            this.fname.HeaderText = "fname";
            this.fname.Name = "fname";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // organisationDataGridViewTextBoxColumn
            // 
            this.organisationDataGridViewTextBoxColumn.DataPropertyName = "organisation";
            this.organisationDataGridViewTextBoxColumn.HeaderText = "organisation";
            this.organisationDataGridViewTextBoxColumn.Name = "organisationDataGridViewTextBoxColumn";
            // 
            // personalemailDataGridViewTextBoxColumn
            // 
            this.personalemailDataGridViewTextBoxColumn.DataPropertyName = "personal_email";
            this.personalemailDataGridViewTextBoxColumn.HeaderText = "personal_email";
            this.personalemailDataGridViewTextBoxColumn.Name = "personalemailDataGridViewTextBoxColumn";
            // 
            // mobilephoneDataGridViewTextBoxColumn
            // 
            this.mobilephoneDataGridViewTextBoxColumn.DataPropertyName = "mobile_phone";
            this.mobilephoneDataGridViewTextBoxColumn.HeaderText = "mobile_phone";
            this.mobilephoneDataGridViewTextBoxColumn.Name = "mobilephoneDataGridViewTextBoxColumn";
            // 
            // officephoneDataGridViewTextBoxColumn
            // 
            this.officephoneDataGridViewTextBoxColumn.DataPropertyName = "office_phone";
            this.officephoneDataGridViewTextBoxColumn.HeaderText = "office_phone";
            this.officephoneDataGridViewTextBoxColumn.Name = "officephoneDataGridViewTextBoxColumn";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PrintCurrentLendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grd_currentLending_preview);
            this.Name = "PrintCurrentLendings";
            this.Text = "PrintCurrentLendings";
            this.Load += new System.EventHandler(this.PrintCurrentLendings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_currentLending_preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentlendinghistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_currentLending_preview;
        private System.Windows.Forms.Button button1;
        private sbmsDataSet sbmsDataSet;
        private System.Windows.Forms.BindingSource currentlendinghistoryBindingSource;
        private sbmsDataSetTableAdapters.currentLendingHisotryTableAdapter currentLendingHisotryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowerdensityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averagedensityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upperdensityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn densitycategoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesspecificidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesstageidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinetnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedoutdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organisationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}