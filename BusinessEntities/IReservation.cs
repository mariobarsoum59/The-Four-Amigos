using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IReservation
    {
        int ReservationID { get; set; }

        DateTime CheckInDate { get; set; }

        DateTime CheckOutDate { get; set; }

        int Adults { get; set; }
        int Children { get; set; }
        double ReservationPrice { get; set; }
        bool PayedDeposit { get; set; }
        bool PayedInFull { get; set; }
        int GuestID { get; set; }
        int RoomNumber { get; set; }

        bool CheckIn { get; set; }






    }
}
