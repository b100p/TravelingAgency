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
    public partial class AddFlights : masterForm
    {
        public AddFlights()
        {
            InitializeComponent();
        }

        private void addNewFlight_Click(object sender, EventArgs e)
        {
            using (var db = new FlightDBContext())
            {
                // Note: This sample requires the database to be created before running.
                Debug.WriteLine($"Database path: {db.DbPath}.");

                // Create
                Debug.WriteLine("Inserting a new blog");
                db.Add(new Flight
                {
                    Fcode = flightCode.Text,
                    Fsrc = flightSrc.Text,
                    Fdst = flightDst.Text,
                    Fcap = flightCapacity.Text,
                    Fdate = flightDate.Value
                });
                db.SaveChanges();
            }
            }

        private void viewFlightTable_Click(object sender, EventArgs e)
        {
            FlightsTbl flightsTbl = new();
            flightsTbl.Show();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home hm = new();
            hm.Show();
            Hide();
        }
    }
}
