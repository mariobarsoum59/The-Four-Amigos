using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class OrderItem : IOrderItem
    {
        private int orderID;
        private int itemID;
        private int quantity;

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
        public int ItemID
        {
            get
            {
                return itemID;
            }
            set
            {
                itemID = value;
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
        public OrderItem()
        {
            throw new System.NotImplementedException();
        }
        public OrderItem(int OrderID, int ItemID, int Quantity)
        {
            this.orderID = OrderID;
            this.itemID = ItemID;
            this.quantity = Quantity;
        }
    }
}
