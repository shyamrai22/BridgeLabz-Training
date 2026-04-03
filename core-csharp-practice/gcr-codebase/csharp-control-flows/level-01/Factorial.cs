using System;

class Factorial
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Negative numbers.");
            return;
        }

        int fac = 1;
        int i = 1;

        while (i <= num)
        {
            fac *= i;
            i++;
        }

        Console.WriteLine($"Factorial of {num} is {fac}");
    }
}
