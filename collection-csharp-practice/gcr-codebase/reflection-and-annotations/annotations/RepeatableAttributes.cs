using System;
using System.Reflection;

// ------------- Custom Repeatable Attribute -------------
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
  public string Description { get; }

  public BugReportAttribute(string description)
  {
    Description = description;
  }
}

// ------------- Sample Class ----------------
class SoftwareModule
{
  [BugReport("Crash occurs on startup")]
  [BugReport("Memory leak in background process")]
  public void Run()
  {
    Console.WriteLine("Module is running...");
  }
}

// ------------- Main App ----------------
class App
{
  static void Main()
  {
    // Get method info
    MethodInfo method =
        typeof(SoftwareModule).GetMethod("Run");

    // Get all BugReport attributes
    BugReportAttribute[] reports =
        method.GetCustomAttributes<BugReportAttribute>();

    Console.WriteLine("Bug Reports:");

    foreach (var report in reports)
    {
      Console.WriteLine("- " + report.Description);
    }

    // Run method
    SoftwareModule module = new SoftwareModule();
    module.Run();
  }
}
