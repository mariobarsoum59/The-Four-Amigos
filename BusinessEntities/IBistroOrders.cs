using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IBistroOrders
    {
        int OrderID { get; set; }
        DateTime OrderDate { get; set; }
        decimal OrderTotal { get; set; }
        int OrderMadeBy { get; set; }
        string OrderNote { get; set; }
        Boolean OrderCompleted { get; set; }
    }
}
