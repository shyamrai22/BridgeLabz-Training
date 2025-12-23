using System;

class Bonus
{
    static void Main(string[] args)
    {
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter years of service: ");
        int years = int.Parse(Console.ReadLine());

        double bonus = 0;

        if (years > 5)
        {
            bonus = salary * 0.05;
            Console.WriteLine($"Bonus amount is: {bonus}");
        }
        else
        {
            Console.WriteLine("No bonus applicable.");
        }
    }
}
