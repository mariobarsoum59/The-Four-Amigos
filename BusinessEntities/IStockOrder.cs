using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IStockOrder
    {
        int OrderID { get; set; }
        DateTime Date { get; set; }
        decimal Total { get; set; }
        String Department { get; set; }
        bool Completed { get; set; }
        int CreatedBy { get; set; }
    }
}
