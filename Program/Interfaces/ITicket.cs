namespace ticketmaster.Interfaces
{
  public interface ITicket
  {
    string Name { get; }
    string Description { get; set; }



    string GetTemplate();

  }
}