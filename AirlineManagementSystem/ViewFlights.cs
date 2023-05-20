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
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }
        static string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseString"].ConnectionString;
        SqlConnection Con = new SqlConnection(conStr);
        private void populate()
        {
            Con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SflightDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewFlights_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            NseatsTb.Text = "";

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FlightTbl ftbl = new FlightTbl();
            ftbl.Show();
            populate();
            this.Hide();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(FcodeTb.Text=="")
            {
                MessageBox.Show("Enter The Flight To Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from FlightTbl where FCode ='" + FcodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SflightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FcodeTb.Text = SflightDGV.SelectedRows[0].Cells[0].Value.ToString();
            SrcCB.SelectedItem = SflightDGV.SelectedRows[0].Cells[1].Value.ToString();
            DestCB.SelectedItem = SflightDGV.SelectedRows[0].Cells[2].Value.ToString();
            NseatsTb.Text = SflightDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text=="" || NseatsTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update FlightTbl set FSrc='" + SrcCB.SelectedItem.ToString() + "',FDest='" + DestCB.SelectedItem.ToString() + "',FDate='" + FdatePicker.Value.Date.ToString() + "',FCap=" + NseatsTb.Text + " where FCode='" + FcodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void FdatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }
    }
}
