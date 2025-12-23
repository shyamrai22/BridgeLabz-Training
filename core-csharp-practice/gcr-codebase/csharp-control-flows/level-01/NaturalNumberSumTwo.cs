using System;

class NaturalNumberSumTwo
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        int formula = n * (n + 1) / 2;
        int loop = 0;
        for (int i = 1; i <= n; i++)
        {
            loop += i;
        }

        Console.WriteLine($"Sum using formula: {formula}");
        Console.WriteLine($"Sum using for loop: {loop}");

        if (formula == loop)
        {
            Console.WriteLine("Match");
        }
        else
        {
            Console.WriteLine("Mismatch");
        }
    }
}
