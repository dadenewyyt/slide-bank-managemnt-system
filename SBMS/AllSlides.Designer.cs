namespace SBMS
{
    partial class AllSlides
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sbmsDataSet = new SBMS.sbmsDataSet();
            this.slidesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slidesTableAdapter = new SBMS.sbmsDataSetTableAdapters.slidesTableAdapter();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinetnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDamagedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isReservedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isBorrowedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesspecificidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesstageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciescatgeroyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowerdensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averagedensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upperdensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.densitycategoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owneridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acquireddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(1, 2);
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
            this.splitContainer1.Size = new System.Drawing.Size(1259, 222);
            this.splitContainer1.SplitterDistance = 57;
            this.splitContainer1.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(444, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(312, 33);
            this.label18.TabIndex = 11;
            this.label18.Text = "All Slides Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 539);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 43);
            this.button2.TabIndex = 44;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.donorcodeDataGridViewTextBoxColumn,
            this.countrycodeDataGridViewTextBoxColumn,
            this.sequenceDataGridViewTextBoxColumn,
            this.cabinetnumberDataGridViewTextBoxColumn,
            this.drawernumberDataGridViewTextBoxColumn,
            this.boxnumberDataGridViewTextBoxColumn,
            this.isDamagedDataGridViewCheckBoxColumn,
            this.isReservedDataGridViewCheckBoxColumn,
            this.isBorrowedDataGridViewCheckBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
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
            this.commentDataGridViewTextBoxColumn,
            this.validationidDataGridViewTextBoxColumn,
            this.updatedbyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.slidesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1255, 487);
            this.dataGridView1.TabIndex = 0;
            // 
            // sbmsDataSet
            // 
            this.sbmsDataSet.DataSetName = "sbmsDataSet";
            this.sbmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // slidesBindingSource
            // 
            this.slidesBindingSource.DataMember = "slides";
            this.slidesBindingSource.DataSource = this.sbmsDataSet;
            // 
            // slidesTableAdapter
            // 
            this.slidesTableAdapter.ClearBeforeFill = true;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "bar_code";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "bar_code";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // donorcodeDataGridViewTextBoxColumn
            // 
            this.donorcodeDataGridViewTextBoxColumn.DataPropertyName = "donor_code";
            this.donorcodeDataGridViewTextBoxColumn.HeaderText = "donor_code";
            this.donorcodeDataGridViewTextBoxColumn.Name = "donorcodeDataGridViewTextBoxColumn";
            // 
            // countrycodeDataGridViewTextBoxColumn
            // 
            this.countrycodeDataGridViewTextBoxColumn.DataPropertyName = "country_code";
            this.countrycodeDataGridViewTextBoxColumn.HeaderText = "country_code";
            this.countrycodeDataGridViewTextBoxColumn.Name = "countrycodeDataGridViewTextBoxColumn";
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            this.sequenceDataGridViewTextBoxColumn.DataPropertyName = "sequence";
            this.sequenceDataGridViewTextBoxColumn.HeaderText = "sequence";
            this.sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
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
            // isDamagedDataGridViewCheckBoxColumn
            // 
            this.isDamagedDataGridViewCheckBoxColumn.DataPropertyName = "isDamaged";
            this.isDamagedDataGridViewCheckBoxColumn.HeaderText = "isDamaged";
            this.isDamagedDataGridViewCheckBoxColumn.Name = "isDamagedDataGridViewCheckBoxColumn";
            // 
            // isReservedDataGridViewCheckBoxColumn
            // 
            this.isReservedDataGridViewCheckBoxColumn.DataPropertyName = "isReserved";
            this.isReservedDataGridViewCheckBoxColumn.HeaderText = "isReserved";
            this.isReservedDataGridViewCheckBoxColumn.Name = "isReservedDataGridViewCheckBoxColumn";
            // 
            // isBorrowedDataGridViewCheckBoxColumn
            // 
            this.isBorrowedDataGridViewCheckBoxColumn.DataPropertyName = "isBorrowed";
            this.isBorrowedDataGridViewCheckBoxColumn.HeaderText = "isBorrowed";
            this.isBorrowedDataGridViewCheckBoxColumn.Name = "isBorrowedDataGridViewCheckBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
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
            // speciescatgeroyidDataGridViewTextBoxColumn
            // 
            this.speciescatgeroyidDataGridViewTextBoxColumn.DataPropertyName = "species_catgeroy_id";
            this.speciescatgeroyidDataGridViewTextBoxColumn.HeaderText = "species_catgeroy_id";
            this.speciescatgeroyidDataGridViewTextBoxColumn.Name = "speciescatgeroyidDataGridViewTextBoxColumn";
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
            // owneridDataGridViewTextBoxColumn
            // 
            this.owneridDataGridViewTextBoxColumn.DataPropertyName = "owner_id";
            this.owneridDataGridViewTextBoxColumn.HeaderText = "owner_id";
            this.owneridDataGridViewTextBoxColumn.Name = "owneridDataGridViewTextBoxColumn";
            // 
            // acquireddateDataGridViewTextBoxColumn
            // 
            this.acquireddateDataGridViewTextBoxColumn.DataPropertyName = "acquired_date";
            this.acquireddateDataGridViewTextBoxColumn.HeaderText = "acquired_date";
            this.acquireddateDataGridViewTextBoxColumn.Name = "acquireddateDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // validationidDataGridViewTextBoxColumn
            // 
            this.validationidDataGridViewTextBoxColumn.DataPropertyName = "validation_id";
            this.validationidDataGridViewTextBoxColumn.HeaderText = "validation_id";
            this.validationidDataGridViewTextBoxColumn.Name = "validationidDataGridViewTextBoxColumn";
            // 
            // updatedbyDataGridViewTextBoxColumn
            // 
            this.updatedbyDataGridViewTextBoxColumn.DataPropertyName = "updated_by";
            this.updatedbyDataGridViewTextBoxColumn.HeaderText = "updated_by";
            this.updatedbyDataGridViewTextBoxColumn.Name = "updatedbyDataGridViewTextBoxColumn";
            // 
            // AllSlides
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1261, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AllSlides";
            this.Text = "AllSlides";
            this.Load += new System.EventHandler(this.AllSlides_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private sbmsDataSet sbmsDataSet;
        private System.Windows.Forms.BindingSource slidesBindingSource;
        private sbmsDataSetTableAdapters.slidesTableAdapter slidesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinetnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDamagedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReservedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBorrowedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedbyDataGridViewTextBoxColumn;
    }
}