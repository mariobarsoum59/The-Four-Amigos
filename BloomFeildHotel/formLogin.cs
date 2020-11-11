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
    public partial class formLogin : Form
    {
        private IModel Model;
        DataSet ds;                 //Declare the DataSet object
        SqlDataAdapter da;   //Declare the DataAdapter object
        int maxRows;
        SqlCommandBuilder cb;



        public formLogin(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
            //try
            //{
            //    ds = new DataSet();
            //    string sql = "SELECT * From Users";
            //    da = new SqlDataAdapter(sql, model.Con);
            //    cb = new SqlCommandBuilder(da);  //Generates
            //    da.Fill(ds, "UsersData");
            //    maxRows = ds.Tables["UsersData"].Rows.Count;
            //    for (int i = 0; i < maxRows; i++)
            //    {
            //        DataRow dRow = ds.Tables["UsersData"].Rows[i];
            //        User user = new User(dRow.ItemArray.GetValue(0).ToString(),
            //                                            dRow.ItemArray.GetValue(1).ToString(),
            //                                            dRow.ItemArray.GetValue(2).ToString(),
            //                                            dRow.ItemArray.GetValue(3).ToString(),
            //                                            dRow.ItemArray.GetValue(4).ToString());
            //        model.UserList.Add(user);
            //        //MessageBox.Show(user.Username + user.Password);

            //        textBoxName.Select();
            //    }
                
            //}
            //catch (System.Exception excep)
            //{
            //    MessageBox.Show(excep.Message);
            //    if (model.Con.State.ToString() == "Open")
            //        model.Con.Close();
            //    Application.Exit();
            //    //Environment.Exit(0); //Force the application to close
            //}






        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
          
           bool validUser = Model.login(textBoxName.Text, textBoxPassword.Text);
          
            if (validUser)
                Close();
            else
            {
                MessageBox.Show("Invalid name or password");
                textBoxName.Text = "";
                textBoxPassword.Text = "";
                textBoxName.Select();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
