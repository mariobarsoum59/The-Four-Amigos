using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IOrderItem
    {
        int OrderID { get; set; }
        int ItemID { get; set; }
        int Quantity { get; set; }
    }
}
