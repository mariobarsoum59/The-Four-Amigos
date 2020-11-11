using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomFeildHotel
{
    public class User
    {
        private string FirstName;
        private string Surname;
        private string Username;
        private string Password;
        private string userType;

        public User()
        {
            throw new System.NotImplementedException();
        }

        public User(string FirstName,string Surname, string Username, string Password, string userType)
        {
            this.FirstName = FirstName;
            this.Surname = Surname;
            this.Username = Username;
            this.Password = Password;
            this.userType = userType;
        }

        public string FName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }


        public string SName
        {
            get
            {
                return Surname; 
            }
            set
            {
                Surname = value;
            }
        }

        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }


        public string UName
        {
            get
            {
                return Username;
            }
            set
            {
                Username = value;
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

        public bool IsLogger(string Uname, string password)
        {
            return (this.Username == Uname && this.Password == password);

        }

    }
}
