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

        bool addNewGuest(string FirstName, string Surname, string ContactNumber, string Address, string Email, bool SendMarketingInfo);

        bool addNewReservation(DateTime CheckInDate, DateTime CheckOutDate, int Adults, int Children, double ReservationPrice, bool PayedDeposit, bool PayedInFull, int GuestID, int RoomNumber);

        bool addNewRoomCleaningRecord(int RoomNumber, DateTime CleanedAt, string Note);

        BusinessEntities.User CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        string getUserTypeForCurrentuser();
        bool login(string username, string password);

        bool deleteUser(IUser user);

        bool deleteReservation(IReservation reservation);

        bool updateReservation(IReservation reservation);
        bool updateGuest(IGuest guest);

        void tearDown();
        System.Collections.ArrayList UserList { get; }
        bool PasswordCheck(string password);

        List<IRoom> RoomsList { get; set; }
        void GetAllRooms();

        List<IGuest> GuestsList { get; set; }
        void GetAllGuests();


        List<IRoomCleaningRecord> RoomCleaningRecordsList { get; set; }

        void GetAllRoomCleaningRecords();

        List<IReservation> ReservationsList { get; set; }

        void GetAllReservations();
        List<IRoom> RoomsOnGivenDates { get; set; }
        int SelectedGuestID { get; set; }

        void getSelectedGuest(int guestid);
        void GetRoomsForDates(string CheckIn, string CheckOut);

        List<IBarItems> BarItemsList { get; set; }
        void GetAllBarItems();

    }
}
