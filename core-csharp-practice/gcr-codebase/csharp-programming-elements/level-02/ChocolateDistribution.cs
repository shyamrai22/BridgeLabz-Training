using System;

class ChocolateDistribution
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        if (numberOfChildren <= 0)
        {
            Console.WriteLine("Number of children must be greater than zero.");
            return;
        }

        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}");
    
	}
}
