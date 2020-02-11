namespace SBMS
{
    partial class SlideHistory
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgr_allslides = new System.Windows.Forms.DataGridView();
            this.sbmsDataSet = new SBMS.sbmsDataSet();
            this.slidehistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slidesHistoryTableAdapter = new SBMS.sbmsDataSetTableAdapters.slidesHistoryTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesstageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciescatgeroyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowerdensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averagedensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upperdensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.densitycategoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owneridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acquireddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinetnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDamagedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isReservedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.updateddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesspecificidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
           
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_allslides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidehistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgr_allslides);
            this.splitContainer1.Size = new System.Drawing.Size(1029, 523);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(378, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Slides History";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(944, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "You can only see slides who are damaged , not active , reserved and deleted from " +
    "the slide bank.";
            // 
            // dgr_allslides
            // 
            this.dgr_allslides.AllowUserToAddRows = false;
            this.dgr_allslides.AllowUserToDeleteRows = false;
            this.dgr_allslides.AllowUserToOrderColumns = true;
            this.dgr_allslides.AutoGenerateColumns = false;
            this.dgr_allslides.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgr_allslides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_allslides.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.donorcodeDataGridViewTextBoxColumn,
            this.sequenceDataGridViewTextBoxColumn,
            this.cabinetnumberDataGridViewTextBoxColumn,
            this.drawernumberDataGridViewTextBoxColumn,
            this.boxnumberDataGridViewTextBoxColumn,
            this.isDamagedDataGridViewCheckBoxColumn,
            this.isReservedDataGridViewCheckBoxColumn,
            this.updateddateDataGridViewTextBoxColumn,
            this.createddateDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn,
            this.speciesspecificidDataGridViewTextBoxColumn,
            this.speciesstageidDataGridViewTextBoxColumn,
            this.speciescatgeroyidDataGridViewTextBoxColumn,
            this.lowerdensityDataGridViewTextBoxColumn,
            this.averagedensityDataGridViewTextBoxColumn,
            this.upperdensityDataGridViewTextBoxColumn,
            this.densitycategoryidDataGridViewTextBoxColumn,
            this.owneridDataGridViewTextBoxColumn,
            this.acquireddateDataGridViewTextBoxColumn,
            this.countrycodeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.validationidDataGridViewTextBoxColumn});
            this.dgr_allslides.DataSource = this.slidehistoryBindingSource;
            this.dgr_allslides.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgr_allslides.Location = new System.Drawing.Point(13, 26);
            this.dgr_allslides.Name = "dgr_allslides";
            this.dgr_allslides.ReadOnly = true;
            this.dgr_allslides.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_allslides.ShowCellErrors = false;
            this.dgr_allslides.ShowCellToolTips = false;
            this.dgr_allslides.ShowEditingIcon = false;
            this.dgr_allslides.ShowRowErrors = false;
            this.dgr_allslides.Size = new System.Drawing.Size(1002, 368);
            this.dgr_allslides.TabIndex = 2;
            // 
            // sbmsDataSet
            // 
            this.sbmsDataSet.DataSetName = "sbmsDataSet";
            this.sbmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // slidehistoryBindingSource
            // 
            this.slidehistoryBindingSource.DataMember = "slide_history";
            this.slidehistoryBindingSource.DataSource = this.sbmsDataSet;
            // 
            // slidesHistoryTableAdapter
            // 
            this.slidesHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "bar_code";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "bar_code";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donorcodeDataGridViewTextBoxColumn
            // 
            this.donorcodeDataGridViewTextBoxColumn.DataPropertyName = "donor_code";
            this.donorcodeDataGridViewTextBoxColumn.HeaderText = "donor_code";
            this.donorcodeDataGridViewTextBoxColumn.Name = "donorcodeDataGridViewTextBoxColumn";
            this.donorcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            this.sequenceDataGridViewTextBoxColumn.DataPropertyName = "sequence";
            this.sequenceDataGridViewTextBoxColumn.HeaderText = "sequence";
            this.sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
            this.sequenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cabinetnumberDataGridViewTextBoxColumn
            // 
            this.cabinetnumberDataGridViewTextBoxColumn.DataPropertyName = "cabinet_number";
            this.cabinetnumberDataGridViewTextBoxColumn.HeaderText = "cabinet_number";
            this.cabinetnumberDataGridViewTextBoxColumn.Name = "cabinetnumberDataGridViewTextBoxColumn";
            this.cabinetnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drawernumberDataGridViewTextBoxColumn
            // 
            this.drawernumberDataGridViewTextBoxColumn.DataPropertyName = "drawer_number";
            this.drawernumberDataGridViewTextBoxColumn.HeaderText = "drawer_number";
            this.drawernumberDataGridViewTextBoxColumn.Name = "drawernumberDataGridViewTextBoxColumn";
            this.drawernumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boxnumberDataGridViewTextBoxColumn
            // 
            this.boxnumberDataGridViewTextBoxColumn.DataPropertyName = "box_number";
            this.boxnumberDataGridViewTextBoxColumn.HeaderText = "box_number";
            this.boxnumberDataGridViewTextBoxColumn.Name = "boxnumberDataGridViewTextBoxColumn";
            this.boxnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDamagedDataGridViewCheckBoxColumn
            // 
            this.isDamagedDataGridViewCheckBoxColumn.DataPropertyName = "isDamaged";
            this.isDamagedDataGridViewCheckBoxColumn.HeaderText = "isDamaged";
            this.isDamagedDataGridViewCheckBoxColumn.Name = "isDamagedDataGridViewCheckBoxColumn";
            this.isDamagedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isReservedDataGridViewCheckBoxColumn
            // 
            this.isReservedDataGridViewCheckBoxColumn.DataPropertyName = "isReserved";
            this.isReservedDataGridViewCheckBoxColumn.HeaderText = "isReserved";
            this.isReservedDataGridViewCheckBoxColumn.Name = "isReservedDataGridViewCheckBoxColumn";
            this.isReservedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // updateddateDataGridViewTextBoxColumn
            // 
            this.updateddateDataGridViewTextBoxColumn.DataPropertyName = "updated_date";
            this.updateddateDataGridViewTextBoxColumn.HeaderText = "updated_date";
            this.updateddateDataGridViewTextBoxColumn.Name = "updateddateDataGridViewTextBoxColumn";
            this.updateddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createddateDataGridViewTextBoxColumn
            // 
            this.createddateDataGridViewTextBoxColumn.DataPropertyName = "created_date";
            this.createddateDataGridViewTextBoxColumn.HeaderText = "created_date";
            this.createddateDataGridViewTextBoxColumn.Name = "createddateDataGridViewTextBoxColumn";
            this.createddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdbyDataGridViewTextBoxColumn
            // 
            this.createdbyDataGridViewTextBoxColumn.DataPropertyName = "created_by";
            this.createdbyDataGridViewTextBoxColumn.HeaderText = "created_by";
            this.createdbyDataGridViewTextBoxColumn.Name = "createdbyDataGridViewTextBoxColumn";
            this.createdbyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speciesspecificidDataGridViewTextBoxColumn
            // 
            this.speciesspecificidDataGridViewTextBoxColumn.DataPropertyName = "species_specific_id";
            this.speciesspecificidDataGridViewTextBoxColumn.HeaderText = "species_specific_id";
            this.speciesspecificidDataGridViewTextBoxColumn.Name = "speciesspecificidDataGridViewTextBoxColumn";
            this.speciesspecificidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speciesstageidDataGridViewTextBoxColumn
            // 
            this.speciesstageidDataGridViewTextBoxColumn.DataPropertyName = "species_stage_id";
            this.speciesstageidDataGridViewTextBoxColumn.HeaderText = "species_stage_id";
            this.speciesstageidDataGridViewTextBoxColumn.Name = "speciesstageidDataGridViewTextBoxColumn";
            this.speciesstageidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speciescatgeroyidDataGridViewTextBoxColumn
            // 
            this.speciescatgeroyidDataGridViewTextBoxColumn.DataPropertyName = "species_catgeroy_id";
            this.speciescatgeroyidDataGridViewTextBoxColumn.HeaderText = "species_catgeroy_id";
            this.speciescatgeroyidDataGridViewTextBoxColumn.Name = "speciescatgeroyidDataGridViewTextBoxColumn";
            this.speciescatgeroyidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lowerdensityDataGridViewTextBoxColumn
            // 
            this.lowerdensityDataGridViewTextBoxColumn.DataPropertyName = "lower_density";
            this.lowerdensityDataGridViewTextBoxColumn.HeaderText = "lower_density";
            this.lowerdensityDataGridViewTextBoxColumn.Name = "lowerdensityDataGridViewTextBoxColumn";
            this.lowerdensityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // averagedensityDataGridViewTextBoxColumn
            // 
            this.averagedensityDataGridViewTextBoxColumn.DataPropertyName = "average_density";
            this.averagedensityDataGridViewTextBoxColumn.HeaderText = "average_density";
            this.averagedensityDataGridViewTextBoxColumn.Name = "averagedensityDataGridViewTextBoxColumn";
            this.averagedensityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // upperdensityDataGridViewTextBoxColumn
            // 
            this.upperdensityDataGridViewTextBoxColumn.DataPropertyName = "upper_density";
            this.upperdensityDataGridViewTextBoxColumn.HeaderText = "upper_density";
            this.upperdensityDataGridViewTextBoxColumn.Name = "upperdensityDataGridViewTextBoxColumn";
            this.upperdensityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // densitycategoryidDataGridViewTextBoxColumn
            // 
            this.densitycategoryidDataGridViewTextBoxColumn.DataPropertyName = "density_category_id";
            this.densitycategoryidDataGridViewTextBoxColumn.HeaderText = "density_category_id";
            this.densitycategoryidDataGridViewTextBoxColumn.Name = "densitycategoryidDataGridViewTextBoxColumn";
            this.densitycategoryidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // owneridDataGridViewTextBoxColumn
            // 
            this.owneridDataGridViewTextBoxColumn.DataPropertyName = "owner_id";
            this.owneridDataGridViewTextBoxColumn.HeaderText = "owner_id";
            this.owneridDataGridViewTextBoxColumn.Name = "owneridDataGridViewTextBoxColumn";
            this.owneridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acquireddateDataGridViewTextBoxColumn
            // 
            this.acquireddateDataGridViewTextBoxColumn.DataPropertyName = "acquired_date";
            this.acquireddateDataGridViewTextBoxColumn.HeaderText = "acquired_date";
            this.acquireddateDataGridViewTextBoxColumn.Name = "acquireddateDataGridViewTextBoxColumn";
            this.acquireddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countrycodeDataGridViewTextBoxColumn
            // 
            this.countrycodeDataGridViewTextBoxColumn.DataPropertyName = "country_code";
            this.countrycodeDataGridViewTextBoxColumn.HeaderText = "country_code";
            this.countrycodeDataGridViewTextBoxColumn.Name = "countrycodeDataGridViewTextBoxColumn";
            this.countrycodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // validationidDataGridViewTextBoxColumn
            // 
            this.validationidDataGridViewTextBoxColumn.DataPropertyName = "validation_id";
            this.validationidDataGridViewTextBoxColumn.HeaderText = "validation_id";
            this.validationidDataGridViewTextBoxColumn.Name = "validationidDataGridViewTextBoxColumn";
            this.validationidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SlideHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 523);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "SlideHistory";
            this.Text = "SlideHistory";
            this.Load += new System.EventHandler(this.SlideHistory_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_allslides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidehistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgr_allslides;
        private sbmsDataSet sbmsDataSet;
        private System.Windows.Forms.BindingSource slidehistoryBindingSource;
        private sbmsDataSetTableAdapters.slidesHistoryTableAdapter slidesHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinetnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDamagedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReservedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesspecificidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesstageidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciescatgeroyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowerdensityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averagedensityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upperdensityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn densitycategoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn owneridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acquireddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validationidDataGridViewTextBoxColumn;
    }
}