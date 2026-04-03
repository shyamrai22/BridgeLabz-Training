using System;

class IntOperations{

    static void Main(string[] args) {
	
        Console.Write("Enter a number : ");
        int a = int.Parse(Console.ReadLine());
		
		Console.Write("Enter a number : ");
        int b = int.Parse(Console.ReadLine());
		
		Console.Write("Enter a number : ");
        int c = int.Parse(Console.ReadLine());
		
		int ops1 = (a + b * c);
		int ops2 = (a * b + c);
		int ops3 = (c + (a / b));
		int ops4 = (a % b + c);	
				
		Console.WriteLine($"The results of Int Operations are {ops1}, {ops2}, {ops3} and {ops4}.");
		
    }
}
