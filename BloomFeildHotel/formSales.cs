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
            Model.GetAllBarItems();
            foreach (BarItems baritem in Model.BarItemsList)
            {

                listBox2.Items.Add(string.Format("{0} | €{1}", baritem.Food, baritem.FoodPrice));

            }
            foreach (BarItems baritem in Model.BarItemsList)
            {

                listBox1.Items.Add(string.Format("{0} | €{1}", baritem.Drink, baritem.DrinkPrice));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formBarStaff form = new formBarStaff(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItemText;
            selectedItemText = listBox2.SelectedItem.ToString();
            listBox3.Items.Add(selectedItemText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItemText;
            selectedItemText = listBox1.SelectedItem.ToString();
            listBox3.Items.Add(selectedItemText);
        }
    }
}
