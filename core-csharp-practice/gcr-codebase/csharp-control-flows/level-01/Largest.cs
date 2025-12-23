using System;

class Largest {

	static void Main(string[] args) {
	
		Console.Write("Enter a number1 : ");
		int num1 = int.Parse(Console.ReadLine());
		
		Console.Write("Enter a number2 : ");
		int num2 = int.Parse(Console.ReadLine());
		
		Console.Write("Enter a number3 : ");
		int num3 = int.Parse(Console.ReadLine());
		
		if(num1 > num2 && num1 > num3) {
		
			Console.WriteLine($"Is the first number the largest? True");
		
		}
		
		else {
		
			Console.WriteLine($"Is the first number the largest? False");
			
		}
		
		if(num2 > num1 && num2 > num3) {
			
			Console.WriteLine($"Is the second number the largest? True");
		
		}
		
		else {
		
			Console.WriteLine($"Is the second number the largest? False");
			
		}
		
		if((num3 > num1 && num3 > num2)) {
			
			Console.WriteLine($"Is the third number the largest? True");
		
		}
		
		else {
		
			Console.WriteLine($"Is the first number the largest? False");
			
		}
	
	}
}