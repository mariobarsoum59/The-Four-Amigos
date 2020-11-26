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
        private List<IRoom> roomsList;
        private List<IGuest> guestsList;
        private List<IReservation> reservationsList;
        private List<IRoom> roomsOnDates;
        private int selectedGuestID;
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


        public List<IRoom> RoomsList
        {
            get
            {
                return roomsList;
            }
            set
            {
                roomsList = value;
            }
        }

        public List<IGuest> GuestsList
        {
            get
            {
                return guestsList;
            }
            set
            {
                guestsList = value;
            }
        }


        public List<IReservation> ReservationsList
        {
            get
            {
                return reservationsList;
            }
            set
            {
                reservationsList = value;
            }
        }




        public List<IRoom> RoomsOnGivenDates
        {
            get
            {
                return roomsOnDates;
            }
            set
            {
                roomsOnDates = value;
            }
        }



        public int SelectedGuestID
        {
            get
            {
                return selectedGuestID;
            }
            set
            {
                selectedGuestID = value;
            }
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


        public Boolean addNewGuest(string FirstName, string Surname, string ContactNumber, string Address, string Email, bool SendMarketingInfo)
        {
            try
            {
                int maxId = 0;

                foreach (Guest u in GuestsList)
                {
                    if (u.GuestID > maxId)
                        maxId = u.GuestID;
                }
                IGuest theguest = GuestHotel.GetGuest(maxId + 1,FirstName, Surname, ContactNumber, Address, Email, SendMarketingInfo);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
                GuestsList.Add(theguest);                             // Add a reference to the newly created object to the Models UserList
                DataLayer.addNewGuestToDB(theguest); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }

        }


        public Boolean addNewReservation(DateTime CheckInDate, DateTime CheckOutDate, int Adults, int Children, double ReservationPrice, bool PayedDeposit, bool PayedInFull, int GuestID, int RoomNumber)
        {
            try
            {
                int maxId = 0;

                foreach (Reservation u in ReservationsList)
                {
                    if (u.ReservationID > maxId)
                        maxId = u.ReservationID;
                }
                IReservation theReservation = ReservationHotel.GetReservation(maxId + 1, CheckInDate, CheckOutDate, Adults, Children, ReservationPrice, PayedDeposit, PayedInFull, GuestID, RoomNumber);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
                ReservationsList.Add(theReservation);                             // Add a reference to the newly created object to the Models UserList
                DataLayer.addNewReservationToDB(theReservation); //Gets the DataLayer to add the new user to the DB. 
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

        public void GetAllRooms()
        {
            RoomsList = dataLayer.getAllRooms();

        }

        public void GetAllGuests()
        {
            GuestsList = dataLayer.getAllGuests();

        }

        public void GetAllReservations()
        {
            ReservationsList = dataLayer.getAllReservations();
        }


        public void GetRoomsForDates(string CheckIn, string CheckOut)
        {
            RoomsOnGivenDates = dataLayer.getRoomForDates(CheckIn, CheckOut);
        }

        public void getSelectedGuest(int guestid)
        {
            SelectedGuestID = guestid;
        }




    }
}
