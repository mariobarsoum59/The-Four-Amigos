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
    public partial class FormCashOrCard : Form
    {
        private FormContainer fc;
        private IModel Model;
        public FormCashOrCard(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void FormCashOrCard_Load(object sender, EventArgs e)
        {

        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            formMakePaymentCard form = new formMakePaymentCard(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            FormMakePaymentCash form = new FormMakePaymentCash(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formSales form = new formSales(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }
    }
}
