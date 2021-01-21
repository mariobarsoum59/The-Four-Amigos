using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class Order_has_MealsHotel
    {
        private static IOrder_has_Meals orderMeal = null;

        public static IOrder_has_Meals GetOrderMeals(int OrderID, int DishID, int Quantity, string Status)
        {
            if (orderMeal != null)
                return orderMeal;
            else
                return new Order_has_Meals(OrderID, DishID, Quantity, Status);

        }
        public static void SetOrderMeal(IOrder_has_Meals anOrderMeal)
        {
            orderMeal = anOrderMeal;
        }
    }
}
