using BusinessLayer;
using System;
using BusinessEntities;
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
    public partial class formManageOrder : Form
    {
        private FormContainer fc;
        private IModel Model;
        private IBistroOrders Order;
        public formManageOrder(FormContainer parent, IModel Model, IBistroOrders Order)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            this.Order = Order;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void formManageOrder_Load(object sender, EventArgs e)
        {
            decimal total = 0.0m;
            lbDrinks.Items.Clear();
            Model.GetAllDrinks();
            foreach (IDrinks drink in Model.DrinksList)
            {
                lbDrinks.Items.Add(string.Format("{0} | €{1}", drink.DrinkName, drink.DrinkPrice));
            }

            lbMeals.Items.Clear();
            Model.GetAllMeals();
            foreach (IMeals meal in Model.MealsList)
            {
                lbMeals.Items.Add(string.Format("{0} | €{1}", meal.DishName, meal.Price));
            }
            tbOrderID.Text = Order.OrderID.ToString();
            if(Order.OrderCompleted)
            {
                rbYes.Checked = true;
            }
            else
            {
                rbNo.Checked = true;
            }
            Model.GetAllOrderDrinks();
            Model.GetAllOrderMeals();
            foreach(IOrder_has_Drinks oDrinks in Model.OrderDrinksList)
            {
                if(Order.OrderID == oDrinks.OrderID)
                {
                    foreach (IDrinks drink in Model.DrinksList)
                    {
                        if(oDrinks.DrinkID == drink.DrinkID)
                        {
                            for (int i = 0; i < oDrinks.Quantity; i++)
                            {
                                lbOrderItems.Items.Add(string.Format("{0} | €{1}", drink.DrinkName, drink.DrinkPrice));
                                total += drink.DrinkPrice;
                            }
                        }
                    }
                }
            }
            foreach(IOrder_has_Meals oMeals in Model.OrderMealsList)
            {
                if(Order.OrderID == oMeals.OrderID)
                {
                    foreach (IMeals meal in Model.MealsList)
                    {
                        if(oMeals.DishID == meal.DishID)
                        {
                            for(int i = 0; i < oMeals.Quantity; i++)
                            {
                                lbOrderItems.Items.Add(string.Format("{0} | €{1}", meal.DishName, meal.Price));
                                total += Convert.ToDecimal(meal.Price);
                            }
                        }
                    }
                }
            }
            if(total == Order.OrderTotal)
            {
                tbTotal.Text = Order.OrderTotal.ToString();
            }
            else
            {
                tbTotal.Text = total.ToString();
                Order.OrderTotal = total;
                MessageBox.Show("There was an error with the stored total, a new total has been calculated");
            }
        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbOrderStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbOrderItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to remove");
            }
            else
            {
                Model.GetAllMeals();
                Model.GetAllDrinks();
                foreach(IMeals meal in Model.MealsList)
                {
                    String std = string.Format("{0} | €{1}", meal.DishName, meal.Price);
                    if(std == lbOrderItems.SelectedItem.ToString())
                    {
                        Order.OrderTotal -= Convert.ToDecimal(meal.Price);
                    }
                }
                foreach(IDrinks drink in Model.DrinksList)
                {
                    String std = string.Format("{0} | €{1}", drink.DrinkName, drink.DrinkPrice);
                    if(std == lbOrderItems.SelectedItem.ToString())
                    {
                        Order.OrderTotal -= drink.DrinkPrice;
                    }
                }
                tbTotal.Text = Order.OrderTotal.ToString();
                lbOrderItems.Items.Remove(lbOrderItems.SelectedItem);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbOrderItems.Items.Clear();
            Order.OrderTotal = 0.0m;
            tbTotal.Text = Order.OrderTotal.ToString();
        }

        private void btnMealSearch_Click(object sender, EventArgs e)
        {
            if (txtMealSearch.Text == "")
            {
                MessageBox.Show("Please enter an item to search for!");
            }
            else
            {
                lbMeals.Items.Clear();
                Model.GetAllMeals();
                foreach (IMeals meal in Model.MealsList)
                {
                    if (meal.DishName.Equals(txtMealSearch.Text))
                    {
                        lbMeals.Items.Add(string.Format("{0} | €{1}", meal.DishName, meal.Price));
                    }
                }
            }
        }

        private void btnViewAllMeals_Click(object sender, EventArgs e)
        {
            lbMeals.Items.Clear();
            Model.GetAllMeals();
            foreach (IMeals meal in Model.MealsList)
            {
                lbMeals.Items.Add(string.Format("{0} | €{1}", meal.DishName, meal.Price));
            }
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            if(lbMeals.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter an item to add!");
            }
            else
            {
                Model.GetAllMeals();
                foreach(IMeals meal in Model.MealsList)
                {
                    String std = string.Format("{0} | €{1}", meal.DishName, meal.Price);
                    if(std == lbMeals.SelectedItem.ToString())
                    {
                        Order.OrderTotal += Convert.ToDecimal(meal.Price);
                    }
                }
                tbTotal.Text = Order.OrderTotal.ToString();
                lbOrderItems.Items.Add(lbMeals.SelectedItem.ToString());
            }
        }

        private void btnDrinkSearch_Click(object sender, EventArgs e)
        {
            if (txtDrinkSearch.Text == "")
            {
                MessageBox.Show("Please enter an item to search for!");
            }
            else
            {
                lbDrinks.Items.Clear();
                Model.GetAllDrinks();
                foreach (IDrinks drink in Model.DrinksList)
                {
                    if (drink.DrinkName.Equals(txtDrinkSearch.Text))
                    {
                        lbDrinks.Items.Add(string.Format("{0} | €{1}", drink.DrinkName, drink.DrinkPrice));
                    }
                }
            }
        }

        private void btnViewAllDrinks_Click(object sender, EventArgs e)
        {
            lbDrinks.Items.Clear();
            Model.GetAllDrinks();
            foreach (IDrinks drink in Model.DrinksList)
            {
                lbDrinks.Items.Add(string.Format("{0} | €{1}", drink.DrinkName, drink.DrinkPrice));
            }
        }

        private void formManageOrder_Load_1(object sender, EventArgs e)
        {
            decimal total = 0.0m;
            lbDrinks.Items.Clear();
            Model.GetAllDrinks();
            foreach (IDrinks drink in Model.DrinksList)
            {
                lbDrinks.Items.Add(string.Format("{0} | €{1}", drink.DrinkName, drink.DrinkPrice));
            }

            lbMeals.Items.Clear();
            Model.GetAllMeals();
            foreach (IMeals meal in Model.MealsList)
            {
                lbMeals.Items.Add(string.Format("{0} | €{1}", meal.DishName, meal.Price));
            }
            tbOrderID.Text = Order.OrderID.ToString();
            if (Order.OrderCompleted)
            {
                rbYes.Checked = true;
            }
            else
            {
                rbNo.Checked = true;
            }
            Model.GetAllOrderDrinks();
            Model.GetAllOrderMeals();
            foreach (IOrder_has_Drinks oDrinks in Model.OrderDrinksList)
            {
                if (Order.OrderID == oDrinks.OrderID)
                {
                    foreach (IDrinks drink in Model.DrinksList)
                    {
                        if (oDrinks.DrinkID == drink.DrinkID)
                        {
                            for (int i = 0; i < oDrinks.Quantity; i++)
                            {
                                lbOrderItems.Items.Add(string.Format("{0} | €{1}", drink.DrinkName, drink.DrinkPrice));
                                total += drink.DrinkPrice;
                            }
                        }
                    }
                }
            }
            foreach (IOrder_has_Meals oMeals in Model.OrderMealsList)
            {
                if (Order.OrderID == oMeals.OrderID)
                {
                    foreach (IMeals meal in Model.MealsList)
                    {
                        if (oMeals.DishID == meal.DishID)
                        {
                            for (int i = 0; i < oMeals.Quantity; i++)
                            {
                                lbOrderItems.Items.Add(string.Format("{0} | €{1}", meal.DishName, meal.Price));
                                total += Convert.ToDecimal(meal.Price);
                            }
                        }
                    }
                }
            }
            if (total == Order.OrderTotal)
            {
                tbTotal.Text = Order.OrderTotal.ToString();
            }
            else
            {
                tbTotal.Text = total.ToString();
                Order.OrderTotal = total;
                MessageBox.Show("There was an error with the stored total, a new total has been calculated");
            }
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            if (lbDrinks.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter an item to add!");
            }
            else
            {
                Model.GetAllDrinks();
                foreach(IDrinks drink in Model.DrinksList)
                {
                    String std = string.Format("{0} | €{1}", drink.DrinkName, drink.DrinkPrice);
                    if(std == lbDrinks.SelectedItem.ToString())
                    {
                        Order.OrderTotal += drink.DrinkPrice;
                    }
                }
                tbTotal.Text = Order.OrderTotal.ToString();
                lbOrderItems.Items.Add(lbDrinks.SelectedItem.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Model.GetAllBistroOrders();
            Model.GetAllOrderDrinks();
            Model.GetAllOrderMeals();
            foreach(IBistroOrders bOrder in Model.BistroOrdersList)
            {
                if(bOrder.OrderID == Order.OrderID)
                {
                    foreach(IOrder_has_Drinks oDrink in Model.OrderDrinksList)
                    {
                        if(oDrink.OrderID == bOrder.OrderID)
                        {
                            if(!Model.deleteOrderDrink(oDrink))
                            {
                                MessageBox.Show("Error deleting drink from order");
                            }
                        }
                    }
                    foreach(IOrder_has_Meals oMeal in Model.OrderMealsList)
                    {
                        if(oMeal.OrderID == bOrder.OrderID)
                        {
                            if(!Model.deleteOrderMeal(oMeal))
                            {
                                MessageBox.Show("Error deleting meal from order");
                            }
                        }
                    }
                    if(Model.deleteBistroOrder(bOrder))
                    {
                        MessageBox.Show("The order has been deleted, please press the back button");
                        lbOrderItems.Items.Clear();
                        tbOrderID.Text = "";
                        tbTotal.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error deleting order");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Model.GetAllBistroOrders();
            Model.GetAllOrderDrinks();
            Model.GetAllOrderMeals();
            foreach (IBistroOrders bOrder in Model.BistroOrdersList)
            {
                if (bOrder.OrderID == Order.OrderID)
                {
                    foreach (IOrder_has_Drinks oDrink in Model.OrderDrinksList)
                    {
                        if (oDrink.OrderID == bOrder.OrderID)
                        {
                            Model.deleteOrderDrink(oDrink);
                        }
                    }
                    foreach (IOrder_has_Meals oMeal in Model.OrderMealsList)
                    {
                        if (oMeal.OrderID == bOrder.OrderID)
                        {
                            Model.deleteOrderMeal(oMeal);
                        }
                    }
                }
            }
            Order.OrderNote = tbNotes.Text;
            Order.OrderDate = DateTime.Now;
            Order.OrderMadeBy = Model.CurrentUser.UserID;
            if(rbYes.Checked)
            {
                Order.OrderCompleted = true;
            }
            else
            {
                Order.OrderCompleted = false;
            }
            List<String> items = lbOrderItems.Items.Cast<String>().ToList();
            List<IOrder_has_Drinks> orderDrinks = new List<IOrder_has_Drinks>();
            List<IOrder_has_Meals> orderMeals = new List<IOrder_has_Meals>();
            bool drinkFound = false;
            bool mealFound = false;
            foreach (String item in items)
            {
                foreach (IMeals meal in Model.MealsList)
                {
                    String std = string.Format("{0} | €{1}", meal.DishName, meal.Price);
                    if (item.Equals(std))
                    {
                        foreach (IOrder_has_Meals orderMeal in orderMeals)
                        {
                            if (orderMeal.DishID == meal.DishID)
                            {
                                mealFound = true;
                                orderMeal.Quantity = orderMeal.Quantity + 1;
                            }
                        }
                        if (!mealFound)
                        {
                            IOrder_has_Meals newOrderMeal = new Order_has_Meals(Order.OrderID, meal.DishID, 1, "Not Ready");
                            orderMeals.Add(newOrderMeal);
                        }
                        mealFound = false;
                    }
                }
                foreach (IDrinks drink in Model.DrinksList)
                {
                    String std = string.Format("{0} | €{1}", drink.DrinkName, drink.DrinkPrice);
                    if (item.Equals(std))
                    {
                        foreach (IOrder_has_Drinks orderDrink in orderDrinks)
                        {
                            if (orderDrink.DrinkID == drink.DrinkID)
                            {
                                drinkFound = true;
                                orderDrink.Quantity = orderDrink.Quantity + 1;
                            }
                        }
                        if (!drinkFound)
                        {
                            IOrder_has_Drinks newOrderDrink = new Order_has_Drinks(Order.OrderID, drink.DrinkID, 1, "Not Ready");
                            orderDrinks.Add(newOrderDrink);
                        }
                        drinkFound = false;
                    }
                }
            }

            if(Model.editBistroOrder(Order))
            {
                foreach(IOrder_has_Drinks oDrink in orderDrinks)
                {
                    Model.createOrderDrink(oDrink.OrderID, oDrink.DrinkID, oDrink.Quantity, "Not Ready");
                }
                foreach(IOrder_has_Meals oMeal in orderMeals)
                {
                    Model.createOrderMeal(oMeal.OrderID, oMeal.DishID, oMeal.Quantity, "Not Ready");
                }
                MessageBox.Show("Order has been updated");
            }
            else
            {
                MessageBox.Show("Error updating the order");
            }
        }

        private void tbNotes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
