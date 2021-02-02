namespace BloomFeildHotel
{
    partial class formManageReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbReservation = new System.Windows.Forms.GroupBox();
            this.numNights = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbPaidNo = new System.Windows.Forms.RadioButton();
            this.numAdults = new System.Windows.Forms.NumericUpDown();
            this.rbPaidYes = new System.Windows.Forms.RadioButton();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.gbDeposit = new System.Windows.Forms.GroupBox();
            this.rbDepositYes = new System.Windows.Forms.RadioButton();
            this.rbDepositNo = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.numChildren = new System.Windows.Forms.NumericUpDown();
            this.tbRoomPrice = new System.Windows.Forms.TextBox();
            this.tbRoomType = new System.Windows.Forms.TextBox();
            this.tbReservationID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gbGuest = new System.Windows.Forms.GroupBox();
            this.tbGuestID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.rbMarketingYes = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.rbMarketingNo = new System.Windows.Forms.RadioButton();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.cbRoomNum = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSmoking = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gbReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).BeginInit();
            this.gbGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Reservation";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(19, 583);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 33);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1075, 418);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 33);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(874, 418);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reservation ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of Nights:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Reservation Price:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Check-out Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Check-in Date:";
            // 
            // gbReservation
            // 
            this.gbReservation.Controls.Add(this.btnCheckOut);
            this.gbReservation.Controls.Add(this.txtSmoking);
            this.gbReservation.Controls.Add(this.label21);
            this.gbReservation.Controls.Add(this.gbGuest);
            this.gbReservation.Controls.Add(this.pictureBox1);
            this.gbReservation.Controls.Add(this.btnDelete);
            this.gbReservation.Controls.Add(this.cbRoomNum);
            this.gbReservation.Controls.Add(this.numNights);
            this.gbReservation.Controls.Add(this.btnUpdate);
            this.gbReservation.Controls.Add(this.numAdults);
            this.gbReservation.Controls.Add(this.dtpCheckIn);
            this.gbReservation.Controls.Add(this.dtpCheckOut);
            this.gbReservation.Controls.Add(this.gbDeposit);
            this.gbReservation.Controls.Add(this.numChildren);
            this.gbReservation.Controls.Add(this.tbRoomType);
            this.gbReservation.Controls.Add(this.tbReservationID);
            this.gbReservation.Controls.Add(this.label17);
            this.gbReservation.Controls.Add(this.label16);
            this.gbReservation.Controls.Add(this.label2);
            this.gbReservation.Controls.Add(this.label8);
            this.gbReservation.Controls.Add(this.label3);
            this.gbReservation.Controls.Add(this.label7);
            this.gbReservation.Controls.Add(this.label4);
            this.gbReservation.Controls.Add(this.label5);
            this.gbReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReservation.Location = new System.Drawing.Point(12, 118);
            this.gbReservation.Name = "gbReservation";
            this.gbReservation.Size = new System.Drawing.Size(1241, 459);
            this.gbReservation.TabIndex = 11;
            this.gbReservation.TabStop = false;
            this.gbReservation.Text = "Reservation Details";
            // 
            // numNights
            // 
            this.numNights.Location = new System.Drawing.Point(137, 288);
            this.numNights.Name = "numNights";
            this.numNights.ReadOnly = true;
            this.numNights.Size = new System.Drawing.Size(109, 26);
            this.numNights.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(51, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "Paid in Full:";
            // 
            // rbPaidNo
            // 
            this.rbPaidNo.AutoSize = true;
            this.rbPaidNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaidNo.Location = new System.Drawing.Point(210, 79);
            this.rbPaidNo.Name = "rbPaidNo";
            this.rbPaidNo.Size = new System.Drawing.Size(44, 20);
            this.rbPaidNo.TabIndex = 31;
            this.rbPaidNo.TabStop = true;
            this.rbPaidNo.Text = "No";
            this.rbPaidNo.UseVisualStyleBackColor = true;
            // 
            // numAdults
            // 
            this.numAdults.Location = new System.Drawing.Point(137, 334);
            this.numAdults.Name = "numAdults";
            this.numAdults.Size = new System.Drawing.Size(109, 26);
            this.numAdults.TabIndex = 36;
            this.numAdults.ValueChanged += new System.EventHandler(this.numGuests_ValueChanged);
            // 
            // rbPaidYes
            // 
            this.rbPaidYes.AutoSize = true;
            this.rbPaidYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaidYes.Location = new System.Drawing.Point(137, 79);
            this.rbPaidYes.Name = "rbPaidYes";
            this.rbPaidYes.Size = new System.Drawing.Size(50, 20);
            this.rbPaidYes.TabIndex = 30;
            this.rbPaidYes.TabStop = true;
            this.rbPaidYes.Text = "Yes";
            this.rbPaidYes.UseVisualStyleBackColor = true;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Location = new System.Drawing.Point(137, 199);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(238, 22);
            this.dtpCheckIn.TabIndex = 35;
            this.dtpCheckIn.Value = new System.DateTime(2020, 12, 1, 22, 37, 39, 0);
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BloomFeildHotel.Properties.Resources.bed;
            this.pictureBox1.Location = new System.Drawing.Point(952, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 141);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Location = new System.Drawing.Point(136, 243);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(239, 22);
            this.dtpCheckOut.TabIndex = 34;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // gbDeposit
            // 
            this.gbDeposit.Controls.Add(this.rbDepositYes);
            this.gbDeposit.Controls.Add(this.rbDepositNo);
            this.gbDeposit.Controls.Add(this.label9);
            this.gbDeposit.Controls.Add(this.label10);
            this.gbDeposit.Controls.Add(this.tbDeposit);
            this.gbDeposit.Controls.Add(this.tbRoomPrice);
            this.gbDeposit.Controls.Add(this.label6);
            this.gbDeposit.Controls.Add(this.rbPaidYes);
            this.gbDeposit.Controls.Add(this.label11);
            this.gbDeposit.Controls.Add(this.rbPaidNo);
            this.gbDeposit.Location = new System.Drawing.Point(865, 25);
            this.gbDeposit.Name = "gbDeposit";
            this.gbDeposit.Size = new System.Drawing.Size(302, 240);
            this.gbDeposit.TabIndex = 32;
            this.gbDeposit.TabStop = false;
            this.gbDeposit.Text = "Payment";
            // 
            // rbDepositYes
            // 
            this.rbDepositYes.AutoSize = true;
            this.rbDepositYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepositYes.Location = new System.Drawing.Point(137, 134);
            this.rbDepositYes.Name = "rbDepositYes";
            this.rbDepositYes.Size = new System.Drawing.Size(50, 20);
            this.rbDepositYes.TabIndex = 38;
            this.rbDepositYes.TabStop = true;
            this.rbDepositYes.Text = "Yes";
            this.rbDepositYes.UseVisualStyleBackColor = true;
            this.rbDepositYes.CheckedChanged += new System.EventHandler(this.rbDepositYes_CheckedChanged);
            // 
            // rbDepositNo
            // 
            this.rbDepositNo.AutoSize = true;
            this.rbDepositNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepositNo.Location = new System.Drawing.Point(210, 134);
            this.rbDepositNo.Name = "rbDepositNo";
            this.rbDepositNo.Size = new System.Drawing.Size(44, 20);
            this.rbDepositNo.TabIndex = 39;
            this.rbDepositNo.TabStop = true;
            this.rbDepositNo.Text = "No";
            this.rbDepositNo.UseVisualStyleBackColor = true;
            this.rbDepositNo.CheckedChanged += new System.EventHandler(this.rbDepositNo_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Deposit Paid:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Deposit Amount:";
            // 
            // tbDeposit
            // 
            this.tbDeposit.Location = new System.Drawing.Point(142, 183);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.ReadOnly = true;
            this.tbDeposit.Size = new System.Drawing.Size(112, 26);
            this.tbDeposit.TabIndex = 28;
            this.tbDeposit.TextChanged += new System.EventHandler(this.tbDeposit_TextChanged);
            // 
            // numChildren
            // 
            this.numChildren.Location = new System.Drawing.Point(136, 376);
            this.numChildren.Name = "numChildren";
            this.numChildren.Size = new System.Drawing.Size(110, 26);
            this.numChildren.TabIndex = 27;
            // 
            // tbRoomPrice
            // 
            this.tbRoomPrice.Location = new System.Drawing.Point(142, 33);
            this.tbRoomPrice.Name = "tbRoomPrice";
            this.tbRoomPrice.ReadOnly = true;
            this.tbRoomPrice.Size = new System.Drawing.Size(112, 26);
            this.tbRoomPrice.TabIndex = 25;
            // 
            // tbRoomType
            // 
            this.tbRoomType.Location = new System.Drawing.Point(137, 110);
            this.tbRoomType.Name = "tbRoomType";
            this.tbRoomType.ReadOnly = true;
            this.tbRoomType.Size = new System.Drawing.Size(238, 26);
            this.tbRoomType.TabIndex = 22;
            // 
            // tbReservationID
            // 
            this.tbReservationID.Location = new System.Drawing.Point(137, 23);
            this.tbReservationID.Name = "tbReservationID";
            this.tbReservationID.ReadOnly = true;
            this.tbReservationID.Size = new System.Drawing.Size(238, 26);
            this.tbReservationID.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 376);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 16);
            this.label17.TabIndex = 15;
            this.label17.Text = "Number of Children:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 336);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Number of Adults:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // gbGuest
            // 
            this.gbGuest.Controls.Add(this.tbGuestID);
            this.gbGuest.Controls.Add(this.label20);
            this.gbGuest.Controls.Add(this.rbMarketingYes);
            this.gbGuest.Controls.Add(this.label19);
            this.gbGuest.Controls.Add(this.rbMarketingNo);
            this.gbGuest.Controls.Add(this.rtbAddress);
            this.gbGuest.Controls.Add(this.tbEmail);
            this.gbGuest.Controls.Add(this.tbPhone);
            this.gbGuest.Controls.Add(this.tbSName);
            this.gbGuest.Controls.Add(this.tbFName);
            this.gbGuest.Controls.Add(this.label18);
            this.gbGuest.Controls.Add(this.label15);
            this.gbGuest.Controls.Add(this.label14);
            this.gbGuest.Controls.Add(this.label13);
            this.gbGuest.Controls.Add(this.label12);
            this.gbGuest.Location = new System.Drawing.Point(452, 25);
            this.gbGuest.Name = "gbGuest";
            this.gbGuest.Size = new System.Drawing.Size(365, 405);
            this.gbGuest.TabIndex = 11;
            this.gbGuest.TabStop = false;
            this.gbGuest.Text = "Guest Details";
            this.gbGuest.Enter += new System.EventHandler(this.gbGuest_Enter);
            // 
            // tbGuestID
            // 
            this.tbGuestID.Location = new System.Drawing.Point(159, 22);
            this.tbGuestID.Name = "tbGuestID";
            this.tbGuestID.ReadOnly = true;
            this.tbGuestID.Size = new System.Drawing.Size(200, 26);
            this.tbGuestID.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(74, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 16);
            this.label20.TabIndex = 42;
            this.label20.Text = "Guest ID:";
            // 
            // rbMarketingYes
            // 
            this.rbMarketingYes.AutoSize = true;
            this.rbMarketingYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMarketingYes.Location = new System.Drawing.Point(194, 367);
            this.rbMarketingYes.Name = "rbMarketingYes";
            this.rbMarketingYes.Size = new System.Drawing.Size(50, 20);
            this.rbMarketingYes.TabIndex = 40;
            this.rbMarketingYes.TabStop = true;
            this.rbMarketingYes.Text = "Yes";
            this.rbMarketingYes.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 372);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 16);
            this.label19.TabIndex = 38;
            this.label19.Text = "Send Marketing Info:";
            // 
            // rbMarketingNo
            // 
            this.rbMarketingNo.AutoSize = true;
            this.rbMarketingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMarketingNo.Location = new System.Drawing.Point(250, 367);
            this.rbMarketingNo.Name = "rbMarketingNo";
            this.rbMarketingNo.Size = new System.Drawing.Size(44, 20);
            this.rbMarketingNo.TabIndex = 41;
            this.rbMarketingNo.TabStop = true;
            this.rbMarketingNo.Text = "No";
            this.rbMarketingNo.UseVisualStyleBackColor = true;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(159, 257);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(200, 94);
            this.rtbAddress.TabIndex = 37;
            this.rtbAddress.Text = "";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(159, 208);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 26);
            this.tbEmail.TabIndex = 36;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(159, 164);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(200, 26);
            this.tbPhone.TabIndex = 35;
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(159, 118);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(200, 26);
            this.tbSName.TabIndex = 34;
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(159, 73);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(200, 26);
            this.tbFName.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(74, 259);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 16);
            this.label18.TabIndex = 19;
            this.label18.Text = "Address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(91, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Phone Number:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(71, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Surname:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(60, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "First Name:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(958, 418);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(102, 33);
            this.btnCheckOut.TabIndex = 12;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // cbRoomNum
            // 
            this.cbRoomNum.FormattingEnabled = true;
            this.cbRoomNum.Location = new System.Drawing.Point(137, 65);
            this.cbRoomNum.Name = "cbRoomNum";
            this.cbRoomNum.Size = new System.Drawing.Size(238, 28);
            this.cbRoomNum.TabIndex = 39;
            this.cbRoomNum.SelectedIndexChanged += new System.EventHandler(this.cbRoomNum_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(67, 157);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 16);
            this.label21.TabIndex = 40;
            this.label21.Text = "Smoking:";
            // 
            // txtSmoking
            // 
            this.txtSmoking.Location = new System.Drawing.Point(137, 154);
            this.txtSmoking.Name = "txtSmoking";
            this.txtSmoking.ReadOnly = true;
            this.txtSmoking.Size = new System.Drawing.Size(238, 26);
            this.txtSmoking.TabIndex = 41;
            // 
            // formManageReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1265, 619);
            this.Controls.Add(this.gbReservation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formManageReservation";
            this.Text = "Manage Reservation";
            this.Load += new System.EventHandler(this.formManageReservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbReservation.ResumeLayout(false);
            this.gbReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbDeposit.ResumeLayout(false);
            this.gbDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).EndInit();
            this.gbGuest.ResumeLayout(false);
            this.gbGuest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbReservation;
        private System.Windows.Forms.GroupBox gbGuest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRoomType;
        private System.Windows.Forms.TextBox tbReservationID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbDeposit;
        private System.Windows.Forms.RadioButton rbPaidNo;
        private System.Windows.Forms.RadioButton rbPaidYes;
        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.NumericUpDown numChildren;
        private System.Windows.Forms.TextBox tbRoomPrice;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.NumericUpDown numAdults;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbDepositYes;
        private System.Windows.Forms.RadioButton rbDepositNo;
        private System.Windows.Forms.RadioButton rbMarketingYes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton rbMarketingNo;
        private System.Windows.Forms.TextBox tbGuestID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox numNights;
        private System.Windows.Forms.TextBox txtSmoking;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbRoomNum;
    }
}