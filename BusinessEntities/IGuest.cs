using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IGuest
    {

        int GuestID { get; set; }
        string FirstName { get; set; }
        string Surname { get; set; }
        string ContactNumber { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        bool SendMarketingInfo { get; set; }


    }
}
