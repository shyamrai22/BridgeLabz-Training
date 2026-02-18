using TechVille.Interface;

namespace TechVille.Model
{
  public class EducationService : CityService, IBookable, ICancellable, ITrackable
  {
    private int courseDurationMonths;

    public EducationService()
        : base("Education", 300)
    {
      this.courseDurationMonths = 6;
    }

    // CityService now forces implementation (abstract method)
    public override void Register(Citizen citizen)
    {
      Console.WriteLine(
          $"{citizen.Name} enrolled in Education Service.");
      Console.WriteLine(
          $"Course duration: {courseDurationMonths} months.");
    }

    public void Book()
    {
      Console.WriteLine("Education course booked successfully.");
    }

    public void Cancel()
    {
      Console.WriteLine("Education enrollment cancelled.");
    }

    public void TrackStatus()
    {
      Console.WriteLine("Education status: Active.");
    }
  }
}
