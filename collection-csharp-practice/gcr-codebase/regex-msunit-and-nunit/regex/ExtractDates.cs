using System;
using System.Text.RegularExpressions;

class ExtractDates
{
  public static void Start()
  {
    string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";

    string pattern = @"\d{2}/\d{2}/\d{4}";

    MatchCollection matches = Regex.Matches(text, pattern);

    foreach (Match match in matches)
    {
      Console.WriteLine(match.Value);
    }
  }
}
