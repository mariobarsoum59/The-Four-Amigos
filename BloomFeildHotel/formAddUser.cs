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
            //search to see if username already exsits
            bool usernameExists = false;

            //foreach(User u in Model.UserList)
            //{
            //    if(u.UName==txtUsername.Text)
            //    {
            //        usernameExists = true;
            //        MessageBox.Show("Username already exists");
            //        txtUsername.Clear();
            //    }
                
            //}


            //if it does not exist creat user object and add to db and update userlist
            if (usernameExists == false && listBoxUserTypes.SelectedIndex !=-1)
            {
                
                if(Model.addNewUser(txtFirstName.Text, txtSurname.Text, txtUsername.Text, txtPassword.Text, listBoxUserTypes.SelectedItem.ToString()))
                {
                    MessageBox.Show("User created");
                }
                

               
            }

            ////check to see if added
            //foreach (User u in Model.UserList)
            //{
            //    if (u.UName == txtUsername.Text)
            //    {
            //        usernameExists = true;
            //        MessageBox.Show("User Added");
                    txtFirstName.Clear();
                    txtSurname.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                //}

            //}





        }
    }
}
