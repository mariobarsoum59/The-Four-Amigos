using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public class GuestHotel
    {
        private static IGuest guest = null;

        public static IGuest GetGuest(int GuestID, string FirstName, string Surname, string ContactNumber, string Address, string Email, bool SendMarketingInfo)
        {
            if (guest != null)  // ie is Factory is primed with an object. 
                return guest;
            else
                return new Guest( GuestID,  FirstName,  Surname,  ContactNumber, Address, Email, SendMarketingInfo);
        }

        public static void SetGuest(IGuest aGuest)
        {
            guest = aGuest;
        }






    }
}
