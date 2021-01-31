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
            lbOrders.Items.Clear();
            Model.GetAllMeals();
            Model.GetAllDrinks();
            Model.GetAllBistroOrders();
            Model.GetAllOrderDrinks();
            Model.GetAllOrderMeals();
            foreach (IBistroOrders orders in Model.BistroOrdersList)
            {
                foreach (IOrder_has_Meals mealorders in Model.OrderMealsList)
                {
                    if (orders.OrderID == mealorders.OrderID)
                    {
                        foreach (IMeals meal in Model.MealsList)
                        {
                            if (mealorders.DishID == meal.DishID)
                            {
                                lbOrders.Items.Add(string.Format("{0} | Quantity: {1} | Order Time: {2} | Status: {3}", meal.DishName, mealorders.Quantity, orders.OrderDate, mealorders.Status));
                            }
                        }
                    }

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formViewOrdersChef form = new formViewOrdersChef(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            foreach (IBistroOrders orders in Model.BistroOrdersList)
            {
                foreach (IOrder_has_Meals mealorders in Model.OrderMealsList)
                {
                    if (orders.OrderID == mealorders.OrderID)
                    {
                        foreach (IMeals meal in Model.MealsList)
                        {

                            string std = string.Format("{0} | Quantity: {1} | Order Time: {2} | Status: {3}", meal.DishName, mealorders.Quantity, orders.OrderDate, mealorders.Status);
                            if (lbOrders.SelectedIndex == -1)
                            {
                                MessageBox.Show("Please select an item to change Status!");
                            }
                            else if (lbOrders.SelectedItem.ToString() == std)
                            {
                                mealorders.Status = Convert.ToString(txtStatus.Text);
                                Model.editOrderMeal(mealorders);

                            }

                        }
                    }
                }
            }
            formChangeOrderStatus form = new formChangeOrderStatus(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();

        }

        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOrders.SelectedIndex != -1)
            {
                foreach (IBistroOrders orders in Model.BistroOrdersList)
                {
                    foreach (IOrder_has_Meals mealorders in Model.OrderMealsList)
                    {
                        if (orders.OrderID == mealorders.OrderID)
                        {
                            foreach (IMeals meal in Model.MealsList)
                            {
                                if (mealorders.DishID == meal.DishID)
                                {
                                    string std = string.Format("{0} | Quantity: {1} | Order Time: {2} | Status: {3}", meal.DishName, mealorders.Quantity, orders.OrderDate, mealorders.Status);
                                    if (lbOrders.SelectedItem.ToString() == std)
                                    {
                                        txtStatus.Text = mealorders.Status;

                                    }
                                }
                            }
                        }

                    }
                }
            }
        }
    }
}
