using System.Collections.Generic;

namespace ticketmaster.Interfaces
{
  public interface ITicketSystem
  {

    List<ITicket> info { get; set; }

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


  }
}