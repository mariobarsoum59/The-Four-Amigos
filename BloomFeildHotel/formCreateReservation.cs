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
    public partial class formCreateReservation : Form
    {
        private FormContainer fc;
        private IModel Model;

        public formCreateReservation(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCreateReservation_Load(object sender, EventArgs e)
        {
            Model.GetAllRooms();
            Model.GetAllReservations();
            Model.GetAllGuests();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {


            //List<Room> availableRooms = new List<Room>();

            //Rooms available in selected period

            //foreach(Reservation r in Model.ReservationsList)
            //{
            //    foreach(Room rm in Model.RoomsList)
            //    {
            //        if (DTPCheckInDate.Value.Date <= r.CheckInDate.Date && DTPCheckOutDate.Value.Date >= r.CheckOutDate.Date) 
            //        {
                        
            //            MessageBox.Show(r.CheckInDate.Date+ " -------" + DTPCheckInDate.Value.Date);
            //        }
            //        else
            //        {
            //            availableRooms.Add(rm);
            //        }
            //    }

            //}


            listBoxSelectedRoom.Items.Clear();
            foreach (Room room in Model.RoomsList)
            {
                if (radioButtonSmoking.Checked && radioButtonSingle.Checked && room.Smoking == true && room.RoomType=="Single") //single smoking
                {
                    listBoxSelectedRoom.Items.Add(room.RoomNumber);
                }
                else if (radioButtonNonSmoking.Checked && radioButtonSingle.Checked && room.Smoking == false && room.RoomType == "Single") //single nonsmoking
                {
                    listBoxSelectedRoom.Items.Add(room.RoomNumber);
                }

                else if (radioButtonSmoking.Checked && radioButtonDouble.Checked && room.Smoking == true && room.RoomType == "Double")//Double Smoking
                {
                    listBoxSelectedRoom.Items.Add(room.RoomNumber);
                }

                else if (radioButtonNonSmoking.Checked && radioButtonDouble.Checked && room.Smoking == false && room.RoomType == "Double") //single nonsmoking
                {
                    listBoxSelectedRoom.Items.Add(room.RoomNumber);
                }


                else if (radioButtonSmoking.Checked && radioButtonTwin.Checked && room.Smoking == true && room.RoomType == "Twin")//Double Smoking
                {
                    listBoxSelectedRoom.Items.Add(room.RoomNumber);
                }

                else if (radioButtonNonSmoking.Checked && radioButtonTwin.Checked && room.Smoking == false && room.RoomType == "Twin") //single nonsmoking
                {
                    listBoxSelectedRoom.Items.Add(room.RoomNumber);
                }

            }


            TimeSpan numofnights = DTPCheckOutDate.Value.Date.Subtract(DTPCheckInDate.Value.Date);
            textBoxNumOfNights.Text = numofnights.Days.ToString();

         

        }

        private void ListBoxSelectedRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSelectedRoom.SelectedIndex<0)
            {
                textBoxRoomNumber.Clear();
                textBoxBasePrice.Clear();
                textBoxVariablePrice.Clear();
            }
            else if (listBoxSelectedRoom.Items.Count==0)
            {
                textBoxRoomNumber.Clear();
                textBoxBasePrice.Clear();
                textBoxVariablePrice.Clear();
            }

            else
            {
                foreach(Room room in Model.RoomsList)
                {
                    if(listBoxSelectedRoom.SelectedItem.ToString()==room.RoomNumber.ToString())
                    {
                        textBoxRoomNumber.Text = room.RoomNumber.ToString();
                        textBoxBasePrice.Text = room.BasePrice.ToString();
                    }

                }

            }
            TimeSpan numofnights = DTPCheckOutDate.Value.Date.Subtract(DTPCheckInDate.Value.Date);
            textBoxNumOfNights.Text = numofnights.Days.ToString();

            int numnights = Convert.ToInt32(numofnights.Days.ToString());
            double BPrice = Convert.ToDouble(textBoxBasePrice.Text);
            double PricePerNight = 20.00;
            double vPrice = BPrice + (PricePerNight * numnights);

            textBoxVariablePrice.Text = vPrice.ToString();

        }

        private void BtnSubmitReservation_Click(object sender, EventArgs e)
        {
            bool sendMInfo = false;
            int guestID = 0;
            int numofchildren= Convert.ToInt32(textBoxNumOfChildren.Text);
            int numofAdults= Convert.ToInt32(textBoxNumOfAdults.Text); ;
            double Price= Convert.ToDouble(textBoxVariablePrice.Text); ;
            bool DepositPayed = false;
            bool PayedInFull = false;
            if (radioButtonDPYes.Checked)
            {
                DepositPayed = true;
            }
            if(radioButtonPIFYes.Checked)
            {
                PayedInFull = true;
            }

            if(radioButtonMIYes.Checked)
            {
                sendMInfo = true;
            }
            if (Model.addNewGuest(textBoxFirstName.Text, textBoxSurname.Text, textBoxContact.Text, textBoxAddress.Text, textBoxEmail.Text, sendMInfo));
            {
                MessageBox.Show("Guest Added");
            }


            foreach(Guest g in Model.GuestsList)
            {
                if(g.Email==textBoxEmail.Text&&g.FirstName==textBoxFirstName.Text)
                {
                    guestID = g.GuestID;
                }
            }


            if(Model.addNewReservation(DTPCheckInDate.Value.Date,DTPCheckOutDate.Value.Date,numofAdults,numofchildren,Price,DepositPayed,PayedInFull,guestID,1))
            {
                MessageBox.Show("Reservation Added");
            }
        }
    }
}
