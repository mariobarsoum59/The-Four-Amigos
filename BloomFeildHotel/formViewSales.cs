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
            //List<double> SalesTotal = new List<double>();
            List<double> SalesTotalBar = new List<double>();
            List<double> SalesTotalRest = new List<double>();
            List<double> SalesTodayBar = new List<double>();
            List<double> SalesTodayRest = new List<double>();
            DateTime today = DateTime.Today;

            foreach (Orders order in Model.OrdersList)
            {

                if (order.Completed == true)
                {
                    double foodPrice = order.FoodPrice;
                    SalesTodayRest.Add(foodPrice);
                    SalesTotalRest.Add(foodPrice);
                    double drinkPrice = order.DrinkPrice;
                    SalesTodayBar.Add(drinkPrice);
                    SalesTotalBar.Add(drinkPrice);

                    if (order.Timestamp.Date == today)
                    {
                        double TodayRestaurant = SalesTodayRest.Sum();
                        txtTodayRest.Text = TodayRestaurant.ToString();

                        double TodayBar = SalesTodayBar.Sum();
                        txtTodayBar.Text = TodayBar.ToString();

                        double totalToday = TodayRestaurant + TodayBar;
                        txtTodayS.Text = totalToday.ToString();
                    }
                    if(order.Timestamp.Date != today)
                    { 
                        double totalBar = SalesTotalBar.Sum();
                        txtAllBar.Text = totalBar.ToString();

                        double totalRest = SalesTotalRest.Sum();
                        txtAllRest.Text = totalRest.ToString();

                        double allSale = totalBar + totalRest;
                        txtAllSale.Text = allSale.ToString();
                    }
                }

            }
        }
    }
}
