using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class Ingredients : BusinessEntities.IIngredients
    { 

        #region Instance Properties

        private int itemID;
        private string itemName;
        private string desc;
        private double price;
        private int quantity;
        private string category;
        #endregion
    
        public int ItemID
        {
            get
            {
                return itemID;
            }
            set
            {
                itemID = value;
            }
        }


        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
            }
        }

        public string Description
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
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


        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }


        public Ingredients()
        {
            throw new System.NotImplementedException();
        }

        public Ingredients(int ItemID, string ItemName, string Description, double Price, int Quantity, string Category)
        {
            this.itemID = ItemID;
            this.itemName = ItemName;
            this.desc = Description;
            this.price = Price;
            this.quantity = Quantity;
            this.category = Category;
        }

    }
}

