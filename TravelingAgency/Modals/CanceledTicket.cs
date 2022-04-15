namespace TravelingAgency.Modals;
public class CanceledTicket
{
    public string Id { get; set; }
    public string TicketId { get; set; }
    public string Fcode { get; set; }
    public DateTime CancelDate { get; set; }
}
