
namespace BloomFeildHotel
{
    partial class formBarStaff
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
            this.lblBarStaff = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBarStaffMenu = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarStaff
            // 
            this.lblBarStaff.AutoSize = true;
            this.lblBarStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarStaff.Location = new System.Drawing.Point(503, 147);
            this.lblBarStaff.Name = "lblBarStaff";
            this.lblBarStaff.Size = new System.Drawing.Size(247, 39);
            this.lblBarStaff.TabIndex = 26;
            this.lblBarStaff.Text = "Bar Staff Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblBarStaffMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 68);
            this.panel1.TabIndex = 25;
            // 
            // lblBarStaffMenu
            // 
            this.lblBarStaffMenu.AutoSize = true;
            this.lblBarStaffMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarStaffMenu.ForeColor = System.Drawing.Color.White;
            this.lblBarStaffMenu.Location = new System.Drawing.Point(16, 21);
            this.lblBarStaffMenu.Name = "lblBarStaffMenu";
            this.lblBarStaffMenu.Size = new System.Drawing.Size(59, 39);
            this.lblBarStaffMenu.TabIndex = 0;
            this.lblBarStaffMenu.Text = "Hi ";
            this.lblBarStaffMenu.Click += new System.EventHandler(this.lblBarStaffMenu_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSales.Location = new System.Drawing.Point(510, 209);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(161, 104);
            this.btnSales.TabIndex = 23;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(510, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 104);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnViewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewOrders.Location = new System.Drawing.Point(697, 209);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(161, 104);
            this.btnViewOrders.TabIndex = 28;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnViewSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewSales.Location = new System.Drawing.Point(697, 341);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(161, 104);
            this.btnViewSales.TabIndex = 34;
            this.btnViewSales.Text = "View Sales";
            this.btnViewSales.UseVisualStyleBackColor = false;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(212, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 104);
            this.button1.TabIndex = 35;
            this.button1.Text = "Sales Test";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formBarStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1261, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViewSales);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblBarStaff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formBarStaff";
            this.Text = "Bar Staff";
            this.Load += new System.EventHandler(this.formBarStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBarStaffMenu;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button button1;
    }
}