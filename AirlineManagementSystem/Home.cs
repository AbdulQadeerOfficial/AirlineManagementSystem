using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFlight_Click(object sender, EventArgs e)
        {
            FlightTbl ft = new FlightTbl();
            ft.Show();
            this.Hide();
        }

        private void BtnPassenger_Click(object sender, EventArgs e)
        {
            AddPassenger pt = new AddPassenger();
            pt.Show();
            this.Hide();
        }

        private void BtnTicket_Click(object sender, EventArgs e)
        {
            Ticket tk = new Ticket();
            tk.Show();
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
           CancellationTbl can = new CancellationTbl();
            can.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
