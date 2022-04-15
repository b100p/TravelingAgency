using System.ComponentModel.DataAnnotations;
namespace TravelingAgency.Modals;
public class Flight
{
    [Key]
    public string Fcode { get; set; }
    public string Fsrc { get; set; }
    public string Fdst { get; set; }
    public DateTime Fdate { get; set; }
    public string Fcap { get; set; }
}

