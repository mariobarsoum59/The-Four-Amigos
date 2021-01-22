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



namespace BloomFeildHotel
{
    public partial class formChangeOrderStatus : Form
    {
        private FormContainer fc;
        private IModel Model;

        public formChangeOrderStatus(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void formChangeOrderStatus_Load(object sender, EventArgs e)
        {
            Model.GetAllOrderMeals();
            Model.GetAllMeals();


            foreach (Order_has_Meals orderMeal in Model.OrderMealsList)
            {  
                foreach (Meals meal in Model.MealsList)
                { 
                    if (orderMeal.DishID == meal.DishID)
                    {
                        lbOrders.Items.Add(meal.DishName);

                        
                    }
                }

            }

        }


        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
           




        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            foreach(IOrder_has_Meals orderMeal in Model.OrderMealsList)
            {
                foreach (IMeals meal in Model.MealsList)
                {
                    orderMeal.Status = Convert.ToString(txtStatus.Text);
                    Model.editOrderMeal(orderMeal);
                }
            }




        }
    }
}
