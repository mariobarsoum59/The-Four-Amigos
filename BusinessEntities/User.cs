using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class User : BusinessEntities.IUser
    {
        #region Instance Properties

        private string firstName;
        private string surname;
        private string username;
        private string password;
        private string userType;
        #endregion

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

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }


        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string UserType
        {
            get
            {
                return userType;
            }
            set
            {
                userType = value;
            }
        }


        public User()
        {
            throw new System.NotImplementedException();
        }

        public User(string FirstName, string Surname, string Username, string Password, string userType)
        {
            this.firstName = FirstName;
            this.surname = Surname;
            this.username = Username;
            this.password = Password;
            this.userType = userType;
        }

    }
}
