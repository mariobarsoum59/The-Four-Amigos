using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class StockOrder : IStockOrder
    {
        private int orderID;
        private decimal total;
        private DateTime date;
        private string department;
        private bool completed;
        private int createdBy;

        public int OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
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
        public decimal Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
        public String Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public bool Completed
        {
            get
            {
                return completed;
            }
            set
            {
                completed = value;
            }
        }
        public int CreatedBy
        {
            get
            {
                return createdBy;
            }
            set
            {
                createdBy = value;
            }
        }
        public StockOrder()
        {
            throw new System.NotImplementedException();
        }
        public StockOrder(int OrderID, DateTime Date, decimal Total, String Department, bool Completed, int CreatedBy)
        {
            this.orderID = OrderID;
            this.date = Date;
            this.total = Total;
            this.department = Department;
            this.completed = Completed;
            this.createdBy = CreatedBy;
        }
    }
}
