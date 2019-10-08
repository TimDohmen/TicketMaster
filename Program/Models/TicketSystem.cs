using System.Collections.Generic;
using ticketmaster.Interfaces;

namespace ticketmaster.Program.Models
{
  public class TicketSystem : ITicketSystem
  {


    public List<ITicket> Tickets { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    void PrintAll()
    {
      //print all tickets in log
    }
    void ViewTicket(int index)
    {
      //view individual ticket, take in index to know what ticket to view details
    }
    void NewTicket()
    {
      //create
    }
    void CloseTicket()
    {
      //dete
    }

    public TicketSystem(List<ITicket> Tickets)
    {
      Tickets = new List<ITicket>();
    }
  }
}