using System;
using System.Reflection;

class Program
{
  static void Main()
  {
    // Get Type
    Type type = typeof(Book);

    // Get Author attribute
    AuthorAttribute author =
        type.GetCustomAttribute<AuthorAttribute>();

    if (author != null)
    {
      Console.WriteLine("Author: " + author.Name);
    }
    else
    {
      Console.WriteLine("No Author attribute found.");
    }
  }
}
