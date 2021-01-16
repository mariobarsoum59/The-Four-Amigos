namespace BloomFeildHotel
{
    partial class formStockManager
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
            this.lblStockManagerMenuTag = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblManagerMenu = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRequestCleaningItems = new System.Windows.Forms.Button();
            this.btnViewStock = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStockManagerMenuTag
            // 
            this.lblStockManagerMenuTag.AutoSize = true;
            this.lblStockManagerMenuTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockManagerMenuTag.Location = new System.Drawing.Point(318, 141);
            this.lblStockManagerMenuTag.Name = "lblStockManagerMenuTag";
            this.lblStockManagerMenuTag.Size = new System.Drawing.Size(345, 39);
            this.lblStockManagerMenuTag.TabIndex = 22;
            this.lblStockManagerMenuTag.Text = "Stock Manager Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblManagerMenu);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 68);
            this.panel1.TabIndex = 21;
            // 
            // lblManagerMenu
            // 
            this.lblManagerMenu.AutoSize = true;
            this.lblManagerMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerMenu.ForeColor = System.Drawing.Color.White;
            this.lblManagerMenu.Location = new System.Drawing.Point(16, 21);
            this.lblManagerMenu.Name = "lblManagerMenu";
            this.lblManagerMenu.Size = new System.Drawing.Size(59, 39);
            this.lblManagerMenu.TabIndex = 0;
            this.lblManagerMenu.Text = "Hi ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(325, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 57);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRequestCleaningItems
            // 
            this.btnRequestCleaningItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnRequestCleaningItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestCleaningItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRequestCleaningItems.Location = new System.Drawing.Point(325, 197);
            this.btnRequestCleaningItems.Name = "btnRequestCleaningItems";
            this.btnRequestCleaningItems.Size = new System.Drawing.Size(161, 104);
            this.btnRequestCleaningItems.TabIndex = 12;
            this.btnRequestCleaningItems.Text = "Request Cleaning Items";
            this.btnRequestCleaningItems.UseVisualStyleBackColor = false;
            this.btnRequestCleaningItems.Click += new System.EventHandler(this.btnRequestCleaningItems_Click);
            // 
            // btnViewStock
            // 
            this.btnViewStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnViewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewStock.Location = new System.Drawing.Point(502, 197);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(161, 104);
            this.btnViewStock.TabIndex = 23;
            this.btnViewStock.Text = "View Stock";
            this.btnViewStock.UseVisualStyleBackColor = false;
            this.btnViewStock.Click += new System.EventHandler(this.btnViewStock_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangePassword.Location = new System.Drawing.Point(158, 197);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(161, 104);
            this.btnChangePassword.TabIndex = 24;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // formStockManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(980, 594);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnViewStock);
            this.Controls.Add(this.lblStockManagerMenuTag);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRequestCleaningItems);
            this.Name = "formStockManager";
            this.Text = "formStockManager";
            this.Load += new System.EventHandler(this.formStockManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockManagerMenuTag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManagerMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRequestCleaningItems;
        private System.Windows.Forms.Button btnViewStock;
        private System.Windows.Forms.Button btnChangePassword;
    }
}