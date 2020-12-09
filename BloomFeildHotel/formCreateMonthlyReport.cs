using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using BusinessLayer;

namespace BloomFeildHotel
{
    public partial class formCreateMonthlyReport : Form
    {
        private FormContainer fc;
        private IModel Model;
        public formCreateMonthlyReport(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
        }

        private void formCreateMonthlyReport_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
