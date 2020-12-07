using BusinessEntities;
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
    public partial class formCheckGuestIn : Form
    {
        private FormContainer fc;
        private IModel Model;
        DateTime today = DateTime.Now;
        public formCheckGuestIn(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void FormCheckGuestIn_Load(object sender, EventArgs e)
        {
            Model.GetAllGuests();
            Model.GetAllReservations();
            Model.GetAllRooms();




            foreach (Reservation r in Model.ReservationsList)
            {
                if (r.CheckInDate.Date == today.Date)
                {
                    listBoxReservations.Items.Add(r.ReservationID);
                }
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            if(txtReservationNumber.Text=="")
            {
                MessageBox.Show("Empty Feild For Searching By Reservation Number");
            }
            listBoxReservations.Items.Clear();
            foreach (Reservation r in Model.ReservationsList)
            {
                if (Convert.ToInt32(txtReservationNumber.Text) == r.ReservationID)
                {
                    listBoxReservations.Items.Add(r.ReservationID);
                }
            }
        }

        private void ListBoxReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
            foreach (Reservation r in Model.ReservationsList)
            {
                if (Convert.ToInt32(listBoxReservations.SelectedItem) == r.ReservationID)
                {
                    textBoxAdults.Text = r.Adults.ToString();
                    textBoxChildren.Text = r.Children.ToString();
                    textBoxPrice.Text = r.ReservationPrice.ToString();
                    txtCheckinDate.Text = r.CheckInDate.Date.ToShortDateString();
                    txtCheckOutDate.Text = r.CheckOutDate.ToShortDateString();


                    foreach (Room rm in Model.RoomsList)
                    {
                        if (r.RoomNumber == rm.RoomNumber)
                        {
                            txtRoomNum.Text = rm.RoomNumber.ToString();
                            txtRoomType.Text = rm.RoomType;
                        }
                    }

                    foreach(Guest g in Model.GuestsList)
                    {
                        if(r.GuestID==g.GuestID)
                        {
                            txtFirstName.Text = g.FirstName;
                            txtSurname.Text = g.Surname;
                        }
                    }


                    if (r.CheckInDate.Date != today.Date)
                    {
                        lblError.Text = "Warning The Check in Date For This Reservation is not For Today";
                    }



                }


                
                
            }
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            foreach(Reservation r in Model.ReservationsList)
            {
                if(Convert.ToInt32(listBoxReservations.SelectedItem)==r.ReservationID)
                {
                    r.CheckIn = true;
                    if(Model.CheckGuestIn(r))
                    {
                        MessageBox.Show("Guest Check In Successfull! ");
                    }
                }
            }
        }
    }
}
