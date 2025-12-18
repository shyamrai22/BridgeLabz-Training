using System;

class SimpleIntrest {
	
	public static void Main(string[] args) {
	
		Console.WriteLine("Enter Principle Amount, Rate of Intrest and Time Duration : ");
		double p = Convert.ToDouble(Console.ReadLine());
		double r = Convert.ToDouble(Console.ReadLine());
		double t = Convert.ToDouble(Console.ReadLine());
		
		double si = (p * r * t)/100;
		Console.Write("Simple Intrest : " + si);
		
	}
	
}