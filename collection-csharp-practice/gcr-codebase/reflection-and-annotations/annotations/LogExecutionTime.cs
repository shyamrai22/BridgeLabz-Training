using System;
using System.Diagnostics;
using System.Reflection;

// ----------- Custom Attribute -----------
[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute
{
}

// ----------- Sample Class -----------
class PerformanceTester
{
  [LogExecutionTime]
  public void FastMethod()
  {
    for (int i = 0; i < 1000000; i++) { }
  }

  [LogExecutionTime]
  public void SlowMethod()
  {
    // Time-consuming loop instead of Thread.Sleep
    for (int i = 0; i < 50000000; i++)
    {
      // Just wasting time
    }
  }

  public void NormalMethod()
  {
    Console.WriteLine("Normal method (no logging)");
  }
}

// ----------- Helper for Execution -----------
class MethodExecutor
{
  public static void ExecuteWithLogging(object obj, string methodName)
  {
    Type type = obj.GetType();

    MethodInfo method = type.GetMethod(methodName);

    if (method == null)
    {
      Console.WriteLine("Method not found!");
      return;
    }

    var attr = method.GetCustomAttribute<LogExecutionTimeAttribute>();

    if (attr != null)
    {
      Stopwatch sw = new Stopwatch();

      sw.Start();

      method.Invoke(obj, null);

      sw.Stop();

      Console.WriteLine(
          $"Method {method.Name} took {sw.ElapsedMilliseconds} ms\n"
      );
    }
    else
    {
      method.Invoke(obj, null);
    }
  }
}

// ----------- Main App -----------
class App
{
  static void Main()
  {
    PerformanceTester tester = new PerformanceTester();

    MethodExecutor.ExecuteWithLogging(tester, "FastMethod");
    MethodExecutor.ExecuteWithLogging(tester, "SlowMethod");
    MethodExecutor.ExecuteWithLogging(tester, "NormalMethod");
  }
}
