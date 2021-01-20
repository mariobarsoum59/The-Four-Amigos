using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IDrinks
    {
        int DrinkID { get; set; }
        string DrinkName { get; set; }
        decimal DrinkPrice { get; set; }
    }
}
