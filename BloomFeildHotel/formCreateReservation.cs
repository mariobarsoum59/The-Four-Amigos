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
using System.Net.Mail;
using System.Net;

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
            DTPCheckInDate.MinDate= DateTime.Today;
            DTPCheckOutDate.MinDate = DTPCheckInDate.Value.AddDays(1);


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {


            List<Room> availableRooms = new List<Room>();
            Model.GetRoomsForDates(DTPCheckInDate.Value.Date.ToString("yyyy-MM-dd"), DTPCheckOutDate.Value.Date.ToString("yyyy-MM-dd"));

            

            listBoxSelectedRoom.Items.Clear();
            foreach (Room room in Model.RoomsOnGivenDates)
            {
                if (radioButtonSmoking.Checked && radioButtonSingle.Checked && room.Smoking == true && room.RoomType == "Single") //single smoking
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
                //listBoxSelectedRoom.Items.Add(room.RoomNumber);
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

            double vPrice = BPrice * numnights;

            textBoxVariablePrice.Text = vPrice.ToString();

        }

        private void BtnSubmitReservation_Click(object sender, EventArgs e)
        {
           
            int guestID = 0;
            int numofchildren= Convert.ToInt32(textBoxNumOfChildren.Text);
            int numofAdults= Convert.ToInt32(textBoxNumOfAdults.Text); 
            double Price= Convert.ToDouble(textBoxVariablePrice.Text); 
            bool DepositPayed = false;
            bool PayedInFull = false;
            int roomnum = Convert.ToInt32(textBoxRoomNumber.Text);
            if (radioButtonDPYes.Checked)
            {
                DepositPayed = true;
            }
            if(radioButtonPIFYes.Checked)
            {
                PayedInFull = true;
            }

           
           


            foreach(Guest g in Model.GuestsList)
            {
                if(g.Email==textBoxEmail.Text&&g.FirstName==textBoxFirstName.Text && g.ContactNumber==textBoxContact.Text)
                {
                    guestID = g.GuestID;
                }
            }


            if(Model.addNewReservation(DTPCheckInDate.Value.Date,DTPCheckOutDate.Value.Date,numofAdults,numofchildren,Price,DepositPayed,PayedInFull,guestID,roomnum,false))
            {
                foreach(Reservation r in Model.ReservationsList)
                {
                    if(r.CheckInDate.Date==DTPCheckInDate.Value.Date && r.CheckOutDate.Date==DTPCheckOutDate.Value.Date && r.RoomNumber==Convert.ToInt32(textBoxRoomNumber.Text))
                    {
                        MessageBox.Show("Reservation Added\n\n\n\n  Reservation Number:" + r.ReservationID);

                        try
                        {
                            MailMessage message = new MailMessage();
                            SmtpClient smtp = new SmtpClient();

                            message.From = new MailAddress("bloomfieldhotel1@gmail.com");
                            message.To.Add(new MailAddress(textBoxEmail.Text));
                            message.Subject = "Your Reservation At the BloomField Hotel Reservation Number is : " + r.ReservationID.ToString();
                            message.Body = "<h1>Reservation Number is : " + r.ReservationID.ToString() + "</h1> <br> <h3>Hi "+ textBoxFirstName.Text +"<br> We are looking forward to seeing you. <br>Your Check in Date is " + DTPCheckInDate.Value.ToShortDateString() +"<br> The Total Price For The reservation has come in at €"+ textBoxVariablePrice.Text + "<br>Please Present this email" +
                                " to the Receptionist and they will assist you at your arival, until then <br<br>Thank You for choosing BloomField Hotel</h3>";

                            message.IsBodyHtml = true;
                            

                            smtp.Port = 587;
                            smtp.Host = "smtp.gmail.com";
                            smtp.EnableSsl = true;
                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("bloomfieldhotel1@gmail.com", "Bloom123");
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Send(message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("err: " + ex.Message);
                        }












                    }
                }
                
            }
        }

        private void DTPCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            DTPCheckOutDate.MinDate = DTPCheckInDate.Value.AddDays(1);
        }

        private void BtnSelectExistingGuest_Click(object sender, EventArgs e)
        {
            formSavedGuests frm2 = new formSavedGuests(Model);
            frm2.Show();

            frm2.FormClosed += new FormClosedEventHandler(Form_Closed);
        }
        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            RefreshList();
        }
        private void BtnEnterSelectedGuestData_Click(object sender, EventArgs e)
        {
            foreach(Guest g in Model.GuestsList)
            {
                if(g.GuestID==Model.SelectedGuestID)
                {
                    textBoxFirstName.Text = g.FirstName;
                    textBoxSurname.Text = g.Surname;
                    textBoxContact.Text = g.ContactNumber;
                    textBoxAddress.Text = g.Address;
                    textBoxEmail.Text = g.Email;
                    if(g.SendMarketingInfo==false)
                    {
                        radioButtonMINo.Checked=true;
                    }
                    else
                    {
                        radioButtonMIYes.Checked = true;
                    }
                    
                }

            }
        }

        public void RefreshList()
        {
            foreach (Guest g in Model.GuestsList)
            {
                if (g.GuestID == Model.SelectedGuestID)
                {
                    textBoxFirstName.Text = g.FirstName;
                    textBoxSurname.Text = g.Surname;
                    textBoxContact.Text = g.ContactNumber;
                    textBoxAddress.Text = g.Address;
                    textBoxEmail.Text = g.Email;
                    if (g.SendMarketingInfo == false)
                    {
                        radioButtonMINo.Checked = true;
                    }
                    else
                    {
                        radioButtonMIYes.Checked = true;
                    }

                }

            }
        }


        private void BtnAddGuest_Click(object sender, EventArgs e)
        {
            bool sendMInfo = false;
            if (radioButtonMIYes.Checked)
            {
                sendMInfo = true;
            }

            if (Model.addNewGuest(textBoxFirstName.Text, textBoxSurname.Text, textBoxContact.Text, textBoxAddress.Text, textBoxEmail.Text, sendMInfo))
            {
                MessageBox.Show("Guest Added");
            }
        }

        private void BtnRoomChart_Click(object sender, EventArgs e)
        {
            formViewRoomBookings f3 = new formViewRoomBookings(fc, Model);
            f3.Show();
        }
    }
}
