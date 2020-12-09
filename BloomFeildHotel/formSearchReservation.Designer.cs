namespace BloomFeildHotel
{
    partial class formSearchReservation
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
            this.lbISearch = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.GuestList = new System.Windows.Forms.ListBox();
            this.EnterSearch = new System.Windows.Forms.Label();
            this.ReservationInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.lbISearch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 102);
            this.panel1.TabIndex = 22;
            // 
            // lbISearch
            // 
            this.lbISearch.AutoSize = true;
            this.lbISearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbISearch.ForeColor = System.Drawing.Color.White;
            this.lbISearch.Location = new System.Drawing.Point(26, 20);
            this.lbISearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbISearch.Name = "lbISearch";
            this.lbISearch.Size = new System.Drawing.Size(584, 61);
            this.lbISearch.TabIndex = 1;
            this.lbISearch.Text = "Search For Reservation";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(130, 231);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(440, 28);
            this.textBoxSurname.TabIndex = 27;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(130, 174);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(440, 28);
            this.textBoxFirstName.TabIndex = 26;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(21, 178);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 22);
            this.lblFirstName.TabIndex = 24;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(21, 231);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(82, 22);
            this.lblSurname.TabIndex = 25;
            this.lblSurname.Text = "Surname";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(130, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 83);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(420, 337);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 83);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GuestList
            // 
            this.GuestList.FormattingEnabled = true;
            this.GuestList.ItemHeight = 20;
            this.GuestList.Location = new System.Drawing.Point(602, 174);
            this.GuestList.Name = "GuestList";
            this.GuestList.Size = new System.Drawing.Size(511, 244);
            this.GuestList.TabIndex = 30;
            // 
            // EnterSearch
            // 
            this.EnterSearch.AutoSize = true;
            this.EnterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EnterSearch.Location = new System.Drawing.Point(21, 126);
            this.EnterSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnterSearch.Name = "EnterSearch";
            this.EnterSearch.Size = new System.Drawing.Size(218, 22);
            this.EnterSearch.TabIndex = 31;
            this.EnterSearch.Text = "Please Enter Guest Name";
            // 
            // ReservationInfo
            // 
            this.ReservationInfo.AutoSize = true;
            this.ReservationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ReservationInfo.Location = new System.Drawing.Point(784, 126);
            this.ReservationInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReservationInfo.Name = "ReservationInfo";
            this.ReservationInfo.Size = new System.Drawing.Size(140, 22);
            this.ReservationInfo.TabIndex = 32;
            this.ReservationInfo.Text = "Reservation Info";
            // 
            // formSearchReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1131, 479);
            this.Controls.Add(this.ReservationInfo);
            this.Controls.Add(this.EnterSearch);
            this.Controls.Add(this.GuestList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formSearchReservation";
            this.Text = "formSearchReservation";
            this.Load += new System.EventHandler(this.formSearchReservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbISearch;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox GuestList;
        private System.Windows.Forms.Label EnterSearch;
        private System.Windows.Forms.Label ReservationInfo;
    }
}