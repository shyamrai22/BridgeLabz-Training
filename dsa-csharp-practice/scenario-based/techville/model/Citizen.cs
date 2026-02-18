namespace TechVille.Model
{
  public class Citizen
  {
    private int citizenId;
    private string name;
    private int age;
    private double income;
    private int residencyYears;
    private string email;

    public int CitizenId => citizenId;
    public string Name => name;
    public int Age => age;
    public double Income => income;
    public int ResidencyYears => residencyYears;
    public string Email => email;

    public Citizen(int id, string name, int age, double income, int years, string email)
    {
      citizenId = id;
      this.name = name;
      this.age = age;
      this.income = income;
      residencyYears = years;
      this.email = email;
    }

    public void UpdateIncome(double newIncome)
    {
      income = newIncome;
    }

    public override string ToString()
    {
      return $"{citizenId} | {name} | {age} | {residencyYears} | {email}";
    }
  }
}
