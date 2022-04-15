using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelingAgency
{
    public partial class Home : masterForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AddFlights vf = new();
            vf.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPassenger ap = new();
            ap.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTickets tkts = new();
            tkts.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CancelTickets ct = new();
            ct.Show();
            Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            dateToday.Text = DateTime.Today.ToString("d");
            clock.Text = DateTime.Now.ToString("t");
            dateTimer.Start();
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("t");
        }
    }
}
