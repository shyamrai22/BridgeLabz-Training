using System;

class Calculator
{
    static void Main(string[] args)
    {
        double first, second;
        string ops;

        Console.Write("Enter first number: ");
        first = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        second = double.Parse(Console.ReadLine());

        Console.Write("Enter operator : ");
        ops = Console.ReadLine();

        switch (ops)
		
        {
            case "+":
                Console.WriteLine($"Result: {first + second}");
                break;
				
            case "-":
                Console.WriteLine($"Result: {first - second}");
                break;
				
            case "*":
                Console.WriteLine($"Result: {first * second}");
                break;
				
            case "/":
                if (second != 0) 
				{
                    Console.WriteLine($"Result: {first / second}");
                }
				else 
				{
                    Console.WriteLine("Error: Division by zero is not allowed");
                }
				break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
				
        }
    }
}
