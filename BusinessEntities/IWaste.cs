using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IWaste
    {
        int DishID { get; set; }
        string DishName { get; set; }
        int NumWasted { get; set; }
        double LossFromWaste { get; set; }
        DateTime Date { get; set; }
    }
}
