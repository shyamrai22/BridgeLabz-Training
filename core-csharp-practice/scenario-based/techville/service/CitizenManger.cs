using TechVille.Interface;
using TechVille.Model;
using TechVille.Utility;


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
      if (count >= citizens.Length)
      {
        Console.WriteLine("Database full.");
        return;
      }

      Console.Write("Enter Citizen ID: ");
      int id = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter Name: ");
      string name = Console.ReadLine();

      Console.Write("Enter Age: ");
      int age = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter Income: ");
      double income = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter Residency Years: ");
      int years = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter Email: ");
      string email = Console.ReadLine();

      if (!ProfileUtility.ValidateEmail(email))
      {
        Console.WriteLine("Invalid email format.");
        return;
      }

      name = ProfileUtility.FormatName(name);

      Citizen citizen = new Citizen(id, name, age, income, years, email);


      CalculateEligibility(citizen);

      citizens[count] = citizen;
      citizenIds[count] = id;

      // Assign zone randomly (for now)
      Random random = new Random();
      int zone = random.Next(0, 5);
      int sector = random.Next(0, 5);
      zones[zone, sector]++;

      count++;

      Console.WriteLine("Citizen registered successfully.");
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



  }
}
