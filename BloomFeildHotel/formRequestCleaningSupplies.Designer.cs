namespace BloomFeildHotel
{
    partial class formRequestCleaningSupplies
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
            this.lblSupplies = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbIngredientsOrder = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbIngredientsOrder = new System.Windows.Forms.ListBox();
            this.gbAvailableIngredients = new System.Windows.Forms.GroupBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.lbAvailableIngredients = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbIngredientsOrder.SuspendLayout();
            this.gbAvailableIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblSupplies);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 108);
            this.panel1.TabIndex = 24;
            // 
            // lblSupplies
            // 
            this.lblSupplies.AutoSize = true;
            this.lblSupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplies.ForeColor = System.Drawing.Color.White;
            this.lblSupplies.Location = new System.Drawing.Point(4, 32);
            this.lblSupplies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplies.Name = "lblSupplies";
            this.lblSupplies.Size = new System.Drawing.Size(678, 61);
            this.lblSupplies.TabIndex = 0;
            this.lblSupplies.Text = "Request Cleaning Supplies ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(20, 929);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(141, 41);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbIngredientsOrder
            // 
            this.gbIngredientsOrder.Controls.Add(this.button1);
            this.gbIngredientsOrder.Controls.Add(this.btnClear);
            this.gbIngredientsOrder.Controls.Add(this.lbIngredientsOrder);
            this.gbIngredientsOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngredientsOrder.Location = new System.Drawing.Point(20, 522);
            this.gbIngredientsOrder.Margin = new System.Windows.Forms.Padding(4);
            this.gbIngredientsOrder.Name = "gbIngredientsOrder";
            this.gbIngredientsOrder.Padding = new System.Windows.Forms.Padding(4);
            this.gbIngredientsOrder.Size = new System.Drawing.Size(1299, 399);
            this.gbIngredientsOrder.TabIndex = 36;
            this.gbIngredientsOrder.TabStop = false;
            this.gbIngredientsOrder.Text = "Ingredients Order";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remove Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(8, 39);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 41);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbIngredientsOrder
            // 
            this.lbIngredientsOrder.FormattingEnabled = true;
            this.lbIngredientsOrder.ItemHeight = 25;
            this.lbIngredientsOrder.Location = new System.Drawing.Point(8, 88);
            this.lbIngredientsOrder.Margin = new System.Windows.Forms.Padding(4);
            this.lbIngredientsOrder.Name = "lbIngredientsOrder";
            this.lbIngredientsOrder.Size = new System.Drawing.Size(1283, 279);
            this.lbIngredientsOrder.TabIndex = 6;
            // 
            // gbAvailableIngredients
            // 
            this.gbAvailableIngredients.Controls.Add(this.btnViewAll);
            this.gbAvailableIngredients.Controls.Add(this.cbCategories);
            this.gbAvailableIngredients.Controls.Add(this.label4);
            this.gbAvailableIngredients.Controls.Add(this.btnAdd);
            this.gbAvailableIngredients.Controls.Add(this.numQty);
            this.gbAvailableIngredients.Controls.Add(this.lbAvailableIngredients);
            this.gbAvailableIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAvailableIngredients.Location = new System.Drawing.Point(20, 115);
            this.gbAvailableIngredients.Margin = new System.Windows.Forms.Padding(4);
            this.gbAvailableIngredients.Name = "gbAvailableIngredients";
            this.gbAvailableIngredients.Padding = new System.Windows.Forms.Padding(4);
            this.gbAvailableIngredients.Size = new System.Drawing.Size(1299, 399);
            this.gbAvailableIngredients.TabIndex = 35;
            this.gbAvailableIngredients.TabStop = false;
            this.gbAvailableIngredients.Text = "Available Ingredients";
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnViewAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(329, 33);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(115, 39);
            this.btnViewAll.TabIndex = 13;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
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
            this.cbCategories.Location = new System.Drawing.Point(8, 37);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(313, 33);
            this.cbCategories.TabIndex = 13;
            this.cbCategories.Text = "Please Select a Category";
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
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
            this.btnAdd.Location = new System.Drawing.Point(687, 33);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add to Order";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(587, 40);
            this.numQty.Margin = new System.Windows.Forms.Padding(4);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(72, 30);
            this.numQty.TabIndex = 12;
            // 
            // lbAvailableIngredients
            // 
            this.lbAvailableIngredients.FormattingEnabled = true;
            this.lbAvailableIngredients.ItemHeight = 25;
            this.lbAvailableIngredients.Location = new System.Drawing.Point(8, 81);
            this.lbAvailableIngredients.Margin = new System.Windows.Forms.Padding(4);
            this.lbAvailableIngredients.Name = "lbAvailableIngredients";
            this.lbAvailableIngredients.Size = new System.Drawing.Size(1283, 304);
            this.lbAvailableIngredients.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(169, 929);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 41);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // formRequestCleaningSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1322, 1002);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbIngredientsOrder);
            this.Controls.Add(this.gbAvailableIngredients);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formRequestCleaningSupplies";
            this.Text = "formRequestCleaningSupplies";
            this.Load += new System.EventHandler(this.formRequestCleaningSupplies_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbIngredientsOrder.ResumeLayout(false);
            this.gbAvailableIngredients.ResumeLayout(false);
            this.gbAvailableIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSupplies;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbIngredientsOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbIngredientsOrder;
        private System.Windows.Forms.GroupBox gbAvailableIngredients;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.ListBox lbAvailableIngredients;
        private System.Windows.Forms.Button btnBack;
    }
}