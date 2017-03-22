namespace VandA_Login_Screen
{
    partial class Hospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblHospitalGroup = new System.Windows.Forms.Label();
            this.lblHospitalName = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gbxHospital = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacancyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avalaibilityReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxHospital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblHospitalGroup
            // 
            this.lblHospitalGroup.AutoSize = true;
            this.lblHospitalGroup.Location = new System.Drawing.Point(18, 34);
            this.lblHospitalGroup.Name = "lblHospitalGroup";
            this.lblHospitalGroup.Size = new System.Drawing.Size(80, 13);
            this.lblHospitalGroup.TabIndex = 2;
            this.lblHospitalGroup.Text = "Hospital Group:";
            // 
            // lblHospitalName
            // 
            this.lblHospitalName.AutoSize = true;
            this.lblHospitalName.Location = new System.Drawing.Point(314, 36);
            this.lblHospitalName.Name = "lblHospitalName";
            this.lblHospitalName.Size = new System.Drawing.Size(79, 13);
            this.lblHospitalName.TabIndex = 3;
            this.lblHospitalName.Text = "Hospital Name:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(597, 39);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "Region:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(860, 34);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 54);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "The Eastern Cape.",
            "The Free State.",
            "Gauteng.",
            "KwaZulu-Natal.",
            "Limpopo.",
            "Mpumalanga.",
            "The Northern Cape.",
            "North West."});
            this.comboBox2.Location = new System.Drawing.Point(647, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(806, 42);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(1055, 43);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(87, 13);
            this.lblContactNumber.TabIndex = 8;
            this.lblContactNumber.Text = "Contact Nubmer:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1148, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 20);
            this.textBox3.TabIndex = 9;
            // 
            // gbxHospital
            // 
            this.gbxHospital.Controls.Add(this.textBox3);
            this.gbxHospital.Controls.Add(this.textBox1);
            this.gbxHospital.Controls.Add(this.lblContactNumber);
            this.gbxHospital.Controls.Add(this.comboBox1);
            this.gbxHospital.Controls.Add(this.lblAddress);
            this.gbxHospital.Controls.Add(this.lblHospitalGroup);
            this.gbxHospital.Controls.Add(this.comboBox2);
            this.gbxHospital.Controls.Add(this.lblHospitalName);
            this.gbxHospital.Controls.Add(this.textBox2);
            this.gbxHospital.Controls.Add(this.lblRegion);
            this.gbxHospital.Location = new System.Drawing.Point(12, 95);
            this.gbxHospital.Name = "gbxHospital";
            this.gbxHospital.Size = new System.Drawing.Size(1346, 106);
            this.gbxHospital.TabIndex = 10;
            this.gbxHospital.TabStop = false;
            this.gbxHospital.Text = "Hospital Details";
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(888, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 27);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(796, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 27);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(704, 207);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 27);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNew.Location = new System.Drawing.Point(612, 207);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(86, 27);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.Text = "AddNew";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1319, 431);
            this.dataGridView1.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(358, 20);
            this.textBox4.TabIndex = 20;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearch.Location = new System.Drawing.Point(112, 34);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(82, 24);
            this.lblSearch.TabIndex = 21;
            this.lblSearch.Text = "Search:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(60, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1162, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(152, 63);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospitalReportToolStripMenuItem,
            this.candidatesReportToolStripMenuItem,
            this.bookingsReportToolStripMenuItem,
            this.vacancyReportToolStripMenuItem,
            this.avalaibilityReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportsToolStripMenuItem.Image")));
            this.reportsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 59);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // hospitalReportToolStripMenuItem
            // 
            this.hospitalReportToolStripMenuItem.Name = "hospitalReportToolStripMenuItem";
            this.hospitalReportToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.hospitalReportToolStripMenuItem.Text = "Hospital Report";
            // 
            // candidatesReportToolStripMenuItem
            // 
            this.candidatesReportToolStripMenuItem.Name = "candidatesReportToolStripMenuItem";
            this.candidatesReportToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.candidatesReportToolStripMenuItem.Text = "Candidates Report";
            // 
            // bookingsReportToolStripMenuItem
            // 
            this.bookingsReportToolStripMenuItem.Name = "bookingsReportToolStripMenuItem";
            this.bookingsReportToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bookingsReportToolStripMenuItem.Text = "Bookings Report";
            // 
            // vacancyReportToolStripMenuItem
            // 
            this.vacancyReportToolStripMenuItem.Name = "vacancyReportToolStripMenuItem";
            this.vacancyReportToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.vacancyReportToolStripMenuItem.Text = "Vacancy Report";
            // 
            // avalaibilityReportToolStripMenuItem
            // 
            this.avalaibilityReportToolStripMenuItem.Name = "avalaibilityReportToolStripMenuItem";
            this.avalaibilityReportToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.avalaibilityReportToolStripMenuItem.Text = "Avalaibility Report";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(72, 59);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxHospital);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hospital";
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Hospital_Load);
            this.gbxHospital.ResumeLayout(false);
            this.gbxHospital.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblHospitalGroup;
        private System.Windows.Forms.Label lblHospitalName;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox gbxHospital;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacancyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avalaibilityReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}