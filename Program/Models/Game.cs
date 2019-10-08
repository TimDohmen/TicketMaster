using ticketmaster.Interfaces;

namespace ticketmaster.Models
{
  public class Game : IGame
  {
    public ITicket Ticket { get; set; }

    private void Setup()
    {

    }
    public Game()
    {
      Ticket = new Ticket();
      Setup();
    }
  }
}