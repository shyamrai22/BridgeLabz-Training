using System;

class Abundant 
{
	static void Main(string[] args)
	{
		
		Console.Write("Enter a number : ");
		string numStr = Console.ReadLine();
		int num = Convert.ToInt32(numStr);
		int sum = 0;
		
		for(int i = 1; i <= (num / 2) ; i++) 
		{
			if(num % i == 0) 
			{
				sum += i;
			}
		}
		
		if(sum > num) 
		{
			Console.WriteLine("Abundant number");
		}
		else 
		{
			Console.WriteLine("Not an abundant number");
		}
		
	}
}