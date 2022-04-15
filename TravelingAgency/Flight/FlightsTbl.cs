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

namespace TravelingAgency
{
    public partial class FlightsTbl : masterForm
    {
        public FlightsTbl()
        {
            InitializeComponent();
        }

        private void FlightsTbl_Load(object sender, EventArgs e)
        {
            using (var db = new FlightDBContext())
            {
                // Note: This sample requires the database to be created before running.
                Debug.WriteLine($"Database path: {db.DbPath}.");
                dataGridView1.DataSource = db.Flights.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddFlights vf = new();
            vf.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flightCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            flightSrc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            flightDst.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            flightDate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            flightCapacity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flightCode.Text = "";
            flightSrc.Text = "";
            flightDst.Text = "";
            flightDate.Text = DateTime.Now.ToString();
            flightCapacity.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(flightCode.Text))
            {
                using (var db = new FlightDBContext())
                {
                    // Note: This sample requires the database to be created before running.
                    Debug.WriteLine($"Database path: {db.DbPath}.");

                    Console.WriteLine("Querying for a blog");
                    var flight = db.Flights.Where(b => b.Fcode == flightCode.Text)
                        .First();


                    // Delete
                    Console.WriteLine("Delete the blog");
                    db.Remove(flight);
                    db.SaveChanges();
                    dataGridView1.DataSource = db.Flights.ToList();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new FlightDBContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");

                // Read
                Console.WriteLine("Querying for a blog");
                var flight = db.Flights.Where(b => b.Fcode== flightCode.Text)
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                flight.Fsrc = flightSrc.Text;
                flight.Fdst = flightDst.Text;
                flight.Fdate = flightDate.Value;
                flight.Fcap = flightCapacity.Text;
                db.SaveChanges();
                dataGridView1.DataSource = db.Flights.ToList();
            }
        }
    }
}
