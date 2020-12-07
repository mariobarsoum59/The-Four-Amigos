using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public class Reservation :IReservation
    {

        private int reservationID;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int adults;
        private int children;
        private double reservationPrice;
        private bool payedDeposit;
        private bool payedInFull;
        private int guestID;
        private int roomNumber;
        private bool checkIn;


        public int ReservationID
        {
            get
            {
                return reservationID;
            }
            set
            {
                reservationID = value;
            }
        }

        public DateTime CheckInDate
        {
            get
            {
                return checkInDate;
            }
            set
            {
                checkInDate = value;
            }
        }

        public DateTime CheckOutDate
        {
            get
            {
                return checkOutDate;
            }
            set
            {
                checkOutDate = value;
            }
        }

        public int Adults
        {
            get
            {
                return adults;
            }
            set
            {
                adults = value;
            }
        }

        public int Children
        {
            get
            {
                return children;
            }
            set
            {
                children = value;
            }
        }

        public double ReservationPrice
        {
            get
            {
                return reservationPrice;
            }
            set
            {
                reservationPrice = value;
            }
        }

        public bool PayedDeposit
        {
            get
            {
                return payedDeposit;
            }
            set
            {
                payedDeposit = value;
            }
        }

        public bool PayedInFull
        {
            get
            {
                return payedInFull;
            }
            set
            {
                payedInFull = value;
            }
        }
        public int GuestID
        {
            get
            {
                return guestID;
            }
            set
            {
                guestID = value;
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

        public bool CheckIn
        {
            get
            {
                return checkIn;
            }
            set
            {
                checkIn = value;
            }
        }


        public Reservation()
        {
            throw new System.NotImplementedException();
        }

        public Reservation(int ReservationID, DateTime CheckInDate, DateTime CheckOutDate, int Adults, int Children, double ReservationPrice, bool PayedDeposit, bool PayedInFull, int GuestID, int RoomNumber, bool CheckIn)
        {
            this.reservationID = ReservationID;
            this.checkInDate = CheckInDate;
            this.checkOutDate = CheckOutDate;
            this.adults = Adults;
            this.children = Children;
            this.reservationPrice = ReservationPrice;
            this.payedDeposit = PayedDeposit;
            this.payedInFull = PayedInFull;
            this.guestID = GuestID;
            this.roomNumber = RoomNumber;
            this.checkIn = CheckIn;
        }
    }
}
