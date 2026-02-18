namespace TechVille.Model
{
  public class CityService
  {
    protected string serviceName;
    protected double baseCost;

    private static int totalServices = 0;

    public string ServiceName => serviceName;
    public double BaseCost => baseCost;

    public static int TotalServices => totalServices;

    public CityService(string serviceName, double baseCost)
    {
      this.serviceName = serviceName;   // using this
      this.baseCost = baseCost;

      totalServices++;  // static tracking
    }

    public virtual void Register(Citizen citizen)
    {
      Console.WriteLine($"{citizen.Name} registered for {serviceName}.");
    }

    public static void DisplayTotalServices()
    {
      Console.WriteLine($"Total services created: {totalServices}");
    }
  }
}
