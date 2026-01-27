using System;
using System.Reflection;

// ----------- Custom Attribute -----------
[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
  public int Value { get; }

  public MaxLengthAttribute(int value)
  {
    Value = value;
  }
}

// ----------- User Class -----------------
class User
{
  [MaxLength(10)]
  public string Username;

  public User(string username)
  {
    // Validate using Reflection
    Validate(username);

    Username = username;
  }

  private void Validate(string username)
  {
    Type type = this.GetType();

    // Get field info
    FieldInfo field = type.GetField("Username");

    // Get MaxLength attribute
    MaxLengthAttribute attr =
        field.GetCustomAttribute<MaxLengthAttribute>();

    if (attr != null)
    {
      if (username.Length > attr.Value)
      {
        throw new ArgumentException(
            $"Username cannot be longer than {attr.Value} characters."
        );
      }
    }
  }
}

// ----------- Main App -------------------
class App
{
  static void Main()
  {
    try
    {
      // Valid user
      User u1 = new User("Shyam123");
      Console.WriteLine("User created: " + u1.Username);

      // Invalid user (too long)
      User u2 = new User("VeryLongUsername123");
      Console.WriteLine("User created: " + u2.Username);
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine("Error: " + ex.Message);
    }
  }
}
