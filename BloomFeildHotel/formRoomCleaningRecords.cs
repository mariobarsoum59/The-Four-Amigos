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
using BusinessEntities;


namespace BloomFeildHotel
{
    public partial class formRoomCleaningRecords : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formRoomCleaningRecords(FormContainer parent, IModel Model)
        {
            InitializeComponent();

            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void FormRoomCleaningRecords_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            Model.GetAllRooms();
            Model.GetAllRoomCleaningRecords();
            foreach (Room room in Model.RoomsList)
            {
                listBox1.Items.Add(room.RoomNumber);
            }
            dataGridView1.DataSource = Model.RoomCleaningRecordsList;
            

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
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
            List<RoomCleaningRecord> selectedRoomList = new List<RoomCleaningRecord>();
            
                foreach(RoomCleaningRecord rc in Model.RoomCleaningRecordsList)
                {
                    if(rc.RoomNumber==Convert.ToInt32(listBox1.SelectedItem.ToString()))
                    {
                        selectedRoomList.Add(rc);
                        
                    }
                }
            
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource = selectedRoomList;
            dataGridView1.Refresh();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Room room in Model.RoomsList)
            {
                listBox1.Items.Add(room.RoomNumber);
            }

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = Model.RoomCleaningRecordsList;
            dataGridView1.Refresh();
        }
    }
}
