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
            if (foodList.SelectedIndex == 0)
            {
                List<string> ingredients = new List<string>();
                //ingredients = Model.GetIngredients;

                
                foreach (Ingredients ingredient in Model.IngredientsList)
                {

                    ingList.Items.Add(ingredient.ItemName);

                }
                
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void formManageWaste_Load(object sender, EventArgs e)
        {
            Model.GetAllIngredients();
        }
    }
}
