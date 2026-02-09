class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to citizen registeration portal");
    Console.Write("Enter your name: ");
    string? name = Console.ReadLine();
    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine());
    Console.Write("Enter your income: ");
    double income = double.Parse(Console.ReadLine());
    Console.Write("Enter your residency years: ");
    int years = int.Parse(Console.ReadLine());

    int ageScore = 0;

    if (age < 18)
    {
      ageScore = 0;
      Console.WriteLine("Citizen is not eligible (Under 18).");
    }
    else if (age >= 18 && age <= 30)
    {
      ageScore = 20;
    }
    else if (age >= 31 && age <= 50)
    {
      ageScore = 30;
    }
    else
    {
      ageScore = 25;
    }


    int incomeScore = 0;

    if (income < 200000)
    {
      incomeScore = 30;
    }
    else if (income >= 200000 && income <= 500000)
    {
      incomeScore = 20;
    }
    else
    {
      incomeScore = 10;
    }


    int residencyScore = 0;

    if (years < 1)
    {
      residencyScore = 0;
      Console.WriteLine("Residency too short for benefits.");
    }
    else if (years >= 1 && years <= 3)
    {
      residencyScore = 10;
    }
    else if (years >= 4 && years <= 7)
    {
      residencyScore = 20;
    }
    else
    {
      residencyScore = 30;
    }

    int totalScore = ageScore + incomeScore + residencyScore;

    Console.WriteLine($"Name -> {name} || Age -> {age} || Income -> {income} || Service Eligibility Score -> {totalScore}");
  }
}
