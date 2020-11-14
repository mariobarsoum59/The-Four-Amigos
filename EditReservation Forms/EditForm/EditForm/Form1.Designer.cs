namespace EditForm
{
    partial class EditPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkIn = new System.Windows.Forms.Label();
            this.checkOut = new System.Windows.Forms.Label();
            this.roomType = new System.Windows.Forms.Label();
            this.singNonSmoke = new System.Windows.Forms.RadioButton();
            this.dblSmoke = new System.Windows.Forms.RadioButton();
            this.sglSmoke = new System.Windows.Forms.RadioButton();
            this.twnNonSmoke = new System.Windows.Forms.RadioButton();
            this.dblNonSmoke = new System.Windows.Forms.RadioButton();
            this.twnSmoke = new System.Windows.Forms.RadioButton();
            this.nmbrNights = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guestDetails = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstLBL = new System.Windows.Forms.Label();
            this.AddressLBL = new System.Windows.Forms.Label();
            this.phoneLBL = new System.Windows.Forms.Label();
            this.lastnameLBL = new System.Windows.Forms.Label();
            this.numGuests = new System.Windows.Forms.TextBox();
            this.numGuestLBL = new System.Windows.Forms.Label();
            this.depositLBL = new System.Windows.Forms.Label();
            this.depYES = new System.Windows.Forms.RadioButton();
            this.depNO = new System.Windows.Forms.RadioButton();
            this.marketingLBL = new System.Windows.Forms.Label();
            this.marketNO = new System.Windows.Forms.RadioButton();
            this.marketYES = new System.Windows.Forms.RadioButton();
            this.email = new System.Windows.Forms.TextBox();
            this.emailLBL = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Reservation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 73);
            this.panel1.TabIndex = 2;
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Location = new System.Drawing.Point(238, 176);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(318, 26);
            this.dtCheckIn.TabIndex = 3;
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Location = new System.Drawing.Point(238, 217);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(318, 26);
            this.dtCheckOut.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // checkIn
            // 
            this.checkIn.AutoSize = true;
            this.checkIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn.Location = new System.Drawing.Point(94, 176);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(123, 22);
            this.checkIn.TabIndex = 6;
            this.checkIn.Text = "Check In Date";
            // 
            // checkOut
            // 
            this.checkOut.AutoSize = true;
            this.checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut.Location = new System.Drawing.Point(94, 221);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(138, 22);
            this.checkOut.TabIndex = 7;
            this.checkOut.Text = "Check Out Date";
            // 
            // roomType
            // 
            this.roomType.AutoSize = true;
            this.roomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType.Location = new System.Drawing.Point(94, 296);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(103, 22);
            this.roomType.TabIndex = 8;
            this.roomType.Text = "Room Type";
            // 
            // singNonSmoke
            // 
            this.singNonSmoke.AutoSize = true;
            this.singNonSmoke.Location = new System.Drawing.Point(106, 342);
            this.singNonSmoke.Name = "singNonSmoke";
            this.singNonSmoke.Size = new System.Drawing.Size(178, 24);
            this.singNonSmoke.TabIndex = 9;
            this.singNonSmoke.TabStop = true;
            this.singNonSmoke.Text = "Single Non-Smoking";
            this.singNonSmoke.UseVisualStyleBackColor = true;
            // 
            // dblSmoke
            // 
            this.dblSmoke.AutoSize = true;
            this.dblSmoke.Location = new System.Drawing.Point(300, 384);
            this.dblSmoke.Name = "dblSmoke";
            this.dblSmoke.Size = new System.Drawing.Size(151, 24);
            this.dblSmoke.TabIndex = 10;
            this.dblSmoke.TabStop = true;
            this.dblSmoke.Text = "Double Smoking";
            this.dblSmoke.UseVisualStyleBackColor = true;
            // 
            // sglSmoke
            // 
            this.sglSmoke.AutoSize = true;
            this.sglSmoke.Location = new System.Drawing.Point(300, 342);
            this.sglSmoke.Name = "sglSmoke";
            this.sglSmoke.Size = new System.Drawing.Size(144, 24);
            this.sglSmoke.TabIndex = 11;
            this.sglSmoke.TabStop = true;
            this.sglSmoke.Text = "Single Smoking";
            this.sglSmoke.UseVisualStyleBackColor = true;
            // 
            // twnNonSmoke
            // 
            this.twnNonSmoke.AutoSize = true;
            this.twnNonSmoke.Location = new System.Drawing.Point(106, 424);
            this.twnNonSmoke.Name = "twnNonSmoke";
            this.twnNonSmoke.Size = new System.Drawing.Size(166, 24);
            this.twnNonSmoke.TabIndex = 12;
            this.twnNonSmoke.TabStop = true;
            this.twnNonSmoke.Text = "Twin Non-Smoking";
            this.twnNonSmoke.UseVisualStyleBackColor = true;
            // 
            // dblNonSmoke
            // 
            this.dblNonSmoke.AutoSize = true;
            this.dblNonSmoke.Location = new System.Drawing.Point(106, 384);
            this.dblNonSmoke.Name = "dblNonSmoke";
            this.dblNonSmoke.Size = new System.Drawing.Size(185, 24);
            this.dblNonSmoke.TabIndex = 13;
            this.dblNonSmoke.TabStop = true;
            this.dblNonSmoke.Text = "Double Non-Smoking";
            this.dblNonSmoke.UseVisualStyleBackColor = true;
            // 
            // twnSmoke
            // 
            this.twnSmoke.AutoSize = true;
            this.twnSmoke.Location = new System.Drawing.Point(300, 424);
            this.twnSmoke.Name = "twnSmoke";
            this.twnSmoke.Size = new System.Drawing.Size(132, 24);
            this.twnSmoke.TabIndex = 14;
            this.twnSmoke.TabStop = true;
            this.twnSmoke.Text = "Twin Smoking";
            this.twnSmoke.UseVisualStyleBackColor = true;
            // 
            // nmbrNights
            // 
            this.nmbrNights.Location = new System.Drawing.Point(255, 490);
            this.nmbrNights.Name = "nmbrNights";
            this.nmbrNights.Size = new System.Drawing.Size(76, 26);
            this.nmbrNights.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Number of Nights";
            // 
            // guestDetails
            // 
            this.guestDetails.AutoSize = true;
            this.guestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestDetails.Location = new System.Drawing.Point(641, 121);
            this.guestDetails.Name = "guestDetails";
            this.guestDetails.Size = new System.Drawing.Size(118, 22);
            this.guestDetails.TabIndex = 17;
            this.guestDetails.Text = "Guest Details";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(757, 166);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(278, 26);
            this.firstName.TabIndex = 18;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(757, 286);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(278, 26);
            this.address.TabIndex = 19;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(757, 243);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(278, 26);
            this.phone.TabIndex = 20;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(757, 204);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(278, 26);
            this.lastName.TabIndex = 21;
            // 
            // firstLBL
            // 
            this.firstLBL.AutoSize = true;
            this.firstLBL.Location = new System.Drawing.Point(659, 166);
            this.firstLBL.Name = "firstLBL";
            this.firstLBL.Size = new System.Drawing.Size(86, 20);
            this.firstLBL.TabIndex = 22;
            this.firstLBL.Text = "First Name";
            // 
            // AddressLBL
            // 
            this.AddressLBL.AutoSize = true;
            this.AddressLBL.Location = new System.Drawing.Point(657, 286);
            this.AddressLBL.Name = "AddressLBL";
            this.AddressLBL.Size = new System.Drawing.Size(68, 20);
            this.AddressLBL.TabIndex = 23;
            this.AddressLBL.Text = "Address";
            // 
            // phoneLBL
            // 
            this.phoneLBL.AutoSize = true;
            this.phoneLBL.Location = new System.Drawing.Point(657, 246);
            this.phoneLBL.Name = "phoneLBL";
            this.phoneLBL.Size = new System.Drawing.Size(55, 20);
            this.phoneLBL.TabIndex = 24;
            this.phoneLBL.Text = "Phone";
            // 
            // lastnameLBL
            // 
            this.lastnameLBL.AutoSize = true;
            this.lastnameLBL.Location = new System.Drawing.Point(657, 207);
            this.lastnameLBL.Name = "lastnameLBL";
            this.lastnameLBL.Size = new System.Drawing.Size(74, 20);
            this.lastnameLBL.TabIndex = 25;
            this.lastnameLBL.Text = "Surname";
            // 
            // numGuests
            // 
            this.numGuests.Location = new System.Drawing.Point(805, 374);
            this.numGuests.Name = "numGuests";
            this.numGuests.Size = new System.Drawing.Size(76, 26);
            this.numGuests.TabIndex = 26;
            // 
            // numGuestLBL
            // 
            this.numGuestLBL.AutoSize = true;
            this.numGuestLBL.Location = new System.Drawing.Point(657, 374);
            this.numGuestLBL.Name = "numGuestLBL";
            this.numGuestLBL.Size = new System.Drawing.Size(142, 20);
            this.numGuestLBL.TabIndex = 27;
            this.numGuestLBL.Text = "Number Of Guests";
            // 
            // depositLBL
            // 
            this.depositLBL.AutoSize = true;
            this.depositLBL.Location = new System.Drawing.Point(657, 424);
            this.depositLBL.Name = "depositLBL";
            this.depositLBL.Size = new System.Drawing.Size(99, 20);
            this.depositLBL.TabIndex = 28;
            this.depositLBL.Text = "Deposit Paid";
            // 
            // depYES
            // 
            this.depYES.AutoSize = true;
            this.depYES.Location = new System.Drawing.Point(875, 416);
            this.depYES.Name = "depYES";
            this.depYES.Size = new System.Drawing.Size(62, 24);
            this.depYES.TabIndex = 29;
            this.depYES.TabStop = true;
            this.depYES.Text = "Yes";
            this.depYES.UseVisualStyleBackColor = true;
            // 
            // depNO
            // 
            this.depNO.AutoSize = true;
            this.depNO.Location = new System.Drawing.Point(953, 416);
            this.depNO.Name = "depNO";
            this.depNO.Size = new System.Drawing.Size(54, 24);
            this.depNO.TabIndex = 30;
            this.depNO.TabStop = true;
            this.depNO.Text = "No";
            this.depNO.UseVisualStyleBackColor = true;
            // 
            // marketingLBL
            // 
            this.marketingLBL.AutoSize = true;
            this.marketingLBL.Location = new System.Drawing.Point(653, 457);
            this.marketingLBL.Name = "marketingLBL";
            this.marketingLBL.Size = new System.Drawing.Size(206, 20);
            this.marketingLBL.TabIndex = 31;
            this.marketingLBL.Text = "Send Marketing Information";
            // 
            // marketNO
            // 
            this.marketNO.AutoSize = true;
            this.marketNO.Location = new System.Drawing.Point(953, 453);
            this.marketNO.Name = "marketNO";
            this.marketNO.Size = new System.Drawing.Size(54, 24);
            this.marketNO.TabIndex = 32;
            this.marketNO.TabStop = true;
            this.marketNO.Text = "No";
            this.marketNO.UseVisualStyleBackColor = true;
            // 
            // marketYES
            // 
            this.marketYES.AutoSize = true;
            this.marketYES.Location = new System.Drawing.Point(875, 453);
            this.marketYES.Name = "marketYES";
            this.marketYES.Size = new System.Drawing.Size(62, 24);
            this.marketYES.TabIndex = 33;
            this.marketYES.TabStop = true;
            this.marketYES.Text = "Yes";
            this.marketYES.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(757, 328);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(278, 26);
            this.email.TabIndex = 34;
            // 
            // emailLBL
            // 
            this.emailLBL.AutoSize = true;
            this.emailLBL.Location = new System.Drawing.Point(659, 334);
            this.emailLBL.Name = "emailLBL";
            this.emailLBL.Size = new System.Drawing.Size(53, 20);
            this.emailLBL.TabIndex = 35;
            this.emailLBL.Text = "E-Mail";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(657, 526);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(181, 50);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update Reservation";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(888, 526);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(181, 50);
            this.btnReturn.TabIndex = 37;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // EditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1180, 611);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.emailLBL);
            this.Controls.Add(this.email);
            this.Controls.Add(this.marketYES);
            this.Controls.Add(this.marketNO);
            this.Controls.Add(this.marketingLBL);
            this.Controls.Add(this.depNO);
            this.Controls.Add(this.depYES);
            this.Controls.Add(this.depositLBL);
            this.Controls.Add(this.numGuestLBL);
            this.Controls.Add(this.numGuests);
            this.Controls.Add(this.lastnameLBL);
            this.Controls.Add(this.phoneLBL);
            this.Controls.Add(this.AddressLBL);
            this.Controls.Add(this.firstLBL);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.address);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.guestDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmbrNights);
            this.Controls.Add(this.twnSmoke);
            this.Controls.Add(this.dblNonSmoke);
            this.Controls.Add(this.twnNonSmoke);
            this.Controls.Add(this.sglSmoke);
            this.Controls.Add(this.dblSmoke);
            this.Controls.Add(this.singNonSmoke);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.panel1);
            this.Name = "EditPage";
            this.Text = "Edit Reservation Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label checkIn;
        private System.Windows.Forms.Label checkOut;
        private System.Windows.Forms.Label roomType;
        private System.Windows.Forms.RadioButton singNonSmoke;
        private System.Windows.Forms.RadioButton dblSmoke;
        private System.Windows.Forms.RadioButton sglSmoke;
        private System.Windows.Forms.RadioButton twnNonSmoke;
        private System.Windows.Forms.RadioButton dblNonSmoke;
        private System.Windows.Forms.RadioButton twnSmoke;
        private System.Windows.Forms.TextBox nmbrNights;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label guestDetails;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label firstLBL;
        private System.Windows.Forms.Label AddressLBL;
        private System.Windows.Forms.Label phoneLBL;
        private System.Windows.Forms.Label lastnameLBL;
        private System.Windows.Forms.TextBox numGuests;
        private System.Windows.Forms.Label numGuestLBL;
        private System.Windows.Forms.Label depositLBL;
        private System.Windows.Forms.RadioButton depYES;
        private System.Windows.Forms.RadioButton depNO;
        private System.Windows.Forms.Label marketingLBL;
        private System.Windows.Forms.RadioButton marketNO;
        private System.Windows.Forms.RadioButton marketYES;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label emailLBL;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReturn;
    }
}

