using System;
using ticketmaster.Controllers;

namespace ticketmaster
{
  class TicketMaster
  {
    static void Main(string[] args)
    {
      new TicketController().Run();
    }
  }
}
