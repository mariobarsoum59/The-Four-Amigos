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
            // TODO: This line of code loads data into the 'bloomFeildHotelDataSetRes.reservations' table. You can move, or remove it, as needed.
            //this.reservationsTableAdapter.Fill(this.bloomFeildHotelDataSetRes.reservations);
            dataGridView1.DataSource = Model.ReservationsList;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGoResID_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;
            }
            string searchValue = textBox1.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue, StringComparison.InvariantCultureIgnoreCase))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMangeRes_Click(object sender, EventArgs e)
        {
            String reservation = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); ;
            String[] reservationDetails = reservation.Split(' ');
            int ReservationID = Int32.Parse(reservationDetails[0]);
            formManageReservation form = new formManageReservation(fc, Model, ReservationID);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
