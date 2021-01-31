using BloomFeildHotel.Properties;
using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloomFeildHotel
{
    public partial class ViewOrdersBarStaff : Form
    {
        private FormContainer fc;
        private IModel Model;
        public ViewOrdersBarStaff(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void lblAddDrink_Click(object sender, EventArgs e)
        {

        }

        private void ViewOrdersBarStaff_Load(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox1.Items.Clear();
            Model.GetAllMeals();
            Model.GetAllDrinks();
            Model.GetAllBistroOrders();
            Model.GetAllOrderDrinks();
            Model.GetAllOrderMeals();
            foreach (IBistroOrders orders in Model.BistroOrdersList)
            {
                if (orders.OrderCompleted == false)
                {
                    listBox3.Items.Add(string.Format("Order ID: {0} | Order Date: {1} | Order Made By User ID: {2}", orders.OrderID, orders.OrderDate,orders.OrderMadeBy));
                }
                if (orders.OrderCompleted == true)
                {
                    listBox1.Items.Add(string.Format("Order ID: {0} | Order Date: {1} | Order Made By User ID: {2}", orders.OrderID, orders.OrderDate, orders.OrderMadeBy));
                }
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to Complete!");
            }
            else
            {
                string selectedItemText;
                selectedItemText = listBox3.SelectedItem.ToString();
                listBox1.Items.Add(selectedItemText);


                foreach (IBistroOrders orders in Model.BistroOrdersList)
                {
                        string std = string.Format("Order ID: {0} | Order Date: {1} | Order Made By User ID: {2}", orders.OrderID, orders.OrderDate, orders.OrderMadeBy);
                        if (listBox3.SelectedItem.ToString() == std)
                        {
                            orders.OrderCompleted = true;
                            Model.editBistroOrder(orders);
                        }

                }

                selectedItemText = listBox3.SelectedItem.ToString();
                listBox3.Items.Remove(selectedItemText);
                MessageBox.Show("Order Completed");
            }
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            formBarStaff form = new formBarStaff(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to Remove from completion !");
            }
            else
            {
                string selectedItemText;
                selectedItemText = listBox1.SelectedItem.ToString();
                listBox3.Items.Add(selectedItemText);
                foreach (IBistroOrders orders in Model.BistroOrdersList)
                {
                    string std = string.Format("Order ID: {0} | Order Date: {1} | Order Made By User ID: {2}", orders.OrderID, orders.OrderDate, orders.OrderMadeBy);
                    if (listBox1.SelectedItem.ToString() == std)
                    {
                        orders.OrderCompleted = false;
                        Model.editBistroOrder(orders);
                    }

                }
                selectedItemText = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(selectedItemText);
                MessageBox.Show("Order Not Completed");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                
                foreach (IBistroOrders orders in Model.BistroOrdersList)
                {

                  string std = string.Format("Order ID: {0} | Order Date: {1} | Order Made By User ID: {2}", orders.OrderID, orders.OrderDate, orders.OrderMadeBy);
                   if (listBox3.SelectedItem.ToString() == std)
                    {
                        textBoxNoteArea.Text = orders.OrderNote;

                    }
                }
            }
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
           
            foreach (IBistroOrders orders in Model.BistroOrdersList)
            {

               string std = string.Format("Order ID: {0} | Order Date: {1} | Order Made By User ID: {2}", orders.OrderID, orders.OrderDate, orders.OrderMadeBy);
               if (listBox3.SelectedItem.ToString() == std)
                {
                  orders.OrderNote = Convert.ToString(textBoxNoteArea.Text);
                  Model.editBistroOrder(orders);

                }

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            IBistroOrders bistroOrder = new BistroOrders();
            Model.GetAllBistroOrders();
            foreach (IBistroOrders orders in Model.BistroOrdersList)
            {
                string std = string.Format("Order ID: {0} | Order Date: {1} | Order Made By User ID: {2}", orders.OrderID, orders.OrderDate, orders.OrderMadeBy);
                if (listBox3.SelectedItem.ToString() == std)
                {
                    bistroOrder = orders;
                }
            }
            formManageOrder form = new formManageOrder(fc, Model, bistroOrder);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            formViewReceipt form = new formViewReceipt(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }
    }
}
