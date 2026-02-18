using TechVille.Interface;
using TechVille.Model;
using TechVille.Utility;
using TechVille.Exceptions;

namespace TechVille.Service
{
  public class CitizenManager : ICitizenManager
  {
    private Citizen[] citizens = new Citizen[100];
    private int[] citizenIds = new int[100];
    private int count = 0;

    private int[,] zones = new int[5, 5];

    public void RegisterCitizen()
    {
      try
      {
        if (count >= citizens.Length)
          throw new Exception("Database is full.");

        Console.Write("Enter Citizen ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (IsDuplicateId(id))
          throw new DuplicateCitizenException("Citizen ID already exists.");

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18)
          throw new InvalidAgeException("Citizen must be 18 or older.");

        Console.Write("Enter Income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Residency Years: ");
        int years = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        if (!ProfileUtility.ValidateEmail(email))
          throw new Exception("Invalid email format.");

        name = ProfileUtility.FormatName(name);

        Citizen citizen = new Citizen(id, name, age, income, years, email);

        citizens[count] = citizen;
        citizenIds[count] = id;

        AssignZone(); // clean separation
        count++;

        Console.WriteLine("Citizen registered successfully.");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
        ExceptionLogger.Log(ex.ToString());
      }
    }

    private void AssignZone()
    {
      Random random = new Random();
      int zone = random.Next(0, 5);
      int sector = random.Next(0, 5);
      zones[zone, sector]++;
    }

    public Citizen SearchCitizen(int id)
    {
      for (int i = 0; i < count; i++)
      {
        if (citizenIds[i] == id)
          return citizens[i];
      }
      return null;
    }

    public void SortCitizenIds()
    {
      for (int i = 0; i < count - 1; i++)
      {
        for (int j = 0; j < count - i - 1; j++)
        {
          if (citizenIds[j] > citizenIds[j + 1])
          {
            int temp = citizenIds[j];
            citizenIds[j] = citizenIds[j + 1];
            citizenIds[j + 1] = temp;
          }
        }
      }

      Console.WriteLine("Citizen IDs sorted.");
    }

    public void DisplayZones()
    {
      Console.WriteLine("\nZone-Sector Distribution:");

      for (int i = 0; i < 5; i++)
      {
        for (int j = 0; j < 5; j++)
        {
          Console.Write(zones[i, j] + " ");
        }
        Console.WriteLine();
      }
    }

    public void DisplayCitizen(Citizen citizen)
    {
      Console.WriteLine("\n--- Citizen Details ---");
      Console.WriteLine(citizen.ToString());
    }

    public void SearchByName(string name)
    {
      bool found = false;

      for (int i = 0; i < count; i++)
      {
        if (ProfileUtility.NameContains(citizens[i].Name, name))
        {
          DisplayCitizen(citizens[i]);
          found = true;
        }
      }

      if (!found)
        Console.WriteLine("No matching citizens found.");
    }

    public void UpdateIncome(int id, double newIncome)
    {
      Citizen citizen = SearchCitizen(id);

      if (citizen == null)
      {
        Console.WriteLine("Citizen not found.");
        return;
      }

      citizen.UpdateIncome(newIncome);   // Encapsulated method
      Console.WriteLine("Income updated successfully.");
    }

    private bool IsDuplicateId(int id)
    {
      for (int i = 0; i < count; i++)
      {
        if (citizenIds[i] == id)
          return true;
      }
      return false;
    }
  }
}
