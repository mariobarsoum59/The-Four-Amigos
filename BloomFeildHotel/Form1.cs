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
    public partial class FormContainer : Form
    {
        private IModel Model;
        public FormContainer(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;
        }


        private void formContainer_Shown(object sender, EventArgs e)
        {
            formLogin formLgn = new formLogin(Model);
            formLgn.ShowDialog();


            switch (Model.getUserTypeForCurrentuser())
            {
                case "Manager":
                    formManager form1 = new formManager(this, Model);
                    //formAddUser form1 = new formAddUser(this, model);
                    this.Text = this.Text + "-Manager";
                    form1.Dock = DockStyle.Fill;
                    form1.Show();
                    break;
                case "Reception":
                    formReception form2 = new formReception(this, Model);
                    //formAddUser form1 = new formAddUser(this, model);
                    this.Text = this.Text + "-Reception";
                    form2.Dock = DockStyle.Fill;
                    form2.Show();
                    break;


            }


        }







    }
}
