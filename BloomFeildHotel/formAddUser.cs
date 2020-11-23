using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;

namespace BloomFeildHotel
{
    public partial class formAddUser : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formAddUser(FormContainer parent, IModel Model)
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

        private void BtnCommit_Click(object sender, EventArgs e)
        {



            string password = txtPassword.Text;
            bool PassOk = false;

            if (Model.PasswordCheck(password) && txtPassword.Text == textBoxConfirmPass.Text)
            {
                PassOk = true;
            }
            else
            {
                MessageBox.Show("Password Must Contain \nAtleast 8 Characters \nOne Upper Case Character \nOne Lower Case Character");
                txtPassword.Clear();
            }



            if (listBoxUserTypes.SelectedIndex != -1 && PassOk == true)
            {

                if (Model.addNewUser(txtFirstName.Text, txtSurname.Text, txtUsername.Text, txtPassword.Text, listBoxUserTypes.SelectedItem.ToString()))
                {
                    MessageBox.Show("User created");
                }

                txtFirstName.Clear();
                txtSurname.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                textBoxConfirmPass.Clear();
                this.usersTableAdapter.Fill(this.bloomFeildHotelDataSetUsers.Users);


            }
        }


        private void FormAddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloomFeildHotelDataSetUsers.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.bloomFeildHotelDataSetUsers.Users);

        }
    }
}
