using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Guest : IGuest
    {
        private int guestID;
        private string firstName;
        private string surname;
        private string contactNumber;
        private string address;
        private string email;
        private bool sendMarketingInfo;


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


        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }

        }


        public string ContactNumber
        {
            get
            {
                return contactNumber;
            }
            set
            {
                contactNumber = value;
            }
        }


        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }


        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }


        public bool SendMarketingInfo
        {
            get
            {
                return sendMarketingInfo;
            }
            set
            {
                sendMarketingInfo = value;
            }
        }




        public Guest()
        {
            throw new System.NotImplementedException();
        }

        public Guest(int GuestID, string FirstName, string Surname, string ContactNumber, string Address, string Email, bool SendMarketingInfo)
        {
            this.guestID = GuestID;
            this.firstName = FirstName;
            this.surname = Surname;
            this.contactNumber = ContactNumber;
            this.address = Address;
            this.email = Email;
            this.sendMarketingInfo = SendMarketingInfo;

        }
    }
}
