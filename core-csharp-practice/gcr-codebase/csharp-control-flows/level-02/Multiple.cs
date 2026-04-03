using System;

class Multiple 
{
	static void Main(string[] args)
	{
		
		Console.Write("Enter a number : ");
		int number = Convert.ToInt32(Console.ReadLine());
				
		for(int i = 100; i >= number ; i--) 
		{
			if(i % number == 0) 
			{
				Console.WriteLine(i);
			}
		}
	}
}