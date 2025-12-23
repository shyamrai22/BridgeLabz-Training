using System;

class Smallest {

	static void Main(string[] args) {
	
		Console.Write("Enter a number1 : ");
		int num1 = int.Parse(Console.ReadLine());
		
		Console.Write("Enter a number2 : ");
		int num2 = int.Parse(Console.ReadLine());
		
		Console.Write("Enter a number3 : ");
		int num3 = int.Parse(Console.ReadLine());
		
		if(num1 < num2 && num1 < num3) {
		
			Console.WriteLine($"Is the first number the smallest? True");
		
		}
		
		else {
			
			Console.WriteLine($"Is the first number the smallest? False");
		
		}
	
	}
}