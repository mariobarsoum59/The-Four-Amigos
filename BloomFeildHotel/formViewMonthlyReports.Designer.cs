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
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbReports = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbOrders = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbExpenses = new System.Windows.Forms.TextBox();
            this.tbRestaurantIncome = new System.Windows.Forms.TextBox();
            this.tbNumSales = new System.Windows.Forms.TextBox();
            this.tbReservationIncome = new System.Windows.Forms.TextBox();
            this.tbNumReservations = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbReportID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 111);
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
            this.groupBox1.Controls.Add(this.btnViewAll);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lbReports);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(753, 433);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Monthly Report";
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnViewAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(276, 35);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(85, 34);
            this.btnViewAll.TabIndex = 11;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 22);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbReports
            // 
            this.lbReports.FormattingEnabled = true;
            this.lbReports.ItemHeight = 16;
            this.lbReports.Location = new System.Drawing.Point(15, 83);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(323, 340);
            this.lbReports.TabIndex = 26;
            this.lbReports.SelectedIndexChanged += new System.EventHandler(this.lbReports_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbOrders);
            this.groupBox2.Controls.Add(this.label9);
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
            this.groupBox2.Location = new System.Drawing.Point(379, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 384);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monthly Report Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbOrders
            // 
            this.tbOrders.Location = new System.Drawing.Point(189, 301);
            this.tbOrders.Name = "tbOrders";
            this.tbOrders.ReadOnly = true;
            this.tbOrders.Size = new System.Drawing.Size(164, 22);
            this.tbOrders.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Stock Orders:";
            // 
            // tbExpenses
            // 
            this.tbExpenses.Location = new System.Drawing.Point(189, 342);
            this.tbExpenses.Name = "tbExpenses";
            this.tbExpenses.ReadOnly = true;
            this.tbExpenses.Size = new System.Drawing.Size(164, 22);
            this.tbExpenses.TabIndex = 13;
            // 
            // tbRestaurantIncome
            // 
            this.tbRestaurantIncome.Location = new System.Drawing.Point(189, 257);
            this.tbRestaurantIncome.Name = "tbRestaurantIncome";
            this.tbRestaurantIncome.ReadOnly = true;
            this.tbRestaurantIncome.Size = new System.Drawing.Size(164, 22);
            this.tbRestaurantIncome.TabIndex = 12;
            // 
            // tbNumSales
            // 
            this.tbNumSales.Location = new System.Drawing.Point(189, 202);
            this.tbNumSales.Name = "tbNumSales";
            this.tbNumSales.ReadOnly = true;
            this.tbNumSales.Size = new System.Drawing.Size(164, 22);
            this.tbNumSales.TabIndex = 11;
            // 
            // tbReservationIncome
            // 
            this.tbReservationIncome.Location = new System.Drawing.Point(189, 165);
            this.tbReservationIncome.Name = "tbReservationIncome";
            this.tbReservationIncome.ReadOnly = true;
            this.tbReservationIncome.Size = new System.Drawing.Size(164, 22);
            this.tbReservationIncome.TabIndex = 10;
            // 
            // tbNumReservations
            // 
            this.tbNumReservations.Location = new System.Drawing.Point(189, 120);
            this.tbNumReservations.Name = "tbNumReservations";
            this.tbNumReservations.ReadOnly = true;
            this.tbNumReservations.Size = new System.Drawing.Size(164, 22);
            this.tbNumReservations.TabIndex = 9;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(189, 77);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(164, 22);
            this.tbDate.TabIndex = 8;
            // 
            // tbReportID
            // 
            this.tbReportID.Location = new System.Drawing.Point(189, 28);
            this.tbReportID.Name = "tbReportID";
            this.tbReportID.ReadOnly = true;
            this.tbReportID.Size = new System.Drawing.Size(164, 22);
            this.tbReportID.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Stock Expenses:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bar/Restaurant Income:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of Reservations:";
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
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 563);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 41);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // formViewMonthlyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(787, 619);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formViewMonthlyReports";
            this.Text = "formViewMonthlyReports";
            this.Load += new System.EventHandler(this.formViewMonthlyReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbExpenses;
        private System.Windows.Forms.TextBox tbRestaurantIncome;
        private System.Windows.Forms.TextBox tbNumSales;
        private System.Windows.Forms.TextBox tbReservationIncome;
        private System.Windows.Forms.TextBox tbNumReservations;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbReportID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbReports;
        private System.Windows.Forms.TextBox tbOrders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnViewAll;
    }
}