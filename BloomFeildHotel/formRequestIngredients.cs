using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;

namespace BloomFeildHotel
{
    public partial class formRequestIngredients : Form
    {
        private FormContainer fc;
        private IModel Model;
        List<IStockItem> IngredientOrder;
        public formRequestIngredients(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbAvailableIngredients.SelectedIndex == -1 || numQty.Value < 1)
            {
                MessageBox.Show("Please select an item and enter a quantity");
            }
            else
            {
                String str = lbAvailableIngredients.SelectedItem.ToString();
                int qty = Convert.ToInt32(numQty.Value);
                numQty.Value = 0;
                str += " | Quantity: " + qty;
                lbIngredientsOrder.Items.Add(str);
                String[] array = str.Split(' ');
                int id = Convert.ToInt32(array[2]);
                foreach (IStockItem item in Model.StockItemsList)
                {
                    if (id == item.ItemID)
                    {
                        IStockItem ingredient = item;
                        ingredient.Quantity = qty;
                        IngredientOrder.Add(ingredient);
                    }
                }
            }
        }

        private void formRequestIngredients_Load(object sender, EventArgs e)
        {
            IngredientOrder = new List<IStockItem>();
            lbAvailableIngredients.Items.Clear();
            lbIngredientsOrder.Items.Clear();
            cbCategories.Items.Clear();
            Model.GetAllStockItems();
            List<String> categories = new List<String>();
            foreach (IStockItem item in Model.StockItemsList)
            {
                if (item.Department == "Kitchen")
                {
                    if (!categories.Contains(item.Category))
                    {
                        categories.Add(item.Category);
                    }
                }
            }
            foreach (String category in categories)
            {
                cbCategories.Items.Add(category);
            }
            foreach (IStockItem item in Model.StockItemsList)
            {
                if(item.Department == "Kitchen")
                {
                    String str = "Item ID: " + item.ItemID.ToString() + " | Name: " + item.ItemName + " | Price: €" + item.Price.ToString() + " | Description: " + item.Description + " | Category: " + item.Category;
                    lbAvailableIngredients.Items.Add(str);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            IngredientOrder.Clear();
            lbIngredientsOrder.Items.Clear();
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAvailableIngredients.Items.Clear();
            String category = cbCategories.Text;
            Model.GetAllStockItems();
            foreach (IStockItem item in Model.StockItemsList)
            {
                if (item.Category == category)
                {
                    String str = "Item ID: " + item.ItemID.ToString() + " | Name: " + item.ItemName + " | Price: €" + item.Price.ToString() + " | Description: " + item.Description + " | Category: " + item.Category;
                    lbAvailableIngredients.Items.Add(str);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lbIngredientsOrder.Items.Clear();
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            decimal total = 0.00m;
            foreach(IStockItem item in IngredientOrder)
            {
                total += item.Price * item.Quantity;
            }
            Model.GetAllStockOrders();
            List<IStockOrder> oldOrders = Model.StockOrdersList;
            if (Model.createStockOrder(date, total, "Kitchen", Model.CurrentUser.UserID))
            {
                Model.GetAllStockOrders();
                List<IStockOrder> newOrders = Model.StockOrdersList;
                List<IStockOrder> newList = newOrders.Except(oldOrders).ToList();
                IStockOrder currentOrder = new StockOrder();
                foreach (IStockOrder order in newList)
                {
                    currentOrder = order;
                }
                bool fail = false;
                foreach(IStockItem item in IngredientOrder)
                {
                    if(!Model.createOrderItem(currentOrder.OrderID, item.ItemID, item.Quantity))
                    {
                        MessageBox.Show("There was an error creating the Stock Order");
                        fail = true;
                        break;
                    }
                }
                if(!fail)
                {
                    MessageBox.Show("The Stock Order has been created");
                }
                else
                {
                    MessageBox.Show("There was an error creating the Stock Order");
                }
            }
            else
            {
                MessageBox.Show("There was an error creating the Stock Order");
            }
            IngredientOrder.Clear();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lbIngredientsOrder.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to remove");
            }
            else
            {
                String str = lbIngredientsOrder.SelectedItem.ToString();
                lbIngredientsOrder.Items.RemoveAt(lbIngredientsOrder.SelectedIndex);
                String[] array = str.Split(' ');
                int id = Convert.ToInt32(array[2]);
                foreach (IStockItem item in IngredientOrder.ToList())
                {
                    if (id == item.ItemID)
                    {
                        IngredientOrder.Remove(item);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            lbAvailableIngredients.Items.Clear();
            cbCategories.Items.Clear();
            Model.GetAllStockItems();
            List<String> categories = new List<String>();
            foreach (IStockItem item in Model.StockItemsList)
            {
                if (item.Department == "Kitchen")
                {
                    if (!categories.Contains(item.Category))
                    {
                        categories.Add(item.Category);
                    }
                }
            }
            foreach (String category in categories)
            {
                cbCategories.Items.Add(category);
            }
            foreach (IStockItem item in Model.StockItemsList)
            {
                if (item.Department == "Kitchen")
                {
                    String str = "Item ID: " + item.ItemID.ToString() + " | Name: " + item.ItemName + " | Price: €" + item.Price.ToString() + " | Description: " + item.Description + " | Category: " + item.Category;
                    lbAvailableIngredients.Items.Add(str);
                }
            }
        }
    }
}
