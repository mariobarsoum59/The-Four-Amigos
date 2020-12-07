using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public static class IngredientsHotel
    {
        private static IIngredients ingredientsPrices = null;

        public static IIngredients GetIngredients(int ItemID, string ItemName, string Description, double Price, int Quantity, string Category)
        {
            if (ingredientsPrices != null)
                return ingredientsPrices;
            else
                return new Ingredients(ItemID, ItemName, Description, Price, Quantity, Category);

        }
    }
}
