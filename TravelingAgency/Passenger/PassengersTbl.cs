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

namespace TravelingAgency
{
    public partial class PassengersTbl : masterForm
    {
        public PassengersTbl()
        {
            InitializeComponent();
        }

        private void ViewPassengers_Load(object sender, EventArgs e)
        {
            using (var db = new FlightDBContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");
                // Read
                Console.WriteLine("Querying for a blog");
                var passenger = db.Passengers
                    .OrderBy(b => b.Id).ToList();
                dataGridView1.DataSource = passenger;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPassenger addPassenger = new();
            addPassenger.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(passId.Text))
            {
                using (var db = new FlightDBContext())
                {
                    // Note: This sample requires the database to be created before running.
                    Console.WriteLine($"Database path: {db.DbPath}.");

                    // Read
                    Console.WriteLine("Querying for a blog");
                    var passenger = db.Passengers.Where(b=>b.Id  == short.Parse(passId.Text))
                        .First();


                    // Delete
                    Console.WriteLine("Delete the blog");
                    db.Remove(passenger);
                    db.SaveChanges();
                    dataGridView1.DataSource = db.Passengers.ToList();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            passId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            PassName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            PassportNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            PassAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbxNationality.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbxGender.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            PassPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            passId.Text = "";
            PassName.Text = "";
            PassportNumber.Text = "";
            PassAddress.Text = "";
            cbxNationality.Text = "";
            cbxGender.Text = "";
            PassPhone.Text = "";
            passAge.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new FlightDBContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");

                // Read
                Console.WriteLine("Querying for a blog");
                var passenger = db.Passengers.Where(b => b.Id == short.Parse(passId.Text))
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                passenger.Name = PassName.Text;
                passenger.Phone = PassPhone.Text;
                passenger.Gender = cbxGender.Text;
                passenger.Nationality = cbxNationality.Text;
                passenger.Address = PassAddress.Text;
                passenger.PassportNumber = PassportNumber.Text;
                passenger.Age = passAge.Text;
                db.SaveChanges();
                dataGridView1.DataSource = db.Passengers.ToList();
            }
        }
    }
}
