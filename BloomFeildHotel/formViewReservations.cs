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
    public partial class formViewReservations : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formViewReservations(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void formViewReservations_Load(object sender, EventArgs e)
        {
            lbReservations.Items.Clear();
            Model.GetAllReservations();
            Model.GetAllGuests();
            foreach(IReservation reservation in Model.ReservationsList)
            {
                foreach(IGuest guest in Model.GuestsList)
                {
                    if(reservation.GuestID == guest.GuestID)
                    {
                        String str = "";
                        str += reservation.ReservationID + " - ";
                        str += reservation.RoomNumber + " - ";
                        str += guest.FirstName + " " + guest.Surname + " - ";
                        str += reservation.CheckInDate.Day + "/" + reservation.CheckInDate.Month + "/" + reservation.CheckInDate.Year;
                        str += " to " + reservation.CheckOutDate.Day + "/" + reservation.CheckOutDate.Month + "/" + reservation.CheckOutDate.Year;
                        lbReservations.Items.Add(str);
                    }
                }
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            String reservation = lbReservations.SelectedItem.ToString();
            String[] reservationDetails = reservation.Split(' ');
            int ReservationID = Int32.Parse(reservationDetails[0]);
            formManageReservation form = new formManageReservation(fc, Model, ReservationID);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String reservationID = txtReservationID.Text;
            String firstName = txtFirstName.Text;
            String lastName = txtLastName.Text;
            lbReservations.Items.Clear();
            Model.GetAllReservations();
            Model.GetAllGuests();
            if(!String.IsNullOrEmpty(reservationID))
            {
                foreach (IReservation reservation in Model.ReservationsList)
                {
                    int id = Int32.Parse(reservationID);
                    if (reservation.ReservationID == id)
                    {
                        foreach (IGuest guest in Model.GuestsList)
                        {
                            if (reservation.GuestID == guest.GuestID)
                            {
                                String str = "";
                                str += reservation.ReservationID + " - ";
                                str += reservation.RoomNumber + " - ";
                                str += guest.FirstName + " " + guest.Surname + " - ";
                                str += reservation.CheckInDate.Day + "/" + reservation.CheckInDate.Month + "/" + reservation.CheckInDate.Year;
                                str += " to " + reservation.CheckOutDate.Day + "/" + reservation.CheckOutDate.Month + "/" + reservation.CheckOutDate.Year;
                                lbReservations.Items.Add(str);
                            }
                        }
                    }
                }
                if (lbReservations.Items.Count == 0)
                {
                    MessageBox.Show("No matching reservations were found");
                    foreach (IReservation reservation in Model.ReservationsList)
                    {
                        foreach (IGuest guest in Model.GuestsList)
                        {
                            if (reservation.GuestID == guest.GuestID)
                            {
                                String str = "";
                                str += reservation.ReservationID + " - ";
                                str += reservation.RoomNumber + " - ";
                                str += guest.FirstName + " " + guest.Surname + " - ";
                                str += reservation.CheckInDate.Day + "/" + reservation.CheckInDate.Month + "/" + reservation.CheckInDate.Year;
                                str += " to " + reservation.CheckOutDate.Day + "/" + reservation.CheckOutDate.Month + "/" + reservation.CheckOutDate.Year;
                                lbReservations.Items.Add(str);
                            }
                        }
                    }
                }
            }
            else if(!String.IsNullOrEmpty(firstName) && !String.IsNullOrEmpty(lastName))
            {
                foreach (IGuest guest in Model.GuestsList)
                {
                    if(guest.FirstName == firstName && guest.Surname == lastName)
                    {
                        foreach (IReservation reservation in Model.ReservationsList)
                        {
                            if (reservation.GuestID == guest.GuestID)
                            {
                                String str = "";
                                str += reservation.ReservationID + " - ";
                                str += reservation.RoomNumber + " - ";
                                str += guest.FirstName + " " + guest.Surname + " - ";
                                str += reservation.CheckInDate.Day + "/" + reservation.CheckInDate.Month + "/" + reservation.CheckInDate.Year;
                                str += " to " + reservation.CheckOutDate.Day + "/" + reservation.CheckOutDate.Month + "/" + reservation.CheckOutDate.Year;
                                lbReservations.Items.Add(str);
                            }
                        }
                    }
                }
                if (lbReservations.Items.Count == 0)
                {
                    MessageBox.Show("No matching reservations were found");
                    foreach (IReservation reservation in Model.ReservationsList)
                    {
                        foreach (IGuest guest in Model.GuestsList)
                        {
                            if (reservation.GuestID == guest.GuestID)
                            {
                                String str = "";
                                str += reservation.ReservationID + " - ";
                                str += reservation.RoomNumber + " - ";
                                str += guest.FirstName + " " + guest.Surname + " - ";
                                str += reservation.CheckInDate.Day + "/" + reservation.CheckInDate.Month + "/" + reservation.CheckInDate.Year;
                                str += " to " + reservation.CheckOutDate.Day + "/" + reservation.CheckOutDate.Month + "/" + reservation.CheckOutDate.Year;
                                lbReservations.Items.Add(str);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid search criteria");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void txtReservationID_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtReservationID.Text = "";
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtReservationID.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
