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
            foreach(Room room in Model.RoomsList)
            {
                listBox1.Items.Add(room.RoomNumber);
            }

        }
    }
}
