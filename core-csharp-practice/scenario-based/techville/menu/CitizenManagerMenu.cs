using TechVille.Model;
using TechVille.Service;

namespace TechVille.Menu
{
  public class CitizenManagerMenu
  {
    private CitizenManager manager = new CitizenManager();

    public void Start()
    {
      Citizen citizen = manager.RegisterCitizen();

      // Basic Validation
      if (citizen.Age < 18)
      {
        Console.WriteLine("Citizen is not eligible (Underage).");
        return;
      }

      if (citizen.ResidencyYears < 1)
      {
        Console.WriteLine("Citizen must have at least 1 year residency.");
        return;
      }

      manager.DisplayCitizen(citizen);
    }
  }
}
