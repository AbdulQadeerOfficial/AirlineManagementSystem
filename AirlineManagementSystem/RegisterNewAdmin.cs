using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem
{
    public partial class RegisterNewAdmin : Form
    {
        public RegisterNewAdmin()
        {
            InitializeComponent();
        }
        static string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseString"].ConnectionString;
        SqlConnection con = new SqlConnection(conStr);
      
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (userIdTb.Text=="" || passTb.Text=="" || emailtb.Text=="" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    // Create a command to insert the data into the database 
                    SqlCommand cmd = new SqlCommand("INSERT INTO AdminRegister (Username, Password, Email) VALUES (@Username, @Password, @Email)", con);
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LoginTbl(UId,Password) VALUES (@Username, @Password)", con);
                    // Add the parameters to the command 
                    cmd.Parameters.AddWithValue("@Username", userIdTb.Text);
                    cmd.Parameters.AddWithValue("@Password", passTb.Text);
                    cmd.Parameters.AddWithValue("@Email", emailtb.Text);
                    cmd.ExecuteNonQuery();
                    cmd1.Parameters.AddWithValue("@Username", userIdTb.Text);
                    cmd1.Parameters.AddWithValue("@Password", passTb.Text);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Admin Registered Successfully!");
                    userIdTb.Text = "";
                    passTb.Text = "";
                    emailtb.Text = "";
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void RegisterNewAdmin_Load(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            userIdTb.Text = "";
            passTb.Text = "";
            emailtb.Text = "";
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
