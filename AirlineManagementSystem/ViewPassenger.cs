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
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }
        static string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseString"].ConnectionString;
        SqlConnection Con = new SqlConnection(conStr);
        private void populate()
        {
            Con.Open();
            string query = "select * from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AddPassenger addpas = new AddPassenger();
            addpas.Show();
            this.Hide();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(pIdTb.Text=="")
            {
                MessageBox.Show("Enter the passenger to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PassengerTbl where PassId=" + pIdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pIdTb.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();
            pNameTb.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
            pPassTb.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
            pAddTb.Text = PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
            natCB.SelectedItem = PassengerDGV.SelectedRows[0].Cells[4].Value.ToString();
            gendCB.SelectedItem = PassengerDGV.SelectedRows[0].Cells[5].Value.ToString();
            pPhoneTb.Text = PassengerDGV.SelectedRows[0].Cells[6].Value.ToString();


        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            pIdTb.Text = "";
            pNameTb.Text = "";
            pPassTb.Text = "";
            pAddTb.Text = "";
            pPhoneTb.Text = "";
            natCB.Text = "";
            gendCB.Text = "";

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(pIdTb.Text=="" || pNameTb.Text=="" || pPassTb.Text=="" || pAddTb.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
               try
                {
                    Con.Open();
                    string query = "update PassengerTbl set PassName='" + pNameTb.Text + "',Passport='"+pPassTb.Text+"',PassAd='"+pAddTb.Text+"',PassNat='"+natCB.SelectedItem.ToString()+"',PassGend='"+gendCB.SelectedItem.ToString()+"',PassPhone='"+pPhoneTb.Text+"' where PassId="+pIdTb.Text+";";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }
        }

        private void PIdTb_TextChanged(object sender, EventArgs e)
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
