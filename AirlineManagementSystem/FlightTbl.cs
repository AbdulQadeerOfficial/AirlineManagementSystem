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
    public partial class FlightTbl : Form
    {
        public FlightTbl()
        {
            InitializeComponent();
        }
        static string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseString"].ConnectionString;
        SqlConnection Con = new SqlConnection(conStr);

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnFRecord_Click(object sender, EventArgs e)
        {

            if (FcodeTb.Text=="" || FSrcCB.Text=="" || FDestCB.Text=="" || FcabTb.Text=="" ||FdateTb.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FlightTbl values('" + FcodeTb.Text + "','" + FSrcCB.SelectedItem.ToString() + "','" + FDestCB.SelectedItem.ToString() + "','"+FdateTb.Value.ToString()+"'," + FcabTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Recorded Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BtnFReset_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            FSrcCB.Text = "";
            FDestCB.Text = "";
            FcabTb.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void FlightTbl_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ViewFlights vf = new ViewFlights();
            vf.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void FDestCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
