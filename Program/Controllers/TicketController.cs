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
        GetUserInput();
      }
    }

    private void GetUserInput()
    {
      Console.Clear();



      Console.WriteLine($@"
      Welcome to Ticket Masta

       -   -   -   -   -   -
      ");
      System.Console.WriteLine($@"
What what you like to do?
      Input: 
    New - to create a new ticket
    View - to view a created ticket
    Quit");
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
          System.Console.WriteLine("Ticket Created! - Go to view to access tickets");
          break;
        case "view":
          Update();
          _ts.Update();
          string view = Console.ReadLine();
          if (int.TryParse(view, out int index))
          {

            _ts.Select(index);
            System.Console.WriteLine($@"
Press Enter to return to main menu or D to Delete Ticket");
            string anotherChoice = Console.ReadLine();


            switch (anotherChoice)
            {
              case "d":
              case "delete":
                _ts.Delete(index);
                System.Console.WriteLine("Ticket Deleted!");
                break;
              case "q":
                break;
            }
          }
          else
          {
            System.Console.WriteLine("Infidels Bad Key :(");
          }

          break;
        default:
          System.Console.WriteLine("Read Directions");
          break;

      }
      Update();
    }

    private void Update()
    {
      Console.ReadLine();
      Console.Clear();
      foreach (string message in _ts.Messages)
      {
        Console.WriteLine(message);
      }

      System.Console.WriteLine("Q to return to previous menu or num to select ticket.");
    }
  }
}