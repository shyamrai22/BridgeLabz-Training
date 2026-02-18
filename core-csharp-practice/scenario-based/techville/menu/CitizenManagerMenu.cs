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
        Console.WriteLine("2. Exit");
        Console.Write("Choose option: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
          case 1:
            Citizen citizen = manager.RegisterCitizen();

            if (citizen.Age < 18)
            {
              Console.WriteLine("Citizen is underage.");
              continue;
            }

            manager.DisplayCitizen(citizen);
            break;

          case 2:
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
