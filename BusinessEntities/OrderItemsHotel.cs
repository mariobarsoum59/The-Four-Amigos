using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class OrderItemsHotel
    {
        private static IOrderItem orderItems = null;

        public static IOrderItem GetOrderItems(int OrderID, int ItemID, int Quantity)
        {
            if (orderItems != null)
                return orderItems;
            else
                return new OrderItem(OrderID, ItemID, Quantity);

        }
        public static void SetStockItems(IOrderItem anOrderItem)
        {
            orderItems = anOrderItem;
        }
    }
}
