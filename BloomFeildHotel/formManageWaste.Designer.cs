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
            this.txtCosttoPrep = new System.Windows.Forms.TextBox();
            this.lblCosttoPrep = new System.Windows.Forms.Label();
            this.txtMoneyWaste = new System.Windows.Forms.TextBox();
            this.lblMoneyWaste = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPrep = new System.Windows.Forms.TextBox();
            this.ingList = new System.Windows.Forms.ListBox();
            this.ingLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.priceList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listQuant = new System.Windows.Forms.ListBox();
            this.lblQuant = new System.Windows.Forms.Label();
            this.btnUpdateWaste = new System.Windows.Forms.Button();
            this.btnEdit1 = new System.Windows.Forms.Button();
            this.btnEdit2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
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
            this.label1.Location = new System.Drawing.Point(370, 98);
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
            this.foodList.Location = new System.Drawing.Point(36, 179);
            this.foodList.Name = "foodList";
            this.foodList.Size = new System.Drawing.Size(190, 124);
            this.foodList.TabIndex = 3;
            this.foodList.SelectedIndexChanged += new System.EventHandler(this.foodList_SelectedIndexChanged);
            // 
            // totalPrep
            // 
            this.totalPrep.Location = new System.Drawing.Point(459, 204);
            this.totalPrep.Name = "totalPrep";
            this.totalPrep.Size = new System.Drawing.Size(100, 26);
            this.totalPrep.TabIndex = 4;
            this.totalPrep.TextChanged += new System.EventHandler(this.totalPrep_TextChanged);
            // 
            // totalRemain
            // 
            this.totalRemain.Location = new System.Drawing.Point(459, 288);
            this.totalRemain.Name = "totalRemain";
            this.totalRemain.Size = new System.Drawing.Size(100, 26);
            this.totalRemain.TabIndex = 5;
            // 
            // lblTotalPrep
            // 
            this.lblTotalPrep.AutoSize = true;
            this.lblTotalPrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrep.Location = new System.Drawing.Point(487, 179);
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
            this.lblTotalLeft.Location = new System.Drawing.Point(476, 263);
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
            this.btnExit.Location = new System.Drawing.Point(495, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCosttoPrep
            // 
            this.txtCosttoPrep.Location = new System.Drawing.Point(735, 204);
            this.txtCosttoPrep.Name = "txtCosttoPrep";
            this.txtCosttoPrep.Size = new System.Drawing.Size(87, 26);
            this.txtCosttoPrep.TabIndex = 9;
            // 
            // lblCosttoPrep
            // 
            this.lblCosttoPrep.AutoSize = true;
            this.lblCosttoPrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosttoPrep.Location = new System.Drawing.Point(696, 179);
            this.lblCosttoPrep.Name = "lblCosttoPrep";
            this.lblCosttoPrep.Size = new System.Drawing.Size(166, 22);
            this.lblCosttoPrep.TabIndex = 10;
            this.lblCosttoPrep.Text = "Prep Cost Per Meal";
            // 
            // txtMoneyWaste
            // 
            this.txtMoneyWaste.Location = new System.Drawing.Point(735, 364);
            this.txtMoneyWaste.Name = "txtMoneyWaste";
            this.txtMoneyWaste.Size = new System.Drawing.Size(87, 26);
            this.txtMoneyWaste.TabIndex = 11;
            // 
            // lblMoneyWaste
            // 
            this.lblMoneyWaste.AutoSize = true;
            this.lblMoneyWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyWaste.Location = new System.Drawing.Point(676, 339);
            this.lblMoneyWaste.Name = "lblMoneyWaste";
            this.lblMoneyWaste.Size = new System.Drawing.Size(196, 22);
            this.lblMoneyWaste.TabIndex = 12;
            this.lblMoneyWaste.Text = "Total Loss From Waste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(707, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Prep Cost";
            // 
            // txtTotalPrep
            // 
            this.txtTotalPrep.Location = new System.Drawing.Point(735, 287);
            this.txtTotalPrep.Name = "txtTotalPrep";
            this.txtTotalPrep.Size = new System.Drawing.Size(87, 26);
            this.txtTotalPrep.TabIndex = 14;
            // 
            // ingList
            // 
            this.ingList.FormattingEnabled = true;
            this.ingList.ItemHeight = 20;
            this.ingList.Location = new System.Drawing.Point(36, 346);
            this.ingList.Name = "ingList";
            this.ingList.Size = new System.Drawing.Size(190, 164);
            this.ingList.TabIndex = 15;
            this.ingList.SelectedIndexChanged += new System.EventHandler(this.ingList_SelectedIndexChanged);
            // 
            // ingLabel
            // 
            this.ingLabel.AutoSize = true;
            this.ingLabel.Location = new System.Drawing.Point(52, 323);
            this.ingLabel.Name = "ingLabel";
            this.ingLabel.Size = new System.Drawing.Size(149, 20);
            this.ingLabel.TabIndex = 16;
            this.ingLabel.Text = "Ingredients Needed";
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(100, 156);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(51, 20);
            this.mealLabel.TabIndex = 17;
            this.mealLabel.Text = "Meals";
            // 
            // priceList
            // 
            this.priceList.FormattingEnabled = true;
            this.priceList.ItemHeight = 20;
            this.priceList.Location = new System.Drawing.Point(241, 346);
            this.priceList.Name = "priceList";
            this.priceList.Size = new System.Drawing.Size(87, 164);
            this.priceList.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price";
            // 
            // listQuant
            // 
            this.listQuant.FormattingEnabled = true;
            this.listQuant.ItemHeight = 20;
            this.listQuant.Location = new System.Drawing.Point(334, 346);
            this.listQuant.Name = "listQuant";
            this.listQuant.Size = new System.Drawing.Size(87, 164);
            this.listQuant.TabIndex = 20;
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(350, 323);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(68, 20);
            this.lblQuant.TabIndex = 21;
            this.lblQuant.Text = "Quantity";
            // 
            // btnUpdateWaste
            // 
            this.btnUpdateWaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.btnUpdateWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateWaste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateWaste.Location = new System.Drawing.Point(613, 461);
            this.btnUpdateWaste.Name = "btnUpdateWaste";
            this.btnUpdateWaste.Size = new System.Drawing.Size(160, 49);
            this.btnUpdateWaste.TabIndex = 22;
            this.btnUpdateWaste.Text = "Export Food";
            this.btnUpdateWaste.UseVisualStyleBackColor = false;
            this.btnUpdateWaste.Click += new System.EventHandler(this.btnUpdateWaste_Click);
            // 
            // btnEdit1
            // 
            this.btnEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.btnEdit1.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit1.Location = new System.Drawing.Point(565, 204);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(74, 26);
            this.btnEdit1.TabIndex = 23;
            this.btnEdit1.Text = "Edit";
            this.btnEdit1.UseVisualStyleBackColor = false;
            // 
            // btnEdit2
            // 
            this.btnEdit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.btnEdit2.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit2.Location = new System.Drawing.Point(565, 288);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(74, 26);
            this.btnEdit2.TabIndex = 24;
            this.btnEdit2.Text = "Edit";
            this.btnEdit2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(779, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 49);
            this.button1.TabIndex = 25;
            this.button1.Text = "Update ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // formManageWaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(960, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdit2);
            this.Controls.Add(this.btnEdit1);
            this.Controls.Add(this.btnUpdateWaste);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.listQuant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceList);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.ingLabel);
            this.Controls.Add(this.ingList);
            this.Controls.Add(this.txtTotalPrep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMoneyWaste);
            this.Controls.Add(this.txtMoneyWaste);
            this.Controls.Add(this.lblCosttoPrep);
            this.Controls.Add(this.txtCosttoPrep);
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
        private System.Windows.Forms.TextBox txtCosttoPrep;
        private System.Windows.Forms.Label lblCosttoPrep;
        private System.Windows.Forms.TextBox txtMoneyWaste;
        private System.Windows.Forms.Label lblMoneyWaste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalPrep;
        private System.Windows.Forms.ListBox ingList;
        private System.Windows.Forms.Label ingLabel;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.ListBox priceList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listQuant;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Button btnUpdateWaste;
        private System.Windows.Forms.Button btnEdit1;
        private System.Windows.Forms.Button btnEdit2;
        private System.Windows.Forms.Button button1;
    }
}