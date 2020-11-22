namespace BloomFeildHotel
{
    partial class formViewWaste
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
            this.lblViewWaste = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.foodList = new System.Windows.Forms.ListBox();
            this.totalPrep = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTotalPrep = new System.Windows.Forms.Label();
            this.lblTotalLeft = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.lblViewWaste);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 87);
            this.panel1.TabIndex = 0;
            // 
            // lblViewWaste
            // 
            this.lblViewWaste.AutoSize = true;
            this.lblViewWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewWaste.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblViewWaste.Location = new System.Drawing.Point(28, 23);
            this.lblViewWaste.Name = "lblViewWaste";
            this.lblViewWaste.Size = new System.Drawing.Size(207, 40);
            this.lblViewWaste.TabIndex = 1;
            this.lblViewWaste.Text = "View Waste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(151, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meals for Today";
            // 
            // foodList
            // 
            this.foodList.FormattingEnabled = true;
            this.foodList.ItemHeight = 20;
            this.foodList.Items.AddRange(new object[] {
            "Chicken Curry and Chips",
            "Fish and Chips",
            "Salad and Soup"});
            this.foodList.Location = new System.Drawing.Point(46, 179);
            this.foodList.Name = "foodList";
            this.foodList.Size = new System.Drawing.Size(190, 124);
            this.foodList.TabIndex = 3;
            // 
            // totalPrep
            // 
            this.totalPrep.Location = new System.Drawing.Point(343, 204);
            this.totalPrep.Name = "totalPrep";
            this.totalPrep.Size = new System.Drawing.Size(100, 26);
            this.totalPrep.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(343, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 5;
            // 
            // lblTotalPrep
            // 
            this.lblTotalPrep.AutoSize = true;
            this.lblTotalPrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrep.Location = new System.Drawing.Point(330, 179);
            this.lblTotalPrep.Name = "lblTotalPrep";
            this.lblTotalPrep.Size = new System.Drawing.Size(130, 22);
            this.lblTotalPrep.TabIndex = 6;
            this.lblTotalPrep.Text = "Total Prepared";
            // 
            // lblTotalLeft
            // 
            this.lblTotalLeft.AutoSize = true;
            this.lblTotalLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLeft.Location = new System.Drawing.Point(330, 259);
            this.lblTotalLeft.Name = "lblTotalLeft";
            this.lblTotalLeft.Size = new System.Drawing.Size(141, 22);
            this.lblTotalLeft.TabIndex = 7;
            this.lblTotalLeft.Text = "Total Remaining";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(223, 371);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // ViewWaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(536, 459);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalLeft);
            this.Controls.Add(this.lblTotalPrep);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.totalPrep);
            this.Controls.Add(this.foodList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ViewWaste";
            this.Text = "ViewWaste";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblViewWaste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox foodList;
        private System.Windows.Forms.TextBox totalPrep;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTotalPrep;
        private System.Windows.Forms.Label lblTotalLeft;
        private System.Windows.Forms.Button btnExit;
    }
}