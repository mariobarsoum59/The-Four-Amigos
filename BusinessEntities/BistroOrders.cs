using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BistroOrders : IBistroOrders
    {
        #region Instance Properties
        private int orderID;
        private DateTime orderDate;
        private decimal orderTotal;
        private int orderMadeBy;
        #endregion

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
        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }
        public decimal OrderTotal
        {
            get
            {
                return orderTotal;
            }
            set
            {
                orderTotal = value;
            }
        }
        public int OrderMadeBy
        {
            get
            {
                return orderMadeBy;
            }
            set
            {
                orderMadeBy = value;
            }
        }
        public BistroOrders()
        {

        }
        public BistroOrders(int OrderID, DateTime OrderDate, decimal OrderTotal, int OrderMadeBy)
        {
            this.orderID = OrderID;
            this.orderDate = OrderDate;
            this.orderTotal = OrderTotal;
            this.orderMadeBy = OrderMadeBy;
        }
    }
}
