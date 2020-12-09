using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessEntities;

namespace BloomFeildHotel
{
    public partial class formCreateMonthlyReport : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formCreateMonthlyReport(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void formCreateMonthlyReport_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            DateTime beginning = date.AddDays(-30);
            Model.GetAllReservations();
            Model.GetAllOrders();
            Model.GetAllStockOrders();
            int reservations = 0;
            decimal reservationIncome = 0.0m;
            int sales = 0;
            decimal salesIncome = 0.0m;
            int stockOrders = 0;
            decimal stockExpenses = 0.0m;
            foreach(IReservation reservation in Model.ReservationsList)
            {
                if(reservation.CheckInDate <= date && reservation.CheckInDate >= beginning)
                {
                    reservations++;
                    reservationIncome += Convert.ToDecimal(reservation.ReservationPrice);
                }
            }
            foreach(IOrders order in Model.OrdersList)
            {
                if(order.Timestamp <= date && order.Timestamp >= beginning)
                {
                    sales++;
                    salesIncome += Convert.ToDecimal(order.DrinkPrice + order.FoodPrice);
                }
            }
            foreach(IStockOrder stockOrder in Model.StockOrdersList)
            {
                if(stockOrder.Date <= date && stockOrder.Date >= beginning)
                {
                    stockOrders++;
                    stockExpenses += stockOrder.Total;
                }
            }
            if(Model.createMonthlyReport(date, reservations, reservationIncome, sales, salesIncome, stockOrders, stockExpenses))
            {
                MessageBox.Show("The Monthly Report has been created");
            }
            else
            {
                MessageBox.Show("There was an error creating the Monthly Report");
            }
        }
    }
}
