using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AirlineManagementSystem
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void MyProgressBar_Click(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            MyProgressBar.Value = startpoint;
            PercentageLbl.Text = startpoint + "%";
            if(MyProgressBar.Value==100)
            {
                MyProgressBar.Value = 0;
                timer1.Stop();
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void PercentLab_Click(object sender, EventArgs e)
        {

        }

        private void PercentageLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
