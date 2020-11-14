namespace ChangeOrderStatus
{
    partial class Form1
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
            this.changeStatusLBL = new System.Windows.Forms.Label();
            this.Current_Order_Summary = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changesLBL = new System.Windows.Forms.Label();
            this.inProgress = new System.Windows.Forms.RadioButton();
            this.readyForServing = new System.Windows.Forms.RadioButton();
            this.complete = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.changeStatusLBL);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 72);
            this.panel1.TabIndex = 0;
            // 
            // changeStatusLBL
            // 
            this.changeStatusLBL.AutoSize = true;
            this.changeStatusLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeStatusLBL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeStatusLBL.Location = new System.Drawing.Point(23, 21);
            this.changeStatusLBL.Name = "changeStatusLBL";
            this.changeStatusLBL.Size = new System.Drawing.Size(301, 32);
            this.changeStatusLBL.TabIndex = 0;
            this.changeStatusLBL.Text = "Change Order Status";
            // 
            // Current_Order_Summary
            // 
            this.Current_Order_Summary.FormattingEnabled = true;
            this.Current_Order_Summary.ItemHeight = 20;
            this.Current_Order_Summary.Items.AddRange(new object[] {
            "Burger, Chips, Cola",
            "Salad, Soup, Tea"});
            this.Current_Order_Summary.Location = new System.Drawing.Point(41, 167);
            this.Current_Order_Summary.Name = "Current_Order_Summary";
            this.Current_Order_Summary.Size = new System.Drawing.Size(240, 84);
            this.Current_Order_Summary.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Order Summary";
            // 
            // changesLBL
            // 
            this.changesLBL.AutoSize = true;
            this.changesLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changesLBL.Location = new System.Drawing.Point(420, 121);
            this.changesLBL.Name = "changesLBL";
            this.changesLBL.Size = new System.Drawing.Size(143, 25);
            this.changesLBL.TabIndex = 3;
            this.changesLBL.Text = "Change Status";
            // 
            // inProgress
            // 
            this.inProgress.AutoSize = true;
            this.inProgress.Location = new System.Drawing.Point(425, 167);
            this.inProgress.Name = "inProgress";
            this.inProgress.Size = new System.Drawing.Size(115, 24);
            this.inProgress.TabIndex = 4;
            this.inProgress.TabStop = true;
            this.inProgress.Text = "In Progress";
            this.inProgress.UseVisualStyleBackColor = true;
            // 
            // readyForServing
            // 
            this.readyForServing.AutoSize = true;
            this.readyForServing.Location = new System.Drawing.Point(425, 207);
            this.readyForServing.Name = "readyForServing";
            this.readyForServing.Size = new System.Drawing.Size(165, 24);
            this.readyForServing.TabIndex = 5;
            this.readyForServing.TabStop = true;
            this.readyForServing.Text = "Ready For Serving";
            this.readyForServing.UseVisualStyleBackColor = true;
            // 
            // complete
            // 
            this.complete.AutoSize = true;
            this.complete.Location = new System.Drawing.Point(425, 249);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(102, 24);
            this.complete.TabIndex = 6;
            this.complete.TabStop = true;
            this.complete.Text = "Complete";
            this.complete.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(41, 274);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(93, 33);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(425, 350);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(117, 49);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(41, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 49);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Return";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(803, 437);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.readyForServing);
            this.Controls.Add(this.inProgress);
            this.Controls.Add(this.changesLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Current_Order_Summary);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label changeStatusLBL;
        private System.Windows.Forms.ListBox Current_Order_Summary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label changesLBL;
        private System.Windows.Forms.RadioButton inProgress;
        private System.Windows.Forms.RadioButton readyForServing;
        private System.Windows.Forms.RadioButton complete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnExit;
    }
}

