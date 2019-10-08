
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

    }
    public void addTicketDetails(string name, string desc)
    {
      _game.Box.NewTicket(name, desc);

    }
    public TicketService()
    {
      Messages = new List<string>();
    }


  }
}