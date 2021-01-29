using System;
using BusinessEntities;
using BusinessLayer;
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
    public partial class formViewCleaner : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formViewCleaner(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void formViewCleaner_Load(object sender, EventArgs e)
        {
            Model.GetAllCleaner();

            foreach (ICleaner cleaner in Model.CleanerList)
            {
                if (cleaner.UserType == "Cleaner")
                {
                    lbCleaners.Items.Add(cleaner.FirstName);
                }
            }
        }

        private void lbCleaners_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (ICleaner cleaner in Model.CleanerList)
            {
                if (lbCleaners.SelectedItem.ToString() == cleaner.FirstName)
                { 
                    
                    txtFirstName.Text = cleaner.FirstName;
                    txtLastName.Text = cleaner.Surname;
                    txtUserName.Text = cleaner.Username;

                }
             }
            
        }
    

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
