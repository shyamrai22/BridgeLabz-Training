using System;

class TotalTwo {

	static void Main(string[] args) {
	
		double total = 0.0;
		double user = 0.0;
	
		while(true) {
			
			Console.Write("Enter a number : ");
			user =  Convert.ToDouble(Console.ReadLine());
		
			if(user > 0) {	
				total += user;
			}
		
			else {	
				break;
			}
		}
		
		Console.WriteLine(total);
	}
}