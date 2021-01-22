namespace BloomFeildHotel
{
    partial class formSaleTest
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
            this.lbMeals = new System.Windows.Forms.ListBox();
            this.lbDrinks = new System.Windows.Forms.ListBox();
            this.lbSale = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sale = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMeals
            // 
            this.lbMeals.FormattingEnabled = true;
            this.lbMeals.Location = new System.Drawing.Point(58, 64);
            this.lbMeals.Name = "lbMeals";
            this.lbMeals.Size = new System.Drawing.Size(194, 160);
            this.lbMeals.TabIndex = 0;
            // 
            // lbDrinks
            // 
            this.lbDrinks.FormattingEnabled = true;
            this.lbDrinks.Location = new System.Drawing.Point(58, 257);
            this.lbDrinks.Name = "lbDrinks";
            this.lbDrinks.Size = new System.Drawing.Size(194, 173);
            this.lbDrinks.TabIndex = 1;
            // 
            // lbSale
            // 
            this.lbSale.FormattingEnabled = true;
            this.lbSale.Location = new System.Drawing.Point(375, 34);
            this.lbSale.Name = "lbSale";
            this.lbSale.Size = new System.Drawing.Size(324, 329);
            this.lbSale.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drinks";
            // 
            // Sale
            // 
            this.Sale.AutoSize = true;
            this.Sale.Location = new System.Drawing.Point(521, 18);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(28, 13);
            this.Sale.TabIndex = 5;
            this.Sale.Text = "Sale";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(501, 391);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(75, 23);
            this.btnCreateOrder.TabIndex = 6;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(273, 133);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 7;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(273, 316);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(75, 23);
            this.btnAddDrink.TabIndex = 8;
            this.btnAddDrink.Text = "Add Drink";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // formSaleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddDrink);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.Sale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSale);
            this.Controls.Add(this.lbDrinks);
            this.Controls.Add(this.lbMeals);
            this.Name = "formSaleTest";
            this.Text = "formSaleTest";
            this.Load += new System.EventHandler(this.formSaleTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMeals;
        private System.Windows.Forms.ListBox lbDrinks;
        private System.Windows.Forms.ListBox lbSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Sale;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnAddDrink;
    }
}