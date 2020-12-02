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
    public partial class formReservationDeleteConfirm : Form
    {
        private FormContainer fc;
        private IModel Model;
        private int ReservationID;
        public formReservationDeleteConfirm(FormContainer parent, IModel Model, int ReservationID)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            this.ReservationID = ReservationID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formReservationDeleteConfirm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(IReservation reservation in Model.ReservationsList)
            {
                if(reservation.ReservationID == this.ReservationID)
                {
                    if(Model.deleteReservation(reservation))
                    {
                        MessageBox.Show("The reservation has been deleted");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("There was an error deleting the reservation");
                        Close();
                    }
                }
            }
        }
    }
}
