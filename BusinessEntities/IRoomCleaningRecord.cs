using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public interface IRoomCleaningRecord
    {

        int RecordID { get; set; }
        int RoomNumber { get; set; }

        DateTime CleanedAt { get; set; }
        string Note { get; set; }

    }
}
