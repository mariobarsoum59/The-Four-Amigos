using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   

    public class RoomCleaningRecordHotel
    {
        private static IRoomCleaningRecord record = null;

        public static IRoomCleaningRecord GetRecords(int RecordID, int RoomNumber, DateTime CleanedAt,string Note)
        {
            if (record != null)
            {
                return record;
            }
            else
                return new RoomCleaningRecord(RecordID, RoomNumber, CleanedAt,Note);
        }


        public static void SetRoomCleaningRecord(IRoomCleaningRecord aRecord)
        {
            record = aRecord;
        }








    }
}
