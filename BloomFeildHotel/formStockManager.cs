using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLayer;

namespace BloomFeildHotel
{
    public partial class formStockManager : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formStockManager(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            formViewStock f1 = new formViewStock(fc, Model);
            f1.Dock = DockStyle.Fill;
            f1.Show();
        }

        private void formStockManager_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
