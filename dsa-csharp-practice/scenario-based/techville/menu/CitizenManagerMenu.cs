using TechVille.Model;
using TechVille.Service;
using TechVille.Interface;

namespace TechVille.Menu
{
  public class CitizenManagerMenu
  {
    private ICitizenManager manager = new CitizenManager();

    private CitizenLinkedList singlyList = new CitizenLinkedList();
    private CitizenDoublyLinkedList doublyList = new CitizenDoublyLinkedList();
    private CitizenCircularLinkedList circularList = new CitizenCircularLinkedList();

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

      Console.WriteLine("\n------ Singly Linked List ------");
      Console.WriteLine("11. Add Citizen To Singly List");
      Console.WriteLine("12. Display Singly List");
      Console.WriteLine("13. Remove Citizen From Singly List");

      Console.WriteLine("\n------ Doubly Linked List ------");
      Console.WriteLine("14. Add Citizen To Doubly List");
      Console.WriteLine("15. Display Doubly List Forward");
      Console.WriteLine("16. Display Doubly List Backward");

      Console.WriteLine("\n------ Circular Linked List ------");
      Console.WriteLine("17. Add Citizen To Circular List");
      Console.WriteLine("18. Display Circular List");

      Console.WriteLine("19. Exit");
      Console.Write("Enter choice: ");
    }

    private bool HandleChoice(int choice)
    {
      switch (choice)
      {
        case 1: manager.RegisterCitizen(); break;
        case 2: SearchById(); break;
        case 3: manager.SortCitizenIds(); break;
        case 4: manager.DisplayZones(); break;
        case 5: SearchByName(); break;
        case 6: UpdateIncome(); break;

        case 7:
        case 8:
        case 9:
          HandleServiceRegistration(choice - 6);
          break;

        case 10:
          CityService.DisplayTotalServices();
          break;

        // Singly Linked List
        case 11: AddToSinglyList(); break;
        case 12: singlyList.Display(); break;
        case 13: RemoveFromSinglyList(); break;

        // Doubly Linked List
        case 14: AddToDoublyList(); break;
        case 15: doublyList.DisplayForward(); break;
        case 16: doublyList.DisplayBackward(); break;

        // Circular Linked List
        case 17: AddToCircularList(); break;
        case 18: circularList.Display(); break;

        case 19:
          Console.WriteLine("Exiting system...");
          return false;

        default:
          Console.WriteLine("Invalid choice.");
          break;
      }

      return true;
    }

    // ------------------ Singly ------------------

    private void AddToSinglyList()
    {
      Citizen citizen = GetCitizenFromInput();
      if (citizen == null) return;

      singlyList.Insert(citizen);
      Console.WriteLine("Citizen added to singly linked list.");
    }

    private void RemoveFromSinglyList()
    {
      Console.Write("Enter Citizen ID to remove: ");
      if (!int.TryParse(Console.ReadLine(), out int id))
      {
        Console.WriteLine("Invalid ID.");
        return;
      }

      singlyList.Delete(id);
      Console.WriteLine("Removal operation completed.");
    }

    // ------------------ Doubly ------------------

    private void AddToDoublyList()
    {
      Citizen citizen = GetCitizenFromInput();
      if (citizen == null) return;

      doublyList.Insert(citizen);
      Console.WriteLine("Citizen added to doubly linked list.");
    }

    // ------------------ Circular ------------------

    private void AddToCircularList()
    {
      Citizen citizen = GetCitizenFromInput();
      if (citizen == null) return;

      circularList.Insert(citizen);
      Console.WriteLine("Citizen added to circular linked list.");
    }

    // ------------------ Shared Helpers ------------------

    private Citizen GetCitizenFromInput()
    {
      Console.Write("Enter Citizen ID: ");
      if (!int.TryParse(Console.ReadLine(), out int id))
      {
        Console.WriteLine("Invalid ID.");
        return null;
      }

      Citizen citizen = manager.SearchCitizen(id);

      if (citizen == null)
      {
        Console.WriteLine("Citizen not found.");
        return null;
      }

      return citizen;
    }

    private void SearchById()
    {
      Citizen citizen = GetCitizenFromInput();
      if (citizen != null)
        manager.DisplayCitizen(citizen);
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
      if (!int.TryParse(Console.ReadLine(), out int updateId))
      {
        Console.WriteLine("Invalid ID.");
        return;
      }

      Console.Write("Enter new income: ");
      if (!double.TryParse(Console.ReadLine(), out double newIncome))
      {
        Console.WriteLine("Invalid income value.");
        return;
      }

      manager.UpdateIncome(updateId, newIncome);
    }

    private void HandleServiceRegistration(int serviceChoice)
    {
      Citizen citizen = GetCitizenFromInput();
      if (citizen == null) return;

      CityService service = ServiceFactory.CreateService(serviceChoice);

      if (service == null)
      {
        Console.WriteLine("Invalid service selection.");
        return;
      }

      service.Register(citizen);

      if (service is PremiumHealthcareService)
      {
        service.Register(citizen, 1);
        Console.WriteLine("Premium healthcare benefits applied.");
      }

      if (service is IBookable bookable)
        bookable.Book();

      if (service is ITrackable trackable)
        trackable.TrackStatus();
    }
  }
}
