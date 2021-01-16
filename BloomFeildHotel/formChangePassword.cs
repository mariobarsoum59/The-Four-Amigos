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

namespace BloomFeildHotel
{
    public partial class formChangePassword : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formChangePassword(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void tbReportID_TextChanged(object sender, EventArgs e)
        {

        }

        private void formChangePassword_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Model.CurrentUser.Username;
            txtOldPassword.PasswordChar = '*';
            txtNewPassword1.PasswordChar = '*';
            txtNewPassword2.PasswordChar = '*';
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtOldPassword.Text == Model.CurrentUser.Password)
            {
                string newPassword = txtNewPassword1.Text;
                if(newPassword.Length >= 8 && newPassword.Any(char.IsUpper))
                {
                    if(newPassword.Equals(txtNewPassword2.Text))
                    {
                        Model.CurrentUser.Password = newPassword;
                        if(Model.changePassword(Model.CurrentUser))
                        {
                            MessageBox.Show("Password changed successfully");
                            txtOldPassword.Text = "";
                            txtNewPassword1.Text = "";
                            txtNewPassword2.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error changing password, please try again");
                            txtOldPassword.Text = "";
                            txtNewPassword1.Text = "";
                            txtNewPassword2.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match, please try again");
                        txtOldPassword.Text = "";
                        txtNewPassword1.Text = "";
                        txtNewPassword2.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("New password must be at least 8 characters long and must contain an upper case letter");
                    txtOldPassword.Text = "";
                    txtNewPassword1.Text = "";
                    txtNewPassword2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Incorrect password, please try again");
                txtOldPassword.Text = "";
                txtNewPassword1.Text = "";
                txtNewPassword2.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPassword.PasswordChar = '\0';
            txtNewPassword1.PasswordChar = '\0';
            txtNewPassword2.PasswordChar = '\0';
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPassword.PasswordChar = '*';
            txtNewPassword1.PasswordChar = '*';
            txtNewPassword2.PasswordChar = '*';
        }
    }
}
