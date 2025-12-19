using System;

class Average {
	
	public static void Main(string[] args) {
			
		Console.WriteLine("Enter three numbers: ");
		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
		int n3 = int.Parse(Console.ReadLine());
			
		Console.WriteLine((n1 + n2 + n3)/3);
	}
}