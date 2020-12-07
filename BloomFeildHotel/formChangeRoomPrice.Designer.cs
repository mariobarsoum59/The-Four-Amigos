namespace BloomFeildHotel
{
    partial class formChangeRoomPrice
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
            this.btnChangeBasePrice = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblLastCleanDate = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtSmoking = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeBasePrice
            // 
            this.btnChangeBasePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnChangeBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeBasePrice.ForeColor = System.Drawing.Color.White;
            this.btnChangeBasePrice.Location = new System.Drawing.Point(679, 382);
            this.btnChangeBasePrice.Name = "btnChangeBasePrice";
            this.btnChangeBasePrice.Size = new System.Drawing.Size(153, 99);
            this.btnChangeBasePrice.TabIndex = 34;
            this.btnChangeBasePrice.Text = "Change Base Price";
            this.btnChangeBasePrice.UseVisualStyleBackColor = false;
            this.btnChangeBasePrice.Click += new System.EventHandler(this.BtnChangeBasePrice_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1080, 494);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 51);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePrice.Location = new System.Drawing.Point(480, 421);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(190, 26);
            this.txtBasePrice.TabIndex = 32;
            // 
            // lblLastCleanDate
            // 
            this.lblLastCleanDate.AutoSize = true;
            this.lblLastCleanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastCleanDate.Location = new System.Drawing.Point(389, 421);
            this.lblLastCleanDate.Name = "lblLastCleanDate";
            this.lblLastCleanDate.Size = new System.Drawing.Size(85, 20);
            this.lblLastCleanDate.TabIndex = 31;
            this.lblLastCleanDate.Text = "Base Price";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(70, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 337);
            this.listBox1.TabIndex = 30;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // lblRoomCleaningService
            // 
            this.lblRoomCleaningService.AutoSize = true;
            this.lblRoomCleaningService.Font = new System.Drawing.Font("Opus Chords Sans Std", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCleaningService.ForeColor = System.Drawing.Color.White;
            this.lblRoomCleaningService.Location = new System.Drawing.Point(3, 21);
            this.lblRoomCleaningService.Name = "lblRoomCleaningService";
            this.lblRoomCleaningService.Size = new System.Drawing.Size(389, 47);
            this.lblRoomCleaningService.TabIndex = 0;
            this.lblRoomCleaningService.Text = "Change Room Base Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblRoomCleaningService);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 68);
            this.panel1.TabIndex = 28;
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
            this.groupBoxFilter.Location = new System.Drawing.Point(70, 92);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(1077, 71);
            this.groupBoxFilter.TabIndex = 35;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter Rooms";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(895, 13);
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
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(428, 202);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(260, 29);
            this.txtType.TabIndex = 36;
            // 
            // txtSmoking
            // 
            this.txtSmoking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmoking.Location = new System.Drawing.Point(428, 234);
            this.txtSmoking.Name = "txtSmoking";
            this.txtSmoking.ReadOnly = true;
            this.txtSmoking.Size = new System.Drawing.Size(260, 29);
            this.txtSmoking.TabIndex = 37;
            // 
            // txtAvailable
            // 
            this.txtAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailable.Location = new System.Drawing.Point(428, 269);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.Size = new System.Drawing.Size(260, 29);
            this.txtAvailable.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Smoking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Available";
            // 
            // formChangeRoomPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1245, 555);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.txtSmoking);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.btnChangeBasePrice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.lblLastCleanDate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formChangeRoomPrice";
            this.Text = "formChangeRoomPrice";
            this.Load += new System.EventHandler(this.FormChangeRoomPrice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChangeBasePrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label lblLastCleanDate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblRoomCleaningService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.ComboBox comboBoxAvailable;
        private System.Windows.Forms.Label lblSmokingNonSmoking;
        private System.Windows.Forms.ComboBox comboBoxSmoking;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboBoxRType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtSmoking;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}