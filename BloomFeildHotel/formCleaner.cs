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
    public partial class formCleaner : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formCleaner(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            formChangePassword form = new formChangePassword(fc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            formViewCleaner form = new formViewCleaner(fc, Model);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
