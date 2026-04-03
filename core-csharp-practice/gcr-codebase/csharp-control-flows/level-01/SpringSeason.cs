using System;

class SpringSeason {
	
	static void Main(string[] args) {
			
		int month = int.Parse(args[0]);	
		int date = int.Parse(args[1]);
				
		if((month >= 3 && date >=20) && (month <= 6 && date <= 20)) {
			Console.WriteLine("Its a Spring Season");
		}
		
		else {
			Console.WriteLine("Not a Spring Season");
		}
		
	}
}