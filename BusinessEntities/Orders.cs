using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Orders : IOrders
    {
        private int orderID;
        private string food;
        private double foodprice;
        private string drink;
        private double drinkprice;
        private DateTime timestamp;
        private bool completed;
        private string note;


        public int OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
        }
        public string Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
            }
        }

        public double FoodPrice
        {
            get
            {
                return foodprice;
            }
            set
            {
                foodprice = value;
            }
        }
        public string Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
            }
        }
        public double DrinkPrice
        {
            get
            {
                return drinkprice;
            }
            set
            {
                drinkprice = value;
            }
        }

        public DateTime Timestamp
        {
            get
            {
                return timestamp;
            }
            set
            {
                timestamp = value;
            }
        }
        public bool Completed
        {
            get
            {
                return completed;
            }
            set
            {
                completed = value;
            }
        }
        public string Note
        {
            get
            {
                return note;
            }
            set
            {
                note = value;
            }
        }
        public Orders()
        {
            throw new System.NotImplementedException();
        }
        public Orders(int OrderID, string Food, double FoodPrice, string Drink, double Drinkprice, DateTime Timestamp,  bool Completed, string Note)
        {
            this.orderID = OrderID;
            this.food = Food;
            this.foodprice = FoodPrice;
            this.drink = Drink;
            this.drinkprice = Drinkprice;
            this.timestamp = Timestamp;
            this.completed = Completed;
            this.note = Note;



        }

    }
}