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
    public partial class formViewRoomBookings : Form
    {

        private FormContainer fc;
        private IModel Model;


        public formViewRoomBookings(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void FormViewRoomBookings_Load(object sender, EventArgs e)
        {
            Model.GetAllRooms();
            Model.GetAllReservations();
            Model.GetAllGuests();



            DisplayChart(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month);
           


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            DisplayChart(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month);
        }

        public void DisplayChart(int year, int month)
        {


            //Find Day numbers for given month and year
            List<DateTime> list = new List<DateTime>();
            DateTime date = new DateTime(year, month, 1);

            do
            {
                list.Add(date);
                date = date.AddDays(1);
            } while (date.Month == month);

            dataGridView1.Columns.Add("Room", "Room");

            // Add the month day values in the columns
            foreach (DateTime d in list)
            {
                dataGridView1.Columns.Add(d.Date.ToShortDateString(), d.Date.ToShortDateString());
                //DataGridViewColumn column = dataGridView1.Columns[d.Day.ToString()];
                //column.Width = 10;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.Columns["Room"].Frozen = true;
            








            // Add Room and Room type to the first column 
            foreach (Room item in Model.RoomsList)
            {
                string smoking = "Smoking";
                if (item.Smoking == false)
                {
                    smoking = "Non-Smoking";
                }
                dataGridView1.Rows.Add(item.RoomNumber + " " + item.RoomType + " " + smoking);
            }
           



            //Display the data from the reservation objects 

            foreach (Reservation r in Model.ReservationsList)
            {
                //if (r.CheckInDate.Month == month && r.CheckInDate.Year==year)
               // {


                    // list to hold date number for given dates
                    List<DateTime> dates = new List<DateTime>();
                    //gets the date number for day and adds it to list
                    for (var dt = r.CheckInDate; dt <= r.CheckOutDate; dt = dt.AddDays(1))
                    {
                        dates.Add(dt);
                    }
                    //shade the days in grid with the days of the reservation.
                    foreach (DateTime d in dates)
                    {

                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            DataGridViewColumnHeaderCell headerCell = column.HeaderCell;
                            string headerCaptionText = column.HeaderText;
                            string columnName = column.Name; // Used as a key to myDataGridView.Columns['key_name'];

                            
                            if (columnName == d.Date.ToShortDateString())
                            {
                                dataGridView1.Rows[r.RoomNumber - 1].Cells[d.Day].Style.BackColor = Color.Red;
                            }
                        }

                    }
                    dates.Clear();
                //}
                
            }
            dataGridView1.Rows[1].Frozen = true;
            list.Clear();
        }
    }
}
