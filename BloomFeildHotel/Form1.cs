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
                case "Receptionist":
                    formReception form2 = new formReception(this, Model);
                    
                    this.Text = this.Text + "-Reception";
                    form2.Dock = DockStyle.Fill;
                    form2.Show();
                    break;
                case "BarStaff":
                    formBarStaff form3 = new formBarStaff(this, Model);
                    //formAddUser form1 = new formAddUser(this, model);
                    this.Text = this.Text + "-BarStaff";
                    form3.Dock = DockStyle.Fill;
                    form3.Show();
                    break;
                case "Chef":
                    formChef form4 = new formChef(this, Model);
                    //formAddUser form1 = new formAddUser(this, model);
                    this.Text = this.Text + "-BarStaff";
                    form4.Dock = DockStyle.Fill;
                    form4.Show();
                    break;
                case "Stock Manager":
                    formStockManager f5 = new formStockManager(this, Model);
                    this.Text = this.Text + "-Stock Manager";
                    f5.Dock = DockStyle.Fill;
                    f5.Show();
                    break;


            }


        }

        private void FormContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
