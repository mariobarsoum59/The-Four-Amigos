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
    public partial class formDeleteUser : Form
    {
        #region Instance Attributes
        IModel Model;
        FormContainer fc;
        #endregion 

        public formDeleteUser(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void FormDeleteUser_Load(object sender, EventArgs e)
        {

            foreach (User user in Model.UserList)
            {
                listBoxUsers.Items.Add(user.Username);
            }

            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete " + listBoxUsers.SelectedItem.ToString() + " ? ", "Are you sure !", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                foreach (User user in Model.UserList)
                {
                    if (user.Username == listBoxUsers.SelectedItem.ToString())
                    {
                        Model.deleteUser(user);
                        listBoxUsers.Items.Remove(listBoxUsers.SelectedItem); //remove name from listbox
                        break;
                    }
                }
            }
            
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
