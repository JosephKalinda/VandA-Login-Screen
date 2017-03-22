namespace VandA_Login_Screen
{
    partial class Availabilities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Availabilities));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacancyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avalaibilityReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbxAvailabilities = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAgent = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.nursingPlacementApplicationDataSet = new VandA_Login_Screen.NursingPlacementApplicationDataSet();
            this.nursingPlacementApplicationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.gbxAvailabilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nursingPlacementApplicationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursingPlacementApplicationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Location = new System.Drawing.Point(1176, 14);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(152, 63);
            this.menuStrip1.TabIndex = 25;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(192, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(358, 20);
            this.textBox4.TabIndex = 23;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearch.Location = new System.Drawing.Point(104, 53);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(82, 24);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Text = "Search:";
            // 
            // gbxAvailabilities
            // 
            this.gbxAvailabilities.Controls.Add(this.btnSave);
            this.gbxAvailabilities.Controls.Add(this.btnDelete);
            this.gbxAvailabilities.Controls.Add(this.monthCalendar1);
            this.gbxAvailabilities.Controls.Add(this.btnEdit);
            this.gbxAvailabilities.Controls.Add(this.comboBox3);
            this.gbxAvailabilities.Controls.Add(this.btnAddNew);
            this.gbxAvailabilities.Controls.Add(this.textBox5);
            this.gbxAvailabilities.Controls.Add(this.lblRank);
            this.gbxAvailabilities.Controls.Add(this.comboBox1);
            this.gbxAvailabilities.Controls.Add(this.textBox3);
            this.gbxAvailabilities.Controls.Add(this.textBox1);
            this.gbxAvailabilities.Controls.Add(this.lblAgent);
            this.gbxAvailabilities.Controls.Add(this.lblShift);
            this.gbxAvailabilities.Controls.Add(this.lblCandidateName);
            this.gbxAvailabilities.Controls.Add(this.comboBox2);
            this.gbxAvailabilities.Controls.Add(this.lblUnit);
            this.gbxAvailabilities.Controls.Add(this.lblRegion);
            this.gbxAvailabilities.Location = new System.Drawing.Point(22, 95);
            this.gbxAvailabilities.Name = "gbxAvailabilities";
            this.gbxAvailabilities.Size = new System.Drawing.Size(1346, 204);
            this.gbxAvailabilities.TabIndex = 26;
            this.gbxAvailabilities.TabStop = false;
            this.gbxAvailabilities.Text = "Availabilities Details";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1062, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(817, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Location = new System.Drawing.Point(1012, 96);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(38, 13);
            this.lblAgent.TabIndex = 8;
            this.lblAgent.Text = "Agent:";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(782, 95);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(31, 13);
            this.lblShift.TabIndex = 7;
            this.lblShift.Text = "Shift:";
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.AutoSize = true;
            this.lblCandidateName.Location = new System.Drawing.Point(474, 74);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(94, 13);
            this.lblCandidateName.TabIndex = 2;
            this.lblCandidateName.Text = "Candidate Names:";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(782, 74);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 13);
            this.lblUnit.TabIndex = 3;
            this.lblUnit.Text = "Unit:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(1012, 71);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "Region:";
            // 
            // nursingPlacementApplicationDataSet
            // 
            this.nursingPlacementApplicationDataSet.DataSetName = "NursingPlacementApplicationDataSet";
            this.nursingPlacementApplicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nursingPlacementApplicationDataSetBindingSource
            // 
            this.nursingPlacementApplicationDataSetBindingSource.DataSource = this.nursingPlacementApplicationDataSet;
            this.nursingPlacementApplicationDataSetBindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(574, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Eastern Cape.",
            "Free State.",
            "Gauteng.",
            "KwaZulu-Natal.",
            "Limpopo.",
            "Mpumalanga.",
            "The Northern Cape.",
            "North West."});
            this.comboBox2.Location = new System.Drawing.Point(1062, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(574, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(202, 20);
            this.textBox5.TabIndex = 11;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(474, 95);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(36, 13);
            this.lblRank.TabIndex = 12;
            this.lblRank.Text = "Rank:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Day Shift",
            "night shift"});
            this.comboBox3.Location = new System.Drawing.Point(819, 92);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(190, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(65, 28);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(22, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 168);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(1062, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 27);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(970, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 27);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(878, 149);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 27);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNew.Location = new System.Drawing.Point(786, 149);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(86, 27);
            this.btnAddNew.TabIndex = 28;
            this.btnAddNew.Text = "AddNew";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Availability Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Candidates Names";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Units";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Rank";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Region";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Shift";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Agent";
            this.Column7.Name = "Column7";
            // 
            // Availabilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxAvailabilities);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblSearch);
            this.Name = "Availabilities";
            this.Text = "Availabilities";
            this.Load += new System.EventHandler(this.Availabilities_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxAvailabilities.ResumeLayout(false);
            this.gbxAvailabilities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nursingPlacementApplicationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursingPlacementApplicationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacancyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avalaibilityReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gbxAvailabilities;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblCandidateName;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblRegion;
        private NursingPlacementApplicationDataSet nursingPlacementApplicationDataSet;
        private System.Windows.Forms.BindingSource nursingPlacementApplicationDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}