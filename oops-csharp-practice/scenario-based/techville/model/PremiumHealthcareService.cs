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

    public override void Register(Citizen citizen)
    {
      base.Register(citizen);  // call parent method
      Console.WriteLine($"Premium benefits activated. Extra charge: {premiumCharge}");
    }
  }
}
