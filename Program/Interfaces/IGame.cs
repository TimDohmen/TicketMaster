using ticketmaster.Models;

namespace ticketmaster.Interfaces
{
  public interface IGame
  {
    Ticket Ticket { get; set; }
    TicketSystem Box { get; set; }

  }
}