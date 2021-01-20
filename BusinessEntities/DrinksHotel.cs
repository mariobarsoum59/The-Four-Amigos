using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class DrinksHotel
    {
        private static IDrinks drink = null;

        public static IDrinks GetDrinks(int DrinkID, string DrinkName, decimal DrinkPrice)
        {
            if (drink != null)
                return drink;
            else
                return new Drinks(DrinkID, DrinkName, DrinkPrice);

        }
        public static void SetDrinks(IDrinks aDrink)
        {
            drink = aDrink;
        }
    }
}
