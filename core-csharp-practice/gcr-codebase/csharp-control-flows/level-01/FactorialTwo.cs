using System;

class FactorialTwo
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num <= 0)
        {
            Console.WriteLine("Negative number");
            return;
        }

        long fac = 1;

        for (int i = 1; i <= num; i++)
        {
            fac *= i;
        }

        Console.WriteLine($"Factorial of {num} is {fac}");
    }
}
