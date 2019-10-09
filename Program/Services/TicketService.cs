
using System.Collections.Generic;
using ticketmaster.Models;

namespace ticketmaster.Services
{
  public class TicketService
  {
    private Game _game = new Game();
    public List<string> Messages { get; set; }

    public void Select(int num)
    {
      // Messages.Add(_game.Ticket.GetTemplate());
      _game.Box.ViewTicket(num - 1);
    }
    public void addTicketDetails(string name, string desc)
    {
      _game.Box.NewTicket(name, desc);

    }
    public void Update()
    {
      _game.Box.PrintAll();
    }

    public void Delete(int num)
    {
      _game.Box.CloseTicket(num - 1);
    }
    public TicketService()
    {
      Messages = new List<string>();
    }


  }
}