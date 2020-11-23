namespace BloomFeildHotel
{
    partial class formViewMonthlyReports
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbReportID = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbNumReservations = new System.Windows.Forms.TextBox();
            this.tbReservationIncome = new System.Windows.Forms.TextBox();
            this.tbNumSales = new System.Windows.Forms.TextBox();
            this.tbRestaurantIncome = new System.Windows.Forms.TextBox();
            this.tbExpenses = new System.Windows.Forms.TextBox();
            this.rbJan = new System.Windows.Forms.RadioButton();
            this.rbFeb = new System.Windows.Forms.RadioButton();
            this.rbMar = new System.Windows.Forms.RadioButton();
            this.rbApr = new System.Windows.Forms.RadioButton();
            this.rbMay = new System.Windows.Forms.RadioButton();
            this.rbJun = new System.Windows.Forms.RadioButton();
            this.rbJul = new System.Windows.Forms.RadioButton();
            this.rbAug = new System.Windows.Forms.RadioButton();
            this.rbSep = new System.Windows.Forms.RadioButton();
            this.rbOct = new System.Windows.Forms.RadioButton();
            this.rbNov = new System.Windows.Forms.RadioButton();
            this.rbDec = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 111);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Monthly Reports";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDec);
            this.groupBox1.Controls.Add(this.rbNov);
            this.groupBox1.Controls.Add(this.rbOct);
            this.groupBox1.Controls.Add(this.rbSep);
            this.groupBox1.Controls.Add(this.rbAug);
            this.groupBox1.Controls.Add(this.rbJul);
            this.groupBox1.Controls.Add(this.rbJun);
            this.groupBox1.Controls.Add(this.rbMay);
            this.groupBox1.Controls.Add(this.rbApr);
            this.groupBox1.Controls.Add(this.rbMar);
            this.groupBox1.Controls.Add(this.rbFeb);
            this.groupBox1.Controls.Add(this.rbJan);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbCategories);
            this.groupBox1.Location = new System.Drawing.Point(16, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(552, 408);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Monthly Report";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Items.AddRange(new object[] {
            "Meat",
            "Poultry",
            "Fish",
            "Dairy",
            "Fruits",
            "Vegetables",
            "Dry Grocery",
            "Miscellaneous"});
            this.cbCategories.Location = new System.Drawing.Point(15, 39);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(160, 24);
            this.cbCategories.TabIndex = 8;
            this.cbCategories.Text = "Please Select a Year";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbExpenses);
            this.groupBox2.Controls.Add(this.tbRestaurantIncome);
            this.groupBox2.Controls.Add(this.tbNumSales);
            this.groupBox2.Controls.Add(this.tbReservationIncome);
            this.groupBox2.Controls.Add(this.tbNumReservations);
            this.groupBox2.Controls.Add(this.tbDate);
            this.groupBox2.Controls.Add(this.tbReportID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(182, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 346);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monthly Report Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Report ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date of Report:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of Reservations:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Reservation Income:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bar/Restaurant Income:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bar/Restaurant Sales:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Stock Expenses:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(16, 538);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 41);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // tbReportID
            // 
            this.tbReportID.Location = new System.Drawing.Point(189, 28);
            this.tbReportID.Name = "tbReportID";
            this.tbReportID.ReadOnly = true;
            this.tbReportID.Size = new System.Drawing.Size(112, 22);
            this.tbReportID.TabIndex = 7;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(189, 77);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(112, 22);
            this.tbDate.TabIndex = 8;
            // 
            // tbNumReservations
            // 
            this.tbNumReservations.Location = new System.Drawing.Point(189, 120);
            this.tbNumReservations.Name = "tbNumReservations";
            this.tbNumReservations.ReadOnly = true;
            this.tbNumReservations.Size = new System.Drawing.Size(112, 22);
            this.tbNumReservations.TabIndex = 9;
            // 
            // tbReservationIncome
            // 
            this.tbReservationIncome.Location = new System.Drawing.Point(189, 165);
            this.tbReservationIncome.Name = "tbReservationIncome";
            this.tbReservationIncome.ReadOnly = true;
            this.tbReservationIncome.Size = new System.Drawing.Size(112, 22);
            this.tbReservationIncome.TabIndex = 10;
            // 
            // tbNumSales
            // 
            this.tbNumSales.Location = new System.Drawing.Point(189, 208);
            this.tbNumSales.Name = "tbNumSales";
            this.tbNumSales.ReadOnly = true;
            this.tbNumSales.Size = new System.Drawing.Size(112, 22);
            this.tbNumSales.TabIndex = 11;
            // 
            // tbRestaurantIncome
            // 
            this.tbRestaurantIncome.Location = new System.Drawing.Point(189, 257);
            this.tbRestaurantIncome.Name = "tbRestaurantIncome";
            this.tbRestaurantIncome.ReadOnly = true;
            this.tbRestaurantIncome.Size = new System.Drawing.Size(112, 22);
            this.tbRestaurantIncome.TabIndex = 12;
            // 
            // tbExpenses
            // 
            this.tbExpenses.Location = new System.Drawing.Point(189, 301);
            this.tbExpenses.Name = "tbExpenses";
            this.tbExpenses.ReadOnly = true;
            this.tbExpenses.Size = new System.Drawing.Size(112, 22);
            this.tbExpenses.TabIndex = 13;
            // 
            // rbJan
            // 
            this.rbJan.AutoSize = true;
            this.rbJan.Location = new System.Drawing.Point(22, 70);
            this.rbJan.Name = "rbJan";
            this.rbJan.Size = new System.Drawing.Size(74, 20);
            this.rbJan.TabIndex = 14;
            this.rbJan.TabStop = true;
            this.rbJan.Text = "January";
            this.rbJan.UseVisualStyleBackColor = true;
            // 
            // rbFeb
            // 
            this.rbFeb.AutoSize = true;
            this.rbFeb.Location = new System.Drawing.Point(21, 96);
            this.rbFeb.Name = "rbFeb";
            this.rbFeb.Size = new System.Drawing.Size(80, 20);
            this.rbFeb.TabIndex = 15;
            this.rbFeb.TabStop = true;
            this.rbFeb.Text = "February";
            this.rbFeb.UseVisualStyleBackColor = true;
            // 
            // rbMar
            // 
            this.rbMar.AutoSize = true;
            this.rbMar.Location = new System.Drawing.Point(21, 122);
            this.rbMar.Name = "rbMar";
            this.rbMar.Size = new System.Drawing.Size(63, 20);
            this.rbMar.TabIndex = 16;
            this.rbMar.TabStop = true;
            this.rbMar.Text = "March";
            this.rbMar.UseVisualStyleBackColor = true;
            // 
            // rbApr
            // 
            this.rbApr.AutoSize = true;
            this.rbApr.Location = new System.Drawing.Point(22, 148);
            this.rbApr.Name = "rbApr";
            this.rbApr.Size = new System.Drawing.Size(53, 20);
            this.rbApr.TabIndex = 17;
            this.rbApr.TabStop = true;
            this.rbApr.Text = "April";
            this.rbApr.UseVisualStyleBackColor = true;
            // 
            // rbMay
            // 
            this.rbMay.AutoSize = true;
            this.rbMay.Location = new System.Drawing.Point(22, 174);
            this.rbMay.Name = "rbMay";
            this.rbMay.Size = new System.Drawing.Size(52, 20);
            this.rbMay.TabIndex = 18;
            this.rbMay.TabStop = true;
            this.rbMay.Text = "May";
            this.rbMay.UseVisualStyleBackColor = true;
            // 
            // rbJun
            // 
            this.rbJun.AutoSize = true;
            this.rbJun.Location = new System.Drawing.Point(22, 200);
            this.rbJun.Name = "rbJun";
            this.rbJun.Size = new System.Drawing.Size(55, 20);
            this.rbJun.TabIndex = 19;
            this.rbJun.TabStop = true;
            this.rbJun.Text = "June";
            this.rbJun.UseVisualStyleBackColor = true;
            // 
            // rbJul
            // 
            this.rbJul.AutoSize = true;
            this.rbJul.Location = new System.Drawing.Point(22, 224);
            this.rbJul.Name = "rbJul";
            this.rbJul.Size = new System.Drawing.Size(50, 20);
            this.rbJul.TabIndex = 20;
            this.rbJul.TabStop = true;
            this.rbJul.Text = "July";
            this.rbJul.UseVisualStyleBackColor = true;
            // 
            // rbAug
            // 
            this.rbAug.AutoSize = true;
            this.rbAug.Location = new System.Drawing.Point(22, 247);
            this.rbAug.Name = "rbAug";
            this.rbAug.Size = new System.Drawing.Size(67, 20);
            this.rbAug.TabIndex = 21;
            this.rbAug.TabStop = true;
            this.rbAug.Text = "August";
            this.rbAug.UseVisualStyleBackColor = true;
            // 
            // rbSep
            // 
            this.rbSep.AutoSize = true;
            this.rbSep.Location = new System.Drawing.Point(21, 273);
            this.rbSep.Name = "rbSep";
            this.rbSep.Size = new System.Drawing.Size(93, 20);
            this.rbSep.TabIndex = 22;
            this.rbSep.TabStop = true;
            this.rbSep.Text = "September";
            this.rbSep.UseVisualStyleBackColor = true;
            this.rbSep.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // rbOct
            // 
            this.rbOct.AutoSize = true;
            this.rbOct.Location = new System.Drawing.Point(21, 302);
            this.rbOct.Name = "rbOct";
            this.rbOct.Size = new System.Drawing.Size(74, 20);
            this.rbOct.TabIndex = 23;
            this.rbOct.TabStop = true;
            this.rbOct.Text = "October";
            this.rbOct.UseVisualStyleBackColor = true;
            // 
            // rbNov
            // 
            this.rbNov.AutoSize = true;
            this.rbNov.Location = new System.Drawing.Point(21, 328);
            this.rbNov.Name = "rbNov";
            this.rbNov.Size = new System.Drawing.Size(90, 20);
            this.rbNov.TabIndex = 24;
            this.rbNov.TabStop = true;
            this.rbNov.Text = "November";
            this.rbNov.UseVisualStyleBackColor = true;
            // 
            // rbDec
            // 
            this.rbDec.AutoSize = true;
            this.rbDec.Location = new System.Drawing.Point(21, 354);
            this.rbDec.Name = "rbDec";
            this.rbDec.Size = new System.Drawing.Size(90, 20);
            this.rbDec.TabIndex = 25;
            this.rbDec.TabStop = true;
            this.rbDec.Text = "December";
            this.rbDec.UseVisualStyleBackColor = true;
            // 
            // formViewMonthlyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(582, 591);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formViewMonthlyReports";
            this.Text = "formViewMonthlyReports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbDec;
        private System.Windows.Forms.RadioButton rbNov;
        private System.Windows.Forms.RadioButton rbOct;
        private System.Windows.Forms.RadioButton rbSep;
        private System.Windows.Forms.RadioButton rbAug;
        private System.Windows.Forms.RadioButton rbJul;
        private System.Windows.Forms.RadioButton rbJun;
        private System.Windows.Forms.RadioButton rbMay;
        private System.Windows.Forms.RadioButton rbApr;
        private System.Windows.Forms.RadioButton rbMar;
        private System.Windows.Forms.RadioButton rbFeb;
        private System.Windows.Forms.RadioButton rbJan;
        private System.Windows.Forms.TextBox tbExpenses;
        private System.Windows.Forms.TextBox tbRestaurantIncome;
        private System.Windows.Forms.TextBox tbNumSales;
        private System.Windows.Forms.TextBox tbReservationIncome;
        private System.Windows.Forms.TextBox tbNumReservations;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbReportID;
        private System.Windows.Forms.Button btnBack;
    }
}