using System;
using BusinessLayer;
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
    public partial class formViewSales : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formViewSales(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formViewSales_Load(object sender, EventArgs e)
        {
            Model.GetAllOrders();
            Model.GetAllOrderItems();
            List<double> SalesTotal = new List<double>();
            List<double> SalesTodayBar = new List<double>();
            List<double> SalesTodayRest = new List<double>();

            foreach (Orders order in Model.OrdersList)
            {
                double foodPrice = order.FoodPrice;
                SalesTodayRest.Add(foodPrice);
                double TodayRestaurant = SalesTodayRest.Sum();
                txtTodayRest.Text = TodayRestaurant.ToString();

                double drinkPrice = order.DrinkPrice;
                SalesTodayBar.Add(drinkPrice);
                double TodayBar = SalesTodayBar.Sum();
                txtTodayBar.Text = TodayBar.ToString();

                double totalToday = TodayRestaurant + TodayBar;
                txtTodayS.Text = totalToday.ToString();

            }
        }
    }
}
