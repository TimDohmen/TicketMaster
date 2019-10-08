namespace ticketmaster.Interfaces
{
  public interface ITicket
  {
    string Name { get; }
    string Description { get; set; }

    void Print()
    {

    }

    string GetTemplate();

  }
}