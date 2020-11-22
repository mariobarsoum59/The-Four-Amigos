namespace BloomFeildHotel
{
    partial class formOrderStatusChange
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
            this.lblChangeStatus = new System.Windows.Forms.Label();
            this.listOrders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnInProgress = new System.Windows.Forms.RadioButton();
            this.btnReadyServing = new System.Windows.Forms.RadioButton();
            this.btnComplete = new System.Windows.Forms.RadioButton();
            this.btnChange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.lblChangeStatus);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 88);
            this.panel1.TabIndex = 0;
            // 
            // lblChangeStatus
            // 
            this.lblChangeStatus.AutoSize = true;
            this.lblChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChangeStatus.Location = new System.Drawing.Point(30, 24);
            this.lblChangeStatus.Name = "lblChangeStatus";
            this.lblChangeStatus.Size = new System.Drawing.Size(357, 40);
            this.lblChangeStatus.TabIndex = 13;
            this.lblChangeStatus.Text = "Change Order Status";
            // 
            // listOrders
            // 
            this.listOrders.FormattingEnabled = true;
            this.listOrders.ItemHeight = 20;
            this.listOrders.Items.AddRange(new object[] {
            "Burger, Chips, Cola",
            "Salad, Fries, Water",
            "Chicken Curry, Seven-Up"});
            this.listOrders.Location = new System.Drawing.Point(57, 171);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(290, 124);
            this.listOrders.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Order Summary";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(247, 351);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 42);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(57, 351);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 42);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(468, 134);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(267, 26);
            this.lblChange.TabIndex = 5;
            this.lblChange.Text = "Current Order Summary";
            // 
            // btnInProgress
            // 
            this.btnInProgress.AutoSize = true;
            this.btnInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInProgress.Location = new System.Drawing.Point(473, 184);
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Size = new System.Drawing.Size(136, 29);
            this.btnInProgress.TabIndex = 6;
            this.btnInProgress.TabStop = true;
            this.btnInProgress.Text = "In Progress";
            this.btnInProgress.UseVisualStyleBackColor = true;
            // 
            // btnReadyServing
            // 
            this.btnReadyServing.AutoSize = true;
            this.btnReadyServing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadyServing.Location = new System.Drawing.Point(473, 235);
            this.btnReadyServing.Name = "btnReadyServing";
            this.btnReadyServing.Size = new System.Drawing.Size(192, 29);
            this.btnReadyServing.TabIndex = 7;
            this.btnReadyServing.TabStop = true;
            this.btnReadyServing.Text = "Ready for Serving";
            this.btnReadyServing.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            this.btnComplete.AutoSize = true;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(473, 285);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(121, 29);
            this.btnComplete.TabIndex = 8;
            this.btnComplete.TabStop = true;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(473, 351);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(103, 42);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // formOrderStatusChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(844, 461);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnReadyServing);
            this.Controls.Add(this.btnInProgress);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOrders);
            this.Controls.Add(this.panel1);
            this.Name = "formOrderStatusChange";
            this.Text = "formOrderStatusChange";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChangeStatus;
        private System.Windows.Forms.ListBox listOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.RadioButton btnInProgress;
        private System.Windows.Forms.RadioButton btnReadyServing;
        private System.Windows.Forms.RadioButton btnComplete;
        private System.Windows.Forms.Button btnChange;
    }
}