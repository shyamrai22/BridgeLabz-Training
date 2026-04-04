using System;
using System.Collections.Generic;
using System.Reflection;

class ObjectMapper
{
  public static T ToObject<T>(Type clazz, Dictionary<string, object> properties)
  {
    // 1. Create instance dynamically
    object obj = Activator.CreateInstance(clazz);

    // 2. Loop through dictionary
    foreach (var entry in properties)
    {
      string name = entry.Key;
      object value = entry.Value;

      // 3. Try to find field
      FieldInfo field = clazz.GetField(
          name,
          BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance
      );

      if (field != null)
      {
        // Convert type if needed
        object converted = Convert.ChangeType(value, field.FieldType);
        field.SetValue(obj, converted);
        continue;
      }

      // 4. Try to find property
      PropertyInfo prop = clazz.GetProperty(
          name,
          BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance
      );

      if (prop != null && prop.CanWrite)
      {
        object converted = Convert.ChangeType(value, prop.PropertyType);
        prop.SetValue(obj, converted);
      }
    }

    return (T)obj;
  }
}
