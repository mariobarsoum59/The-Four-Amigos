namespace BloomFeildHotel
{
    partial class formReservation
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
            this.textBoxNumOfNights = new System.Windows.Forms.TextBox();
            this.lblNumOfNights = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.groupBoxRoomType = new System.Windows.Forms.GroupBox();
            this.radioButtonTwinSmoking = new System.Windows.Forms.RadioButton();
            this.radioButtonTwinNonSmoking = new System.Windows.Forms.RadioButton();
            this.radioButtonDoubleSmoking = new System.Windows.Forms.RadioButton();
            this.radioButtonDoubleNonSmoking = new System.Windows.Forms.RadioButton();
            this.radioButtonSingleSmoking = new System.Windows.Forms.RadioButton();
            this.radioButtonSingleNonSmoking = new System.Windows.Forms.RadioButton();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.DTPCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.DTPCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReservation = new System.Windows.Forms.Label();
            this.listBoxSelectedRoom = new System.Windows.Forms.ListBox();
            this.textBoxVariablePrice = new System.Windows.Forms.TextBox();
            this.textBoxBasePrice = new System.Windows.Forms.TextBox();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.lblVariablePrice = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxSendMarketingInfo = new System.Windows.Forms.GroupBox();
            this.radioButtonMINo = new System.Windows.Forms.RadioButton();
            this.radioButtonMIYes = new System.Windows.Forms.RadioButton();
            this.groupBoxDepositPayed = new System.Windows.Forms.GroupBox();
            this.radioButtonDPNo = new System.Windows.Forms.RadioButton();
            this.radioButtonDPYes = new System.Windows.Forms.RadioButton();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfGuests = new System.Windows.Forms.TextBox();
            this.lblNumberOfGuests = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxRoomType.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxSendMarketingInfo.SuspendLayout();
            this.groupBoxDepositPayed.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNumOfNights
            // 
            this.textBoxNumOfNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumOfNights.Location = new System.Drawing.Point(148, 337);
            this.textBoxNumOfNights.Name = "textBoxNumOfNights";
            this.textBoxNumOfNights.ReadOnly = true;
            this.textBoxNumOfNights.Size = new System.Drawing.Size(52, 21);
            this.textBoxNumOfNights.TabIndex = 20;
            // 
            // lblNumOfNights
            // 
            this.lblNumOfNights.AutoSize = true;
            this.lblNumOfNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfNights.Location = new System.Drawing.Point(37, 337);
            this.lblNumOfNights.Name = "lblNumOfNights";
            this.lblNumOfNights.Size = new System.Drawing.Size(105, 15);
            this.lblNumOfNights.TabIndex = 19;
            this.lblNumOfNights.Text = "Number Of Nights";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInDate.Location = new System.Drawing.Point(37, 102);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(83, 15);
            this.lblCheckInDate.TabIndex = 13;
            this.lblCheckInDate.Text = "Check In Date";
            // 
            // groupBoxRoomType
            // 
            this.groupBoxRoomType.Controls.Add(this.radioButtonTwinSmoking);
            this.groupBoxRoomType.Controls.Add(this.radioButtonTwinNonSmoking);
            this.groupBoxRoomType.Controls.Add(this.radioButtonDoubleSmoking);
            this.groupBoxRoomType.Controls.Add(this.radioButtonDoubleNonSmoking);
            this.groupBoxRoomType.Controls.Add(this.radioButtonSingleSmoking);
            this.groupBoxRoomType.Controls.Add(this.radioButtonSingleNonSmoking);
            this.groupBoxRoomType.Location = new System.Drawing.Point(40, 174);
            this.groupBoxRoomType.Name = "groupBoxRoomType";
            this.groupBoxRoomType.Size = new System.Drawing.Size(330, 145);
            this.groupBoxRoomType.TabIndex = 18;
            this.groupBoxRoomType.TabStop = false;
            this.groupBoxRoomType.Text = "Room Type";
            // 
            // radioButtonTwinSmoking
            // 
            this.radioButtonTwinSmoking.AutoSize = true;
            this.radioButtonTwinSmoking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTwinSmoking.Location = new System.Drawing.Point(210, 85);
            this.radioButtonTwinSmoking.Name = "radioButtonTwinSmoking";
            this.radioButtonTwinSmoking.Size = new System.Drawing.Size(103, 19);
            this.radioButtonTwinSmoking.TabIndex = 5;
            this.radioButtonTwinSmoking.TabStop = true;
            this.radioButtonTwinSmoking.Text = "Twin Smoking";
            this.radioButtonTwinSmoking.UseVisualStyleBackColor = true;
            // 
            // radioButtonTwinNonSmoking
            // 
            this.radioButtonTwinNonSmoking.AutoSize = true;
            this.radioButtonTwinNonSmoking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTwinNonSmoking.Location = new System.Drawing.Point(19, 85);
            this.radioButtonTwinNonSmoking.Name = "radioButtonTwinNonSmoking";
            this.radioButtonTwinNonSmoking.Size = new System.Drawing.Size(130, 19);
            this.radioButtonTwinNonSmoking.TabIndex = 4;
            this.radioButtonTwinNonSmoking.TabStop = true;
            this.radioButtonTwinNonSmoking.Text = "Twin Non-Smoking";
            this.radioButtonTwinNonSmoking.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoubleSmoking
            // 
            this.radioButtonDoubleSmoking.AutoSize = true;
            this.radioButtonDoubleSmoking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDoubleSmoking.Location = new System.Drawing.Point(210, 55);
            this.radioButtonDoubleSmoking.Name = "radioButtonDoubleSmoking";
            this.radioButtonDoubleSmoking.Size = new System.Drawing.Size(117, 19);
            this.radioButtonDoubleSmoking.TabIndex = 3;
            this.radioButtonDoubleSmoking.TabStop = true;
            this.radioButtonDoubleSmoking.Text = "Double Smoking";
            this.radioButtonDoubleSmoking.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoubleNonSmoking
            // 
            this.radioButtonDoubleNonSmoking.AutoSize = true;
            this.radioButtonDoubleNonSmoking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDoubleNonSmoking.Location = new System.Drawing.Point(19, 55);
            this.radioButtonDoubleNonSmoking.Name = "radioButtonDoubleNonSmoking";
            this.radioButtonDoubleNonSmoking.Size = new System.Drawing.Size(144, 19);
            this.radioButtonDoubleNonSmoking.TabIndex = 2;
            this.radioButtonDoubleNonSmoking.TabStop = true;
            this.radioButtonDoubleNonSmoking.Text = "Double Non-Smoking";
            this.radioButtonDoubleNonSmoking.UseVisualStyleBackColor = true;
            // 
            // radioButtonSingleSmoking
            // 
            this.radioButtonSingleSmoking.AutoSize = true;
            this.radioButtonSingleSmoking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSingleSmoking.Location = new System.Drawing.Point(210, 25);
            this.radioButtonSingleSmoking.Name = "radioButtonSingleSmoking";
            this.radioButtonSingleSmoking.Size = new System.Drawing.Size(112, 19);
            this.radioButtonSingleSmoking.TabIndex = 1;
            this.radioButtonSingleSmoking.TabStop = true;
            this.radioButtonSingleSmoking.Text = "Single Smoking";
            this.radioButtonSingleSmoking.UseVisualStyleBackColor = true;
            // 
            // radioButtonSingleNonSmoking
            // 
            this.radioButtonSingleNonSmoking.AutoSize = true;
            this.radioButtonSingleNonSmoking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSingleNonSmoking.Location = new System.Drawing.Point(19, 25);
            this.radioButtonSingleNonSmoking.Name = "radioButtonSingleNonSmoking";
            this.radioButtonSingleNonSmoking.Size = new System.Drawing.Size(139, 19);
            this.radioButtonSingleNonSmoking.TabIndex = 0;
            this.radioButtonSingleNonSmoking.TabStop = true;
            this.radioButtonSingleNonSmoking.Text = "Single Non-Smoking";
            this.radioButtonSingleNonSmoking.UseVisualStyleBackColor = true;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutDate.Location = new System.Drawing.Point(37, 124);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(92, 15);
            this.lblCheckOutDate.TabIndex = 14;
            this.lblCheckOutDate.Text = "Check Out Date";
            // 
            // DTPCheckOutDate
            // 
            this.DTPCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPCheckOutDate.Location = new System.Drawing.Point(147, 124);
            this.DTPCheckOutDate.Name = "DTPCheckOutDate";
            this.DTPCheckOutDate.Size = new System.Drawing.Size(214, 21);
            this.DTPCheckOutDate.TabIndex = 17;
            // 
            // DTPCheckInDate
            // 
            this.DTPCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPCheckInDate.Location = new System.Drawing.Point(148, 98);
            this.DTPCheckInDate.Name = "DTPCheckInDate";
            this.DTPCheckInDate.Size = new System.Drawing.Size(214, 21);
            this.DTPCheckInDate.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblReservation);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 66);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(277, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservation.ForeColor = System.Drawing.Color.White;
            this.lblReservation.Location = new System.Drawing.Point(17, 13);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(263, 39);
            this.lblReservation.TabIndex = 1;
            this.lblReservation.Text = "Reservation for:";
            // 
            // listBoxSelectedRoom
            // 
            this.listBoxSelectedRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelectedRoom.FormattingEnabled = true;
            this.listBoxSelectedRoom.ItemHeight = 15;
            this.listBoxSelectedRoom.Location = new System.Drawing.Point(404, 102);
            this.listBoxSelectedRoom.Name = "listBoxSelectedRoom";
            this.listBoxSelectedRoom.Size = new System.Drawing.Size(123, 79);
            this.listBoxSelectedRoom.TabIndex = 6;
            // 
            // textBoxVariablePrice
            // 
            this.textBoxVariablePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVariablePrice.Location = new System.Drawing.Point(404, 312);
            this.textBoxVariablePrice.Name = "textBoxVariablePrice";
            this.textBoxVariablePrice.Size = new System.Drawing.Size(123, 21);
            this.textBoxVariablePrice.TabIndex = 5;
            // 
            // textBoxBasePrice
            // 
            this.textBoxBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBasePrice.Location = new System.Drawing.Point(404, 266);
            this.textBoxBasePrice.Name = "textBoxBasePrice";
            this.textBoxBasePrice.Size = new System.Drawing.Size(123, 21);
            this.textBoxBasePrice.TabIndex = 4;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomNumber.Location = new System.Drawing.Point(404, 222);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(123, 21);
            this.textBoxRoomNumber.TabIndex = 3;
            // 
            // lblVariablePrice
            // 
            this.lblVariablePrice.AutoSize = true;
            this.lblVariablePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariablePrice.Location = new System.Drawing.Point(430, 296);
            this.lblVariablePrice.Name = "lblVariablePrice";
            this.lblVariablePrice.Size = new System.Drawing.Size(86, 15);
            this.lblVariablePrice.TabIndex = 2;
            this.lblVariablePrice.Text = "Variable Price ";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(439, 250);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(66, 15);
            this.lblBasePrice.TabIndex = 1;
            this.lblBasePrice.Text = "Base Price";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(430, 206);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(89, 15);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Room Info";
            // 
            // groupBoxSendMarketingInfo
            // 
            this.groupBoxSendMarketingInfo.Controls.Add(this.radioButtonMINo);
            this.groupBoxSendMarketingInfo.Controls.Add(this.radioButtonMIYes);
            this.groupBoxSendMarketingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSendMarketingInfo.Location = new System.Drawing.Point(567, 341);
            this.groupBoxSendMarketingInfo.Name = "groupBoxSendMarketingInfo";
            this.groupBoxSendMarketingInfo.Size = new System.Drawing.Size(181, 67);
            this.groupBoxSendMarketingInfo.TabIndex = 29;
            this.groupBoxSendMarketingInfo.TabStop = false;
            this.groupBoxSendMarketingInfo.Text = "Send Marketing Information";
            // 
            // radioButtonMINo
            // 
            this.radioButtonMINo.AutoSize = true;
            this.radioButtonMINo.Location = new System.Drawing.Point(117, 25);
            this.radioButtonMINo.Name = "radioButtonMINo";
            this.radioButtonMINo.Size = new System.Drawing.Size(41, 19);
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
            this.radioButtonMIYes.Size = new System.Drawing.Size(45, 19);
            this.radioButtonMIYes.TabIndex = 0;
            this.radioButtonMIYes.TabStop = true;
            this.radioButtonMIYes.Text = "Yes";
            this.radioButtonMIYes.UseVisualStyleBackColor = true;
            // 
            // groupBoxDepositPayed
            // 
            this.groupBoxDepositPayed.Controls.Add(this.radioButtonDPNo);
            this.groupBoxDepositPayed.Controls.Add(this.radioButtonDPYes);
            this.groupBoxDepositPayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDepositPayed.Location = new System.Drawing.Point(567, 257);
            this.groupBoxDepositPayed.Name = "groupBoxDepositPayed";
            this.groupBoxDepositPayed.Size = new System.Drawing.Size(181, 67);
            this.groupBoxDepositPayed.TabIndex = 28;
            this.groupBoxDepositPayed.TabStop = false;
            this.groupBoxDepositPayed.Text = "Deposit Paid";
            // 
            // radioButtonDPNo
            // 
            this.radioButtonDPNo.AutoSize = true;
            this.radioButtonDPNo.Location = new System.Drawing.Point(117, 25);
            this.radioButtonDPNo.Name = "radioButtonDPNo";
            this.radioButtonDPNo.Size = new System.Drawing.Size(41, 19);
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
            this.radioButtonDPYes.Size = new System.Drawing.Size(45, 19);
            this.radioButtonDPYes.TabIndex = 0;
            this.radioButtonDPYes.TabStop = true;
            this.radioButtonDPYes.Text = "Yes";
            this.radioButtonDPYes.UseVisualStyleBackColor = true;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(629, 189);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(120, 21);
            this.textBoxAddress.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Address";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(629, 157);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(120, 21);
            this.textBoxContact.TabIndex = 25;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(563, 163);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(48, 15);
            this.lblContact.TabIndex = 24;
            this.lblContact.Text = "Contact";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(629, 125);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(120, 21);
            this.textBoxSurname.TabIndex = 23;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(629, 94);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(120, 21);
            this.textBoxFirstName.TabIndex = 22;
            // 
            // textBoxNumberOfGuests
            // 
            this.textBoxNumberOfGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfGuests.Location = new System.Drawing.Point(687, 218);
            this.textBoxNumberOfGuests.Name = "textBoxNumberOfGuests";
            this.textBoxNumberOfGuests.Size = new System.Drawing.Size(63, 21);
            this.textBoxNumberOfGuests.TabIndex = 20;
            // 
            // lblNumberOfGuests
            // 
            this.lblNumberOfGuests.AutoSize = true;
            this.lblNumberOfGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGuests.Location = new System.Drawing.Point(563, 222);
            this.lblNumberOfGuests.Name = "lblNumberOfGuests";
            this.lblNumberOfGuests.Size = new System.Drawing.Size(108, 15);
            this.lblNumberOfGuests.TabIndex = 19;
            this.lblNumberOfGuests.Text = "Number Of Guests";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(563, 98);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(563, 131);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(58, 15);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Surname";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(219, 356);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 35);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(305, 356);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 35);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // formReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(777, 421);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBoxSendMarketingInfo);
            this.Controls.Add(this.groupBoxDepositPayed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.lblVariablePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVariablePrice);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.listBoxSelectedRoom);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.textBoxBasePrice);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxNumberOfGuests);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblNumberOfGuests);
            this.Controls.Add(this.textBoxNumOfNights);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.lblNumOfNights);
            this.Controls.Add(this.DTPCheckInDate);
            this.Controls.Add(this.groupBoxRoomType);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.DTPCheckOutDate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formReservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.groupBoxRoomType.ResumeLayout(false);
            this.groupBoxRoomType.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxSendMarketingInfo.ResumeLayout(false);
            this.groupBoxSendMarketingInfo.PerformLayout();
            this.groupBoxDepositPayed.ResumeLayout(false);
            this.groupBoxDepositPayed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumOfNights;
        private System.Windows.Forms.Label lblNumOfNights;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.GroupBox groupBoxRoomType;
        private System.Windows.Forms.RadioButton radioButtonTwinSmoking;
        private System.Windows.Forms.RadioButton radioButtonTwinNonSmoking;
        private System.Windows.Forms.RadioButton radioButtonDoubleSmoking;
        private System.Windows.Forms.RadioButton radioButtonDoubleNonSmoking;
        private System.Windows.Forms.RadioButton radioButtonSingleSmoking;
        private System.Windows.Forms.RadioButton radioButtonSingleNonSmoking;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.DateTimePicker DTPCheckOutDate;
        private System.Windows.Forms.DateTimePicker DTPCheckInDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.ListBox listBoxSelectedRoom;
        private System.Windows.Forms.TextBox textBoxVariablePrice;
        private System.Windows.Forms.TextBox textBoxBasePrice;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Label lblVariablePrice;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxSendMarketingInfo;
        private System.Windows.Forms.RadioButton radioButtonMINo;
        private System.Windows.Forms.RadioButton radioButtonMIYes;
        private System.Windows.Forms.GroupBox groupBoxDepositPayed;
        private System.Windows.Forms.RadioButton radioButtonDPNo;
        private System.Windows.Forms.RadioButton radioButtonDPYes;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxNumberOfGuests;
        private System.Windows.Forms.Label lblNumberOfGuests;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
    }
}