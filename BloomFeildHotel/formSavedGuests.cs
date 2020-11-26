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
    public partial class formSavedGuests : Form
    {
        int GuestID;
        private FormContainer fc;
        private IModel Model;
   

        public formSavedGuests(IModel Model)
        {
            InitializeComponent();
           
            this.Model = Model;
        }

        private void FormSavedGuests_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloomFeildHotelDataSet.guests' table. You can move, or remove it, as needed.
            this.guestsTableAdapter.FillBy1(this.bloomFeildHotelDataSet.guests);
           

        }

        private void BtnGoFname_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewGuests.Rows)
            {
                row.Selected = false;
            }
                string searchValue = textBox1.Text;

            dataGridViewGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridViewGuests.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue, StringComparison.InvariantCultureIgnoreCase))
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

        private void BtnGoSname_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewGuests.Rows)
            {
                row.Selected = false;
            }
            string searchValue = textBox2.Text;

            dataGridViewGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridViewGuests.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(searchValue, StringComparison.InvariantCultureIgnoreCase))
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

        private void DataGridViewGuests_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Model.SelectedGuestID = Convert.ToInt32(dataGridViewGuests.SelectedRows[0].Cells[0].Value);
            
            this.Close();
         
            
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.guestsTableAdapter.FillBy(this.bloomFeildHotelDataSet.guests);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.guestsTableAdapter.FillBy1(this.bloomFeildHotelDataSet.guests);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FormSavedGuests_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
    
}
