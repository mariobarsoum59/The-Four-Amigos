using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IRoom
    {
        int RoomNumber { get; set; }
        double BasePrice { get; set; }
        bool Available { get; set; }
        string RoomType { get; set; }
        bool Smoking { get; set; }

    }
}
