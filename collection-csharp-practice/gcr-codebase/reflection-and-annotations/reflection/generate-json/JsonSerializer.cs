using System;
using System.Reflection;
using System.Text;

class JsonSerializer
{
  public static string ToJson(object obj)
  {
    if (obj == null)
      return "null";

    Type type = obj.GetType();

    StringBuilder json = new StringBuilder();
    json.Append("{\n");

    FieldInfo[] fields = type.GetFields(
        BindingFlags.Public |
        BindingFlags.NonPublic |
        BindingFlags.Instance
    );

    for (int i = 0; i < fields.Length; i++)
    {
      FieldInfo field = fields[i];

      string name = field.Name;
      object value = field.GetValue(obj);

      json.Append("  \"");
      json.Append(name);
      json.Append("\": ");

      // Handle value types
      if (value is string)
      {
        json.Append("\"" + value + "\"");
      }
      else
      {
        json.Append(value);
      }

      if (i < fields.Length - 1)
        json.Append(",");

      json.Append("\n");
    }

    json.Append("}");

    return json.ToString();
  }
}
