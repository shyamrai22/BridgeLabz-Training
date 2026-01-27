using System;
using System.Reflection;

class Program
{
  static void Main()
  {
    MathOperations math = new MathOperations();

    Type type = math.GetType();

    Console.Write("Enter method name (Add/Subtract/Multiply): ");
    string methodName = Console.ReadLine();

    Console.Write("Enter first number: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Enter second number: ");
    int b = int.Parse(Console.ReadLine());

    // Find method
    MethodInfo method = type.GetMethod(
        methodName,
        BindingFlags.Public | BindingFlags.Instance
    );

    if (method == null)
    {
      Console.WriteLine("Invalid method name!");
      return;
    }

    // Invoke method
    object result = method.Invoke(
        math,
        new object[] { a, b }
    );

    Console.WriteLine("Result: " + result);
  }
}
