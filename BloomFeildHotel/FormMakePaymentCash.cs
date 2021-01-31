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
    public partial class FormMakePaymentCash : Form
    {
        private FormContainer fc;
        private IModel Model;
        public FormMakePaymentCash(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void FormMakePaymentCash_Load(object sender, EventArgs e)
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
           
            if (textBoxName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a Name!");
            }
            if (textBoxAmount.Text == String.Empty)
            {
                MessageBox.Show("Please Enter an Amount!");
            }
            else if (textBoxRecieved.Text == String.Empty)
            {
                MessageBox.Show("Please enter Amount Recived!");
            }
            else
            {
                decimal change = (Convert.ToDecimal(textBoxRecieved.Text) - Convert.ToDecimal(textBoxAmount.Text));

                int id = 0;
                bool cardPayment = false;
                bool cashPayment = true;
                decimal amount = Convert.ToDecimal(textBoxAmount.Text);
                Model.addNewPayment(id, cashPayment, cardPayment, textBoxName.Text, amount);
                MessageBox.Show("Chnage for Customer = " + change.ToString());
                MessageBox.Show("Payment Made");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxAmount.Clear();
            textBoxRecieved.Clear();
            
        }
    }
}
