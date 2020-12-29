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
    public partial class formViewStock : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formViewStock(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDepartmentStock.Items.Clear();
            String department = cbDepartment.Text;
            List<String> categories = new List<String>();
            cbCategory.Items.Clear();
            Model.GetAllStockItems();
            foreach (IStockItem item in Model.StockItemsList)
            {
                if(item.Department == department)
                {
                    if (!categories.Contains(item.Category))
                    {
                        categories.Add(item.Category);
                    }
                    String str = "Item ID: " + item.ItemID.ToString() + " | Name: " + item.ItemName + " | Description: " + item.Description + " | Price: €" + item.Price.ToString() + " | Quantity: " + item.Quantity.ToString() + " | Category: " + item.Category + " | Department: " + item.Department;
                    lbDepartmentStock.Items.Add(str);
                }
            }
            foreach (String category in categories)
            {
                cbCategory.Items.Add(category);
            }
        }

        private void formViewStock_Load(object sender, EventArgs e)
        {
            lbDepartmentStock.Items.Clear();
            cbDepartment.Items.Clear();
            cbCategory.Items.Clear();
            Model.GetAllStockItems();
            List<String> departments = new List<String>();
            List<String> categories = new List<String>();
            foreach (IStockItem item in Model.StockItemsList)
            {
                if(!departments.Contains(item.Department))
                {
                    departments.Add(item.Department);
                }
                if (!categories.Contains(item.Category))
                {
                    categories.Add(item.Category);
                }
            }
            foreach (String department in departments)
            {
                cbDepartment.Items.Add(department);
            }
            foreach(String category in categories)
            {
                cbCategory.Items.Add(category);
            }
                foreach (IStockItem item in Model.StockItemsList)
            {
                String str = "Item ID: " + item.ItemID.ToString() + " | Name: " + item.ItemName + " | Description: " + item.Description + " | Price: €" + item.Price.ToString() + " | Quantity: " + item.Quantity.ToString() + " | Category: " + item.Category + " | Department: " + item.Department;
                lbDepartmentStock.Items.Add(str);
            }
        }

        private void lbDepartmentStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            lbDepartmentStock.Items.Clear();
            cbDepartment.Items.Clear();
            cbCategory.Items.Clear();
            Model.GetAllStockItems();
            List<String> departments = new List<String>();
            List<String> categories = new List<String>();
            foreach (IStockItem item in Model.StockItemsList)
            {
                if (!departments.Contains(item.Department))
                {
                    departments.Add(item.Department);
                }
                if (!categories.Contains(item.Category))
                {
                    categories.Add(item.Category);
                }
            }
            foreach (String department in departments)
            {
                cbDepartment.Items.Add(department);
            }
            foreach (String category in categories)
            {
                cbCategory.Items.Add(category);
            }
            foreach (IStockItem item in Model.StockItemsList)
            {
                String str = "Item ID: " + item.ItemID.ToString() + " | Name: " + item.ItemName + " | Description: " + item.Description + " | Price: €" + item.Price.ToString() + " | Quantity: " + item.Quantity.ToString() + " | Category: " + item.Category + " | Department: " + item.Department;
                lbDepartmentStock.Items.Add(str);
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDepartmentStock.Items.Clear();
            String category = cbCategory.Text;
            Model.GetAllStockItems();
            if (cbDepartment.SelectedIndex != -1)
            {
                String department = cbDepartment.Text;
                foreach (IStockItem item in Model.StockItemsList)
                {
                    if (item.Department == department && item.Category == category)
                    {
                        String str = "Item ID: " + item.ItemID.ToString() + " | Name: " + item.ItemName + " | Description: " + item.Description + " | Price: €" + item.Price.ToString() + " | Quantity: " + item.Quantity.ToString() + " | Category: " + item.Category + " | Department: " + item.Department;
                        lbDepartmentStock.Items.Add(str);
                    }
                }
            }
            else
            {
                foreach (IStockItem item in Model.StockItemsList)
                {
                    if (item.Category == category)
                    {
                        String str = "Item ID: " + item.ItemID.ToString() + " | Name: " + item.ItemName + " | Description: " + item.Description + " | Price: €" + item.Price.ToString() + " | Quantity: " + item.Quantity.ToString() + " | Category: " + item.Category + " | Department: " + item.Department;
                        lbDepartmentStock.Items.Add(str);
                    }
                }
            }
        }
    }
}
