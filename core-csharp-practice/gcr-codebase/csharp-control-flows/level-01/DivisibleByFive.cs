using System;

class DivisibleByFive {

	static void Main(string[] args) {
	
		Console.Write("Enter a number : ");
		int num = int.Parse(Console.ReadLine());
		
		if(num % 5 == 0) {
		
			Console.WriteLine($"Is the number {num} divisible by 5? True");
		
		}
		else {
			
			Console.WriteLine($"Is the number {num} divisible by 5? False");
		
		}
	
	}
}