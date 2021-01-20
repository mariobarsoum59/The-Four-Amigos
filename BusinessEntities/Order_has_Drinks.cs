using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Order_has_Drinks : IOrder_has_Drinks
    {
        #region Instance Properties
        private int orderID;
        private int drinkID;
        private int quantity;
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
        public int DrinkID
        {
            get
            {
                return drinkID;
            }
            set
            {
                drinkID = value;
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
        public Order_has_Drinks()
        {

        }
        public Order_has_Drinks(int OrderID, int DrinkID, int Quantity)
        {
            this.orderID = OrderID;
            this.drinkID = DrinkID;
            this.quantity = Quantity;
        }
    }
}
