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
            Model.GetAllOrders();
            foreach (Orders order in Model.OrdersList)
            {
                if (order.Completed == false)
                {
                    listBox3.Items.Add(string.Format("{0}  €{1} | {2}  €{3} | {4}", order.Food, order.FoodPrice, order.Drink, order.DrinkPrice, order.Timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff")));
                }
                if (order.Completed == true)
                {
                    listBox1.Items.Add(string.Format("{0}  €{1} | {2}  €{3} | {4}", order.Food, order.FoodPrice, order.Drink, order.DrinkPrice, order.Timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff")));
                }
            }
         
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            string selectedItemText;
            selectedItemText = listBox3.SelectedItem.ToString();
            listBox1.Items.Add(selectedItemText);

            foreach (Orders order in Model.OrdersList)
            {
                string std = string.Format("{0}  €{1} | {2}  €{3} | {4}", order.Food, order.FoodPrice, order.Drink, order.DrinkPrice, order.Timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                if (listBox3.SelectedItem.ToString() == std )
                {
                    order.Completed = true;
                   
                    Model.UpdateOrderComplete(order);
                }
            }
            selectedItemText = listBox3.SelectedItem.ToString();
            listBox3.Items.Remove(selectedItemText);
            MessageBox.Show("Order Completed");

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
            string selectedItemText;
            selectedItemText = listBox1.SelectedItem.ToString();
            listBox3.Items.Add(selectedItemText);

            

            foreach (Orders order in Model.OrdersList)
            {
                string std = string.Format("{0}  €{1} | {2}  €{3} | {4}", order.Food, order.FoodPrice, order.Drink, order.DrinkPrice, order.Timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff"));

                if (listBox1.SelectedItem.ToString() == std)
                {
                    order.Completed = false;
                    Model.UpdateOrderComplete(order);

                   

                }
            }
            selectedItemText = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(selectedItemText);
            MessageBox.Show("Order Not Completed");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                foreach (Orders order in Model.OrdersList)
                {
                    string std = string.Format("{0}  €{1} | {2}  €{3} | {4}", order.Food, order.FoodPrice, order.Drink, order.DrinkPrice, order.Timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    if (listBox3.SelectedItem.ToString() == std)
                    {
                        textBoxNoteArea.Text = order.Note;
                       
                    }
                }




            }
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            foreach (Orders order in Model.OrdersList)
            {
                string std = string.Format("{0}  €{1} | {2}  €{3} | {4}", order.Food, order.FoodPrice, order.Drink, order.DrinkPrice, order.Timestamp.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                if (listBox3.SelectedItem.ToString() == std)
                {
                    order.Note = Convert.ToString(textBoxNoteArea.Text);
                    Model.UpdateOrderComplete(order);

                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            formManageOrder form = new formManageOrder(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }
    }
}
