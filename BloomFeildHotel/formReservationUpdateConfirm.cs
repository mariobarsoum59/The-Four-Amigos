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
    public partial class formReservationUpdateConfirm : Form
    {
        private FormContainer fc;
        private IModel Model;
        private int ReservationID;
        private int GuestID;
        public formReservationUpdateConfirm(FormContainer parent, IModel Model, int ReservationID, int GuestID)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            this.ReservationID = ReservationID;
            this.GuestID = GuestID;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (IReservation reservation in Model.ReservationsList)
            {
                if (reservation.ReservationID == this.ReservationID)
                {
                    foreach(IGuest guest in Model.GuestsList)
                    {
                        if(guest.GuestID == this.GuestID)
                        {
                            if (Model.updateReservation(reservation) && Model.updateGuest(guest))
                            {
                                MessageBox.Show("The reservation has been updated");
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("There was an error updating the reservation");
                                Close();
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
    }
}
