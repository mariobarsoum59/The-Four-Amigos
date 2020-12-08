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
    public partial class formMarkRoomCleaned : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formMarkRoomCleaned(FormContainer parent, IModel Model)
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

        private void FormMarkRoomCleaned_Load(object sender, EventArgs e)
        {
            Model.GetAllRooms();
            Model.GetAllRoomCleaningRecords();
            foreach(Room room in Model.RoomsList)
            {
                listBox1.Items.Add(room.RoomNumber);
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            bool smoking = false;
            bool Available = true;

            if(comboBoxSmoking.SelectedItem.ToString()== "Yes")
            {
                smoking = true;
            }

            if(comboBoxAvailable.SelectedItem.ToString()=="Not Available")
            {
                Available = false;
            }


            foreach(Room r in Model.RoomsList)
            {
                if (r.RoomType == comboBoxRType.SelectedItem.ToString() && r.Smoking == smoking && r.Available == Available) 
                {
                    listBox1.Items.Add(r.RoomNumber);
                }
            }




        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                foreach(RoomCleaningRecord record in Model.RoomCleaningRecordsList)
                {
                    if (Convert.ToInt32(listBox1.SelectedItem.ToString()) == record.RoomNumber)
                    {
                        txtLastCleanDate.Text = record.CleanedAt.ToString();
                        //textBoxNoteArea.Text = record.Note;
                    }
                }
               
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            if (Model.addNewRoomCleaningRecord(Convert.ToInt32(listBox1.SelectedItem.ToString()), date, textBoxNoteArea.Text))
            {
                MessageBox.Show("Cleaning Record Made");
                textBoxNoteArea.Clear();
                foreach (RoomCleaningRecord record in Model.RoomCleaningRecordsList)
                {
                    if(record.RoomNumber== Convert.ToInt32(listBox1.SelectedItem.ToString()))
                    {
                        txtLastCleanDate.Text = record.CleanedAt.ToString();
                    }
                }
                    
            }
        }

        
    }
}
