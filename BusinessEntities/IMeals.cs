using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{ 
    public interface IMeals
    {
        int DishID { get; set; }
        string DishName { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }
    }
}

