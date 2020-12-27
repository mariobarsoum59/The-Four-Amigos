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

       

        private void ingList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void foodList_SelectedIndexChanged(object sender, EventArgs e)
        {
              

                if (foodList.SelectedIndex == 0)      //if chicken curry is selected
                {
                     ingList.Items.Clear();
                     priceList.Items.Clear();
                     listQuant.Items.Clear();
                     totalPrep.Text = string.Empty;
                     totalRemain.Text = string.Empty;
                     txtCosttoPrep.Text = string.Empty;
                     txtTotalPrep.Text = string.Empty;
                     txtMoneyWaste.Text = string.Empty;
                     List<double> total = new List<double>();

                    //first ingredient (potato) is added to list

                        foreach (Ingredients ingredient in Model.IngredientsList)
                        {
                            if (ingredient.ItemName == "Potatoes")
                            {
                                string Ing1 = ingredient.ItemName;
                                decimal price1 = Convert.ToDecimal(ingredient.Price);
                                // string s = String.Format("{0:C}", price1);
                                string s = price1.ToString("C2");
                                ingList.Items.Add(Ing1);
                                priceList.Items.Add(s);
                                listQuant.Items.Add(3);
                                total.Add(ingredient.Price * 3);
                             
                            }

                            if (ingredient.ItemName == "Chicken Breasts")
                            {

                                string Ing2 = ingredient.ItemName;
                                decimal price2 = Convert.ToDecimal(ingredient.Price);
                                string s = price2.ToString("C2");
                                ingList.Items.Add(Ing2);
                                priceList.Items.Add(s);
                                listQuant.Items.Add(3);
                                total.Add(ingredient.Price * 3);

                            }

                            if (ingredient.ItemName == "Curry Powder")
                            {
                                string Ing3 = ingredient.ItemName;
                                decimal price3 = Convert.ToDecimal(ingredient.Price);
                                string s = price3.ToString("C2");
                                ingList.Items.Add(Ing3);
                                priceList.Items.Add(s);
                                listQuant.Items.Add(2);
                                total.Add(ingredient.Price * 2);
                               
                            }

                            if (ingredient.ItemName == "Garlic")
                            {
                                string Ing4 = ingredient.ItemName;
                                decimal price4 = Convert.ToDecimal(ingredient.Price);
                                string s = price4.ToString("C2");
                                ingList.Items.Add(Ing4);
                                priceList.Items.Add(s);
                                listQuant.Items.Add("1");
                                total.Add(ingredient.Price);
                                
                            }

                            if (ingredient.ItemName == "Chicken Stock")
                            {
                                string Ing5 = ingredient.ItemName;
                                decimal price5 = Convert.ToDecimal(ingredient.Price);
                                string s = price5.ToString("C2");
                                ingList.Items.Add(Ing5);
                                priceList.Items.Add(s);
                                listQuant.Items.Add(1);
                                total.Add(ingredient.Price);

                            }
                            

                        }
                        


                        foreach (Meals meal in Model.MealsList)
                        {
                            if (meal.DishID == 1)
                            {
                                totalPrep.Text = meal.Quantity.ToString();
                                double totalPerAll = total.Sum();
                                double totalPerMeal = totalPerAll / meal.Quantity;
                                txtCosttoPrep.Text = totalPerMeal.ToString("C2");
                                txtTotalPrep.Text = totalPerAll.ToString("C2");

                                foreach (Waste waste in Model.WasteList)
                                {
                                    if (waste.DishID == 1)
                                    {
                                        double lossFromWaste = 0;
                                        lossFromWaste = totalPerMeal * waste.NumWasted;
                                        txtMoneyWaste.Text = lossFromWaste.ToString("C2");


                                    }

                                }

                            }

                        }

                        foreach(Waste waste in Model.WasteList)
                        {
                            if(waste.DishID ==1)
                            {
                            totalRemain.Text = waste.NumWasted.ToString();
                                
                            //txtMoneyWaste.Text = 
                            }
                        }

                        


                }

                if (foodList.SelectedIndex ==1)
                {
                    ingList.Items.Clear();
                    priceList.Items.Clear();
                    listQuant.Items.Clear();
                    totalPrep.Text = string.Empty;
                    totalRemain.Text = string.Empty;
                    txtCosttoPrep.Text = string.Empty;
                    txtTotalPrep.Text = string.Empty;
                    txtMoneyWaste.Text = string.Empty;
                    List<double> total = new List<double>();

                    foreach (Ingredients ingredient in Model.IngredientsList)
                    {
                        if (ingredient.ItemName == "Cod Fillet")
                        {   
                            string Ing1 = ingredient.ItemName;
                            decimal price1 = Convert.ToDecimal(ingredient.Price);
                            string s = price1.ToString("C2");
                            ingList.Items.Add(Ing1);
                            priceList.Items.Add(s);
                            listQuant.Items.Add(12);
                            total.Add(ingredient.Price * 12);
                        }

                        if (ingredient.ItemName == "Oil")
                        {
                            string Ing2 = ingredient.ItemName;
                            decimal price2 = Convert.ToDecimal(ingredient.Price);
                            string s = price2.ToString("C2");
                            ingList.Items.Add(Ing2);
                            priceList.Items.Add(s);
                            listQuant.Items.Add(3);
                            total.Add(ingredient.Price * 3);
                        }


                        if (ingredient.ItemName == "Potatoes")
                        {
                            string Ing3 = ingredient.ItemName;
                            decimal price3 = Convert.ToDecimal(ingredient.Price);
                            string s = price3.ToString("C2");
                            ingList.Items.Add(Ing3);
                            priceList.Items.Add(s);
                            listQuant.Items.Add(2);
                            total.Add(ingredient.Price * 2);
                        }

                        if (ingredient.ItemName == "Salt")
                        {
                            string Ing4 = ingredient.ItemName;
                            decimal price4 = Convert.ToDecimal(ingredient.Price);
                            string s = price4.ToString("C2");
                            ingList.Items.Add(Ing4);
                            priceList.Items.Add(s);
                            listQuant.Items.Add("1/2");
                            total.Add(ingredient.Price * 0.5);
                        }

                    }


                    foreach (Meals meal in Model.MealsList)
                    {
                        if (meal.DishID == 2)
                        {
                            totalPrep.Text = meal.Quantity.ToString();
                            double totalPerAll = total.Sum();
                            double totalPerMeal = totalPerAll / meal.Quantity;
                            txtCosttoPrep.Text = totalPerMeal.ToString("C2");
                            txtTotalPrep.Text = totalPerAll.ToString("C2");

                            foreach (Waste waste in Model.WasteList)
                            {
                                if (waste.DishID == 2)
                                {
                                    double lossFromWaste = 0;
                                    lossFromWaste = totalPerMeal * waste.NumWasted;
                                    txtMoneyWaste.Text = lossFromWaste.ToString("C2");


                                }

                            }

                        }

                    }

                    foreach (Waste waste in Model.WasteList)
                    {
                        if (waste.DishID == 2)
                        {
                            totalRemain.Text = waste.NumWasted.ToString();

                            //txtMoneyWaste.Text = 
                        }
                    }


                }

                if (foodList.SelectedIndex == 2)
                {
                    ingList.Items.Clear();
                    priceList.Items.Clear();
                    listQuant.Items.Clear();
                    totalPrep.Text = string.Empty;
                    totalRemain.Text = string.Empty;
                    txtCosttoPrep.Text = string.Empty;
                    txtTotalPrep.Text = string.Empty;
                    txtMoneyWaste.Text = string.Empty;
                    List<double> total = new List<double>();

                    foreach (Ingredients ingredient in Model.IngredientsList)
                    { 
                        if (ingredient.ItemName == "Lettuce")
                        {
                            string Ing1 = ingredient.ItemName;
                            decimal price1 = Convert.ToDecimal(ingredient.Price);
                            string s = price1.ToString("C2");
                            ingList.Items.Add(Ing1);
                            priceList.Items.Add(s);
                            listQuant.Items.Add(1);
                            total.Add(ingredient.Price);
                        }

                        if (ingredient.ItemName == "Tomatoes")
                        {
                            string Ing2 = ingredient.ItemName;
                            decimal price2 = Convert.ToDecimal(ingredient.Price);
                            string s = price2.ToString("C2");
                            ingList.Items.Add(Ing2);
                            priceList.Items.Add(s);
                            listQuant.Items.Add(2);
                            total.Add(ingredient.Price * 2);
                        }

                        if (ingredient.ItemName == "Avocado")
                        {
                            string Ing3 = ingredient.ItemName;
                            decimal price3 = Convert.ToDecimal(ingredient.Price);
                            string s = price3.ToString("C2");
                            ingList.Items.Add(Ing3);
                            priceList.Items.Add(s);
                            listQuant.Items.Add(1);
                            total.Add(ingredient.Price);
                        }

                        if (ingredient.ItemName == "Garlic")
                        {
                            string Ing4 = ingredient.ItemName;
                            decimal price4 = Convert.ToDecimal(ingredient.Price);
                            string s = price4.ToString("C2");
                            ingList.Items.Add(Ing4);
                            priceList.Items.Add(s);
                            listQuant.Items.Add(1);
                            total.Add(ingredient.Price);
                        }

                        if (ingredient.ItemName == "Cucumber")
                        {
                            string Ing5 = ingredient.ItemName;
                            decimal price5 = Convert.ToDecimal(ingredient.Price);
                            string s = price5.ToString("C2");
                            ingList.Items.Add(Ing5);
                            priceList.Items.Add(s);
                            listQuant.Items.Add(1);
                            total.Add(ingredient.Price);
                        }

                        if (ingredient.ItemName == "Vinegar")
                        {
                            string Ing6 = ingredient.ItemName;
                            decimal price6 = Convert.ToDecimal(ingredient.Price);
                            string s = price6.ToString("C2");
                            ingList.Items.Add(Ing6);
                            priceList.Items.Add(s);
                            listQuant.Items.Add(1);
                            total.Add(ingredient.Price);
                        }

                        if (ingredient.ItemName == "Potato")
                        {
                            string Ing7 = ingredient.ItemName;
                            decimal price7 = Convert.ToDecimal(ingredient.Price);
                            string s = price7.ToString("C2");
                            ingList.Items.Add(Ing7);
                            priceList.Items.Add(s);
                            listQuant.Items.Add(2);
                            total.Add(ingredient.Price * 2);
                        }

                        if (ingredient.ItemName == "Chicken Stock")
                        {
                            string Ing8 = ingredient.ItemName;
                            decimal price8 = Convert.ToDecimal(ingredient.Price);
                            string s = price8.ToString("C2");
                            ingList.Items.Add(Ing8);
                            priceList.Items.Add(s);
                            listQuant.Items.Add(1);
                            total.Add(ingredient.Price);
                        }

                        if (ingredient.ItemName == "Onions")
                        {
                            string Ing9 = ingredient.ItemName;
                            decimal price9 = Convert.ToDecimal(ingredient.Price);
                            string s = price9.ToString("C2");
                            ingList.Items.Add(Ing9);
                            priceList.Items.Add(s);
                            listQuant.Items.Add(1);
                            total.Add(ingredient.Price);
                        }
                    }

                    foreach (Meals meal in Model.MealsList)
                    {
                        if (meal.DishID == 3)
                        {
                            totalPrep.Text = meal.Quantity.ToString();
                            double totalPerAll = total.Sum();
                            double totalPerMeal = totalPerAll / meal.Quantity;
                            txtCosttoPrep.Text = totalPerMeal.ToString("C2");
                            txtTotalPrep.Text = totalPerAll.ToString("C2");

                            foreach (Waste waste in Model.WasteList)
                            {
                                if (waste.DishID == 3)
                                {
                                    double lossFromWaste = 0;
                                    lossFromWaste = totalPerMeal * waste.NumWasted;
                                    txtMoneyWaste.Text = lossFromWaste.ToString("C2");


                                }

                            }

                        }

                    }

                    foreach (Waste waste in Model.WasteList)
                    {
                        if (waste.DishID == 3)
                        {
                            totalRemain.Text = waste.NumWasted.ToString();

                            //txtMoneyWaste.Text = 
                        }
                    }


                }   



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formManageWaste_Load(object sender, EventArgs e)
        {
            Model.GetAllIngredients();
            Model.GetAllMeals();
            Model.GetAllWaste();
        }
    }
}
