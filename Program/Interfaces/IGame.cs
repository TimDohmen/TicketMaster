using ticketmaster.Models;

namespace ticketmaster.Interfaces
{
  public interface IGame
  {
    ITicket Ticket { get; set; }
    TicketSystem Box { get; set; }

  }
}