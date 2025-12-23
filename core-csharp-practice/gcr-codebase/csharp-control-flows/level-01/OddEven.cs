using System;

class OddEven
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

        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} : Even number");
            }
            else
            {
                Console.WriteLine($"{i} : Odd number");
            }
        }
    }
}
