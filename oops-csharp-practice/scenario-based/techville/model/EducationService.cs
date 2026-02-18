namespace TechVille.Model
{
  public class EducationService : CityService
  {
    private int courseDurationMonths;

    public EducationService()
        : base("Education", 300)
    {
      this.courseDurationMonths = 6;  // using 'this'
    }

    public override void Register(Citizen citizen)
    {
      base.Register(citizen);  // call parent method first

      Console.WriteLine(
          $"Education enrollment successful for {citizen.Name}.");
      Console.WriteLine(
          $"Course duration: {courseDurationMonths} months.");
    }
  }
}
