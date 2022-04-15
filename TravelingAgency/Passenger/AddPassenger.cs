using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelingAgency.EF;
using TravelingAgency.Modals;

namespace TravelingAgency
{
    public partial class AddPassenger : masterForm
    {
        public AddPassenger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new FlightDBContext())
            {
                // Note: This sample requires the database to be created before running.
                Debug.WriteLine($"Database path: {db.DbPath}.");

                // Create
                Debug.WriteLine("Inserting a new blog");
                db.Add(new Passenger {
                    Id = short.Parse(passId.Text),
                    Name = PassName.Text,
                    Address = PassAddress.Text,
                    Gender = cbxGender.Text,
                    Nationality = cbxNationality.Text,
                    PassportNumber = PassportNumb.Text,
                    Phone = phoneNumber.Text,
                    Age = passngerAge.Text,
                });
                db.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassengersTbl viewPassengers = new();
            viewPassengers.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home hm = new();
            hm.Show();
            Hide();
        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }
    }
}
