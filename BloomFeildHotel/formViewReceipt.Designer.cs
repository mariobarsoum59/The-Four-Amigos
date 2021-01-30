
namespace BloomFeildHotel
{
    partial class formViewReceipt
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
            this.btnOk = new System.Windows.Forms.Button();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreateReservation = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.listBoxSubtotal = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(668, 675);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(647, 135);
            this.btnOk.TabIndex = 48;
            this.btnOk.Text = "Back";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.BackColor = System.Drawing.Color.White;
            this.listBoxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOrders.ForeColor = System.Drawing.Color.Black;
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 25;
            this.listBoxOrders.Location = new System.Drawing.Point(13, 186);
            this.listBoxOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(647, 479);
            this.listBoxOrders.TabIndex = 44;
            this.listBoxOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxOrders_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblCreateReservation);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 109);
            this.panel1.TabIndex = 49;
            // 
            // lblCreateReservation
            // 
            this.lblCreateReservation.AutoSize = true;
            this.lblCreateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateReservation.ForeColor = System.Drawing.Color.White;
            this.lblCreateReservation.Location = new System.Drawing.Point(4, 32);
            this.lblCreateReservation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateReservation.Name = "lblCreateReservation";
            this.lblCreateReservation.Size = new System.Drawing.Size(234, 61);
            this.lblCreateReservation.TabIndex = 0;
            this.lblCreateReservation.Text = "Receipts";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(663, 153);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(170, 29);
            this.Amount.TabIndex = 52;
            this.Amount.Text = "Order Subtotal";
            // 
            // listBoxSubtotal
            // 
            this.listBoxSubtotal.BackColor = System.Drawing.Color.White;
            this.listBoxSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSubtotal.ForeColor = System.Drawing.Color.Black;
            this.listBoxSubtotal.FormattingEnabled = true;
            this.listBoxSubtotal.ItemHeight = 25;
            this.listBoxSubtotal.Location = new System.Drawing.Point(668, 186);
            this.listBoxSubtotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxSubtotal.Name = "listBoxSubtotal";
            this.listBoxSubtotal.Size = new System.Drawing.Size(647, 479);
            this.listBoxSubtotal.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Select Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(651, 29);
            this.label2.TabIndex = 55;
            this.label2.Text = "Note Orders with the same ID get Calculated for the subtotal";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(13, 675);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(647, 135);
            this.button1.TabIndex = 56;
            this.button1.Text = "Clear Subtotals";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formViewReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1332, 842);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSubtotal);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.listBoxOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formViewReceipt";
            this.Text = "formViewReceipt";
            this.Load += new System.EventHandler(this.formViewReceipt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreateReservation;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.ListBox listBoxSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}