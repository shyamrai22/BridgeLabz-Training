namespace TechVille.Model
{
  public static class ServiceFactory
  {
    public static CityService CreateService(int choice)
    {
      switch (choice)
      {
        case 1:
          return new HealthcareService();
        case 2:
          return new EducationService();
        case 3:
          return new PremiumHealthcareService(1000);
        default:
          return null;
      }
    }
  }
}
