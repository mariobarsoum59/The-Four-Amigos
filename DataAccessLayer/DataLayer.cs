using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

using BusinessEntities;

namespace DataAccessLayer
{
    public class DataLayer:IDataLayer
    {

        #region Instance Attributes
        private SqlConnection con;   // DB Connection
        DataSet ds;                 //Declare the DataSet object
        SqlDataAdapter da;          //Declare the DataAdapter object
        int maxRows;
      
        SqlCommandBuilder cb;
        #endregion

        private static IDataLayer dataLayerSingletonInstance;  // DataLayer object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the DataLayer singleton creation. ie in GetInstance () method


        public static IDataLayer GetInstance() // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (dataLayerSingletonInstance == null)
                {
                    dataLayerSingletonInstance = new DataLayer();
                }
                return dataLayerSingletonInstance;
            }
        }


        private DataLayer()  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            openConnection();
        }


        public void openConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=SQL5.student.litdom.lit.ie\\TEAM2, 60152;Database=BloomFeildHotel;User Id=k00235626;Password=$QLT3AM02;";
            //con.ConnectionString = "Data Source=BDEV2 ;Initial Catalog=ProductTracker;Integrated Security=True";
            /*       con.ConnectionString = "Data Source=SQL02.student.litdom.lit.ie\\SD3A ;Initial Catalog=ProductTracker;Integrated Security=True";
                     This last conection string is for SQL02.student.litdom.lit.ie\SD3A  Note the extra (slash)\ in the code. This is needed in the lab 
                     for the extra instances Annette Bowman sets up on the CS SQL Server*/
            try
            {
                con.Open();
                //MessageBox.Show("Database Open");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                Environment.Exit(0); //Force the application to close
            }
        }



        public void closeConnection()
        {
            con.Close();
        }

        public SqlConnection getConnection()
        {
            return con;
        }

        public List <ICleaner> getAllCleaner()
        {
            List<ICleaner> cleanerList = new List<ICleaner>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                maxRows = ds.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["UsersData"].Rows[i];
                    ICleaner cleaner = CleanerHotel.GetCleaner(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString(),
                                                       Convert.ToInt16((dRow.ItemArray.GetValue(5))));
                    cleanerList.Add(cleaner);
                    //MessageBox.Show(user.Username + user.Password);

                    //textBoxName.Select();
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }



            return cleanerList;

        }

        public ArrayList GetAllUsers()
        {
            ArrayList UserList = new ArrayList();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                maxRows = ds.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["UsersData"].Rows[i];
                    IUser user = UserHotel.GetUser(dRow.ItemArray.GetValue(0).ToString(),
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString(),
                                                       Convert.ToInt16((dRow.ItemArray.GetValue(5))));
                    UserList.Add(user);
                    //MessageBox.Show(user.Username + user.Password);

                    //textBoxName.Select();
                }

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }



            return UserList;

        }

        public void addNewUserToDB(IUser theUser)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Users";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                maxRows = ds.Tables["UsersData"].Rows.Count;
                DataRow dRow = ds.Tables["UsersData"].NewRow();
                dRow[0] = theUser.FirstName;
                dRow[1] = theUser.Surname;
                dRow[2] = theUser.Username;
                dRow[3] = theUser.Password;
                dRow[4] = theUser.UserType;
                dRow[5] = theUser.UserID;



                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public void addNewGuestToDB(IGuest theGuest)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Guests";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "GuestData");
                maxRows = ds.Tables["GuestData"].Rows.Count;
                DataRow dRow = ds.Tables["GuestData"].NewRow();
                dRow[0] = theGuest.GuestID;
                dRow[1] = theGuest.FirstName;
                dRow[2] = theGuest.Surname;
                dRow[3] = theGuest.ContactNumber;
                dRow[4] = theGuest.Address;
                dRow[5] = theGuest.Email;
                dRow[6] = theGuest.SendMarketingInfo;



                ds.Tables["GuestData"].Rows.Add(dRow);
                da.Update(ds, "GuestData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }



        public void addNewReservationToDB(IReservation theReservation)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Reservations";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "reservationData");
                maxRows = ds.Tables["reservationData"].Rows.Count;
                DataRow dRow = ds.Tables["reservationData"].NewRow();
                dRow[0] = theReservation.ReservationID;
                dRow[1] = theReservation.CheckInDate;
                dRow[2] = theReservation.CheckOutDate;
                dRow[3] = theReservation.Adults;
                dRow[4] = theReservation.Children;
                dRow[5] = theReservation.ReservationPrice;
                dRow[6] = theReservation.PayedDeposit;
                dRow[7] = theReservation.PayedInFull;
                dRow[8] = theReservation.GuestID;
                dRow[9] = theReservation.RoomNumber;
                dRow[10] = theReservation.CheckIn;



                ds.Tables["reservationData"].Rows.Add(dRow);
                da.Update(ds, "reservationData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }












        public bool deleteUserFromDB(BusinessEntities.IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        public bool deleteReservationFromDB(BusinessEntities.IReservation reservation)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Reservations";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ReservationsData");
                DataRow findRow = ds.Tables["ReservationsData"].Rows.Find(reservation.ReservationID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "ReservationsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        public virtual List<IRoom>getAllRooms()
        {
            List<IRoom> RoomsList = new List<IRoom>();
            DataSet ds;                 //Declare the DataSet object
            SqlDataAdapter da;   //Declare the DataAdapter object
            SqlCommandBuilder cb;

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Rooms";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RoomsData");
                int totNumsRooms = ds.Tables["RoomsData"].Rows.Count;
                for (int i = 0; i < totNumsRooms; i++)
                {
                    DataRow dRow = ds.Tables["RoomsData"].Rows[i];

                    IRoom room = RoomHotel.GetRoom(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),  // Using a Hotel to create the Room entity object. ie seperating object creation from business logic
                                                       Convert.ToDouble(dRow.ItemArray.GetValue(1).ToString()),
                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(2).ToString()),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                       Convert.ToBoolean((dRow.ItemArray.GetValue(4))));

                    
                    RoomsList.Add(room);
                }
            }
            catch(System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }


            return RoomsList;

        }

        public virtual List<IGuest> getAllGuests()
        {
            List<IGuest> GuestsList = new List<IGuest>();
            DataSet ds;                 //Declare the DataSet object
            SqlDataAdapter da;   //Declare the DataAdapter object
            SqlCommandBuilder cb;

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Guests";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "GuestsData");
                int totNumsGuest = ds.Tables["GuestsData"].Rows.Count;
                for (int i = 0; i < totNumsGuest; i++)
                {
                    DataRow dRow = ds.Tables["GuestsData"].Rows[i];

                    IGuest guest = GuestHotel.GetGuest(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),  // Using a Hotel to create the Room entity object. ie seperating object creation from business logic
                                                       dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                        dRow.ItemArray.GetValue(4).ToString(),
                                                        dRow.ItemArray.GetValue(5).ToString(),
                                                       Convert.ToBoolean((dRow.ItemArray.GetValue(6))));


                    GuestsList.Add(guest);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }


            return GuestsList;

        }


        public virtual List<IReservation> getAllReservations()
        {
            List<IReservation> ReservationsList = new List<IReservation>();
            DataSet ds;                 //Declare the DataSet object
            SqlDataAdapter da;   //Declare the DataAdapter object
            SqlCommandBuilder cb;

            

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Reservations";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ReservationsData");
                int totNumReservations = ds.Tables["ReservationsData"].Rows.Count;
                for (int i = 0; i < totNumReservations; i++)
                {
                    DataRow dRow = ds.Tables["ReservationsData"].Rows[i];


                    IReservation reservation = ReservationHotel.GetReservation      // Using factory to create the reservation entity object. ie seperating object creation from business logic
                        (Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),  //reservationID
                                                       Convert.ToDateTime(dRow.ItemArray.GetValue(1).ToString()), //in
                                                        Convert.ToDateTime(dRow.ItemArray.GetValue(2).ToString()), //out
                                                        Convert.ToInt16(dRow.ItemArray.GetValue(3).ToString()), //Adults
                                                        Convert.ToInt16(dRow.ItemArray.GetValue(4).ToString()), //Children
                                                        Convert.ToDouble(dRow.ItemArray.GetValue(5).ToString()), //Price
                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(6).ToString()), //deposit
                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(7).ToString()), //Payedfull
                                                        Convert.ToInt16(dRow.ItemArray.GetValue(8).ToString()), //guestID
                                                       Convert.ToInt16((dRow.ItemArray.GetValue(9))),
                                                       Convert.ToBoolean(dRow.ItemArray.GetValue(10).ToString())
                                                       ); //RoomNum


                    ReservationsList.Add(reservation);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }


            return ReservationsList;

        }



        public virtual List<IRoom> getRoomForDates(string CheckIn, string CheckOut)
        {
            List<IRoom> AvailableRoomsList = new List<IRoom>();
            DataSet ds;                 //Declare the DataSet object
            SqlDataAdapter da;   //Declare the DataAdapter object
            SqlCommandBuilder cb;

            try
            {
                ds = new DataSet();
                string sql = "SELECT Rooms.RoomNumber,rooms.BasePrice,rooms.Available,rooms.RoomType,Rooms.Smoking FROM rooms LEFT JOIN reservations ON(reservations.RoomNumber = rooms.RoomNumber AND NOT((reservations.CheckInDate < '"+CheckIn+ "' and reservations.CheckOutDate < '" + CheckIn + "') OR (reservations.CheckInDate > '" + CheckOut + "' and reservations.CheckOutDate > '" + CheckOut + "'))) WHERE reservations.RoomNumber IS NULL; ";
                //MessageBox.Show(sql);
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ARoomsData");
                int totNumsRooms = ds.Tables["ARoomsData"].Rows.Count;
                for (int i = 0; i < totNumsRooms; i++)
                {
                    DataRow dRow = ds.Tables["ARoomsData"].Rows[i];

                    IRoom room = RoomHotel.GetRoom(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),  // Using a Hotel to create the Room entity object. ie seperating object creation from business logic
                                                       Convert.ToDouble(dRow.ItemArray.GetValue(1).ToString()),
                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(2).ToString()),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                       Convert.ToBoolean((dRow.ItemArray.GetValue(4))));


                    AvailableRoomsList.Add(room);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }


            return AvailableRoomsList;

        }






        public bool updateReservationFromDB(BusinessEntities.IReservation reservation)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Reservations";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ReservationsData");
                DataRow findRow = ds.Tables["ReservationsData"].Rows.Find(reservation.ReservationID);
                if (findRow != null)
                {
                    //findRow[0] = reservation.ReservationID;
                    findRow[1] = reservation.CheckInDate;
                    findRow[2] = reservation.CheckOutDate;
                    findRow[3] = reservation.Adults;
                    findRow[4] = reservation.Children;
                    findRow[5] = reservation.ReservationPrice;
                    findRow[6] = reservation.PayedDeposit;
                    findRow[7] = reservation.PayedInFull;
                    findRow[8] = reservation.GuestID;
                    findRow[9] = reservation.RoomNumber;
                }
                da.Update(ds, "ReservationsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        public bool updateGuestFromDB(BusinessEntities.IGuest guest)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Guests";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "GuestsData");
                DataRow findRow = ds.Tables["GuestsData"].Rows.Find(guest.GuestID);
                if (findRow != null)
                {
                    //findRow[0] = guest.GuestID;
                    findRow[1] = guest.FirstName;
                    findRow[2] = guest.Surname;
                    findRow[3] = guest.ContactNumber;
                    findRow[4] = guest.Address;
                    findRow[5] = guest.Email;
                    findRow[6] = guest.SendMarketingInfo;
                }
                da.Update(ds, "GuestsData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }


        public virtual List<IRoomCleaningRecord> getAllRoomCleaningRecords()
        {
            List<IRoomCleaningRecord> RecordsList = new List<IRoomCleaningRecord>();
            DataSet ds;                 //Declare the DataSet object
            SqlDataAdapter da;   //Declare the DataAdapter object
            SqlCommandBuilder cb;



            try
            {
                ds = new DataSet();
                string sql = "SELECT * From RoomCleaningRecords";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RecordsData");
                int totNumRecords = ds.Tables["RecordsData"].Rows.Count;
                for (int i = 0; i < totNumRecords; i++)
                {
                    DataRow dRow = ds.Tables["RecordsData"].Rows[i];


                    IRoomCleaningRecord record = RoomCleaningRecordHotel.GetRecords      // Using factory to create the reservation entity object. ie seperating object creation from business logic
                        (Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),  //recordID
                                                       Convert.ToInt16(dRow.ItemArray.GetValue(1).ToString()), //RoomNumber
                                                        Convert.ToDateTime(dRow.ItemArray.GetValue(2).ToString()), //CleanedAt
                                                        dRow.ItemArray.GetValue(3).ToString());



                    RecordsList.Add(record);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }


            return RecordsList;

        }


        public void addNewRoomCleaningRecordToDB(IRoomCleaningRecord theRecord)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From RoomCleaningRecords";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RecordsData");
                maxRows = ds.Tables["RecordsData"].Rows.Count;
                DataRow dRow = ds.Tables["RecordsData"].NewRow();
                dRow[0] = theRecord.RecordID;
                dRow[1] = theRecord.RoomNumber;
                dRow[2] = theRecord.CleanedAt;
                dRow[3] = theRecord.Note;




                ds.Tables["RecordsData"].Rows.Add(dRow);
                da.Update(ds, "RecordsData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }


        public virtual List<IBarItems> getAllbarItems()
        {
            List<IBarItems> BarItems = new List<IBarItems>();
            DataSet ds;                 //Declare the DataSet object
            SqlDataAdapter da;   //Declare the DataAdapter object
            SqlCommandBuilder cb;

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From BarItems";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "BarItemsData");
                int totNumsBarItems = ds.Tables["BarItemsData"].Rows.Count;
                for (int i = 0; i < totNumsBarItems; i++)
                {
                    DataRow dRow = ds.Tables["BarItemsData"].Rows[i];

                    IBarItems baritem = BarItemsHotel.GetBarItems(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),  // Using a Hotel to create the Room entity object. ie seperating object creation from business logic
                                                       dRow.ItemArray.GetValue(1).ToString(),
                                                        Convert.ToDouble(dRow.ItemArray.GetValue(2).ToString()),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                       Convert.ToDouble(dRow.ItemArray.GetValue(4)));

                    BarItems.Add(baritem);
                }
                
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return BarItems;
        }

        public virtual bool updateRoomPriceInDB(IRoom room)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Rooms";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "RoomsData");
                DataRow findRow = ds.Tables["RoomsData"].Rows.Find(room.RoomNumber);
                if (findRow != null)
                {
                    findRow[0] = room.RoomNumber;
                    findRow[1] = room.BasePrice;
                    findRow[2] = room.Available;
                    findRow[3] = room.RoomType;
                    findRow[4] = room.Smoking;

                }
                da.Update(ds, "RoomsData"); //remove row from database table
                
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }


        public virtual bool checkGusetInDB(IReservation reservation)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Reservations";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ReservationData");
                DataRow findRow = ds.Tables["ReservationData"].Rows.Find(reservation.ReservationID);
                if (findRow != null)
                {
                    //findRow[0] = reservation.ReservationID;
                    findRow[1] = reservation.CheckInDate.Date;
                    findRow[2] = reservation.CheckOutDate.Date;
                    findRow[3] = reservation.Adults;
                    findRow[4] = reservation.Children;
                    findRow[5] = reservation.ReservationPrice;
                    findRow[6] = reservation.PayedDeposit;
                    findRow[7] = reservation.PayedInFull;
                    findRow[8] = reservation.GuestID;
                    findRow[9] = reservation.RoomNumber;
                    findRow[10] = reservation.CheckIn;


                }
                da.Update(ds, "ReservationData"); //remove row from database table

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);

                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }


            return true;
        }

        public virtual List<IOrders> getAllOrders()
        {
            List<IOrders> Orders = new List<IOrders>();
            DataSet ds;                 //Declare the DataSet object
            SqlDataAdapter da;   //Declare the DataAdapter object
            SqlCommandBuilder cb;

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From BarOrders";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "OrdersData");
                int totNumOrders = ds.Tables["OrdersData"].Rows.Count;
                for (int i = 0; i < totNumOrders; i++)
                {
                    DataRow dRow = ds.Tables["OrdersData"].Rows[i];

                    IOrders orders = OrdersHotel.GetOrders(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),  // Using a Hotel to create the Room entity object. ie seperating object creation from business logic
                                                       dRow.ItemArray.GetValue(1).ToString(),
                                                        Convert.ToDouble(dRow.ItemArray.GetValue(2).ToString()),
                                                        dRow.ItemArray.GetValue(3).ToString(),
                                                       Convert.ToDouble(dRow.ItemArray.GetValue(4).ToString()),
                                                      Convert.ToDateTime(dRow.ItemArray.GetValue(5).ToString()),
                                                      Convert.ToBoolean(dRow.ItemArray.GetValue(6).ToString()),
                                                      dRow.ItemArray.GetValue(7).ToString());

                    Orders.Add(orders);
                }

            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return Orders;
        }

        //------------------------------rebecca i1 manage waste-----------------------------------------------
        public virtual List<IIngredients> getAllIngredients()
        {
            List<IIngredients> Ingredients = new List<IIngredients>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From StockItems";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "IngData");
                int allIngData = ds.Tables["IngData"].Rows.Count;
                for (int i = 0; i < allIngData; i++)
                {
                    DataRow dRow = ds.Tables["IngData"].Rows[i];
                    IIngredients ingredients = IngredientsHotel.GetIngredients(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                                         dRow.ItemArray.GetValue(1).ToString(),
                                                                                         dRow.ItemArray.GetValue(2).ToString(),
                                                                        Convert.ToDouble(dRow.ItemArray.GetValue(3).ToString()),
                                                                         Convert.ToInt16(dRow.ItemArray.GetValue(4).ToString()),
                                                                                         dRow.ItemArray.GetValue(5).ToString());

                    Ingredients.Add(ingredients);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return Ingredients;


        }


        public virtual List<IMeals> getAllMealsDB()
        {
            List<IMeals> Meals = new List<IMeals>();
            
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Meals";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "MealData");
                int allMealData = ds.Tables["MealData"].Rows.Count;
                for (int i = 0; i < allMealData; i++)
                {
                    DataRow dRow = ds.Tables["MealData"].Rows[i];
                    IMeals meals = MealsHotel.GetMeals(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                           dRow.ItemArray.GetValue(1).ToString(),
                                                           Convert.ToDouble(dRow.ItemArray.GetValue(2).ToString()),
                                                           Convert.ToInt16(dRow.ItemArray.GetValue(3).ToString()));


                    Meals.Add(meals);
                }
            }
            catch (System.Exception excep)
            { 

                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
            return Meals;

        }


        public virtual List<IWaste> getAllWasteDB()
        {
            List<IWaste> Waste = new List<IWaste>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Waste";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "WasteData");
                int allWasteData = ds.Tables["WasteData"].Rows.Count;

                for (int i = 0; i < allWasteData; i++)
                {
                    DataRow dRow = ds.Tables["WasteData"].Rows[i];
                    IWaste waste = WasteHotel.GetWaste(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                       dRow.ItemArray.GetValue(1).ToString(),
                                                        Convert.ToInt16(dRow.ItemArray.GetValue(2).ToString()),
                                                        Convert.ToDouble(dRow.ItemArray.GetValue(3).ToString()),
                                                        Convert.ToDateTime(dRow.ItemArray.GetValue(4).ToString()));

                    Waste.Add(waste);
                }
            }
            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
            return Waste;

        }

        public virtual bool changeOrderStatus(IOrders status)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From BarOrders";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "OrdersData");
                DataRow findRow = ds.Tables["OrdersData"].Rows.Find(status.OrderID);

                if (findRow != null)
                {
                    findRow[0] = status.OrderID;
                    findRow[1] = status.Food;
                    findRow[2] = status.FoodPrice;
                    findRow[3] = status.Drink;
                    findRow[4] = status.DrinkPrice;
                    findRow[5] = status.Timestamp;
                    findRow[6] = status.Completed;
                    findRow[7] = status.Note;


                }
                da.Update(ds, "OrdersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        //---------------------------------------------------------------------------------------------------------------------------------


        public virtual bool updateCompletedOrders(IOrders completed)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From BarOrders";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "OrdersData");
                DataRow findRow = ds.Tables["OrdersData"].Rows.Find(completed.OrderID);
                if (findRow != null)
                {
                    findRow[0] = completed.OrderID;
                    findRow[1] = completed.Food;
                    findRow[2] = completed.FoodPrice;
                    findRow[3] = completed.Drink;
                    findRow[4] = completed.DrinkPrice;
                    findRow[5] = completed.Timestamp;
                    findRow[6] = completed.Completed;
                    findRow[7] = completed.Note;


                }
                da.Update(ds, "OrdersData"); //remove row from database table

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }






        public virtual List<IStockItem> getAllStockItems()
        {
            List<IStockItem> StockItems = new List<IStockItem>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From StockItems";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "StockItemData");
                int allStockItems = ds.Tables["StockItemData"].Rows.Count;
                for (int i = 0; i < allStockItems; i++)
                {
                    DataRow dRow = ds.Tables["StockItemData"].Rows[i];
                    IStockItem stockItems = StockItemsHotel.GetStockItems(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                                         dRow.ItemArray.GetValue(1).ToString(),
                                                                                         dRow.ItemArray.GetValue(2).ToString(),
                                                                        Convert.ToDecimal(dRow.ItemArray.GetValue(3).ToString()),
                                                                         Convert.ToInt16(dRow.ItemArray.GetValue(4).ToString()),
                                                                                         dRow.ItemArray.GetValue(5).ToString(),
                                                                                         dRow.ItemArray.GetValue(6).ToString());

                StockItems.Add(stockItems);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return StockItems;


        }


        public virtual List<IStockOrder> getAllStockOrders()
        {
            List<IStockOrder> StockOrders = new List<IStockOrder>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From StockOrders";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "StockOrdersData");
                int allStockOrders = ds.Tables["StockOrdersData"].Rows.Count;
                for (int i = 0; i < allStockOrders; i++)
                {
                    DataRow dRow = ds.Tables["StockOrdersData"].Rows[i];
                    IStockOrder stockOrders = StockOrdersHotel.GetStockOrders(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                       Convert.ToDateTime(dRow.ItemArray.GetValue(1).ToString()),
                                                                       Convert.ToDecimal(dRow.ItemArray.GetValue(2).ToString()),
                                                                                         dRow.ItemArray.GetValue(3).ToString(),
                                                                        Convert.ToBoolean(dRow.ItemArray.GetValue(4).ToString()),
                                                                         Convert.ToInt16(dRow.ItemArray.GetValue(5).ToString()));
                                                                                         

                    StockOrders.Add(stockOrders);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return StockOrders;


        }

        public virtual List<IOrderItem> getAllOrderItems()
        {
            List<IOrderItem> OrderItems = new List<IOrderItem>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From OrderItems";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "OrderItemsData");
                int allOrderItems = ds.Tables["OrderItemsData"].Rows.Count;
                for (int i = 0; i < allOrderItems; i++)
                {
                    DataRow dRow = ds.Tables["OrderItemsData"].Rows[i];
                    IOrderItem orderItems = OrderItemsHotel.GetOrderItems(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                       Convert.ToInt16(dRow.ItemArray.GetValue(1).ToString()),
                                                                                         Convert.ToInt16(dRow.ItemArray.GetValue(2).ToString()));
                                                                        


                    OrderItems.Add(orderItems);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return OrderItems;


        }
        public virtual List<IMonthlyReport> getAllMonthlyReports()
        {
            List<IMonthlyReport> MonthlyReports = new List<IMonthlyReport>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From MonthlyReport";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "MonthlyData");
                int allMonthlyReports = ds.Tables["MonthlyData"].Rows.Count;
                for (int i = 0; i < allMonthlyReports; i++)
                {
                    DataRow dRow = ds.Tables["MonthlyData"].Rows[i];
                    IMonthlyReport monthlyReports = MonthlyReportsHotel.GetMonthlyReports(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                       Convert.ToDateTime(dRow.ItemArray.GetValue(1).ToString()),
                                                                                         Convert.ToInt16(dRow.ItemArray.GetValue(2).ToString()),
                                                                                         Convert.ToDecimal(dRow.ItemArray.GetValue(3).ToString()),
                                                                                         Convert.ToInt16(dRow.ItemArray.GetValue(4).ToString()),
                                                                                         Convert.ToDecimal(dRow.ItemArray.GetValue(5).ToString()),
                                                                                         Convert.ToInt16(dRow.ItemArray.GetValue(6).ToString()),
                                                                                         Convert.ToDecimal(dRow.ItemArray.GetValue(7).ToString()));



                    MonthlyReports.Add(monthlyReports);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return MonthlyReports;


        }

        public virtual void addNewMonthlyReportToDB(IMonthlyReport aMonthlyReport)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From MonthlyReport";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "monthlyReportData");
                maxRows = ds.Tables["monthlyReportData"].Rows.Count;
                DataRow dRow = ds.Tables["monthlyReportData"].NewRow();
                dRow[1] = aMonthlyReport.Date;
                dRow[2] = aMonthlyReport.Reservations;
                dRow[3] = aMonthlyReport.ReservationIncome;
                dRow[4] = aMonthlyReport.Sales;
                dRow[5] = aMonthlyReport.SalesIncome;
                dRow[6] = aMonthlyReport.StockOrders;
                dRow[7] = aMonthlyReport.StockExpenses;



                ds.Tables["monthlyReportData"].Rows.Add(dRow);
                da.Update(ds, "monthlyReportData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public virtual void addNewStockOrderToDB(IStockOrder aStockOrder)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From StockOrders";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "stockOrderData");
                maxRows = ds.Tables["stockOrderData"].Rows.Count;
                DataRow dRow = ds.Tables["stockOrderData"].NewRow();
                dRow[1] = aStockOrder.Date;
                dRow[2] = aStockOrder.Total;
                dRow[3] = aStockOrder.Department;
                dRow[4] = aStockOrder.Completed;
                dRow[5] = aStockOrder.CreatedBy;



                ds.Tables["stockOrderData"].Rows.Add(dRow);
                da.Update(ds, "stockOrderData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public virtual void addNewOrderItemToDB(IOrderItem aOrderItem)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From OrderItems";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "orderItemData");
                maxRows = ds.Tables["orderItemData"].Rows.Count;
                DataRow dRow = ds.Tables["orderItemData"].NewRow();
                dRow[0] = aOrderItem.OrderID;
                dRow[1] = aOrderItem.ItemID;
                dRow[2] = aOrderItem.Quantity;



                ds.Tables["orderItemData"].Rows.Add(dRow);
                da.Update(ds, "orderItemData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }

        public virtual bool updateCurrentStockItemInDB(IStockItem stockItem)
        {

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From StockItems";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "StockItemsData");
                DataRow findRow = ds.Tables["StockItemsData"].Rows.Find(stockItem.ItemID);
                if (findRow != null)
                {
                    //findRow[0] = stockItem.ItemID;
                    findRow[1] = stockItem.ItemName;
                    findRow[2] = stockItem.Description;
                    findRow[3] = stockItem.Price;
                    findRow[4] = stockItem.Quantity;
                    findRow[5] = stockItem.Category;
                    findRow[6] = stockItem.Department;

                }
                da.Update(ds, "StockItemsData"); //remove row from database table

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;





        }

        public virtual bool changePassword(IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow[3] = user.Password;
                }
                da.Update(ds, "UsersData");

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        public virtual bool editUser(IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow[0] = user.FirstName;
                    findRow[1] = user.Surname;
                    findRow[2] = user.Username;
                    findRow[4] = user.UserType;
                }
                da.Update(ds, "UsersData");

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }

        public virtual List<IBistroOrders> getAllBistroOrders()
        {
            List<IBistroOrders> BistroOrders = new List<IBistroOrders>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From BistroOrders";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "BistroData");
                int allBistroOrders = ds.Tables["BistroData"].Rows.Count;
                for (int i = 0; i < allBistroOrders; i++)
                {
                    DataRow dRow = ds.Tables["BistroData"].Rows[i];
                    IBistroOrders bistroOrder = BistroOrdersHotel.GetBistroOrders(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                       Convert.ToDateTime(dRow.ItemArray.GetValue(1).ToString()),
                                                                                         Convert.ToDecimal(dRow.ItemArray.GetValue(2).ToString()),
                                                                                         Convert.ToInt16(dRow.ItemArray.GetValue(3).ToString()),
                                                                                         dRow.ItemArray.GetValue(4).ToString(),
                                                                                         Convert.ToBoolean(dRow.ItemArray.GetValue(5).ToString()));



                    BistroOrders.Add(bistroOrder);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return BistroOrders;
        }
        public virtual List<IDrinks> getAllDrinks()
        {
            List<IDrinks> Drinks = new List<IDrinks>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Drinks";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "DrinkData");
                int allDrinks = ds.Tables["DrinkData"].Rows.Count;
                for (int i = 0; i < allDrinks; i++)
                {
                    DataRow dRow = ds.Tables["DrinkData"].Rows[i];
                    IDrinks drinks = DrinksHotel.GetDrinks(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                           dRow.ItemArray.GetValue(1).ToString(),
                                                           Convert.ToDecimal(dRow.ItemArray.GetValue(2).ToString()));


                    Drinks.Add(drinks);
                }
            }
            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
            return Drinks;
        }
        public virtual List<IOrder_has_Meals> getAllOrderMeals()
        {
            List<IOrder_has_Meals> OrderMeals = new List<IOrder_has_Meals>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Order_has_Meals";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "OrderMealData");
                int allOrderMeals = ds.Tables["OrderMealData"].Rows.Count;
                for (int i = 0; i < allOrderMeals; i++)
                {
                    DataRow dRow = ds.Tables["OrderMealData"].Rows[i];
                    IOrder_has_Meals orderMeal = Order_has_MealsHotel.GetOrderMeals(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                                                    Convert.ToInt16(dRow.ItemArray.GetValue(1).ToString()),
                                                                                                    Convert.ToInt16(dRow.ItemArray.GetValue(2).ToString()),
                                                                                                    dRow.ItemArray.GetValue(3).ToString());


                    OrderMeals.Add(orderMeal);
                }
            }
            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
            return OrderMeals;
        }
        public virtual List<IOrder_has_Drinks> getAllOrderDrinks()
        {
            List<IOrder_has_Drinks> OrderDrinks = new List<IOrder_has_Drinks>();

            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Order_has_Drinks";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "OrderDrinkData");
                int allOrderDrinks = ds.Tables["OrderDrinkData"].Rows.Count;
                for (int i = 0; i < allOrderDrinks; i++)
                {
                    DataRow dRow = ds.Tables["OrderDrinkData"].Rows[i];
                    IOrder_has_Drinks orderDrink = Order_has_DrinksHotel.GetOrderDrinks(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                                                                                    Convert.ToInt16(dRow.ItemArray.GetValue(1).ToString()),
                                                                                                    Convert.ToInt16(dRow.ItemArray.GetValue(2).ToString()),
                                                                                                    dRow.ItemArray.GetValue(3).ToString());


                    OrderDrinks.Add(orderDrink);
                }
            }
            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
            return OrderDrinks;
        }
        public virtual void addNewBistroOrder(IBistroOrders aBistroOrder)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From BistroOrders";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "bistroOrderData");
                maxRows = ds.Tables["bistroOrderData"].Rows.Count;
                DataRow dRow = ds.Tables["bistroOrderData"].NewRow();
                dRow[1] = aBistroOrder.OrderDate;
                dRow[2] = aBistroOrder.OrderTotal;
                dRow[3] = aBistroOrder.OrderMadeBy;
                dRow[4] = aBistroOrder.OrderNote;
                dRow[5] = aBistroOrder.OrderCompleted;



                ds.Tables["bistroOrderData"].Rows.Add(dRow);
                da.Update(ds, "bistroOrderData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public virtual void addNewDrink(IDrinks aDrink)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Drinks";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "drinksData");
                maxRows = ds.Tables["drinksData"].Rows.Count;
                DataRow dRow = ds.Tables["drinksData"].NewRow();
                dRow[1] = aDrink.DrinkName;
                dRow[2] = aDrink.DrinkPrice;



                ds.Tables["drinksData"].Rows.Add(dRow);
                da.Update(ds, "drinksData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public virtual void addNewOrderDrink(IOrder_has_Drinks anOrderDrink)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Order_has_Drinks";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "orderDrinksData");
                maxRows = ds.Tables["orderDrinksData"].Rows.Count;
                DataRow dRow = ds.Tables["orderDrinksData"].NewRow();
                dRow[0] = anOrderDrink.OrderID;
                dRow[1] = anOrderDrink.DrinkID;
                dRow[2] = anOrderDrink.Quantity;
                dRow[3] = anOrderDrink.Status;



                ds.Tables["orderDrinksData"].Rows.Add(dRow);
                da.Update(ds, "orderDrinksData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public virtual void addNewOrderMeal(IOrder_has_Meals anOrderMeal)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Order_has_Meals";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "orderMealsData");
                maxRows = ds.Tables["orderMealsData"].Rows.Count;
                DataRow dRow = ds.Tables["orderMealsData"].NewRow();
                dRow[0] = anOrderMeal.OrderID;
                dRow[1] = anOrderMeal.DishID;
                dRow[2] = anOrderMeal.Quantity;
                dRow[3] = anOrderMeal.Status;



                ds.Tables["orderMealsData"].Rows.Add(dRow);
                da.Update(ds, "orderMealsData");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public virtual bool editBistroOrder(IBistroOrders aBistroOrder)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From BistroOrders";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "BistroOrdersData");
                DataRow findRow = ds.Tables["BistroOrdersData"].Rows.Find(aBistroOrder.OrderID);
                if (findRow != null)
                {
                    findRow[1] = aBistroOrder.OrderDate;
                    findRow[2] = aBistroOrder.OrderTotal;
                    findRow[3] = aBistroOrder.OrderMadeBy;
                    findRow[4] = aBistroOrder.OrderNote;
                    findRow[5] = aBistroOrder.OrderCompleted;
                }
                da.Update(ds, "BistroOrdersData");

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public virtual bool editOrderDrink(IOrder_has_Drinks anOrderDrink)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Order_has_Drinks";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "OrderDrinksData");
                object[] findItem = new object[2];
                findItem[0] = anOrderDrink.OrderID;
                findItem[1] = anOrderDrink.DrinkID;
                DataRow findRow = ds.Tables["OrderDrinksData"].Rows.Find(findItem);
                if (findRow != null)
                {
                    findRow[0] = anOrderDrink.OrderID;
                    findRow[1] = anOrderDrink.DrinkID;
                    findRow[2] = anOrderDrink.Quantity;
                    findRow[3] = anOrderDrink.Status;
                }
                da.Update(ds, "OrderDrinksData");

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
        public virtual bool editOrderMeal(IOrder_has_Meals anOrderMeal)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Order_has_Meals";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "OrderMealsData");
                object[] findItem = new object[2];
                findItem[0] = anOrderMeal.OrderID;
                findItem[1] = anOrderMeal.DishID;
                DataRow findRow = ds.Tables["OrderMealsData"].Rows.Find(findItem);
                if (findRow != null)
                {
                    findRow[0] = anOrderMeal.OrderID;
                    findRow[1] = anOrderMeal.DishID;
                    findRow[2] = anOrderMeal.Quantity;
                    findRow[3] = anOrderMeal.Status;
                }
                da.Update(ds, "OrderMealsData");

            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }
    }
}
