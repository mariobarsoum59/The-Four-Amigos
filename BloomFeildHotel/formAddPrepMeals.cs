using System;
using BusinessEntities;
using BusinessLayer;
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
    public partial class formAddPrepMeals : Form
    {
        private FormContainer fc;
        private IModel Model;

        public formAddPrepMeals(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = 0;
            double price = Convert.ToDouble(txtPrice.Text);
            if (Model.addPrepMeal(id, txtMealName.Text, price, Convert.ToInt32(txtMealAmt.Text)))
            {
                MessageBox.Show("Meal Added");
            }
        }
    }
}
