namespace MSBMS
{
    partial class MDIChild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIChild));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_alert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_replace = new System.Windows.Forms.Button();
            this.btn_user_account = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btn_lending_history = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_archive_summary = new System.Windows.Forms.Button();
            this.btn_all_slides = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_checkin = new System.Windows.Forms.Button();
            this.bn_borrowers = new System.Windows.Forms.Button();
            this.btn_donors = new System.Windows.Forms.Button();
            this.btn_slides = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btn_replacment_history = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 749);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1002, 53);
            this.label1.TabIndex = 30;
            this.label1.Text = "National Archive of Malaria Slides - NAMS";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(3, 195);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_replacment_history);
            this.splitContainer1.Panel2.Controls.Add(this.btn_alert);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btn_replace);
            this.splitContainer1.Panel2.Controls.Add(this.btn_user_account);
            this.splitContainer1.Panel2.Controls.Add(this.button11);
            this.splitContainer1.Panel2.Controls.Add(this.btn_lending_history);
            this.splitContainer1.Panel2.Controls.Add(this.button9);
            this.splitContainer1.Panel2.Controls.Add(this.btn_archive_summary);
            this.splitContainer1.Panel2.Controls.Add(this.btn_all_slides);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.btn_checkout);
            this.splitContainer1.Panel2.Controls.Add(this.btn_checkin);
            this.splitContainer1.Panel2.Controls.Add(this.bn_borrowers);
            this.splitContainer1.Panel2.Controls.Add(this.btn_donors);
            this.splitContainer1.Panel2.Controls.Add(this.btn_slides);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox4);
            this.splitContainer1.Size = new System.Drawing.Size(1255, 551);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.TabIndex = 13;
            // 
            // btn_alert
            // 
            this.btn_alert.BackColor = System.Drawing.Color.Red;
            this.btn_alert.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alert.Location = new System.Drawing.Point(794, 82);
            this.btn_alert.Name = "btn_alert";
            this.btn_alert.Size = new System.Drawing.Size(247, 73);
            this.btn_alert.TabIndex = 29;
            this.btn_alert.Text = "ALERTS!";
            this.btn_alert.UseVisualStyleBackColor = false;
            this.btn_alert.Click += new System.EventHandler(this.btn_alert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(592, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(638, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Software Developed by Daniel Adenew , PMI/MDTA Lead Software Engineer MDTA Projec" +
    "t with PMI/USAID Cooperation, 2020 (C). ";
            // 
            // btn_replace
            // 
            this.btn_replace.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_replace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_replace.Location = new System.Drawing.Point(288, 236);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(247, 74);
            this.btn_replace.TabIndex = 26;
            this.btn_replace.Text = "&Replace Slides";
            this.btn_replace.UseVisualStyleBackColor = false;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // btn_user_account
            // 
            this.btn_user_account.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_user_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_user_account.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_user_account.Location = new System.Drawing.Point(288, 316);
            this.btn_user_account.Name = "btn_user_account";
            this.btn_user_account.Size = new System.Drawing.Size(247, 64);
            this.btn_user_account.TabIndex = 25;
            this.btn_user_account.Text = "&Exchanged Slides";
            this.btn_user_account.UseVisualStyleBackColor = false;
            this.btn_user_account.Click += new System.EventHandler(this.btn_user_account_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.RoyalBlue;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(803, 316);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(238, 64);
            this.button11.TabIndex = 22;
            this.button11.Text = "Reports";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // btn_lending_history
            // 
            this.btn_lending_history.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_lending_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lending_history.Location = new System.Drawing.Point(541, 161);
            this.btn_lending_history.Name = "btn_lending_history";
            this.btn_lending_history.Size = new System.Drawing.Size(500, 69);
            this.btn_lending_history.TabIndex = 21;
            this.btn_lending_history.Text = "&Lending/Borrowed History";
            this.btn_lending_history.UseVisualStyleBackColor = false;
            this.btn_lending_history.Click += new System.EventHandler(this.btn_lending_history_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(803, 236);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(238, 74);
            this.button9.TabIndex = 20;
            this.button9.Text = "&History Of Slides";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_archive_summary
            // 
            this.btn_archive_summary.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_archive_summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_archive_summary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_archive_summary.Location = new System.Drawing.Point(541, 316);
            this.btn_archive_summary.Name = "btn_archive_summary";
            this.btn_archive_summary.Size = new System.Drawing.Size(247, 64);
            this.btn_archive_summary.TabIndex = 19;
            this.btn_archive_summary.Text = "Archive Summary";
            this.btn_archive_summary.UseVisualStyleBackColor = false;
            this.btn_archive_summary.Click += new System.EventHandler(this.btn_archive_summary_Click);
            // 
            // btn_all_slides
            // 
            this.btn_all_slides.BackColor = System.Drawing.Color.LightCoral;
            this.btn_all_slides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_all_slides.ForeColor = System.Drawing.Color.MintCream;
            this.btn_all_slides.Location = new System.Drawing.Point(541, 386);
            this.btn_all_slides.Name = "btn_all_slides";
            this.btn_all_slides.Size = new System.Drawing.Size(500, 80);
            this.btn_all_slides.TabIndex = 18;
            this.btn_all_slides.Text = "All Slides";
            this.btn_all_slides.UseVisualStyleBackColor = false;
            this.btn_all_slides.Click += new System.EventHandler(this.btn_all_slides_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button6.Location = new System.Drawing.Point(288, 82);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(500, 73);
            this.button6.TabIndex = 17;
            this.button6.Text = "&Selection Search Engine";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.Olive;
            this.btn_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.Location = new System.Drawing.Point(288, 386);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(247, 80);
            this.btn_checkout.TabIndex = 16;
            this.btn_checkout.Text = "Single Checkout";
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_checkin
            // 
            this.btn_checkin.BackColor = System.Drawing.Color.LightBlue;
            this.btn_checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkin.Location = new System.Drawing.Point(288, 161);
            this.btn_checkin.Name = "btn_checkin";
            this.btn_checkin.Size = new System.Drawing.Size(247, 69);
            this.btn_checkin.TabIndex = 15;
            this.btn_checkin.Text = "Check-in Slides";
            this.btn_checkin.UseVisualStyleBackColor = false;
            this.btn_checkin.Click += new System.EventHandler(this.btn_checkin_Click);
            // 
            // bn_borrowers
            // 
            this.bn_borrowers.BackColor = System.Drawing.Color.PaleGreen;
            this.bn_borrowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_borrowers.Location = new System.Drawing.Point(794, 10);
            this.bn_borrowers.Name = "bn_borrowers";
            this.bn_borrowers.Size = new System.Drawing.Size(247, 66);
            this.bn_borrowers.TabIndex = 14;
            this.bn_borrowers.Text = "&Contacts";
            this.bn_borrowers.UseVisualStyleBackColor = false;
            this.bn_borrowers.Click += new System.EventHandler(this.bn_borrowers_Click);
            // 
            // btn_donors
            // 
            this.btn_donors.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_donors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_donors.Location = new System.Drawing.Point(288, 10);
            this.btn_donors.Name = "btn_donors";
            this.btn_donors.Size = new System.Drawing.Size(247, 66);
            this.btn_donors.TabIndex = 13;
            this.btn_donors.Text = "Donor Entry";
            this.btn_donors.UseVisualStyleBackColor = false;
            this.btn_donors.Click += new System.EventHandler(this.btn_donors_Click);
            // 
            // btn_slides
            // 
            this.btn_slides.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_slides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_slides.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_slides.Location = new System.Drawing.Point(541, 8);
            this.btn_slides.Name = "btn_slides";
            this.btn_slides.Size = new System.Drawing.Size(247, 68);
            this.btn_slides.TabIndex = 12;
            this.btn_slides.Text = "Slides Entry";
            this.btn_slides.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_slides.UseVisualStyleBackColor = false;
            this.btn_slides.Click += new System.EventHandler(this.btn_slides_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btn_replacment_history
            // 
            this.btn_replacment_history.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_replacment_history.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_replacment_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_replacment_history.ForeColor = System.Drawing.Color.MintCream;
            this.btn_replacment_history.Location = new System.Drawing.Point(541, 236);
            this.btn_replacment_history.Name = "btn_replacment_history";
            this.btn_replacment_history.Size = new System.Drawing.Size(247, 74);
            this.btn_replacment_history.TabIndex = 30;
            this.btn_replacment_history.Text = "R&eplaced Slides History";
            this.btn_replacment_history.UseVisualStyleBackColor = false;
            this.btn_replacment_history.Click += new System.EventHandler(this.btn_replacment_history_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox1.Location = new System.Drawing.Point(3, 202);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(270, 305);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MSBMS.Properties.Resources._2000px_Flag_of_Ethiopia_svg;
            this.pictureBox3.Location = new System.Drawing.Point(244, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(360, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MSBMS.Properties.Resources._27332741_1426914380750443_3640997397741266774_n;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MSBMS.Properties.Resources.Usaid_Icap_logo;
            this.pictureBox2.Location = new System.Drawing.Point(600, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(658, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MSBMS.Properties.Resources.click;
            this.pictureBox4.Location = new System.Drawing.Point(-2, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(275, 182);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // MDIChild
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1261, 749);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDIChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.MDIChild_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_user_account;
        private System.Windows.Forms.Button btn_lending_history;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_archive_summary;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_checkin;
        private System.Windows.Forms.Button btn_donors;
        private System.Windows.Forms.Button btn_slides;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bn_borrowers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_alert;
        private System.Windows.Forms.Button btn_all_slides;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button btn_replacment_history;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}