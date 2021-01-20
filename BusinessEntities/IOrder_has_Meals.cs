using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IOrder_has_Meals
    {
        int OrderID { get; set; }
        int DishID { get; set; }
        int Quantity { get; set; }
    }
}
