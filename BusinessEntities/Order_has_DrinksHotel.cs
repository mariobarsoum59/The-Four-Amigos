using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class Order_has_DrinksHotel
    {
        private static IOrder_has_Drinks orderDrink = null;

        public static IOrder_has_Drinks GetOrderDrinks(int OrderID, int DrinkID, int Quantity, string Status)
        {
            if (orderDrink != null)
                return orderDrink;
            else
                return new Order_has_Drinks(OrderID, DrinkID, Quantity, Status);

        }
        public static void SetOrderDrinks(IOrder_has_Drinks anOrderDrink)
        {
            orderDrink = anOrderDrink;
        }
    }
}
