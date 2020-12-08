using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public static class IngredientsHotel
    {
        private static IIngredients ingredients = null;

        public static IIngredients GetIngredients(int ItemID, string ItemName, string Description, double Price, int Quantity, string Category)
        {
            if (ingredients != null)
                return ingredients;
            else
                return new Ingredients(ItemID, ItemName, Description, Price, Quantity, Category);

        }
        public static void SetIngredients(IIngredients aIngredient)
        {
            ingredients = aIngredient;
        }
    }
}
