using System;

class DoubleOpt {

    static void Main(string[] args) {
	
        Console.Write("Enter a number : ");
        double a = double.Parse(Console.ReadLine());
		
		Console.Write("Enter a number : ");
        double b = double.Parse(Console.ReadLine());
		
		Console.Write("Enter a number : ");
        double c = double.Parse(Console.ReadLine());
		
		double ops1 = (a + b * c);
		double ops2 = (a * b + c);
		double ops3 = (c + (a / b));
		double ops4 = (a % b + c);	
				
		Console.WriteLine($"The results of Double Operations are {ops1}, {ops2}, {ops3} and {ops4}.");
		
    }
}
