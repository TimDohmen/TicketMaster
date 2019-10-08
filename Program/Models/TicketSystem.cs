using System;
using System.Collections.Generic;
using ticketmaster.Interfaces;
using ticketmaster.Models;

namespace ticketmaster.Models
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
    public void NewTicket(string name, string desc)
    {
      //create

      Ticket newTicket = new Ticket(name, desc);
      Tickets.Add(newTicket);
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