namespace TechVille.Model
{
  public class HealthcareService : Service
  {
    public HealthcareService() : base("Healthcare", 500)
    {
    }

    public override void Register(Citizen citizen)
    {
      Console.WriteLine($"Healthcare registration complete for {citizen.Name}.");
    }
  }
}
