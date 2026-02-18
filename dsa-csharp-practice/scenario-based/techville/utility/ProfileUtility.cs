using System.Text.RegularExpressions;

namespace TechVille.Utility
{
  public static class ProfileUtility
  {
    public static string FormatName(string name)
    {
      if (string.IsNullOrWhiteSpace(name))
        return name;

      name = name.Trim().ToLower();
      return char.ToUpper(name[0]) + name.Substring(1);
    }

    public static bool ValidateEmail(string email)
    {
      string pattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
      return Regex.IsMatch(email, pattern);
    }

    public static bool NameContains(string source, string search)
    {
      return source.ToLower().Contains(search.ToLower());
    }
  }
}
