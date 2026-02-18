using TechVille.Model;
using TechVille.Service;

namespace TechVille.Menu
{
  public class CitizenManagerMenu
  {
    private CitizenManager manager = new CitizenManager();

    public void Start()
    {
      while (true)
      {
        Console.WriteLine("\n1. Register Citizen");
        Console.WriteLine("2. Search Citizen");
        Console.WriteLine("3. Sort Citizen IDs");
        Console.WriteLine("4. Display Zones");
        Console.WriteLine("5. Exit");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
          case 1:
            manager.RegisterCitizen();
            break;

          case 2:
            Console.Write("Enter ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Citizen found = manager.SearchCitizen(id);

            if (found != null)
              manager.DisplayCitizen(found);
            else
              Console.WriteLine("Citizen not found.");
            break;

          case 3:
            manager.SortCitizenIds();
            break;

          case 4:
            manager.DisplayZones();
            break;

          case 5:
            return;

          default:
            Console.WriteLine("Invalid choice.");
            break;
        }
      }
    }
  }
}
