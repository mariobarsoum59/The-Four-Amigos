namespace BloomFeildHotel
{
    partial class formSavedGuests
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGuests = new System.Windows.Forms.Label();
            this.dataGridViewGuests = new System.Windows.Forms.DataGridView();
            this.guestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketingInfoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloomFeildHotelDataSet = new BloomFeildHotel.BloomFeildHotelDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGoFname = new System.Windows.Forms.Button();
            this.btnGoSname = new System.Windows.Forms.Button();
            this.guestsTableAdapter = new BloomFeildHotel.BloomFeildHotelDataSetTableAdapters.guestsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloomFeildHotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblGuests);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 68);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(4, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(685, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Note: When Choosing a Guest Click On the Very First Column For the Desired Guest";
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Font = new System.Drawing.Font("Opus Chords Sans Std", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.ForeColor = System.Drawing.Color.White;
            this.lblGuests.Location = new System.Drawing.Point(0, 0);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(123, 47);
            this.lblGuests.TabIndex = 0;
            this.lblGuests.Text = "Guests";
            // 
            // dataGridViewGuests
            // 
            this.dataGridViewGuests.AllowUserToAddRows = false;
            this.dataGridViewGuests.AllowUserToDeleteRows = false;
            this.dataGridViewGuests.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guestIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.marketingInfoDataGridViewCheckBoxColumn});
            this.dataGridViewGuests.DataSource = this.guestsBindingSource;
            this.dataGridViewGuests.Location = new System.Drawing.Point(8, 134);
            this.dataGridViewGuests.Name = "dataGridViewGuests";
            this.dataGridViewGuests.ReadOnly = true;
            this.dataGridViewGuests.Size = new System.Drawing.Size(743, 364);
            this.dataGridViewGuests.TabIndex = 14;
            this.dataGridViewGuests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewGuests_CellClick);
            this.dataGridViewGuests.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewGuests_CellContentDoubleClick);
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            this.guestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marketingInfoDataGridViewCheckBoxColumn
            // 
            this.marketingInfoDataGridViewCheckBoxColumn.DataPropertyName = "MarketingInfo";
            this.marketingInfoDataGridViewCheckBoxColumn.HeaderText = "MarketingInfo";
            this.marketingInfoDataGridViewCheckBoxColumn.Name = "marketingInfoDataGridViewCheckBoxColumn";
            this.marketingInfoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataMember = "guests";
            this.guestsBindingSource.DataSource = this.bloomFeildHotelDataSet;
            // 
            // bloomFeildHotelDataSet
            // 
            this.bloomFeildHotelDataSet.DataSetName = "BloomFeildHotelDataSet";
            this.bloomFeildHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(104, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 26);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(489, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 26);
            this.textBox2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Surname";
            // 
            // btnGoFname
            // 
            this.btnGoFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnGoFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoFname.ForeColor = System.Drawing.Color.White;
            this.btnGoFname.Location = new System.Drawing.Point(309, 95);
            this.btnGoFname.Name = "btnGoFname";
            this.btnGoFname.Size = new System.Drawing.Size(60, 30);
            this.btnGoFname.TabIndex = 19;
            this.btnGoFname.Text = "Go";
            this.btnGoFname.UseVisualStyleBackColor = false;
            this.btnGoFname.Click += new System.EventHandler(this.BtnGoFname_Click);
            // 
            // btnGoSname
            // 
            this.btnGoSname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnGoSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoSname.ForeColor = System.Drawing.Color.White;
            this.btnGoSname.Location = new System.Drawing.Point(688, 94);
            this.btnGoSname.Name = "btnGoSname";
            this.btnGoSname.Size = new System.Drawing.Size(60, 30);
            this.btnGoSname.TabIndex = 20;
            this.btnGoSname.Text = "Go";
            this.btnGoSname.UseVisualStyleBackColor = false;
            this.btnGoSname.Click += new System.EventHandler(this.BtnGoSname_Click);
            // 
            // guestsTableAdapter
            // 
            this.guestsTableAdapter.ClearBeforeFill = true;
            // 
            // formSavedGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(763, 510);
            this.Controls.Add(this.btnGoSname);
            this.Controls.Add(this.btnGoFname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewGuests);
            this.Controls.Add(this.panel1);
            this.Name = "formSavedGuests";
            this.Text = "formSavedGuests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSavedGuests_FormClosed);
            this.Load += new System.EventHandler(this.FormSavedGuests_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloomFeildHotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.DataGridView dataGridViewGuests;
        private BloomFeildHotelDataSet bloomFeildHotelDataSet;
        private System.Windows.Forms.BindingSource guestsBindingSource;
        private BloomFeildHotelDataSetTableAdapters.guestsTableAdapter guestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn marketingInfoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGoFname;
        private System.Windows.Forms.Button btnGoSname;
        private System.Windows.Forms.Label label4;
    }
}