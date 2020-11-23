namespace BloomFeildHotel
{
    partial class formRequestIngredients
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbAvailableIngredients = new System.Windows.Forms.GroupBox();
            this.gbNewIngredient = new System.Windows.Forms.GroupBox();
            this.numNewQty = new System.Windows.Forms.NumericUpDown();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.lbAvailableIngredients = new System.Windows.Forms.ListBox();
            this.gbIngredientsOrder = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbIngredientsOrder = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gbAvailableIngredients.SuspendLayout();
            this.gbNewIngredient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNewQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.gbIngredientsOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 78);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Ingredients";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(687, 684);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 41);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(952, 684);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 41);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // gbAvailableIngredients
            // 
            this.gbAvailableIngredients.Controls.Add(this.gbNewIngredient);
            this.gbAvailableIngredients.Controls.Add(this.label4);
            this.gbAvailableIngredients.Controls.Add(this.btnAdd);
            this.gbAvailableIngredients.Controls.Add(this.cbCategories);
            this.gbAvailableIngredients.Controls.Add(this.numQty);
            this.gbAvailableIngredients.Controls.Add(this.lbAvailableIngredients);
            this.gbAvailableIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAvailableIngredients.Location = new System.Drawing.Point(14, 100);
            this.gbAvailableIngredients.Margin = new System.Windows.Forms.Padding(4);
            this.gbAvailableIngredients.Name = "gbAvailableIngredients";
            this.gbAvailableIngredients.Padding = new System.Windows.Forms.Padding(4);
            this.gbAvailableIngredients.Size = new System.Drawing.Size(357, 713);
            this.gbAvailableIngredients.TabIndex = 5;
            this.gbAvailableIngredients.TabStop = false;
            this.gbAvailableIngredients.Text = "Available Ingredients";
            // 
            // gbNewIngredient
            // 
            this.gbNewIngredient.Controls.Add(this.numNewQty);
            this.gbNewIngredient.Controls.Add(this.tbNewName);
            this.gbNewIngredient.Controls.Add(this.btnAddNew);
            this.gbNewIngredient.Controls.Add(this.label3);
            this.gbNewIngredient.Controls.Add(this.label2);
            this.gbNewIngredient.Location = new System.Drawing.Point(8, 538);
            this.gbNewIngredient.Margin = new System.Windows.Forms.Padding(4);
            this.gbNewIngredient.Name = "gbNewIngredient";
            this.gbNewIngredient.Padding = new System.Windows.Forms.Padding(4);
            this.gbNewIngredient.Size = new System.Drawing.Size(336, 167);
            this.gbNewIngredient.TabIndex = 6;
            this.gbNewIngredient.TabStop = false;
            this.gbNewIngredient.Text = "New Ingredient";
            // 
            // numNewQty
            // 
            this.numNewQty.Location = new System.Drawing.Point(127, 75);
            this.numNewQty.Margin = new System.Windows.Forms.Padding(4);
            this.numNewQty.Name = "numNewQty";
            this.numNewQty.Size = new System.Drawing.Size(70, 22);
            this.numNewQty.TabIndex = 11;
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(127, 46);
            this.tbNewName.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(135, 22);
            this.tbNewName.TabIndex = 10;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(94, 105);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(168, 46);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "Add New Ingredient";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingredient Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(220, 47);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 41);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add to Order";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Items.AddRange(new object[] {
            "Meat",
            "Poultry",
            "Fish",
            "Dairy",
            "Fruits",
            "Vegetables",
            "Dry Grocery",
            "Miscellaneous"});
            this.cbCategories.Location = new System.Drawing.Point(8, 39);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(184, 24);
            this.cbCategories.TabIndex = 5;
            this.cbCategories.Text = "Please Select a Category";
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(288, 17);
            this.numQty.Margin = new System.Windows.Forms.Padding(4);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(47, 22);
            this.numQty.TabIndex = 12;
            // 
            // lbAvailableIngredients
            // 
            this.lbAvailableIngredients.FormattingEnabled = true;
            this.lbAvailableIngredients.ItemHeight = 16;
            this.lbAvailableIngredients.Location = new System.Drawing.Point(8, 96);
            this.lbAvailableIngredients.Margin = new System.Windows.Forms.Padding(4);
            this.lbAvailableIngredients.Name = "lbAvailableIngredients";
            this.lbAvailableIngredients.Size = new System.Drawing.Size(336, 436);
            this.lbAvailableIngredients.TabIndex = 4;
            // 
            // gbIngredientsOrder
            // 
            this.gbIngredientsOrder.Controls.Add(this.button1);
            this.gbIngredientsOrder.Controls.Add(this.btnClear);
            this.gbIngredientsOrder.Controls.Add(this.lbIngredientsOrder);
            this.gbIngredientsOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngredientsOrder.Location = new System.Drawing.Point(687, 100);
            this.gbIngredientsOrder.Margin = new System.Windows.Forms.Padding(4);
            this.gbIngredientsOrder.Name = "gbIngredientsOrder";
            this.gbIngredientsOrder.Padding = new System.Windows.Forms.Padding(4);
            this.gbIngredientsOrder.Size = new System.Drawing.Size(361, 538);
            this.gbIngredientsOrder.TabIndex = 6;
            this.gbIngredientsOrder.TabStop = false;
            this.gbIngredientsOrder.Text = "Ingredients Order";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remove Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(236, 39);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 41);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lbIngredientsOrder
            // 
            this.lbIngredientsOrder.FormattingEnabled = true;
            this.lbIngredientsOrder.ItemHeight = 16;
            this.lbIngredientsOrder.Location = new System.Drawing.Point(8, 94);
            this.lbIngredientsOrder.Margin = new System.Windows.Forms.Padding(4);
            this.lbIngredientsOrder.Name = "lbIngredientsOrder";
            this.lbIngredientsOrder.Size = new System.Drawing.Size(336, 436);
            this.lbIngredientsOrder.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BloomFeildHotel.Properties.Resources.grocery;
            this.pictureBox1.Location = new System.Drawing.Point(378, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 336);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // formRequestIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1066, 828);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbIngredientsOrder);
            this.Controls.Add(this.gbAvailableIngredients);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formRequestIngredients";
            this.Text = "formRequestIngredients";
            this.Load += new System.EventHandler(this.formRequestIngredients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAvailableIngredients.ResumeLayout(false);
            this.gbAvailableIngredients.PerformLayout();
            this.gbNewIngredient.ResumeLayout(false);
            this.gbNewIngredient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNewQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.gbIngredientsOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbAvailableIngredients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbNewIngredient;
        private System.Windows.Forms.NumericUpDown numNewQty;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.ListBox lbAvailableIngredients;
        private System.Windows.Forms.GroupBox gbIngredientsOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbIngredientsOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}