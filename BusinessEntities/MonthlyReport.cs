using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class MonthlyReport : IMonthlyReport
    {
        private int reportID;
        private DateTime date;
        private int reservations;
        private decimal reservationIncome;
        private int sales;
        private decimal salesIncome;
        private decimal stockExpenses;

        public int ReportID
        {
            get
            {
                return reportID;
            }
            set 
            {
                reportID = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public int Reservations
        {
            get
            {
                return reservations;
            }
            set
            {
                reservations = value;
            }
        }
        public decimal ReservationIncome
        {
            get
            {
                return reservationIncome;
            }
            set
            {
                reservationIncome = value;
            }
        }
        public int Sales
        {
            get
            {
                return sales;
            }
            set
            {
                sales = value;
            }
        }
        public decimal SalesIncome
        {
            get
            {
                return salesIncome;
            }
            set
            {
                salesIncome = value;
            }
        }
        public decimal StockExpenses
        {
            get
            {
                return stockExpenses;
            }
            set
            {
                stockExpenses = value;
            }
        }
        public MonthlyReport()
        {
            throw new System.NotImplementedException();
        }
        public MonthlyReport(int ReportID, DateTime Date, int Reservations, decimal ReservationIncome, int Sales, decimal SalesIncome, decimal StockExpenses)
        {
            this.reportID = ReportID;
            this.date = Date;
            this.reservations = Reservations;
            this.reservationIncome = ReservationIncome;
            this.sales = Sales;
            this.salesIncome = SalesIncome;
            this.stockExpenses = StockExpenses;
        }
    }
}
