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
    public partial class CancelTickets : masterForm
    {
        public CancelTickets()
        {
            InitializeComponent();
        }

        private void CancelBookingTbl_Load(object sender, EventArgs e)
        {
            using (var db = new FlightDBContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");

                // Read
                Console.WriteLine("Querying for a blog");
                var tickets = db.Tickets.ToList();
                var flights = db.Flights.ToList();
                List<string> fCodes = new();
                List<string> tCodes = new();
                foreach (var f in flights)
                {
                    fCodes.Add(f.Fcode);
                }
                foreach (var t in tickets)
                {
                    tCodes.Add(t.Id);
                }
                tktId.DataSource = tCodes;
                flightCode.Text = tickets.Where(t => t.Id == tktId.Text).First().Fcode;
                dataGridView1.DataSource = db.CanceledTickets.ToList();
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
                CanceledTicket ct = new();
                ct.TicketId = tktId.Text;
                ct.Id = cancelId.Text;
                ct.CancelDate = cancelDate.Value;
                ct.Fcode = flightCode.Text;
                Ticket tkt = db.Tickets.Where(t=>t.Id == tktId.Text).First();
                db.Remove(tkt);
                db.Add(ct);
                db.SaveChanges();
                dataGridView1.DataSource = db.CanceledTickets.ToList();
            }
        }

        private void tktId_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new FlightDBContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");

                // Read
                Console.WriteLine("Querying for a blog");
                var tickets = db.Tickets.ToList();
                var flights = db.Flights.ToList();
                flightCode.Text = tickets.Where(t => t.Id == tktId.Text).First().Fcode;

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
