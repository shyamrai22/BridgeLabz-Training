using System;
using System.Text.RegularExpressions;

class ValidateLicensePlateNumber
{
  public static void Start()
  {
    Console.Write("Enter license number --> ");
    string licenseNumber = Console.ReadLine();
    string pattern = @"^[A-Z]{2}[0-9]{4}$";
    bool isMatch = Regex.IsMatch(licenseNumber, pattern);
    if (isMatch)
    {
      Console.WriteLine("correct");
    }
    else
    {
      Console.WriteLine("incorrect");
    }
  }
}