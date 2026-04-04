using System;
using System.Text.RegularExpressions;

class CensorWords
{
  public static void Start()
  {
    string text = "This is a damn bad example with some stupid words.";

    // List of bad words
    string[] badWords = { "damn", "stupid" };

    // Join into regex pattern
    string pattern = @"\b(" + string.Join("|", badWords) + @")\b";

    string result = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);

    Console.WriteLine(result);
  }
}
