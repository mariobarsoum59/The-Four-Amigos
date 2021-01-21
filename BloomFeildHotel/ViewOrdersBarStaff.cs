using BloomFeildHotel.Properties;
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
    public partial class ViewOrdersBarStaff : Form
    {
        private FormContainer fc;
        private IModel Model;
        public ViewOrdersBarStaff(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void lblAddDrink_Click(object sender, EventArgs e)
        {

        }

        private void ViewOrdersBarStaff_Load(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            Model.GetAllMeals();
            Model.GetAllDrinks();
            Model.GetAllBistroOrders();
            Model.GetAllOrderDrinks();
            Model.GetAllOrderMeals();
            foreach (IBistroOrders orders in Model.BistroOrdersList)
            {
                if (orders.OrderCompleted == false)
                {
                    foreach (IOrder_has_Meals mealorders in Model.OrderMealsList)
                    {
                        if (orders.OrderID == mealorders.OrderID)
                        {
                            foreach (IMeals meal in Model.MealsList)
                            {
                                if (mealorders.DishID == meal.DishID)
                                {
                                    listBox3.Items.Add(string.Format("{0} | Quantity: {1} | Price: €{2} | Status: {3}", meal.DishName, mealorders.Quantity, meal.Price, mealorders.Status));
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
                                    listBox3.Items.Add(string.Format("{0} | Quantity: {1} | Price: €{2} | Status: {3}", drink.DrinkName, drinkorders.Quantity, drink.DrinkPrice, drinkorders.Status));
                                }
                            }

                        }

                    }
                }
                if (orders.OrderCompleted == true)
                {
                    foreach (IOrder_has_Meals mealorders in Model.OrderMealsList)
                    {
                        if (orders.OrderID == mealorders.OrderID)
                        {
                            foreach (IMeals meal in Model.MealsList)
                            {
                                if (mealorders.DishID == meal.DishID)
                                {
                                    listBox1.Items.Add(string.Format("{0} | Quantity: {1} | Price: €{2} | Status: {3}", meal.DishName, mealorders.Quantity, meal.Price, mealorders.Status));
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
                                    listBox1.Items.Add(string.Format("{0} | Quantity: {1} | Price: €{2} | Status: {3}", drink.DrinkName, drinkorders.Quantity, drink.DrinkPrice, drinkorders.Status));
                                }
                            }

                        }

                    }
                }
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            string selectedItemText;
            selectedItemText = listBox3.SelectedItem.ToString();
            listBox1.Items.Add(selectedItemText);

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
                                    string std = string.Format("{0} | Quantity: {1} | Price: €{2} | Status: {3}", meal.DishName, mealorders.Quantity, meal.Price, mealorders.Status);
                                    if (listBox3.SelectedItem.ToString() == std)
                                    {
                                        orders.OrderCompleted = true;
                                        Model.editBistroOrder(orders);
                                    }
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
                                    string std = string.Format("{0} | Quantity: {1} | Price: €{2} | Status: {3}", drink.DrinkName, drinkorders.Quantity, drink.DrinkPrice, drinkorders.Status);
                                    if (listBox3.SelectedItem.ToString() == std)
                                    {
                                        orders.OrderCompleted = true;
                                        Model.editBistroOrder(orders);
                                    }
                                }
                            }

                        }

                    }
            }

            selectedItemText = listBox3.SelectedItem.ToString();
            listBox3.Items.Remove(selectedItemText);
            MessageBox.Show("Order Completed");

        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            formBarStaff form = new formBarStaff(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selectedItemText;
            selectedItemText = listBox1.SelectedItem.ToString();
            listBox3.Items.Add(selectedItemText);
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
                                    string std = string.Format("{0} | Quantity: {1} | Price: €{2} | Status: {3}", meal.DishName, mealorders.Quantity, meal.Price, mealorders.Status);
                                    if (listBox1.SelectedItem.ToString() == std)
                                    {
                                        orders.OrderCompleted = false;

                                        Model.editBistroOrder(orders);
                                    }
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
                                    string std = string.Format("{0} | Quantity: {1} | Price: €{2} | Status: {3}", drink.DrinkName, drinkorders.Quantity, drink.DrinkPrice, drinkorders.Status);
                                    if (listBox1.SelectedItem.ToString() == std)
                                    {
                                        orders.OrderCompleted = false;

                                        Model.editBistroOrder(orders);
                                    }
                                }
                            }

                        }

                    }
            }
            selectedItemText = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(selectedItemText);
            MessageBox.Show("Order Not Completed");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
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
                                    string std = string.Format("{0} | Quantity: {1} | Price: €{2} | Status: {3}", meal.DishName, mealorders.Quantity, meal.Price, mealorders.Status);
                                    if (listBox3.SelectedItem.ToString() == std)
                                    {
                                        textBoxNoteArea.Text = orders.OrderNote;

                                    }
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
                                    string std = string.Format("{0} | Quantity: {1} | Price: €{2} | Status: {3}", drink.DrinkName, drinkorders.Quantity, drink.DrinkPrice, drinkorders.Status);
                                    if (listBox3.SelectedItem.ToString() == std)
                                    {
                                        textBoxNoteArea.Text = orders.OrderNote;

                                    }
                                }
                            }

                        }

                    }
                }
            }
        }

        private void btnNote_Click(object sender, EventArgs e)
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
                                string std = string.Format("{0} | Quantity: {1} | Price: €{2} | Status: {3}", meal.DishName, mealorders.Quantity, meal.Price, mealorders.Status);
                                if (listBox3.SelectedItem.ToString() == std)
                                {
                                    orders.OrderNote = Convert.ToString(textBoxNoteArea.Text);
                                    Model.editBistroOrder(orders);

                                }
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
                                string std = string.Format("{0} | Quantity: {1} | Price: €{2} | Status: {3}", drink.DrinkName, drinkorders.Quantity, drink.DrinkPrice, drinkorders.Status);
                                if (listBox3.SelectedItem.ToString() == std)
                                {
                                    orders.OrderNote = Convert.ToString(textBoxNoteArea.Text);
                                    Model.editBistroOrder(orders);

                                }
                            }
                        }

                    }

                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            formManageOrder form = new formManageOrder(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }
    }
}
