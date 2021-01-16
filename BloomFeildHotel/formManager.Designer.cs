namespace BloomFeildHotel
{
    partial class formManager
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
            this.lblManagerMenu = new System.Windows.Forms.Label();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnViewRoomBookings = new System.Windows.Forms.Button();
            this.btnChangeRoomBasePrice = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumberOfGuests = new System.Windows.Forms.Label();
            this.lblManagerMenuTag = new System.Windows.Forms.Label();
            this.btnSearchForReservation = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnManageStockItems = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewGuests = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManagerMenu
            // 
            this.lblManagerMenu.AutoSize = true;
            this.lblManagerMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerMenu.ForeColor = System.Drawing.Color.White;
            this.lblManagerMenu.Location = new System.Drawing.Point(16, 21);
            this.lblManagerMenu.Name = "lblManagerMenu";
            this.lblManagerMenu.Size = new System.Drawing.Size(59, 39);
            this.lblManagerMenu.TabIndex = 0;
            this.lblManagerMenu.Text = "Hi ";
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsers.Location = new System.Drawing.Point(328, 174);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(161, 104);
            this.btnAddUsers.TabIndex = 1;
            this.btnAddUsers.Text = "Add Users";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.BtnAddUsers_Click);
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUsers.Location = new System.Drawing.Point(328, 284);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(161, 104);
            this.btnDeleteUsers.TabIndex = 2;
            this.btnDeleteUsers.Text = "Delete Users";
            this.btnDeleteUsers.UseVisualStyleBackColor = true;
            this.btnDeleteUsers.Click += new System.EventHandler(this.BtnDeleteUsers_Click);
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReservation.Location = new System.Drawing.Point(328, 394);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(161, 104);
            this.btnCreateReservation.TabIndex = 3;
            this.btnCreateReservation.Text = "Create Reservation";
            this.btnCreateReservation.UseVisualStyleBackColor = true;
            this.btnCreateReservation.Click += new System.EventHandler(this.BtnCreateReservation_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(495, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 104);
            this.button4.TabIndex = 4;
            this.button4.Text = "Room Cleaning Service";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnViewRoomBookings
            // 
            this.btnViewRoomBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRoomBookings.Location = new System.Drawing.Point(495, 284);
            this.btnViewRoomBookings.Name = "btnViewRoomBookings";
            this.btnViewRoomBookings.Size = new System.Drawing.Size(161, 104);
            this.btnViewRoomBookings.TabIndex = 5;
            this.btnViewRoomBookings.Text = "View Room Bookings";
            this.btnViewRoomBookings.UseVisualStyleBackColor = true;
            this.btnViewRoomBookings.Click += new System.EventHandler(this.BtnViewRoomBookings_Click);
            // 
            // btnChangeRoomBasePrice
            // 
            this.btnChangeRoomBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRoomBasePrice.Location = new System.Drawing.Point(495, 394);
            this.btnChangeRoomBasePrice.Name = "btnChangeRoomBasePrice";
            this.btnChangeRoomBasePrice.Size = new System.Drawing.Size(161, 104);
            this.btnChangeRoomBasePrice.TabIndex = 6;
            this.btnChangeRoomBasePrice.Text = "Change Room Base Price";
            this.btnChangeRoomBasePrice.UseVisualStyleBackColor = true;
            this.btnChangeRoomBasePrice.Click += new System.EventHandler(this.BtnChangeRoomBasePrice_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(662, 174);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(161, 104);
            this.btnCheckIn.TabIndex = 7;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReport.Location = new System.Drawing.Point(662, 284);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(161, 104);
            this.btnCreateReport.TabIndex = 8;
            this.btnCreateReport.Text = "Create Monthly Report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(808, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 57);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Logout";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblNumberOfGuests);
            this.panel1.Controls.Add(this.lblManagerMenu);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 68);
            this.panel1.TabIndex = 10;
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
            // lblManagerMenuTag
            // 
            this.lblManagerMenuTag.AutoSize = true;
            this.lblManagerMenuTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerMenuTag.Location = new System.Drawing.Point(520, 107);
            this.lblManagerMenuTag.Name = "lblManagerMenuTag";
            this.lblManagerMenuTag.Size = new System.Drawing.Size(248, 39);
            this.lblManagerMenuTag.TabIndex = 11;
            this.lblManagerMenuTag.Text = "Manager Menu";
            // 
            // btnSearchForReservation
            // 
            this.btnSearchForReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForReservation.Location = new System.Drawing.Point(662, 395);
            this.btnSearchForReservation.Name = "btnSearchForReservation";
            this.btnSearchForReservation.Size = new System.Drawing.Size(161, 104);
            this.btnSearchForReservation.TabIndex = 16;
            this.btnSearchForReservation.Text = "Search For Reservation";
            this.btnSearchForReservation.UseVisualStyleBackColor = true;
            this.btnSearchForReservation.Click += new System.EventHandler(this.btnSearchForReservation_Click);
            // 
            // btnViewReports
            // 
            this.btnViewReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReports.Location = new System.Drawing.Point(829, 284);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(161, 104);
            this.btnViewReports.TabIndex = 17;
            this.btnViewReports.Text = "View Monthly Reports";
            this.btnViewReports.UseVisualStyleBackColor = true;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // btnManageStockItems
            // 
            this.btnManageStockItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStockItems.Location = new System.Drawing.Point(829, 174);
            this.btnManageStockItems.Name = "btnManageStockItems";
            this.btnManageStockItems.Size = new System.Drawing.Size(161, 104);
            this.btnManageStockItems.TabIndex = 18;
            this.btnManageStockItems.Text = "Manage Stock Items";
            this.btnManageStockItems.UseVisualStyleBackColor = true;
            this.btnManageStockItems.Click += new System.EventHandler(this.BtnManageStockItems_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-4, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 119);
            this.panel2.TabIndex = 19;
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
            // btnViewGuests
            // 
            this.btnViewGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGuests.Location = new System.Drawing.Point(829, 395);
            this.btnViewGuests.Name = "btnViewGuests";
            this.btnViewGuests.Size = new System.Drawing.Size(161, 104);
            this.btnViewGuests.TabIndex = 20;
            this.btnViewGuests.Text = "View Guests";
            this.btnViewGuests.UseVisualStyleBackColor = true;
            this.btnViewGuests.Click += new System.EventHandler(this.btnViewGuests_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(161, 395);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(161, 104);
            this.btnChangePassword.TabIndex = 21;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // formManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 633);
            this.ControlBox = false;
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnViewGuests);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnManageStockItems);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnSearchForReservation);
            this.Controls.Add(this.lblManagerMenuTag);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateReport);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnChangeRoomBasePrice);
            this.Controls.Add(this.btnViewRoomBookings);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCreateReservation);
            this.Controls.Add(this.btnDeleteUsers);
            this.Controls.Add(this.btnAddUsers);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formManager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManagerMenu;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button btnDeleteUsers;
        private System.Windows.Forms.Button btnCreateReservation;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnViewRoomBookings;
        private System.Windows.Forms.Button btnChangeRoomBasePrice;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManagerMenuTag;
        private System.Windows.Forms.Button btnSearchForReservation;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnManageStockItems;
        private System.Windows.Forms.Label lblNumberOfGuests;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewGuests;
        private System.Windows.Forms.Button btnChangePassword;
    }
}