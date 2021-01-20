using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Drinks : IDrinks
    {
        #region Instance Properties

        private int drinkID;
        private string drinkName;
        private decimal drinkPrice;
        #endregion

        public int DrinkID
        {
            get
            {
                return drinkID;
            }
            set
            {
                drinkID = value;
            }
        }
        public string DrinkName
        {
            get
            {
                return drinkName;
            }
            set
            {
                drinkName = value;
            }
        }
        public decimal DrinkPrice
        {
            get
            {
                return drinkPrice;
            }
            set
            {
                drinkPrice = value;
            }
        }

        public Drinks()
        {

        }
        public Drinks(int DrinkID, string DrinkName, decimal DrinkPrice)
        {
            this.drinkID = DrinkID;
            this.drinkName = DrinkName;
            this.drinkPrice = DrinkPrice;
        }
    }
}
