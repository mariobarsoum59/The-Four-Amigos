using System;
using BusinessEntities;
using BusinessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BloomFeildHotel
{
    public partial class formAddWaste : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formAddWaste(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool correctMeal = false ;
            string dishName = txtDishName.Text;
            string wasted = txtAmtWasted.Text;

            foreach (Meals meal in Model.MealsList)
            {

                if (meal.DishName == dishName && (!String.IsNullOrEmpty(txtAmtWasted.Text)))
                {
                        correctMeal = true;
                        int numWasted = Convert.ToInt32(wasted);
                        int id = 0;
                        double price = meal.Price;
                        int quantity = meal.Quantity;
                        int loss = numWasted;

                    if (quantity < numWasted)
                    {
                        MessageBox.Show("Error. Amount is larger than prepared meal");
                    }
                    else

                    {
                        double monetaryLoss = loss * price;
                        txtMoneyLoss.Text = monetaryLoss.ToString();


                        if (Model.addWaste(id, dishName, numWasted, monetaryLoss, DateTime.Now))
                        {
                            MessageBox.Show("Meal Added");
                        }
                        else
                        {
                            MessageBox.Show("Error adding meal");
                        }
                    }
                }
                

            }
            if (correctMeal ==false)
            {
                MessageBox.Show("Incorrect meal or amount\n Please ensure you have entered the meal correctly");
            }
        }

        

        private void formAddWaste_Load(object sender, EventArgs e)
        {
            Model.GetAllMeals();
            Model.GetAllWaste();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
