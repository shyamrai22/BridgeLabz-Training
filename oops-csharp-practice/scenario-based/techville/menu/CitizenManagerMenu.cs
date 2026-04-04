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
        PrintMenu();

        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
          Console.WriteLine("Invalid input. Enter a number.");
          continue;
        }

        if (!HandleChoice(choice))
          break;
      }
    }

    private void PrintMenu()
    {
      Console.WriteLine("\n===== TechVille Citizen Management =====");
      Console.WriteLine("1. Register Citizen");
      Console.WriteLine("2. Search Citizen by ID");
      Console.WriteLine("3. Sort Citizen IDs");
      Console.WriteLine("4. Display Zones");
      Console.WriteLine("5. Search Citizen by Name");
      Console.WriteLine("6. Update Citizen Income");
      Console.WriteLine("7. Register for Healthcare Service");
      Console.WriteLine("8. Register for Education Service");
      Console.WriteLine("9. Register for Premium Healthcare");
      Console.WriteLine("10. Display Total Services Created");
      Console.WriteLine("11. Exit");
      Console.Write("Enter choice: ");
    }

    private bool HandleChoice(int choice)
    {
      switch (choice)
      {
        case 1:
          manager.RegisterCitizen();
          break;

        case 2:
          SearchById();
          break;

        case 3:
          manager.SortCitizenIds();
          break;

        case 4:
          manager.DisplayZones();
          break;

        case 5:
          SearchByName();
          break;

        case 6:
          UpdateIncome();
          break;

        case 7:
        case 8:
        case 9:
          HandleServiceRegistration(choice - 6);
          break;

        case 10:
          CityService.DisplayTotalServices();
          break;

        case 11:
          Console.WriteLine("Exiting system...");
          return false;

        default:
          Console.WriteLine("Invalid choice.");
          break;
      }

      return true;
    }

    private void SearchById()
    {
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
    }

    private void SearchByName()
    {
      Console.Write("Enter name to search: ");
      string name = Console.ReadLine();
      manager.SearchByName(name);
    }

    private void UpdateIncome()
    {
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
    }

    private void HandleServiceRegistration(int serviceChoice)
    {
      Console.Write("Enter Citizen ID: ");
      if (!int.TryParse(Console.ReadLine(), out int id))
      {
        Console.WriteLine("Invalid ID.");
        return;
      }

      Citizen citizen = manager.SearchCitizen(id);

      if (citizen == null)
      {
        Console.WriteLine("Citizen not found.");
        return;
      }

      // Create service using factory
      CityService service = ServiceFactory.CreateService(serviceChoice);

      if (service == null)
      {
        Console.WriteLine("Invalid service selection.");
        return;
      }

      // Register citizen
      service.Register(citizen);

      // If premium, use overloaded method
      if (service is PremiumHealthcareService)
      {
        service.Register(citizen, 1);
        Console.WriteLine("Premium healthcare benefits applied.");
      }

      // Interface-based polymorphic behavior
      if (service is IBookable bookable)
      {
        bookable.Book();
      }

      if (service is ITrackable trackable)
      {
        trackable.TrackStatus();
      }
    }
  }
}
