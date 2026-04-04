using System;
using System.Reflection;
using System.Text;

// ----------- Custom Serialization Attribute -----------
[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
  public string Name { get; set; }
}

// ----------- User Class ----------------
class User
{
  [JsonField(Name = "user_name")]
  public string Username;

  [JsonField(Name = "age")]
  public int Age;

  public string Password; // Not serialized (no attribute)
}

// ----------- JSON Serializer -----------
class SimpleJsonSerializer
{
  public static string ToJson(object obj)
  {
    Type type = obj.GetType();

    StringBuilder json = new StringBuilder();
    json.Append("{\n");

    FieldInfo[] fields = type.GetFields(
        BindingFlags.Public |
        BindingFlags.Instance
    );

    bool first = true;

    foreach (var field in fields)
    {
      // Read JsonField attribute
      JsonFieldAttribute attr =
          field.GetCustomAttribute<JsonFieldAttribute>();

      // Skip fields without attribute
      if (attr == null)
        continue;

      if (!first)
        json.Append(",\n");

      first = false;

      string jsonName = attr.Name;
      object value = field.GetValue(obj);

      json.Append("  \"");
      json.Append(jsonName);
      json.Append("\": ");

      // Handle string vs number
      if (value is string)
      {
        json.Append("\"" + value + "\"");
      }
      else
      {
        json.Append(value);
      }
    }

    json.Append("\n}");

    return json.ToString();
  }
}

// ----------- Main App ------------------
class App
{
  static void Main()
  {
    User user = new User
    {
      Username = "Shyam",
      Age = 22,
      Password = "secret123"
    };

    string json = SimpleJsonSerializer.ToJson(user);

    Console.WriteLine("Serialized JSON:\n");
    Console.WriteLine(json);
  }
}
