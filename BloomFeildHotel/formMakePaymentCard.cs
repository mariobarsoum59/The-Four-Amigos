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
    }
}
