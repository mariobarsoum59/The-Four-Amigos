namespace BloomFeildHotel
{
    partial class formMarkRoomCleaned
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
            this.lblRoomCleaningService = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.comboBoxAvailable = new System.Windows.Forms.ComboBox();
            this.lblSmokingNonSmoking = new System.Windows.Forms.Label();
            this.comboBoxSmoking = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.comboBoxRType = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblLastCleanDate = new System.Windows.Forms.Label();
            this.txtLastCleanDate = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBoxNoteArea = new System.Windows.Forms.TextBox();
            this.lblLeaveANote = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRoomCleaningService
            // 
            this.lblRoomCleaningService.AutoSize = true;
            this.lblRoomCleaningService.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCleaningService.ForeColor = System.Drawing.Color.White;
            this.lblRoomCleaningService.Location = new System.Drawing.Point(4, 32);
            this.lblRoomCleaningService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomCleaningService.Name = "lblRoomCleaningService";
            this.lblRoomCleaningService.Size = new System.Drawing.Size(582, 61);
            this.lblRoomCleaningService.TabIndex = 0;
            this.lblRoomCleaningService.Text = "Room Cleaning Service";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblRoomCleaningService);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 105);
            this.panel1.TabIndex = 13;
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
            this.groupBoxFilter.Location = new System.Drawing.Point(75, 135);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFilter.Size = new System.Drawing.Size(1616, 109);
            this.groupBoxFilter.TabIndex = 14;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter Rooms";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1342, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(230, 78);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(908, 43);
            this.lblAvailability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(126, 29);
            this.lblAvailability.TabIndex = 7;
            this.lblAvailability.Text = "Availability";
            // 
            // comboBoxAvailable
            // 
            this.comboBoxAvailable.FormattingEnabled = true;
            this.comboBoxAvailable.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.comboBoxAvailable.Location = new System.Drawing.Point(1038, 38);
            this.comboBoxAvailable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxAvailable.Name = "comboBoxAvailable";
            this.comboBoxAvailable.Size = new System.Drawing.Size(234, 37);
            this.comboBoxAvailable.TabIndex = 6;
            // 
            // lblSmokingNonSmoking
            // 
            this.lblSmokingNonSmoking.AutoSize = true;
            this.lblSmokingNonSmoking.Location = new System.Drawing.Point(500, 43);
            this.lblSmokingNonSmoking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSmokingNonSmoking.Name = "lblSmokingNonSmoking";
            this.lblSmokingNonSmoking.Size = new System.Drawing.Size(108, 29);
            this.lblSmokingNonSmoking.TabIndex = 5;
            this.lblSmokingNonSmoking.Text = "Smoking";
            // 
            // comboBoxSmoking
            // 
            this.comboBoxSmoking.FormattingEnabled = true;
            this.comboBoxSmoking.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxSmoking.Location = new System.Drawing.Point(615, 38);
            this.comboBoxSmoking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSmoking.Name = "comboBoxSmoking";
            this.comboBoxSmoking.Size = new System.Drawing.Size(232, 37);
            this.comboBoxSmoking.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(56, 43);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(139, 29);
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
            this.comboBoxRType.Location = new System.Drawing.Point(200, 38);
            this.comboBoxRType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxRType.Name = "comboBoxRType";
            this.comboBoxRType.Size = new System.Drawing.Size(242, 37);
            this.comboBoxRType.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 55;
            this.listBox1.Location = new System.Drawing.Point(75, 271);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 499);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // lblLastCleanDate
            // 
            this.lblLastCleanDate.AutoSize = true;
            this.lblLastCleanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastCleanDate.Location = new System.Drawing.Point(428, 294);
            this.lblLastCleanDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastCleanDate.Name = "lblLastCleanDate";
            this.lblLastCleanDate.Size = new System.Drawing.Size(182, 29);
            this.lblLastCleanDate.TabIndex = 16;
            this.lblLastCleanDate.Text = "Last Clean Date";
            // 
            // txtLastCleanDate
            // 
            this.txtLastCleanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastCleanDate.Location = new System.Drawing.Point(624, 294);
            this.txtLastCleanDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastCleanDate.Name = "txtLastCleanDate";
            this.txtLastCleanDate.ReadOnly = true;
            this.txtLastCleanDate.Size = new System.Drawing.Size(558, 35);
            this.txtLastCleanDate.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1620, 757);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(230, 78);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1418, 469);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(230, 198);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Mark As Cleaned And Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // textBoxNoteArea
            // 
            this.textBoxNoteArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoteArea.Location = new System.Drawing.Point(435, 397);
            this.textBoxNoteArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNoteArea.Multiline = true;
            this.textBoxNoteArea.Name = "textBoxNoteArea";
            this.textBoxNoteArea.Size = new System.Drawing.Size(931, 364);
            this.textBoxNoteArea.TabIndex = 26;
            
            // 
            // lblLeaveANote
            // 
            this.lblLeaveANote.AutoSize = true;
            this.lblLeaveANote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveANote.Location = new System.Drawing.Point(428, 362);
            this.lblLeaveANote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeaveANote.Name = "lblLeaveANote";
            this.lblLeaveANote.Size = new System.Drawing.Size(157, 29);
            this.lblLeaveANote.TabIndex = 27;
            this.lblLeaveANote.Text = "Leave A Note";
            // 
            // formMarkRoomCleaned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1868, 854);
            this.Controls.Add(this.lblLeaveANote);
            this.Controls.Add(this.textBoxNoteArea);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtLastCleanDate);
            this.Controls.Add(this.lblLastCleanDate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formMarkRoomCleaned";
            this.Text = "formMarkRoomCleaned";
            this.Load += new System.EventHandler(this.FormMarkRoomCleaned_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomCleaningService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.ComboBox comboBoxAvailable;
        private System.Windows.Forms.Label lblSmokingNonSmoking;
        private System.Windows.Forms.ComboBox comboBoxSmoking;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboBoxRType;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblLastCleanDate;
        private System.Windows.Forms.TextBox txtLastCleanDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBoxNoteArea;
        private System.Windows.Forms.Label lblLeaveANote;
        private System.Windows.Forms.Button btnSearch;
    }
}