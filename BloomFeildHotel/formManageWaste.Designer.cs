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
            this.totalRemain = new System.Windows.Forms.TextBox();
            this.lblTotalPrep = new System.Windows.Forms.Label();
            this.lblTotalLeft = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMoneyWaste = new System.Windows.Forms.TextBox();
            this.lblMoneyWaste = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.btnUpdateWaste = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.lblViewWaste);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 85);
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
            this.label1.Location = new System.Drawing.Point(346, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meal Waste";
            // 
            // foodList
            // 
            this.foodList.FormattingEnabled = true;
            this.foodList.ItemHeight = 20;
            this.foodList.Location = new System.Drawing.Point(69, 226);
            this.foodList.Name = "foodList";
            this.foodList.Size = new System.Drawing.Size(190, 124);
            this.foodList.TabIndex = 3;
            this.foodList.SelectedIndexChanged += new System.EventHandler(this.foodList_SelectedIndexChanged);
            // 
            // totalPrep
            // 
            this.totalPrep.Location = new System.Drawing.Point(373, 226);
            this.totalPrep.Name = "totalPrep";
            this.totalPrep.Size = new System.Drawing.Size(100, 26);
            this.totalPrep.TabIndex = 4;
            this.totalPrep.TextChanged += new System.EventHandler(this.totalPrep_TextChanged);
            // 
            // totalRemain
            // 
            this.totalRemain.Location = new System.Drawing.Point(373, 310);
            this.totalRemain.Name = "totalRemain";
            this.totalRemain.Size = new System.Drawing.Size(100, 26);
            this.totalRemain.TabIndex = 5;
            // 
            // lblTotalPrep
            // 
            this.lblTotalPrep.AutoSize = true;
            this.lblTotalPrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrep.Location = new System.Drawing.Point(358, 201);
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
            this.lblTotalLeft.Location = new System.Drawing.Point(348, 285);
            this.lblTotalLeft.Name = "lblTotalLeft";
            this.lblTotalLeft.Size = new System.Drawing.Size(141, 22);
            this.lblTotalLeft.TabIndex = 7;
            this.lblTotalLeft.Text = "Total Remaining";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(221, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMoneyWaste
            // 
            this.txtMoneyWaste.Location = new System.Drawing.Point(634, 226);
            this.txtMoneyWaste.Name = "txtMoneyWaste";
            this.txtMoneyWaste.Size = new System.Drawing.Size(87, 26);
            this.txtMoneyWaste.TabIndex = 11;
            // 
            // lblMoneyWaste
            // 
            this.lblMoneyWaste.AutoSize = true;
            this.lblMoneyWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyWaste.Location = new System.Drawing.Point(579, 201);
            this.lblMoneyWaste.Name = "lblMoneyWaste";
            this.lblMoneyWaste.Size = new System.Drawing.Size(196, 22);
            this.lblMoneyWaste.TabIndex = 12;
            this.lblMoneyWaste.Text = "Total Loss From Waste";
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(139, 203);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(51, 20);
            this.mealLabel.TabIndex = 17;
            this.mealLabel.Text = "Meals";
            // 
            // btnUpdateWaste
            // 
            this.btnUpdateWaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.btnUpdateWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateWaste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateWaste.Location = new System.Drawing.Point(396, 461);
            this.btnUpdateWaste.Name = "btnUpdateWaste";
            this.btnUpdateWaste.Size = new System.Drawing.Size(160, 49);
            this.btnUpdateWaste.TabIndex = 22;
            this.btnUpdateWaste.Text = "Export Food";
            this.btnUpdateWaste.UseVisualStyleBackColor = false;
            this.btnUpdateWaste.Click += new System.EventHandler(this.btnUpdateWaste_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(587, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 49);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add Waste";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(69, 461);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 49);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(583, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 49);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // formManageWaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(836, 576);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateWaste);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.lblMoneyWaste);
            this.Controls.Add(this.txtMoneyWaste);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalLeft);
            this.Controls.Add(this.lblTotalPrep);
            this.Controls.Add(this.totalRemain);
            this.Controls.Add(this.totalPrep);
            this.Controls.Add(this.foodList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formManageWaste";
            this.Text = "ViewWaste";
            this.Load += new System.EventHandler(this.formManageWaste_Load);
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
        private System.Windows.Forms.TextBox totalRemain;
        private System.Windows.Forms.Label lblTotalPrep;
        private System.Windows.Forms.Label lblTotalLeft;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMoneyWaste;
        private System.Windows.Forms.Label lblMoneyWaste;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.Button btnUpdateWaste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
    }
}