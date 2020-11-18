namespace BloomFeildHotel
{
    partial class formEditReservation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreateReservation = new System.Windows.Forms.Label();
            this.groupBoxSearchForAvailability = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.nightNum = new System.Windows.Forms.TextBox();
            this.lblNumOfNights = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.groupBoxRoomType = new System.Windows.Forms.GroupBox();
            this.twnSmoke = new System.Windows.Forms.RadioButton();
            this.TwnNonSmoke = new System.Windows.Forms.RadioButton();
            this.DblSmoke = new System.Windows.Forms.RadioButton();
            this.DblNonSmoke = new System.Windows.Forms.RadioButton();
            this.SingleSmoke = new System.Windows.Forms.RadioButton();
            this.SingleNonSmoke = new System.Windows.Forms.RadioButton();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.dateCheckout = new System.Windows.Forms.DateTimePicker();
            this.dateCheckin = new System.Windows.Forms.DateTimePicker();
            this.groupBoxGuestDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxSendMarketingInfo = new System.Windows.Forms.GroupBox();
            this.MKNO = new System.Windows.Forms.RadioButton();
            this.MKYES = new System.Windows.Forms.RadioButton();
            this.groupBoxDepositPayed = new System.Windows.Forms.GroupBox();
            this.DPNO = new System.Windows.Forms.RadioButton();
            this.DPYES = new System.Windows.Forms.RadioButton();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.guestNum = new System.Windows.Forms.TextBox();
            this.lblNumberOfGuests = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxSearchForAvailability.SuspendLayout();
            this.groupBoxRoomType.SuspendLayout();
            this.groupBoxGuestDetails.SuspendLayout();
            this.groupBoxSendMarketingInfo.SuspendLayout();
            this.groupBoxDepositPayed.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.lblCreateReservation);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1533, 105);
            this.panel1.TabIndex = 0;
            // 
            // lblCreateReservation
            // 
            this.lblCreateReservation.AutoSize = true;
            this.lblCreateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateReservation.ForeColor = System.Drawing.Color.White;
            this.lblCreateReservation.Location = new System.Drawing.Point(25, 23);
            this.lblCreateReservation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateReservation.Name = "lblCreateReservation";
            this.lblCreateReservation.Size = new System.Drawing.Size(405, 59);
            this.lblCreateReservation.TabIndex = 1;
            this.lblCreateReservation.Text = "Edit Reservation";
            this.lblCreateReservation.Click += new System.EventHandler(this.lblCreateReservation_Click);
            // 
            // groupBoxSearchForAvailability
            // 
            this.groupBoxSearchForAvailability.Controls.Add(this.btnSearch);
            this.groupBoxSearchForAvailability.Controls.Add(this.nightNum);
            this.groupBoxSearchForAvailability.Controls.Add(this.lblNumOfNights);
            this.groupBoxSearchForAvailability.Controls.Add(this.lblCheckInDate);
            this.groupBoxSearchForAvailability.Controls.Add(this.groupBoxRoomType);
            this.groupBoxSearchForAvailability.Controls.Add(this.lblCheckOutDate);
            this.groupBoxSearchForAvailability.Controls.Add(this.dateCheckout);
            this.groupBoxSearchForAvailability.Controls.Add(this.dateCheckin);
            this.groupBoxSearchForAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchForAvailability.Location = new System.Drawing.Point(67, 132);
            this.groupBoxSearchForAvailability.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSearchForAvailability.Name = "groupBoxSearchForAvailability";
            this.groupBoxSearchForAvailability.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSearchForAvailability.Size = new System.Drawing.Size(724, 706);
            this.groupBoxSearchForAvailability.TabIndex = 20;
            this.groupBoxSearchForAvailability.TabStop = false;
            this.groupBoxSearchForAvailability.Text = "Search For Availability";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(28, 606);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(523, 65);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // nightNum
            // 
            this.nightNum.Location = new System.Drawing.Point(236, 497);
            this.nightNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nightNum.Name = "nightNum";
            this.nightNum.ReadOnly = true;
            this.nightNum.Size = new System.Drawing.Size(76, 35);
            this.nightNum.TabIndex = 20;
            // 
            // lblNumOfNights
            // 
            this.lblNumOfNights.AutoSize = true;
            this.lblNumOfNights.Location = new System.Drawing.Point(22, 498);
            this.lblNumOfNights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfNights.Name = "lblNumOfNights";
            this.lblNumOfNights.Size = new System.Drawing.Size(206, 29);
            this.lblNumOfNights.TabIndex = 19;
            this.lblNumOfNights.Text = "Number Of Nights";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(22, 98);
            this.lblCheckInDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(162, 29);
            this.lblCheckInDate.TabIndex = 13;
            this.lblCheckInDate.Text = "Check In Date";
            // 
            // groupBoxRoomType
            // 
            this.groupBoxRoomType.Controls.Add(this.twnSmoke);
            this.groupBoxRoomType.Controls.Add(this.TwnNonSmoke);
            this.groupBoxRoomType.Controls.Add(this.DblSmoke);
            this.groupBoxRoomType.Controls.Add(this.DblNonSmoke);
            this.groupBoxRoomType.Controls.Add(this.SingleSmoke);
            this.groupBoxRoomType.Controls.Add(this.SingleNonSmoke);
            this.groupBoxRoomType.Location = new System.Drawing.Point(28, 229);
            this.groupBoxRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRoomType.Name = "groupBoxRoomType";
            this.groupBoxRoomType.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRoomType.Size = new System.Drawing.Size(629, 218);
            this.groupBoxRoomType.TabIndex = 18;
            this.groupBoxRoomType.TabStop = false;
            this.groupBoxRoomType.Text = "Room Type";
            // 
            // twnSmoke
            // 
            this.twnSmoke.AutoSize = true;
            this.twnSmoke.Location = new System.Drawing.Point(315, 131);
            this.twnSmoke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.twnSmoke.Name = "twnSmoke";
            this.twnSmoke.Size = new System.Drawing.Size(192, 33);
            this.twnSmoke.TabIndex = 5;
            this.twnSmoke.TabStop = true;
            this.twnSmoke.Text = "Twin Smoking";
            this.twnSmoke.UseVisualStyleBackColor = true;
            // 
            // TwnNonSmoke
            // 
            this.TwnNonSmoke.AutoSize = true;
            this.TwnNonSmoke.Location = new System.Drawing.Point(28, 131);
            this.TwnNonSmoke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TwnNonSmoke.Name = "TwnNonSmoke";
            this.TwnNonSmoke.Size = new System.Drawing.Size(245, 33);
            this.TwnNonSmoke.TabIndex = 4;
            this.TwnNonSmoke.TabStop = true;
            this.TwnNonSmoke.Text = "Twin Non-Smoking";
            this.TwnNonSmoke.UseVisualStyleBackColor = true;
            // 
            // DblSmoke
            // 
            this.DblSmoke.AutoSize = true;
            this.DblSmoke.Location = new System.Drawing.Point(315, 85);
            this.DblSmoke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DblSmoke.Name = "DblSmoke";
            this.DblSmoke.Size = new System.Drawing.Size(217, 33);
            this.DblSmoke.TabIndex = 3;
            this.DblSmoke.TabStop = true;
            this.DblSmoke.Text = "Double Smoking";
            this.DblSmoke.UseVisualStyleBackColor = true;
            // 
            // DblNonSmoke
            // 
            this.DblNonSmoke.AutoSize = true;
            this.DblNonSmoke.Location = new System.Drawing.Point(28, 85);
            this.DblNonSmoke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DblNonSmoke.Name = "DblNonSmoke";
            this.DblNonSmoke.Size = new System.Drawing.Size(270, 33);
            this.DblNonSmoke.TabIndex = 2;
            this.DblNonSmoke.TabStop = true;
            this.DblNonSmoke.Text = "Double Non-Smoking";
            this.DblNonSmoke.UseVisualStyleBackColor = true;
            // 
            // SingleSmoke
            // 
            this.SingleSmoke.AutoSize = true;
            this.SingleSmoke.Location = new System.Drawing.Point(315, 38);
            this.SingleSmoke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SingleSmoke.Name = "SingleSmoke";
            this.SingleSmoke.Size = new System.Drawing.Size(208, 33);
            this.SingleSmoke.TabIndex = 1;
            this.SingleSmoke.TabStop = true;
            this.SingleSmoke.Text = "Single Smoking";
            this.SingleSmoke.UseVisualStyleBackColor = true;
            // 
            // SingleNonSmoke
            // 
            this.SingleNonSmoke.AutoSize = true;
            this.SingleNonSmoke.Location = new System.Drawing.Point(28, 38);
            this.SingleNonSmoke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SingleNonSmoke.Name = "SingleNonSmoke";
            this.SingleNonSmoke.Size = new System.Drawing.Size(261, 33);
            this.SingleNonSmoke.TabIndex = 0;
            this.SingleNonSmoke.TabStop = true;
            this.SingleNonSmoke.Text = "Single Non-Smoking";
            this.SingleNonSmoke.UseVisualStyleBackColor = true;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(22, 155);
            this.lblCheckOutDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(181, 29);
            this.lblCheckOutDate.TabIndex = 14;
            this.lblCheckOutDate.Text = "Check Out Date";
            // 
            // dateCheckout
            // 
            this.dateCheckout.Location = new System.Drawing.Point(216, 148);
            this.dateCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateCheckout.Name = "dateCheckout";
            this.dateCheckout.Size = new System.Drawing.Size(434, 35);
            this.dateCheckout.TabIndex = 17;
            // 
            // dateCheckin
            // 
            this.dateCheckin.Location = new System.Drawing.Point(216, 98);
            this.dateCheckin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateCheckin.Name = "dateCheckin";
            this.dateCheckin.Size = new System.Drawing.Size(434, 35);
            this.dateCheckin.TabIndex = 16;
            // 
            // groupBoxGuestDetails
            // 
            this.groupBoxGuestDetails.Controls.Add(this.lblPhone);
            this.groupBoxGuestDetails.Controls.Add(this.txtPhone);
            this.groupBoxGuestDetails.Controls.Add(this.groupBoxSendMarketingInfo);
            this.groupBoxGuestDetails.Controls.Add(this.groupBoxDepositPayed);
            this.groupBoxGuestDetails.Controls.Add(this.TxtAddress);
            this.groupBoxGuestDetails.Controls.Add(this.label2);
            this.groupBoxGuestDetails.Controls.Add(this.TxtEmail);
            this.groupBoxGuestDetails.Controls.Add(this.lblContact);
            this.groupBoxGuestDetails.Controls.Add(this.TxtSurname);
            this.groupBoxGuestDetails.Controls.Add(this.txtFirstName);
            this.groupBoxGuestDetails.Controls.Add(this.btnSubmit);
            this.groupBoxGuestDetails.Controls.Add(this.guestNum);
            this.groupBoxGuestDetails.Controls.Add(this.lblNumberOfGuests);
            this.groupBoxGuestDetails.Controls.Add(this.lblFirstName);
            this.groupBoxGuestDetails.Controls.Add(this.lblSurname);
            this.groupBoxGuestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGuestDetails.Location = new System.Drawing.Point(799, 151);
            this.groupBoxGuestDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGuestDetails.Name = "groupBoxGuestDetails";
            this.groupBoxGuestDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGuestDetails.Size = new System.Drawing.Size(674, 722);
            this.groupBoxGuestDetails.TabIndex = 23;
            this.groupBoxGuestDetails.TabStop = false;
            this.groupBoxGuestDetails.Text = "Guest Details";
            // 
            // groupBoxSendMarketingInfo
            // 
            this.groupBoxSendMarketingInfo.Controls.Add(this.MKNO);
            this.groupBoxSendMarketingInfo.Controls.Add(this.MKYES);
            this.groupBoxSendMarketingInfo.Location = new System.Drawing.Point(27, 479);
            this.groupBoxSendMarketingInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSendMarketingInfo.Name = "groupBoxSendMarketingInfo";
            this.groupBoxSendMarketingInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSendMarketingInfo.Size = new System.Drawing.Size(625, 82);
            this.groupBoxSendMarketingInfo.TabIndex = 29;
            this.groupBoxSendMarketingInfo.TabStop = false;
            this.groupBoxSendMarketingInfo.Text = "Send Marketing Information";
            // 
            // MKNO
            // 
            this.MKNO.AutoSize = true;
            this.MKNO.Location = new System.Drawing.Point(176, 38);
            this.MKNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MKNO.Name = "MKNO";
            this.MKNO.Size = new System.Drawing.Size(70, 33);
            this.MKNO.TabIndex = 1;
            this.MKNO.TabStop = true;
            this.MKNO.Text = "No";
            this.MKNO.UseVisualStyleBackColor = true;
            // 
            // MKYES
            // 
            this.MKYES.AutoSize = true;
            this.MKYES.Location = new System.Drawing.Point(28, 38);
            this.MKYES.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MKYES.Name = "MKYES";
            this.MKYES.Size = new System.Drawing.Size(80, 33);
            this.MKYES.TabIndex = 0;
            this.MKYES.TabStop = true;
            this.MKYES.Text = "Yes";
            this.MKYES.UseVisualStyleBackColor = true;
            // 
            // groupBoxDepositPayed
            // 
            this.groupBoxDepositPayed.Controls.Add(this.DPNO);
            this.groupBoxDepositPayed.Controls.Add(this.DPYES);
            this.groupBoxDepositPayed.Location = new System.Drawing.Point(27, 360);
            this.groupBoxDepositPayed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDepositPayed.Name = "groupBoxDepositPayed";
            this.groupBoxDepositPayed.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDepositPayed.Size = new System.Drawing.Size(625, 72);
            this.groupBoxDepositPayed.TabIndex = 28;
            this.groupBoxDepositPayed.TabStop = false;
            this.groupBoxDepositPayed.Text = "Deposit Paid";
            // 
            // DPNO
            // 
            this.DPNO.AutoSize = true;
            this.DPNO.Location = new System.Drawing.Point(175, 38);
            this.DPNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DPNO.Name = "DPNO";
            this.DPNO.Size = new System.Drawing.Size(70, 33);
            this.DPNO.TabIndex = 1;
            this.DPNO.TabStop = true;
            this.DPNO.Text = "No";
            this.DPNO.UseVisualStyleBackColor = true;
            // 
            // DPYES
            // 
            this.DPYES.AutoSize = true;
            this.DPYES.Location = new System.Drawing.Point(24, 38);
            this.DPYES.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DPYES.Name = "DPYES";
            this.DPYES.Size = new System.Drawing.Size(80, 33);
            this.DPYES.TabIndex = 0;
            this.DPYES.TabStop = true;
            this.DPYES.Text = "Yes";
            this.DPYES.UseVisualStyleBackColor = true;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(162, 206);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(488, 35);
            this.TxtAddress.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Address";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(162, 157);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(488, 35);
            this.TxtEmail.TabIndex = 25;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(22, 166);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(74, 29);
            this.lblContact.TabIndex = 24;
            this.lblContact.Text = "Email";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(162, 108);
            this.TxtSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(488, 35);
            this.TxtSurname.TabIndex = 23;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(162, 57);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(488, 35);
            this.txtFirstName.TabIndex = 22;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(26, 587);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(595, 65);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit Reservation";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // guestNum
            // 
            this.guestNum.Location = new System.Drawing.Point(241, 314);
            this.guestNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guestNum.Name = "guestNum";
            this.guestNum.Size = new System.Drawing.Size(92, 35);
            this.guestNum.TabIndex = 20;
            // 
            // lblNumberOfGuests
            // 
            this.lblNumberOfGuests.AutoSize = true;
            this.lblNumberOfGuests.Location = new System.Drawing.Point(21, 314);
            this.lblNumberOfGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfGuests.Name = "lblNumberOfGuests";
            this.lblNumberOfGuests.Size = new System.Drawing.Size(212, 29);
            this.lblNumberOfGuests.TabIndex = 19;
            this.lblNumberOfGuests.Text = "Number Of Guests";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(22, 66);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(131, 29);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(22, 117);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(110, 29);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Surname";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(164, 251);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(488, 35);
            this.txtPhone.TabIndex = 30;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(22, 257);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 29);
            this.lblPhone.TabIndex = 31;
            this.lblPhone.Text = "Phone";
            // 
            // formEditReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1524, 838);
            this.Controls.Add(this.groupBoxGuestDetails);
            this.Controls.Add(this.groupBoxSearchForAvailability);
            this.Controls.Add(this.panel1);
            this.Name = "formEditReservation";
            this.Text = "formEditReservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxSearchForAvailability.ResumeLayout(false);
            this.groupBoxSearchForAvailability.PerformLayout();
            this.groupBoxRoomType.ResumeLayout(false);
            this.groupBoxRoomType.PerformLayout();
            this.groupBoxGuestDetails.ResumeLayout(false);
            this.groupBoxGuestDetails.PerformLayout();
            this.groupBoxSendMarketingInfo.ResumeLayout(false);
            this.groupBoxSendMarketingInfo.PerformLayout();
            this.groupBoxDepositPayed.ResumeLayout(false);
            this.groupBoxDepositPayed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreateReservation;
        private System.Windows.Forms.GroupBox groupBoxSearchForAvailability;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox nightNum;
        private System.Windows.Forms.Label lblNumOfNights;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.GroupBox groupBoxRoomType;
        private System.Windows.Forms.RadioButton twnSmoke;
        private System.Windows.Forms.RadioButton TwnNonSmoke;
        private System.Windows.Forms.RadioButton DblSmoke;
        private System.Windows.Forms.RadioButton DblNonSmoke;
        private System.Windows.Forms.RadioButton SingleSmoke;
        private System.Windows.Forms.RadioButton SingleNonSmoke;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.DateTimePicker dateCheckout;
        private System.Windows.Forms.DateTimePicker dateCheckin;
        private System.Windows.Forms.GroupBox groupBoxGuestDetails;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox groupBoxSendMarketingInfo;
        private System.Windows.Forms.RadioButton MKNO;
        private System.Windows.Forms.RadioButton MKYES;
        private System.Windows.Forms.GroupBox groupBoxDepositPayed;
        private System.Windows.Forms.RadioButton DPNO;
        private System.Windows.Forms.RadioButton DPYES;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox guestNum;
        private System.Windows.Forms.Label lblNumberOfGuests;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
    }
}