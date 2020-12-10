using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class StockOrdersHotel
    {
        private static IStockOrder stockOrders = null;

        public static IStockOrder GetStockOrders(int OrderID, DateTime Date, decimal Total, String Department, bool Completed, int CreatedBy)
        {
            if (stockOrders != null)
                return stockOrders;
            else
                return new StockOrder(OrderID, Date, Total, Department, Completed, CreatedBy);

        }
        public static void SetStockOrders(IStockOrder aStockOrder)
        {
            stockOrders = aStockOrder;
        }
    }
}
