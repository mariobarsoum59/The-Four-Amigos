using BusinessEntities;
using BusinessLayer;
using System;
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
    public partial class formViewReceipt : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formViewReceipt(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ViewOrdersBarStaff form = new ViewOrdersBarStaff(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void formViewReceipt_Load(object sender, EventArgs e)
        {
            listBoxOrders.Items.Clear();
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
                                listBoxOrders.Items.Add(string.Format("Order ID: {0} | {1} | Quantity: {2} | Price: €{3}", orders.OrderID ,meal.DishName, mealorders.Quantity, meal.Price));
                                }
                            }
                        }

                    }

                    foreach (IOrder_has_Drinks drinkorders in Model.OrderDrinksList)
                    {
                        if (orders.OrderID == drinkorders.OrderID)
                        {
                            foreach (IDrinks drink in Model.DrinksList)
                            {
                                if (drinkorders.DrinkID == drink.DrinkID)
                                {
                                listBoxOrders.Items.Add(string.Format("Order ID: {0} | {1} | Quantity: {2} | Price: €{3}", orders.OrderID, drink.DrinkName, drinkorders.Quantity, drink.DrinkPrice));
                                }
                            }

                        }

                    }
            }
        }

       

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOrders.SelectedIndex != -1)
            {
                foreach (IBistroOrders orders in Model.BistroOrdersList)
                {
                    foreach (IOrder_has_Meals mealorders in Model.OrderMealsList)
                    {
                        foreach (IMeals meal in Model.MealsList)
                        {
                            if (mealorders.DishID == meal.DishID)
                            {
                                string std = string.Format("Order ID: {0} | {1} | Quantity: {2} | Price: €{3}", orders.OrderID, meal.DishName, mealorders.Quantity, meal.Price);
                                if (listBoxOrders.SelectedItem.ToString() == std)
                                {
                                    listBoxSubtotal.Items.Add(string.Format("Order ID: {0} | SubTotal: €{1}", orders.OrderID, orders.OrderTotal));

                                }
                            }
                        }

                    }
                

               
                    foreach (IOrder_has_Drinks drinkorders in Model.OrderDrinksList)
                    {
                        foreach (IDrinks drink in Model.DrinksList)
                        {
                            if (drinkorders.DrinkID == drink.DrinkID)
                            {
                                string std = string.Format("Order ID: {0} | {1} | Quantity: {2} | Price: €{3}", orders.OrderID, drink.DrinkName, drinkorders.Quantity, drink.DrinkPrice);
                                if (listBoxOrders.SelectedItem.ToString() == std)
                                {
                                    listBoxSubtotal.Items.Add(string.Format("Order ID: {0} | SubTotal: €{1}", orders.OrderID, orders.OrderTotal));

                                }
                            }
                        }

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxSubtotal.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCashOrCard form = new FormCashOrCard(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }
    }
}
