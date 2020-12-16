using BusinessLayer;
using System;
using BusinessEntities;
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
    public partial class formManageOrder : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formManageOrder(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void formManageOrder_Load(object sender, EventArgs e)
        {


            
        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbOrderStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.GetAllOrders();
            if (cbOrderStat.SelectedIndex ==0)
            {
                foreach (Orders order in Model.OrdersList)
                {
                    string ID = order.OrderID.ToString();
                    if(ID == tbOrderID.Text)
                    {
                        order.Completed = false; //order is not complete
                    }
                }
            }

            if (cbOrderStat.SelectedIndex == 1)
            {
                foreach (Orders order in Model.OrdersList)
                {
                    string ID = order.OrderID.ToString();
                    if (ID == tbOrderID.Text)
                    {
                        order.Completed = true; //order is complete
                        
                      
                    }
                }
                
            }
        }
    }
}
