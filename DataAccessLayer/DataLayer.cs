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
                da.Fill(ds, "GuestsData");
                int totNumsGuest = ds.Tables["GuestsData"].Rows.Count;
                for (int i = 0; i < totNumsGuest; i++)
                {
                    DataRow dRow = ds.Tables["GuestsData"].Rows[i];


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
                                                       Convert.ToInt16((dRow.ItemArray.GetValue(9)))); //RoomNum


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


    }
}
