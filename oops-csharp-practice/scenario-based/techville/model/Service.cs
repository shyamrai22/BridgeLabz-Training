namespace TechVille.Model
{
  public class Service
  {
    protected string serviceName;
    protected double baseCost;

    public string ServiceName => serviceName;
    public double BaseCost => baseCost;

    public Service(string name, double cost)
    {
      serviceName = name;
      baseCost = cost;
    }

    public virtual void Register(Citizen citizen)
    {
      Console.WriteLine($"{citizen.Name} registered for {serviceName} service.");
    }
  }
}
