using System;
using System.Text.RegularExpressions;

class ValidateCard
{
  public static void Start()
  {
    Console.Write("Enter card number --> ");
    string card = Console.ReadLine();

    string pattern = @"^(4\d{15}|5\d{15})$";

    bool isValid = Regex.IsMatch(card, pattern);

    if (isValid)
      Console.WriteLine("Valid Visa/MasterCard");
    else
      Console.WriteLine("Invalid Card");
  }
}
