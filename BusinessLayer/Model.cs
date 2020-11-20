using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities;
using System.Collections;

namespace BusinessLayer
{
    public class Model : IModel
    {
        #region Static Attributes
        private static IModel modelSingletonInstance;  // Model object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the Model singleton creation. ie in GetInstance () method
        #endregion

        #region Instance Attribures
        private IDataLayer dataLayer;
        private User currentUser;
        private ArrayList userList;
        #endregion

        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }
        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }


        public ArrayList UserList
        {
            get
            {
                return userList;
            }
            //set
            //{
            //}
        }
        #endregion



        #region Constructors/Destructors
        public static IModel GetInstance(IDataLayer _DataLayer) // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (modelSingletonInstance == null)
                {
                    modelSingletonInstance = new Model(_DataLayer);
                }
                return modelSingletonInstance;
            }
        }
        private Model(IDataLayer _DataLayer)  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            userList = new ArrayList();
            dataLayer = _DataLayer;
            userList = dataLayer.GetAllUsers(); // setup Models userList so we can login
        }

        ~Model()
        {
            tearDown();
        }
        #endregion


        public Boolean login(String username, String password)
        {

            foreach (User user in userList)
            {
                if (username == user.Username && password == user.Password)
                {

                    CurrentUser = user;
                    return true;
                }
            }
            return false;
        }
        public Boolean addNewUser(string FirstName, string Surname, string Username, string Password, string userType)
        {
            try
            {
                int maxId = 0;
                // need some code to avoid dulicate usernames


                // maybe add some logic (busiess rules) about password policy
                //      IUser user = new User(name, password, userType); // Construct a User Object
                foreach (User u in UserList)
                {
                    if (u.UserID > maxId)
                        maxId = u.UserID;
                }
                IUser theUser = UserHotel.GetUser(FirstName, Surname, Username, Password, userType, maxId + 1);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
                UserList.Add(theUser);                             // Add a reference to the newly created object to the Models UserList
                DataLayer.addNewUserToDB(theUser); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }




        }

        public String getUserTypeForCurrentuser()
        {
            return currentUser.UserType;
        }



        public void tearDown()
        {
            DataLayer.closeConnection();
        }




        public bool deleteUser(IUser user)
        {

            DataLayer.deleteUserFromDB(user);
            UserList.Remove(user); //remove object from collection
            return true;

        }



        public bool PasswordCheck(string password)
        {
            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower))
            {
                return true;
            }
            return false;
        }
    }
}
