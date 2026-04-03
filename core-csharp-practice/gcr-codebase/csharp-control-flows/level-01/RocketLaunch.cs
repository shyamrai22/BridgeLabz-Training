using System;

class RocketLaunch {

	static void Main(string[] args) {
	
		Console.Write("Enter a value for countdown : ");
		int num = int.Parse(Console.ReadLine());
		
		Console.WriteLine(num);	
		
		while(num-- > 0) {
		
			Console.WriteLine(num);
		
		}	
	}
}