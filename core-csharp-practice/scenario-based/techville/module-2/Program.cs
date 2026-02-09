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


    /*=====================================================MODULE-02==========================================================*/

    string package = "";

    if (age >= 18)
    {
      if (years >= 1)
      {
        if (totalScore >= 80)
        {
          package = "Platinum";
        }
        else if (totalScore >= 60)
        {
          package = "Gold";
        }
        else if (totalScore >= 40)
        {
          package = "Silver";
        }
        else
        {
          package = "Basic";
        }
      }
      else
      {
        package = "Not Eligible (Insufficient Residency)";
      }
    }
    else
    {
      package = "Not Eligible (Underage)";
    }

    switch (package)
    {
      case "Platinum":
        Console.WriteLine("Access to all city services + premium healthcare.");
        break;

      case "Gold":
        Console.WriteLine("Access to major city services.");
        break;

      case "Silver":
        Console.WriteLine("Access to limited city services.");
        break;

      case "Basic":
        Console.WriteLine("Access to essential services only.");
        break;

      default:
        Console.WriteLine("No services available.");
        break;
    }

    Console.Write("Enter number of family members to register: ");
    int count = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= count; i++)
    {
      Console.WriteLine($"Registering member {i}");

      Console.Write("Enter Age: ");
      int memberAge = Convert.ToInt32(Console.ReadLine());

      if (memberAge <= 0)
      {
        Console.WriteLine("Invalid age. Skipping...");
        continue;   // moves to next loop iteration
      }

      if (memberAge < 18)
      {
        Console.WriteLine("Member underage. Stopping registration.");
        break;  // completely exits loop
      }

      Console.WriteLine("Member registered successfully.");
    }


  }
}