using System;

class CheckNumber {

	static void Main(string[] args) {
	
		Console.Write("Enter a number : ");
		int num = int.Parse(Console.ReadLine());
				
		if(num > 0) {
			Console.WriteLine("positive");
		}
		
		else if(num < 0) {
			Console.WriteLine("negative");
		}
		
		else {
			Console.WriteLine("zero");
		}
	
	}
}