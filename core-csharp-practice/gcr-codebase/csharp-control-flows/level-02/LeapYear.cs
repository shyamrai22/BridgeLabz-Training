using System;

class LeapYear 
{
	static void Main(string[] args)
	{
		
		Console.Write("Enter a year : ");
		int year = int.Parse(Console.ReadLine());

		if(year < 1582)
		{
			Console.WriteLine("Not applicable");
			return;
		}
		
		if(year % 4 == 0)
		{
			if(year % 100 != 0)
			{
				Console.WriteLine("Leap Year");
			}
			else
			{
				if(year % 400 == 0)
				{
					Console.WriteLine("Leap Year");
				}
				
				else
				{
					Console.WriteLine("Not a leap year");
				}
			}
		}
		else
		{
			Console.WriteLine("Not a leap year");
		}
	
	}
}