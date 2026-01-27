using System;
using System.Reflection;
using System.Collections.Generic;

// ----------- Cache Attribute -----------
[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute
{
}

// ----------- Expensive Service ----------
class MathService
{
  [CacheResult]
  public int SlowSquare(int x)
  {
    Console.WriteLine("Computing SlowSquare...");

    // Simulate heavy work using loop
    for (int i = 0; i < 50000000; i++) { }

    return x * x;
  }

  public int FastAdd(int a, int b)
  {
    return a + b;
  }
}

// ----------- Cache Manager --------------
class CacheExecutor
{
  // Stores cached results
  private static Dictionary<string, object> cache =
      new Dictionary<string, object>();

  public static object Execute(object obj, string methodName, params object[] args)
  {
    Type type = obj.GetType();

    MethodInfo method = type.GetMethod(methodName);

    if (method == null)
    {
      Console.WriteLine("Method not found!");
      return null;
    }

    // Check if method has CacheResult
    var attr = method.GetCustomAttribute<CacheResultAttribute>();

    // Create unique cache key
    string key = methodName;

    foreach (var arg in args)
    {
      key += "_" + arg.ToString();
    }

    // If caching enabled
    if (attr != null)
    {
      // Check cache
      if (cache.ContainsKey(key))
      {
        Console.WriteLine("Returning cached result...");
        return cache[key];
      }

      // Compute result
      object result = method.Invoke(obj, args);

      // Store in cache
      cache[key] = result;

      return result;
    }

    // Normal execution (no cache)
    return method.Invoke(obj, args);
  }
}

// ----------- Main App -------------------
class App
{
  static void Main()
  {
    MathService service = new MathService();

    Console.WriteLine("First Call:");
    var r1 = CacheExecutor.Execute(service, "SlowSquare", 5);
    Console.WriteLine("Result: " + r1);

    Console.WriteLine("\nSecond Call (Same Input):");
    var r2 = CacheExecutor.Execute(service, "SlowSquare", 5);
    Console.WriteLine("Result: " + r2);

    Console.WriteLine("\nDifferent Input:");
    var r3 = CacheExecutor.Execute(service, "SlowSquare", 7);
    Console.WriteLine("Result: " + r3);
  }
}
