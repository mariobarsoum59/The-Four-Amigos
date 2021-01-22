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
            
            foreach (IBistroOrders orders in Model.BistroOrdersList)
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

           
            MessageBox.Show("Sale Made");
        }
    }
}
