using System;
using System.Collections.Generic;
using ticketmaster.Interfaces;
using ticketmaster.Models;

namespace ticketmaster.Models
{
  public class TicketSystem : ITicketSystem
  {

    public List<string> Messages { get; set; }

    public List<ITicket> Tickets { get; set; }
    public void PrintAll()
    {
      //print all tickets in log
      // foreach (var t in Tickets)
      // {
      //   //cant add to messages need to fix
      //   // Messages.Add($"{t.Name}");
      //   Console.WriteLine($" {t.Name}");

      // }
      for (int i = 0; i < Tickets.Count; i++)
      {
        ITicket T = Tickets[i];
        Console.WriteLine($"{i + 1}.    {T.Name}");

      }
    }
    public void ViewTicket(int index)
    {
      //view individual ticket, take in index to know what ticket to view details
      Console.WriteLine($"{Tickets[index].GetTemplate()}");

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

    public TicketSystem()
    {
      Tickets = new List<ITicket>();
      Messages = new List<string>();
    }
  }
}