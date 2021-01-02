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
        private List<IRoomCleaningRecord> roomCleaningRecordsList;
        private int selectedGuestID;
        private List<IBarItems> baritemslist;
        private List<IOrders> orderslist;
        private List<IIngredients> ingredientsList;
        private List<IMeals> mealsList;
        private List<IWaste> wasteList;
        private List<IStockItem> stockItemsList;
        private List<IStockOrder> stockOrdersList;
        private List<IOrderItem> orderItemsList;
        private List<IMonthlyReport> monthlyReportsList;
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

        public List<IRoomCleaningRecord> RoomCleaningRecordsList
        {
            get
            {
                return roomCleaningRecordsList;
            }
            set
            {
                roomCleaningRecordsList = value;
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

        public List<IBarItems> BarItemsList
        {
            get
            {
                return baritemslist;
            }
            set
            {
                baritemslist = value;
            }
        }
        public List<IOrders> OrdersList
        {
            get
            {
                return orderslist;
            }
            set
            {
                orderslist = value;
            }
        }

        public List<IIngredients> IngredientsList
        {
            get
            {
                return ingredientsList;
            }
            set
            {
                ingredientsList = value;
            }
        }

        public List<IMeals> MealsList
        {
            get
            {
                return mealsList;
            }
            set
            {
                mealsList = value;
            }
        }

        public List<IWaste> WasteList
        {
            get
            {
                return wasteList;
            }
            set
            {
                wasteList = value;
            }
        }
        public List<IStockItem> StockItemsList
        {
            get
            {
                return stockItemsList;
            }
            set
            {
                stockItemsList = value;
            }
        }
        public List<IStockOrder> StockOrdersList
        {
            get
            {
                return stockOrdersList;
            }
            set
            {
                stockOrdersList = value;
            }
        }
        public List<IOrderItem> OrderItemsList
        {
            get
            {
                return orderItemsList;
            }
            set
            {
                orderItemsList = value;
            }
        }
        public List<IMonthlyReport> MonthlyReportsList
        {
            get
            {
                return monthlyReportsList;
            }
            set
            {
                monthlyReportsList = value;
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


        public Boolean addNewReservation(DateTime CheckInDate, DateTime CheckOutDate, int Adults, int Children, double ReservationPrice, bool PayedDeposit, bool PayedInFull, int GuestID, int RoomNumber,bool CheckIn)
        {
            try
            {
                int maxId = 0;

                foreach (Reservation u in ReservationsList)
                {
                    if (u.ReservationID > maxId)
                        maxId = u.ReservationID;
                }
                IReservation theReservation = ReservationHotel.GetReservation(maxId + 1, CheckInDate, CheckOutDate, Adults, Children, ReservationPrice, PayedDeposit, PayedInFull, GuestID, RoomNumber,CheckIn);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
                ReservationsList.Add(theReservation);                             // Add a reference to the newly created object to the Models UserList
                DataLayer.addNewReservationToDB(theReservation); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
            catch (System.Exception excep)
            {
                return false;
            }

        }


        public Boolean addNewRoomCleaningRecord(int RoomNumber, DateTime CleanedAt, string Note)
        {
            try
            {
                int maxId = 0;

                foreach (RoomCleaningRecord r in RoomCleaningRecordsList)
                {
                    if (r.RecordID > maxId)
                        maxId = r.RecordID;
                }
                IRoomCleaningRecord theRecord = RoomCleaningRecordHotel.GetRecords(maxId + 1, RoomNumber, CleanedAt, Note);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
                RoomCleaningRecordsList.Add(theRecord);                             // Add a reference to the newly created object to the Models UserList
                DataLayer.addNewRoomCleaningRecordToDB(theRecord); //Gets the DataLayer to add the new user to the DB. 
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

        public bool deleteReservation(IReservation reservation)
        {

            DataLayer.deleteReservationFromDB(reservation);
            reservationsList.Remove(reservation); //remove object from collection
            return true;

        }

        public bool updateReservation(IReservation reservation)
        {
            DataLayer.updateReservationFromDB(reservation);
            return true;
        }

        public bool updateGuest(IGuest guest)
        {
            DataLayer.updateGuestFromDB(guest);
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

        public void GetAllRoomCleaningRecords()
        {
            RoomCleaningRecordsList = dataLayer.getAllRoomCleaningRecords();
        }
        public void GetAllBarItems()
        {
            BarItemsList = dataLayer.getAllbarItems();

        }

        public bool UpdateRoomPrice(IRoom room)
        {
            dataLayer.updateRoomPriceInDB(room);
            return true;
        }
        public bool UpdateOrderComplete(IOrders completed)
        {
            dataLayer.updateCompletedOrders(completed);
            return true;
        }

        public bool CheckGuestIn(IReservation reservation)
        {
            dataLayer.checkGusetInDB(reservation);
            return true;
        }

        public void GetAllOrders()
        {
            OrdersList = dataLayer.getAllOrders();

        }


        //-------------------Rebecca ---------------------------------------------- 

        public void GetAllIngredients()
        {
           IngredientsList = dataLayer.getAllIngredients();
        }

        public void GetAllMeals()
        {
            MealsList = dataLayer.getAllMealsDB();
        }

        public void GetAllWaste()
        {
            WasteList = dataLayer.getAllWasteDB();
        }

        public bool ChangeOrderStatus(IOrders status)
        {
            DataLayer.changeOrderStatus(status);
            return true;
        }



        //-----------------------------------------------------------------------------------------
        public void GetAllStockItems()
        {
            StockItemsList = dataLayer.getAllStockItems();
        }
        public void GetAllStockOrders()
        {
            StockOrdersList = dataLayer.getAllStockOrders();
        }
        public void GetAllOrderItems()
        {
            OrderItemsList = dataLayer.getAllOrderItems();
        }
        public void GetAllMonthlyReports()
        {
            MonthlyReportsList = dataLayer.getAllMonthlyReports();
        }
        public Boolean createMonthlyReport(DateTime Date, int Reservations, decimal ReservationIncome, int Sales, decimal SalesIncome, int StockOrders, decimal StockExpenses)
        {
            try
            {
                
                IMonthlyReport aMonthlyReport = MonthlyReportsHotel.GetMonthlyReports(0, Date, Reservations, ReservationIncome, Sales, SalesIncome, StockOrders, StockExpenses);                          
                DataLayer.addNewMonthlyReportToDB(aMonthlyReport);
                return true;
            }
            catch (System.Exception excep)
            {
                
                return false;
            }

        }
        public Boolean createStockOrder(DateTime Date, decimal Total, String Department, int CreatedBy)
        {
            try
            {

                IStockOrder aStockOrder = StockOrdersHotel.GetStockOrders(0, Date, Total, Department, false, CreatedBy);
                DataLayer.addNewStockOrderToDB(aStockOrder);
                return true;
            }
            catch (System.Exception excep)
            {

                return false;
            }
        }
        public Boolean createOrderItem(int OrderID, int ItemID, int Quantity)
        {
            try
            {

                IOrderItem aOrderItem = OrderItemsHotel.GetOrderItems(OrderID, ItemID, Quantity);
                DataLayer.addNewOrderItemToDB(aOrderItem);
                return true;
            }
            catch (System.Exception excep)
            {

                return false;
            }
        }
        public bool UpdateCurrrentStockItem(IStockItem stockItem)
        {
            dataLayer.updateCurrentStockItemInDB(stockItem);
            return true;
        }


    }
}
