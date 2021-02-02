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
                                if (room.Available)
                                {
                                    cbRoomNum.Items.Add(room.RoomNumber);
                                }
                                if(reservation.RoomNumber == room.RoomNumber)
                                {
                                    tbReservationID.Text = reservation.ReservationID.ToString();
                                    cbRoomNum.SelectedItem = reservation.RoomNumber;
                                    tbRoomType.Text = room.RoomType;
                                    if(room.Smoking)
                                    {
                                        txtSmoking.Text = "Smoking";
                                    }
                                    else
                                    {
                                        txtSmoking.Text = "Non - Smoking";
                                    }
                                    dtpCheckIn.Value = reservation.CheckInDate;
                                    dtpCheckOut.Value = reservation.CheckOutDate;
                                    numNights.Text = (reservation.CheckOutDate - reservation.CheckInDate).Days.ToString();
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
            if (dtpCheckIn.Value >= dtpCheckOut.Value)
            {
                DateTime date = dtpCheckOut.Value;
                date = date.AddDays(-1);
                dtpCheckIn.Value = date.Date;
            }
            Model.GetAllReservations();
            Model.GetAllRooms();
            foreach (IReservation reservation in Model.ReservationsList)
            {
                if (reservation.ReservationID == ReservationID)
                {
                    foreach (IRoom room in Model.RoomsList)
                    {
                        if (room.RoomNumber == reservation.RoomNumber)
                        {
                            int numNights = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
                            tbRoomPrice.Text = (room.BasePrice * numNights).ToString();
                            if (rbDepositYes.Checked)
                            {
                                tbDeposit.Text = (Convert.ToInt32(tbRoomPrice.Text) * 0.1).ToString();
                            }
                            else
                            {
                                tbDeposit.Text = "0.00";
                            }
                        }
                    }
                }
            }
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckIn.Value >= dtpCheckOut.Value)
            {
                DateTime date = dtpCheckIn.Value;
                date = date.AddDays(1);
                dtpCheckOut.Value = date.Date;
            }
            Model.GetAllReservations();
            Model.GetAllRooms();
            foreach (IReservation reservation in Model.ReservationsList)
            {
                if (reservation.ReservationID == ReservationID)
                {
                    foreach (IRoom room in Model.RoomsList)
                    {
                        if (room.RoomNumber == reservation.RoomNumber)
                        {
                            int numNights = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
                            tbRoomPrice.Text = (room.BasePrice * numNights).ToString();
                            if (rbDepositYes.Checked)
                            {
                                tbDeposit.Text = (Convert.ToInt32(tbRoomPrice.Text) * 0.1).ToString();
                            }
                            else
                            {
                                tbDeposit.Text = "0.00";
                            }
                        }
                    }
                }
            }
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
            if(numAdults.Value < 1)
            {
                MessageBox.Show("Number of Adults must be at least 1");
            }
            else if(tbFName.Text == "" || tbSName.Text == "" || tbPhone.Text == "" || tbEmail.Text == "" || rtbAddress.Text == "")
            {
                MessageBox.Show("Please fill in all guest details");
                Model.GetAllReservations();
                Model.GetAllGuests();
                foreach (IReservation r in Model.ReservationsList)
                {
                    if (r.ReservationID == ReservationID)
                    {
                        foreach (IGuest g in Model.GuestsList)
                        {
                            if (g.GuestID == r.GuestID)
                            {
                                tbFName.Text = g.FirstName;
                                tbSName.Text = g.Surname;
                                tbPhone.Text = g.ContactNumber;
                                tbEmail.Text = g.Email;
                                rtbAddress.Text = g.Address;
                                if (g.SendMarketingInfo)
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
            else
            {
                int GuestID = 0;
                foreach (IReservation reservation in Model.ReservationsList)
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
                                    if (room.RoomNumber == Convert.ToInt32(cbRoomNum.SelectedItem))
                                    {
                                        reservation.RoomNumber = room.RoomNumber;
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
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            formCheckOut form = new formCheckOut(this.fc, this.Model, this.ReservationID);
            form.Show();
        }

        private void cbRoomNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.GetAllReservations();
            Model.GetAllRooms();
            foreach (IRoom room in Model.RoomsList)
            {
                if(room.RoomNumber == Convert.ToInt32(cbRoomNum.SelectedItem))
                {
                    foreach(IReservation reservation in Model.ReservationsList)
                    {
                        if(reservation.ReservationID == ReservationID)
                        {
                            if (room.Smoking)
                            {
                                txtSmoking.Text = "Smoking";
                            }
                            else
                            {
                                txtSmoking.Text = "Non - Smoking";
                            }
                            tbRoomType.Text = room.RoomType;

                            int numNights = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
                            tbRoomPrice.Text = (room.BasePrice * numNights).ToString();
                            if (rbDepositYes.Checked)
                            {
                                tbDeposit.Text = (Convert.ToInt32(tbRoomPrice.Text) * 0.1).ToString();
                            }
                            else
                            {
                                tbDeposit.Text = "0.00";
                            }
                        }
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rbDepositYes_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDepositYes.Checked)
            {
                Model.GetAllReservations();
                Model.GetAllRooms();
                foreach (IReservation reservation in Model.ReservationsList)
                {
                    if (reservation.ReservationID == ReservationID)
                    {
                        foreach (IRoom room in Model.RoomsList)
                        {
                            if (room.RoomNumber == Convert.ToInt32(cbRoomNum.SelectedItem))
                            {
                                int numNights = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
                                tbRoomPrice.Text = (room.BasePrice * numNights).ToString();
                                if (rbDepositYes.Checked)
                                {
                                    tbDeposit.Text = (Convert.ToInt32(tbRoomPrice.Text) * 0.1).ToString();
                                }
                                else
                                {
                                    tbDeposit.Text = "0.00";
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                tbDeposit.Text = "0.00";
            }
        }

        private void rbDepositNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDepositNo.Checked)
            {
                tbDeposit.Text = "0.00";
            }
            else
            {
                Model.GetAllReservations();
                Model.GetAllRooms();
                foreach (IReservation reservation in Model.ReservationsList)
                {
                    if (reservation.ReservationID == ReservationID)
                    {
                        foreach (IRoom room in Model.RoomsList)
                        {
                            if (room.RoomNumber == Convert.ToInt32(cbRoomNum.SelectedItem))
                            {
                                int numNights = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
                                tbRoomPrice.Text = (room.BasePrice * numNights).ToString();
                                if (rbDepositYes.Checked)
                                {
                                    tbDeposit.Text = (Convert.ToInt32(tbRoomPrice.Text) * 0.1).ToString();
                                }
                                else
                                {
                                    tbDeposit.Text = "0.00";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void gbGuest_Enter(object sender, EventArgs e)
        {

        }
    }
}
