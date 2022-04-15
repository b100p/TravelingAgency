using Microsoft.EntityFrameworkCore;
using TravelingAgency.Modals;

namespace TravelingAgency.EF;
public class FlightDBContext : DbContext
{
    public DbSet<Passenger> Passengers { get; set; }
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<CanceledTicket> CanceledTickets { get; set; }

    public string DbPath { get; }

    public FlightDBContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "Flights.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}





