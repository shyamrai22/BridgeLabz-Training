using TechVille.Model;
using TechVille.Service;
using TechVille.Interface;

namespace TechVille.Menu
{
  public class CitizenManagerMenu
  {
    private ICitizenManager manager = new CitizenManager();

    public void Start()
    {
      while (true)
      {
        Console.WriteLine("\n===== TechVille Citizen Management =====");
        Console.WriteLine("1. Register Citizen");
        Console.WriteLine("2. Search Citizen by ID");
        Console.WriteLine("3. Sort Citizen IDs");
        Console.WriteLine("4. Display Zones");
        Console.WriteLine("5. Search Citizen by Name");
        Console.WriteLine("6. Update Citizen Income");
        Console.WriteLine("7. Exit");
        Console.Write("Enter choice: ");

        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
          Console.WriteLine("Invalid input. Enter a number.");
          continue;
        }

        switch (choice)
        {
          case 1:
            manager.RegisterCitizen();
            break;

          case 2:
            Console.Write("Enter ID to search: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
              Citizen found = manager.SearchCitizen(id);

              if (found != null)
                manager.DisplayCitizen(found);
              else
                Console.WriteLine("Citizen not found.");
            }
            else
            {
              Console.WriteLine("Invalid ID.");
            }
            break;

          case 3:
            manager.SortCitizenIds();
            break;

          case 4:
            manager.DisplayZones();
            break;

          case 5:
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine();
            manager.SearchByName(name);
            break;

          case 6:
            Console.Write("Enter Citizen ID: ");
            if (int.TryParse(Console.ReadLine(), out int updateId))
            {
              Console.Write("Enter new income: ");
              if (double.TryParse(Console.ReadLine(), out double newIncome))
              {
                manager.UpdateIncome(updateId, newIncome);
              }
              else
              {
                Console.WriteLine("Invalid income value.");
              }
            }
            else
            {
              Console.WriteLine("Invalid ID.");
            }
            break;

          case 7:
            Console.WriteLine("Exiting system...");
            return;

          default:
            Console.WriteLine("Invalid choice.");
            break;
        }
      }
    }
  }
}
