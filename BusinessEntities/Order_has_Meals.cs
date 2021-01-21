using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Order_has_Meals : IOrder_has_Meals
    {
        #region Instance Properties
        private int orderID;
        private int dishID;
        private int quantity;
        private string status;
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
        public int DishID
        {
            get
            {
                return dishID;
            }
            set
            {
                dishID = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public Order_has_Meals()
        {

        }
        public Order_has_Meals(int OrderID, int DishID, int Quantity, string Status)
        {
            this.orderID = OrderID;
            this.dishID = DishID;
            this.quantity = Quantity;
            this.status = Status;
        }
    }
}
