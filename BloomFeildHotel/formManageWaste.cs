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
using System.IO;


namespace BloomFeildHotel
{
    public partial class formManageWaste : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formManageWaste(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }
        private void lblTotalPrep_Click(object sender, EventArgs e)
        {

        }

        private void formManageWaste_Load(object sender, EventArgs e)
        {
            Model.GetAllMeals();
            Model.GetAllWaste();

            foreach (Waste waste in Model.WasteList)
            {
                foodList.Items.Add(waste.DishName);
            }

            

        }



        private void foodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Meals meal in Model.MealsList)
            {
                foreach (Waste waste in Model.WasteList)
                {
                    if (waste.DishName == meal.DishName)
                    {
                        if (foodList.SelectedItem.ToString() == waste.DishName)
                        {
                            totalPrep.Text = meal.Quantity.ToString();
                            totalRemain.Text = waste.NumWasted.ToString();
                            double wasted = meal.Price * waste.NumWasted;
                            txtMoneyWaste.Text = wasted.ToString();
                        }
                    }
                }
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnUpdateWaste_Click(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var fullFileName = Path.Combine(path, "Meal Report.txt");

            //string[] = "Meals", "for", "today";
            foreach (var item in foodList.Items)
            {
                foreach (Waste waste in Model.WasteList)
                {
                    
                    
                    System.IO.File.WriteAllLines(fullFileName,  foodList.Items.Cast<string>().ToArray());

                }
            }

        }

        private void totalPrep_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAddWaste form = new formAddWaste(fc, Model);
            form.Show();
            form.Dock = DockStyle.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(foodList.SelectedIndex >= 0)
            {
                
                foreach (IMeals meal in Model.MealsList)
                {
                    foreach (IWaste waste in Model.WasteList)
                    {
                        if (waste.DishName == meal.DishName)
                        {
                            if (meal.DishName == foodList.SelectedItem.ToString())
                            {
                                int mealID = waste.DishID;
                                string mealName = waste.DishName;
                                int numWasted = waste.NumWasted;
                                double lossFromWaste = waste.LossFromWaste;
                                DateTime Date = waste.Date;

                                DialogResult result = MessageBox.Show("Delete " + foodList.SelectedItem.ToString() + " ? ", "Confirm", MessageBoxButtons.OKCancel);

                                if (result == DialogResult.OK)
                                {
                                    try
                                    {
                                        
                                            
                                                Model.deleteWaste(waste);
                                                foodList.Items.Remove(foodList.SelectedItem);
                                                totalPrep.Clear();
                                                totalRemain.Clear();
                                                txtMoneyWaste.Clear();
                                                break;
                                            
                                    }
                                    catch(System.Exception ex)
                                    {
                                        if(ex is InvalidOperationException)
                                        {

                                        }
                                        if(ex is NullReferenceException)
                                        {

                                        }
                                        
                                    }

                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select item to delete");
            }
        }
    }
}
