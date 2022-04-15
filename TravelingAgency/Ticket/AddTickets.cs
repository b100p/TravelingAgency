using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelingAgency.EF;
using TravelingAgency.Modals;

namespace TravelingAgency
{
    public partial class AddTickets : masterForm
    {
        public AddTickets()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            using (var db = new FlightDBContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");

                // Read
                Console.WriteLine("Querying for a blog");
                dataGridView1.DataSource = db.Tickets.ToList()!=null? db.Tickets.ToList():"";

                var passengers = db.Passengers.ToList();
                var flights= db.Flights.ToList();
                List<string> fCodes = new();
                List<int> pCodes = new();
                foreach (var f in flights)
                {
                    fCodes.Add(f.Fcode);
                }
                foreach (var p in passengers)
                {
                    pCodes.Add(p.Id);
                }
                passengerId.DataSource = pCodes;
                flightCode.DataSource = fCodes;
                var firstPassenger = passengers.Where(p => p.Id == pCodes.First()).First();
                passName.Text = firstPassenger.Name;
                passNationlity.Text = firstPassenger.Nationality;
                passportNumber.Text = firstPassenger.PassportNumber;
                passAge.Text = firstPassenger.Age;
            }
        }

        private void passengerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new FlightDBContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");

                // Read
                Console.WriteLine("Querying for a blog");
                var passengers = db.Passengers.ToList();
                var firstPassenger = passengers.Where(p => p.Id == short.Parse(passengerId.Text)).First();
                passName.Text = firstPassenger.Name;
                passNationlity.Text = firstPassenger.Nationality;
                passportNumber.Text = firstPassenger.PassportNumber;
                passAge.Text = firstPassenger.Age;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new FlightDBContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");

                // Read
                Console.WriteLine("Querying for a blog");
                var passengers = db.Passengers.ToList();
                var flights = db.Flights.ToList();
                
                var selectedPassenger = passengers.Where(p => p.Id == short.Parse(passengerId.Text)).First();
                var selectedFlight = flights.Where(p => p.Fcode == flightCode.Text).First();
                Ticket tkt = new();
                tkt.Fcode = selectedFlight.Fcode;
                tkt.PassengerId= selectedPassenger.Id.ToString();
                tkt.Amount = amnt.Text;
                tkt.Id = ticketCode.Text;
                db.Add(tkt);
                db.SaveChanges();
                dataGridView1.DataSource = db.Tickets.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new();
            hm.Show();
            Hide();
        }
    }
}
