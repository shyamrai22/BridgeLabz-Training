using System;

class FizzBuzzTwo 
{
	static void Main(string[] args)
	{
		
		Console.Write("Enter a number : ");
		int num = int.Parse(Console.ReadLine());
		int i = 0;
		
		if(num <= 0) 
		{
			Console.WriteLine("Not a positive integer");
			return;
		}
		
		while(i <= num)
		{	
	
			if(i % 5 == 0 && i % 3 == 0)
			{
				Console.WriteLine("FizzBuzz");
			}
			else if(i % 3 == 0)
			{
				Console.WriteLine("Fizz");
			}
			
			else if(i % 5 == 0)
			{
				Console.WriteLine("Buzz");
			}
			
			else
			{
				Console.WriteLine(i);
			}
			i++;			
		}
	}
}