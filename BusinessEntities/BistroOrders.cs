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
        private string orderNote;
        private Boolean orderCompleted;
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
        public string OrderNote
        {
            get
            {
                return orderNote;
            }
            set
            {
                orderNote = value;
            }
        }
        public Boolean OrderCompleted
        {
            get
            {
                return orderCompleted;
            }
            set
            {
                orderCompleted = value;
            }
        }
        public BistroOrders()
        {

        }
        public BistroOrders(int OrderID, DateTime OrderDate, decimal OrderTotal, int OrderMadeBy, string OrderNote, Boolean OrderCompleted)
        {
            this.orderID = OrderID;
            this.orderDate = OrderDate;
            this.orderTotal = OrderTotal;
            this.orderMadeBy = OrderMadeBy;
            this.orderNote = OrderNote;
            this.orderCompleted = OrderCompleted;
        }
    }
}
