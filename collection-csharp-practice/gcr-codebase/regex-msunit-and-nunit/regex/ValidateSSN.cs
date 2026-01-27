using System;
using System.Text.RegularExpressions;

class ValidateSSN
{
  public static void Start()
  {
    Console.Write("Enter SSN --> ");
    string ssn = Console.ReadLine();

    string pattern = @"^\d{3}-\d{2}-\d{4}$";

    bool isValid = Regex.IsMatch(ssn, pattern);

    if (isValid)
      Console.WriteLine("Valid SSN");
    else
      Console.WriteLine("Invalid SSN");
  }
}
