namespace BloomFeildHotel
{
    partial class formCreateReservation
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
            this.lblCreateReservation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.DTPCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.DTPCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxRoomType = new System.Windows.Forms.GroupBox();
            this.radioButtonTwin = new System.Windows.Forms.RadioButton();
            this.radioButtonDouble = new System.Windows.Forms.RadioButton();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.groupBoxSearchForAvailability = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNonSmoking = new System.Windows.Forms.RadioButton();
            this.radioButtonSmoking = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxNumOfNights = new System.Windows.Forms.TextBox();
            this.lblNumOfNights = new System.Windows.Forms.Label();
            this.groupBoxGuestDetails = new System.Windows.Forms.GroupBox();
            this.textBoxNumOfChildren = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonPIFNo = new System.Windows.Forms.RadioButton();
            this.radioButtonPIFYes = new System.Windows.Forms.RadioButton();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSendMarketingInfo = new System.Windows.Forms.GroupBox();
            this.radioButtonMINo = new System.Windows.Forms.RadioButton();
            this.radioButtonMIYes = new System.Windows.Forms.RadioButton();
            this.groupBoxDepositPayed = new System.Windows.Forms.GroupBox();
            this.radioButtonDPNo = new System.Windows.Forms.RadioButton();
            this.radioButtonDPYes = new System.Windows.Forms.RadioButton();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.btnSubmitReservation = new System.Windows.Forms.Button();
            this.textBoxNumOfAdults = new System.Windows.Forms.TextBox();
            this.lblNumberOfAdults = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxRoomDetails = new System.Windows.Forms.GroupBox();
            this.listBoxSelectedRoom = new System.Windows.Forms.ListBox();
            this.textBoxVariablePrice = new System.Windows.Forms.TextBox();
            this.textBoxBasePrice = new System.Windows.Forms.TextBox();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.lblVariablePrice = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxRoomType.SuspendLayout();
            this.groupBoxSearchForAvailability.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxGuestDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSendMarketingInfo.SuspendLayout();
            this.groupBoxDepositPayed.SuspendLayout();
            this.groupBoxRoomDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreateReservation
            // 
            this.lblCreateReservation.AutoSize = true;
            this.lblCreateReservation.Font = new System.Drawing.Font("Opus Chords Sans Std", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateReservation.ForeColor = System.Drawing.Color.White;
            this.lblCreateReservation.Location = new System.Drawing.Point(3, 21);
            this.lblCreateReservation.Name = "lblCreateReservation";
            this.lblCreateReservation.Size = new System.Drawing.Size(301, 47);
            this.lblCreateReservation.TabIndex = 0;
            this.lblCreateReservation.Text = "Create Reservation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblCreateReservation);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 68);
            this.panel1.TabIndex = 12;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(15, 64);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(111, 20);
            this.lblCheckInDate.TabIndex = 13;
            this.lblCheckInDate.Text = "Check In Date";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(15, 101);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(123, 20);
            this.lblCheckOutDate.TabIndex = 14;
            this.lblCheckOutDate.Text = "Check Out Date";
            // 
            // DTPCheckInDate
            // 
            this.DTPCheckInDate.Location = new System.Drawing.Point(144, 59);
            this.DTPCheckInDate.Name = "DTPCheckInDate";
            this.DTPCheckInDate.Size = new System.Drawing.Size(291, 26);
            this.DTPCheckInDate.TabIndex = 16;
            this.DTPCheckInDate.ValueChanged += new System.EventHandler(this.DTPCheckInDate_ValueChanged);
            // 
            // DTPCheckOutDate
            // 
            this.DTPCheckOutDate.Location = new System.Drawing.Point(144, 100);
            this.DTPCheckOutDate.Name = "DTPCheckOutDate";
            this.DTPCheckOutDate.Size = new System.Drawing.Size(291, 26);
            this.DTPCheckOutDate.TabIndex = 17;
            // 
            // groupBoxRoomType
            // 
            this.groupBoxRoomType.Controls.Add(this.radioButtonTwin);
            this.groupBoxRoomType.Controls.Add(this.radioButtonDouble);
            this.groupBoxRoomType.Controls.Add(this.radioButtonSingle);
            this.groupBoxRoomType.Location = new System.Drawing.Point(19, 149);
            this.groupBoxRoomType.Name = "groupBoxRoomType";
            this.groupBoxRoomType.Size = new System.Drawing.Size(190, 145);
            this.groupBoxRoomType.TabIndex = 18;
            this.groupBoxRoomType.TabStop = false;
            this.groupBoxRoomType.Text = "Room Type";
            // 
            // radioButtonTwin
            // 
            this.radioButtonTwin.AutoSize = true;
            this.radioButtonTwin.Location = new System.Drawing.Point(19, 85);
            this.radioButtonTwin.Name = "radioButtonTwin";
            this.radioButtonTwin.Size = new System.Drawing.Size(59, 24);
            this.radioButtonTwin.TabIndex = 4;
            this.radioButtonTwin.TabStop = true;
            this.radioButtonTwin.Text = "Twin";
            this.radioButtonTwin.UseVisualStyleBackColor = true;
            // 
            // radioButtonDouble
            // 
            this.radioButtonDouble.AutoSize = true;
            this.radioButtonDouble.Location = new System.Drawing.Point(19, 55);
            this.radioButtonDouble.Name = "radioButtonDouble";
            this.radioButtonDouble.Size = new System.Drawing.Size(78, 24);
            this.radioButtonDouble.TabIndex = 2;
            this.radioButtonDouble.TabStop = true;
            this.radioButtonDouble.Text = "Double";
            this.radioButtonDouble.UseVisualStyleBackColor = true;
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(19, 25);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(71, 24);
            this.radioButtonSingle.TabIndex = 0;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Single";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchForAvailability
            // 
            this.groupBoxSearchForAvailability.Controls.Add(this.groupBox1);
            this.groupBoxSearchForAvailability.Controls.Add(this.btnSearch);
            this.groupBoxSearchForAvailability.Controls.Add(this.textBoxNumOfNights);
            this.groupBoxSearchForAvailability.Controls.Add(this.lblNumOfNights);
            this.groupBoxSearchForAvailability.Controls.Add(this.lblCheckInDate);
            this.groupBoxSearchForAvailability.Controls.Add(this.groupBoxRoomType);
            this.groupBoxSearchForAvailability.Controls.Add(this.lblCheckOutDate);
            this.groupBoxSearchForAvailability.Controls.Add(this.DTPCheckOutDate);
            this.groupBoxSearchForAvailability.Controls.Add(this.DTPCheckInDate);
            this.groupBoxSearchForAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchForAvailability.Location = new System.Drawing.Point(12, 74);
            this.groupBoxSearchForAvailability.Name = "groupBoxSearchForAvailability";
            this.groupBoxSearchForAvailability.Size = new System.Drawing.Size(449, 508);
            this.groupBoxSearchForAvailability.TabIndex = 19;
            this.groupBoxSearchForAvailability.TabStop = false;
            this.groupBoxSearchForAvailability.Text = "Search For Availability";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNonSmoking);
            this.groupBox1.Controls.Add(this.radioButtonSmoking);
            this.groupBox1.Location = new System.Drawing.Point(233, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 145);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smoking / Non- Smoking";
            // 
            // radioButtonNonSmoking
            // 
            this.radioButtonNonSmoking.AutoSize = true;
            this.radioButtonNonSmoking.Location = new System.Drawing.Point(10, 60);
            this.radioButtonNonSmoking.Name = "radioButtonNonSmoking";
            this.radioButtonNonSmoking.Size = new System.Drawing.Size(123, 24);
            this.radioButtonNonSmoking.TabIndex = 3;
            this.radioButtonNonSmoking.TabStop = true;
            this.radioButtonNonSmoking.Text = "Non-Smoking";
            this.radioButtonNonSmoking.UseVisualStyleBackColor = true;
            // 
            // radioButtonSmoking
            // 
            this.radioButtonSmoking.AutoSize = true;
            this.radioButtonSmoking.Location = new System.Drawing.Point(10, 30);
            this.radioButtonSmoking.Name = "radioButtonSmoking";
            this.radioButtonSmoking.Size = new System.Drawing.Size(89, 24);
            this.radioButtonSmoking.TabIndex = 1;
            this.radioButtonSmoking.TabStop = true;
            this.radioButtonSmoking.Text = "Smoking";
            this.radioButtonSmoking.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(19, 394);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(416, 48);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // textBoxNumOfNights
            // 
            this.textBoxNumOfNights.Location = new System.Drawing.Point(157, 323);
            this.textBoxNumOfNights.Name = "textBoxNumOfNights";
            this.textBoxNumOfNights.ReadOnly = true;
            this.textBoxNumOfNights.Size = new System.Drawing.Size(52, 26);
            this.textBoxNumOfNights.TabIndex = 20;
            // 
            // lblNumOfNights
            // 
            this.lblNumOfNights.AutoSize = true;
            this.lblNumOfNights.Location = new System.Drawing.Point(15, 324);
            this.lblNumOfNights.Name = "lblNumOfNights";
            this.lblNumOfNights.Size = new System.Drawing.Size(135, 20);
            this.lblNumOfNights.TabIndex = 19;
            this.lblNumOfNights.Text = "Number Of Nights";
            // 
            // groupBoxGuestDetails
            // 
            this.groupBoxGuestDetails.Controls.Add(this.textBoxNumOfChildren);
            this.groupBoxGuestDetails.Controls.Add(this.label3);
            this.groupBoxGuestDetails.Controls.Add(this.groupBox2);
            this.groupBoxGuestDetails.Controls.Add(this.textBoxEmail);
            this.groupBoxGuestDetails.Controls.Add(this.label1);
            this.groupBoxGuestDetails.Controls.Add(this.groupBoxSendMarketingInfo);
            this.groupBoxGuestDetails.Controls.Add(this.groupBoxDepositPayed);
            this.groupBoxGuestDetails.Controls.Add(this.textBoxAddress);
            this.groupBoxGuestDetails.Controls.Add(this.label2);
            this.groupBoxGuestDetails.Controls.Add(this.textBoxContact);
            this.groupBoxGuestDetails.Controls.Add(this.lblContact);
            this.groupBoxGuestDetails.Controls.Add(this.textBoxSurname);
            this.groupBoxGuestDetails.Controls.Add(this.textBoxFirstName);
            this.groupBoxGuestDetails.Controls.Add(this.btnSubmitReservation);
            this.groupBoxGuestDetails.Controls.Add(this.textBoxNumOfAdults);
            this.groupBoxGuestDetails.Controls.Add(this.lblNumberOfAdults);
            this.groupBoxGuestDetails.Controls.Add(this.lblFirstName);
            this.groupBoxGuestDetails.Controls.Add(this.lblSurname);
            this.groupBoxGuestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGuestDetails.Location = new System.Drawing.Point(800, 74);
            this.groupBoxGuestDetails.Name = "groupBoxGuestDetails";
            this.groupBoxGuestDetails.Size = new System.Drawing.Size(449, 457);
            this.groupBoxGuestDetails.TabIndex = 22;
            this.groupBoxGuestDetails.TabStop = false;
            this.groupBoxGuestDetails.Text = "Guest Details";
            // 
            // textBoxNumOfChildren
            // 
            this.textBoxNumOfChildren.Location = new System.Drawing.Point(373, 180);
            this.textBoxNumOfChildren.Name = "textBoxNumOfChildren";
            this.textBoxNumOfChildren.Size = new System.Drawing.Size(45, 26);
            this.textBoxNumOfChildren.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Number Of Children";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonPIFNo);
            this.groupBox2.Controls.Add(this.radioButtonPIFYes);
            this.groupBox2.Location = new System.Drawing.Point(19, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 51);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payed In Full";
            // 
            // radioButtonPIFNo
            // 
            this.radioButtonPIFNo.AutoSize = true;
            this.radioButtonPIFNo.Location = new System.Drawing.Point(117, 25);
            this.radioButtonPIFNo.Name = "radioButtonPIFNo";
            this.radioButtonPIFNo.Size = new System.Drawing.Size(47, 24);
            this.radioButtonPIFNo.TabIndex = 1;
            this.radioButtonPIFNo.TabStop = true;
            this.radioButtonPIFNo.Text = "No";
            this.radioButtonPIFNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonPIFYes
            // 
            this.radioButtonPIFYes.AutoSize = true;
            this.radioButtonPIFYes.Location = new System.Drawing.Point(19, 25);
            this.radioButtonPIFYes.Name = "radioButtonPIFYes";
            this.radioButtonPIFYes.Size = new System.Drawing.Size(55, 24);
            this.radioButtonPIFYes.TabIndex = 0;
            this.radioButtonPIFYes.TabStop = true;
            this.radioButtonPIFYes.Text = "Yes";
            this.radioButtonPIFYes.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(108, 147);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(327, 26);
            this.textBoxEmail.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Email";
            // 
            // groupBoxSendMarketingInfo
            // 
            this.groupBoxSendMarketingInfo.Controls.Add(this.radioButtonMINo);
            this.groupBoxSendMarketingInfo.Controls.Add(this.radioButtonMIYes);
            this.groupBoxSendMarketingInfo.Location = new System.Drawing.Point(19, 273);
            this.groupBoxSendMarketingInfo.Name = "groupBoxSendMarketingInfo";
            this.groupBoxSendMarketingInfo.Size = new System.Drawing.Size(416, 51);
            this.groupBoxSendMarketingInfo.TabIndex = 29;
            this.groupBoxSendMarketingInfo.TabStop = false;
            this.groupBoxSendMarketingInfo.Text = "Send Marketing Information";
            // 
            // radioButtonMINo
            // 
            this.radioButtonMINo.AutoSize = true;
            this.radioButtonMINo.Location = new System.Drawing.Point(117, 25);
            this.radioButtonMINo.Name = "radioButtonMINo";
            this.radioButtonMINo.Size = new System.Drawing.Size(47, 24);
            this.radioButtonMINo.TabIndex = 1;
            this.radioButtonMINo.TabStop = true;
            this.radioButtonMINo.Text = "No";
            this.radioButtonMINo.UseVisualStyleBackColor = true;
            // 
            // radioButtonMIYes
            // 
            this.radioButtonMIYes.AutoSize = true;
            this.radioButtonMIYes.Location = new System.Drawing.Point(19, 25);
            this.radioButtonMIYes.Name = "radioButtonMIYes";
            this.radioButtonMIYes.Size = new System.Drawing.Size(55, 24);
            this.radioButtonMIYes.TabIndex = 0;
            this.radioButtonMIYes.TabStop = true;
            this.radioButtonMIYes.Text = "Yes";
            this.radioButtonMIYes.UseVisualStyleBackColor = true;
            // 
            // groupBoxDepositPayed
            // 
            this.groupBoxDepositPayed.Controls.Add(this.radioButtonDPNo);
            this.groupBoxDepositPayed.Controls.Add(this.radioButtonDPYes);
            this.groupBoxDepositPayed.Location = new System.Drawing.Point(19, 212);
            this.groupBoxDepositPayed.Name = "groupBoxDepositPayed";
            this.groupBoxDepositPayed.Size = new System.Drawing.Size(416, 55);
            this.groupBoxDepositPayed.TabIndex = 28;
            this.groupBoxDepositPayed.TabStop = false;
            this.groupBoxDepositPayed.Text = "Deposit Payed";
            // 
            // radioButtonDPNo
            // 
            this.radioButtonDPNo.AutoSize = true;
            this.radioButtonDPNo.Location = new System.Drawing.Point(117, 25);
            this.radioButtonDPNo.Name = "radioButtonDPNo";
            this.radioButtonDPNo.Size = new System.Drawing.Size(47, 24);
            this.radioButtonDPNo.TabIndex = 1;
            this.radioButtonDPNo.TabStop = true;
            this.radioButtonDPNo.Text = "No";
            this.radioButtonDPNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonDPYes
            // 
            this.radioButtonDPYes.AutoSize = true;
            this.radioButtonDPYes.Location = new System.Drawing.Point(19, 25);
            this.radioButtonDPYes.Name = "radioButtonDPYes";
            this.radioButtonDPYes.Size = new System.Drawing.Size(55, 24);
            this.radioButtonDPYes.TabIndex = 0;
            this.radioButtonDPYes.TabStop = true;
            this.radioButtonDPYes.Text = "Yes";
            this.radioButtonDPYes.UseVisualStyleBackColor = true;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(108, 113);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(327, 26);
            this.textBoxAddress.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Address";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(108, 81);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(327, 26);
            this.textBoxContact.TabIndex = 25;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(15, 87);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(89, 20);
            this.lblContact.TabIndex = 24;
            this.lblContact.Text = "Contact No";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(108, 49);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(327, 26);
            this.textBoxSurname.TabIndex = 23;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(108, 16);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(327, 26);
            this.textBoxFirstName.TabIndex = 22;
            // 
            // btnSubmitReservation
            // 
            this.btnSubmitReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSubmitReservation.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReservation.Location = new System.Drawing.Point(19, 394);
            this.btnSubmitReservation.Name = "btnSubmitReservation";
            this.btnSubmitReservation.Size = new System.Drawing.Size(416, 48);
            this.btnSubmitReservation.TabIndex = 21;
            this.btnSubmitReservation.Text = "Submit Reservation";
            this.btnSubmitReservation.UseVisualStyleBackColor = false;
            this.btnSubmitReservation.Click += new System.EventHandler(this.BtnSubmitReservation_Click);
            // 
            // textBoxNumOfAdults
            // 
            this.textBoxNumOfAdults.Location = new System.Drawing.Point(163, 180);
            this.textBoxNumOfAdults.Name = "textBoxNumOfAdults";
            this.textBoxNumOfAdults.Size = new System.Drawing.Size(45, 26);
            this.textBoxNumOfAdults.TabIndex = 20;
            // 
            // lblNumberOfAdults
            // 
            this.lblNumberOfAdults.AutoSize = true;
            this.lblNumberOfAdults.Location = new System.Drawing.Point(15, 183);
            this.lblNumberOfAdults.Name = "lblNumberOfAdults";
            this.lblNumberOfAdults.Size = new System.Drawing.Size(135, 20);
            this.lblNumberOfAdults.TabIndex = 19;
            this.lblNumberOfAdults.Text = "Number Of Adults";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 22);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(15, 55);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(74, 20);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Surname";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1096, 537);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 51);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBoxRoomDetails
            // 
            this.groupBoxRoomDetails.Controls.Add(this.listBoxSelectedRoom);
            this.groupBoxRoomDetails.Controls.Add(this.textBoxVariablePrice);
            this.groupBoxRoomDetails.Controls.Add(this.textBoxBasePrice);
            this.groupBoxRoomDetails.Controls.Add(this.textBoxRoomNumber);
            this.groupBoxRoomDetails.Controls.Add(this.lblVariablePrice);
            this.groupBoxRoomDetails.Controls.Add(this.lblBasePrice);
            this.groupBoxRoomDetails.Controls.Add(this.lbl);
            this.groupBoxRoomDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRoomDetails.Location = new System.Drawing.Point(477, 74);
            this.groupBoxRoomDetails.Name = "groupBoxRoomDetails";
            this.groupBoxRoomDetails.Size = new System.Drawing.Size(305, 508);
            this.groupBoxRoomDetails.TabIndex = 24;
            this.groupBoxRoomDetails.TabStop = false;
            this.groupBoxRoomDetails.Text = "Room Details";
            // 
            // listBoxSelectedRoom
            // 
            this.listBoxSelectedRoom.FormattingEnabled = true;
            this.listBoxSelectedRoom.ItemHeight = 20;
            this.listBoxSelectedRoom.Location = new System.Drawing.Point(10, 33);
            this.listBoxSelectedRoom.Name = "listBoxSelectedRoom";
            this.listBoxSelectedRoom.Size = new System.Drawing.Size(287, 244);
            this.listBoxSelectedRoom.TabIndex = 6;
            this.listBoxSelectedRoom.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedRoom_SelectedIndexChanged);
            // 
            // textBoxVariablePrice
            // 
            this.textBoxVariablePrice.Location = new System.Drawing.Point(10, 437);
            this.textBoxVariablePrice.Name = "textBoxVariablePrice";
            this.textBoxVariablePrice.Size = new System.Drawing.Size(288, 26);
            this.textBoxVariablePrice.TabIndex = 5;
            // 
            // textBoxBasePrice
            // 
            this.textBoxBasePrice.Location = new System.Drawing.Point(9, 373);
            this.textBoxBasePrice.Name = "textBoxBasePrice";
            this.textBoxBasePrice.ReadOnly = true;
            this.textBoxBasePrice.Size = new System.Drawing.Size(288, 26);
            this.textBoxBasePrice.TabIndex = 4;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(10, 308);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.ReadOnly = true;
            this.textBoxRoomNumber.Size = new System.Drawing.Size(288, 26);
            this.textBoxRoomNumber.TabIndex = 3;
            // 
            // lblVariablePrice
            // 
            this.lblVariablePrice.AutoSize = true;
            this.lblVariablePrice.Location = new System.Drawing.Point(5, 413);
            this.lblVariablePrice.Name = "lblVariablePrice";
            this.lblVariablePrice.Size = new System.Drawing.Size(110, 20);
            this.lblVariablePrice.TabIndex = 2;
            this.lblVariablePrice.Text = "Variable Price ";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(5, 344);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(85, 20);
            this.lblBasePrice.TabIndex = 1;
            this.lblBasePrice.Text = "Base Price";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 287);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(112, 20);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Room Number";
            // 
            // formCreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1261, 594);
            this.Controls.Add(this.groupBoxRoomDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBoxGuestDetails);
            this.Controls.Add(this.groupBoxSearchForAvailability);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCreateReservation";
            this.Text = "formCreateReservation";
            this.Load += new System.EventHandler(this.FormCreateReservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxRoomType.ResumeLayout(false);
            this.groupBoxRoomType.PerformLayout();
            this.groupBoxSearchForAvailability.ResumeLayout(false);
            this.groupBoxSearchForAvailability.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxGuestDetails.ResumeLayout(false);
            this.groupBoxGuestDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSendMarketingInfo.ResumeLayout(false);
            this.groupBoxSendMarketingInfo.PerformLayout();
            this.groupBoxDepositPayed.ResumeLayout(false);
            this.groupBoxDepositPayed.PerformLayout();
            this.groupBoxRoomDetails.ResumeLayout(false);
            this.groupBoxRoomDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCreateReservation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.DateTimePicker DTPCheckInDate;
        private System.Windows.Forms.DateTimePicker DTPCheckOutDate;
        private System.Windows.Forms.GroupBox groupBoxRoomType;
        private System.Windows.Forms.RadioButton radioButtonTwin;
        private System.Windows.Forms.RadioButton radioButtonDouble;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.GroupBox groupBoxSearchForAvailability;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxNumOfNights;
        private System.Windows.Forms.Label lblNumOfNights;
        private System.Windows.Forms.GroupBox groupBoxGuestDetails;
        private System.Windows.Forms.GroupBox groupBoxSendMarketingInfo;
        private System.Windows.Forms.RadioButton radioButtonMINo;
        private System.Windows.Forms.RadioButton radioButtonMIYes;
        private System.Windows.Forms.GroupBox groupBoxDepositPayed;
        private System.Windows.Forms.RadioButton radioButtonDPNo;
        private System.Windows.Forms.RadioButton radioButtonDPYes;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button btnSubmitReservation;
        private System.Windows.Forms.TextBox textBoxNumOfAdults;
        private System.Windows.Forms.Label lblNumberOfAdults;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBoxRoomDetails;
        private System.Windows.Forms.ListBox listBoxSelectedRoom;
        private System.Windows.Forms.TextBox textBoxVariablePrice;
        private System.Windows.Forms.TextBox textBoxBasePrice;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Label lblVariablePrice;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNonSmoking;
        private System.Windows.Forms.RadioButton radioButtonSmoking;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonPIFNo;
        private System.Windows.Forms.RadioButton radioButtonPIFYes;
        private System.Windows.Forms.TextBox textBoxNumOfChildren;
        private System.Windows.Forms.Label label3;
    }
}