using System;

class SimpleIntrest {
    static void Main(string[] args) {
        
        Console.Write("Enter the principal amount : ");
        double principal = int.Parse(Console.ReadLine());
		
		Console.Write("Enter the rate of intrest : ");
        double rate = int.Parse(Console.ReadLine());
		
		Console.Write("Enter the time : ");
        double time = int.Parse(Console.ReadLine());        
		
		double si = (principal * rate * time) / 100.0;
        Console.WriteLine($"The Simple Interest is {si} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    
	}
}
