namespace MSBMS
{
    partial class Lending
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
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.cmb_borrowers_org = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_borrowers_full_name = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.grd_currentLending = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.densitycategoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.densitycategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desnityCat_bindingDataSource = new MSBMS.desnityCat_bindingDataSource();
            this.speciesspecificidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.speciesspecificsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.speciecespecificsdataBindingSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.speciece_specifics_dataBindingSource = new MSBMS.speciece_specifics_dataBindingSource();
            this.speciesstageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.speciesstagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sbmsDataSet = new MSBMS.sbmsDataSet();
            this.owneridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerDataBindingSource = new MSBMS.ownerDataBindingSource();
            this.acquireddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedoutdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentlendinghistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentlendingpasthistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.density_categoryTableAdapter = new MSBMS.desnityCat_bindingDataSourceTableAdapters.density_categoryTableAdapter();
            this.ownersTableAdapter = new MSBMS.ownerDataBindingSourceTableAdapters.ownersTableAdapter();
            this.species_specificsTableAdapter = new MSBMS.speciece_specifics_dataBindingSourceTableAdapters.species_specificsTableAdapter();
            this.currentLendingHisotryTableAdapter = new MSBMS.sbmsDataSetTableAdapters.currentLendingHisotryTableAdapter();
            this.borrower_contact_listTableAdapter = new MSBMS.sbmsDataSetTableAdapters.borrower_contact_listTableAdapter();
            this.species_stagesTableAdapter = new MSBMS.sbmsDataSetTableAdapters.species_stagesTableAdapter();
            this.current_lending_past_historyTableAdapter = new MSBMS.sbmsDataSetTableAdapters.current_lending_past_historyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_currentLending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densitycategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desnityCat_bindingDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesspecificsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciecespecificsdataBindingSourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciece_specifics_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesstagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentlendinghistoryBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentlendingpasthistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label18);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_find);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_borrowers_org);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_borrowers_full_name);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1391, 153);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(328, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(642, 33);
            this.label18.TabIndex = 11;
            this.label18.Text = "Current Borrowed Slides and Lending History";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(437, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search and Filter";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(231, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Organisation";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(722, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "Find!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.Location = new System.Drawing.Point(722, 26);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(81, 26);
            this.btn_find.TabIndex = 13;
            this.btn_find.Text = "Find!";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // cmb_borrowers_org
            // 
            this.cmb_borrowers_org.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.cmb_borrowers_org.FormattingEnabled = true;
            this.cmb_borrowers_org.Location = new System.Drawing.Point(346, 57);
            this.cmb_borrowers_org.Name = "cmb_borrowers_org";
            this.cmb_borrowers_org.Size = new System.Drawing.Size(370, 25);
            this.cmb_borrowers_org.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(253, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Full Name";
            // 
            // cmb_borrowers_full_name
            // 
            this.cmb_borrowers_full_name.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.cmb_borrowers_full_name.FormattingEnabled = true;
            this.cmb_borrowers_full_name.Location = new System.Drawing.Point(346, 28);
            this.cmb_borrowers_full_name.Name = "cmb_borrowers_full_name";
            this.cmb_borrowers_full_name.Size = new System.Drawing.Size(370, 25);
            this.cmb_borrowers_full_name.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1395, 495);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.grd_currentLending);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1387, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Active Lendings";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(9, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Print!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grd_currentLending
            // 
            this.grd_currentLending.AutoGenerateColumns = false;
            this.grd_currentLending.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grd_currentLending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_currentLending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.countrycodeDataGridViewTextBoxColumn,
            this.donorcodeDataGridViewTextBoxColumn,
            this.sequenceDataGridViewTextBoxColumn,
            this.densitycategoryidDataGridViewTextBoxColumn,
            this.speciesspecificidDataGridViewTextBoxColumn,
            this.speciesstageidDataGridViewTextBoxColumn,
            this.owneridDataGridViewTextBoxColumn,
            this.acquireddateDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.organisationDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.checkedoutdateDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn});
            this.grd_currentLending.DataSource = this.currentlendinghistoryBindingSource;
            this.grd_currentLending.Location = new System.Drawing.Point(9, 44);
            this.grd_currentLending.Name = "grd_currentLending";
            this.grd_currentLending.Size = new System.Drawing.Size(1376, 460);
            this.grd_currentLending.TabIndex = 0;
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
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "BCode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // countrycodeDataGridViewTextBoxColumn
            // 
            this.countrycodeDataGridViewTextBoxColumn.DataPropertyName = "country_code";
            this.countrycodeDataGridViewTextBoxColumn.HeaderText = "Ccode";
            this.countrycodeDataGridViewTextBoxColumn.Name = "countrycodeDataGridViewTextBoxColumn";
            // 
            // donorcodeDataGridViewTextBoxColumn
            // 
            this.donorcodeDataGridViewTextBoxColumn.DataPropertyName = "donor_code";
            this.donorcodeDataGridViewTextBoxColumn.HeaderText = "Dcode";
            this.donorcodeDataGridViewTextBoxColumn.Name = "donorcodeDataGridViewTextBoxColumn";
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            this.sequenceDataGridViewTextBoxColumn.DataPropertyName = "sequence";
            this.sequenceDataGridViewTextBoxColumn.HeaderText = "Seq#";
            this.sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
            // 
            // densitycategoryidDataGridViewTextBoxColumn
            // 
            this.densitycategoryidDataGridViewTextBoxColumn.DataPropertyName = "density_category_id";
            this.densitycategoryidDataGridViewTextBoxColumn.DataSource = this.densitycategoryBindingSource;
            this.densitycategoryidDataGridViewTextBoxColumn.DisplayMember = "density_category";
            this.densitycategoryidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.densitycategoryidDataGridViewTextBoxColumn.HeaderText = "Density";
            this.densitycategoryidDataGridViewTextBoxColumn.Name = "densitycategoryidDataGridViewTextBoxColumn";
            this.densitycategoryidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.densitycategoryidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.densitycategoryidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // densitycategoryBindingSource
            // 
            this.densitycategoryBindingSource.DataMember = "density_category";
            this.densitycategoryBindingSource.DataSource = this.desnityCat_bindingDataSource;
            // 
            // desnityCat_bindingDataSource
            // 
            this.desnityCat_bindingDataSource.DataSetName = "desnityCat_bindingDataSource";
            this.desnityCat_bindingDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // speciesspecificidDataGridViewTextBoxColumn
            // 
            this.speciesspecificidDataGridViewTextBoxColumn.DataPropertyName = "species_specific_id";
            this.speciesspecificidDataGridViewTextBoxColumn.DataSource = this.speciesspecificsBindingSource;
            this.speciesspecificidDataGridViewTextBoxColumn.DisplayMember = "specifics";
            this.speciesspecificidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.speciesspecificidDataGridViewTextBoxColumn.HeaderText = "Speciecs";
            this.speciesspecificidDataGridViewTextBoxColumn.Name = "speciesspecificidDataGridViewTextBoxColumn";
            this.speciesspecificidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.speciesspecificidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.speciesspecificidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // speciesspecificsBindingSource
            // 
            this.speciesspecificsBindingSource.DataMember = "species_specifics";
            this.speciesspecificsBindingSource.DataSource = this.speciecespecificsdataBindingSourceBindingSource;
            // 
            // speciecespecificsdataBindingSourceBindingSource
            // 
            this.speciecespecificsdataBindingSourceBindingSource.DataSource = this.speciece_specifics_dataBindingSource;
            this.speciecespecificsdataBindingSourceBindingSource.Position = 0;
            // 
            // speciece_specifics_dataBindingSource
            // 
            this.speciece_specifics_dataBindingSource.DataSetName = "speciece_specifics_dataBindingSource";
            this.speciece_specifics_dataBindingSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // speciesstageidDataGridViewTextBoxColumn
            // 
            this.speciesstageidDataGridViewTextBoxColumn.DataPropertyName = "species_stage_id";
            this.speciesstageidDataGridViewTextBoxColumn.DataSource = this.speciesstagesBindingSource;
            this.speciesstageidDataGridViewTextBoxColumn.DisplayMember = "stage";
            this.speciesstageidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.speciesstageidDataGridViewTextBoxColumn.HeaderText = "Stage";
            this.speciesstageidDataGridViewTextBoxColumn.Name = "speciesstageidDataGridViewTextBoxColumn";
            this.speciesstageidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.speciesstageidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.speciesstageidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // speciesstagesBindingSource
            // 
            this.speciesstagesBindingSource.DataMember = "species_stages";
            this.speciesstagesBindingSource.DataSource = this.sbmsDataSet;
            // 
            // sbmsDataSet
            // 
            this.sbmsDataSet.DataSetName = "sbmsDataSet";
            this.sbmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // owneridDataGridViewTextBoxColumn
            // 
            this.owneridDataGridViewTextBoxColumn.DataPropertyName = "owner_id";
            this.owneridDataGridViewTextBoxColumn.DataSource = this.ownersBindingSource;
            this.owneridDataGridViewTextBoxColumn.DisplayMember = "owner";
            this.owneridDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.owneridDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.owneridDataGridViewTextBoxColumn.Name = "owneridDataGridViewTextBoxColumn";
            this.owneridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.owneridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.owneridDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataMember = "owners";
            this.ownersBindingSource.DataSource = this.ownerDataBindingSource;
            // 
            // ownerDataBindingSource
            // 
            this.ownerDataBindingSource.DataSetName = "ownerDataBindingSource";
            this.ownerDataBindingSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acquireddateDataGridViewTextBoxColumn
            // 
            this.acquireddateDataGridViewTextBoxColumn.DataPropertyName = "acquired_date";
            this.acquireddateDataGridViewTextBoxColumn.HeaderText = "Adate";
            this.acquireddateDataGridViewTextBoxColumn.Name = "acquireddateDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Borrower Fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Borrower Lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // organisationDataGridViewTextBoxColumn
            // 
            this.organisationDataGridViewTextBoxColumn.DataPropertyName = "organisation";
            this.organisationDataGridViewTextBoxColumn.HeaderText = "Borrower Orga";
            this.organisationDataGridViewTextBoxColumn.Name = "organisationDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Borrowed Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // checkedoutdateDataGridViewTextBoxColumn
            // 
            this.checkedoutdateDataGridViewTextBoxColumn.DataPropertyName = "checked_out_date";
            this.checkedoutdateDataGridViewTextBoxColumn.HeaderText = "CheckedOut?";
            this.checkedoutdateDataGridViewTextBoxColumn.Name = "checkedoutdateDataGridViewTextBoxColumn";
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "due_date";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "Due Date";
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            // 
            // currentlendinghistoryBindingSource
            // 
            this.currentlendinghistoryBindingSource.DataMember = "current_lending_history";
            this.currentlendinghistoryBindingSource.DataSource = this.sbmsDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1387, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Lending History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewComboBoxColumn3,
            this.dataGridViewComboBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView1.DataSource = this.currentlendingpasthistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1376, 460);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "bar_code";
            this.dataGridViewTextBoxColumn2.HeaderText = "BCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "country_code";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ccode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "donor_code";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dcode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sequence";
            this.dataGridViewTextBoxColumn5.HeaderText = "Seq#";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "density_category_id";
            this.dataGridViewComboBoxColumn1.DataSource = this.densitycategoryBindingSource;
            this.dataGridViewComboBoxColumn1.DisplayMember = "density_category";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.HeaderText = "Density";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.ValueMember = "id";
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "species_specific_id";
            this.dataGridViewComboBoxColumn2.DataSource = this.speciesspecificsBindingSource;
            this.dataGridViewComboBoxColumn2.DisplayMember = "specifics";
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn2.HeaderText = "Speciecs";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.ValueMember = "id";
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.DataPropertyName = "species_stage_id";
            this.dataGridViewComboBoxColumn3.DataSource = this.speciesstagesBindingSource;
            this.dataGridViewComboBoxColumn3.DisplayMember = "stage";
            this.dataGridViewComboBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn3.HeaderText = "Stage";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn3.ValueMember = "id";
            // 
            // dataGridViewComboBoxColumn4
            // 
            this.dataGridViewComboBoxColumn4.DataPropertyName = "owner_id";
            this.dataGridViewComboBoxColumn4.DataSource = this.ownersBindingSource;
            this.dataGridViewComboBoxColumn4.DisplayMember = "owner";
            this.dataGridViewComboBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn4.HeaderText = "Owner";
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn4.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "acquired_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn7.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fname";
            this.dataGridViewTextBoxColumn8.HeaderText = "Borrower Fname";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "lname";
            this.dataGridViewTextBoxColumn9.HeaderText = "Borrower Lname";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "organisation";
            this.dataGridViewTextBoxColumn10.HeaderText = "Borrower Orga";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "reason";
            this.dataGridViewTextBoxColumn11.HeaderText = "Borrowed Reason";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "checked_out_date";
            this.dataGridViewTextBoxColumn12.HeaderText = "CheckedOut?";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "due_date";
            this.dataGridViewTextBoxColumn13.HeaderText = "Due Date";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // currentlendingpasthistoryBindingSource
            // 
            this.currentlendingpasthistoryBindingSource.DataMember = "current_lending_past_history";
            this.currentlendingpasthistoryBindingSource.DataSource = this.sbmsDataSet;
            // 
            // density_categoryTableAdapter
            // 
            this.density_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // species_specificsTableAdapter
            // 
            this.species_specificsTableAdapter.ClearBeforeFill = true;
            // 
            // currentLendingHisotryTableAdapter
            // 
            this.currentLendingHisotryTableAdapter.ClearBeforeFill = true;
            // 
            // borrower_contact_listTableAdapter
            // 
            this.borrower_contact_listTableAdapter.ClearBeforeFill = true;
            // 
            // species_stagesTableAdapter
            // 
            this.species_stagesTableAdapter.ClearBeforeFill = true;
            // 
            // current_lending_past_historyTableAdapter
            // 
            this.current_lending_past_historyTableAdapter.ClearBeforeFill = true;
            // 
            // Lending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1395, 660);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Lending";
            this.Text = "Lending";
            this.Load += new System.EventHandler(this.Lending_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_currentLending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.densitycategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desnityCat_bindingDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesspecificsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciecespecificsdataBindingSourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciece_specifics_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesstagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentlendinghistoryBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentlendingpasthistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private sbmsDataSetTableAdapters.borrower_contact_listTableAdapter borrower_contact_listTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmb_borrowers_full_name;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grd_currentLending;
        private sbmsDataSet sbmsDataSet;
        private System.Windows.Forms.BindingSource currentlendinghistoryBindingSource;
        private sbmsDataSetTableAdapters.currentLendingHisotryTableAdapter currentLendingHisotryTableAdapter;
        private desnityCat_bindingDataSource desnityCat_bindingDataSource;
        private System.Windows.Forms.BindingSource densitycategoryBindingSource;
        private desnityCat_bindingDataSourceTableAdapters.density_categoryTableAdapter density_categoryTableAdapter;
        private System.Windows.Forms.BindingSource speciesstagesBindingSource;
        private sbmsDataSetTableAdapters.species_stagesTableAdapter species_stagesTableAdapter;
        private ownerDataBindingSource ownerDataBindingSource;
        private System.Windows.Forms.BindingSource ownersBindingSource;
        private ownerDataBindingSourceTableAdapters.ownersTableAdapter ownersTableAdapter;
        private speciece_specifics_dataBindingSource speciece_specifics_dataBindingSource;
        private System.Windows.Forms.BindingSource speciecespecificsdataBindingSourceBindingSource;
        private System.Windows.Forms.BindingSource speciesspecificsBindingSource;
        private speciece_specifics_dataBindingSourceTableAdapters.species_specificsTableAdapter species_specificsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn densitycategoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn speciesspecificidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn speciesstageidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn owneridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acquireddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organisationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedoutdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.ComboBox cmb_borrowers_org;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource currentlendingpasthistoryBindingSource;
        private sbmsDataSetTableAdapters.current_lending_past_historyTableAdapter current_lending_past_historyTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}