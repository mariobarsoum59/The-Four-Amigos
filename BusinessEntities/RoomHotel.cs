using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class RoomHotel
    {
        private static IRoom Room = null;

        public static IRoom GetRoom(int RoomNumber, double BasePrice, bool Available, string RoomType, bool Smoking)
        {
            if (Room != null)
            {
                return Room;
            }
            else
            {
               
                return new Room(RoomNumber, BasePrice, Available, RoomType, Smoking);
            }
                
        }

        public static void SetRoom (IRoom aRoom)
        {
            Room = aRoom;
        }
    }
}
