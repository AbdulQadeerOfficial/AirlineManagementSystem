using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem
{
    public partial class Login : Form
    {
        public string DatabaseConnectionString { get; private set; }

        public Login()
        {
            InitializeComponent();
        }
        string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseString"].ConnectionString;
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void PassTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string str = "SELECT UId FROM LoginTbl WHERE Password='" + passTb.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Visible = false;
                Home hm = new Home();
                hm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or Password.");
                uIdTb.Text = "";
                passTb.Text = "";
            }

           
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegAdmin_Click(object sender, EventArgs e)
        {
            RegisterNewAdmin reg = new RegisterNewAdmin();
            reg.Show();
            this.Hide();
        }
    }
}
