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
            //Model.GetAllReservations();
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
            //int numGuests = 0;
            lblManagerMenu.Text = "Hi "+Model.CurrentUser.FirstName;
            //foreach(Reservation r in Model.ReservationsList)
            //{
             //   if (r.CheckIn == true)
            //    { numGuests++; }
            //}
            //lblNumberOfGuests.Text = "Number of Checked in Guests: " + numGuests;
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

        private void BtnChangeRoomBasePrice_Click(object sender, EventArgs e)
        {
            formChangeRoomPrice f6 = new formChangeRoomPrice(fc, Model);
            f6.Dock = DockStyle.Fill;

            f6.Show();
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            formCheckGuestIn f7 = new formCheckGuestIn(fc, Model);
            f7.Dock = DockStyle.Fill;

            f7.Show();
        }

        private void btnSearchForReservation_Click(object sender, EventArgs e)
        {
            formSearchReservation f8 = new formSearchReservation(fc, Model);
            f8.Dock = DockStyle.Fill;
            f8.Show();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            formCreateMonthlyReport f9 = new formCreateMonthlyReport(fc, Model);
            f9.Dock = DockStyle.Fill;
            f9.Show();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            formViewMonthlyReports f10 = new formViewMonthlyReports(fc, Model);
            f10.Dock = DockStyle.Fill;
            f10.Show();
        }

        private void BtnManageStockItems_Click(object sender, EventArgs e)
        {
            formEditCurrentStock f9 = new formEditCurrentStock(fc, Model);
            f9.Dock = DockStyle.Fill;

            f9.Show();
        }
    }
}
