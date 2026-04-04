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

    private CitizenStack undoStack = new CitizenStack();
    private ServiceRequestQueue requestQueue = new ServiceRequestQueue();
    private EmergencyServiceQueue emergencyQueue = new EmergencyServiceQueue();

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

      Console.WriteLine("\n------ Stack & Queue ------");
      Console.WriteLine("19. Push Citizen To Undo Stack");
      Console.WriteLine("20. Undo Last Citizen");
      Console.WriteLine("21. Add Citizen To Service Queue");
      Console.WriteLine("22. Process Next Service Request");
      Console.WriteLine("23. Add Citizen To Emergency Queue");
      Console.WriteLine("24. Process Emergency Request");

      Console.WriteLine("25. Exit");
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

        case 11: AddToSinglyList(); break;
        case 12: singlyList.Display(); break;
        case 13: RemoveFromSinglyList(); break;

        case 14: AddToDoublyList(); break;
        case 15: doublyList.DisplayForward(); break;
        case 16: doublyList.DisplayBackward(); break;

        case 17: AddToCircularList(); break;
        case 18: circularList.Display(); break;

        case 19: PushToUndoStack(); break;
        case 20: UndoLastCitizen(); break;

        case 21: AddToServiceQueue(); break;
        case 22: ProcessServiceQueue(); break;

        case 23: AddToEmergencyQueue(); break;
        case 24: ProcessEmergencyQueue(); break;

        case 25:
          Console.WriteLine("Exiting system...");
          return false;

        default:
          Console.WriteLine("Invalid choice.");
          break;
      }

      return true;
    }

    // ------------------ Stack ------------------

    private void PushToUndoStack()
    {
      Citizen citizen = GetCitizenFromInput();
      if (citizen == null) return;

      undoStack.Push(citizen);
      Console.WriteLine("Citizen pushed to undo stack.");
    }

    private void UndoLastCitizen()
    {
      Citizen undone = undoStack.Pop();
      if (undone == null)
        Console.WriteLine("Stack is empty.");
      else
        Console.WriteLine($"Undo performed for: {undone}");
    }

    // ------------------ FIFO Queue ------------------

    private void AddToServiceQueue()
    {
      Citizen citizen = GetCitizenFromInput();
      if (citizen == null) return;

      requestQueue.Enqueue(citizen);
      Console.WriteLine("Citizen added to service queue.");
    }

    private void ProcessServiceQueue()
    {
      Citizen processed = requestQueue.Dequeue();
      if (processed == null)
        Console.WriteLine("Queue is empty.");
      else
        Console.WriteLine($"Processing service request for: {processed}");
    }

    // ------------------ Priority Queue ------------------

    private void AddToEmergencyQueue()
    {
      Citizen citizen = GetCitizenFromInput();
      if (citizen == null) return;

      Console.Write("Enter Priority (1 = High, 5 = Low): ");
      if (!int.TryParse(Console.ReadLine(), out int priority))
      {
        Console.WriteLine("Invalid priority.");
        return;
      }

      emergencyQueue.Enqueue(citizen, priority);
      Console.WriteLine("Citizen added to emergency queue.");
    }

    private void ProcessEmergencyQueue()
    {
      Citizen processed = emergencyQueue.Dequeue();
      if (processed == null)
        Console.WriteLine("Emergency queue is empty.");
      else
        Console.WriteLine($"Processing emergency request for: {processed}");
    }

    // ------------------ Existing Methods (Unchanged) ------------------

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

    private void AddToDoublyList()
    {
      Citizen citizen = GetCitizenFromInput();
      if (citizen == null) return;

      doublyList.Insert(citizen);
      Console.WriteLine("Citizen added to doubly linked list.");
    }

    private void AddToCircularList()
    {
      Citizen citizen = GetCitizenFromInput();
      if (citizen == null) return;

      circularList.Insert(citizen);
      Console.WriteLine("Citizen added to circular linked list.");
    }

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
