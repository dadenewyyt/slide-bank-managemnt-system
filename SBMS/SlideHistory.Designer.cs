namespace MSBMS
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
            this.slidesHistoryTableAdapter = new MSBMS.sbmsDataSetTableAdapters.slidesHistoryTableAdapter();
            this.slidehistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.speciescategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sbmsDataSet = new MSBMS.sbmsDataSet();
            this.slidehistoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.speciecespecificsdataBindingSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.speciesstagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.densitycategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.speciesspecificsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgr_allslides = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.speciece_specifics_dataBindingSource = new MSBMS.speciece_specifics_dataBindingSource();
            this.speciesspecificsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.species_specificsTableAdapter = new MSBMS.speciece_specifics_dataBindingSourceTableAdapters.species_specificsTableAdapter();
            this.desnityCat_bindingDataSource = new MSBMS.desnityCat_bindingDataSource();
            this.densitycategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.density_categoryTableAdapter = new MSBMS.desnityCat_bindingDataSourceTableAdapters.density_categoryTableAdapter();
            this.stage_dataBindingSource = new MSBMS.stage_dataBindingSource();
            this.speciesstagesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.species_stagesTableAdapter = new MSBMS.stage_dataBindingSourceTableAdapters.species_stagesTableAdapter();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.old_cabinet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.old_drawer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.old_box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesspecificidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.densitycategoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.speciesstageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.exchangeddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOutExchangedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isWHODataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.slidehistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciescategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidehistoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciecespecificsdataBindingSourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesstagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densitycategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesspecificsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_allslides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speciece_specifics_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesspecificsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desnityCat_bindingDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densitycategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stage_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesstagesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // slidesHistoryTableAdapter
            // 
            this.slidesHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // sbmsDataSet
            // 
            this.sbmsDataSet.DataSetName = "sbmsDataSet";
            this.sbmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // slidehistoryBindingSource2
            // 
            this.slidehistoryBindingSource2.DataMember = "slide_history";
            this.slidehistoryBindingSource2.DataSource = this.sbmsDataSet;
            // 
            // dgr_allslides
            // 
            this.dgr_allslides.AllowUserToOrderColumns = true;
            this.dgr_allslides.AutoGenerateColumns = false;
            this.dgr_allslides.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgr_allslides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_allslides.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.donorcodeDataGridViewTextBoxColumn,
            this.sequenceDataGridViewTextBoxColumn,
            this.countrycodeDataGridViewTextBoxColumn,
            this.old_cabinet,
            this.old_drawer,
            this.old_box,
            this.fname,
            this.lname,
            this.country,
            this.organisation,
            this.speciesspecificidDataGridViewTextBoxColumn,
            this.densitycategoryidDataGridViewTextBoxColumn,
            this.speciesstageidDataGridViewTextBoxColumn,
            this.exchangeddateDataGridViewTextBoxColumn,
            this.exchangedbyDataGridViewTextBoxColumn,
            this.isOutExchangedDataGridViewCheckBoxColumn,
            this.isWHODataGridViewCheckBoxColumn});
            this.dgr_allslides.DataSource = this.slidehistoryBindingSource2;
            this.dgr_allslides.Location = new System.Drawing.Point(11, 18);
            this.dgr_allslides.Name = "dgr_allslides";
            this.dgr_allslides.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgr_allslides.ShowCellErrors = false;
            this.dgr_allslides.ShowCellToolTips = false;
            this.dgr_allslides.ShowRowErrors = false;
            this.dgr_allslides.Size = new System.Drawing.Size(1002, 456);
            this.dgr_allslides.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(378, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Slides Exchange History View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exchaged/checked out slides are not going to be returned on checkin work process." +
    "";
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgr_allslides);
            this.splitContainer1.Size = new System.Drawing.Size(1029, 624);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 17;
            // 
            // speciece_specifics_dataBindingSource
            // 
            this.speciece_specifics_dataBindingSource.DataSetName = "speciece_specifics_dataBindingSource";
            this.speciece_specifics_dataBindingSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // speciesspecificsBindingSource1
            // 
            this.speciesspecificsBindingSource1.DataMember = "species_specifics";
            this.speciesspecificsBindingSource1.DataSource = this.speciece_specifics_dataBindingSource;
            // 
            // species_specificsTableAdapter
            // 
            this.species_specificsTableAdapter.ClearBeforeFill = true;
            // 
            // desnityCat_bindingDataSource
            // 
            this.desnityCat_bindingDataSource.DataSetName = "desnityCat_bindingDataSource";
            this.desnityCat_bindingDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // densitycategoryBindingSource1
            // 
            this.densitycategoryBindingSource1.DataMember = "density_category";
            this.densitycategoryBindingSource1.DataSource = this.desnityCat_bindingDataSource;
            // 
            // density_categoryTableAdapter
            // 
            this.density_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // stage_dataBindingSource
            // 
            this.stage_dataBindingSource.DataSetName = "stage_dataBindingSource";
            this.stage_dataBindingSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // speciesstagesBindingSource1
            // 
            this.speciesstagesBindingSource1.DataMember = "species_stages";
            this.speciesstagesBindingSource1.DataSource = this.stage_dataBindingSource;
            // 
            // species_stagesTableAdapter
            // 
            this.species_stagesTableAdapter.ClearBeforeFill = true;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "bar_code";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // donorcodeDataGridViewTextBoxColumn
            // 
            this.donorcodeDataGridViewTextBoxColumn.DataPropertyName = "donor_code";
            this.donorcodeDataGridViewTextBoxColumn.HeaderText = "Donor";
            this.donorcodeDataGridViewTextBoxColumn.Name = "donorcodeDataGridViewTextBoxColumn";
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            this.sequenceDataGridViewTextBoxColumn.DataPropertyName = "sequence";
            this.sequenceDataGridViewTextBoxColumn.HeaderText = "Sequence";
            this.sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
            // 
            // countrycodeDataGridViewTextBoxColumn
            // 
            this.countrycodeDataGridViewTextBoxColumn.DataPropertyName = "country_code";
            this.countrycodeDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countrycodeDataGridViewTextBoxColumn.Name = "countrycodeDataGridViewTextBoxColumn";
            // 
            // old_cabinet
            // 
            this.old_cabinet.DataPropertyName = "old_cabinet";
            this.old_cabinet.HeaderText = "OldCabinet";
            this.old_cabinet.Name = "old_cabinet";
            // 
            // old_drawer
            // 
            this.old_drawer.DataPropertyName = "old_drawer";
            this.old_drawer.HeaderText = "OldDrawer";
            this.old_drawer.Name = "old_drawer";
            // 
            // old_box
            // 
            this.old_box.DataPropertyName = "old_box";
            this.old_box.HeaderText = "OldBox";
            this.old_box.Name = "old_box";
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            this.fname.HeaderText = "ContactFname";
            this.fname.Name = "fname";
            // 
            // lname
            // 
            this.lname.DataPropertyName = "lname";
            this.lname.HeaderText = "ContactLname";
            this.lname.Name = "lname";
            // 
            // country
            // 
            this.country.DataPropertyName = "country";
            this.country.HeaderText = "CountryOfOrigin";
            this.country.Name = "country";
            // 
            // organisation
            // 
            this.organisation.DataPropertyName = "organisation";
            this.organisation.HeaderText = "Contact Orga";
            this.organisation.Name = "organisation";
            // 
            // speciesspecificidDataGridViewTextBoxColumn
            // 
            this.speciesspecificidDataGridViewTextBoxColumn.DataPropertyName = "species_specific_id";
            this.speciesspecificidDataGridViewTextBoxColumn.DataSource = this.speciesspecificsBindingSource1;
            this.speciesspecificidDataGridViewTextBoxColumn.DisplayMember = "specifics";
            this.speciesspecificidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.speciesspecificidDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesspecificidDataGridViewTextBoxColumn.Name = "speciesspecificidDataGridViewTextBoxColumn";
            this.speciesspecificidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.speciesspecificidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.speciesspecificidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // densitycategoryidDataGridViewTextBoxColumn
            // 
            this.densitycategoryidDataGridViewTextBoxColumn.DataPropertyName = "density_category_id";
            this.densitycategoryidDataGridViewTextBoxColumn.DataSource = this.densitycategoryBindingSource1;
            this.densitycategoryidDataGridViewTextBoxColumn.DisplayMember = "density_category";
            this.densitycategoryidDataGridViewTextBoxColumn.HeaderText = "Density";
            this.densitycategoryidDataGridViewTextBoxColumn.Name = "densitycategoryidDataGridViewTextBoxColumn";
            this.densitycategoryidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.densitycategoryidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.densitycategoryidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // speciesstageidDataGridViewTextBoxColumn
            // 
            this.speciesstageidDataGridViewTextBoxColumn.DataPropertyName = "species_stage_id";
            this.speciesstageidDataGridViewTextBoxColumn.DataSource = this.speciesstagesBindingSource1;
            this.speciesstageidDataGridViewTextBoxColumn.DisplayMember = "stage";
            this.speciesstageidDataGridViewTextBoxColumn.HeaderText = "Stage";
            this.speciesstageidDataGridViewTextBoxColumn.Name = "speciesstageidDataGridViewTextBoxColumn";
            this.speciesstageidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.speciesstageidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.speciesstageidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // exchangeddateDataGridViewTextBoxColumn
            // 
            this.exchangeddateDataGridViewTextBoxColumn.DataPropertyName = "exchanged_date";
            this.exchangeddateDataGridViewTextBoxColumn.HeaderText = "Exchanged";
            this.exchangeddateDataGridViewTextBoxColumn.Name = "exchangeddateDataGridViewTextBoxColumn";
            // 
            // exchangedbyDataGridViewTextBoxColumn
            // 
            this.exchangedbyDataGridViewTextBoxColumn.DataPropertyName = "exchanged_by";
            this.exchangedbyDataGridViewTextBoxColumn.HeaderText = "ExchangedBy";
            this.exchangedbyDataGridViewTextBoxColumn.Name = "exchangedbyDataGridViewTextBoxColumn";
            // 
            // isOutExchangedDataGridViewCheckBoxColumn
            // 
            this.isOutExchangedDataGridViewCheckBoxColumn.DataPropertyName = "isOutExchanged";
            this.isOutExchangedDataGridViewCheckBoxColumn.HeaderText = "isOutExchanged";
            this.isOutExchangedDataGridViewCheckBoxColumn.Name = "isOutExchangedDataGridViewCheckBoxColumn";
            // 
            // isWHODataGridViewCheckBoxColumn
            // 
            this.isWHODataGridViewCheckBoxColumn.DataPropertyName = "isWHO?";
            this.isWHODataGridViewCheckBoxColumn.HeaderText = "isWHO?";
            this.isWHODataGridViewCheckBoxColumn.Name = "isWHODataGridViewCheckBoxColumn";
            // 
            // SlideHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 624);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "SlideHistory";
            this.Text = "SlideHistory";
            this.Load += new System.EventHandler(this.SlideHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slidehistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciescategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidehistoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciecespecificsdataBindingSourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesstagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.densitycategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesspecificsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_allslides)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speciece_specifics_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesspecificsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desnityCat_bindingDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.densitycategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stage_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesstagesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sbmsDataSetTableAdapters.slidesHistoryTableAdapter slidesHistoryTableAdapter;
        private System.Windows.Forms.BindingSource slidehistoryBindingSource;
        private System.Windows.Forms.BindingSource speciescategoryBindingSource;
        private sbmsDataSet sbmsDataSet;
        private System.Windows.Forms.BindingSource slidehistoryBindingSource2;
        private System.Windows.Forms.BindingSource speciecespecificsdataBindingSourceBindingSource;
        private System.Windows.Forms.BindingSource speciesstagesBindingSource;
        private System.Windows.Forms.BindingSource densitycategoryBindingSource;
        private System.Windows.Forms.BindingSource speciesspecificsBindingSource;
        private System.Windows.Forms.DataGridView dgr_allslides;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private speciece_specifics_dataBindingSource speciece_specifics_dataBindingSource;
        private System.Windows.Forms.BindingSource speciesspecificsBindingSource1;
        private speciece_specifics_dataBindingSourceTableAdapters.species_specificsTableAdapter species_specificsTableAdapter;
        private desnityCat_bindingDataSource desnityCat_bindingDataSource;
        private System.Windows.Forms.BindingSource densitycategoryBindingSource1;
        private desnityCat_bindingDataSourceTableAdapters.density_categoryTableAdapter density_categoryTableAdapter;
        private stage_dataBindingSource stage_dataBindingSource;
        private System.Windows.Forms.BindingSource speciesstagesBindingSource1;
        private stage_dataBindingSourceTableAdapters.species_stagesTableAdapter species_stagesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn old_cabinet;
        private System.Windows.Forms.DataGridViewTextBoxColumn old_drawer;
        private System.Windows.Forms.DataGridViewTextBoxColumn old_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn organisation;
        private System.Windows.Forms.DataGridViewComboBoxColumn speciesspecificidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn densitycategoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn speciesstageidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangeddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOutExchangedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isWHODataGridViewCheckBoxColumn;
    }
}