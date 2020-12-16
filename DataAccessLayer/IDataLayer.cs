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

        List<IRoomCleaningRecord> getAllRoomCleaningRecords();

        void addNewGuestToDB(BusinessEntities.IGuest theGuest);
        void addNewReservationToDB(BusinessEntities.IReservation theReservation);

        void addNewRoomCleaningRecordToDB(BusinessEntities.IRoomCleaningRecord theRecord);
        bool updateReservationFromDB(BusinessEntities.IReservation reservation);
        bool updateGuestFromDB(BusinessEntities.IGuest guest);


        List<IBarItems> getAllbarItems();

        List<IOrders> getAllOrders();

        bool updateRoomPriceInDB(BusinessEntities.IRoom room);

        bool checkGusetInDB(BusinessEntities.IReservation reservation);

        bool updateCompletedOrders(BusinessEntities.IOrders completed);


        //-------------------------- rebecca ----------------------------------------------------
        List<IIngredients> getAllIngredients();

        List<IMeals> getAllMealsDB();

        List<IWaste> getAllWasteDB();

        bool changeOrderStatus(BusinessEntities.IOrders status);
        //--------------------------------------------------------------------------------------

        List<IStockItem> getAllStockItems();
        List<IStockOrder> getAllStockOrders();
        List<IOrderItem> getAllOrderItems();
        List<IMonthlyReport> getAllMonthlyReports();
        void addNewMonthlyReportToDB(IMonthlyReport aMonthlyReport);

        bool updateCurrentStockItemInDB(BusinessEntities.IStockItem stockItem);

    }
}
