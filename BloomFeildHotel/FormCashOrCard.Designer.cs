
namespace BloomFeildHotel
{
    partial class FormCashOrCard
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
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblCreateReservation);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 109);
            this.panel1.TabIndex = 77;
            // 
            // lblCreateReservation
            // 
            this.lblCreateReservation.AutoSize = true;
            this.lblCreateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateReservation.ForeColor = System.Drawing.Color.White;
            this.lblCreateReservation.Location = new System.Drawing.Point(4, 32);
            this.lblCreateReservation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateReservation.Name = "lblCreateReservation";
            this.lblCreateReservation.Size = new System.Drawing.Size(351, 61);
            this.lblCreateReservation.TabIndex = 0;
            this.lblCreateReservation.Text = "Cash Or Card";
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCash.Location = new System.Drawing.Point(358, 157);
            this.btnCash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(223, 135);
            this.btnCash.TabIndex = 79;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCard.Location = new System.Drawing.Point(15, 157);
            this.btnCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(216, 135);
            this.btnCard.TabIndex = 78;
            this.btnCard.Text = "Card";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(184, 324);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(216, 135);
            this.btnBack.TabIndex = 80;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormCashOrCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(594, 488);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCashOrCard";
            this.Text = "FormCashOrCard";
            this.Load += new System.EventHandler(this.FormCashOrCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreateReservation;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnBack;
    }
}