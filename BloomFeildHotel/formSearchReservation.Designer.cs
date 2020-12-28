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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbISearch = new System.Windows.Forms.Label();
            this.btnGoResID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payedDepositDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.payedInFullDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.guestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloomFeildHotelDataSetRes = new BloomFeildHotel.BloomFeildHotelDataSetRes();
            this.bloomFeildHotelDataSetReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationsTableAdapter = new BloomFeildHotel.BloomFeildHotelDataSetResTableAdapters.reservationsTableAdapter();
            this.btnMangeRes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloomFeildHotelDataSetRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloomFeildHotelDataSetReservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbISearch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1895, 114);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(4, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1132, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Note: When Choosing a Reservation Click On the Very First Column For the Desired " +
    "Reservation";
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
            // btnGoResID
            // 
            this.btnGoResID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnGoResID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoResID.ForeColor = System.Drawing.Color.White;
            this.btnGoResID.Location = new System.Drawing.Point(548, 132);
            this.btnGoResID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoResID.Name = "btnGoResID";
            this.btnGoResID.Size = new System.Drawing.Size(90, 60);
            this.btnGoResID.TabIndex = 28;
            this.btnGoResID.Text = "Go";
            this.btnGoResID.UseVisualStyleBackColor = false;
            this.btnGoResID.Click += new System.EventHandler(this.btnGoResID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Reservation ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(197, 145);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 35);
            this.textBox1.TabIndex = 24;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(1278, 805);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(586, 135);
            this.btnExit.TabIndex = 52;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(647, 805);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(582, 135);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 33;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn,
            this.checkInDateDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn,
            this.adultsDataGridViewTextBoxColumn,
            this.childrenDataGridViewTextBoxColumn,
            this.reservationPriceDataGridViewTextBoxColumn,
            this.payedDepositDataGridViewCheckBoxColumn,
            this.payedInFullDataGridViewCheckBoxColumn,
            this.guestIDDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.checkInDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.reservationsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(24, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1840, 595);
            this.dataGridView1.TabIndex = 53;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            this.checkInDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkInDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            this.checkOutDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkOutDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // adultsDataGridViewTextBoxColumn
            // 
            this.adultsDataGridViewTextBoxColumn.DataPropertyName = "Adults";
            this.adultsDataGridViewTextBoxColumn.HeaderText = "Adults";
            this.adultsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adultsDataGridViewTextBoxColumn.Name = "adultsDataGridViewTextBoxColumn";
            this.adultsDataGridViewTextBoxColumn.ReadOnly = true;
            this.adultsDataGridViewTextBoxColumn.Width = 120;
            // 
            // childrenDataGridViewTextBoxColumn
            // 
            this.childrenDataGridViewTextBoxColumn.DataPropertyName = "Children";
            this.childrenDataGridViewTextBoxColumn.HeaderText = "Children";
            this.childrenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.childrenDataGridViewTextBoxColumn.Name = "childrenDataGridViewTextBoxColumn";
            this.childrenDataGridViewTextBoxColumn.ReadOnly = true;
            this.childrenDataGridViewTextBoxColumn.Width = 120;
            // 
            // reservationPriceDataGridViewTextBoxColumn
            // 
            this.reservationPriceDataGridViewTextBoxColumn.DataPropertyName = "ReservationPrice";
            this.reservationPriceDataGridViewTextBoxColumn.HeaderText = "ReservationPrice";
            this.reservationPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reservationPriceDataGridViewTextBoxColumn.Name = "reservationPriceDataGridViewTextBoxColumn";
            this.reservationPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationPriceDataGridViewTextBoxColumn.Width = 120;
            // 
            // payedDepositDataGridViewCheckBoxColumn
            // 
            this.payedDepositDataGridViewCheckBoxColumn.DataPropertyName = "PayedDeposit";
            this.payedDepositDataGridViewCheckBoxColumn.HeaderText = "PayedDeposit";
            this.payedDepositDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.payedDepositDataGridViewCheckBoxColumn.Name = "payedDepositDataGridViewCheckBoxColumn";
            this.payedDepositDataGridViewCheckBoxColumn.ReadOnly = true;
            this.payedDepositDataGridViewCheckBoxColumn.Width = 120;
            // 
            // payedInFullDataGridViewCheckBoxColumn
            // 
            this.payedInFullDataGridViewCheckBoxColumn.DataPropertyName = "PayedInFull";
            this.payedInFullDataGridViewCheckBoxColumn.HeaderText = "PayedInFull";
            this.payedInFullDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.payedInFullDataGridViewCheckBoxColumn.Name = "payedInFullDataGridViewCheckBoxColumn";
            this.payedInFullDataGridViewCheckBoxColumn.ReadOnly = true;
            this.payedInFullDataGridViewCheckBoxColumn.Width = 120;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            this.guestIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // checkInDataGridViewCheckBoxColumn
            // 
            this.checkInDataGridViewCheckBoxColumn.DataPropertyName = "CheckIn";
            this.checkInDataGridViewCheckBoxColumn.HeaderText = "CheckIn";
            this.checkInDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.checkInDataGridViewCheckBoxColumn.Name = "checkInDataGridViewCheckBoxColumn";
            this.checkInDataGridViewCheckBoxColumn.ReadOnly = true;
            this.checkInDataGridViewCheckBoxColumn.Width = 120;
            // 
            // reservationsBindingSource
            // 
            this.reservationsBindingSource.DataMember = "reservations";
            this.reservationsBindingSource.DataSource = this.bloomFeildHotelDataSetRes;
            // 
            // bloomFeildHotelDataSetRes
            // 
            this.bloomFeildHotelDataSetRes.DataSetName = "BloomFeildHotelDataSetRes";
            this.bloomFeildHotelDataSetRes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationsTableAdapter
            // 
            this.reservationsTableAdapter.ClearBeforeFill = true;
            // 
            // btnMangeRes
            // 
            this.btnMangeRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnMangeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangeRes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMangeRes.Location = new System.Drawing.Point(24, 805);
            this.btnMangeRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMangeRes.Name = "btnMangeRes";
            this.btnMangeRes.Size = new System.Drawing.Size(582, 135);
            this.btnMangeRes.TabIndex = 54;
            this.btnMangeRes.Text = "Manage Reservation";
            this.btnMangeRes.UseVisualStyleBackColor = false;
            this.btnMangeRes.Click += new System.EventHandler(this.btnMangeRes_Click);
            // 
            // formSearchReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1885, 977);
            this.Controls.Add(this.btnMangeRes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGoResID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formSearchReservation";
            this.Text = "formSearchReservation";
            this.Load += new System.EventHandler(this.formSearchReservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloomFeildHotelDataSetRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloomFeildHotelDataSetReservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbISearch;
        private System.Windows.Forms.Button btnGoResID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bloomFeildHotelDataSetReservationBindingSource;
        
        private BloomFeildHotelDataSetRes bloomFeildHotelDataSetRes;
        private System.Windows.Forms.BindingSource reservationsBindingSource;
        private BloomFeildHotelDataSetResTableAdapters.reservationsTableAdapter reservationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn payedDepositDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn payedInFullDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkInDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnMangeRes;
        private System.Windows.Forms.Label label4;
    }
}