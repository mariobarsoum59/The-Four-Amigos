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
    public partial class formViewOrdersChef : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formViewOrdersChef(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void formViewOrdersChef_Load(object sender, EventArgs e)
        {
            Model.GetAllOrders();
            foreach (Orders order in Model.OrdersList)
            {

                listBoxOrders.Items.Add(string.Format("{0} | €{1} |", order.Food, order.FoodPrice));
               
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formChef form = new formChef(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChangeOrderStatus_Click(object sender, EventArgs e)
        {
            formManageOrder form = new formManageOrder(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
