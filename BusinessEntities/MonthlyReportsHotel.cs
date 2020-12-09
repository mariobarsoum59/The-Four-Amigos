using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class MonthlyReportsHotel
    {
        private static IMonthlyReport monthlyReports = null;

        public static IMonthlyReport GetMonthlyReports(int ReportID, DateTime Date, int Reservations, decimal ReservationIncome, int Sales, decimal SalesIncome, decimal StockExpenses)
        {
            if (monthlyReports != null)
                return monthlyReports;
            else
                return new MonthlyReport(ReportID, Date, Reservations, ReservationIncome, Sales, SalesIncome, StockExpenses);

        }
        public static void SetMonthlyReports(IMonthlyReport aMonthlyReport)
        {
            monthlyReports = aMonthlyReport;
        }
    }
}
