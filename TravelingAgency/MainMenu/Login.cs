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
    public partial class Login : masterForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username.Text) || !string.IsNullOrEmpty(password.Text))
            {
                if(username.Text.ToLower() == "admin" && password.Text == "admin")
                {
                    Home hm = new();
                    hm.Show();
                    Hide();
                }
            }
        }
    }
}
