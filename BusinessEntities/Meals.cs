using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public class Meals : IMeals
    {
        #region Instance Properties

        private int dishID;
        private string dishName;
        private double price;
        private int quantity;
        #endregion


        public int DishID
        {
            get
            {
                return dishID;
            }
            set
            {
                dishID = value;
            }
        }


        public string DishName
        {
            get
            {
                return dishName;
            }
            set
            {
                dishName = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public Meals()
        {
            throw new System.NotImplementedException();
        }

        public Meals(int DishID, string DishName, double Price, int Quantity)
        {
            this.dishID = DishID;
            this.dishName = DishName;
            this.price = Price;
            this.quantity = Quantity;

        }

    }
}
