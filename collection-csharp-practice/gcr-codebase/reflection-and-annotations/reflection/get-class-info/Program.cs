using System;
using System.Reflection;

class Program
{
  static void Main()
  {
    Console.Write("Enter class name: ");
    string className = Console.ReadLine();

    // Try to get type
    Type type = Type.GetType(className);

    if (type == null)
    {
      Console.WriteLine("Class not found!");
      return;
    }

    Console.WriteLine("\n===== Class Information =====");
    Console.WriteLine("Class Name: " + type.Name);

    // ----------------- Fields -----------------
    Console.WriteLine("\n--- Fields ---");

    FieldInfo[] fields = type.GetFields(
        BindingFlags.Public |
        BindingFlags.NonPublic |
        BindingFlags.Instance |
        BindingFlags.Static);

    foreach (var field in fields)
    {
      Console.WriteLine($"{field.FieldType.Name} {field.Name}");
    }

    // ----------------- Methods -----------------
    Console.WriteLine("\n--- Methods ---");

    MethodInfo[] methods = type.GetMethods(
        BindingFlags.Public |
        BindingFlags.NonPublic |
        BindingFlags.Instance |
        BindingFlags.Static |
        BindingFlags.DeclaredOnly);

    foreach (var method in methods)
    {
      Console.WriteLine(method.Name);
    }

    // ----------------- Constructors -----------------
    Console.WriteLine("\n--- Constructors ---");

    ConstructorInfo[] constructors = type.GetConstructors();

    foreach (var ctor in constructors)
    {
      Console.WriteLine(ctor);
    }
  }
}
