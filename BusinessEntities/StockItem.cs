using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class StockItem : IStockItem
    {
        private int itemID;
        private String itemName;
        private String desc;
        private decimal price;
        private int quantity;
        private String category;
        private String department;

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


        public String ItemName
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

        public String Description
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


        public decimal Price
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


        public String Category
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
        public String Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }


        public StockItem()
        {
            throw new System.NotImplementedException();
        }

        public StockItem(int ItemID, String ItemName, String Description, decimal Price, int Quantity, String Category, String Department)
        {
            this.itemID = ItemID;
            this.itemName = ItemName;
            this.desc = Description;
            this.price = Price;
            this.quantity = Quantity;
            this.category = Category;
            this.department = Department;
        }
    }
}
