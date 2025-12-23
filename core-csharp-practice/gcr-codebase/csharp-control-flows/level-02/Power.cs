using System;

class Power 
{
	static void Main(string[] args)
	{
		
		Console.Write("Enter a number : ");
		int number = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter its power : ");
		int exponent = Convert.ToInt32(Console.ReadLine());
		int result = 1;
		
		for(int i = 1; i <= exponent; i++) 
		{
			result *= number;
		}
		
		Console.WriteLine(result);	
		
	}
}