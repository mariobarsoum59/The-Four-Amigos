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
    public partial class formManager : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formManager(FormContainer parent, IModel Model)
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

        private void BtnAddUsers_Click(object sender, EventArgs e)
        {
            formAddUser form = new formAddUser(fc, Model);
            //form.Show();
            form.Dock = DockStyle.Fill;

            form.Show();
        }

        private void BtnDeleteUsers_Click(object sender, EventArgs e)
        {
            formDeleteUser f2 = new formDeleteUser(fc, Model);
            f2.Dock=DockStyle.Fill;

            f2.Show();
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            lblManagerMenu.Text = "Hi "+Model.CurrentUser.FirstName;
        }

        private void BtnCreateReservation_Click(object sender, EventArgs e)
        {
            formCreateReservation f3 = new formCreateReservation(fc, Model);
            f3.Dock = DockStyle.Fill;

            f3.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            formMarkRoomCleaned f4 = new formMarkRoomCleaned(fc, Model);
            f4.Dock = DockStyle.Fill;

            f4.Show();
        }

        private void BtnViewRoomBookings_Click(object sender, EventArgs e)
        {
            formViewRoomBookings f5 = new formViewRoomBookings(fc, Model);
            f5.Dock = DockStyle.Fill;

            f5.Show();
        }
    }
}
