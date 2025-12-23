using System;

class NaturalNumber {

	static void Main(string[] args) {
	
		Console.Write("Enter a number : ");
		int num1 = int.Parse(Console.ReadLine());
				
		if(num1 > 0 ) {
		
			int sum = num1 * (num1 + 1)/2;
			Console.WriteLine($"The sum of {num1} natural numbers is {sum}");
		
		}
		
		else {
			
			Console.WriteLine($"The number {num1} is not a natural number");
		
		}
	
	}
}