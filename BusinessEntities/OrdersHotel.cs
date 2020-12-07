using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class OrdersHotel
    {

        private static IOrders orders = null;

        public static IOrders GetOrders(int OrderID, string Food, double FoodPrice, string Drink, double Drinkprice, string Timestamp)
        {
            if (orders != null)  // ie is Factory is primed with an object. 
                return orders;
            else
                return new Orders(OrderID, Food, FoodPrice, Drink, Drinkprice, Timestamp);
        }

        public static void SetBarItems(IOrders aOrders)
        {
            orders = aOrders;
        }
    }
}