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
    public partial class formSales : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formSales(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }


        private void formSales_Load(object sender, EventArgs e)
        {
            Model.GetAllBistroOrders();
            Model.GetAllDrinks();
            Model.GetAllMeals();
            foreach (IDrinks drink in Model.DrinksList)
            {
                listBox4.Items.Add(string.Format("{0} | €{1} ", drink.DrinkName, drink.DrinkPrice));
                
            }
            foreach (IDrinks drink in Model.DrinksList)
            {
                if(drink.DrinkName == "Pint of Guinness")
                    listBox1.Items.Add(string.Format("{0}", drink.DrinkName));
            }
            foreach (IMeals meal in Model.MealsList)
            {
                listBox5.Items.Add(string.Format("{0} | €{1} ", meal.DishName, meal.Price));

            }
            foreach (IMeals meal in Model.MealsList)
            {
                if (meal.DishName == "Fish and Chips")
                    listBox2.Items.Add(string.Format("{0}", meal.DishName));
            }

            foreach (IBistroOrders orders in Model.BistroOrdersList)
            {

               listBox3.Items.Add(string.Format("Order ID: {0} | Order Date: {1} | Order Total: €{2} | Order Made By User ID: {3} | Order Note: {4} | OrderCompleted: {5}", orders.OrderID, orders.OrderDate, orders.OrderTotal, orders.OrderMadeBy, orders.OrderNote, orders.OrderCompleted));

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formBarStaff form = new formBarStaff(fc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {

            /*foreach (IBistroOrders orders in Model.BistroOrdersList)
            {
                foreach (IMeals meal in Model.MealsList)
                {
                    string std = string.Format("{0}", meal.DishName);
                    if (listBox2.SelectedItem.ToString() == std)
                    {
                        decimal num = 10;
                        orders.OrderDate = DateTime.Now;
                        orders.OrderTotal = num;
                        orders.OrderMadeBy = Model.CurrentUser.UserID;
                        orders.OrderCompleted = false;
                        Model.editBistroOrder(orders);
                    }
                }
            }

           
            MessageBox.Show("Sale Made");*/

            DateTime date = DateTime.Now;
            decimal total = 0.0m;
            int madeBy = Model.CurrentUser.UserID;

            List<String> names = listBox3.Items.Cast<String>().ToList();
            List<IOrder_has_Drinks> orderDrinks = new List<IOrder_has_Drinks>();
            List<IOrder_has_Meals> orderMeals = new List<IOrder_has_Meals>();
            Model.GetAllDrinks();
            Model.GetAllMeals();
            bool drinkFound = false;
            bool mealFound = false;
            foreach(String name in names)
            {
                foreach(IMeals meal in Model.MealsList)
                {
                    if(name.Equals(meal.DishName))
                    {
                        total += Convert.ToDecimal(meal.Price);
                        foreach(IOrder_has_Meals orderMeal in orderMeals)
                        {
                            if(orderMeal.DishID == meal.DishID)
                            {
                                mealFound = true;
                                orderMeal.Quantity++;
                            }
                        }
                        if(!mealFound)
                        {
                            IOrder_has_Meals newOrderMeal = new Order_has_Meals(0, meal.DishID, 1, "Not Ready");
                        }
                        mealFound = false;
                    }
                }
                foreach(IDrinks drink in Model.DrinksList)
                {
                    if(name.Equals(drink.DrinkName))
                    {
                        total += drink.DrinkPrice;
                        foreach(IOrder_has_Drinks orderDrink in orderDrinks)
                        {
                            if(orderDrink.DrinkID == drink.DrinkID)
                            {
                                drinkFound = true;
                                orderDrink.Quantity++;
                            }
                        }
                        if(!drinkFound)
                        {
                            IOrder_has_Drinks newOrderDrink = new Order_has_Drinks(0, drink.DrinkID, 1, "Not Ready");
                            orderDrinks.Add(newOrderDrink);
                        }
                        drinkFound = false;
                    }
                }
            }
            Model.GetAllBistroOrders();
            List<IBistroOrders> oldOrders = Model.BistroOrdersList;
            if(Model.createBistroOrder(date, total, madeBy, "", false))
            {
                Model.GetAllBistroOrders();
                foreach(IBistroOrders order in Model.BistroOrdersList)
                {
                    if(!oldOrders.Contains(order))
                    {
                        foreach(IOrder_has_Drinks orderDrink in orderDrinks)
                        {
                            orderDrink.OrderID = order.OrderID;
                            Model.createOrderDrink(orderDrink.OrderID, orderDrink.DrinkID, orderDrink.Quantity, orderDrink.Status);
                        }
                        foreach(IOrder_has_Meals orderMeal in orderMeals)
                        {
                            orderMeal.OrderID = order.OrderID;
                            Model.createOrderMeal(orderMeal.OrderID, orderMeal.DishID, orderMeal.Quantity, orderMeal.Status);
                        }
                    }
                }
                MessageBox.Show("The sale has been made");
            }
            else
            {
                MessageBox.Show("Sale was unsuccessful");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void viewOrdersBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
