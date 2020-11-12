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






    }
}
