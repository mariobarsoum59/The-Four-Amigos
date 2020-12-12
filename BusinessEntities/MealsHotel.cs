using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class MealsHotel
    {
        private static IMeals meals = null;

        public static IMeals GetMeals(int DishID, string DishName, double Price, int Quantity)
        {
            if (meals != null)
                return meals;
            else
                return new Meals(DishID, DishName, Price, Quantity);

        }
        public static void SetMeals(IMeals aMeal)
        {
            meals = aMeal;
        }
    }
}
