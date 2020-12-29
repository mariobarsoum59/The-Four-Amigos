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
    public partial class formRequestIngredients : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formRequestIngredients(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void formRequestIngredients_Load(object sender, EventArgs e)
        {

        }
    }
}
