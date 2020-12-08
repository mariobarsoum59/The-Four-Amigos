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
    public partial class formBarStaff : Form
    {
        private FormContainer fc;
        private IModel Model;
        public  formBarStaff(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void formBarStaff_Load(object sender, EventArgs e)
        {
            lblBarStaffMenu.Text = "Hi " + Model.CurrentUser.FirstName;
        }
        

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            formSales form = new formSales(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void lblBarStaffMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrdersBarStaff form = new ViewOrdersBarStaff(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }
    }
}
