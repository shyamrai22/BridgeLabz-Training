using System;
using System.Reflection;

// ----------- Custom Todo Attribute -----------
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
  public string Task { get; }
  public string AssignedTo { get; }
  public string Priority { get; }

  // Priority has default value
  public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
  {
    Task = task;
    AssignedTo = assignedTo;
    Priority = priority;
  }
}

// ----------- Sample Project Class -----------
class ProjectFeatures
{
  [Todo("Implement login validation", "Shyam", "HIGH")]
  [Todo("Add password reset feature", "Amit")]
  public void UserAuthentication()
  {
    Console.WriteLine("User authentication module");
  }

  [Todo("Optimize database queries", "Ravi", "LOW")]
  public void DataProcessing()
  {
    Console.WriteLine("Data processing module");
  }

  public void Reporting()
  {
    Console.WriteLine("Reporting module");
  }
}

// ----------- Main App -----------
class App
{
  static void Main()
  {
    Type type = typeof(ProjectFeatures);

    Console.WriteLine("Pending Tasks:\n");

    // Get all methods
    MethodInfo[] methods = type.GetMethods(
        BindingFlags.Public |
        BindingFlags.Instance |
        BindingFlags.DeclaredOnly
    );

    foreach (var method in methods)
    {
      // Get all Todo attributes on this method
      TodoAttribute[] todos =
          method.GetCustomAttributes<TodoAttribute>();

      foreach (var todo in todos)
      {
        Console.WriteLine($"Method: {method.Name}");
        Console.WriteLine($"  Task      : {todo.Task}");
        Console.WriteLine($"  Assigned  : {todo.AssignedTo}");
        Console.WriteLine($"  Priority  : {todo.Priority}");
        Console.WriteLine();
      }
    }
  }
}
