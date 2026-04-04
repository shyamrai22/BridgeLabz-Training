using System;
using System.Text.RegularExpressions;

class ValidateHexColorCode
{
  public static void Start()
  {
    Console.Write("Enter code --> ");
    string code = Console.ReadLine();
    string pattern = @"^[#][0-9A-Fa-f]{6}$";
    bool isMatch = Regex.IsMatch(code, pattern);
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