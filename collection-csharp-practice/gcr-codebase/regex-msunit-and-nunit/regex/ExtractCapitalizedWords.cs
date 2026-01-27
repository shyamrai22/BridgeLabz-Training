using System;
using System.Text.RegularExpressions;

class ExtractCapitalizedWords
{
  public static void Start()
  {
    string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

    string pattern = @"[A-Z][a-z]+";

    MatchCollection matches = Regex.Matches(text, pattern);

    foreach (Match match in matches)
    {
      Console.WriteLine(match.Value);
    }
  }
}
