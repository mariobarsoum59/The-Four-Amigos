namespace BloomFeildHotel
{
    partial class formRoomCleaningRecords
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumberOfGuests = new System.Windows.Forms.Label();
            this.lblManagerMenu = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.comboBoxAvailable = new System.Windows.Forms.ComboBox();
            this.lblSmokingNonSmoking = new System.Windows.Forms.Label();
            this.comboBoxSmoking = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.comboBoxRType = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 573);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 90);
            this.panel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(924, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblNumberOfGuests);
            this.panel1.Controls.Add(this.lblManagerMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 68);
            this.panel1.TabIndex = 20;
            // 
            // lblNumberOfGuests
            // 
            this.lblNumberOfGuests.AutoSize = true;
            this.lblNumberOfGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGuests.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfGuests.Location = new System.Drawing.Point(924, 33);
            this.lblNumberOfGuests.Name = "lblNumberOfGuests";
            this.lblNumberOfGuests.Size = new System.Drawing.Size(0, 25);
            this.lblNumberOfGuests.TabIndex = 1;
            // 
            // lblManagerMenu
            // 
            this.lblManagerMenu.AutoSize = true;
            this.lblManagerMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerMenu.ForeColor = System.Drawing.Color.White;
            this.lblManagerMenu.Location = new System.Drawing.Point(16, 21);
            this.lblManagerMenu.Name = "lblManagerMenu";
            this.lblManagerMenu.Size = new System.Drawing.Size(292, 39);
            this.lblManagerMenu.TabIndex = 0;
            this.lblManagerMenu.Text = "Cleaning Records";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(35, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 374);
            this.listBox1.TabIndex = 23;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.btnSearch);
            this.groupBoxFilter.Controls.Add(this.lblAvailability);
            this.groupBoxFilter.Controls.Add(this.comboBoxAvailable);
            this.groupBoxFilter.Controls.Add(this.lblSmokingNonSmoking);
            this.groupBoxFilter.Controls.Add(this.comboBoxSmoking);
            this.groupBoxFilter.Controls.Add(this.lblType);
            this.groupBoxFilter.Controls.Add(this.comboBoxRType);
            this.groupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilter.Location = new System.Drawing.Point(23, 102);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(1212, 71);
            this.groupBoxFilter.TabIndex = 22;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter Rooms";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(940, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 51);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(605, 28);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(81, 20);
            this.lblAvailability.TabIndex = 7;
            this.lblAvailability.Text = "Availability";
            // 
            // comboBoxAvailable
            // 
            this.comboBoxAvailable.FormattingEnabled = true;
            this.comboBoxAvailable.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.comboBoxAvailable.Location = new System.Drawing.Point(692, 25);
            this.comboBoxAvailable.Name = "comboBoxAvailable";
            this.comboBoxAvailable.Size = new System.Drawing.Size(157, 28);
            this.comboBoxAvailable.TabIndex = 6;
            // 
            // lblSmokingNonSmoking
            // 
            this.lblSmokingNonSmoking.AutoSize = true;
            this.lblSmokingNonSmoking.Location = new System.Drawing.Point(333, 28);
            this.lblSmokingNonSmoking.Name = "lblSmokingNonSmoking";
            this.lblSmokingNonSmoking.Size = new System.Drawing.Size(71, 20);
            this.lblSmokingNonSmoking.TabIndex = 5;
            this.lblSmokingNonSmoking.Text = "Smoking";
            // 
            // comboBoxSmoking
            // 
            this.comboBoxSmoking.FormattingEnabled = true;
            this.comboBoxSmoking.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxSmoking.Location = new System.Drawing.Point(410, 25);
            this.comboBoxSmoking.Name = "comboBoxSmoking";
            this.comboBoxSmoking.Size = new System.Drawing.Size(156, 28);
            this.comboBoxSmoking.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(37, 28);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(90, 20);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Room Type";
            // 
            // comboBoxRType
            // 
            this.comboBoxRType.FormattingEnabled = true;
            this.comboBoxRType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Twin"});
            this.comboBoxRType.Location = new System.Drawing.Point(133, 25);
            this.comboBoxRType.Name = "comboBoxRType";
            this.comboBoxRType.Size = new System.Drawing.Size(163, 28);
            this.comboBoxRType.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(602, 335);
            this.dataGridView1.TabIndex = 24;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1099, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 41);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(957, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 26;
            this.button1.Text = "View All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // formRoomCleaningRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1277, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRoomCleaningRecords";
            this.Text = "formRoomCleaningRecords";
            this.Load += new System.EventHandler(this.FormRoomCleaningRecords_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumberOfGuests;
        private System.Windows.Forms.Label lblManagerMenu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.ComboBox comboBoxAvailable;
        private System.Windows.Forms.Label lblSmokingNonSmoking;
        private System.Windows.Forms.ComboBox comboBoxSmoking;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboBoxRType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
    }
}