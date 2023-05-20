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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        static string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseString"].ConnectionString;
        SqlConnection Con = new SqlConnection(conStr);
        private void populate()
        {
            Con.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void fillPassenger()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from PassengerTbl",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(rdr);
            PIdCB.ValueMember = "PassId";
            PIdCB.DataSource = dt;
            Con.Close();
        }
        private void fillFlightCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select FCode from FlightTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FCode", typeof(string));
            dt.Load(rdr);
            FcodeCB.ValueMember = "FCode";
            FcodeCB.DataSource = dt;
            Con.Close();
        }
        string pname, ppass;
        string pnat;
        
        private void fetchPassenger()
        {
            Con.Open();
            string query = "select * from PassengerTbl where PassId=" + PIdCB.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query,Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                pname = dr["PassName"].ToString();
                ppass = dr["Passport"].ToString();
                pnat = dr["PassNat"].ToString();
                PNameTb.Text = pname;
                pPortTb.Text = ppass;
                NatCB.Text = pnat;
               

            }
            Con.Close();
        }
        private void Ticket_Load(object sender, EventArgs e)
        {
            fillPassenger();
            fillFlightCode();
            populate();
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

       

        private void BtnReset_Click(object sender, EventArgs e)
        {
            tIdTb.Text = "";
            amtTb.Text = "";
        }

        private void PIdCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PIdCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchPassenger();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void NatCB_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            if (tIdTb.Text == "" || PNameTb.Text == "" || amtTb.Text=="")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into TicketTbl values(" + tIdTb.Text + ",'" + FcodeCB.SelectedValue.ToString() + "'," + PIdCB.SelectedValue.ToString() + ",'" + PNameTb.Text + "','" + pPortTb.Text + "','" + NatCB.Text.ToString() + "'," + amtTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
