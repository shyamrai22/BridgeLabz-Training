using System;
using System.Reflection;

class Program
{
  static void Main()
  {
    // Get Type
    Type type = typeof(Configuration);

    // Get private static field
    FieldInfo field = type.GetField(
        "API_KEY",
        BindingFlags.NonPublic | BindingFlags.Static
    );

    if (field == null)
    {
      Console.WriteLine("Field not found!");
      return;
    }

    // Get old value (null because static)
    string oldKey = (string)field.GetValue(null);
    Console.WriteLine("Old API Key: " + oldKey);

    // Modify value
    field.SetValue(null, "NEW_SECRET_KEY_999");

    // Get new value
    string newKey = (string)field.GetValue(null);
    Console.WriteLine("New API Key: " + newKey);

    // Verify via normal method
    Configuration.ShowKey();
  }
}
