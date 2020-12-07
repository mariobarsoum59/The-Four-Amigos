using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BarItems : IBarItems
    {
        private int baritemID;
        private string food;
        private double foodprice;
        private string drink;
        private double drinkprice;


        public int BarItemID
        {
            get
            {
                return baritemID;
            }
            set
            {
                baritemID = value;
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
        public BarItems()
        {
            throw new System.NotImplementedException();
        }
        public BarItems(int BarItemID, string Food, double FoodPrice, string Drink, double Drinkprice)
        {
            this.baritemID = BarItemID;
            this.food = Food;
            this.foodprice = FoodPrice;
            this.drink = Drink;
            this.drinkprice = Drinkprice;



        }

    }
}