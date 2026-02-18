namespace TechVille.Model
{
  public class HealthcareService : CityService
  {
    private bool includesInsurance;

    public HealthcareService()
        : base("Healthcare", 500)
    {
      this.includesInsurance = true;   // using 'this'
    }

    public override void Register(Citizen citizen)
    {
      base.Register(citizen);  // call parent logic first

      Console.WriteLine(
          $"Healthcare registration complete for {citizen.Name}.");

      if (includesInsurance)
      {
        Console.WriteLine("Insurance coverage included.");
      }
    }
  }
}
