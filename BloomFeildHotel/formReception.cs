using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace BloomFeildHotel
{
    public partial class formReception : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formReception(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void FormReception_Load(object sender, EventArgs e)
        {
            lblHiReceptionMenu.Text = "Hi " + Model.CurrentUser.FirstName;
        }

        private void BtnCreateReservation_Click(object sender, EventArgs e)
        {
            formCreateReservation form = new formCreateReservation(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            formViewReservations form = new formViewReservations(fc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
