using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class ReservationHotel
    {
        private static IReservation Reservation = null;


        public static IReservation GetReservation(int ReservationID, DateTime CheckInDate, DateTime CheckOutDate, int Adults, int Children, double ReservationPrice, bool PayedDeposit, bool PayedInFull, int GuestID, int RoomNumber)
        {
            if (Reservation != null)
            {
                return Reservation;
            }
            else
            {
                return new Reservation(ReservationID, CheckInDate, CheckOutDate, Adults, Children, ReservationPrice, PayedDeposit, PayedInFull, GuestID, RoomNumber);
            }
        }


        public static void SetReservation(IReservation aReservation)
        {
            Reservation = aReservation;
        }


    }
}
