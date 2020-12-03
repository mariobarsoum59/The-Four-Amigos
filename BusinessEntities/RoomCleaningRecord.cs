using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class RoomCleaningRecord : IRoomCleaningRecord
    {
        private int recordID;
        private int roomNumber;
        private DateTime cleanedAt;
        private string note;

        public int RecordID
        {
            get
            {
                return recordID;
            }
            set
            {
                recordID = value;
            }
        }



        public int RoomNumber
        {
            get
            {
                return roomNumber;
            }
            set
            {
                roomNumber = value;
            }
        }


        public DateTime CleanedAt
        {
            get
            {
                return cleanedAt;
            }
            set
            {
                cleanedAt = value;
            }
        }


        public string Note
        {
            get
            {
                return note;
            }
            set
            {
                note = value;
            }
        }



        public RoomCleaningRecord()
        {
            throw new System.NotImplementedException();

        }


        public RoomCleaningRecord(int RecordID, int RoomNumber, DateTime CleanedAt,string Note)
        {
            this.recordID = RecordID;
            this.roomNumber = RoomNumber;
            this.cleanedAt = CleanedAt;
            this.note=Note;
        }





    }
}
