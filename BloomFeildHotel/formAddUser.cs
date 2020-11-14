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
            
            bool usernameExists = false;
            bool ValidPassword = false;




            string password = txtPassword.Text;

            if (password.Length > 8 && // Must be above 8 characters
                password.Any(char.IsUpper) && //At least one uppercase
                password.Any(char.IsLower) //At least one lowercase
                )
            {
                ValidPassword = true;

                if (usernameExists == false && listBoxUserTypes.SelectedIndex != -1)
                {

                    if (Model.addNewUser(txtFirstName.Text, txtSurname.Text, txtUsername.Text, txtPassword.Text, listBoxUserTypes.SelectedItem.ToString()))
                    {
                        MessageBox.Show("User created");
                    }

                    txtFirstName.Clear();
                    txtSurname.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    this.usersTableAdapter.Fill(this.bloomFeildHotelDataSetUsers.Users);
                    

                }
            }
            else
            {
                MessageBox.Show("Password Must Contain \nAtleast 8 Characters \nOne Upper Case Character \nOne Lower Case Character");
                txtPassword.Clear();
            }



        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloomFeildHotelDataSetUsers.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.bloomFeildHotelDataSetUsers.Users);

        }
    }
}
