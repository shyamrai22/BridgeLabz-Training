namespace TechVille.Model
{
  public class Citizen
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public double Income { get; set; }
    public int ResidencyYears { get; set; }
    public double EligibilityScore { get; set; }
    public string ServicePackage { get; set; }
    public int CitizenId { get; set; }


    public Citizen(int id, string name, int age, double income, int years)
    {
      CitizenId = id;
      Name = name;
      Age = age;
      Income = income;
      ResidencyYears = years;
    }


    public override string ToString()
    {
      return $"{Name} | {Age} | {ResidencyYears}";
    }
  }
}