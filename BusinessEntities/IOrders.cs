using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IOrders
    {
        int OrderID { get; set; }
        string Food { get; set; }
        double FoodPrice { get; set; }
        string Drink { get; set; }
        double DrinkPrice { get; set; }

        DateTime Timestamp { get; set; }

    }
}