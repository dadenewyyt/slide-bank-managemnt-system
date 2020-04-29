namespace SBMS
{
    partial class Borrowers
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_pobox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_hno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_pemail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_oemail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fnum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ophone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mphone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_jtitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_org = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear_selection = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgr_borrower = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officalemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upatedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isdeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.borrowersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sbmsDataSet = new SBMS.sbmsDataSet();
            this.borrowersTableAdapter = new SBMS.sbmsDataSetTableAdapters.borrowersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_borrower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(2, 1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label18);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1259, 78);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(403, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(430, 31);
            this.label18.TabIndex = 11;
            this.label18.Text = "Contacts Information Management";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Location = new System.Drawing.Point(2, 85);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btn_delete);
            this.splitContainer2.Panel1.Controls.Add(this.btn_update);
            this.splitContainer2.Panel1.Controls.Add(this.btn_save);
            this.splitContainer2.Panel1.Controls.Add(this.txt_notes);
            this.splitContainer2.Panel1.Controls.Add(this.label17);
            this.splitContainer2.Panel1.Controls.Add(this.txt_pobox);
            this.splitContainer2.Panel1.Controls.Add(this.label16);
            this.splitContainer2.Panel1.Controls.Add(this.txt_hno);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txt_city);
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.txt_country);
            this.splitContainer2.Panel1.Controls.Add(this.label15);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.txt_pemail);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.txt_oemail);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.txt_fnum);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.txt_ophone);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.txt_mphone);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.txt_jtitle);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.txt_org);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.txt_lname);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.txt_fname);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_clear_selection);
            this.splitContainer2.Panel2.Controls.Add(this.label19);
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Panel2.Controls.Add(this.btn_find);
            this.splitContainer2.Panel2.Controls.Add(this.txt_search);
            this.splitContainer2.Panel2.Controls.Add(this.dgr_borrower);
            this.splitContainer2.Size = new System.Drawing.Size(1259, 534);
            this.splitContainer2.SplitterDistance = 369;
            this.splitContainer2.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_delete.Location = new System.Drawing.Point(268, 485);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(64, 38);
            this.btn_delete.TabIndex = 35;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_update.Location = new System.Drawing.Point(190, 485);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(72, 38);
            this.btn_update.TabIndex = 34;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_save.Location = new System.Drawing.Point(120, 485);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(64, 38);
            this.btn_save.TabIndex = 33;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_notes
            // 
            this.txt_notes.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_notes.Location = new System.Drawing.Point(123, 437);
            this.txt_notes.MaxLength = 200;
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(209, 42);
            this.txt_notes.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label17.Location = new System.Drawing.Point(61, 437);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = "Note:";
            // 
            // txt_pobox
            // 
            this.txt_pobox.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_pobox.Location = new System.Drawing.Point(123, 410);
            this.txt_pobox.MaxLength = 10;
            this.txt_pobox.Name = "txt_pobox";
            this.txt_pobox.Size = new System.Drawing.Size(209, 25);
            this.txt_pobox.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label16.Location = new System.Drawing.Point(62, 383);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "H.No";
            // 
            // txt_hno
            // 
            this.txt_hno.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_hno.Location = new System.Drawing.Point(123, 383);
            this.txt_hno.MaxLength = 10;
            this.txt_hno.Name = "txt_hno";
            this.txt_hno.Size = new System.Drawing.Size(209, 25);
            this.txt_hno.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label1.Location = new System.Drawing.Point(39, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "PostalCode:";
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_city.Location = new System.Drawing.Point(123, 359);
            this.txt_city.MaxLength = 10;
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(209, 25);
            this.txt_city.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label14.Location = new System.Drawing.Point(67, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "City:";
            // 
            // txt_country
            // 
            this.txt_country.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_country.Location = new System.Drawing.Point(123, 335);
            this.txt_country.MaxLength = 10;
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(209, 25);
            this.txt_country.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label15.Location = new System.Drawing.Point(48, 338);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 17);
            this.label15.TabIndex = 23;
            this.label15.Text = "Country:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label13.Location = new System.Drawing.Point(120, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Address";
            // 
            // txt_pemail
            // 
            this.txt_pemail.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_pemail.Location = new System.Drawing.Point(120, 281);
            this.txt_pemail.Name = "txt_pemail";
            this.txt_pemail.Size = new System.Drawing.Size(209, 25);
            this.txt_pemail.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label11.Location = new System.Drawing.Point(24, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Personal Email:";
            // 
            // txt_oemail
            // 
            this.txt_oemail.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_oemail.Location = new System.Drawing.Point(120, 255);
            this.txt_oemail.Name = "txt_oemail";
            this.txt_oemail.Size = new System.Drawing.Size(209, 25);
            this.txt_oemail.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label12.Location = new System.Drawing.Point(31, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Offical Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label7.Location = new System.Drawing.Point(120, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Emails";
            // 
            // txt_fnum
            // 
            this.txt_fnum.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_fnum.Location = new System.Drawing.Point(120, 205);
            this.txt_fnum.Name = "txt_fnum";
            this.txt_fnum.Size = new System.Drawing.Size(209, 25);
            this.txt_fnum.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label8.Location = new System.Drawing.Point(36, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fax Number:";
            // 
            // txt_ophone
            // 
            this.txt_ophone.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_ophone.Location = new System.Drawing.Point(120, 181);
            this.txt_ophone.Name = "txt_ophone";
            this.txt_ophone.Size = new System.Drawing.Size(209, 25);
            this.txt_ophone.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label9.Location = new System.Drawing.Point(34, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Office Phone:";
            // 
            // txt_mphone
            // 
            this.txt_mphone.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_mphone.Location = new System.Drawing.Point(120, 155);
            this.txt_mphone.Name = "txt_mphone";
            this.txt_mphone.Size = new System.Drawing.Size(209, 25);
            this.txt_mphone.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label10.Location = new System.Drawing.Point(31, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Mobile Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label6.Location = new System.Drawing.Point(120, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Numbers";
            // 
            // txt_jtitle
            // 
            this.txt_jtitle.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_jtitle.Location = new System.Drawing.Point(123, 97);
            this.txt_jtitle.MaxLength = 20;
            this.txt_jtitle.Name = "txt_jtitle";
            this.txt_jtitle.Size = new System.Drawing.Size(209, 25);
            this.txt_jtitle.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label5.Location = new System.Drawing.Point(53, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Job Title:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_org
            // 
            this.txt_org.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_org.Location = new System.Drawing.Point(123, 71);
            this.txt_org.MaxLength = 30;
            this.txt_org.Name = "txt_org";
            this.txt_org.Size = new System.Drawing.Size(209, 25);
            this.txt_org.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label4.Location = new System.Drawing.Point(34, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Organization:";
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_lname.Location = new System.Drawing.Point(123, 45);
            this.txt_lname.MaxLength = 10;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(209, 25);
            this.txt_lname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label3.Location = new System.Drawing.Point(42, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_fname.Location = new System.Drawing.Point(123, 19);
            this.txt_fname.MaxLength = 10;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(209, 25);
            this.txt_fname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label2.Location = new System.Drawing.Point(43, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // btn_clear_selection
            // 
            this.btn_clear_selection.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clear_selection.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_selection.Location = new System.Drawing.Point(643, 17);
            this.btn_clear_selection.Name = "btn_clear_selection";
            this.btn_clear_selection.Size = new System.Drawing.Size(110, 26);
            this.btn_clear_selection.TabIndex = 43;
            this.btn_clear_selection.Text = "Clear selection";
            this.btn_clear_selection.UseVisualStyleBackColor = false;
            this.btn_clear_selection.Click += new System.EventHandler(this.btn_clear_selection_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label19.Location = new System.Drawing.Point(10, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 17);
            this.label19.TabIndex = 36;
            this.label19.Text = "Borrower:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(759, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 29);
            this.button4.TabIndex = 33;
            this.button4.Text = "Refresh!";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.btn_find.Location = new System.Drawing.Point(379, 13);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(64, 26);
            this.btn_find.TabIndex = 30;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txt_search.Location = new System.Drawing.Point(83, 13);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(290, 25);
            this.txt_search.TabIndex = 31;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_pressed);
            // 
            // dgr_borrower
            // 
            this.dgr_borrower.AutoGenerateColumns = false;
            this.dgr_borrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_borrower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.organisationDataGridViewTextBoxColumn,
            this.jobtitleDataGridViewTextBoxColumn,
            this.officalemailDataGridViewTextBoxColumn,
            this.personalemailDataGridViewTextBoxColumn,
            this.mobilephoneDataGridViewTextBoxColumn,
            this.officephoneDataGridViewTextBoxColumn,
            this.faxnumberDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.hnoDataGridViewTextBoxColumn,
            this.postcodeDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.createddateDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn,
            this.updateddateDataGridViewTextBoxColumn,
            this.upatedbyDataGridViewTextBoxColumn,
            this.isdeletedDataGridViewCheckBoxColumn});
            this.dgr_borrower.DataSource = this.borrowersBindingSource;
            this.dgr_borrower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgr_borrower.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgr_borrower.Location = new System.Drawing.Point(0, 50);
            this.dgr_borrower.MultiSelect = false;
            this.dgr_borrower.Name = "dgr_borrower";
            this.dgr_borrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_borrower.Size = new System.Drawing.Size(882, 480);
            this.dgr_borrower.TabIndex = 0;
            this.dgr_borrower.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_borrower_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // organisationDataGridViewTextBoxColumn
            // 
            this.organisationDataGridViewTextBoxColumn.DataPropertyName = "organisation";
            this.organisationDataGridViewTextBoxColumn.HeaderText = "Organisation";
            this.organisationDataGridViewTextBoxColumn.Name = "organisationDataGridViewTextBoxColumn";
            // 
            // jobtitleDataGridViewTextBoxColumn
            // 
            this.jobtitleDataGridViewTextBoxColumn.DataPropertyName = "job_title";
            this.jobtitleDataGridViewTextBoxColumn.HeaderText = "Position";
            this.jobtitleDataGridViewTextBoxColumn.Name = "jobtitleDataGridViewTextBoxColumn";
            // 
            // officalemailDataGridViewTextBoxColumn
            // 
            this.officalemailDataGridViewTextBoxColumn.DataPropertyName = "offical_email";
            this.officalemailDataGridViewTextBoxColumn.HeaderText = "Office";
            this.officalemailDataGridViewTextBoxColumn.Name = "officalemailDataGridViewTextBoxColumn";
            // 
            // personalemailDataGridViewTextBoxColumn
            // 
            this.personalemailDataGridViewTextBoxColumn.DataPropertyName = "personal_email";
            this.personalemailDataGridViewTextBoxColumn.HeaderText = "Personal";
            this.personalemailDataGridViewTextBoxColumn.Name = "personalemailDataGridViewTextBoxColumn";
            // 
            // mobilephoneDataGridViewTextBoxColumn
            // 
            this.mobilephoneDataGridViewTextBoxColumn.DataPropertyName = "mobile_phone";
            this.mobilephoneDataGridViewTextBoxColumn.HeaderText = "MPhone";
            this.mobilephoneDataGridViewTextBoxColumn.Name = "mobilephoneDataGridViewTextBoxColumn";
            // 
            // officephoneDataGridViewTextBoxColumn
            // 
            this.officephoneDataGridViewTextBoxColumn.DataPropertyName = "office_phone";
            this.officephoneDataGridViewTextBoxColumn.HeaderText = "OfficePhone";
            this.officephoneDataGridViewTextBoxColumn.Name = "officephoneDataGridViewTextBoxColumn";
            // 
            // faxnumberDataGridViewTextBoxColumn
            // 
            this.faxnumberDataGridViewTextBoxColumn.DataPropertyName = "fax_number";
            this.faxnumberDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxnumberDataGridViewTextBoxColumn.Name = "faxnumberDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // hnoDataGridViewTextBoxColumn
            // 
            this.hnoDataGridViewTextBoxColumn.DataPropertyName = "hno";
            this.hnoDataGridViewTextBoxColumn.HeaderText = "H.No";
            this.hnoDataGridViewTextBoxColumn.Name = "hnoDataGridViewTextBoxColumn";
            // 
            // postcodeDataGridViewTextBoxColumn
            // 
            this.postcodeDataGridViewTextBoxColumn.DataPropertyName = "postcode";
            this.postcodeDataGridViewTextBoxColumn.HeaderText = "PoBox";
            this.postcodeDataGridViewTextBoxColumn.Name = "postcodeDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // createddateDataGridViewTextBoxColumn
            // 
            this.createddateDataGridViewTextBoxColumn.DataPropertyName = "created_date";
            this.createddateDataGridViewTextBoxColumn.HeaderText = "created_date";
            this.createddateDataGridViewTextBoxColumn.Name = "createddateDataGridViewTextBoxColumn";
            // 
            // createdbyDataGridViewTextBoxColumn
            // 
            this.createdbyDataGridViewTextBoxColumn.DataPropertyName = "created_by";
            this.createdbyDataGridViewTextBoxColumn.HeaderText = "created_by";
            this.createdbyDataGridViewTextBoxColumn.Name = "createdbyDataGridViewTextBoxColumn";
            // 
            // updateddateDataGridViewTextBoxColumn
            // 
            this.updateddateDataGridViewTextBoxColumn.DataPropertyName = "updated_date";
            this.updateddateDataGridViewTextBoxColumn.HeaderText = "updated_date";
            this.updateddateDataGridViewTextBoxColumn.Name = "updateddateDataGridViewTextBoxColumn";
            // 
            // upatedbyDataGridViewTextBoxColumn
            // 
            this.upatedbyDataGridViewTextBoxColumn.DataPropertyName = "upated_by";
            this.upatedbyDataGridViewTextBoxColumn.HeaderText = "upated_by";
            this.upatedbyDataGridViewTextBoxColumn.Name = "upatedbyDataGridViewTextBoxColumn";
            // 
            // isdeletedDataGridViewCheckBoxColumn
            // 
            this.isdeletedDataGridViewCheckBoxColumn.DataPropertyName = "isdeleted";
            this.isdeletedDataGridViewCheckBoxColumn.HeaderText = "isdeleted";
            this.isdeletedDataGridViewCheckBoxColumn.Name = "isdeletedDataGridViewCheckBoxColumn";
            this.isdeletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // borrowersBindingSource
            // 
            this.borrowersBindingSource.DataMember = "borrowers";
            this.borrowersBindingSource.DataSource = this.sbmsDataSet;
            // 
            // sbmsDataSet
            // 
            this.sbmsDataSet.DataSetName = "sbmsDataSet";
            this.sbmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borrowersTableAdapter
            // 
            this.borrowersTableAdapter.ClearBeforeFill = true;
            // 
            // Borrowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1261, 638);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Borrowers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts Information";
            this.Load += new System.EventHandler(this.Borrowers_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_borrower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txt_jtitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_org;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_pemail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_oemail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fnum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ophone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_mphone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_pobox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_hno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgr_borrower;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private sbmsDataSet sbmsDataSet;
        private System.Windows.Forms.BindingSource borrowersBindingSource;
        private sbmsDataSetTableAdapters.borrowersTableAdapter borrowersTableAdapter;
        private System.Windows.Forms.Button btn_clear_selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organisationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officalemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upatedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isdeletedDataGridViewCheckBoxColumn;
    }
}