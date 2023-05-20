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
    public partial class CancellationTbl : Form
    {
        public CancellationTbl()
        {
            InitializeComponent();

        }
        static string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseString"].ConnectionString;

        SqlConnection Con = new SqlConnection(conStr);
        private void fillTicketId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TId from TicketTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TId", typeof(string));
            dt.Load(rdr);
            TIdTb.ValueMember = "TId";
            TIdTb.DataSource = dt;
            Con.Close();
        }
        private void fetchFCode()
        {
            Con.Open();
            string query = "select * from TicketTbl where TId=" + TIdTb.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FcodeTb.Text = dr["Fcode"].ToString();
            }
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TCancelDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void CancellationTbl_Load(object sender, EventArgs e)
        {
            fillTicketId();
            populate();
        }

        private void TIdTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TIdTb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchFCode();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CancIdTb.Text = "";
            FcodeTb.Text = "";
            TIdTb.Text = "";

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }
        private void deleteTicket()
        {
            try
            {
                Con.Open();
                string query = "delete from TicketTbl where TId ='"+TIdTb.SelectedValue.ToString()+"'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populate();
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (CancIdTb.Text == "" || FcodeTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CancelTbl values(" + CancIdTb.Text + "," + TIdTb.SelectedValue.ToString() + ",'" + FcodeTb.Text + "','" + dateCB.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Canceled Successfully");
                    Con.Close();
                    populate();
                    deleteTicket();
                    CancIdTb.Text = "";
                    FcodeTb.Text = "";
                    TIdTb.Text = "";
                    fillTicketId();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void TCancelDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FcodeTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
