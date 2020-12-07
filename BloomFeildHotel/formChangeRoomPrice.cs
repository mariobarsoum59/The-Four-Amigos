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
    public partial class formChangeRoomPrice : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formChangeRoomPrice(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormChangeRoomPrice_Load(object sender, EventArgs e)
        {
            Model.GetAllRooms();
            foreach (Room room in Model.RoomsList)
            {
                listBox1.Items.Add(room.RoomNumber);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

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

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                foreach (Room r in Model.RoomsList)
                {
                    if (Convert.ToInt32(listBox1.SelectedItem.ToString()) == r.RoomNumber)
                    {
                        txtType.Text = r.RoomType;
                        txtSmoking.Text = r.Smoking.ToString();
                        txtAvailable.Text = r.Available.ToString();
                        txtBasePrice.Text = r.BasePrice.ToString();
                    }
                }
                   



            }

            
        }

        private void BtnChangeBasePrice_Click(object sender, EventArgs e)
        {
            foreach(Room r in Model.RoomsList)
            {
                if(listBox1.SelectedItem.ToString()==r.RoomNumber.ToString())
                {
                    r.BasePrice = Convert.ToDouble(txtBasePrice.Text);
                    if(Model.UpdateRoomPrice(r))
                    {
                        MessageBox.Show("Room Price Updated");
                    }
                }
            }


            
        }
    }
}
