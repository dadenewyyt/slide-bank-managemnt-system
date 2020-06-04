namespace MSBMS
{
    partial class DueDateReminderCheckedOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grd_currentLending = new System.Windows.Forms.DataGridView();
            this.currentlendingduedatepassedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sbmsDataSet = new MSBMS.sbmsDataSet();
            this.btn_print = new System.Windows.Forms.Button();
            this.current_lending_duedate_passed_TableAdapter = new MSBMS.sbmsDataSetTableAdapters.current_lending_duedate_passed_TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinetnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.densitycategoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesspecificidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesstageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedoutdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officalemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_currentLending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentlendingduedatepassedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.grd_currentLending);
            this.splitContainer1.Panel2.Controls.Add(this.btn_print);
            this.splitContainer1.Size = new System.Drawing.Size(1120, 479);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "The following are passed due date checked out slides. Please , take some action.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(523, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alert! - Unreturned Slides Borrowed";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(933, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grd_currentLending
            // 
            this.grd_currentLending.AutoGenerateColumns = false;
            this.grd_currentLending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grd_currentLending.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.grd_currentLending.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grd_currentLending.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_currentLending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_currentLending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.countrycodeDataGridViewTextBoxColumn,
            this.donorcodeDataGridViewTextBoxColumn,
            this.sequenceDataGridViewTextBoxColumn,
            this.cabinetnumberDataGridViewTextBoxColumn,
            this.drawernumberDataGridViewTextBoxColumn,
            this.boxnumberDataGridViewTextBoxColumn,
            this.densitycategoryidDataGridViewTextBoxColumn,
            this.speciesspecificidDataGridViewTextBoxColumn,
            this.speciesstageidDataGridViewTextBoxColumn,
            this.checkedoutdateDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.jobtitleDataGridViewTextBoxColumn,
            this.organisationDataGridViewTextBoxColumn,
            this.officalemailDataGridViewTextBoxColumn,
            this.personalemailDataGridViewTextBoxColumn,
            this.mobilephoneDataGridViewTextBoxColumn,
            this.officephoneDataGridViewTextBoxColumn,
            this.faxnumberDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.grd_currentLending.DataSource = this.currentlendingduedatepassedBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_currentLending.DefaultCellStyle = dataGridViewCellStyle1;
            this.grd_currentLending.Location = new System.Drawing.Point(3, 64);
            this.grd_currentLending.Name = "grd_currentLending";
            this.grd_currentLending.Size = new System.Drawing.Size(1110, 329);
            this.grd_currentLending.TabIndex = 1;
            // 
            // currentlendingduedatepassedBindingSource
            // 
            this.currentlendingduedatepassedBindingSource.DataMember = "current_lending_duedate_passed";
            this.currentlendingduedatepassedBindingSource.DataSource = this.sbmsDataSet;
            // 
            // sbmsDataSet
            // 
            this.sbmsDataSet.DataSetName = "sbmsDataSet";
            this.sbmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.Black;
            this.btn_print.Location = new System.Drawing.Point(3, 11);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(229, 49);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "Print Over Due Slides";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click_1);
            // 
            // current_lending_duedate_passed_TableAdapter
            // 
            this.current_lending_duedate_passed_TableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "bar_code";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Bcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.Width = 63;
            // 
            // countrycodeDataGridViewTextBoxColumn
            // 
            this.countrycodeDataGridViewTextBoxColumn.DataPropertyName = "country_code";
            this.countrycodeDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countrycodeDataGridViewTextBoxColumn.Name = "countrycodeDataGridViewTextBoxColumn";
            this.countrycodeDataGridViewTextBoxColumn.Width = 68;
            // 
            // donorcodeDataGridViewTextBoxColumn
            // 
            this.donorcodeDataGridViewTextBoxColumn.DataPropertyName = "donor_code";
            this.donorcodeDataGridViewTextBoxColumn.HeaderText = "Donor";
            this.donorcodeDataGridViewTextBoxColumn.Name = "donorcodeDataGridViewTextBoxColumn";
            this.donorcodeDataGridViewTextBoxColumn.Width = 61;
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            this.sequenceDataGridViewTextBoxColumn.DataPropertyName = "sequence";
            this.sequenceDataGridViewTextBoxColumn.HeaderText = "Slide Sequence#";
            this.sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
            this.sequenceDataGridViewTextBoxColumn.Width = 105;
            // 
            // cabinetnumberDataGridViewTextBoxColumn
            // 
            this.cabinetnumberDataGridViewTextBoxColumn.DataPropertyName = "cabinet_number";
            this.cabinetnumberDataGridViewTextBoxColumn.HeaderText = "Cabinet#";
            this.cabinetnumberDataGridViewTextBoxColumn.Name = "cabinetnumberDataGridViewTextBoxColumn";
            this.cabinetnumberDataGridViewTextBoxColumn.Width = 75;
            // 
            // drawernumberDataGridViewTextBoxColumn
            // 
            this.drawernumberDataGridViewTextBoxColumn.DataPropertyName = "drawer_number";
            this.drawernumberDataGridViewTextBoxColumn.HeaderText = "Drawer#";
            this.drawernumberDataGridViewTextBoxColumn.Name = "drawernumberDataGridViewTextBoxColumn";
            this.drawernumberDataGridViewTextBoxColumn.Width = 73;
            // 
            // boxnumberDataGridViewTextBoxColumn
            // 
            this.boxnumberDataGridViewTextBoxColumn.DataPropertyName = "box_number";
            this.boxnumberDataGridViewTextBoxColumn.HeaderText = "Box#";
            this.boxnumberDataGridViewTextBoxColumn.Name = "boxnumberDataGridViewTextBoxColumn";
            this.boxnumberDataGridViewTextBoxColumn.Width = 57;
            // 
            // densitycategoryidDataGridViewTextBoxColumn
            // 
            this.densitycategoryidDataGridViewTextBoxColumn.DataPropertyName = "density_category_id";
            this.densitycategoryidDataGridViewTextBoxColumn.HeaderText = "Density";
            this.densitycategoryidDataGridViewTextBoxColumn.Name = "densitycategoryidDataGridViewTextBoxColumn";
            this.densitycategoryidDataGridViewTextBoxColumn.Width = 67;
            // 
            // speciesspecificidDataGridViewTextBoxColumn
            // 
            this.speciesspecificidDataGridViewTextBoxColumn.DataPropertyName = "species_specific_id";
            this.speciesspecificidDataGridViewTextBoxColumn.HeaderText = "Specifics";
            this.speciesspecificidDataGridViewTextBoxColumn.Name = "speciesspecificidDataGridViewTextBoxColumn";
            this.speciesspecificidDataGridViewTextBoxColumn.Width = 75;
            // 
            // speciesstageidDataGridViewTextBoxColumn
            // 
            this.speciesstageidDataGridViewTextBoxColumn.DataPropertyName = "species_stage_id";
            this.speciesstageidDataGridViewTextBoxColumn.HeaderText = "Stage";
            this.speciesstageidDataGridViewTextBoxColumn.Name = "speciesstageidDataGridViewTextBoxColumn";
            this.speciesstageidDataGridViewTextBoxColumn.Width = 60;
            // 
            // checkedoutdateDataGridViewTextBoxColumn
            // 
            this.checkedoutdateDataGridViewTextBoxColumn.DataPropertyName = "checked_out_date";
            this.checkedoutdateDataGridViewTextBoxColumn.HeaderText = "CheckedOutDate";
            this.checkedoutdateDataGridViewTextBoxColumn.Name = "checkedoutdateDataGridViewTextBoxColumn";
            this.checkedoutdateDataGridViewTextBoxColumn.Width = 115;
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "due_date";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            this.duedateDataGridViewTextBoxColumn.Width = 75;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "BorrowReason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.Width = 102;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "BFname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 71;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "BLname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.Width = 71;
            // 
            // jobtitleDataGridViewTextBoxColumn
            // 
            this.jobtitleDataGridViewTextBoxColumn.DataPropertyName = "job_title";
            this.jobtitleDataGridViewTextBoxColumn.HeaderText = "BPostion";
            this.jobtitleDataGridViewTextBoxColumn.Name = "jobtitleDataGridViewTextBoxColumn";
            this.jobtitleDataGridViewTextBoxColumn.Width = 74;
            // 
            // organisationDataGridViewTextBoxColumn
            // 
            this.organisationDataGridViewTextBoxColumn.DataPropertyName = "organisation";
            this.organisationDataGridViewTextBoxColumn.HeaderText = "BOrganisation";
            this.organisationDataGridViewTextBoxColumn.Name = "organisationDataGridViewTextBoxColumn";
            this.organisationDataGridViewTextBoxColumn.Width = 98;
            // 
            // officalemailDataGridViewTextBoxColumn
            // 
            this.officalemailDataGridViewTextBoxColumn.DataPropertyName = "offical_email";
            this.officalemailDataGridViewTextBoxColumn.HeaderText = "BOffice";
            this.officalemailDataGridViewTextBoxColumn.Name = "officalemailDataGridViewTextBoxColumn";
            this.officalemailDataGridViewTextBoxColumn.Width = 67;
            // 
            // personalemailDataGridViewTextBoxColumn
            // 
            this.personalemailDataGridViewTextBoxColumn.DataPropertyName = "personal_email";
            this.personalemailDataGridViewTextBoxColumn.HeaderText = "BPersonal";
            this.personalemailDataGridViewTextBoxColumn.Name = "personalemailDataGridViewTextBoxColumn";
            this.personalemailDataGridViewTextBoxColumn.Width = 80;
            // 
            // mobilephoneDataGridViewTextBoxColumn
            // 
            this.mobilephoneDataGridViewTextBoxColumn.DataPropertyName = "mobile_phone";
            this.mobilephoneDataGridViewTextBoxColumn.HeaderText = "BMobile";
            this.mobilephoneDataGridViewTextBoxColumn.Name = "mobilephoneDataGridViewTextBoxColumn";
            this.mobilephoneDataGridViewTextBoxColumn.Width = 70;
            // 
            // officephoneDataGridViewTextBoxColumn
            // 
            this.officephoneDataGridViewTextBoxColumn.DataPropertyName = "office_phone";
            this.officephoneDataGridViewTextBoxColumn.HeaderText = "BOffice";
            this.officephoneDataGridViewTextBoxColumn.Name = "officephoneDataGridViewTextBoxColumn";
            this.officephoneDataGridViewTextBoxColumn.Width = 67;
            // 
            // faxnumberDataGridViewTextBoxColumn
            // 
            this.faxnumberDataGridViewTextBoxColumn.DataPropertyName = "fax_number";
            this.faxnumberDataGridViewTextBoxColumn.HeaderText = "BFax";
            this.faxnumberDataGridViewTextBoxColumn.Name = "faxnumberDataGridViewTextBoxColumn";
            this.faxnumberDataGridViewTextBoxColumn.Width = 56;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "BCity";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 56;
            // 
            // DueDateReminderCheckedOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1136, 492);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DueDateReminderCheckedOut";
            this.Text = "CheckoutReminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DueDateReminderCheckedOut_FormClosing);
            this.Load += new System.EventHandler(this.CheckoutReminder_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_currentLending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentlendingduedatepassedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grd_currentLending;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_print;
        private sbmsDataSet sbmsDataSet;
        private System.Windows.Forms.BindingSource currentlendingduedatepassedBindingSource;
        private sbmsDataSetTableAdapters.current_lending_duedate_passed_TableAdapter current_lending_duedate_passed_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcreateddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinetnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn densitycategoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesspecificidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesstageidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedoutdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organisationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officalemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}