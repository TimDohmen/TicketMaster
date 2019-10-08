namespace ticketmaster.Interfaces
{
  public class ITicket
  {
    public string Name { get; set; }
    public string Description { get; set; }

    string GetTemplate();

  }
}