using System;

class Rounds {

    static void Main(string[] args) {
	
        Console.Write("Enter side1 : ");
        int side1 = int.Parse(Console.ReadLine());
		
		Console.Write("Enter side2 : ");
        int side2 = int.Parse(Console.ReadLine());
		
		Console.Write("Enter side3 : ");
        int side3 = int.Parse(Console.ReadLine());
		
		int perimeter = side1 + side2 + side3;
		int rounds = 5000 / perimeter;
			
		Console.WriteLine($" The total number of rounds the athlete will run is {rounds} to complete 5 km");
		
    }
}
