using System;
using BusinessEntities;
using BusinessLayer;
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
    public partial class formViewGuests : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formViewGuests(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void formViewGuests_Load(object sender, EventArgs e)
        {
            Model.GetAllReservations();
            Model.GetAllGuests();
            Model.GetAllRooms();
            listBoxGuests.DataSource = Model.GuestsList;
            listBoxGuests.DisplayMember = "FirstName";
            listBoxGuests.ValueMember = "FirstName";
            listBoxGuests.ClearSelected();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formManager f1 = new formManager(fc, Model);
            f1.Dock = DockStyle.Fill;

            f1.Show();
        }

        private void listBoxGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Guest guest in Model.GuestsList)
            {
                string text = listBoxGuests.GetItemText(listBoxGuests.SelectedItem);
                if (text == guest.FirstName.ToString())
                {
                    foreach (Reservation res in Model.ReservationsList)
                    {
                        foreach (Room room in Model.RoomsList)
                        {
                            if (guest.GuestID == res.GuestID)
                            {
                                txtFirstName.Text = string.Empty;
                                txtSurname.Text = string.Empty;
                                txtEmail.Text = string.Empty;
                                txtCheckIn.Text = string.Empty;
                                txtRoomNo.Text = string.Empty;
                                txtStayDura.Text = string.Empty;
                                txtTele.Text = string.Empty;
                                txtCheckOut.Text = string.Empty;
                                DateTime d1 = res.CheckInDate;
                                DateTime d2 = res.CheckOutDate;
                                int days = (d2 - d1).Days;

                                //listBoxGuests.Items.Add(guest);
                                txtFirstName.Text = guest.FirstName.ToString();
                                txtSurname.Text = guest.Surname.ToString();
                                txtEmail.Text = guest.Email.ToString();
                                txtCheckIn.Text = res.CheckInDate.ToString();
                                txtRoomNo.Text = res.RoomNumber.ToString();
                                txtStayDura.Text = days.ToString();
                                txtTele.Text = guest.ContactNumber.ToString();
                                txtCheckOut.Text = res.CheckOutDate.ToString();

                                if (room.RoomNumber == res.RoomNumber)
                                {
                                    //txtRoomNo.Text = room.RoomNumber.ToString();
                                    txtRoomType.Text = room.RoomType.ToString();
                                }

                            }

                        }
                    }
                }
            }
        }
    }
}
