using System;
using System.Reflection;

// ---------------- Custom Attribute ----------------
[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
  public string Priority { get; }
  public string AssignedTo { get; }

  public TaskInfoAttribute(string priority, string assignedTo)
  {
    Priority = priority;
    AssignedTo = assignedTo;
  }
}

// ---------------- Task Manager ----------------
class TaskManager
{
  [TaskInfo("High", "Shyam")]
  public void CompleteProject()
  {
    Console.WriteLine("Project completed.");
  }
}

// ---------------- Main App ----------------
class App
{
  static void Main()
  {
    // Get type of TaskManager
    Type type = typeof(TaskManager);

    // Get method info
    MethodInfo method = type.GetMethod("CompleteProject");

    // Get TaskInfo attribute
    TaskInfoAttribute info =
        method.GetCustomAttribute<TaskInfoAttribute>();

    if (info != null)
    {
      Console.WriteLine("Task Details:");
      Console.WriteLine("Priority: " + info.Priority);
      Console.WriteLine("Assigned To: " + info.AssignedTo);
    }

    // Call the method
    TaskManager manager = new TaskManager();
    manager.CompleteProject();
  }
}
