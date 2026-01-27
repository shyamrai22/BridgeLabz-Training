using System;
using System.Reflection;

// ----------- Custom Attribute -----------
[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
  public string Level { get; }

  // Optional parameter with default value
  public ImportantMethodAttribute(string level = "HIGH")
  {
    Level = level;
  }
}

// ----------- Sample Class -----------
class ReportService
{
  [ImportantMethod] // Uses default: HIGH
  public void GenerateReport()
  {
    Console.WriteLine("Generating report...");
  }

  [ImportantMethod("MEDIUM")] // Custom level
  public void ExportReport()
  {
    Console.WriteLine("Exporting report...");
  }

  public void ViewReport()
  {
    Console.WriteLine("Viewing report...");
  }
}

// ----------- Main App -----------
class App
{
  static void Main()
  {
    Type type = typeof(ReportService);

    Console.WriteLine("Important Methods:\n");

    // Get all methods
    MethodInfo[] methods = type.GetMethods(
        BindingFlags.Public |
        BindingFlags.Instance |
        BindingFlags.DeclaredOnly
    );

    foreach (var method in methods)
    {
      // Check if ImportantMethod is applied
      ImportantMethodAttribute attr =
          method.GetCustomAttribute<ImportantMethodAttribute>();

      if (attr != null)
      {
        Console.WriteLine(
            $"Method: {method.Name}, Level: {attr.Level}"
        );
      }
    }
  }
}
