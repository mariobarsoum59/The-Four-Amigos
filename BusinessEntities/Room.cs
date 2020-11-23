using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public class Room : IRoom
    {

        private int roomNumber;
        private double basePrice;
        private bool available;
        private string roomType;
        private bool smoking;



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

        public double BasePrice
        {
            get
            {
                return basePrice;
            }
            set
            {
                basePrice = value;
            }
        }


        public bool Available
        {
            get
            {
                return available;
            }
            set
            {
                available = value;
            }
        }


        public string RoomType
        {
            get
            {
                return roomType;
            }
            set
            {
                roomType = value;
            }
        }


        public bool Smoking
        {
            get
            {
                return smoking;
            }
            set
            {
                smoking = value;
            }
        }

        public Room()
        {
            throw new System.NotImplementedException();
        }

        public Room(int RoomNumber, double BasePrice, bool Available, string RoomType, bool Smoking)
        {
            this.roomNumber = RoomNumber;
            this.basePrice = BasePrice;
            this.available = Available;
            this.roomType = RoomType;
            this.smoking = Smoking;
        }
    }
}
