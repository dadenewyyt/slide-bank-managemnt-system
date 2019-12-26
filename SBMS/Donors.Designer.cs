using System.Data.SqlClient;
using System.Windows.Forms;

namespace SBMS
{
    partial class Donors
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
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_donor_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_country_code = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbl_editing_status = new System.Windows.Forms.Label();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.btn_save_edit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_validation = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_upper_density = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_average_density = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_lower_density = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_density_category = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_acquired_date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_owners = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_specice_category = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_specice_stage = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_specice_specifics = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_deactivate = new System.Windows.Forms.Button();
            this.dgr_donors = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesspecificidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.speciesspecificsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.speciece_specifics_dataBindingSource = new SBMS.speciece_specifics_dataBindingSource();
            this.speciesstageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.speciesstagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stage_dataBindingSource = new SBMS.stage_dataBindingSource();
            this.SCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.speciescategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.speciceDataSet = new SBMS.speciceDataSet();
            this.lowerdensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averagedensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upperdensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.densitycategoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.densitycategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desnityCat_bindingDataSource = new SBMS.densityCat_bindingDataSource();
            this.owneridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerDataBindingSource = new SBMS.ownerDataBindingSource();
            this.acquireddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.validationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.validationDataBindingSource = new SBMS.validationDataBindingSource();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.donorsDataSet = new SBMS.donorsDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_search_box = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sbmsDataSet = new SBMS.sbmsDataSet();
            this.donorsTableAdapter = new SBMS.sbmsDataSetTableAdapters.donorsTableAdapter();
            this.sbmsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.species_specificsTableAdapter = new SBMS.speciece_specifics_dataBindingSourceTableAdapters.species_specificsTableAdapter();
            this.species_stagesTableAdapter = new SBMS.stage_dataBindingSourceTableAdapters.species_stagesTableAdapter();
            this.density_categoryTableAdapter = new SBMS.desnityCat_bindingDataSourceTableAdapters.density_categoryTableAdapter();
            this.validationsTableAdapter = new SBMS.validationDataBindingSourceTableAdapters.validationsTableAdapter();
            this.ownersTableAdapter = new SBMS.ownerDataBindingSourceTableAdapters.ownersTableAdapter();
            this.donorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.donorsTableAdapter1 = new SBMS.donorsDataSetTableAdapters.donorsTableAdapter();
            this.species_categoryTableAdapter = new SBMS.speciceDataSetTableAdapters.species_categoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_donors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesspecificsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciece_specifics_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesstagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stage_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciescategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densitycategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desnityCat_bindingDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country code : ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(3, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Panel2.Controls.Add(this.txt_barcode);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txt_donor_code);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txt_country_code);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1248, 172);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Donor Management";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Honeydew;
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(347, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(885, 72);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Extarcting donor and country code from barcode automatically , adding validation " +
    "for duplicate save for donot code or country code , deactivating  a donor or not" +
    " ? ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(344, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "TODO:";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_barcode.Location = new System.Drawing.Point(147, 12);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(178, 25);
            this.txt_barcode.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label5.Location = new System.Drawing.Point(32, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "BarCode Scaned:";
            // 
            // txt_donor_code
            // 
            this.txt_donor_code.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_donor_code.Location = new System.Drawing.Point(147, 41);
            this.txt_donor_code.Name = "txt_donor_code";
            this.txt_donor_code.ShortcutsEnabled = false;
            this.txt_donor_code.Size = new System.Drawing.Size(178, 25);
            this.txt_donor_code.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label4.Location = new System.Drawing.Point(59, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Donor code:";
            // 
            // txt_country_code
            // 
            this.txt_country_code.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_country_code.Location = new System.Drawing.Point(147, 72);
            this.txt_country_code.Name = "txt_country_code";
            this.txt_country_code.ShortcutsEnabled = false;
            this.txt_country_code.Size = new System.Drawing.Size(178, 25);
            this.txt_country_code.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Location = new System.Drawing.Point(3, 190);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbl_editing_status);
            this.splitContainer2.Panel1.Controls.Add(this.txt_comment);
            this.splitContainer2.Panel1.Controls.Add(this.btn_save_edit);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.cmb_validation);
            this.splitContainer2.Panel1.Controls.Add(this.btn_save);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txt_upper_density);
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.txt_average_density);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.txt_lower_density);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.cmb_density_category);
            this.splitContainer2.Panel1.Controls.Add(this.label15);
            this.splitContainer2.Panel1.Controls.Add(this.txt_acquired_date);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.cmb_owners);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.cmb_specice_category);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.cmb_specice_stage);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.cmb_specice_specifics);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.btn_deactivate);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgr_donors);
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Panel2.Controls.Add(this.btn_find);
            this.splitContainer2.Panel2.Controls.Add(this.txt_search_box);
            this.splitContainer2.Panel2.Controls.Add(this.label16);
            this.splitContainer2.Size = new System.Drawing.Size(1248, 428);
            this.splitContainer2.SplitterDistance = 405;
            this.splitContainer2.TabIndex = 3;
            // 
            // lbl_editing_status
            // 
            this.lbl_editing_status.AutoSize = true;
            this.lbl_editing_status.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editing_status.ForeColor = System.Drawing.Color.Brown;
            this.lbl_editing_status.Location = new System.Drawing.Point(14, 392);
            this.lbl_editing_status.Name = "lbl_editing_status";
            this.lbl_editing_status.Size = new System.Drawing.Size(161, 17);
            this.lbl_editing_status.TabIndex = 38;
            this.lbl_editing_status.Text = "Data Editing is now Acive.";
            this.lbl_editing_status.Visible = false;
            // 
            // txt_comment
            // 
            this.txt_comment.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comment.Location = new System.Drawing.Point(147, 299);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(239, 75);
            this.txt_comment.TabIndex = 37;
            // 
            // btn_save_edit
            // 
            this.btn_save_edit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save_edit.Enabled = false;
            this.btn_save_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_edit.Location = new System.Drawing.Point(285, 380);
            this.btn_save_edit.Name = "btn_save_edit";
            this.btn_save_edit.Size = new System.Drawing.Size(101, 38);
            this.btn_save_edit.TabIndex = 9;
            this.btn_save_edit.Text = "Edit/Update";
            this.btn_save_edit.UseVisualStyleBackColor = false;
            this.btn_save_edit.Click += new System.EventHandler(this.btn_save_edit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Comment:";
            // 
            // cmb_validation
            // 
            this.cmb_validation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_validation.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_validation.FormattingEnabled = true;
            this.cmb_validation.Items.AddRange(new object[] {
            "pf",
            "pv",
            "po",
            "pm",
            "pvpf",
            "pmpo"});
            this.cmb_validation.Location = new System.Drawing.Point(147, 269);
            this.cmb_validation.Name = "cmb_validation";
            this.cmb_validation.Size = new System.Drawing.Size(239, 25);
            this.cmb_validation.TabIndex = 35;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(197, 382);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(82, 36);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "Save!";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Validation:";
            // 
            // txt_upper_density
            // 
            this.txt_upper_density.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_upper_density.Location = new System.Drawing.Point(147, 155);
            this.txt_upper_density.Name = "txt_upper_density";
            this.txt_upper_density.Size = new System.Drawing.Size(239, 25);
            this.txt_upper_density.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Upper Density:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_average_density
            // 
            this.txt_average_density.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_average_density.Location = new System.Drawing.Point(147, 129);
            this.txt_average_density.Name = "txt_average_density";
            this.txt_average_density.Size = new System.Drawing.Size(239, 25);
            this.txt_average_density.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Average Density:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_lower_density
            // 
            this.txt_lower_density.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lower_density.Location = new System.Drawing.Point(147, 103);
            this.txt_lower_density.Name = "txt_lower_density";
            this.txt_lower_density.Size = new System.Drawing.Size(239, 25);
            this.txt_lower_density.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Lower Density:";
            // 
            // cmb_density_category
            // 
            this.cmb_density_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_density_category.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_density_category.FormattingEnabled = true;
            this.cmb_density_category.Items.AddRange(new object[] {
            "pf",
            "pv",
            "po",
            "pm",
            "pvpf",
            "pmpo"});
            this.cmb_density_category.Location = new System.Drawing.Point(147, 183);
            this.cmb_density_category.Name = "cmb_density_category";
            this.cmb_density_category.Size = new System.Drawing.Size(239, 25);
            this.cmb_density_category.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Density Catgeory:";
            // 
            // txt_acquired_date
            // 
            this.txt_acquired_date.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_acquired_date.Location = new System.Drawing.Point(147, 240);
            this.txt_acquired_date.Name = "txt_acquired_date";
            this.txt_acquired_date.Size = new System.Drawing.Size(239, 25);
            this.txt_acquired_date.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Aquired Date:";
            // 
            // cmb_owners
            // 
            this.cmb_owners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_owners.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_owners.FormattingEnabled = true;
            this.cmb_owners.Items.AddRange(new object[] {
            "pf",
            "pv",
            "po",
            "pm",
            "pvpf",
            "pmpo"});
            this.cmb_owners.Location = new System.Drawing.Point(147, 212);
            this.cmb_owners.Name = "cmb_owners";
            this.cmb_owners.Size = new System.Drawing.Size(239, 25);
            this.cmb_owners.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Owner";
            // 
            // cmb_specice_category
            // 
            this.cmb_specice_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_specice_category.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_specice_category.FormattingEnabled = true;
            this.cmb_specice_category.Items.AddRange(new object[] {
            "pf",
            "pv",
            "po",
            "pm",
            "pvpf",
            "pmpo"});
            this.cmb_specice_category.Location = new System.Drawing.Point(147, 47);
            this.cmb_specice_category.Name = "cmb_specice_category";
            this.cmb_specice_category.Size = new System.Drawing.Size(239, 25);
            this.cmb_specice_category.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Speices Category";
            // 
            // cmb_specice_stage
            // 
            this.cmb_specice_stage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_specice_stage.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_specice_stage.FormattingEnabled = true;
            this.cmb_specice_stage.Items.AddRange(new object[] {
            "pf",
            "pv",
            "po",
            "pm",
            "pvpf",
            "pmpo"});
            this.cmb_specice_stage.Location = new System.Drawing.Point(147, 75);
            this.cmb_specice_stage.Name = "cmb_specice_stage";
            this.cmb_specice_stage.Size = new System.Drawing.Size(239, 25);
            this.cmb_specice_stage.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Stage:";
            // 
            // cmb_specice_specifics
            // 
            this.cmb_specice_specifics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_specice_specifics.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_specice_specifics.FormattingEnabled = true;
            this.cmb_specice_specifics.Items.AddRange(new object[] {
            "Please select specific"});
            this.cmb_specice_specifics.Location = new System.Drawing.Point(147, 20);
            this.cmb_specice_specifics.Name = "cmb_specice_specifics";
            this.cmb_specice_specifics.Size = new System.Drawing.Size(239, 25);
            this.cmb_specice_specifics.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Speices Specific:";
            // 
            // btn_deactivate
            // 
            this.btn_deactivate.Enabled = false;
            this.btn_deactivate.Location = new System.Drawing.Point(285, 380);
            this.btn_deactivate.Name = "btn_deactivate";
            this.btn_deactivate.Size = new System.Drawing.Size(101, 38);
            this.btn_deactivate.TabIndex = 39;
            this.btn_deactivate.Text = "Deactivate?";
            this.btn_deactivate.UseVisualStyleBackColor = true;
            // 
            // dgr_donors
            // 
            this.dgr_donors.AllowUserToAddRows = false;
            this.dgr_donors.AllowUserToDeleteRows = false;
            this.dgr_donors.AllowUserToOrderColumns = true;
            this.dgr_donors.AutoGenerateColumns = false;
            this.dgr_donors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgr_donors.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgr_donors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_donors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.countrycodeDataGridViewTextBoxColumn,
            this.donorcodeDataGridViewTextBoxColumn,
            this.speciesspecificidDataGridViewTextBoxColumn,
            this.speciesstageidDataGridViewTextBoxColumn,
            this.SCategory,
            this.lowerdensityDataGridViewTextBoxColumn,
            this.averagedensityDataGridViewTextBoxColumn,
            this.upperdensityDataGridViewTextBoxColumn,
            this.densitycategoryidDataGridViewTextBoxColumn,
            this.owneridDataGridViewTextBoxColumn,
            this.acquireddateDataGridViewTextBoxColumn,
            this.validationidDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn,
            this.updatedbyDataGridViewTextBoxColumn,
            this.createddateDataGridViewTextBoxColumn,
            this.updateddateDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgr_donors.DataSource = this.donorsBindingSource2;
            this.dgr_donors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgr_donors.Location = new System.Drawing.Point(12, 41);
            this.dgr_donors.Name = "dgr_donors";
            this.dgr_donors.ReadOnly = true;
            this.dgr_donors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_donors.Size = new System.Drawing.Size(811, 377);
            this.dgr_donors.TabIndex = 30;
            this.dgr_donors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_donors_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "pk_id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "bar_code";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Bar Code";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countrycodeDataGridViewTextBoxColumn
            // 
            this.countrycodeDataGridViewTextBoxColumn.DataPropertyName = "country_code";
            this.countrycodeDataGridViewTextBoxColumn.HeaderText = "Country Code";
            this.countrycodeDataGridViewTextBoxColumn.Name = "countrycodeDataGridViewTextBoxColumn";
            this.countrycodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donorcodeDataGridViewTextBoxColumn
            // 
            this.donorcodeDataGridViewTextBoxColumn.DataPropertyName = "donor_code";
            this.donorcodeDataGridViewTextBoxColumn.HeaderText = "Donor_Code";
            this.donorcodeDataGridViewTextBoxColumn.Name = "donorcodeDataGridViewTextBoxColumn";
            this.donorcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speciesspecificidDataGridViewTextBoxColumn
            // 
            this.speciesspecificidDataGridViewTextBoxColumn.DataPropertyName = "species_specific_id";
            this.speciesspecificidDataGridViewTextBoxColumn.DataSource = this.speciesspecificsBindingSource;
            this.speciesspecificidDataGridViewTextBoxColumn.DisplayMember = "specifics";
            this.speciesspecificidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.speciesspecificidDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speciesspecificidDataGridViewTextBoxColumn.HeaderText = "Specific";
            this.speciesspecificidDataGridViewTextBoxColumn.Name = "speciesspecificidDataGridViewTextBoxColumn";
            this.speciesspecificidDataGridViewTextBoxColumn.ReadOnly = true;
            this.speciesspecificidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.speciesspecificidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.speciesspecificidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // speciesspecificsBindingSource
            // 
            this.speciesspecificsBindingSource.DataMember = "species_specifics";
            this.speciesspecificsBindingSource.DataSource = this.speciece_specifics_dataBindingSource;
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
            this.speciesstageidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.speciesstageidDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speciesstageidDataGridViewTextBoxColumn.HeaderText = "Stage";
            this.speciesstageidDataGridViewTextBoxColumn.Name = "speciesstageidDataGridViewTextBoxColumn";
            this.speciesstageidDataGridViewTextBoxColumn.ReadOnly = true;
            this.speciesstageidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.speciesstageidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.speciesstageidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // speciesstagesBindingSource
            // 
            this.speciesstagesBindingSource.DataMember = "species_stages";
            this.speciesstagesBindingSource.DataSource = this.stage_dataBindingSource;
            // 
            // stage_dataBindingSource
            // 
            this.stage_dataBindingSource.DataSetName = "stage_dataBindingSource";
            this.stage_dataBindingSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SCategory
            // 
            this.SCategory.DataPropertyName = "species_catgeroy_id";
            this.SCategory.DataSource = this.speciescategoryBindingSource;
            this.SCategory.DisplayMember = "species_category";
            this.SCategory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.SCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SCategory.HeaderText = "Category";
            this.SCategory.Name = "SCategory";
            this.SCategory.ReadOnly = true;
            this.SCategory.ValueMember = "id";
            // 
            // speciescategoryBindingSource
            // 
            this.speciescategoryBindingSource.DataMember = "species_category";
            this.speciescategoryBindingSource.DataSource = this.speciceDataSet;
            // 
            // speciceDataSet
            // 
            this.speciceDataSet.DataSetName = "speciceDataSet";
            this.speciceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lowerdensityDataGridViewTextBoxColumn
            // 
            this.lowerdensityDataGridViewTextBoxColumn.DataPropertyName = "lower_density";
            this.lowerdensityDataGridViewTextBoxColumn.HeaderText = "Lower";
            this.lowerdensityDataGridViewTextBoxColumn.Name = "lowerdensityDataGridViewTextBoxColumn";
            this.lowerdensityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // averagedensityDataGridViewTextBoxColumn
            // 
            this.averagedensityDataGridViewTextBoxColumn.DataPropertyName = "average_density";
            this.averagedensityDataGridViewTextBoxColumn.HeaderText = "Average";
            this.averagedensityDataGridViewTextBoxColumn.Name = "averagedensityDataGridViewTextBoxColumn";
            this.averagedensityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // upperdensityDataGridViewTextBoxColumn
            // 
            this.upperdensityDataGridViewTextBoxColumn.DataPropertyName = "upper_density";
            this.upperdensityDataGridViewTextBoxColumn.HeaderText = "Upper";
            this.upperdensityDataGridViewTextBoxColumn.Name = "upperdensityDataGridViewTextBoxColumn";
            this.upperdensityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // densitycategoryidDataGridViewTextBoxColumn
            // 
            this.densitycategoryidDataGridViewTextBoxColumn.DataPropertyName = "density_category_id";
            this.densitycategoryidDataGridViewTextBoxColumn.DataSource = this.densitycategoryBindingSource;
            this.densitycategoryidDataGridViewTextBoxColumn.DisplayMember = "density_category";
            this.densitycategoryidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.densitycategoryidDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.densitycategoryidDataGridViewTextBoxColumn.HeaderText = "Density";
            this.densitycategoryidDataGridViewTextBoxColumn.Name = "densitycategoryidDataGridViewTextBoxColumn";
            this.densitycategoryidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // owneridDataGridViewTextBoxColumn
            // 
            this.owneridDataGridViewTextBoxColumn.DataPropertyName = "owner_id";
            this.owneridDataGridViewTextBoxColumn.DataSource = this.ownersBindingSource;
            this.owneridDataGridViewTextBoxColumn.DisplayMember = "owner";
            this.owneridDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.owneridDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.owneridDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.owneridDataGridViewTextBoxColumn.Name = "owneridDataGridViewTextBoxColumn";
            this.owneridDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.acquireddateDataGridViewTextBoxColumn.HeaderText = "Acquired";
            this.acquireddateDataGridViewTextBoxColumn.Name = "acquireddateDataGridViewTextBoxColumn";
            this.acquireddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // validationidDataGridViewTextBoxColumn
            // 
            this.validationidDataGridViewTextBoxColumn.DataPropertyName = "validation_id";
            this.validationidDataGridViewTextBoxColumn.DataSource = this.validationsBindingSource;
            this.validationidDataGridViewTextBoxColumn.DisplayMember = "validation";
            this.validationidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.validationidDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validationidDataGridViewTextBoxColumn.HeaderText = "Validated?";
            this.validationidDataGridViewTextBoxColumn.Name = "validationidDataGridViewTextBoxColumn";
            this.validationidDataGridViewTextBoxColumn.ReadOnly = true;
            this.validationidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.validationidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.validationidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // validationsBindingSource
            // 
            this.validationsBindingSource.DataMember = "validations";
            this.validationsBindingSource.DataSource = this.validationDataBindingSource;
            // 
            // validationDataBindingSource
            // 
            this.validationDataBindingSource.DataSetName = "validationDataBindingSource";
            this.validationDataBindingSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // createdbyDataGridViewTextBoxColumn
            // 
            this.createdbyDataGridViewTextBoxColumn.DataPropertyName = "created_by";
            this.createdbyDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdbyDataGridViewTextBoxColumn.Name = "createdbyDataGridViewTextBoxColumn";
            this.createdbyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedbyDataGridViewTextBoxColumn
            // 
            this.updatedbyDataGridViewTextBoxColumn.DataPropertyName = "updated_by";
            this.updatedbyDataGridViewTextBoxColumn.HeaderText = "Updated";
            this.updatedbyDataGridViewTextBoxColumn.Name = "updatedbyDataGridViewTextBoxColumn";
            this.updatedbyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createddateDataGridViewTextBoxColumn
            // 
            this.createddateDataGridViewTextBoxColumn.DataPropertyName = "created_date";
            this.createddateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createddateDataGridViewTextBoxColumn.Name = "createddateDataGridViewTextBoxColumn";
            this.createddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateddateDataGridViewTextBoxColumn
            // 
            this.updateddateDataGridViewTextBoxColumn.DataPropertyName = "updated_date";
            this.updateddateDataGridViewTextBoxColumn.HeaderText = "LastUpdatedDate";
            this.updateddateDataGridViewTextBoxColumn.Name = "updateddateDataGridViewTextBoxColumn";
            this.updateddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donorsBindingSource2
            // 
            this.donorsBindingSource2.DataMember = "donors";
            this.donorsBindingSource2.DataSource = this.donorsDataSet;
            // 
            // donorsDataSet
            // 
            this.donorsDataSet.DataSetName = "donorsDataSet";
            this.donorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(635, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 25);
            this.button4.TabIndex = 29;
            this.button4.Text = "Fetch from server";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_find.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.Location = new System.Drawing.Point(239, 7);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 27);
            this.btn_find.TabIndex = 9;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_search_box
            // 
            this.txt_search_box.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_search_box.Location = new System.Drawing.Point(99, 9);
            this.txt_search_box.Name = "txt_search_box";
            this.txt_search_box.Size = new System.Drawing.Size(134, 25);
            this.txt_search_box.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label16.Location = new System.Drawing.Point(9, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Search Donor:";
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "donors";
            this.donorsBindingSource.DataSource = this.sbmsDataSet;
            // 
            // sbmsDataSet
            // 
            this.sbmsDataSet.DataSetName = "sbmsDataSet";
            this.sbmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // sbmsDataSetBindingSource
            // 
            this.sbmsDataSetBindingSource.DataSource = this.sbmsDataSet;
            this.sbmsDataSetBindingSource.Position = 0;
            // 
            // species_specificsTableAdapter
            // 
            this.species_specificsTableAdapter.ClearBeforeFill = true;
            // 
            // species_stagesTableAdapter
            // 
            this.species_stagesTableAdapter.ClearBeforeFill = true;
            // 
            // density_categoryTableAdapter
            // 
            this.density_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // validationsTableAdapter
            // 
            this.validationsTableAdapter.ClearBeforeFill = true;
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // donorsBindingSource1
            // 
            this.donorsBindingSource1.DataMember = "donors";
            this.donorsBindingSource1.DataSource = this.sbmsDataSet;
            // 
            // donorsTableAdapter1
            // 
            this.donorsTableAdapter1.ClearBeforeFill = true;
            // 
            // species_categoryTableAdapter
            // 
            this.species_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // Donors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1261, 622);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Donors";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donors";
            this.Load += new System.EventHandler(this.Donors_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_donors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesspecificsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciece_specifics_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesstagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stage_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciescategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.densitycategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desnityCat_bindingDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_country_code;
        private System.Windows.Forms.TextBox txt_donor_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cmb_specice_stage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_specice_specifics;
        private System.Windows.Forms.Label label6;
   
      
        private System.Windows.Forms.ComboBox cmb_density_category;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker txt_acquired_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_owners;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_specice_category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_search_box;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_save_edit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_validation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_upper_density;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_average_density;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_lower_density;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgr_donors;
        private BindingSource bindingSourceDonorsDataGrid;
        private SqlDataAdapter dataAdapterDonorsDataGridview;
        private sbmsDataSet sbmsDataSet;
        private BindingSource donorsBindingSource;
        private sbmsDataSetTableAdapters.donorsTableAdapter donorsTableAdapter;
        private BindingSource sbmsDataSetBindingSource;
        private speciece_specifics_dataBindingSource speciece_specifics_dataBindingSource;
        private BindingSource speciesspecificsBindingSource;
        private speciece_specifics_dataBindingSourceTableAdapters.species_specificsTableAdapter species_specificsTableAdapter;
        private stage_dataBindingSource stage_dataBindingSource;
        private BindingSource speciesstagesBindingSource;
        private stage_dataBindingSourceTableAdapters.species_stagesTableAdapter species_stagesTableAdapter;
        private densityCat_bindingDataSource desnityCat_bindingDataSource;
        private BindingSource densitycategoryBindingSource;
        private desnityCat_bindingDataSourceTableAdapters.density_categoryTableAdapter density_categoryTableAdapter;
        private validationDataBindingSource validationDataBindingSource;
        private BindingSource validationsBindingSource;
        private validationDataBindingSourceTableAdapters.validationsTableAdapter validationsTableAdapter;
        private ownerDataBindingSource ownerDataBindingSource;
        private BindingSource ownersBindingSource;
        private ownerDataBindingSourceTableAdapters.ownersTableAdapter ownersTableAdapter;
        private BindingSource donorsBindingSource1;
        private donorsDataSet donorsDataSet;
        private BindingSource donorsBindingSource2;
        private donorsDataSetTableAdapters.donorsTableAdapter donorsTableAdapter1;
        private speciceDataSet speciceDataSet;
        private BindingSource speciescategoryBindingSource;
        private speciceDataSetTableAdapters.species_categoryTableAdapter species_categoryTableAdapter;
        private Button btn_deactivate;
        private Label lbl_editing_status;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countrycodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn donorcodeDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn speciesspecificidDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn speciesstageidDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn SCategory;
        private DataGridViewTextBoxColumn lowerdensityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn averagedensityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn upperdensityDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn densitycategoryidDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn owneridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acquireddateDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn validationidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedbyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updateddateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private TextBox textBox1;
        private Label label17;
    }


}