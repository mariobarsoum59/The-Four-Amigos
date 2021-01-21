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
    public partial class formSales : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formSales(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }


        private void formSales_Load(object sender, EventArgs e)
        {
            Model.GetAllDrinks();
            Model.GetAllMeals();
            foreach (Drinks drink in Model.DrinksList)
            {
                listBox4.Items.Add(string.Format("{0} | €{1} ", drink.DrinkName, drink.DrinkPrice));
                
            }
            foreach (Drinks drink in Model.DrinksList)
            {
                if(drink.DrinkName == "Pint of Guinness")
                    listBox1.Items.Add(string.Format("{0}", drink.DrinkName));
            }
            foreach (Meals meal in Model.MealsList)
            {
                listBox5.Items.Add(string.Format("{0} | €{1} ", meal.DishName, meal.Price));

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formBarStaff form = new formBarStaff(fc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
