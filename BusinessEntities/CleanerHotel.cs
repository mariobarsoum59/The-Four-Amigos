using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public static class CleanerHotel
    {
        private static ICleaner cleaner = null;

        public static ICleaner GetCleaner(string FirstName, string Surname, string Username, string Password, string UserType, int UserID)
        {
            if (cleaner != null)  // ie is Factory is primed with an object. 
                return cleaner;
            else
                return new Cleaner(FirstName, Surname, Username, Password, UserType, UserID);
        }
        public static void SetCleaner(ICleaner aCleaner)   // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            cleaner = aCleaner;
        }

    }
}
