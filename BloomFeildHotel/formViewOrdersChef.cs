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
    public partial class formViewOrdersChef : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formViewOrdersChef(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void formViewOrdersChef_Load(object sender, EventArgs e)
        {
            listBoxOrders.Items.Clear();
            Model.GetAllOrderDrinks();
            Model.GetAllOrderMeals();
            Model.GetAllMeals();
            Model.GetAllDrinks();
            Model.GetAllBistroOrders();
            foreach(IBistroOrders orders in Model.BistroOrdersList)
            {
                foreach (IOrder_has_Meals mealorders in Model.OrderMealsList)
                {
                   if(orders.OrderID == mealorders.OrderID)
                    {
                        foreach (IMeals meal in Model.MealsList)
                        {
                            if(mealorders.DishID == meal.DishID)
                            {
                                listBoxOrders.Items.Add(string.Format("{0} | {1} | {2} | {3}", meal.DishName, mealorders.Quantity, mealorders.Status, orders.OrderTotal));
                            }
                        }
                    }

                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formChef form = new formChef(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChangeOrderStatus_Click(object sender, EventArgs e)
        {
            formManageOrder form = new formManageOrder(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
