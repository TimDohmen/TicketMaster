using System;
using ticketmaster.Services;

namespace ticketmaster.Controllers
{
  public class TicketController
  {

    private TicketService _ts = new TicketService();
    public void Run()
    {
      while (true)
      {
        Update();
        GetUserInput();
      }
    }

    private void GetUserInput()
    {
      Console.Clear();
      Console.WriteLine($@"
      Welcome to Ticket Masta
  #                Ticket Name
      -   -   -   -   -
      ");
      System.Console.WriteLine("What You wanna Do? View / New / Quit");

      string choice = Console.ReadLine().ToLower();
      switch (choice)
      {
        case "q":
        case "quit":
        case "exit":
        case "close":
          Environment.Exit(0);
          break;
        case "new":
          System.Console.WriteLine("Ticket Name : ");
          string name = Console.ReadLine();
          System.Console.WriteLine("Ticket Description : ");
          string desc = Console.ReadLine();
          _ts.addTicketDetails(name, desc);
          break;
        case "view":
          Update();
          _ts.Update();
          string view = Console.ReadLine();
          if (int.TryParse(view, out int index))
          {
            _ts.Select(index);
            break;
          }
          else
          {
            System.Console.WriteLine("Infidels Bad Key :(");
          }
          break;
        default:
          break;
      }
    }

    private void Update()
    {
      Console.ReadLine();
      Console.Clear();
      foreach (string message in _ts.Messages)
      {
        Console.WriteLine(message);
      }

      System.Console.WriteLine("What You wanna Do? View / New / Quit");
    }
  }
}