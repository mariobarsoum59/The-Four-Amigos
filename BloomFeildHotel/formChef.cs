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
        
        public formChef()
        {
            InitializeComponent();
            
        }
        
        private void formChef_Load(object sender, EventArgs e)
        {

        }

        private void lblManagerMenuTag_Click(object sender, EventArgs e)
        {

        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            formViewOrders form = new formViewOrders();
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnViewOrders_Click_1(object sender, EventArgs e)
        {

        }
    }
}
