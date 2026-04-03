using System;

class RocketLaunchTwo {

	static void Main(string[] args) {
	
		Console.Write("Enter a value for countdown : ");
		int num = int.Parse(Console.ReadLine());
		
		for(int i = num; num >= 0; num--) {
		
			Console.WriteLine(num);
		
		}	
	}
}