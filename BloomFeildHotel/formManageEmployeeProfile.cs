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
    public partial class formManageEmployeeProfile : Form
    {
        private FormContainer fc;
        private IModel Model;
        private IUser employee;
        public formManageEmployeeProfile(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            employee.Username = txtUsername.Text;
            employee.FirstName = txtFirstName.Text;
            employee.Surname = txtSurname.Text;
            employee.UserType = cbDepartment.SelectedItem.ToString();
            if(Model.editUser(employee))
            {
                MessageBox.Show("Employee profile has been updated");

            }
            else
            {
                MessageBox.Show("Update was unsuccessful, please try again later");
            }
            txtUsername.Text = "";
            txtFirstName.Text = "";
            txtSurname.Text = "";
            lbUsers.Items.Clear();
            cbDepartment.Items.Clear();
            List<String> departments = new List<String>();
            foreach (IUser user in Model.UserList)
            {
                if (!departments.Contains(user.UserType))
                {
                    departments.Add(user.UserType);
                    cbDepartment.Items.Add(user.UserType);
                }
                if (user != Model.CurrentUser)
                {
                    lbUsers.Items.Add(user.Username + " - " + user.FirstName + " " + user.Surname + " - " + user.UserType);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string firstname = "";
            string surname = "";
            lbUsers.Items.Clear();
            if (txtFNameSearch.Text == "" && txtSNameSearch.Text == "")
            {
                MessageBox.Show("Please enter a first or last name to search for");
            }
            else if(txtFNameSearch.Text != "" && txtSNameSearch.Text == "")
            {
                firstname = txtFNameSearch.Text;
                foreach (IUser user in Model.UserList)
                {
                    if (user != Model.CurrentUser)
                    {
                        if (user.FirstName == firstname)
                        {
                            lbUsers.Items.Add(user.Username + " - " + user.FirstName + " " + user.Surname + " - " + user.UserType);
                        }
                    }
                }
            }
            else if(txtFNameSearch.Text == "" && txtSNameSearch.Text != "")
            {
                surname = txtSNameSearch.Text;
                foreach (IUser user in Model.UserList)
                {
                    if (user != Model.CurrentUser)
                    {
                        if (user.Surname == surname)
                        {
                            lbUsers.Items.Add(user.Username + " - " + user.FirstName + " " + user.Surname + " - " + user.UserType);
                        }
                    }
                }
            }
            else
            {
                firstname = txtFNameSearch.Text;
                surname = txtSNameSearch.Text;
                foreach (IUser user in Model.UserList)
                {
                    if(user != Model.CurrentUser)
                    {
                        if (user.FirstName == firstname && user.Surname == surname)
                        {
                            lbUsers.Items.Add(user.Username + " - " + user.FirstName + " " + user.Surname + " - " + user.UserType);
                        }
                    }
                }
            }
            txtFNameSearch.Text = "";
            txtSNameSearch.Text = "";
        }

        private void formManageEmployeeProfile_Load(object sender, EventArgs e)
        {
            lbUsers.Items.Clear();
            cbDepartment.Items.Clear();
            List<String> departments = new List<String>();
            foreach(IUser user in Model.UserList)
            {
                if(!departments.Contains(user.UserType))
                {
                    departments.Add(user.UserType);
                    cbDepartment.Items.Add(user.UserType);
                }
                if(user != Model.CurrentUser)
                {
                    lbUsers.Items.Add(user.Username + " - " + user.FirstName + " " + user.Surname + " - " + user.UserType);
                }
            }
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string report = lbUsers.SelectedItem.ToString();
            string sep = " ";
            string[] splitContent = report.Split(sep.ToCharArray());
            txtUsername.Text = "";
            txtFirstName.Text = "";
            txtSurname.Text = "";
            foreach (IUser user in Model.UserList)
            {
                if(user.Username == splitContent[0])
                {
                    txtUsername.Text = user.Username;
                    txtFirstName.Text = user.FirstName;
                    txtSurname.Text = user.Surname;
                    cbDepartment.SelectedItem = user.UserType;
                    this.employee = user;
                }
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            lbUsers.Items.Clear();
            foreach (IUser user in Model.UserList)
            {
                if (user != Model.CurrentUser)
                {
                    lbUsers.Items.Add(user.Username + " - " + user.FirstName + " " + user.Surname + " - " + user.UserType);
                }
            }
            txtFNameSearch.Text = "";
            txtSNameSearch.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(Model.deleteUser(employee))
            {
                MessageBox.Show("Employee profile has been deleted");
            }
            else
            {
                MessageBox.Show("Deletion unsuccessful, please try again later");
            }
            txtUsername.Text = "";
            txtFirstName.Text = "";
            txtSurname.Text = "";
            lbUsers.Items.Clear();
            cbDepartment.Items.Clear();
            List<String> departments = new List<String>();
            foreach (IUser user in Model.UserList)
            {
                if (!departments.Contains(user.UserType))
                {
                    departments.Add(user.UserType);
                    cbDepartment.Items.Add(user.UserType);
                }
                if (user != Model.CurrentUser)
                {
                    lbUsers.Items.Add(user.Username + " - " + user.FirstName + " " + user.Surname + " - " + user.UserType);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
