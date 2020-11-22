namespace BloomFeildHotel
{
    partial class formConfPass
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
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPass1 = new System.Windows.Forms.Label();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.lblConfirmPass);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 80);
            this.panel1.TabIndex = 0;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConfirmPass.Location = new System.Drawing.Point(12, 26);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(245, 32);
            this.lblConfirmPass.TabIndex = 12;
            this.lblConfirmPass.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please confirm your password before continuing";
            // 
            // lblPass1
            // 
            this.lblPass1.AutoSize = true;
            this.lblPass1.Location = new System.Drawing.Point(39, 211);
            this.lblPass1.Name = "lblPass1";
            this.lblPass1.Size = new System.Drawing.Size(82, 20);
            this.lblPass1.TabIndex = 2;
            this.lblPass1.Text = "Password:";
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.Location = new System.Drawing.Point(39, 276);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(141, 20);
            this.lblPass2.TabIndex = 3;
            this.lblPass2.Text = "Confirm Password:";
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(211, 205);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Size = new System.Drawing.Size(200, 26);
            this.txtPass1.TabIndex = 4;
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(211, 270);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(200, 26);
            this.txtPass2.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(162, 355);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 46);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // formConfPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(451, 476);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.lblPass2);
            this.Controls.Add(this.lblPass1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "formConfPass";
            this.Text = "formConfPass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPass1;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.Button btnSubmit;
    }
}