using System;
using System.Text.RegularExpressions;
using System.Linq;

class ExtractLanguages
{
  public static void Start()
  {
    string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";

    string[] languages = { "Java", "Python", "JavaScript", "Go" };

    // Step 1: Extract all words
    MatchCollection words = Regex.Matches(text, @"\b[a-zA-Z]+\b");

    // Step 2: Filter using array
    foreach (Match match in words)
    {
      string word = match.Value;

      if (languages.Contains(word))
      {
        Console.WriteLine(word);
      }
    }
  }
}
