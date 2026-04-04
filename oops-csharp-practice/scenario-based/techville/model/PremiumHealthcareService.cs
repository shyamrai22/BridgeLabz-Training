namespace TechVille.Model
{
  public class PremiumHealthcareService : HealthcareService
  {
    private double premiumCharge;

    public PremiumHealthcareService(double premiumCharge)
        : base()
    {
      this.premiumCharge = premiumCharge;
    }

    public override void Register(Citizen citizen, int priorityLevel)
    {
      base.Register(citizen, priorityLevel);
      Console.WriteLine("Premium fast-track processing enabled.");
    }

  }
}
