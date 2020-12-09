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
    public partial class formSearchReservation : Form
    {
        private FormContainer fc;
        private IModel Model;

        public formSearchReservation(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formSearchReservation_Load(object sender, EventArgs e)
        {
            Model.GetAllReservations();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
