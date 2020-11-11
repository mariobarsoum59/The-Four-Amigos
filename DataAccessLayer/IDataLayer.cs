using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void addNewUserToDB(string FirstName, string Surname, string Username, string Password, string userType);
        void closeConnection();
        System.Collections.ArrayList GetAllUsers();
        System.Data.SqlClient.SqlConnection getConnection();
        void openConnection();



    }
}
