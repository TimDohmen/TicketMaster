

using ticketmaster.Interfaces;

namespace ticketmaster.Models
{
  public class Ticket : ITicket
  {

    public string Name { get; private set; }
    public string Description { get; set; }

    public string GetTemplate()
    {
      return $@"
  {Name}
  {Description}";

    }
    public Ticket(string name, string description)
    {
      Name = name;
      Description = description;

    }

  }

}