using System;

class CanVote {

	static void Main(string[] args) {
	
		Console.Write("Enter the age of the person : ");
		int age = int.Parse(Console.ReadLine());
				
		if(age >= 18) {
			Console.WriteLine($"The person's age is {age} and can vote.");
		}
		
		else {
			Console.WriteLine($"The person's age is {age} and cannot vote.");
		}
	
	}
}