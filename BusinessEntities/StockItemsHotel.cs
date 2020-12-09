using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class StockItemsHotel
    {
        private static IStockItem stockItems = null;

        public static IStockItem GetStockItems(int ItemID, String ItemName, String Description, decimal Price, int Quantity, String Category, String Department)
        {
            if (stockItems != null)
                return stockItems;
            else
                return new StockItem(ItemID, ItemName, Description, Price, Quantity, Category, Department);

        }
        public static void SetStockItems(IStockItem aStockItem)
        {
            stockItems = aStockItem;
        }
    }
}
