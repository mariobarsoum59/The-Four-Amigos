using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace BloomFeildHotel
{
    public partial class formChef : Form
    {

        private FormContainer fc;
        private IModel Model;
        public formChef(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void formChef_Load(object sender, EventArgs e)
        {
            lblChefMenu.Text = "Hi " + Model.CurrentUser.FirstName;
        }

        

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            formViewOrdersChef form = new formViewOrdersChef(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnChangeOrderStatus_Click(object sender, EventArgs e)
        {
            formManageOrder form = new formManageOrder(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }
    }
}
