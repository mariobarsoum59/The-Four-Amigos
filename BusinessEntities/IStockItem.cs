using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IStockItem
    {
        int ItemID { get; set; }
        string ItemName { get; set; }
        String Description { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }
        String Category { get; set; }
        String Department { get; set; }
    }
}
