using System;
using System.Text.RegularExpressions;

class FindRepeatingWords
{
  public static void Start()
  {
    string text = "This is is a repeated repeated word test.";

    string pattern = @"\b(\w+)\b\s+\1\b";

    MatchCollection matches = Regex.Matches(
        text,
        pattern,
        RegexOptions.IgnoreCase
    );

    foreach (Match match in matches)
    {
      // Group 1 contains the repeated word
      Console.WriteLine(match.Groups[1].Value);
    }
  }
}
