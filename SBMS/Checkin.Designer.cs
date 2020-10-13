namespace MSBMS
{
    partial class Checkin
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
            this.txt_b_create_date = new System.Windows.Forms.TextBox();
            this.txt_bby = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_returned_status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Checkin = new System.Windows.Forms.Button();
            this.txt_due_Date = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_org_borrower = new System.Windows.Forms.TextBox();
            this.txt_b_full_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_checked_out_date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.txt_slide_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_contry_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_donor_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_slide_scan_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speciesspecificsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sbmsDataSet = new MSBMS.sbmsDataSet();
            this.speciescategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.densitycategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desnityCat_bindingDataSource = new MSBMS.desnityCat_bindingDataSource();
            this.currentlendinghistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sbmsDataSet1 = new MSBMS.sbmsDataSet();
            this.density_categoryTableAdapter = new MSBMS.desnityCat_bindingDataSourceTableAdapters.density_categoryTableAdapter();
            this.currentLendingHisotryTableAdapter = new MSBMS.sbmsDataSetTableAdapters.currentLendingHisotryTableAdapter();
            this.species_categoryTableAdapter = new MSBMS.sbmsDataSetTableAdapters.species_categoryTableAdapter();
            this.species_specificsTableAdapter = new MSBMS.sbmsDataSetTableAdapters.species_specificsTableAdapter();
            this.b_created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowed_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checked_out_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.density = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.species_catgeroy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.species = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrycode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slideId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentLendingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grd_checkin_borrowed = new System.Windows.Forms.DataGridView();
            this.btnreload_data = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speciesspecificsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciescategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densitycategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desnityCat_bindingDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentlendinghistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_checkin_borrowed)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(0, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txt_b_create_date);
            this.splitContainer1.Panel2.Controls.Add(this.txt_bby);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.txt_reason);
            this.splitContainer1.Panel2.Controls.Add(this.txt_comment);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_returned_status);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Checkin);
            this.splitContainer1.Panel2.Controls.Add(this.txt_due_Date);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.txt_org_borrower);
            this.splitContainer1.Panel2.Controls.Add(this.txt_b_full_name);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txt_checked_out_date);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txt_barcode);
            this.splitContainer1.Panel2.Controls.Add(this.txt_slide_number);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txt_contry_code);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txt_donor_code);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txt_slide_scan_in);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1321, 257);
            this.splitContainer1.SplitterDistance = 57;
            this.splitContainer1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(366, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "Checkin-Borrowed Slides";
            // 
            // txt_b_create_date
            // 
            this.txt_b_create_date.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_b_create_date.Location = new System.Drawing.Point(718, 155);
            this.txt_b_create_date.Name = "txt_b_create_date";
            this.txt_b_create_date.ReadOnly = true;
            this.txt_b_create_date.Size = new System.Drawing.Size(225, 25);
            this.txt_b_create_date.TabIndex = 27;
            // 
            // txt_bby
            // 
            this.txt_bby.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_bby.Location = new System.Drawing.Point(718, 86);
            this.txt_bby.Name = "txt_bby";
            this.txt_bby.ReadOnly = true;
            this.txt_bby.Size = new System.Drawing.Size(225, 25);
            this.txt_bby.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label15.Location = new System.Drawing.Point(715, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Borrowed Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label14.Location = new System.Drawing.Point(715, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Borrowed By:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label8.Location = new System.Drawing.Point(351, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Reason:";
            // 
            // txt_reason
            // 
            this.txt_reason.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_reason.Location = new System.Drawing.Point(484, 157);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.ReadOnly = true;
            this.txt_reason.Size = new System.Drawing.Size(225, 25);
            this.txt_reason.TabIndex = 22;
            // 
            // txt_comment
            // 
            this.txt_comment.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_comment.Location = new System.Drawing.Point(1051, 52);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(259, 76);
            this.txt_comment.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label13.Location = new System.Drawing.Point(973, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Comment:";
            // 
            // cmb_returned_status
            // 
            this.cmb_returned_status.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.cmb_returned_status.FormattingEnabled = true;
            this.cmb_returned_status.Items.AddRange(new object[] {
            "--Select---",
            "Okay",
            "Damaged",
            "Missing"});
            this.cmb_returned_status.Location = new System.Drawing.Point(1051, 24);
            this.cmb_returned_status.Name = "cmb_returned_status";
            this.cmb_returned_status.Size = new System.Drawing.Size(259, 25);
            this.cmb_returned_status.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label10.Location = new System.Drawing.Point(867, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Slide Status When Retruned:";
            // 
            // btn_Checkin
            // 
            this.btn_Checkin.BackColor = System.Drawing.Color.DimGray;
            this.btn_Checkin.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Checkin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Checkin.Location = new System.Drawing.Point(1051, 134);
            this.btn_Checkin.Name = "btn_Checkin";
            this.btn_Checkin.Size = new System.Drawing.Size(259, 55);
            this.btn_Checkin.TabIndex = 13;
            this.btn_Checkin.Text = "Checkin";
            this.btn_Checkin.UseVisualStyleBackColor = false;
            this.btn_Checkin.Click += new System.EventHandler(this.btn_Checkin_Click);
            // 
            // txt_due_Date
            // 
            this.txt_due_Date.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_due_Date.Location = new System.Drawing.Point(484, 93);
            this.txt_due_Date.Name = "txt_due_Date";
            this.txt_due_Date.ReadOnly = true;
            this.txt_due_Date.Size = new System.Drawing.Size(225, 25);
            this.txt_due_Date.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label11.Location = new System.Drawing.Point(351, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Due Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label12.Location = new System.Drawing.Point(351, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Organisation:";
            // 
            // txt_org_borrower
            // 
            this.txt_org_borrower.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_org_borrower.Location = new System.Drawing.Point(484, 63);
            this.txt_org_borrower.Name = "txt_org_borrower";
            this.txt_org_borrower.ReadOnly = true;
            this.txt_org_borrower.Size = new System.Drawing.Size(225, 25);
            this.txt_org_borrower.TabIndex = 14;
            // 
            // txt_b_full_name
            // 
            this.txt_b_full_name.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_b_full_name.Location = new System.Drawing.Point(484, 32);
            this.txt_b_full_name.Name = "txt_b_full_name";
            this.txt_b_full_name.ReadOnly = true;
            this.txt_b_full_name.Size = new System.Drawing.Size(225, 25);
            this.txt_b_full_name.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label9.Location = new System.Drawing.Point(348, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Borrower Full Name:";
            // 
            // txt_checked_out_date
            // 
            this.txt_checked_out_date.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_checked_out_date.Location = new System.Drawing.Point(484, 124);
            this.txt_checked_out_date.Name = "txt_checked_out_date";
            this.txt_checked_out_date.ReadOnly = true;
            this.txt_checked_out_date.Size = new System.Drawing.Size(225, 25);
            this.txt_checked_out_date.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label6.Location = new System.Drawing.Point(351, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "CheckOut Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label5.Location = new System.Drawing.Point(31, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Barcode:";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_barcode.Location = new System.Drawing.Point(112, 152);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.ReadOnly = true;
            this.txt_barcode.Size = new System.Drawing.Size(222, 25);
            this.txt_barcode.TabIndex = 8;
            // 
            // txt_slide_number
            // 
            this.txt_slide_number.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_slide_number.Location = new System.Drawing.Point(112, 125);
            this.txt_slide_number.Name = "txt_slide_number";
            this.txt_slide_number.ReadOnly = true;
            this.txt_slide_number.Size = new System.Drawing.Size(222, 25);
            this.txt_slide_number.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Slide number:";
            // 
            // txt_contry_code
            // 
            this.txt_contry_code.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_contry_code.Location = new System.Drawing.Point(112, 96);
            this.txt_contry_code.Name = "txt_contry_code";
            this.txt_contry_code.ReadOnly = true;
            this.txt_contry_code.Size = new System.Drawing.Size(222, 25);
            this.txt_contry_code.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Country Code:";
            // 
            // txt_donor_code
            // 
            this.txt_donor_code.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_donor_code.Location = new System.Drawing.Point(112, 67);
            this.txt_donor_code.Name = "txt_donor_code";
            this.txt_donor_code.ReadOnly = true;
            this.txt_donor_code.Size = new System.Drawing.Size(222, 25);
            this.txt_donor_code.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Donor Code:";
            // 
            // txt_slide_scan_in
            // 
            this.txt_slide_scan_in.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_slide_scan_in.Location = new System.Drawing.Point(112, 37);
            this.txt_slide_scan_in.Name = "txt_slide_scan_in";
            this.txt_slide_scan_in.Size = new System.Drawing.Size(222, 25);
            this.txt_slide_scan_in.TabIndex = 1;
            this.txt_slide_scan_in.Click += new System.EventHandler(this.txt_slide_scan_in_Click);
            this.txt_slide_scan_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.find_borrowed_slide);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scan In:";
            // 
            // speciesspecificsBindingSource
            // 
            this.speciesspecificsBindingSource.DataMember = "species_specifics";
            this.speciesspecificsBindingSource.DataSource = this.sbmsDataSet;
            // 
            // sbmsDataSet
            // 
            this.sbmsDataSet.DataSetName = "sbmsDataSet";
            this.sbmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // speciescategoryBindingSource
            // 
            this.speciescategoryBindingSource.DataMember = "species_category";
            this.speciescategoryBindingSource.DataSource = this.sbmsDataSet;
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
            // currentlendinghistoryBindingSource
            // 
            this.currentlendinghistoryBindingSource.DataMember = "current_lending_history";
            this.currentlendinghistoryBindingSource.DataSource = this.sbmsDataSet1;
            // 
            // sbmsDataSet1
            // 
            this.sbmsDataSet1.DataSetName = "sbmsDataSet";
            this.sbmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // density_categoryTableAdapter
            // 
            this.density_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // currentLendingHisotryTableAdapter
            // 
            this.currentLendingHisotryTableAdapter.ClearBeforeFill = true;
            // 
            // species_categoryTableAdapter
            // 
            this.species_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // species_specificsTableAdapter
            // 
            this.species_specificsTableAdapter.ClearBeforeFill = true;
            // 
            // b_created_date
            // 
            this.b_created_date.DataPropertyName = "b_created_date";
            this.b_created_date.HeaderText = "Record_CreatedDate";
            this.b_created_date.Name = "b_created_date";
            // 
            // borrowed_by
            // 
            this.borrowed_by.DataPropertyName = "borrowed_by";
            this.borrowed_by.HeaderText = "BorrowedBy";
            this.borrowed_by.Name = "borrowed_by";
            // 
            // checked_out_date
            // 
            this.checked_out_date.DataPropertyName = "checked_out_date";
            this.checked_out_date.HeaderText = "CheckoutDate";
            this.checked_out_date.Name = "checked_out_date";
            // 
            // duedate
            // 
            this.duedate.DataPropertyName = "due_date";
            this.duedate.HeaderText = "DueDate";
            this.duedate.Name = "duedate";
            // 
            // organisation
            // 
            this.organisation.DataPropertyName = "organisation";
            this.organisation.HeaderText = "Organisation";
            this.organisation.Name = "organisation";
            // 
            // jobtitle
            // 
            this.jobtitle.DataPropertyName = "job_title";
            this.jobtitle.HeaderText = "Postion";
            this.jobtitle.Name = "jobtitle";
            // 
            // lname
            // 
            this.lname.DataPropertyName = "lname";
            this.lname.HeaderText = "BLastname";
            this.lname.Name = "lname";
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            this.fname.HeaderText = "BFname";
            this.fname.Name = "fname";
            // 
            // reason
            // 
            this.reason.DataPropertyName = "reason";
            this.reason.HeaderText = "Reason";
            this.reason.Name = "reason";
            // 
            // box
            // 
            this.box.DataPropertyName = "box_number";
            this.box.HeaderText = "Box";
            this.box.Name = "box";
            // 
            // drawer
            // 
            this.drawer.DataPropertyName = "drawer_number";
            this.drawer.HeaderText = "Drawer";
            this.drawer.Name = "drawer";
            // 
            // cabinet
            // 
            this.cabinet.DataPropertyName = "cabinet_number";
            this.cabinet.HeaderText = "Cabinet";
            this.cabinet.Name = "cabinet";
            // 
            // density
            // 
            this.density.DataPropertyName = "density_category_id";
            this.density.DataSource = this.densitycategoryBindingSource;
            this.density.DisplayMember = "density_category";
            this.density.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.density.HeaderText = "Density";
            this.density.Name = "density";
            this.density.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.density.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.density.ValueMember = "id";
            // 
            // species_catgeroy
            // 
            this.species_catgeroy.DataPropertyName = "species_catgeroy_id";
            this.species_catgeroy.DataSource = this.speciescategoryBindingSource;
            this.species_catgeroy.DisplayMember = "species_category";
            this.species_catgeroy.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.species_catgeroy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.species_catgeroy.HeaderText = "Category";
            this.species_catgeroy.Name = "species_catgeroy";
            this.species_catgeroy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.species_catgeroy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.species_catgeroy.ValueMember = "id";
            // 
            // species
            // 
            this.species.DataPropertyName = "species_specific_id";
            this.species.DataSource = this.speciesspecificsBindingSource;
            this.species.DisplayMember = "specifics";
            this.species.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.species.HeaderText = "Speciecs";
            this.species.Name = "species";
            this.species.ValueMember = "id";
            // 
            // sequence
            // 
            this.sequence.DataPropertyName = "sequence";
            this.sequence.HeaderText = "Sequence";
            this.sequence.Name = "sequence";
            // 
            // countrycode
            // 
            this.countrycode.DataPropertyName = "country_code";
            this.countrycode.HeaderText = "Country";
            this.countrycode.Name = "countrycode";
            // 
            // donorcode
            // 
            this.donorcode.DataPropertyName = "donor_code";
            this.donorcode.HeaderText = "Donor";
            this.donorcode.Name = "donorcode";
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "bar_code";
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            // 
            // slideId
            // 
            this.slideId.DataPropertyName = "slide_id";
            this.slideId.HeaderText = "slideId";
            this.slideId.Name = "slideId";
            this.slideId.Visible = false;
            // 
            // currentLendingId
            // 
            this.currentLendingId.DataPropertyName = "id";
            this.currentLendingId.HeaderText = "id";
            this.currentLendingId.Name = "currentLendingId";
            this.currentLendingId.ReadOnly = true;
            this.currentLendingId.Visible = false;
            // 
            // grd_checkin_borrowed
            // 
            this.grd_checkin_borrowed.AutoGenerateColumns = false;
            this.grd_checkin_borrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_checkin_borrowed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currentLendingId,
            this.slideId,
            this.barcode,
            this.donorcode,
            this.countrycode,
            this.sequence,
            this.species,
            this.species_catgeroy,
            this.density,
            this.cabinet,
            this.drawer,
            this.box,
            this.reason,
            this.fname,
            this.lname,
            this.jobtitle,
            this.organisation,
            this.duedate,
            this.checked_out_date,
            this.borrowed_by,
            this.b_created_date});
            this.grd_checkin_borrowed.DataSource = this.currentlendinghistoryBindingSource;
            this.grd_checkin_borrowed.Location = new System.Drawing.Point(0, 314);
            this.grd_checkin_borrowed.Name = "grd_checkin_borrowed";
            this.grd_checkin_borrowed.Size = new System.Drawing.Size(1321, 427);
            this.grd_checkin_borrowed.TabIndex = 3;
            this.grd_checkin_borrowed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_checkin_borrowed_CellClick);
            // 
            // btnreload_data
            // 
            this.btnreload_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreload_data.Location = new System.Drawing.Point(1199, 266);
            this.btnreload_data.Name = "btnreload_data";
            this.btnreload_data.Size = new System.Drawing.Size(117, 42);
            this.btnreload_data.TabIndex = 12;
            this.btnreload_data.Text = "Refresh";
            this.btnreload_data.UseVisualStyleBackColor = true;
            this.btnreload_data.Click += new System.EventHandler(this.btnreload_data_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1324, 743);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnreload_data);
            this.Controls.Add(this.grd_checkin_borrowed);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Checkin";
            this.Text = "Checkin";
            this.Load += new System.EventHandler(this.Checkin_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speciesspecificsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciescategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.densitycategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desnityCat_bindingDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentlendinghistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_checkin_borrowed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_donor_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_slide_scan_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_checked_out_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.TextBox txt_slide_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_contry_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_due_Date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_org_borrower;
        private System.Windows.Forms.TextBox txt_b_full_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_returned_status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Checkin;
        private sbmsDataSet sbmsDataSet;
        private sbmsDataSetTableAdapters.currentLendingHisotryTableAdapter currentLendingHisotryTableAdapter;
        private System.Windows.Forms.BindingSource speciescategoryBindingSource;
        private sbmsDataSetTableAdapters.species_categoryTableAdapter species_categoryTableAdapter;
        private desnityCat_bindingDataSource desnityCat_bindingDataSource;
        private System.Windows.Forms.BindingSource densitycategoryBindingSource;
        private desnityCat_bindingDataSourceTableAdapters.density_categoryTableAdapter density_categoryTableAdapter;
        private System.Windows.Forms.BindingSource speciesspecificsBindingSource;
        private sbmsDataSetTableAdapters.species_specificsTableAdapter species_specificsTableAdapter;
        private System.Windows.Forms.TextBox txt_b_create_date;
        private System.Windows.Forms.TextBox txt_bby;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_reason;
        private sbmsDataSet sbmsDataSet1;
        private System.Windows.Forms.BindingSource currentlendinghistoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_created_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowed_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn checked_out_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn organisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn box;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinet;
        private System.Windows.Forms.DataGridViewComboBoxColumn density;
        private System.Windows.Forms.DataGridViewComboBoxColumn species_catgeroy;
        private System.Windows.Forms.DataGridViewComboBoxColumn species;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrycode;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn slideId;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentLendingId;
        private System.Windows.Forms.DataGridView grd_checkin_borrowed;
        private System.Windows.Forms.Button btnreload_data;
        private System.Windows.Forms.Button button1;
    }
}