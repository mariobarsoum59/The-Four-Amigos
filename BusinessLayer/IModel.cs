using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer
{
    public interface IModel
    {

        bool addNewUser(string FirstName, string Surname, string Username, string Password, string userType);
        BusinessEntities.User CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        string getUserTypeForCurrentuser();
        bool login(string username, string password);

        bool deleteUser(IUser user);

        void tearDown();
        System.Collections.ArrayList UserList { get; }
        bool PasswordCheck(string password);


    }
}
