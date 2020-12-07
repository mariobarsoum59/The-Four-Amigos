using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class BarItemsHotel
    {

        private static IBarItems baritems = null;

        public static IBarItems GetBarItems(int BarItemID, string Food, double FoodPrice, string Drink, double Drinkprice)
        {
            if (baritems != null)  // ie is Factory is primed with an object. 
                return baritems;
            else
                return new BarItems(BarItemID, Food, FoodPrice, Drink, Drinkprice);
        }

        public static void SetBarItems(IBarItems aBarItem)
        {
            baritems = aBarItem;
        }
    }
}