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
    public partial class formSearchReservation : Form
    {
        private FormContainer fc;
        private IModel Model;

        public formSearchReservation(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formSearchReservation_Load(object sender, EventArgs e)
        {
            Model.GetAllReservations();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GuestList.Items.Clear();

            bool smoking = false;
            bool Available = true;

            if (comboBoxSmoking.SelectedItem.ToString() == "Yes")
            {
                smoking = true;
            }

            if (comboBoxAvailable.SelectedItem.ToString() == "Not Available")
            {
                Available = false;
            }


            foreach (Room r in Model.RoomsList)
            {
                if (r.RoomType == comboBoxRType.SelectedItem.ToString() && r.Smoking == smoking && r.Available == Available)
                {
                    listBox1.Items.Add(r.RoomNumber);
                }
            }
        }
    }
}
