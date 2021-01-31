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


        List<ICleaner> getAllCleaner();

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

        List<IIngredients> getAllIngredients();

        List<IMeals> getAllMealsDB();

        List<IWaste> getAllWasteDB();

        bool changeOrderStatus(BusinessEntities.IOrders status);

        List<IStockItem> getAllStockItems();
        List<IStockOrder> getAllStockOrders();
        List<IOrderItem> getAllOrderItems();
        List<IMonthlyReport> getAllMonthlyReports();
        void addNewMonthlyReportToDB(IMonthlyReport aMonthlyReport);
        void addNewOrderItemToDB(IOrderItem aOrderItem);
        void addNewStockOrderToDB(IStockOrder aStockOrder);
        bool updateCurrentStockItemInDB(BusinessEntities.IStockItem stockItem);

        bool changePassword(IUser user);
        bool editUser(IUser user);

        List<IBistroOrders> getAllBistroOrders();
        List<IDrinks> getAllDrinks();
        List<IOrder_has_Meals> getAllOrderMeals();
        List<IOrder_has_Drinks> getAllOrderDrinks();
        void addNewBistroOrder(IBistroOrders aBistroOrder);
        void addNewDrink(IDrinks aDrink);
        void addNewOrderDrink(IOrder_has_Drinks anOrderDrink);
        void addNewOrderMeal(IOrder_has_Meals anOrderMeal);
        bool editBistroOrder(IBistroOrders aBistroOrder);
        bool editOrderDrink(IOrder_has_Drinks anOrderDrink);
        bool editOrderMeal(IOrder_has_Meals anOrderMeal);
        bool deleteBistroOrder(IBistroOrders aBistroOrder);
        bool deleteOrderDrink(IOrder_has_Drinks anOrderDrink);
        bool deleteOrderMeal(IOrder_has_Meals anOrderMeal);
        void addPrepMeal(IMeals aPrepMeal);

        void wasteToDB(IWaste waste);
    }
}
