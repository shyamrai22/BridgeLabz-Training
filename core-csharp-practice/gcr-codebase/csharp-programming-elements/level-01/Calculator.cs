using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double add = num1 + num2;
        double sub = num1 - num2;
        double mul = num1 * num2;
        double div = num1 / num2;

        Console.WriteLine(
            $"The add, sub, mul and div value of 2 numbers {num1} and {num2} is {add}, {sub}, {mul}, and {div}"
        );
    }
}
