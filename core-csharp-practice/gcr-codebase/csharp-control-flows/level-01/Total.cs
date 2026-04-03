using System;

class Total {

	static void Main(string[] args) {
	
		double total = 0.0;
		
		Console.Write("Enter a number ");
		double user =  Convert.ToDouble(Console.ReadLine());
		
		while(user != 0) {
		
			total += user;
			Console.Write("Enter a number ");
			user =  Convert.ToDouble(Console.ReadLine());
		
		}
		
		Console.WriteLine(total);
	}
}