using System;
using System.Reflection;

class Program
{
  static void Main()
  {
    Calculator calc = new Calculator();

    // Get Type
    Type type = calc.GetType();

    // Get private method "Multiply"
    MethodInfo method = type.GetMethod(
        "Multiply",
        BindingFlags.NonPublic | BindingFlags.Instance
    );

    if (method == null)
    {
      Console.WriteLine("Method not found!");
      return;
    }

    // Invoke method
    object result = method.Invoke(
        calc,
        new object[] { 6, 7 }
    );

    Console.WriteLine("Result: " + result);
  }
}
