using System;
using System.Text.RegularExpressions;

class ValidateUsername
{
  public static void Start()
  {
    Console.Write("Enter username --> ");
    string username = Console.ReadLine();
    string pattern = @"^[a-zA-Z][a-zA-z0-9_]{4,14}$";
    bool isMatch = Regex.IsMatch(username, pattern);
    if (isMatch)
    {
      Console.WriteLine("correct username");
    }
    else
    {
      Console.WriteLine("incorrect username");
    }
  }
}