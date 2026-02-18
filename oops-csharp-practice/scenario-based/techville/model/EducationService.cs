namespace TechVille.Model
{
  public class EducationService : Service
  {
    public EducationService() : base("Education", 300)
    {
    }

    public override void Register(Citizen citizen)
    {
      Console.WriteLine($"Education enrollment successful for {citizen.Name}.");
    }
  }
}
