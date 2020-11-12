using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class UserHotel
    {

        private static IUser user = null;

        public static IUser GetUser(string FirstName, string Surname, string Username, string Password, string userType, int userID)
        {
            if (user != null)  // ie is Factory is primed with an object. 
                return user;
            else
                return new User(FirstName, Surname, Username, Password, userType, userID);
        }
        public static void SetUser(IUser aUser)   // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            user = aUser;
        }





    }
}
