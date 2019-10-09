using ticketmaster.Interfaces;

namespace ticketmaster.Models
{
  public class Game : IGame
  {
    public Ticket Ticket { get; set; }
    public TicketSystem Box { get; set; }


    public Game()
    {
      Box = new TicketSystem();
    }
  }
}