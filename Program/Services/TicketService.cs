
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
      Messages.Add(_game.Ticket.GetTemplate());
    }
    public void addTicketDetails(string name, string desc)
    {
      _game.Box.NewTicket(name, desc);

    }
    public void Update()
    {
      _game.Box.PrintAll();
    }
    public TicketService()
    {
      Messages = new List<string>();
    }


  }
}