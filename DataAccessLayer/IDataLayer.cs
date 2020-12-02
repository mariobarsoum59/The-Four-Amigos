using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void addNewUserToDB(BusinessEntities.IUser theUser);
        void closeConnection();
        System.Collections.ArrayList GetAllUsers();
        System.Data.SqlClient.SqlConnection getConnection();
        void openConnection();
        bool deleteUserFromDB(BusinessEntities.IUser user);

        bool deleteReservationFromDB(BusinessEntities.IReservation reservation);

        List<IRoom> getAllRooms();

        List<IGuest> getAllGuests();

        List<IReservation> getAllReservations();

        List<IRoom> getRoomForDates(string CheckIn, string CheckOut);

        void addNewGuestToDB(BusinessEntities.IGuest theGuest);
        void addNewReservationToDB(BusinessEntities.IReservation theReservation);
        bool updateReservationFromDB(BusinessEntities.IReservation reservation);
        bool updateGuestFromDB(BusinessEntities.IGuest guest);

    }
}
