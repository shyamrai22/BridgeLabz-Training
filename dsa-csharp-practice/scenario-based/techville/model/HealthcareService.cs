using TechVille.Interface;

namespace TechVille.Model
{
  public class HealthcareService : CityService, IBookable, ICancellable, ITrackable
  {
    public HealthcareService()
        : base("Healthcare", 500)
    {
    }

    public override void Register(Citizen citizen)
    {
      Console.WriteLine($"{citizen.Name} registered for healthcare.");
    }

    public void Book()
    {
      Console.WriteLine("Healthcare appointment booked.");
    }

    public void Cancel()
    {
      Console.WriteLine("Healthcare appointment cancelled.");
    }

    public void TrackStatus()
    {
      Console.WriteLine("Healthcare appointment status: Confirmed.");
    }
  }
}
