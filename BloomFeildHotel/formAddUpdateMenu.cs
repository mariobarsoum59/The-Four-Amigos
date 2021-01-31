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
    public partial class formAddUpdateMenu : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formAddUpdateMenu(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }
        private void formAddUpdateMenu_Load(object sender, EventArgs e)
        {
            Model.GetAllMeals();
            Model.GetAllDrinks();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formStockManager form = new formStockManager(fc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnSubmitDrink_Click(object sender, EventArgs e)
        {
            
                if (textDrinkName.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter a drink name!");
                }
                else if (textDrinkPrice.Text == String.Empty)
                {
                    MessageBox.Show("Please enter a drink price!");
                }

                else
                {
                    Model.createDrink(textDrinkName.Text, Convert.ToDecimal(textDrinkPrice.Text));
                    MessageBox.Show("Drink created");
                }

        }

        private void btnNewMeal_Click(object sender, EventArgs e)
        {
            

            if (textBoxMeal.Text == String.Empty)
            {
                MessageBox.Show("Please Enter a Meal name!");
            }
            else if (textBoxMealPrice.Text == String.Empty)
            {
                MessageBox.Show("Please enter a Meal price!");
            }
            else if(textBoxQuantity.Text == String.Empty)
            {
                MessageBox.Show("Please enter a Quantity!");
            }
            else
            {
                int id = 0;
                double price = Convert.ToDouble(textBoxMealPrice.Text);
                Model.addPrepMeal(id, textBoxMeal.Text, price, Convert.ToInt32(textBoxQuantity.Text));
                MessageBox.Show("Meal Added");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textDrinkName.Clear();
            textDrinkPrice.Clear();
            textBoxMeal.Clear();
            textBoxMealPrice.Clear();
            textBoxQuantity.Clear();
        }
    }
}
