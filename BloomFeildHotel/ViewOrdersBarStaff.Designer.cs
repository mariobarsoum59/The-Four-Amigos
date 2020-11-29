
namespace BloomFeildHotel
{
    partial class ViewOrdersBarStaff
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblAddDrink = new System.Windows.Forms.Label();
            this.AddFood = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblCreateReservation);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 71);
            this.panel1.TabIndex = 25;
            // 
            // lblCreateReservation
            // 
            this.lblCreateReservation.AutoSize = true;
            this.lblCreateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateReservation.ForeColor = System.Drawing.Color.White;
            this.lblCreateReservation.Location = new System.Drawing.Point(3, 21);
            this.lblCreateReservation.Name = "lblCreateReservation";
            this.lblCreateReservation.Size = new System.Drawing.Size(208, 39);
            this.lblCreateReservation.TabIndex = 0;
            this.lblCreateReservation.Text = "View Orders";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Pint of Heinken €5.50",
            "Coca Cola €3.00"});
            this.listBox2.Location = new System.Drawing.Point(742, 119);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(277, 290);
            this.listBox2.TabIndex = 43;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "15: 00 Fish & Chips €15 ",
            "1: 00 Chicken Burger €13"});
            this.listBox1.Location = new System.Drawing.Point(371, 119);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 290);
            this.listBox1.TabIndex = 42;
            // 
            // lblAddDrink
            // 
            this.lblAddDrink.AutoSize = true;
            this.lblAddDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDrink.Location = new System.Drawing.Point(100, 96);
            this.lblAddDrink.Name = "lblAddDrink";
            this.lblAddDrink.Size = new System.Drawing.Size(112, 20);
            this.lblAddDrink.TabIndex = 41;
            this.lblAddDrink.Text = "Todays Orders";
            this.lblAddDrink.Click += new System.EventHandler(this.lblAddDrink_Click);
            // 
            // AddFood
            // 
            this.AddFood.AutoSize = true;
            this.AddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFood.Location = new System.Drawing.Point(408, 96);
            this.AddFood.Name = "AddFood";
            this.AddFood.Size = new System.Drawing.Size(193, 20);
            this.AddFood.TabIndex = 40;
            this.AddFood.Text = "Todays Completed Orders";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "14: 00 Pint of Heinken €5.50",
            "16: 00 Coca Cola €3.00"});
            this.listBox3.Location = new System.Drawing.Point(13, 119);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(277, 290);
            this.listBox3.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(738, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Orders Made Over The Past Tree Days";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayment.Location = new System.Drawing.Point(11, 415);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(279, 88);
            this.btnPayment.TabIndex = 46;
            this.btnPayment.Text = "Complete Orders";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(368, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 88);
            this.button1.TabIndex = 47;
            this.button1.Text = "Remove Complete Orders";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(740, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 88);
            this.button2.TabIndex = 48;
            this.button2.Text = "Additional Notes";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ViewOrdersBarStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1038, 594);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblAddDrink);
            this.Controls.Add(this.AddFood);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewOrdersBarStaff";
            this.Text = "ViewOrdersBarStaff";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreateReservation;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblAddDrink;
        private System.Windows.Forms.Label AddFood;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}