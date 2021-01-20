using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class BistroOrdersHotel
    {
        private static IBistroOrders order = null;

        public static IBistroOrders GetBistroOrders(int OrderID, DateTime OrderDate, decimal OrderTotal, int OrderMadeBy)
        {
            if (order != null)
                return order;
            else
                return new BistroOrders(OrderID, OrderDate, OrderTotal, OrderMadeBy);

        }
        public static void SetBistroOrder(IBistroOrders anOrder)
        {
            order = anOrder;
        }
    }
}
