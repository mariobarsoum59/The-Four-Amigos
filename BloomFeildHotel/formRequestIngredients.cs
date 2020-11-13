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
    public partial class formRequestIngredients : Form
    {
        public formRequestIngredients()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAvailableIngredients.Items.Clear();
            String category = cbCategory.SelectedItem.ToString();
            switch(category)
            {
                case "Meat":
                    lbAvailableIngredients.Items.Add("Steak");
                    lbAvailableIngredients.Items.Add("Pork Chop");
                    lbAvailableIngredients.Items.Add("Sausage");
                    lbAvailableIngredients.Items.Add("Rasher");
                    break;
                case "Poultry":
                    lbAvailableIngredients.Items.Add("Whole Chicken");
                    lbAvailableIngredients.Items.Add("Chicken Breast");
                    lbAvailableIngredients.Items.Add("Turkey Mince");
                    lbAvailableIngredients.Items.Add("Whole Duck");
                    break;
                case "Fish":
                    lbAvailableIngredients.Items.Add("Cod Fillet");
                    lbAvailableIngredients.Items.Add("Salmon Fillet");
                    lbAvailableIngredients.Items.Add("Mackerel Fillet");
                    break;
                case "Dairy":
                    lbAvailableIngredients.Items.Add("Litre of Milk");
                    lbAvailableIngredients.Items.Add("Block of Cheddar");
                    lbAvailableIngredients.Items.Add("Pound of Butter");
                    lbAvailableIngredients.Items.Add("Tub of Yoghurt");
                    break;
                case "Vegetables":
                    lbAvailableIngredients.Items.Add("Carrot");
                    lbAvailableIngredients.Items.Add("Parnip");
                    lbAvailableIngredients.Items.Add("Turnip");
                    lbAvailableIngredients.Items.Add("Head of Broccoli");
                    break;
                case "Fruits":
                    lbAvailableIngredients.Items.Add("Apple");
                    lbAvailableIngredients.Items.Add("Orange");
                    lbAvailableIngredients.Items.Add("Grape Vine");
                    lbAvailableIngredients.Items.Add("Banana");
                    break;
                case "Dry Grocery":
                    lbAvailableIngredients.Items.Add("Spaghetti");
                    lbAvailableIngredients.Items.Add("Bag of Flour");
                    lbAvailableIngredients.Items.Add("Egg");
                    lbAvailableIngredients.Items.Add("Rice");
                    break;
                case "Miscellaneous":
                    lbAvailableIngredients.Items.Add("");
                    break;
                default:
                    break;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void formRequestIngredients_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(lbAvailableIngredients.SelectedIndex != -1)
            {
                if(numAddQty.Value > 0)
                {
                    String item = lbAvailableIngredients.SelectedItem.ToString() + " Qty: " + numAddQty.Value;
                    lbIngredientsOrder.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("Please select a quantity above 0");
                }
            }
            else
            {
                MessageBox.Show("Please select an ingredient from the list");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbAvailableIngredients.SelectedIndex != -1)
            {
                int num = lbAvailableIngredients.SelectedIndex;
                lbIngredientsOrder.Items.RemoveAt(num);
            }
            else
            {
                MessageBox.Show("Please select an ingredient from the list");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtNewIngredient.Text))
            {
                if(numNewQty.Value > 0)
                {
                    String item = txtNewIngredient.Text + " Qty: " + numNewQty.Value;
                    lbIngredientsOrder.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("Please select a quantity above 0");
                }
            }
            else
            {
                MessageBox.Show("Please enter the ingredient name");
            }
        }
    }
}
