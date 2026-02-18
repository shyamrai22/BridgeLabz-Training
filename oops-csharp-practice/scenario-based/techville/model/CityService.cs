namespace TechVille.Model
{
  public abstract class CityService
  {
    protected string serviceName;
    protected double baseCost;

    private static int totalServices = 0;

    public string ServiceName => serviceName;
    public double BaseCost => baseCost;

    public static int TotalServices => totalServices;

    public CityService(string serviceName, double baseCost)
    {
      this.serviceName = serviceName;
      this.baseCost = baseCost;
      totalServices++;
    }

    public abstract void Register(Citizen citizen);


    // 🔹 Method Overloading
    public virtual void Register(Citizen citizen, int priorityLevel)
    {
      Console.WriteLine($"{citizen.Name} registered for {serviceName} with priority {priorityLevel}.");
    }

    public override string ToString()
    {
      return $"Service: {serviceName} | Cost: {baseCost}";
    }

    public override bool Equals(object obj)
    {
      if (obj is CityService other)
      {
        return this.serviceName == other.serviceName;
      }
      return false;
    }

    public override int GetHashCode()
    {
      return serviceName.GetHashCode();
    }

    public static void DisplayTotalServices()
    {
      Console.WriteLine($"Total services created: {totalServices}");
    }
  }
}
