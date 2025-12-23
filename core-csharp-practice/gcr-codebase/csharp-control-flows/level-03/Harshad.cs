using System;

class Harshad 
{
	static void Main(string[] args)
	{
		
		Console.Write("Enter a number : ");
		string numStr = Console.ReadLine();
		int num = Convert.ToInt32(numStr);
		int temp = num;
		int sum = 0;
		int dig = 0;
		
		if(num == 0) 
		{
			Console.WriteLine("number is invalid");
			return;
		}
				
		while(temp != 0) 
		{
			dig = temp % 10;
			sum += dig; 
			temp = temp / 10;
		}
		
		if(num % sum == 0) 
		{
			Console.WriteLine("Harshad number");
		}
		else 
		{
			Console.WriteLine("Not a harshad number");
		}
		
	}
}