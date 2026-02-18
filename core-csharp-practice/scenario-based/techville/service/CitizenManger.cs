using TechVille.Model;

namespace TechVille.Service
{
  public class CitizenManager
  {
    public Citizen RegisterCitizen()
    {
      Console.Write("Enter Name: ");
      string name = Console.ReadLine();

      Console.Write("Enter Age: ");
      int age = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter Income: ");
      double income = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter Residency Years: ");
      int years = Convert.ToInt32(Console.ReadLine());

      Citizen citizen = new Citizen(name, age, income, years);

      CalculateEligibility(citizen);

      return citizen;
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


  }
}
