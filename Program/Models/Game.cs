using ticketmaster.Interfaces;

namespace ticketmaster.Models
{
  public class Game : IGame
  {
    public Ticket Ticket { get; set; }
    public TicketSystem Box { get; set; }

    private void Setup()
    {

    }
    public Game()
    {
      Box = new TicketSystem();
      Setup();
    }
  }
}