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
using BusinessEntities;

namespace BloomFeildHotel
{
    public partial class formCheckOut : Form
    {
        private FormContainer fc;
        private IModel Model;
        private int ReservationID;
        public formCheckOut(FormContainer parent, IModel Model, int ReservationID)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            this.ReservationID = ReservationID;
        }

        private void formCheckOut_Load(object sender, EventArgs e)
        {
            Model.GetAllReservations();
            Model.GetAllGuests();
            Model.GetAllRooms();
            foreach (IReservation reservation in Model.ReservationsList)
            {
                if (this.ReservationID == reservation.ReservationID)
                {
                    foreach (IGuest guest in Model.GuestsList)
                    { 
                        if (reservation.GuestID == guest.GuestID)
                        {
                            foreach (IRoom room in Model.RoomsList)
                            {
                                if (reservation.RoomNumber == room.RoomNumber)
                                {
                                    txtName.Text = guest.FirstName;
                                    txtSurname.Text = guest.Surname;
                                    txtRoomNo.Text = reservation.RoomNumber.ToString();
                                    txtPhone.Text = guest.ContactNumber.ToString();
                                }

                            }
                        }
                    }
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (IReservation reservation in Model.ReservationsList)
            {
                if (this.ReservationID == reservation.ReservationID)
                {
                    foreach (IGuest guest in Model.GuestsList)
                    {
                        if (reservation.GuestID == guest.GuestID)
                        {
                            foreach (IRoom room in Model.RoomsList)
                            {
                                if (reservation.RoomNumber == room.RoomNumber)
                                {
                                    reservation.CheckIn = false;
                                    if(Model.CheckGuestOut(reservation))
                                    {
                                        MessageBox.Show("Guest checked out successfully" );
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }


        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
