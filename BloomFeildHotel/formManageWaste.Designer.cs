namespace BloomFeildHotel
{
    partial class formManageWaste
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
            this.txtCosttoPrep = new System.Windows.Forms.TextBox();
            this.lblCosttoPrep = new System.Windows.Forms.Label();
            this.txtMoneyWaste = new System.Windows.Forms.TextBox();
            this.lblMoneyWaste = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPrep = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.lblViewWaste);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 88);
            this.panel1.TabIndex = 0;
            // 
            // lblViewWaste
            // 
            this.lblViewWaste.AutoSize = true;
            this.lblViewWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewWaste.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblViewWaste.Location = new System.Drawing.Point(28, 23);
            this.lblViewWaste.Name = "lblViewWaste";
            this.lblViewWaste.Size = new System.Drawing.Size(259, 40);
            this.lblViewWaste.TabIndex = 1;
            this.lblViewWaste.Text = "Manage Waste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(243, 106);
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
            this.totalPrep.Location = new System.Drawing.Point(273, 204);
            this.totalPrep.Name = "totalPrep";
            this.totalPrep.Size = new System.Drawing.Size(100, 26);
            this.totalPrep.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(273, 296);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 5;
            // 
            // lblTotalPrep
            // 
            this.lblTotalPrep.AutoSize = true;
            this.lblTotalPrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrep.Location = new System.Drawing.Point(258, 179);
            this.lblTotalPrep.Name = "lblTotalPrep";
            this.lblTotalPrep.Size = new System.Drawing.Size(130, 22);
            this.lblTotalPrep.TabIndex = 6;
            this.lblTotalPrep.Text = "Total Prepared";
            this.lblTotalPrep.Click += new System.EventHandler(this.lblTotalPrep_Click);
            // 
            // lblTotalLeft
            // 
            this.lblTotalLeft.AutoSize = true;
            this.lblTotalLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLeft.Location = new System.Drawing.Point(258, 262);
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
            this.btnExit.Location = new System.Drawing.Point(262, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // txtCosttoPrep
            // 
            this.txtCosttoPrep.Location = new System.Drawing.Point(500, 204);
            this.txtCosttoPrep.Name = "txtCosttoPrep";
            this.txtCosttoPrep.Size = new System.Drawing.Size(87, 26);
            this.txtCosttoPrep.TabIndex = 9;
            // 
            // lblCosttoPrep
            // 
            this.lblCosttoPrep.AutoSize = true;
            this.lblCosttoPrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosttoPrep.Location = new System.Drawing.Point(476, 179);
            this.lblCosttoPrep.Name = "lblCosttoPrep";
            this.lblCosttoPrep.Size = new System.Drawing.Size(166, 22);
            this.lblCosttoPrep.TabIndex = 10;
            this.lblCosttoPrep.Text = "Prep Cost Per Meal";
            // 
            // txtMoneyWaste
            // 
            this.txtMoneyWaste.Location = new System.Drawing.Point(500, 362);
            this.txtMoneyWaste.Name = "txtMoneyWaste";
            this.txtMoneyWaste.Size = new System.Drawing.Size(87, 26);
            this.txtMoneyWaste.TabIndex = 11;
            // 
            // lblMoneyWaste
            // 
            this.lblMoneyWaste.AutoSize = true;
            this.lblMoneyWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyWaste.Location = new System.Drawing.Point(436, 337);
            this.lblMoneyWaste.Name = "lblMoneyWaste";
            this.lblMoneyWaste.Size = new System.Drawing.Size(196, 22);
            this.lblMoneyWaste.TabIndex = 12;
            this.lblMoneyWaste.Text = "Total Loss From Waste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Prep Cost";
            // 
            // txtTotalPrep
            // 
            this.txtTotalPrep.Location = new System.Drawing.Point(500, 287);
            this.txtTotalPrep.Name = "txtTotalPrep";
            this.txtTotalPrep.Size = new System.Drawing.Size(87, 26);
            this.txtTotalPrep.TabIndex = 14;
            // 
            // formManageWaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(723, 524);
            this.Controls.Add(this.txtTotalPrep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMoneyWaste);
            this.Controls.Add(this.txtMoneyWaste);
            this.Controls.Add(this.lblCosttoPrep);
            this.Controls.Add(this.txtCosttoPrep);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalLeft);
            this.Controls.Add(this.lblTotalPrep);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.totalPrep);
            this.Controls.Add(this.foodList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "formManageWaste";
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
        private System.Windows.Forms.TextBox txtCosttoPrep;
        private System.Windows.Forms.Label lblCosttoPrep;
        private System.Windows.Forms.TextBox txtMoneyWaste;
        private System.Windows.Forms.Label lblMoneyWaste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalPrep;
    }
}