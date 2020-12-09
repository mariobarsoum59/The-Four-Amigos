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
    public partial class formEditCurrentStock : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formEditCurrentStock(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void FormEditCurrentStock_Load(object sender, EventArgs e)
        {
            Model.GetAllStockItems();
            foreach (StockItem s in Model.StockItemsList)
            {
                if (comboBoxCategory.Items.Contains(s.Category))
                {
                }
                else
                {
                    comboBoxCategory.Items.Add(s.Category);
                }

                if (comboBoxDepartment.Items.Contains(s.Department))
                {
                }
                else
                {
                    comboBoxDepartment.Items.Add(s.Department);
                }

                listBox1.Items.Add(s.ItemName);
                comboBoxDepartment.Sorted = true;
                comboBoxCategory.Sorted = true;
                listBox1.Sorted = true;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (StockItem s in Model.StockItemsList)
            {
                if (listBox1.SelectedItem.ToString() == s.ItemName)
                {
                    textBoxID.Text = s.ItemID.ToString();
                    textBoxName.Text = s.ItemName;
                    textBoxPrice.Text = s.Price.ToString();
                    textBoxCategory.Text = s.Category;
                    textBoxDepartment.Text = s.Department;
                    numericUpDownQuantity.Value = s.Quantity;
                    textBoxDesc.Text = s.Description;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (StockItem s in Model.StockItemsList)
            {
                //search for department only
                if (comboBoxCategory.SelectedItem == null && comboBoxDepartment.SelectedItem != null)
                {
                    if (comboBoxDepartment.SelectedItem.ToString() == s.Department)
                    {
                        listBox1.Items.Add(s.ItemName);

                    }

                }

                //search for category only
                if (comboBoxDepartment.SelectedItem == null && comboBoxCategory.SelectedItem != null)
                {
                    if (comboBoxCategory.SelectedItem.ToString() == s.Category)
                    {
                        listBox1.Items.Add(s.ItemName);

                    }

                }

                //search by both
                if (comboBoxDepartment.SelectedItem != null && comboBoxCategory.SelectedItem != null)
                {
                    if (comboBoxCategory.SelectedItem.ToString() == s.Category && comboBoxDepartment.SelectedItem.ToString() == s.Department)
                    {
                        listBox1.Items.Add(s.ItemName);
                    }
                }

                if(comboBoxDepartment.SelectedItem == null && comboBoxCategory.SelectedItem == null && txtItemName.Text=="")
                {
                    listBox1.Items.Add(s.ItemName);
                }


            }
        }

        private void BtnCommit_Click(object sender, EventArgs e)
        {
            foreach (StockItem s in Model.StockItemsList)
            {
                if (textBoxID.Text == s.ItemID.ToString())
                {
                    s.ItemName = textBoxName.Text;
                    s.Price = Convert.ToDecimal(textBoxPrice.Text);
                    s.Quantity = Convert.ToInt32(numericUpDownQuantity.Value);
                    s.Description = textBoxDesc.Text;

                    if (Model.UpdateCurrrentStockItem(s))
                    {
                        MessageBox.Show(s.ItemName + " has been updated Successfully!");
                    }
                }
            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            bool found = false;
            listBox1.Items.Clear();
            foreach (StockItem s in Model.StockItemsList)
            {
                if (txtItemName.Text.Equals(s.ItemName, StringComparison.CurrentCultureIgnoreCase))
                {
                    listBox1.Items.Add(s.ItemName);
                    found = true;
                }
                else
                {
                    listBox1.Items.Add(s.ItemName);
                    listBox1.Sorted = true;
                }


            }
            if (found == false)
            {
                MessageBox.Show("Could not find " + txtItemName.Text);

            }
        }

        private void BtnReloadList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (StockItem s in Model.StockItemsList)
            {
                listBox1.Items.Add(s.ItemName);
                listBox1.Sorted = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            comboBoxCategory.SelectedItem = null;
            comboBoxDepartment.SelectedItem = null;
            txtItemName.Text = null;
        }
    }
}
