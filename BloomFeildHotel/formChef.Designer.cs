namespace BloomFeildHotel
{
    partial class formChef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChef));
            this.lblManagerMenuTag = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChefMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChangeOrderStatus = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMangeWaste = new System.Windows.Forms.Button();
            this.btnRequestIngredients = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnPrepMeal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManagerMenuTag
            // 
            this.lblManagerMenuTag.AutoSize = true;
            this.lblManagerMenuTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerMenuTag.Location = new System.Drawing.Point(882, 235);
            this.lblManagerMenuTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerMenuTag.Name = "lblManagerMenuTag";
            this.lblManagerMenuTag.Size = new System.Drawing.Size(283, 61);
            this.lblManagerMenuTag.TabIndex = 22;
            this.lblManagerMenuTag.Text = "Chef Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblChefMenu);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 105);
            this.panel1.TabIndex = 21;
            // 
            // lblChefMenu
            // 
            this.lblChefMenu.AutoSize = true;
            this.lblChefMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.lblChefMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefMenu.ForeColor = System.Drawing.Color.White;
            this.lblChefMenu.Location = new System.Drawing.Point(24, 32);
            this.lblChefMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChefMenu.Name = "lblChefMenu";
            this.lblChefMenu.Size = new System.Drawing.Size(92, 61);
            this.lblChefMenu.TabIndex = 0;
            this.lblChefMenu.Text = "Hi ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BloomFeildHotel.Properties.Resources.Webp_net_resizeimage;
            this.pictureBox1.Location = new System.Drawing.Point(58, 134);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 202);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnChangeOrderStatus
            // 
            this.btnChangeOrderStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnChangeOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeOrderStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeOrderStatus.Location = new System.Drawing.Point(908, 342);
            this.btnChangeOrderStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangeOrderStatus.Name = "btnChangeOrderStatus";
            this.btnChangeOrderStatus.Size = new System.Drawing.Size(242, 160);
            this.btnChangeOrderStatus.TabIndex = 33;
            this.btnChangeOrderStatus.Text = "Manage Order";
            this.btnChangeOrderStatus.UseVisualStyleBackColor = false;
            this.btnChangeOrderStatus.Click += new System.EventHandler(this.btnChangeOrderStatus_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnViewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewOrders.Location = new System.Drawing.Point(657, 342);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(242, 160);
            this.btnViewOrders.TabIndex = 31;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(1158, 511);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(242, 160);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMangeWaste
            // 
            this.btnMangeWaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnMangeWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangeWaste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMangeWaste.Location = new System.Drawing.Point(657, 511);
            this.btnMangeWaste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMangeWaste.Name = "btnMangeWaste";
            this.btnMangeWaste.Size = new System.Drawing.Size(242, 160);
            this.btnMangeWaste.TabIndex = 35;
            this.btnMangeWaste.Text = "Manage Waste";
            this.btnMangeWaste.UseVisualStyleBackColor = false;
            this.btnMangeWaste.Click += new System.EventHandler(this.btnMangeWaste_Click);
            // 
            // btnRequestIngredients
            // 
            this.btnRequestIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnRequestIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestIngredients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRequestIngredients.Location = new System.Drawing.Point(908, 511);
            this.btnRequestIngredients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRequestIngredients.Name = "btnRequestIngredients";
            this.btnRequestIngredients.Size = new System.Drawing.Size(242, 160);
            this.btnRequestIngredients.TabIndex = 36;
            this.btnRequestIngredients.Text = "Request Ingredients";
            this.btnRequestIngredients.UseVisualStyleBackColor = false;
            this.btnRequestIngredients.Click += new System.EventHandler(this.btnRequestIngredients_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangePassword.Location = new System.Drawing.Point(406, 511);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(242, 160);
            this.btnChangePassword.TabIndex = 37;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeStatus.Location = new System.Drawing.Point(406, 341);
            this.btnChangeStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(242, 160);
            this.btnChangeStatus.TabIndex = 38;
            this.btnChangeStatus.Text = "Change Order Status";
            this.btnChangeStatus.UseVisualStyleBackColor = false;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnPrepMeal
            // 
            this.btnPrepMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnPrepMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrepMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrepMeal.Location = new System.Drawing.Point(1158, 341);
            this.btnPrepMeal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrepMeal.Name = "btnPrepMeal";
            this.btnPrepMeal.Size = new System.Drawing.Size(242, 160);
            this.btnPrepMeal.TabIndex = 39;
            this.btnPrepMeal.Text = "Add Prepared Meal";
            this.btnPrepMeal.UseVisualStyleBackColor = false;
            this.btnPrepMeal.Click += new System.EventHandler(this.btnPrepMeal_Click);
            // 
            // formChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1892, 942);
            this.Controls.Add(this.btnPrepMeal);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnRequestIngredients);
            this.Controls.Add(this.btnMangeWaste);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeOrderStatus);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblManagerMenuTag);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formChef";
            this.Text = "formChef";
            this.Load += new System.EventHandler(this.formChef_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManagerMenuTag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChefMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChangeOrderStatus;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMangeWaste;
        private System.Windows.Forms.Button btnRequestIngredients;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnPrepMeal;
    }
}