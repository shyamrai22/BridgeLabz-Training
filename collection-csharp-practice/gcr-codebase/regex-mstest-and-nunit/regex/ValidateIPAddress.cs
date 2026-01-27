using System;
using System.Text.RegularExpressions;

class ValidateIPAddress
{
  public static void Start()
  {
    Console.Write("Enter IP Address --> ");
    string ip = Console.ReadLine();

    string pattern =
        @"^(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9][0-9]|[0-9])" +
        @"(\.(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9][0-9]|[0-9])){3}$";

    bool isValid = Regex.IsMatch(ip, pattern);

    if (isValid)
      Console.WriteLine("Valid IP Address");
    else
      Console.WriteLine("Invalid IP Address");
  }
}
