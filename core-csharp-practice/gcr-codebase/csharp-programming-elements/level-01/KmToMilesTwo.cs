using System;

class KmToMilesTwo {

	static void Main(string[] args) {
	
		double km = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"The total miles is {km * 0.621371} mile for the given {km} km");
		
	}

}