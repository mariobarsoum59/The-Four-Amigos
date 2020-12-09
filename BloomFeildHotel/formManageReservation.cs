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
    public partial class formManageReservation : Form
    {
        private FormContainer fc;
        private IModel Model;
        private int ReservationID;
        public formManageReservation(FormContainer parent, IModel Model, int ReservationID)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            this.ReservationID = ReservationID;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void formManageReservation_Load(object sender, EventArgs e)
        {
            Model.GetAllReservations();
            Model.GetAllGuests();
            Model.GetAllRooms();
            foreach (IReservation reservation in Model.ReservationsList)
            {
                if(this.ReservationID == reservation.ReservationID)
                {
                    foreach (IGuest guest in Model.GuestsList)
                    {

                        if (reservation.GuestID == guest.GuestID)
                        {
                            foreach(IRoom room in Model.RoomsList)
                            {
                                if(reservation.RoomNumber == room.RoomNumber)
                                {
                                    tbReservationID.Text = reservation.ReservationID.ToString();
                                    tbRoomNumber.Text = reservation.RoomNumber.ToString();
                                    tbRoomType.Text = room.RoomType;
                                    dtpCheckIn.Value = reservation.CheckInDate;
                                    dtpCheckOut.Value = reservation.CheckOutDate;
                                    numNights.Value = (reservation.CheckOutDate - reservation.CheckInDate).Days;
                                    numAdults.Value = reservation.Adults;
                                    numChildren.Value = reservation.Children;
                                    tbRoomPrice.Text = reservation.ReservationPrice.ToString();
                                    if(reservation.PayedInFull == true)
                                    {
                                        rbPaidYes.Checked = true;
                                    }
                                    else
                                    {
                                        rbPaidNo.Checked = true;
                                    }
                                    if(reservation.PayedDeposit == true)
                                    {
                                        rbDepositYes.Checked = true;
                                        tbDeposit.Text = (reservation.ReservationPrice * 0.1).ToString();
                                    }
                                    else
                                    {
                                        rbDepositNo.Checked = true;
                                        tbDeposit.Text = "0.00";
                                    }
                                    tbGuestID.Text = guest.GuestID.ToString();
                                    tbFName.Text = guest.FirstName;
                                    tbSName.Text = guest.Surname;
                                    tbPhone.Text = guest.ContactNumber;
                                    tbEmail.Text = guest.Email;
                                    rtbAddress.Text = guest.Address;
                                    if(guest.SendMarketingInfo == true)
                                    {
                                        rbMarketingYes.Checked = true;
                                    }
                                    else
                                    {
                                        rbMarketingNo.Checked = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            //if (dtpCheckIn.Value >= dtpCheckOut.Value)
            //{
            //    MessageBox.Show("Check-in date must be before check-out date");
            //    dtpCheckIn.Value = dtpCheckOut.Value.AddDays(1);
            //}
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            //if(dtpCheckIn.Value <= dtpCheckOut.Value)
            //{
            //    MessageBox.Show("Check-out date must be after check-in date");
            //    dtpCheckIn.Value = dtpCheckOut.Value.AddDays(1);
           // }
        }

        private void numGuests_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            formReservationDeleteConfirm form = new formReservationDeleteConfirm(this.fc, this.Model, this.ReservationID);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int GuestID = 0;
            foreach(IReservation reservation in Model.ReservationsList)
            {
                if (reservation.ReservationID == this.ReservationID)
                {
                    foreach (IGuest guest in Model.GuestsList)
                    {

                        if (reservation.GuestID == guest.GuestID)
                        {
                            GuestID = reservation.GuestID;
                            foreach (IRoom room in Model.RoomsList)
                            {
                                if (reservation.RoomNumber == room.RoomNumber)
                                {
                                    reservation.RoomNumber = Int32.Parse(tbRoomNumber.Text);
                                    reservation.CheckInDate = dtpCheckIn.Value;
                                    reservation.CheckOutDate = dtpCheckOut.Value;
                                    reservation.Adults = Convert.ToInt32(numAdults.Value);
                                    reservation.Children = Convert.ToInt32(numChildren.Value);
                                    reservation.ReservationPrice = Convert.ToDouble(tbRoomPrice.Text);
                                    if (rbPaidYes.Checked)
                                    {
                                        reservation.PayedInFull = true;
                                    }
                                    else
                                    {
                                        reservation.PayedInFull = false;
                                    }
                                    if (rbDepositYes.Checked)
                                    {
                                        reservation.PayedDeposit = true;
                                    }
                                    else
                                    {
                                        reservation.PayedDeposit = false;
                                    }
                                    guest.FirstName = tbFName.Text;
                                    guest.Surname = tbSName.Text;
                                    guest.ContactNumber = tbPhone.Text;
                                    guest.Email = tbEmail.Text;
                                    guest.Address = rtbAddress.Text;
                                    if (rbMarketingYes.Checked == true)
                                    {
                                        guest.SendMarketingInfo = true;
                                    }
                                    else
                                    {
                                        guest.SendMarketingInfo = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            formReservationUpdateConfirm form = new formReservationUpdateConfirm(this.fc, this.Model, this.ReservationID, GuestID);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void gbReservation_Enter(object sender, EventArgs e)
        {

        }
    }
}
