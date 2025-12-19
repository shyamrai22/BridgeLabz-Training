using System;

class Power {
	
	public static void Main(string[] args) {
			
		Console.WriteLine("Enter two numbers: ");
		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
			
		Console.WriteLine(Math.Pow(n1,n2));
	}
}