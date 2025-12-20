using System;

class DistanceConverter{

    static void Main(string[] args) {
	
        Console.Write("Enter the distance in feet : ");
        double feet = double.Parse(Console.ReadLine());
		
		double yard = feet / 3;
		double miles = yard / 1760;
		
        Console.WriteLine($"Your distance in miles is {(miles):2} miles and yard is {yard} yards");
		
    }
}
