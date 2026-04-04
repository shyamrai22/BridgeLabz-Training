using System;
using System.Text.RegularExpressions;

class ExtractLinks
{
  public static void Start()
  {
    string text = "Visit https://www.google.com and http://example.org for more info.";

    string pattern = @"https?://[a-zA-Z0-9.-]+";

    MatchCollection matches = Regex.Matches(text, pattern);

    foreach (Match match in matches)
    {
      Console.WriteLine(match.Value);
    }
  }
}
