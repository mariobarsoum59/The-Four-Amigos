using BusinessEntities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloomFeildHotel
{
    public partial class formMakePaymentCard : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formMakePaymentCard(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void formMakePaymentCard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormCashOrCard form = new FormCashOrCard(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (textBoxAmount.Text == String.Empty)
            {
                MessageBox.Show("Please Enter an Amount!");
            }
            else if (textBoxName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a Name!");
            }
            else if (textBoxNumber.Text == String.Empty)
            {
                MessageBox.Show("Please enter Card Number!");
            }
            else if (monthComboBox.Text == String.Empty)
            {
                MessageBox.Show("Please enter a Month!");
            }
            else if (yearComboBox.Text == String.Empty)
            {
                MessageBox.Show("Please enter a Year!");
            }
            else if (textBoxCCV.Text == String.Empty)
            {
                MessageBox.Show("Please enter CVV/CVVD!");
            }
            else if (textBoxCCV.Text.Length < 3 || textBoxCCV.Text.Length > 3)
            {
                MessageBox.Show("Please enter CVV/CVVD that is 3 characters long");
            }
            else if (textBoxNumber.Text.Length < 16 || textBoxNumber.Text.Length > 16)
            {
                MessageBox.Show("Please enter a card number that is 16 characters long");
            }
            else
            {
                
                int id = 0;
                bool cardPayment = true;
                bool cashPayment = false;
                decimal amount = Convert.ToDecimal(textBoxAmount.Text);
                Model.addNewPayment(id,cashPayment, cardPayment, textBoxName.Text, amount);
                MessageBox.Show("Payment Made");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxAmount.Clear();
            textBoxName.Clear();
            textBoxNumber.Clear();
            monthComboBox.SelectedIndex = -1;
            yearComboBox.SelectedIndex = -1;
            textBoxCCV.Clear();
        }

        
    }
    
}
