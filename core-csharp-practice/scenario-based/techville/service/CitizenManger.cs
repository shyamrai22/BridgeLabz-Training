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

    private int[,] zones = new int[5, 5]; // 5 zones, 5 sectors each

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

        CalculateEligibility(citizen);

        citizens[count] = citizen;
        citizenIds[count] = id;

        count++;

        Console.WriteLine("Citizen registered successfully.");
      }
      catch (InvalidAgeException ex)
      {
        Console.WriteLine($"Age Error: {ex.Message}");
        ExceptionLogger.Log(ex.ToString());
      }
      catch (DuplicateCitizenException ex)
      {
        Console.WriteLine($"Duplicate Error: {ex.Message}");
        ExceptionLogger.Log(ex.ToString());
      }
      catch (FormatException ex)
      {
        Console.WriteLine("Input format error. Please enter valid numeric values.");
        ExceptionLogger.Log(ex.ToString());
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Unexpected error: {ex.Message}");
        ExceptionLogger.Log(ex.ToString());
      }

    }

    public Citizen SearchCitizen(int id)
    {
      for (int i = 0; i < count; i++)
      {
        if (citizenIds[i] == id)
        {
          return citizens[i];
        }
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

    private void CalculateEligibility(Citizen citizen)
    {
      citizen.EligibilityScore =
          (citizen.Age * 0.3) +
          (citizen.Income * 0.2) +
          (citizen.ResidencyYears * 0.5);

      AssignServicePackage(citizen);
    }

    private void AssignServicePackage(Citizen citizen)
    {
      if (citizen.Age < 18)
      {
        citizen.ServicePackage = "Not Eligible";
        return;
      }

      if (citizen.EligibilityScore < 20)
        citizen.ServicePackage = "Basic";
      else if (citizen.EligibilityScore < 40)
        citizen.ServicePackage = "Silver";
      else if (citizen.EligibilityScore < 60)
        citizen.ServicePackage = "Gold";
      else
        citizen.ServicePackage = "Platinum";
    }

    public void DisplayCitizen(Citizen citizen)
    {
      Console.WriteLine("\n--- Citizen Details ---");
      Console.WriteLine(citizen.ToString());
      Console.WriteLine($"Income: {citizen.Income}");
      Console.WriteLine($"Eligibility Score: {citizen.EligibilityScore:F2}");
      Console.WriteLine($"Service Package: {citizen.ServicePackage}");
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

      ModifyIncome(citizen, newIncome);
      Console.WriteLine("Income updated successfully.");
    }

    private void ModifyIncome(Citizen citizen, double income)
    {
      citizen.Income = income;
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
