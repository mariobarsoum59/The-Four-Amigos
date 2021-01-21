using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IOrder_has_Drinks
    {
        int OrderID { get; set; }
        int DrinkID { get; set; }
        int Quantity { get; set; }
        string Status { get; set; }
    }
}
