using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class WasteHotel
    {
        private static IWaste waste = null;

        public static IWaste GetWaste(int DishID, string DishName, int NumWasted, double LossFromWaste, DateTime Date)
        {
            if (waste != null)
                return waste;
            else
                return new Waste(DishID, DishName, NumWasted, LossFromWaste, Date);

        }
        public static void SetWaste(IWaste aWaste)
        {
            waste = aWaste;
        }
    }
}
